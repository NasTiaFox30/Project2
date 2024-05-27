using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Projekt_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        
        }

        private void radioBtnPLN1_CheckedChanged(object sender, EventArgs e)
        {

            if (double.TryParse(textBox1.Text, out double waluta1AB))
            {
                Konwersja(waluta1AB);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Poprawność();

            if (double.TryParse(textBox1.Text, out double waluta1AB))
            {
                Konwersja(waluta1AB);
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double waluta1AB))
            {
                waluta1AB = hScrollBar1.Value;
                Konwersja(waluta1AB);
                textBox1.Text = Convert.ToString(waluta1AB);
            }
        }

        //Zamykanie programu
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001B') //przycisk ESC
                Close();
        }


                //METODY:

        public void Poprawność()    //sprawdza prawidlowość napisania
        {
            textBox1.Text = textBox1.Text.Replace(" ", "");
            int indeks_kropkaAB = textBox1.Text.IndexOf(".");
            if (indeks_kropkaAB != -1)
            {
                MessageBox.Show("Proszę używać przecinek ',' !", "Nieprawidlowe znaki", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                textBox1.Text = textBox1.Text.Replace(".", "");
            }
        }

        public void Konwersja(double waluta)    //konwertuje waluty 
        {
            //anulowanie dostępu do radiobutton'ów
            radioBtnPLN1.Enabled = true;
            radioBtnUSD2.Enabled = true;
            radioBtnEUR3.Enabled = true;
            radioBtnAB4.Enabled = true;
            radioBtnUSD5.Enabled = true;
            radioBtnEUR6.Enabled = true;
            radioBtnPLN7.Enabled = true;
            radioBtnAB8.Enabled = true;

            

            //PLN
            if (radioBtnPLN1.Checked)
            {
                //5.Nazwy walut w etykielach (Label) pojawiają się zgodnie z nazwami walut zaznaczonymi w kontrolkach RadioButton
                //labelWalutaŹród.Text = "PLN";     //sposób1
                labelWalutaŹród.Text = radioBtnPLN1.Text;   //sposób2
                labelZnak1.Text = "zł";
                radioBtnPLN7.Enabled = false;

                if (radioBtnUSD5.Checked) //USD
                {
                    //labelWalutaDocel.Text = "USD";
                    labelWalutaDocel.Text = radioBtnUSD2.Text;
                    labelZnak2.Text = "$";
                    radioBtnUSD2.Enabled = false;
                    textBox2.Text = Convert.ToString(waluta / 4.002);
                }
                if (radioBtnEUR6.Checked) //EUR
                {
                    //labelWalutaDocel.Text = "EUR";
                    labelWalutaDocel.Text = radioBtnEUR3.Text;
                    labelZnak2.Text = "€";
                    radioBtnEUR3.Enabled = false;
                    textBox2.Text = Convert.ToString(waluta / 4.3785);
                }
                if (radioBtnAB8.Checked) //AB
                {
                    //labelWalutaDocel.Text = "AB";
                    labelWalutaDocel.Text = radioBtnAB8.Text;
                    labelZnak2.Text = "ab";
                    radioBtnAB4.Checked = false;
                    textBox2.Text = Convert.ToString(waluta / 6.6702);
                }
            }

            //USD
            if (radioBtnUSD2.Checked)
            {
                labelWalutaŹród.Text = "USD";
                labelZnak1.Text = "$";
                radioBtnUSD5.Enabled = false;

                if (radioBtnEUR6.Checked) //EUR
                {
                    labelWalutaDocel.Text = "EUR";
                    labelZnak2.Text = "€";
                    radioBtnEUR3.Enabled = false;
                    textBox2.Text = Convert.ToString(waluta * 0.91);
                }
                if (radioBtnPLN7.Checked) //PLN
                {
                    labelWalutaDocel.Text = "PLN";
                    labelZnak2.Text = "zł";
                    radioBtnPLN1.Enabled = false;
                    textBox2.Text = Convert.ToString(waluta * 3.98);
                }
                if (radioBtnAB8.Checked) //AB
                {
                    labelWalutaDocel.Text = "AB";
                    labelZnak2.Text = "ab";
                    radioBtnAB4.Checked = false;
                    textBox2.Text = Convert.ToString(waluta * 0.5967);
                }
                
            }
           

            //EUR
            if (radioBtnEUR3.Checked)
            {
                labelWalutaŹród.Text = "EUR";
                labelZnak1.Text = "€";
                radioBtnEUR6.Enabled = false;

                if (radioBtnUSD5.Checked) //USD
                {
                    labelWalutaDocel.Text = "USD";
                    labelZnak2.Text = "$";
                    radioBtnUSD2.Enabled = false;
                    textBox2.Text = Convert.ToString(waluta / 1.123);
                }
                if (radioBtnPLN7.Checked) //PLN
                {
                    labelWalutaDocel.Text = "PLN";
                    labelZnak2.Text = "zł";
                    radioBtnPLN1.Enabled = false;
                    textBox2.Text = Convert.ToString(waluta * 4.3602);
                }
                if (radioBtnAB8.Checked) //AB
                {
                    labelWalutaDocel.Text = "AB";
                    labelZnak2.Text = "ab";
                    radioBtnAB4.Checked = false;
                    textBox2.Text = Convert.ToString(waluta * 0.6537);
                }
                
            }


            //AB
            if (radioBtnAB4.Checked)
            {
                labelWalutaŹród.Text = "AB";
                labelZnak1.Text = "ab";
                radioBtnAB8.Enabled = false;

                if (radioBtnUSD5.Checked) //USD
                {
                    labelWalutaDocel.Text = "USD";
                    labelZnak2.Text = "$";
                    radioBtnUSD2.Enabled = false;
                    textBox2.Text = Convert.ToString(waluta / 0.612);
                }
                if (radioBtnEUR6.Checked) //EUR
                {
                    labelWalutaDocel.Text = "EUR";
                    labelZnak2.Text = "€";
                    radioBtnEUR3.Enabled = false;
                    textBox2.Text = Convert.ToString(waluta / 0.6903);
                }
                if (radioBtnPLN7.Checked) //PLN
                {
                    labelWalutaDocel.Text = "PLN";
                    labelZnak2.Text = "zł";
                    radioBtnPLN1.Enabled = false;
                    textBox2.Text = Convert.ToString(waluta * 6.6617);
                }
            }
            if (radioBtnAB8.Checked) radioBtnAB4.Enabled = false;
            else radioBtnAB4.Enabled = true;
        }

       
    }
}
