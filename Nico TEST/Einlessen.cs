using System;
using System.Data;
using System.Xml;
using System.Windows.Forms;

namespace Nico_TEST
{
    class Einlessen
    {
        public DataSet data = new DataSet();
        public DataSet read()
        {
            string file = string.Empty;
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = @"c:\";
                ofd.Filter = "kml files (*.kml)|*.kml|All files (*.*)|*.*";
                ofd.FilterIndex = 2;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    file = ofd.FileName;
                }
            }
            
                XmlReader reader = XmlReader.Create(file);

                reader.Read();
                Console.WriteLine(reader.ToString());
                data.ReadXml(file);
                return data;
            }
            catch (Exception)
            {
                MessageBox.Show("Bitte Datei angeben");
                return data;
                throw;
            }
            
        }

        public void analyse(DataSet ponits)
        {
            ponits.Tables["Placemark"].Rows[0]["name"].ToString();
        }

    }
}
