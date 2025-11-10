using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    [Serializable]
    public class Asigurare : IReducere
    {
        public string numarPolita;
        public string tipAsigurare;
        public double sumaAsigurata;
        public DateTime dataInceput;
        public DateTime dataExpirare;

        public Asigurare()
        {
            numarPolita = "x";
            tipAsigurare = "Necunoscut";
            sumaAsigurata = 0;
            dataInceput = DateTime.Now;
            dataExpirare = DateTime.Now.AddYears(1);
        }

        public Asigurare(string nr, string tip, double suma, DateTime inceput, DateTime expirare)
        {
            numarPolita = nr;
            tipAsigurare = tip;
            sumaAsigurata = suma;
            dataInceput = inceput;
            dataExpirare = expirare;
        }

        public string Numar { get => numarPolita; set => numarPolita = value; }
        public string Tip { get => tipAsigurare; set => tipAsigurare = value; }
        public double Suma { get => sumaAsigurata; set => sumaAsigurata = value; }
        public DateTime Inceput { get => dataInceput; set => dataInceput = value; }
        public DateTime Expirare { get => dataExpirare; set => dataExpirare = value; }

        public double calculeazaReducere()
        {
            int ani = (dataExpirare - dataInceput).Days / 365;
            if (ani > 2)
            {
                return sumaAsigurata * 0.10;
            }
            return 0;
        }

        public override string ToString()
        {
            return "\n" +"----------------------------\n"+"Numar polita: " + numarPolita + "\nTip asigurare: " + tipAsigurare + "\nSuma asigurata: " + sumaAsigurata + "\nValabilitate asigurare:de la " + dataInceput.ToShortDateString() + " pana la " + dataExpirare.ToShortDateString()+"\n\n";
        }
        
        
      
    }
}
