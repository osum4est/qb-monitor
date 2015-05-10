using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Quickbooks_Monitor
{
    class XmlHandler
    {
        string path = "settings.xml";

        XmlSerializer serializer;
        public static XmlHandler Current;

        public XmlHandler()
        {
            serializer = new XmlSerializer(typeof(Settings));
            Current = this;
            CreateXml();
        }

        public void CreateXml()
        { 
            Settings settings = new Settings();

            try
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                XmlReader reader = new XmlTextReader(fs);
                serializer.CanDeserialize(reader);
                reader.Close();
            }
            catch
            {

                FrmSetDirectory frmSetDirectory = new FrmSetDirectory();
                frmSetDirectory.ShowDialog();

                if (frmSetDirectory.DialogResult == System.Windows.Forms.DialogResult.OK)
                    settings.directory = frmSetDirectory.GetDirectory();
                else
                    Environment.Exit(0);

                settings.minimizeWarning = true;
                settings.autoSearch = true;
                settings.startMinimized = false;
                settings.openAll = false;

                Write(settings);
            }

        }

        public Settings Read()
        {
            Settings settings = new Settings();

            FileStream fs = new FileStream(path, FileMode.Open);

            settings = (Settings)serializer.Deserialize(fs);

            fs.Dispose();
            return settings;
        }


        public void Write(Settings settings)
        {
            TextWriter writer = new StreamWriter(path);
            serializer.Serialize(writer, settings);

            writer.Dispose();
        }
    }
}
