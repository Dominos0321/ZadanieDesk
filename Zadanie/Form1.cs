using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tekst = richTextBox1;
            string x = "styczeń";
            string y = "czerwiec";
            string imie = textBox2.Text;
            string nazwisko = textBox1.Text;
            string data = maskedTextBox1.Text;
            string miejsce = textBox4.Text;
            string pesel = maskedTextBox2.Text;
            string miejscowosc = textBox6.Text;
            string ulica = textBox7.Text;
            string kod = maskedTextBox3.Text;
            string poczta = textBox9.Text;
            string tel = textBox10.Text;
            string mail = textBox11.Text;


            if (comboBox1.Text==x)
            {
                tekst.Text += "Deklaruję przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie przeprowadzonego w terminie" +" " + x +"\n\n";
            }

            else
            {
                tekst.Text += "Deklaruję przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie przeprowadzonego w terminie" + " " + y + "\n\n";
            }


            tekst.Text += "Dane osobowe ucznia\n Nazwisko:       "+nazwisko +"\n Imię(imiona):     "+imie +"\n Data i miejsce urodzenia:    "+data+", "+miejsce +"\n Numer PESEL:       "+ pesel;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tekst = richTextBox1;
            tekst.Clear();
        }
    }
}
