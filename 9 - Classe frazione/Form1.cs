using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9___Classe_frazione
{
    public partial class Form1 : Form
    {
        Frazione frazione1;
        Frazione frazione2;
        Frazione risultato;
        bool check;

        public Form1()
        {
            InitializeComponent();
            frazione1 = new Frazione();
            frazione2 = new Frazione();
            risultato = new Frazione();
            check = true;
            Display.Items.Add("Output:\n\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SalvaBut_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                if (frazione1.Denominatore == 0 || Denom1.Text == "0" || frazione2.Denominatore == 0 || Denom2.Text == "0")
                {
                    MessageBox.Show("I denominatori devono essere diversi da 0.");
                    return;
                }

                MessageBox.Show("Confermare le frazioni con l'apposito tasto.");
                return;
            }
            
            bool parse1 = int.TryParse(Numer1.Text, out int numer1);
            bool parse2 = int.TryParse(Denom1.Text, out int denom1);

            bool parse3 = int.TryParse(Numer2.Text, out int numer2);
            bool parse4 = int.TryParse(Denom2.Text, out int denom2);

            if ((parse1 && parse2 && parse3 && parse4) == false)
            {
                MessageBox.Show("Sono accettati solo valori numerici interi.");
                return;
            }

            frazione1.Numeratore = numer1;
            frazione1.Denominatore = denom1;

            frazione2.Numeratore = numer2;
            frazione2.Denominatore = denom2;

            check = false;
        }

        private void SempBut_Click(object sender, EventArgs e)
        {
            int num1 = 0, num2 = 0, den1 = 0, den2 = 0;

            

            //if (String.IsNullOrEmpty(Numer1.Text) && String.IsNullOrEmpty(Denom1.Text))
            //{
            //    (num2, den2) = frazione2.Semplifica();
            //    Display.Items.Add($"La frazione 1 semplificata è: {num1}/{den1}\n");
            //}

            //if (String.IsNullOrEmpty(Numer2.Text) && String.IsNullOrEmpty(Denom2.Text))
            //{
            //    (num1, den1) = frazione1.Semplifica();
            //    Display.Items.Add($"La frazione 2 semplificata è: {num2}/{den2}\n");
            //}


            check = false;
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            (risultato.Numeratore, risultato.Denominatore) = risultato.Somma(frazione1, frazione2);

            Display.Items.Add($"Il risultato della somma è: {risultato.Numeratore}/{risultato.Denominatore}\n");

            check = false;
        }
    }
}
