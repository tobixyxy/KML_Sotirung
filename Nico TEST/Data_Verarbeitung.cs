using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nico_TEST
{
    internal class Data_Verarbeitung : PLZ
    {
        DataTable dt;
        public Data_Verarbeitung(DataSet data) 
        {
            if (data.Tables["Placemark"] != null)
            {
                dt = data.Tables["Placemark"];
            }
        }

        public DataTable date_ana()
        {
            DataTable view = new DataTable();
            if (dt != null)
            {                
                view.Columns.Add("Tel");
                view.Columns.Add("PLZ");
                view.Columns.Add("Stadt");
                view.Columns.Add("Straße");
                view.Columns.Add("Bundesland");
                view.Columns.Add("Styl");
                view.Columns.Add("Id");
                foreach (DataRow note in dt.Rows)
                {
                    DataRow row = view.NewRow();
                    var data = note["name"].ToString();
                    var styl = note["styleUrl"];
                    row["styl"] = styl;
                    var id = note["Placemark_id"];
                    row["id"] = id;
                    var tel = data.Split(',', ' ')[0];
                    row["Tel"] = tel;
                    var plz = data.Split(',', ' ')[2];
                    row["PLZ"] = plz;
                    var stad = data.Split(',', ' ')[3];
                    row["Stadt"] = stad;
                    var strass = data.Substring(tel.Length + plz.Length + stad.Length + 4);
                    row["Straße"] = strass;
                    var bund = plz_bundelsland(Convert.ToInt32(plz));
                    row["Bundesland"] = bund;
                    view.Rows.Add(row);
                }
            }
            return view;
        }
            

    }
}
