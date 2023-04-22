using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektNr2_Karpowicz61959
{
    public partial class Kokpit_Karpowicz61959 : Form
    {
        public Kokpit_Karpowicz61959()
        {
            InitializeComponent();
        }

        private void btnLaboratorium_Click(object sender, EventArgs e)
        {
            foreach (Form Formularz in Application.OpenForms)
                // czy został znaleziony formularz LaboratoriumNr2
                if (Formularz.Name == "LaboratoriumNr2_Karpowicz61959")
                {
                    // ukrycie bieżącego (głównego) formularza
                    this.Hide();
                    // odsłonięcie znalezionego formularza LaboratoriumNr2
                    Formularz.Show();
                    // bezwarunkowe zakończenie metody obsługi zdarzenia Click
                    return;
                }
            // formularz LaboratoriumNr2 nie został znaleziony
            // utworzyć egzemplarz formularza LaboratoriumNr1
            LaboratoriumNr2_Karpowicz61959 FormLaboratoriumNr2_Karpowicz = new LaboratoriumNr2_Karpowicz61959();
            // ukrycie bieżącego (głównego) formularza
            this.Hide();
            // odsłonięcie znalezionego formularza LaboratoriumNr2
            FormLaboratoriumNr2_Karpowicz.Show();
            // bezwarunkowe zakończenie metody obsługi zdarzenia Click
            return;
        }

        private void Kokpit_Karpowicz61959_FormClosing(object sender, FormClosingEventArgs e)
        {
            // utworzenie okna dialogowego dla spytania Użytkownika
            DialogResult OknoMessage = MessageBox.Show("Czy chcesz zamknąć program?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void btnProjekt_Click(object sender, EventArgs e)
        {
            foreach (Form Formularz in Application.OpenForms)
                if (Formularz.Name == "ProjektNr2_Karpowicz61959")
                {
                    // ukrycie bieżącego (głównego) formularza
                    this.Hide();
                    Formularz.Show();
                    // bezwarunkowe zakończenie metody obsługi zdarzenia Click
                    return;
                }

            ProjektNr2_Karpowicz61959 FormProjektNr1_Karpowicz = new ProjektNr2_Karpowicz61959();
            // ukrycie bieżącego (głównego) formularza
            this.Hide();

            FormProjektNr1_Karpowicz.Show();
            // bezwarunkowe zakończenie metody obsługi zdarzenia Click
            return;
        }
    }
}
