using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CrtanjeKruznice
{
    public static class Kruznica
    {


        public static Point srediste;
        public static Point obodnaTocka;

        public static int Polumjer()
        {
            double polumjer =  Math.Sqrt(Math.Pow((srediste.X - obodnaTocka.X), 2) + Math.Pow((srediste.Y - obodnaTocka.Y), 2));

            return (int)polumjer;
        }

        public static float Opseg()
        {
            int r = Polumjer();

            double opseg = 2 * r * Math.PI;
            
            return (float)opseg;
        }

        public static float Povrsina()
        {
            int r = Polumjer();

            double povrsina = (Math.Pow(r, 2)) * Math.PI;

            return (float)povrsina;
        }

        // metoda IscrtajKruznicu

        public static void IscrtajKruznicu(Graphics g)
        {

            int r = Polumjer();

            // stranica kvadrata = promjer kruznice
            // koordinate kvadrata - pocetna tocka iscrtavanja je gore lijevo u odnosu na srediste kruznice
            Rectangle kvadrat = new Rectangle((srediste.X - r), (srediste.Y - r), 2*r, 2*r);

            // iscrtaj kruznicu
            g.DrawEllipse(Pens.Black, kvadrat);
        }

    }
}
