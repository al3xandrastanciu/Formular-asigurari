using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    [Serializable]
    public abstract class Persoana
    {
       protected int id;
       protected char sex;

        public Persoana()
        {
            id = 0;
            sex = '0';
        }
        public Persoana(int i, char s)
        {
            id = i;
            sex = s;
        }
        public int ID { get => id; set => id = value; }
        public char Sex { get => sex; set => sex = value; }

        public override string ToString()
        {
            return "ID:" + id + " \nSex client:" + sex;
        }
    }
}
