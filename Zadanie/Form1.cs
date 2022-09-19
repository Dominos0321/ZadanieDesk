using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            var selecty = comboBox2.Items;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            var tekst = richTextBox1;
            TextWriter txt = new StreamWriter("C:\\Users\\student\\Desktop\\zad\\zad.txt");
            txt.Write(tekst.Text);
            txt.Close();
        }
    }
}
