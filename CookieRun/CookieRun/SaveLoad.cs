using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace CookieRun
{
    class SaveLoad
    {
        Player user;
        private void Save()
        {
            XmlTextWriter writer = new XmlTextWriter("player.xml", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartElement("root");
            writer.WriteStartElement("uang");
            writer.WriteElementString("coin", user.Coin.ToString());
            writer.WriteEndElement();
            for (int i = 0; i < user.Cookie.Length; i++)
            {
                writer.WriteStartElement("skin");
                writer.WriteElementString("name", user.Cookie[i]);
                writer.WriteEndElement();
            }
            for (int i = 0; i < user.Pet.Length; i++)
            {
                writer.WriteStartElement("pet");
                writer.WriteElementString("name", user.Pet[i]);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.Close();
        }

        private void Load()
        {
            if(File.Exists("player.xml"))
            {
                try
                {
                    XmlTextReader reader = new XmlTextReader("player.xml");
                    reader.ReadStartElement("root");
                    reader.ReadStartElement("uang");
                    user.Coin = Convert.ToInt32(reader.ReadElementString("coin"));
                    reader.ReadEndElement();
                    int ctr = 0;
                    while(reader.IsStartElement("skin"))
                    {
                        reader.ReadStartElement("skin");
                        user.Cookie[ctr]= reader.ReadElementString("name");
                        reader.ReadEndElement();
                        ctr++;
                    }
                    int ctr1 = 0;
                    while (reader.IsStartElement("pet"))
                    {
                        reader.ReadStartElement("pet");
                        user.Pet[ctr1] = reader.ReadElementString("name");
                        reader.ReadEndElement();
                        ctr1++;
                    }
                    reader.ReadEndElement();
                    reader.Close();
                }
                catch (Exception)
                {

                }
            }
            else
            {
                
            }   
        }
    }
}
