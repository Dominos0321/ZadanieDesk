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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zadanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void start()
        {
            infbtn.Checked = true;
            zmianazawodu();
            pierwszybtn.Checked = true;
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


            if (comboBox1.Text == x)
            {
                tekst.Text += "Deklaruję przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie przeprowadzonego w terminie" + " " + x + "\n\n";
            }

            else
            {
                tekst.Text += "Deklaruję przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie przeprowadzonego w terminie" + " " + y + "\n\n";
            }


            tekst.Text += "Dane osobowe ucznia\n Nazwisko:       " + nazwisko + "\n Imię(imiona):     " + imie + "\n Data i miejsce urodzenia:    " + data + ", " + miejsce + "\n Numer PESEL:       " + pesel;
            tekst.Text += "\n Adres korespondencyjny\n miejscowość: " + miejscowosc + "\n ulica i numer domu: " + ulica + "\n kod pocztowy i poczta: " + kod + ", " + poczta + "\n nr telefonu z kierunkowym" + tel + "\n mail: " + mail;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tekst = richTextBox1;
            tekst.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Pliki tekstowe .txt|*.txt|Wszystkie pliki *.*|*.*";
            saveFileDialog1.Title = "Zapisz zawartość";
            saveFileDialog1.DefaultExt = "txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter plik = new StreamWriter(saveFileDialog1.FileName, false);
                plik.WriteLine(richTextBox1.Text);
                plik.Close();
            }
        }


        void infolabelu()
        {
            if (comboBox2.Text == "INF.02")
                label13.Text = "Administracja i eksploatacja systemów komputerowych, \nurządzeń peryferyjnych i lokalnych sieci komputerowych";
            else if (comboBox2.Text == "INF.03")
                label13.Text = "Tworzenie i administrowanie stronami i aplikacjami \ninternetowymi oraz bazami danych";
            else
                label13.Text = "Projektowanie, programowanie i testowanie aplikacji";

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            infolabelu();
        }


        void zmianazawodu()
        {
            if (radioButton1.Checked == true)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("INF.02");
                comboBox2.Items.Add("INF.03");
                comboBox2.Text = "INF.02";
            }
            else
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("INF.03");
                comboBox2.Items.Add("INF.04");
                comboBox2.Text = "INF.03";
                infolabelu();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            zmianazawodu();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            zmianazawodu();
        }
    }
}
