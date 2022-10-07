using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Nico_TEST
{
    internal class Ausgabe
    {
        DataSet all = new DataSet();
        DataTable grid = new DataTable();
        public Ausgabe(DataSet all, DataTable grid)
        {
            this.all = all;
            this.grid = grid;
        }
        public void erstellung(ProgressBar bar)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "kml files (*.kml)|*.kml|All files (*.*)|*.*";
            save.RestoreDirectory = true;
            save.OverwritePrompt = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                if (grid != null)
                {
                    if (grid.Rows.Count>0)
                    {
                        XmlDocument kml = new XmlDocument();
                        XmlDeclaration DKml = kml.CreateXmlDeclaration("1.0", "UTF-8", null);
                        XmlElement element = kml.CreateElement("kml");
                        element.SetAttribute("xmlns", "http://www.opengis.net/kml/2.2");
                        element.SetAttribute("xmlns:gx", "http://www.google.com/kml/ext/2.2");
                        element.SetAttribute("xmlns:kml", "http://www.opengis.net/kml/2.2");
                        element.SetAttribute("xmlns:atom", "http://www.w3.org/2005/Atom");
                        kml.InsertBefore(DKml, kml.DocumentElement);
                        kml.AppendChild(element);
                        XmlElement kmldoc = kml.CreateElement("Document");
                        element.AppendChild(kmldoc);
                        XmlElement namekml = kml.CreateElement("Name");
                        XmlText namekmltext = kml.CreateTextNode(Path.GetFileName(save.FileName));
                        kmldoc.AppendChild(namekml);
                        namekml.AppendChild(namekmltext);
                        #region Style
                        #region Style 1
                        XmlElement Style1 = kml.CreateElement("Style");
                        Style1.SetAttribute("id", "1");
                        kmldoc.AppendChild(Style1);
                        XmlElement iconstyle1 = kml.CreateElement("IconStyle");
                        Style1.AppendChild(iconstyle1);
                        XmlElement Icon1 = kml.CreateElement("Icon");
                        iconstyle1.AppendChild(Icon1);
                        XmlElement link1 = kml.CreateElement("href");
                        link1.InnerText="http://maps.google.com/mapfiles/kml/pushpin/blue-pushpin.png";
                        Icon1.AppendChild(link1);
                        #endregion
                        #region Style 2
                        XmlElement Style2 = kml.CreateElement("Style");
                        Style2.SetAttribute("id", "2");
                        kmldoc.AppendChild(Style2);
                        XmlElement iconstyle2 = kml.CreateElement("IconStyle");
                        Style2.AppendChild(iconstyle2);
                        XmlElement Icon2 = kml.CreateElement("Icon");
                        iconstyle2.AppendChild(Icon2);
                        XmlElement link2 = kml.CreateElement("href");
                        link2.InnerText = "http://maps.google.com/mapfiles/kml/pushpin/red-pushpin.png";
                        Icon2.AppendChild(link2);
                        #endregion
                        #region Style 3
                        XmlElement Style3 = kml.CreateElement("Style");
                        Style3.SetAttribute("id", "3");
                        kmldoc.AppendChild(Style3);
                        XmlElement iconstyle3 = kml.CreateElement("IconStyle");
                        Style3.AppendChild(iconstyle3);
                        XmlElement Icon3 = kml.CreateElement("Icon");
                        iconstyle3.AppendChild(Icon3);
                        XmlElement link3 = kml.CreateElement("href");
                        link3.InnerText = "http://maps.google.com/mapfiles/kml/pushpin/grn-pushpin.png";
                        Icon3.AppendChild(link3);
                        #endregion
                        #region Style 4
                        XmlElement Style4 = kml.CreateElement("Style");
                        Style4.SetAttribute("id", "4");
                        kmldoc.AppendChild(Style4);
                        XmlElement iconstyle4 = kml.CreateElement("IconStyle");
                        Style4.AppendChild(iconstyle4);
                        XmlElement Icon4 = kml.CreateElement("Icon");
                        iconstyle4.AppendChild(Icon4);
                        XmlElement link4 = kml.CreateElement("href");
                        link4.InnerText = "http://maps.google.com/mapfiles/kml/pushpin/ylw-pushpin.png";
                        Icon4.AppendChild(link4);
                        #endregion
                        #region Style 5
                        XmlElement Style5 = kml.CreateElement("Style");
                        Style5.SetAttribute("id", "5");
                        kmldoc.AppendChild(Style5);
                        XmlElement iconstyle5 = kml.CreateElement("IconStyle");
                        Style5.AppendChild(iconstyle5);
                        XmlElement Icon5 = kml.CreateElement("Icon");
                        iconstyle5.AppendChild(Icon5);
                        XmlElement link5 = kml.CreateElement("href");
                        link5.InnerText = "http://maps.google.com/mapfiles/kml/pushpin/ltblu-pushpin.png";
                        Icon5.AppendChild(link5);
                        #endregion
                        #region Style 6
                        XmlElement Style6 = kml.CreateElement("Style");
                        Style6.SetAttribute("id", "6");
                        kmldoc.AppendChild(Style6);
                        XmlElement iconstyle6 = kml.CreateElement("IconStyle");
                        Style6.AppendChild(iconstyle6);
                        XmlElement Icon6 = kml.CreateElement("Icon");
                        iconstyle6.AppendChild(Icon6);
                        XmlElement link6 = kml.CreateElement("href");
                        link6.InnerText = "http://maps.google.com/mapfiles/kml/pushpin/pink-pushpin.png";
                        Icon6.AppendChild(link6);
                        #endregion
                        #region Style 7
                        XmlElement Style7 = kml.CreateElement("Style");
                        Style7.SetAttribute("id", "7");
                        kmldoc.AppendChild(Style7);
                        XmlElement iconstyle7 = kml.CreateElement("IconStyle");
                        Style7.AppendChild(iconstyle7);
                        XmlElement Icon7 = kml.CreateElement("Icon");
                        iconstyle7.AppendChild(Icon7);
                        XmlElement link7 = kml.CreateElement("href");
                        link7.InnerText = "http://maps.google.com/mapfiles/kml/pushpin/purple-pushpin.png";
                        Icon7.AppendChild(link7);
                        #endregion
                        #region Style 8
                        XmlElement Style8 = kml.CreateElement("Style");
                        Style8.SetAttribute("id", "8");
                        kmldoc.AppendChild(Style8);
                        XmlElement iconstyle8 = kml.CreateElement("IconStyle");
                        Style8.AppendChild(iconstyle8);
                        XmlElement Icon8 = kml.CreateElement("Icon");
                        iconstyle8.AppendChild(Icon8);
                        XmlElement link8 = kml.CreateElement("href");
                        link8.InnerText = "http://maps.google.com/mapfiles/kml/pushpin/grn-pushpin.png";
                        Icon8.AppendChild(link8);
                        #endregion
                        #endregion
                        foreach (DataRow data in grid.Rows)
                        {
                            var a = "Placemark_id = " + data["Id"].ToString();
                            var test = all.Tables["Placemark"].Select(a);

                            XmlElement placemark = kml.CreateElement("Placemark");
                            kmldoc.AppendChild(placemark);

                            XmlElement name = kml.CreateElement("name");
                            XmlText nametext = kml.CreateTextNode(test[0]["name"].ToString());
                            placemark.AppendChild(name);
                            name.AppendChild(nametext);

                            XmlElement styleUrl = kml.CreateElement("styleUrl");
                            XmlText strleUrlText = kml.CreateTextNode(test[0]["styleUrl"].ToString());
                            placemark.AppendChild(styleUrl);
                            styleUrl.AppendChild(strleUrlText);

                            XmlElement Point = kml.CreateElement("Point");
                            placemark.AppendChild(Point);

                            XmlElement coordinates = kml.CreateElement("coordinates");
                            Point.AppendChild(coordinates);
                            
                            var point = all.Tables["Point"].Select(a);
                            XmlText coordinatesText = kml.CreateTextNode(point[0]["coordinates"].ToString());
                            coordinates.AppendChild(coordinatesText);

                            bar.PerformStep();
                        }
                            
                        kml.Save(save.FileName);
                        MessageBox.Show("fertig");
                    }
                }
                if (grid.Rows.Count == 0) 
                {
                    all.WriteXml(save.FileName);    
                }
            }
            save.Dispose();
        }
    }
}
