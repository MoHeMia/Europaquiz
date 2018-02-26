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
        private int Zoomfaktor;//[PH]
        private int[,] Position = new int[1,1];
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
