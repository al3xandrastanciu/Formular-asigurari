using Proiect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Formular
{
    public partial class Form3 : Form
    {
        List<Client> clienti;


        public Form3(List<Client> clienti)
        {
            InitializeComponent();

            btnSalvareFisier.Text = "&Salveaza in fisier";
            if (clienti == null)
                this.clienti = new List<Client>();
            else
                this.clienti = clienti;


            Client c1 = new Client(1, 'M', "Ion Popescu", "1234567890123", "0712345678", "Strada A");
            c1.adaugareAsigurare(new Asigurare("A100", "CASCO", 5000, DateTime.Now, DateTime.Now.AddYears(1)));
            c1.adaugareAsigurare(new Asigurare("A101", "RCA", 2000, DateTime.Now, DateTime.Now.AddYears(1)));

            Client c2 = new Client(2, 'F', "Maria Ionescu", "2345678901234", "0723456789", "Strada B");
            c2.adaugareAsigurare(new Asigurare("B200", "Sanatate", 10000,new DateTime(2023,6,11), DateTime.Now.AddYears(1)));

            Client c3 = new Client(2, 'M', "Andrei Constantin", "1890417891234", "0723454689", "Strada F");
            c3.adaugareAsigurare(new Asigurare("B28", "Viata", 10000, DateTime.Now, DateTime.Now.AddYears(4)));

            clienti.Add(c1);
            clienti.Add(c2);

            
            listView1.ContextMenuStrip = contextMenuStrip1;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void btnAfisareMemorie_Click(object sender, EventArgs e)
        {
            tbAfisare.Clear();
            foreach (var client in Form1.clienti)
                tbAfisare.AppendText("Nume: " + client.Nume + Environment.NewLine +
            "CNP: " + client.CNP + Environment.NewLine +
            "Telefon: " + client.Telefon + Environment.NewLine +
            "Adresa: " + client.Adresa + Environment.NewLine +
            Environment.NewLine);
        }

        private void btnFisier_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (clienti == null)
            {
                MessageBox.Show("Lista de clienți nu a fost inițializată.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var client in clienti)
            {
                if (client.Asigurari == null) continue;
                foreach (var asigurare in client.Asigurari)
                {
                    ListViewItem itm = new ListViewItem(client.ID.ToString());
                    itm.SubItems.Add(client.Nume);
                    itm.SubItems.Add(client.CNP);
                    itm.SubItems.Add(client.Telefon);
                    itm.SubItems.Add(client.Adresa);
                    itm.SubItems.Add(asigurare.Tip);
                    itm.SubItems.Add(asigurare.Suma.ToString("0.00"));

                    listView1.Items.Add(itm);
                }
            }

        }

        private void stergereAsigurareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                int idClient = int.Parse(selectedItem.Text);              
                var clientDeSters = clienti.FirstOrDefault(c => c.ID == idClient);
                if (clientDeSters != null)
                    clienti.Remove(clientDeSters);
                listView1.Items.Remove(selectedItem);
            }
        }

        private void btnSalvareFisier_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("clienti.txt"))
            {
                foreach (Client client in clienti)
                {
                    sw.Write(client.ID + "|");
                    sw.Write(client.Nume + "|");
                    sw.Write(client.CNP + "|");
                    sw.Write(client.Telefon + "|");
                    sw.Write(client.Adresa);
                    if (client.Asigurari != null && client.Asigurari.Count > 0)
                    {
                        foreach (var asigurare in client.Asigurari)
                        {
                            sw.Write("|" + asigurare.Numar + "," + asigurare.Tip + "," + asigurare.Suma.ToString("0.00") +
                                "," + asigurare.Inceput.ToString("dd.MM.yyyy") + "," + asigurare.Expirare.ToString("dd.MM.yyyy"));
                        }
                    }
                    sw.WriteLine();
                }
            }
            MessageBox.Show("Date exportate!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 grafic = new Form4(clienti);
            grafic.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }
    }
}

