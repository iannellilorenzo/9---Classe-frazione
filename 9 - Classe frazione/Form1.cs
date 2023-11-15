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
        FrazioneEstesa frazioneDec;

        public Form1()
        {
            InitializeComponent();
            frazione1 = new Frazione();
            frazione2 = new Frazione();
            risultato = new Frazione();
            frazioneDec = new FrazioneEstesa();
            Display.Items.Add("Risultati (N.B. I risultati non sono automaticamente semplificati):\n\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private static (int, int, bool) Check(string num, string den)
        {
            if (num == "0" || den == "0" || String.IsNullOrEmpty(num) || String.IsNullOrEmpty(den))
            {
                return (0, 0, false);
            }

            bool numerBool = int.TryParse(num, out int numer);
            bool denomBool = int.TryParse(den, out int denom);

            return (numer, denom, numerBool);
        }

        private void SempBut_Click(object sender, EventArgs e)
        {
            (int num0, int den0, bool numBool) = Check(Numer1.Text, Denom1.Text);

            if (numBool == false)
            {
                if (Denom1.Text == "0")
                {
                    MessageBox.Show("Il denominatore deve essere maggiore di 0");
                    return;
                }

                MessageBox.Show("Sono accettati solo valori numerici interi.");
                return;
            }

            frazione1.Numeratore = num0;
            frazione1.Denominatore = den0;

            (risultato.Numeratore, risultato.Denominatore) = frazione1.Semplifica(frazione1);
            Display.Items.Add($"La frazione semplificata è: {risultato.Numeratore}/{risultato.Denominatore}\n");
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            (int num1, int den1, bool numBool) = Check(Numer1.Text, Denom1.Text);
            (int num2, int den2, bool appNumBool) = Check(Numer2.Text, Denom2.Text);
            
            if (numBool == false || appNumBool == false)
            {
                if (Denom1.Text == "0" || Denom2.Text == "0")
                {
                    MessageBox.Show("Il denominatore deve essere maggiore di 0");
                    return;
                }

                MessageBox.Show("Sono accettati solo valori numerici interi.");
                return;
            }

            frazione1.Numeratore = num1;
            frazione1.Denominatore = den1;

            frazione2.Numeratore = num2;
            frazione2.Denominatore = den2;

            (risultato.Numeratore, risultato.Denominatore) = risultato.Somma(frazione1, frazione2);

            if (risultato.Numeratore == 0)
            {
                Display.Items.Add("Il risultato dell'addizione è: 0\n");
                return;
            }

            Display.Items.Add($"Il risultato dell'addizione è: {risultato.Numeratore}/{risultato.Denominatore}\n");
        }

        private void OperFondBut_CheckedChanged(object sender, EventArgs e)
        {
            if (OperFondBut.Checked == true && AltreFunBut.Checked == false)
            {
                AddBut.Enabled = true;
                SottBut.Enabled = true;
                MoltBut.Enabled = true;
                DivBut.Enabled = true;

                SempBut.Enabled = false;
                FrazDecBut.Enabled = false;
                DecFrazBut.Enabled = false;
                PotBut.Enabled = false;
                ValDec.Enabled = false;

                return;
            }
            
            if (OperFondBut.Checked == false && AltreFunBut.Checked == true)
            {
                AddBut.Enabled = false;
                SottBut.Enabled = false;
                MoltBut.Enabled = false;
                DivBut.Enabled = false;

                SempBut.Enabled = true;
                FrazDecBut.Enabled = true;
                DecFrazBut.Enabled = true;
                PotBut.Enabled = true;
                ValDec.Enabled = true;

                Denom2.Enabled = false;
                Denom2.Text = "";

                return;
            }

            if (OperFondBut.Checked == false && AltreFunBut.Checked == false)
            {
                AddBut.Enabled = false;
                SottBut.Enabled = false;
                MoltBut.Enabled = false;
                DivBut.Enabled = false;

                SempBut.Enabled = false;
                FrazDecBut.Enabled = false;
                DecFrazBut.Enabled = false;
                PotBut.Enabled = false;
                ValDec.Enabled = false;

                Denom2.Enabled = true;
                Denom2.Text = "";

                return;
            }

            if (OperFondBut.Checked == true && AltreFunBut.Checked == true)
            {
                AddBut.Enabled = false;
                SottBut.Enabled = false;
                MoltBut.Enabled = false;
                DivBut.Enabled = false;

                SempBut.Enabled = false;
                FrazDecBut.Enabled = false;
                DecFrazBut.Enabled = false;
                PotBut.Enabled = false;
                ValDec.Enabled = false;

                MessageBox.Show("È possibile selezionare solamente un gruppo di funzioni alla volta.");
            }
        }

        private void SottBut_Click(object sender, EventArgs e)
        {
            (int num1, int den1, bool numBool) = Check(Numer1.Text, Denom1.Text);
            (int num2, int den2, bool appNumBool) = Check(Numer2.Text, Denom2.Text);
            
            if (numBool == false || appNumBool == false)
            {
                if (Denom1.Text == "0" || Denom2.Text == "0")
                {
                    MessageBox.Show("Il denominatore deve essere maggiore di 0");
                    return;
                }

                MessageBox.Show("Sono accettati solo valori numerici interi.");
                return;
            }

            frazione1.Numeratore = num1;
            frazione1.Denominatore = den1;

            frazione2.Numeratore = num2;
            frazione2.Denominatore = den2;

            (risultato.Numeratore, risultato.Denominatore) = risultato.Sottrai(frazione1, frazione2);

            if (risultato.Numeratore == 0)
            {
                Display.Items.Add($"Il risultato della sottrazione è: {risultato.Numeratore}\n");
                return;
            }

            Display.Items.Add($"Il risultato della sottrazione è: {risultato.Numeratore}/{risultato.Denominatore}\n");
        }

        private void MoltBut_Click(object sender, EventArgs e)
        {
            (int num1, int den1, bool numBool) = Check(Numer1.Text, Denom1.Text);
            (int num2, int den2, bool appNumBool) = Check(Numer2.Text, Denom2.Text);
            
            if (numBool == false || appNumBool == false)
            {
                if (Denom1.Text == "0" || Denom2.Text == "0")
                {
                    MessageBox.Show("Il denominatore deve essere maggiore di 0");
                    return;
                }

                MessageBox.Show("Sono accettati solo valori numerici interi.");
                return;
            }

            frazione1.Numeratore = num1;
            frazione1.Denominatore = den1;

            frazione2.Numeratore = num2;
            frazione2.Denominatore = den2;

            (risultato.Numeratore, risultato.Denominatore) = risultato.Moltiplica(frazione1, frazione2);

            if (risultato.Numeratore == 0)
            {
                Display.Items.Add($"Il risultato della moltiplicazione è: {risultato.Numeratore}\n");
                return;
            }

            Display.Items.Add($"Il risultato della moltiplicazione è: {risultato.Numeratore}/{risultato.Denominatore}\n");
        }

        private void DivBut_Click(object sender, EventArgs e)
        {
            (int num1, int den1, bool numBool) = Check(Numer1.Text, Denom1.Text);
            (int num2, int den2, bool appNumBool) = Check(Numer2.Text, Denom2.Text);
            
            if (numBool == false || appNumBool == false)
            {
                if (Denom1.Text == "0" || Denom2.Text == "0")
                {
                    MessageBox.Show("Il denominatore deve essere maggiore di 0");
                    return;
                }

                MessageBox.Show("Sono accettati solo valori numerici interi.");
                return;
            }

            frazione1.Numeratore = num1;
            frazione1.Denominatore = den1;

            frazione2.Numeratore = num2;
            frazione2.Denominatore = den2;

            (risultato.Numeratore, risultato.Denominatore) = risultato.Dividi(frazione1, frazione2);

            if (risultato.Numeratore == 0)
            {
                Display.Items.Add($"Il risultato della divisione è: {risultato.Numeratore}\n");
                return;
            }

            Display.Items.Add($"Il risultato della divisione è: {risultato.Numeratore}/{risultato.Denominatore}\n");
        }

        private void FrazDecBut_Click(object sender, EventArgs e)
        {
            (int num1, int den1, bool numBool) = Check(Numer1.Text, Denom1.Text);

            if (numBool == false)
            {
                if (Denom1.Text == "0")
                {
                    MessageBox.Show("Il denominatore deve essere maggiore di 0");
                    return;
                }

                MessageBox.Show("Sono accettati solo valori numerici interi.");
                return;
            }

            frazioneDec.Numeratore = num1;
            frazioneDec.Denominatore = den1;

            double dec = frazioneDec.FrazDec(frazioneDec);

            Display.Items.Add($"Il valore decimale della frazione è: {dec}\n");
        }

        private void DecFrazBut_Click(object sender, EventArgs e)
        {
            bool check = double.TryParse(ValDec.Text, out double decimale);

            if (check == false)
            {
                MessageBox.Show("Sono accettati solo valori numerici a virgola mobile nel formato: x.ab");
                return;
            }

            (risultato.Numeratore, risultato.Denominatore) = frazioneDec.DecFraz(ValDec.Text);

            Display.Items.Add($"Il valore frazionario è: {risultato.Numeratore}/{risultato.Denominatore}");
        }

        private void PotBut_Click(object sender, EventArgs e)
        {
            (int num1, int den1, bool numBool) = Check(Numer1.Text, Denom1.Text);

            bool pot = int.TryParse(Numer2.Text, out int espo);
            
            if (numBool == false || pot == false)
            {
                if (Denom1.Text == "0")
                {
                    MessageBox.Show("Il denominatore deve essere maggiore di 0");
                    return;
                }

                MessageBox.Show("Sono accettati solo valori numerici interi.");
                return;
            }

            frazioneDec.Numeratore = num1;
            frazioneDec.Denominatore = den1;

            (risultato.Numeratore, risultato.Denominatore) = frazioneDec.Potenza(frazioneDec, espo);

            Display.Items.Add($"Il risultato della potenza è: {risultato.Numeratore}/{risultato.Denominatore}");
        }

        private void AltreFunBut_CheckedChanged(object sender, EventArgs e)
        {
            OperFondBut_CheckedChanged(sender, e);
        }
    }
}
