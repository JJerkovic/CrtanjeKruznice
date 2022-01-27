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

        public static int Promjer()
        {
            double promjer =  2*Math.Sqrt(Math.Pow((srediste.X - obodnaTocka.X), 2) + Math.Pow((srediste.Y - obodnaTocka.Y), 2));

            return (int)promjer;
        }

        // metoda IscrtajKruznicu

        public static void IscrtajKruznicu(Graphics g)
        {

            int promjer = Kruznica.Promjer();

            // stranica kvadrata = promjer kruznice
            // koordinate kvadrata - pocetna tocka iscrtavanja je gore lijevo u odnosu na srediste kruznice
            Rectangle kvadrat = new Rectangle((srediste.X - promjer/2), (srediste.Y - promjer / 2), promjer, promjer);

            // iscrtaj kruznicu
            g.DrawEllipse(Pens.Black, kvadrat);
        }

    }
}
