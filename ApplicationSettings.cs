using System;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace rspo_2023
{
    [Serializable]
    public class ApplicationSettings
    {
        [XmlElement("MachineName")]
        public string MachineName { get; set; }
        
        [XmlElement("ServerClass")]
        public string ServerClass { get; set; }

        [XmlElement("UpdateRate")]
        public int UpdateRate { get; set; }

        [XmlElement("OPCTags")]
        public List<string> OPCTags { get; set; }

        public ApplicationSettings()
        {
            MachineName = "127.0.0.1";
            ServerClass = "Kepware.KEPServerEX.V6";
            UpdateRate = 1000;
            
            OPCTags = new List<string>();            
            OPCTags.Add("Simulation Examples.Functions.Ramp1");
            OPCTags.Add("Simulation Examples.Functions.Sine1");
            OPCTags.Add("Simulation Examples.Functions.Random1");
        }

        public void DeserializeFromString(String stringData)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
                using (TextReader reader = new StringReader(stringData))
                {
                    ApplicationSettings temp = (ApplicationSettings)xmlSerializer.Deserialize(reader);

                    this.MachineName = temp.MachineName;
                    this.ServerClass = temp.ServerClass;
                    this.UpdateRate = temp.UpdateRate;
                    this.OPCTags = temp.OPCTags.Distinct().ToList();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        public String SerializeToString()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
                StringWriter textWriter = new StringWriter();

                xmlSerializer.Serialize(textWriter, this);
                return textWriter.ToString();
            }
            catch (Exception E)
            {
                return String.Empty;
            }
        }

        public void Load()
        {
            String configFile = Path.Combine(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), String.Format(@"{0}.config", Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().Location))));
            if (File.Exists(configFile))
            {
                try
                {
                    String serializedString = System.IO.File.ReadAllText(configFile);
                    this.DeserializeFromString(serializedString);
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }
        }

        public void Save()
        {
            try
            {
                String configFile = Path.Combine(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), String.Format(@"{0}.config", Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().Location))));

                String serializedString = this.SerializeToString();
                System.IO.File.WriteAllText(configFile, serializedString);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
