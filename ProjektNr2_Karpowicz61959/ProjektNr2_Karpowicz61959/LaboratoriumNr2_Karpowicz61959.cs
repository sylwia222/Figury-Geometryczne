using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// dodanie przestrzei nazw dodanych przez klase figurygeometryczne
using static ProjektNr2_Karpowicz61959.FiguryGeometryczne;
// dodanie przestrzeni na grafiki 2d
using System.Drawing.Drawing2D;

namespace ProjektNr2_Karpowicz61959
{
    public partial class LaboratoriumNr2_Karpowicz61959 : Form
    {
        const int Margines = 10;
        //  deklaracja pomocnicza powierzchni graficznej
        Graphics Rysownica;
        Punkt[] TFG; // tablica figur geometrycznych
        ushort IndexTFG;
        public LaboratoriumNr2_Karpowicz61959()
        {
            InitializeComponent();

            // ustalenie rozmiaru formularza
            this.Location = new Point(Screen.PrimaryScreen.Bounds.X + Margines,
                                      Screen.PrimaryScreen.Bounds.Y + Margines);
            this.Width = (int)(Screen.PrimaryScreen.Bounds.X * 0.85F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Y * 0.75F);
            this.StartPosition = FormStartPosition.Manual;

            // utworzenie BitMapy i podpięcie jej do kontrolki PictureBox
            pbsRysownica.Image = new Bitmap(pbsRysownica.Width, pbsRysownica.Height);
            // utworzenie egzemplarza powierzchni graficznej 
            Rysownica = Graphics.FromImage(pbsRysownica.Image);

        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            ushort N;
            // zgaszenie kontrolki errorprovider
            errorProvider1.Dispose();
            if (!ushort.TryParse(txtN.Text, out N))
            {
                errorProvider1.SetError(txtN, "ERROR: w zapisie liczby figur do prezentacji " +
                    "wystąpił niedozwolony znak");
                return;
            }
            // sprawdzenie czy zostały wybrane figury w kontrolce ChechedListBox
            if (ckld_FiguryGeometryczne.CheckedItems.Count > 0)
            {
                // ustawienie kontrolki txtN w stan braku aktywności
                txtN.Enabled = false;
                // uaktywnienie przycisku poleceń START
                btnStart.Enabled = true;
            }
            else
                errorProvider1.SetError(ckld_FiguryGeometryczne,
                    "UWAGA: Musisz wybrać co najmniej jedną figurę geometryczną w " +
                    "kontrolce CheckedListBox");
            if (!txtN.Enabled)
            {
                //uaktywnienie przycisku poleceń start
                btnStart.Enabled = true;
                /*kontrolki 'chlbFiguryGeometryczne' nie ustawiamy w stan: brak aktywności 
                 * gdyż planujemy udostępnienie przecysku funkcjonalnego: Dodaj nową figurę
                 */
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            // deklaracje pomocnicze
            ushort LiczbaWybranychFG;
            int Xmax, Ymax;
            int Xp, Yp, Xk, Yk;
            int OśDuża, OśMała;
            Color Kolor, KolorWypełnienia;
            float GrubośćLinii;
            DashStyle StylLinii;
            Random rnd = new Random();
            int IndexWylosowanejFG;
            // zgaszenie kontrolki errorProvider
            errorProvider1.Dispose();

            // pobranie liczby figur (bez sprawdzenia poprawności zapisu bo zostało to zrobione w metodzie txt changed
            LiczbaWybranychFG = ushort.Parse(txtN.Text);
            // utworzenie egzemplarza tablicy TFG (Tablica Figur Geometrycznych)
            TFG = new Punkt[LiczbaWybranychFG];
            IndexTFG = 0;
            // pobraniekolekcji wybranych figur geometrycznych w kontrolce cklb
            CheckedListBox.CheckedItemCollection WybraneFG = ckld_FiguryGeometryczne.CheckedItems;
            // ustalenie wartości atrybutów powierzchni graficznej
            Xmax = pbsRysownica.Width;
            Ymax = pbsRysownica.Height;
            // utworzenie i wykreślenie wylosowanych figur geometrycznych
            for (int i = 0; i < LiczbaWybranychFG; i++)
            {
                Xp = rnd.Next(Margines, Xmax - Margines);
                Yp = rnd.Next(Margines, Ymax - Margines);
                Kolor = Color.FromArgb(rnd.Next(0, 255),
                                       rnd.Next(0, 255),
                                       rnd.Next(0, 255));
                KolorWypełnienia = Color.FromArgb
                                       (rnd.Next(0, 255),
                                       rnd.Next(0, 255),
                                       rnd.Next(0, 255));
                // losowanie stylu linii
                switch (rnd.Next(0, 5))
                {
                    case 0: 
                        StylLinii = DashStyle.Solid; 
                        break;
                    case 1: 
                        StylLinii = DashStyle.Dash; 
                        break;
                    case 2: 
                        StylLinii = DashStyle.Dot; 
                        break;
                    case 3: 
                        StylLinii = DashStyle.DashDot; 
                        break;
                    case 4: 
                        StylLinii = DashStyle.DashDotDot; 
                        break;
                    default:
                        MessageBox.Show("Przepraszamy, ale takiego stylu liii jeszcze " +
                        "nie mamy");
                        break;      
                }
                // losowanie grubości linii
                GrubośćLinii = (float)(rnd.NextDouble() * (Margines - 1) + 1);
                /* wzór na generowanie liczby losowej z przedział [a, b]
                 rnd() * (b-a) + a; gdzie rnd() jest liczba losową z przedziału
                [0.0, 1.0]*/
                // wylosowanie i-tej figury
                IndexWylosowanejFG = rnd.Next(WybraneFG.Count);
                // rozpoznanie wylosowanej figury geometrycznej i utworzenie jej egzemplarza oraz wykreślenie 
                switch (WybraneFG[IndexWylosowanejFG].ToString())
                {
                    case "Punkt":
                        { // utworzenie egzemplarza Punktu i wpisanie jego referencji do TFG
                            TFG[IndexTFG] = new Punkt(Xp, Yp, Kolor);
                            // wykreślenie Punktu
                            TFG[IndexTFG].Wykreśl(Rysownica);
                            // zwiększenie indeksu tablicy TFG do następnej wolnej pozycji
                            IndexTFG++;
                            break;
                        }
                    case "Linia":
                        { // wylosowanie współrzędnych końca linii
                            Xk = rnd.Next(Margines, Xmax - Margines);
                            Yk = rnd.Next(Margines, Ymax - Margines);
                            // utworzenie egzemplarza Linii i wpisanie jego referencji do TFG
                            TFG[IndexTFG] = new Linia(Xp, Yp, Xk, Yk, Kolor);
                            // wykreślenie Linii
                            TFG[IndexTFG].Wykreśl(Rysownica);
                            // zwiększenie indeksu tablicy TFG do następnej wolnej pozycji
                            IndexTFG++;
                            break;
                        }
                    //Tutaj będzie case dla pozostałych
                    case "Elipsa":
                        {
                            //wylosowanie osi elipsy
                            OśDuża = rnd.Next(Margines, Xmax / 4);
                            OśMała = rnd.Next(Margines, Ymax / 4);

                            //utworzenie egzemplarza elipsy i wpisanie jej referencji do TFG
                            TFG[IndexTFG] = new Elipsa(Xp, Yp, OśDuża, OśMała, Kolor, StylLinii, GrubośćLinii) ;

                            //wykreślenie elipsy
                            TFG[IndexTFG].Wykreśl(Rysownica);
                            IndexTFG++;
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("UWAGA: wybrana figura nie jest wykreślana!" +
                                "Ale już wkrótce . . .");
                            break;
                        }
                } // koniec switch

            } // koniec for
            pbsRysownica.Refresh();
            // ustawienie stanu braku aktywności dla przycisku poleceń START
            btnStart.Enabled = false;
            // uaktywnienie przycisków i kontrolek, których użycie jest dozwolone
            btnPrzesunDoNowegoXY.Enabled = false;
        }

        private void LaboratoriumNr2_Karpowicz61959_FormClosing(object sender, FormClosingEventArgs e)
        {
            // utworzenie okna dialogowego dla spytania Użytkownika
            DialogResult OknoMessage = MessageBox.Show("Czy chcesz zamknąć bieżący formularz i przejść do formularza głównego? (Utracisz niezapisane dane w bieżącym formularzu)", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // sprawdzenie odpowiedzi Użytkownika programu
            if (OknoMessage == DialogResult.Yes)
            {// odszukanie formularza głównego w kolekcji OpenForms
                foreach (Form Formularz in Application.OpenForms)
                    // czy to jest formularz główny
                    if (Formularz.Name == "Kokpit_Karpowicz61959")
                    {// ukrycie bieżącego formularza
                        this.Hide();
                        // odsłonięcie znalezionego egzemplarza formularza głównego
                        Formularz.Show();
                        // zakończenie obsługi zdarzenia FormClosing
                        return;
                    }
                // jeżeli znajdziemy się tutaj, to znaczy, że "ktoś" usunął egzemplarz formularza głównego z kolekcji OpenForms
                MessageBox.Show("AWARIA: 'ktoś' usunął egzemplarz formularza głównego i program nie może działać dalej!!!", this.Text);
                // zamknięcie wszystkich formularzy i wątków (procesów równoległych)
                Application.ExitThread();
            }
            else
                //skasowanie zdarzenia FormClosing
                e.Cancel = true;
        }

        private void ckld_FiguryGeometryczne_SelectedIndexChanged(object sender, EventArgs e)
        { // zgaszenie errorProvider
            errorProvider1.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pbsRysownica.BackColor = colorDialog1.Color;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrzesunDoNowegoXY_Click(object sender, EventArgs e)
        {
            //pomocnicze deklaracje
            Random rnd = new Random();
            int Xmax, Ymax;
            int Xp, Yp;

            //wyczyszczenie powierzchni graficznej
            Rysownica.Clear(pbsRysownica.BackColor);

            //odczytanie rozmiarów powierzchni graficznej
            Xmax = pbsRysownica.Width; Ymax = pbsRysownica.Height;

            /*dla każdego egzemplarza figury geometrycznej losujemy nowe położenie 
             * i ją przesuwamy do nowego położenia */
            //MessageBox.Show("Liczba egzemplarzy w tablicy TFG: " + (TFG.Length).ToString());
            for (int i = 0; i < TFG.Length; i++)
            {
                //wylosowanie współrzędnych położenia i-tej figury geometrycznej 
                Xp = rnd.Next(Margines, Xmax - Margines);
                Yp = rnd.Next(Margines, Ymax - Margines);

                //wywołanie metody (wirtualnej) przesunięcia i-tej figury geometrycznej do nowego (Xp, Yp)
                //MessageBox.Show("Aktualna wartość zmiennej indeksowej: i = " + i.ToString());
                if (TFG[i] is null)
                {
                    MessageBox.Show("Pozycja: " + i.ToString() + " jest pusta");
                }
                else
                {
                    TFG[i].PrzesunDoNowegoXY(pbsRysownica, Rysownica, Xp, Yp);
                }
            }
            //odświeżenie powierzchni graficzneh
            pbsRysownica.Refresh();
        }
    }
}
