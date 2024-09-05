using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clicker
{
    internal class NarizClasse
    {
        private int userCod;
        private double nariz;
        private double narizPorClique;
        private double narizPorSegundo;
        private string acessorio;

        public int UserCod
        {
            get { return userCod; }
            set { userCod = value; }
        }

        public double Nariz
        {
            get { return nariz; }
            set { nariz = value; }
        }

        public double NarizPorClique
        {
            get { return narizPorClique; }
            set { narizPorClique = value; }
        }

        public double NarizPorSegundo
        {
            get { return narizPorSegundo; }
            set { narizPorSegundo = value; }
        }

        public string Acessorio
        {
            get { return acessorio; }
            set { acessorio = value; }
        }
    }
}
