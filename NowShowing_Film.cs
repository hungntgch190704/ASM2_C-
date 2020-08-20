using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformASM
{
    class NowShowing_Film
    {
        private string name;
        private string type;
        private string subtitle;
        private string date;
        private string experience;
        private string cast;
        private string director;
        private string distributor;
        private string synopsis;
        private string image;

        public NowShowing_Film(string n, string t, string s, string d, string e, string c, string drt, string dsb, string sy, string i)
        {
            this.name = n;
            this.type = t;
            this.subtitle = s;
            this.date = d;
            this.experience = e;
            this.cast = c;
            this.director = drt;
            this.distributor = dsb;
            this.synopsis = sy;
            this.image = i;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Subtitle
        {
            get { return this.subtitle; }
            set { this.subtitle = value; }
        }

        public string Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string Experience
        {
            get { return this.experience; }
            set { this.experience = value; }
        }

        public string Cast
        {
            get { return this.cast; }
            set { this.cast = value; }
        }

        public string Director
        {
            get { return this.director; }
            set { this.director = value; }
        }

        public string Distributor
        {
            get { return this.distributor; }
            set { this.distributor = value; }
        }

        public string Synopsis
        {
            get { return this.synopsis; }
            set { this.synopsis = value; }
        }

        public string Image
        {
            get { return this.image; }
            set { this.image = value; }
        }
    }
}
