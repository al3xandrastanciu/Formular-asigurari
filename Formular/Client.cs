using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    [Serializable]
    public class Client:Persoana, ICloneable, IComparable
    {
        private string nume;
        private string cnp;
        private string telefon;
        private string adresa;
        List<Asigurare> asigurari;

        public Client():base()
        {
            nume = "Anonim";
            cnp= "0000000000000";
            telefon = "0000000000";
            adresa = "Necunoscuta";
            asigurari = new List<Asigurare>();
        }
        public Client(int i, char s,string n,string c,string t,string a):base(i,s)
        {
            nume = n;
            cnp = c;
            telefon = t;
            adresa = a;
            asigurari = new List<Asigurare>();
        }

        public string Nume { get => nume; set => nume = value; }
        public string CNP { get => cnp; set => cnp = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public List<Asigurare> Asigurari { get => asigurari; }
      
        

        public void adaugareAsigurare(Asigurare a)
        {
            asigurari.Add(a);
        }
        public bool stergeAsigurare(string numarPolita)
        {
            Asigurare asig = asigurari.FirstOrDefault(a => a.Numar == numarPolita);
            if (asig != null)
            {
                asigurari.Remove(asig);
                return true;
            }
            return false;
        }
        public void afiseazaAsigurari()
        {
            Console.WriteLine("Asigurări pentru clientul: "+nume);
            foreach (var asig in asigurari)
            {
                Console.WriteLine(asig);
            }
        }
        public override string ToString()
        {
            return base.ToString()+"\nNume client:" + nume + "\n CNP: " + cnp +"\nTelefon: "+telefon+"\nAdresa: " + adresa+"\nAsigurarile clientului: "+string.Join("\n",asigurari);
        }

        public static Client operator +(Client c, Asigurare a)
        {
            Client nouClient = (Client)c.Clone();
            nouClient.asigurari.Add(a);
            return nouClient;
        }

        public object Clone()
        {
            Client copie = new Client(0, 'M', this.nume, this.cnp, this.telefon, this.adresa);
            copie.asigurari = new List<Asigurare>(this.asigurari.Select(a => new Asigurare(a.Numar, a.tipAsigurare, a.sumaAsigurata, a.dataInceput, a.dataExpirare)));
            return copie;

        }
        public int comparareDupaNume(Client other)
        {
            return this.nume.CompareTo(other.nume);
        }
        public int compararedupaCnp(Client other)
        {
            return this.cnp.CompareTo(other.cnp);
        }
        public bool esteEgal(Client other)
        {
            return this.cnp == other.cnp;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }



    }
}
