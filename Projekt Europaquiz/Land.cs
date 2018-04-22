using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Europaquiz
{
    class Land
    {
        private int Nummer;
        private string Name;
        private string Haupstadt;
        private int punkteHaupstadt;
        private int punkteLand;
        private int punkteBeides;
        private bool benutzt = false;


        public int getNummer()
        {
            return Nummer;
        }
        public void setNummer(int Nummer)
        {
            this.Nummer = Nummer;
        }
        public string getName()
        {
            return Name;
        }
        public void setName(string Name)
        {
            this.Name = Name;
        }
        public string getHaupstadt()
        {
            return Haupstadt;
        }
        public void setHaupstadt(string Haupstadt)
        {
            this.Haupstadt = Haupstadt;
        }
        public int getpunkteHauptstadt()
        {
            return punkteHaupstadt;
        }
        public void setpunkteHauptstadt(int punkteHaupstadt)
        {
            this.punkteHaupstadt = punkteHaupstadt;
        }
        public int getpunkteLand()
        {
            return punkteLand;
        }
        public void setpunkteLand(int punkteLand)
        {
            this.punkteLand = punkteLand;
        }
        public int getpunkteBeides()
        {
            return punkteBeides;
        }
        public void setpunkteBeides(int punkteBeides)
        {
            this.punkteBeides = punkteBeides;
        }
        public bool getbenutzt()
        {
            return benutzt;
        }
        public void setbenutzt(bool benutzt)
        {
            this.benutzt = benutzt;
        }

    }
}
