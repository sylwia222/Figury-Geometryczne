using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjektNr2_Karpowicz61959.FiguryGeometryczne.Punkt;
using static ProjektNr2_Karpowicz61959.FiguryGeometryczne;

namespace ProjektNr2_Karpowicz61959
{
    internal class FiguryGeometryczne
    { // deklaracja głównej klasy bazowej
        public class Punkt
        { // deklaracje pomocnicze 
            public const int PromienPunktu = 5;
            // deklaracja typu wyliczeniowego dla oznaczania egzemplarzy figur geometrycznych
            public enum FiguraGeometryczna : byte
            { Punkt = 0, Linia, Elipsa, Prostokat, Okrag, Kwadrat, Wielokat };
            // deklaracje atrybutów klasy Punkt

            public FiguraGeometryczna Figura
            {
                get;
                protected set;
            }
            // deklaracja atrybutu widoczności
            public bool widoczny
            {
                get;
                protected set;
            }

            public int ŚrednicaPunktu
            {
                get;
                protected set;
            }

            public int X
            {
                get;
                protected set;
            }

            public int Y
            {
                get;
                protected set;
            }

            public Color Kolor
            {
                get;
                protected set;
            }

            // deklaracja właściwości ważnych dla klas potomnych

            public float GrubośćLinii
            {
                get;
                protected set;
            }

            public DashStyle StylLinii
            {
                get;
                protected set;
            }
            public Color KolorWypełnienia
            {
                get;
                protected set;
            }

            // deklaracje konstruktorów

            public Punkt(int X, int Y)
            { // ustawienie wartości atrybutów ważnych dla punktu
                Figura = FiguraGeometryczna.Punkt;
                this.X = X;
                this.Y = Y;
                ŚrednicaPunktu = 2 * PromienPunktu;
                widoczny = false;

                // ustawienie wartości pozostałych atrybutów ważnych dla klasy Punkt i klas potomnych
                Kolor = Color.Black;
                GrubośćLinii = 1.0F;
                StylLinii = DashStyle.Solid;
                KolorWypełnienia = Color.White;
            }
            // deklaracja drugiego konstruktora
            public Punkt(int X, int Y, Color Kolor) : this(X, Y)
            { // uaktualnienie dedykowanego koloru Punktu
                this.Kolor = Kolor;
            }

            // deklaracja trzeciego konstruktora
            public Punkt(int X, int Y, Color Kolor, int ŚrednicaPunktu) : this(X, Y, Kolor)
            { // uaktualnienie dedykowanej średnicy Punktu
                this.ŚrednicaPunktu = ŚrednicaPunktu;
            }

            // deklaracja metod wirtualnych
            public virtual void Wykreśl(Graphics Rysownica)
            {
                /* I wersja
                SolidBrush Pędzel = new SolidBrush(Kolor);
                // wykreślenie wypełnienionego okręgu, czyli koła
                Rysownica.FillEllipse(Pędzel, X - ŚrednicaPunktu / 2, Y - ŚrednicaPunktu / 2,
                                     ŚrednicaPunktu, ŚrednicaPunktu);
                // zapalenie atrybutu widoczności
                widoczny = true;
                // zwolnienie Pędzla
                Pędzel.Dispose();
                */
                // II wersja 
                using (SolidBrush Pędzel2 = new SolidBrush(Kolor))
                {
                    // wykreślenie wypełnienionego okręgu, czyli koła
                    Rysownica.FillEllipse(Pędzel2, X - ŚrednicaPunktu / 2, Y - ŚrednicaPunktu / 2,
                                         ŚrednicaPunktu, ŚrednicaPunktu);
                    // zapalenie atrybutu widoczności
                    widoczny = true;
                }
            }

            public virtual void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                using (SolidBrush Pędzel = new SolidBrush(Kontrolka.BackColor))
                {
                    Rysownica.FillEllipse(Pędzel, X - ŚrednicaPunktu / 2, Y - ŚrednicaPunktu / 2,
                                        ŚrednicaPunktu, ŚrednicaPunktu);
                    // zgaszenie atrybutu widoczności
                    widoczny = false;

                }
            }

            public virtual void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int NoweXp, int NoweYp)
            {
                //ustawienie nowych współrzędnych  położenia Punktu
                X = NoweXp; Y = NoweYp;

                //wykreślenie punktu w nowym położeniu
                Wykreśl(Rysownica);
            }

        } // koniec klas Punkt

        // deklaracja klas linia
        public class Linia : Punkt
        { // dodanie nowych deklaracji atrybutów linii niezbędnych dla jej wykreślania
            int Xk, Yk;

            // deklaracja konstruktorów klasy linia

            public Linia(int Xp, int Yp, int Xk, int Yk) : base(Xp, Yp)
            {
                // ustalenie rodzajufigury geometrycznej
                Figura = FiguraGeometryczna.Linia;

                // przechowanie wartości atrybutów parametrów Xk, Yk
                this.Xk = Xk; this.Yk = Yk;
            }

            public Linia(int Xp, int Yp, int Xk, int Yk, Color KolorLinii) : base(Xp, Yp, KolorLinii)
            {
                Figura = FiguraGeometryczna.Linia;
                this.Xk = Xk; this.Yk = Yk;

            }
            // nadpisanie metod wirtualnych zadeklarowanych w klasie bazowej punkt
            public override void Wykreśl(Graphics Rysownica)
            { // wykreślenie linii
                using (Pen Pióro = new Pen(Kolor, GrubośćLinii))
                { // ustawienie stylu linii
                    Pióro.DashStyle = StylLinii;
                    Rysownica.DrawLine(Pióro, X, Y, Xk, Yk);
                    widoczny = true;
                }
            }

            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            { // sprawdzenie widoczności
                if (widoczny)
                    using (Pen Pióro = new Pen(Kontrolka.BackColor, GrubośćLinii))
                    {
                        Pióro.DashStyle = StylLinii;
                        Rysownica.DrawLine(Pióro, X, Y, Xk, Yk);
                        // zgaszenie atrybutu widoczności
                        widoczny = false;
                    }
            }
            public override void PrzesunDoNowegoXY(Control Kontrolka, Graphics Rysownica, int NoweXp, int NoweYp)
            {
                //pomocnicza deklaracja dla przyrostu zmian X i Y
                int dx, dy;

                //wyznaczenie przyrostu zmian współrzędnej X
                if (NoweXp > X)
                {
                    dx = NoweXp - X;
                }
                else
                {
                    dx = X - NoweXp;
                }

                if (NoweYp > Y)
                {
                    dy = NoweYp - Y;
                }
                else
                {
                    dy = Y - NoweYp;
                }

                //przesunięcie początku linii do punktu NoweX, NoweY;
                X = NoweXp; Y = NoweYp;

                //przesunięcie współrzędnych Linii o przystost dx oraz dy
                Xk = (Xk + dx) % Kontrolka.Width;
                Yk = (Yk + dy) % Kontrolka.Height;

                //wykreślenie linii w nowym położeniu
                Wykreśl(Rysownica);
            }
        }

        public class Elipsa : Punkt
        {
            //deklaracje niezbędne dla wykreślenia ELIPSY
            protected int OśDuża, OśMała;

            //deklaracja konstruktorów
            public Elipsa(int X, int Y, int OśDuża, int OśMała, Color KolorLinii,
                DashStyle StylLinii, float GrubośćLinii) : base(X, Y, KolorLinii)
            {
                //ustawienie "znacznika" Elipsa
                Figura = FiguraGeometryczna.Elipsa;

                //ustawienie atrybutu widoczności
                widoczny = false;

                //przechowanie wartości atrybutu Elipsy
                this.OśDuża = OśDuża;
                this.OśMała = OśMała;
                this.StylLinii = StylLinii;
                this.GrubośćLinii = GrubośćLinii;
            }

            //deklaracja metod nadpisujących metody wirtualne z klasy Punkt
            public override void Wykreśl(Graphics Rysownica)
            {
                //Wykreślenie elipsy
                using (Pen Pioro = new Pen(Kolor, GrubośćLinii))
                {
                    //ustawienie stylu linii
                    Pioro.DashStyle = StylLinii;

                    //wykreslenie elipsy
                    Rysownica.DrawEllipse(Pioro, X - OśDuża / 2, Y - OśMała / 2, OśDuża, OśMała);

                    //ustawienie atrybutu widoczności
                    widoczny = true;
                }
            }
            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                //sprawdzenie czy elipsa jest wykreślona
                if (widoczny)
                {
                    //wymazanie elipsy
                    using (Pen Pioro = new Pen(Kontrolka.BackColor, GrubośćLinii))
                    {
                        //ustawienie stylu linii
                        Pioro.DashStyle = StylLinii;

                        //wymazanie elipsy
                        Rysownica.DrawEllipse(Pioro, X - OśDuża / 2, Y - OśMała / 2, OśDuża, OśMała);

                        //ustawienie atrybutu widoczności
                        widoczny = false;
                    }
                }
            }
        }

    }
}
    