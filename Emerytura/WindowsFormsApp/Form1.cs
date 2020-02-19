using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Imie_Click(object sender, EventArgs e)
        {

        }

        private void buttonOblicz_Click(object sender, EventArgs e)
        {
            string imie = textBoxImie.Text;                 
            string nazwisko = textBoxNazwisko.Text;
            int wiek = int.Parse(textBoxWiek.Text);

            if(wiek>=67)
            {
                labelWynik.Text = $"Witaj {imie} {nazwisko}! Jesteś emerytem";
            }
            else
            {
                labelWynik.Text = $"Witaj {imie} {nazwisko}! Do emerytury zostało ci {67 - wiek} lat";
            }
        }

        private void labelWynik_Click(object sender, EventArgs e)
        {

        }
    }
}
