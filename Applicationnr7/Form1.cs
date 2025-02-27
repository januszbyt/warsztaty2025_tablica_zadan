using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Applicationnr7
{
    public partial class Form1 : Form
    {


        public List<Student> tablica = new List<Student>();
        public int rozmiar, indeks;
        public int imie, nazwisko;
        public Form1()
        {

            InitializeComponent();
            rozmiar = 0;
            indeks = 0;
            tablica = new List<Student>();
        }

        public Form1(int imieMax, int maxNazwisko) : this()
        {

            imie = imieMax;
            nazwisko = maxNazwisko;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int liczba;
            bool czy_numer = int.TryParse(textBoxRozmiarTablicy.Text, out liczba);

            if (!czy_numer || liczba < 1)
            {
                MessageBox.Show("Podaj w³aœciwy rozmiar tablicy!", "UWAGA!", MessageBoxButtons.OK);
                textBoxRozmiarTablicy.Clear();
                return;
            }

            rozmiar = liczba;
            textBoxWielkoscTablicy.Text = textBoxPozostalo.Text = rozmiar.ToString();
            textBoxRozmiarTablicy.Clear();
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            if (indeks < rozmiar)
            {
                if (textBoxImie.Text.Length >= imie)
                {
                    MessageBox.Show($"Podaj imiê o d³ugoœci do {imie} liter", "UWAGA!", MessageBoxButtons.OK);
                    return;
                }
                else if (textBoxNazwisko.Text.Length >= nazwisko)
                {
                    MessageBox.Show($"Podaj nazwisko o d³ugoœci do {nazwisko} liter", "UWAGA!", MessageBoxButtons.OK);
                    return;
                }

                int wiek;
                bool czy_numer = int.TryParse(textBoxWiek.Text, out wiek);
                if (!czy_numer || wiek <= 0 || wiek > 150)
                {
                    MessageBox.Show("Podaj w³aœciwy wiek!", "UWAGA!", MessageBoxButtons.OK);
                    textBoxWiek.Clear();
                    return;
                }

                tablica.Add(new Student(textBoxImie.Text, textBoxNazwisko.Text, wiek));
                textBoxImie.Clear();
                textBoxNazwisko.Clear();
                textBoxWiek.Clear();

                indeks++;
                textBoxPozostalo.Text = (rozmiar - indeks).ToString();

                if (indeks == rozmiar)
                {
                    MessageBox.Show("Tablica pe³na", "UWAGA!", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Tablica pe³na", "UWAGA!", MessageBoxButtons.OK);
                textBoxImie.Clear();
                textBoxNazwisko.Clear();
                textBoxWiek.Clear();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            textBoxRozmiarTablicy.Clear();
            textBoxPozostalo.Clear();
            textBoxWielkoscTablicy.Clear();
            textBoxImie.Clear();
            textBoxNazwisko.Clear();
            textBoxWiek.Clear();
            textBoxNumer.Clear();
            textBoxImieWypisz.Clear();
            textBoxNazwiskoWypisz.Clear();
            textBoxWiekWypisz.Clear();

            rozmiar = 0;
            indeks = 0;
            tablica.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int numer;
            bool czy_numer = int.TryParse(textBoxNumer.Text, out numer);

            if (czy_numer && numer <= rozmiar && numer > 0 && numer <= tablica.Count)
            {
                int numerek = numer - 1;
                textBoxImieWypisz.Text = tablica[numerek].Imie;
                textBoxNazwiskoWypisz.Text = tablica[numerek].Nazwisko;
                textBoxWiekWypisz.Text = tablica[numerek].Wiek.ToString();
            }
            else
            {
                MessageBox.Show("Poda³eœ nieistniej¹cy numer!", "UWAGA!", MessageBoxButtons.OK);
                textBoxNumer.Clear();
            }
            textBoxNumer.Clear();
        }
        private void Zakoncz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
