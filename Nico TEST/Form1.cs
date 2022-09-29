using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Nico_TEST
{
    public partial class Form1 : Form
    {
        Einlessen Einlessen = new Einlessen();
        DataTable data = new DataTable();
        private string auswahl = "Bundesland";

        public Form1()
        {
            InitializeComponent();
            string[] test = { "","Banden-Württenberg","Berlin","Bayern","Sachsen","Brandenburg","Thüringen","Sachsen-Anhalt","Mecklenburg-Vorpommern","Niedersachsen","Hamburg","Schleswig-Holstein","Bremen","Nordrhein-Westfalen","Saarland"};
            cbbLaender.DataSource = test;
            pgbVortschrit.Visible = false;
            
        }

        private void btEinlessen_Click(object sender, EventArgs e)
        {
            Data_Verarbeitung work = new Data_Verarbeitung(Einlessen.read());
            data = work.date_ana();
            if (txtPlz.Text == string.Empty && cbbLaender.SelectedIndex == 0)
            {
                dgvDaten.DataSource = data;
                visibil();
            }
            else if (cbbLaender.SelectedIndex > 0)
            {
                sotirung(auswahl, cbbLaender.SelectedItem.ToString());
            }
            else if (txtPlz.Text != string.Empty)
            {
                sotirung(auswahl, txtPlz.Text);
            }            
        }

        private void cbbLaender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (data.Columns.Count > 0)
            {
                if (cbbLaender.SelectedIndex != 0)
                {
                    dgvDaten.DataSource =  sotirung(auswahl, cbbLaender.SelectedItem.ToString());
                    visibil();
                    if (txtPlz.Text != string.Empty)
                    {
                        dgvDaten.DataSource = filter(sotirung(auswahl, cbbLaender.SelectedItem.ToString()), txtPlz.Text);
                        visibil();
                    }
                }
                else if (cbbLaender.SelectedIndex == 0)
                {
                    dgvDaten.DataSource = data;
                    visibil();
                }
            }
        }

        private void txtPlz_TextChanged(object sender, EventArgs e)
        {
            if (data.Columns.Count > 0)
            {
                if (txtPlz.Text == String.Empty)
                {
                    if (txtPlz.Text == string.Empty && cbbLaender.SelectedIndex == 0)
                    {
                        dgvDaten.DataSource = data;
                        visibil();
                    }
                    else if (cbbLaender.SelectedIndex != 0)
                    {
                        dgvDaten.DataSource = sotirung(auswahl, cbbLaender.SelectedItem.ToString());
                        visibil();
                    }
                }
                else
                {
                    if (cbbLaender.SelectedIndex != 0)
                    {
                        dgvDaten.DataSource = filter(sotirung(auswahl, cbbLaender.SelectedItem.ToString()), txtPlz.Text);
                        visibil();

                    }
                    else
                    {
                        dgvDaten.DataSource = filter(data, txtPlz.Text);
                        visibil();
                    }
                } 
            }       
        }
        DataTable table = new DataTable();
        public DataTable sotirung(string Rows, string suche)
        {
            DataTable temp = data;
            table.Clear();
            if (table.Columns.Count <= 0)
            {
                table.Columns.Add("Tel");
                table.Columns.Add("PLZ");
                table.Columns.Add("Stadt");
                table.Columns.Add("Straße");
                table.Columns.Add("Bundesland");
                table.Columns.Add("Styl");
                table.Columns.Add("Id");
            }

            int i = 0;
            table.Rows.Clear();
            foreach (DataRow thp in temp.Rows)
            {
                if (suche == thp.Table.Rows[i][Rows].ToString())
                {
                    DataRow row = table.NewRow();
                    row["Tel"] = thp.Table.Rows[i][0];
                    row["PLZ"] = thp.Table.Rows[i][1];
                    row["Stadt"] = thp.Table.Rows[i][2];
                    row["Straße"] = thp.Table.Rows[i][3];
                    row["Bundesland"] = thp.Table.Rows[i][4];
                    row["Styl"] = thp.Table.Rows[i][5];
                    row["Id"] = thp.Table.Rows[i][6];
                    table.Rows.Add(row);
                }
                i++;
            }
            /*
            dgvDaten.DataSource = table;
            dgvDaten.Columns["Styl"].Visible = false;
            dgvDaten.Columns["Id"].Visible = false;*/
            return table;

        }

        public DataTable filter(DataTable data, string plz)
        {
            DataTable temp = new DataTable();
            if (data.Columns.Count > 0)
            {
                var sql = "PLZ like '" + plz + "%'";

                try
                {
                    temp = data.Select(sql).CopyToDataTable();
                    //return temp;
                }
                catch (Exception)
                {
                    //return temp;
                }

            }
            return temp;


        }

        private void visibil()
        {
            if (dgvDaten.DataSource != null && dgvDaten.RowCount != 0)
            {
                dgvDaten.Columns["Styl"].Visible = false;
                dgvDaten.Columns["Id"].Visible = false;
            }
        }

        private void btAugaben_Click(object sender, EventArgs e)
        {
            pgbVortschrit.Visible = true;
            pgbVortschrit.Minimum = 1;
            pgbVortschrit.Maximum = table.Rows.Count;
            Ausgabe ausgabe = new Ausgabe(Einlessen.data,table);
            ausgabe.erstellung(pgbVortschrit);
            pgbVortschrit.Visible = false;
        }
    }
}