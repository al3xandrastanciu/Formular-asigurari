using Proiect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formular
{
    public partial class Form1: Form
    {
        public static List<Client> clienti = new List<Client>();
        private bool validareCnp(string cnp)
        {
            return cnp.Length == 13 && cnp.All(char.IsDigit);
        }
        private bool validareTelefon(string telefon)
        {
            return telefon.Length == 10 && telefon.All(char.IsDigit);
        }
        List<Asigurare> asigurari = new List<Asigurare>();
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbCod.Text == "")
                errorProvider1.SetError(tbCod, "Introduceti codul clientului!");
            else
                if (cbSex.Text == "")
                errorProvider1.SetError(cbSex, "Selectati sexul!");
            else
                if (tbNume.Text == "")
                errorProvider1.SetError(tbNume, "Introduceti numele!");
            else
                if (tbCNP.Text == "")
                errorProvider1.SetError(tbCNP, "Introduceti CNP-ul!");
            else
                if (!validareCnp(tbCNP.Text))
            {
                errorProvider1.SetError(tbCNP, "CNP-ul introdus nu este valid! Trebuie sa contina exact 13 cifre.");
                return;
            }
            else
                if(!validareTelefon(tbTelefon.Text))
            {
                errorProvider1.SetError(tbTelefon, "Numarul de telefon nu este valid! Trebuie sa contina 10 cifre!");
            }
            else
            {
                errorProvider1.Clear();
                try
                {

                    int cod = Convert.ToInt32(tbCod.Text);
                    char sex = Convert.ToChar(cbSex.Text);
                    string nume = tbNume.Text;
                    string cnp = tbCNP.Text;
                    string telefon = tbTelefon.Text;
                    string adresa = tbAdresa.Text;

                    Client client = new Client(cod, sex, nume, cnp, telefon, adresa);
                   
                    clienti.Add(client);
                    MessageBox.Show("Clientul a fost adaugat!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbCod.Clear();
                    tbNume.Clear();
                    tbCNP.Clear();
                    tbTelefon.Clear();
                    tbAdresa.Clear();
                }
            }
        }

        private void formularAsigurareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form2 formularAsigurare = new Form2(clienti);
            formularAsigurare.Show();
        }
    }
}
