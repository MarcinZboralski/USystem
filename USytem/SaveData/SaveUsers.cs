using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace USytem.SaveData
{
    public static class SaveUsers
    {
        public static void Save<T>(T toSave)
        {
            XmlSerializer s = new XmlSerializer(typeof(T));

         //   MessageBox.Show(Application.UserAppDataPath);

            using (Stream str = new FileStream(Application.UserAppDataPath+"/Users.xml",FileMode.Create))
            {
                s.Serialize(str,toSave);
            }
        }

        public static void Load<T>(out T toSave)
        {
            XmlSerializer s = new XmlSerializer(typeof(T));

            using (Stream str = new FileStream(Application.UserAppDataPath + "/Users.xml", FileMode.Open))
            {
                toSave =  (T)s.Deserialize(str);
            }
        }
    }
}
