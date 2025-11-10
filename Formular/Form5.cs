using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Formular
{
    public partial class Form5: Form
    {
        string connString;
        public Form5()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.16.0; Data Source=asigurari.accdb";
        }

        private void PopuleazaListView()
        {
            listView1.Items.Clear();
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                string query = @"SELECT c.[ID client], c.Nume, 
                        a.[Numar Polita], 
                        a.[Tip asigurare], 
                        a.[Suma asigurata]
                 FROM clienti c
                 INNER JOIN asigurari a ON c.[ID client] = a.[ID Client]";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["ID client"].ToString());
                        item.SubItems.Add(reader["Nume"].ToString());
                        item.SubItems.Add(reader["Numar Polita"].ToString());
                        item.SubItems.Add(reader["Tip asigurare"].ToString());
                        item.SubItems.Add(reader["Suma asigurata"].ToString());
                        listView1.Items.Add(item);

                    }
                }
            }
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            PopuleazaListView();
        }

        //Prompt pentru formulare de adaugare asigurare
        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form() { Width = 300, Height = 150, Text = caption };
                Label lbl = new Label() { Left = 10, Top = 20, Text = text };
                TextBox txt = new TextBox() { Left = 10, Top = 50, Width = 260 };
                Button btnOk = new Button() { Text = "OK", Left = 200, Width = 70, Top = 80, DialogResult = DialogResult.OK };
                prompt.Controls.Add(lbl); prompt.Controls.Add(txt); prompt.Controls.Add(btnOk);
                prompt.AcceptButton = btnOk;
                return prompt.ShowDialog() == DialogResult.OK ? txt.Text : "";
            }
        }
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string idClient = Prompt.ShowDialog("ID Client:", "Adauga");
            string nume = Prompt.ShowDialog("Nume:", "Adauga");
            string nrPolita = Prompt.ShowDialog("Numar Asigurare:", "Adauga");
            string tip = Prompt.ShowDialog("Tip:", "Adauga");
            string suma = Prompt.ShowDialog("Suma Asigurata:", "Adauga");

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                // Adauga clientul daca nu exista deja
                var cmdClient = new OleDbCommand("SELECT COUNT(*) FROM clienti WHERE [ID client]=@id", conn);
                cmdClient.Parameters.AddWithValue("@id", idClient);
                int count = (int)cmdClient.ExecuteScalar();
                if (count == 0)
                {
                    var cmdInsertClient = new OleDbCommand("INSERT INTO clienti ([ID client], Nume) VALUES (@id, @nume)", conn);
                    cmdInsertClient.Parameters.AddWithValue("@id", idClient);
                    cmdInsertClient.Parameters.AddWithValue("@nume", nume);
                    cmdInsertClient.ExecuteNonQuery();
                }
                // Adauga asigurarea
                var cmdAsig = new OleDbCommand(
                    "INSERT INTO asigurari ([Numar Polita], [Tip asigurare], [Suma asigurata], [ID Client]) VALUES (@nr, @tip, @suma, @idClient)", conn);
                cmdAsig.Parameters.AddWithValue("@nr", nrPolita);
                cmdAsig.Parameters.AddWithValue("@tip", tip);
                cmdAsig.Parameters.AddWithValue("@suma", suma);
                cmdAsig.Parameters.AddWithValue("@idClient", idClient);
                cmdAsig.ExecuteNonQuery();

            }
            PopuleazaListView();
        }

      

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectează o asigurare pentru actualizare.");
                return;
            }
            var itm = listView1.SelectedItems[0];
            string nrPolita = itm.SubItems[2].Text;
            string tipNou = Prompt.ShowDialog("Tip nou:", "Actualizare");
            string sumaNoua = Prompt.ShowDialog("Suma nouă:", "Actualizare");

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                var cmd = new OleDbCommand("UPDATE asigurari SET [Tip asigurare]=@tip, [Suma asigurata]=@suma WHERE [Numar Polita]=@nr", conn);
                cmd.Parameters.AddWithValue("@tip", tipNou);
                cmd.Parameters.AddWithValue("@suma", sumaNoua);
                cmd.Parameters.AddWithValue("@nr", nrPolita);
                cmd.ExecuteNonQuery();

            }
            PopuleazaListView();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectează o asigurare pentru ștergere.");
                return;
            }
            var itm = listView1.SelectedItems[0];
            string nrPolita = itm.SubItems[2].Text;

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                var cmd = new OleDbCommand("DELETE FROM asigurari WHERE [Numar Polita]=@nr", conn);
                cmd.Parameters.AddWithValue("@nr", nrPolita);
                cmd.ExecuteNonQuery();

            }
            PopuleazaListView();
        }
    }
}
