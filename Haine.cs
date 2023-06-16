using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestiune_haine
{
    class Haine
    {
        string nume;
        string producator;
        string tip;
        string marime;
        int nrBucati;
        float pret;
        public Haine(string producator_, string tip_, string marime_,  int nrBucati_, float pret_)
        {
            producator = producator_;
            tip = tip_;
            marime = marime_;
            nrBucati = nrBucati_;
            pret = pret_;
        }
        public Haine(string producator_, string tip_, string marime_, float pret_)
        {
            producator = producator_;
            tip = tip_;
            marime = marime_;
            pret = pret_;
        }

        public string Producator
        {
            get { return producator; }
            set { producator = value; }
        }
        public string Tip
        {
            get { return tip; }
            set { tip = value; }
        }
        public string Marime
        {
            get { return marime; }
            set { marime = value; }
        }
       
        public int NrBucati
        {
            get { return nrBucati; }
            set { nrBucati = value; }
        }
        public float Pret
        {
            get { return pret; }
            set { pret = value; }
        }

        public override string ToString()
        {
            return "Producator: " + producator + ", Tip: " + tip + ", Marime: " + marime + ", Numar Bucati: " + nrBucati + ", pret: " + pret;
        }
        public string ToFile()
        {
            return producator + "," + tip + "," + marime + "," + nrBucati + "," + pret;
        }

    }
}
