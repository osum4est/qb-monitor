using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quickbooks_Monitor
{
    public partial class FrmMain : Form
    {
        public static Settings settings;

        public static List<string> broken;
        public static List<string> inUse;
        public static List<string> notInUse;

        DateTime lastUpdate;

        public FrmMain()
        {
            InitializeComponent();
            broken = new List<string>();
            inUse = new List<string>();
            notInUse = new List<string>();

            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            XmlHandler xml = new XmlHandler();
            settings = xml.Read();

            Update();

            if (settings.autoSearch)
                FileSystemWatcher();

            this.ShowInTaskbar = false;
            if (settings.startMinimized)
                this.WindowState = FormWindowState.Minimized;
        }

        static bool InUse(string path)
        {
            bool inUse = true;

            DateTime qbw = File.GetLastWriteTime(path);
            DateTime dsn = File.GetLastWriteTime(path + ".dsn");
            DateTime nd = File.GetLastWriteTime(path + ".nd");
            DateTime tlg = File.GetLastWriteTime(path + ".tlg");

            if (qbw - tlg < new TimeSpan(0, 1, 0))
            {
                if (dsn <= qbw)
                {
                    inUse = false;
                }
            }

            return inUse;
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                if (settings.minimizeWarning)
                {
                    MessageBox.Show("Minimizing the application will send it to the system tray. Double click on the tray icon to open the window back up. Right-clicking on the icon will show the files currently in use as well as an Open Window option and the ability to completely exit the program. This message will not show again.");
                    settings.minimizeWarning = false;
                    XmlHandler.Current.Write(settings);
                }
                trayIcon.Visible = true;
                this.Hide();
            }
        }

        public void OpenWindow()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenWindow();
        }

        public void LoadTrayIcon(NotifyIcon trayIcon)
        {
            ContextMenu cm = new ContextMenu();

            notInUse.Sort();
            inUse.Sort();

            List<string> all = new List<string>();
            all = notInUse.Concat(inUse).ToList();
            all.Sort();

            if (!settings.openAll)
            {
                cm.MenuItems.Add(new MenuItem
                    {
                        Enabled = false,
                        Text = "Available Quickbooks:",
                        DefaultItem = true
                    });

                for (int i = 0; i < notInUse.Count; i++)
                {
                    MenuItem mi = new MenuItem();
                    mi.Text = notInUse[i];
                    mi.Click += new EventHandler(Available_ItemClicked);
                    cm.MenuItems.Add(mi);
                }

                cm.MenuItems.Add("-");

                cm.MenuItems.Add(new MenuItem
                {
                    Enabled = false,
                    Text = "QuickBooks in use:",
                    //DefaultItem = true
                });

                for (int i = 0; i < inUse.Count; i++)
                {
                    MenuItem mi = new MenuItem();
                    mi.Text = inUse[i];
                    mi.Enabled = false;

                    cm.MenuItems.Add(mi);
                }
            }
            else
            {
                cm.MenuItems.Add(new MenuItem
                {
                    Enabled = false,
                    Text = "Available Quickbooks:",
                    DefaultItem = true
                });

                for (int i = 0; i < all.Count; i++)
                {
                    MenuItem mi = new MenuItem();
                    mi.Text = all[i];
                    mi.Click += new EventHandler(Available_ItemClicked);
                    cm.MenuItems.Add(mi);
                }
            }

            cm.MenuItems.Add("-");
            cm.MenuItems.Add("Open Window", new EventHandler(Open_ItemClicked));
            cm.MenuItems.Add("Update", new EventHandler(Update_ItemClicked));
            cm.MenuItems.Add("-");
            cm.MenuItems.Add("Exit", new EventHandler(Exit_ItemClicked));

            trayIcon.ContextMenu = cm;
        }

        private void Available_ItemClicked(object sender, EventArgs e)
        {
            string file = (sender as MenuItem).Text;
            string[] files = Directory.GetFiles(Settings.Current.directory, "*.qbw", SearchOption.AllDirectories);
            for (int i = 0; i < files.Length; i++)
            {
                if (Path.GetFileNameWithoutExtension(files[i]) == file)
                    System.Diagnostics.Process.Start(files[i]);
            }
            

        }

        private void Update_ItemClicked(object sender, EventArgs e)
        {
            Update();
        }

        private void Exit_ItemClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Open_ItemClicked(object sender, EventArgs e)
        {
            OpenWindow();
        }

        private void tbQBFiles_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            DialogResult result = frmSettings.ShowDialog();
            Update();
            if (result != DialogResult.Cancel)
                Update();

        }

        new public void Update()
        {

            tbQBFiles.Clear();
            inUse.Clear();
            notInUse.Clear();
            broken.Clear();
            // Index all quickbooks files
            string[] qbFiles = Directory.GetFiles(settings.directory, "*.qbw", SearchOption.AllDirectories);
            string[] qbFolders = Directory.GetDirectories(settings.directory);

            for (int i = 0; i < qbFolders.Length; i++)
            {
                if (qbFiles.Length == 0)
                    broken.Add(qbFolders[i].Split(new char[] { '/', '\\' }).Last());
                for (int j = 0; j < qbFiles.Length; j++)
                {
                    if (qbFiles[j].Contains(qbFolders[i]))
                    {
                        if (InUse(qbFiles[j]))
                            inUse.Add(Path.GetFileNameWithoutExtension(qbFiles[j]));
                        else
                            notInUse.Add(Path.GetFileNameWithoutExtension(qbFiles[j]));
                        break;
                    }

                    if (j == qbFiles.Length - 1)
                        broken.Add(qbFolders[i].Split(new char[] {'/', '\\'}).Last());
                }  
            }

            for (int i = 0; i < inUse.Count; i++)
                tbQBFiles.AppendText(inUse[i], Color.Red);
            for (int i = 0; i < notInUse.Count; i++)
                tbQBFiles.AppendText(notInUse[i], Color.Green);
            for (int i = 0; i < broken.Count; i++)
                tbQBFiles.AppendText(broken[i], Color.Black);

            lastUpdate = DateTime.Now;
            lblUpdated.Text = "Last Manual Update: " + lastUpdate.ToString("hh:mm tt");

            LoadTrayIcon(trayIcon);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [PermissionSet(SecurityAction.Demand, Name="FullTrust")]
        public void FileSystemWatcher()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = Settings.Current.directory;
            watcher.IncludeSubdirectories = true;
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            watcher.Filter = "*.*";

            watcher.Changed += new FileSystemEventHandler(OnChanged);

            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            if (InvokeRequired)
                this.Invoke(new Action(() => Update()));
        }
    }
}
