namespace Applicationnr7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Zakoncz = new Button();
            buttonWypisz = new Button();
            textBoxImieWypisz = new TextBox();
            textBoxNazwiskoWypisz = new TextBox();
            textBoxWiekWypisz = new TextBox();
            buttonOK_Click = new Button();
            button1 = new Button();
            textBoxWielkoscTablicy = new TextBox();
            textBoxPozostalo = new TextBox();
            textBoxNumer = new TextBox();
            buttonZapisz = new Button();
            textBoxRozmiarTablicy = new TextBox();
            textBoxImie = new TextBox();
            textBoxNazwisko = new TextBox();
            textBoxWiek = new TextBox();
            SuspendLayout();
            // 
            // Zakoncz
            // 
            Zakoncz.Location = new Point(699, 415);
            Zakoncz.Name = "Zakoncz";
            Zakoncz.Size = new Size(75, 23);
            Zakoncz.TabIndex = 0;
            Zakoncz.Text = "Zakoncz";
            Zakoncz.UseVisualStyleBackColor = true;
            Zakoncz.Click += Zakoncz_Click;
            // 
            // buttonWypisz
            // 
            buttonWypisz.Location = new Point(656, 77);
            buttonWypisz.Name = "buttonWypisz";
            buttonWypisz.Size = new Size(75, 23);
            buttonWypisz.TabIndex = 1;
            buttonWypisz.Text = "Wypisz";
            buttonWypisz.UseVisualStyleBackColor = true;
            buttonWypisz.Click += button1_Click;
            // 
            // textBoxImieWypisz
            // 
            textBoxImieWypisz.Location = new Point(522, 35);
            textBoxImieWypisz.Name = "textBoxImieWypisz";
            textBoxImieWypisz.Size = new Size(100, 23);
            textBoxImieWypisz.TabIndex = 2;
            // 
            // textBoxNazwiskoWypisz
            // 
            textBoxNazwiskoWypisz.Location = new Point(522, 77);
            textBoxNazwiskoWypisz.Name = "textBoxNazwiskoWypisz";
            textBoxNazwiskoWypisz.Size = new Size(100, 23);
            textBoxNazwiskoWypisz.TabIndex = 3;
            // 
            // textBoxWiekWypisz
            // 
            textBoxWiekWypisz.Location = new Point(522, 115);
            textBoxWiekWypisz.Name = "textBoxWiekWypisz";
            textBoxWiekWypisz.Size = new Size(100, 23);
            textBoxWiekWypisz.TabIndex = 4;
            // 
            // buttonOK_Click
            // 
            buttonOK_Click.Location = new Point(265, 34);
            buttonOK_Click.Name = "buttonOK_Click";
            buttonOK_Click.Size = new Size(75, 23);
            buttonOK_Click.TabIndex = 5;
            buttonOK_Click.Text = "OK";
            buttonOK_Click.UseVisualStyleBackColor = true;
            buttonOK_Click.Click += button1_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(360, 34);
            button1.Name = "button1";
            button1.Size = new Size(105, 23);
            button1.TabIndex = 6;
            button1.Text = "Wyczyść tablice";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // textBoxWielkoscTablicy
            // 
            textBoxWielkoscTablicy.Location = new Point(88, 77);
            textBoxWielkoscTablicy.Name = "textBoxWielkoscTablicy";
            textBoxWielkoscTablicy.Size = new Size(150, 23);
            textBoxWielkoscTablicy.TabIndex = 7;
            // 
            // textBoxPozostalo
            // 
            textBoxPozostalo.Location = new Point(88, 106);
            textBoxPozostalo.Name = "textBoxPozostalo";
            textBoxPozostalo.Size = new Size(63, 23);
            textBoxPozostalo.TabIndex = 8;
            // 
            // textBoxNumer
            // 
            textBoxNumer.Location = new Point(182, 106);
            textBoxNumer.Name = "textBoxNumer";
            textBoxNumer.Size = new Size(56, 23);
            textBoxNumer.TabIndex = 9;
            // 
            // buttonZapisz
            // 
            buttonZapisz.Location = new Point(88, 415);
            buttonZapisz.Name = "buttonZapisz";
            buttonZapisz.Size = new Size(75, 23);
            buttonZapisz.TabIndex = 10;
            buttonZapisz.Text = "Zapisz";
            buttonZapisz.UseVisualStyleBackColor = true;
            buttonZapisz.Click += buttonZapisz_Click;
            // 
            // textBoxRozmiarTablicy
            // 
            textBoxRozmiarTablicy.Location = new Point(88, 34);
            textBoxRozmiarTablicy.Name = "textBoxRozmiarTablicy";
            textBoxRozmiarTablicy.Size = new Size(150, 23);
            textBoxRozmiarTablicy.TabIndex = 11;
            // 
            // textBoxImie
            // 
            textBoxImie.Location = new Point(88, 213);
            textBoxImie.Name = "textBoxImie";
            textBoxImie.Size = new Size(100, 23);
            textBoxImie.TabIndex = 12;
            // 
            // textBoxNazwisko
            // 
            textBoxNazwisko.Location = new Point(88, 251);
            textBoxNazwisko.Name = "textBoxNazwisko";
            textBoxNazwisko.Size = new Size(100, 23);
            textBoxNazwisko.TabIndex = 13;
            // 
            // textBoxWiek
            // 
            textBoxWiek.Location = new Point(88, 289);
            textBoxWiek.Name = "textBoxWiek";
            textBoxWiek.Size = new Size(100, 23);
            textBoxWiek.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxWiek);
            Controls.Add(textBoxNazwisko);
            Controls.Add(textBoxImie);
            Controls.Add(textBoxRozmiarTablicy);
            Controls.Add(buttonZapisz);
            Controls.Add(textBoxNumer);
            Controls.Add(textBoxPozostalo);
            Controls.Add(textBoxWielkoscTablicy);
            Controls.Add(button1);
            Controls.Add(buttonOK_Click);
            Controls.Add(textBoxWiekWypisz);
            Controls.Add(textBoxNazwiskoWypisz);
            Controls.Add(textBoxImieWypisz);
            Controls.Add(buttonWypisz);
            Controls.Add(Zakoncz);
            Name = "Form1";
            Text = "Aplikacja zadanie 7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Zakoncz;
        private Button buttonWypisz;
        private TextBox textBoxImieWypisz;
        private TextBox textBoxNazwiskoWypisz;
        private TextBox textBoxWiekWypisz;
        private Button buttonOK_Click;
        private Button button1;
        private TextBox textBoxWielkoscTablicy;
        private TextBox textBoxPozostalo;
        private TextBox textBoxNumer;
        private Button buttonZapisz;
        private TextBox textBoxRozmiarTablicy;
        private TextBox textBoxImie;
        private TextBox textBoxNazwisko;
        private TextBox textBoxWiek;
    }
}
