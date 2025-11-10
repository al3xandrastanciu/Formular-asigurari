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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Formular
{
    public partial class Form2 : Form
    {
        List<Client> clienti;
       
        public Form2(List<Client> clienti)
        {
            InitializeComponent();
            this.clienti = clienti;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (var client in clienti)
            {
                //textBox1.AppendText(client.ToString() + Environment.NewLine);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNr.Text == "")
                errorProvider1.SetError(tbNr, "Introduceti Numarul politei!");

            else
                if (tbTip.Text == "")
                errorProvider1.SetError(tbTip, "Introduceti tipul asigurarii!");
            else
                if (tbSuma.Text == "")
                errorProvider1.SetError(tbSuma, "Introduceti suma asigurata");
            else
                if (tbInceput.Text == "")
                errorProvider1.SetError(tbInceput, "Introduceti data!");
            else
                if (tbSfarsit.Text == "")
                errorProvider1.SetError(tbSfarsit, "Introduceti data!");

            else
            {
                errorProvider1.Clear();
                try
                {
                    string nr = tbNr.Text;
                    string tip = tbTip.Text;
                    double suma = Convert.ToDouble(tbSuma.Text);
                    DateTime inceput = Convert.ToDateTime(tbInceput.Text);
                    DateTime sfarsit = Convert.ToDateTime(tbSfarsit.Text);
                    

                    if (inceput >= sfarsit)
                    {
                        MessageBox.Show("Data de început trebuie să fie înainte de data de sfârșit!");
                        return;
                    }

                    if (suma <= 0)
                    {
                        MessageBox.Show("Suma asigurată trebuie să fie un număr pozitiv!");
                        return;
                    }

                    Asigurare asigurare = new Asigurare(nr, tip, suma, inceput, sfarsit);

               
                    Client client = clienti.Last();
                    client.adaugareAsigurare(asigurare);
                    MessageBox.Show("Asigurarea a fost inregistrata și atașată la client!");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbNr.Clear();
                    tbTip.Clear();
                    tbSuma.Clear();
                    tbInceput.Clear();
                    tbSfarsit.Clear();
                }
            }
        }

        private void vizualizareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form3 vizualizare = new Form3(clienti);
            vizualizare.Show();
        }

        private void listBoxTipuri_MouseDown(object sender, MouseEventArgs e)
        {
           
            if (listBoxTipuri.SelectedItem != null)
            {
                listBoxTipuri.DoDragDrop(listBoxTipuri.SelectedItem.ToString(), DragDropEffects.Copy);
            }
        }

        private void tbTip_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void tbTip_DragDrop(object sender, DragEventArgs e)
        {
            tbTip.Text = (string)e.Data.GetData(DataFormats.Text);
        }
    
    }
}

