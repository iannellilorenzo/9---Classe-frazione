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
            Display.Items.Add("Risultati (N.B. I risultati non sono automaticamente semplificati):\n\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SalvaBut_Click(object sender, EventArgs e)
        {
            bool parse1, parse2, parse3, parse4;
            int numer1, denom1, numer2, denom2;

            if (SingFrazBut.Checked == true)
            {
                if (check == false)
                {
                    if (frazione1.Denominatore == 0 || Denom1.Text == "0")
                    {
                        MessageBox.Show("Il denominatore deve essere diverso da 0.");
                        return;
                    }

                    MessageBox.Show("Confermare le frazioni con l'apposito tasto.");
                    check = true;
                    return;
                }

                parse1 = int.TryParse(Numer1.Text, out numer1);
                parse2 = int.TryParse(Denom1.Text, out denom1);

                if ((parse1 && parse2) == false)
                {
                    MessageBox.Show("Sono accettati solo valori numerici interi.");
                    return;
                }

                frazione1.Numeratore = numer1;
                frazione1.Denominatore = denom1;

                check = false;
                return;
            }

            if (check == false)
            {
                if (frazione1.Denominatore == 0 || Denom1.Text == "0" || frazione2.Denominatore == 0 || Denom2.Text == "0")
                {
                    MessageBox.Show("I denominatori devono essere diversi da 0.");
                    return;
                }

                MessageBox.Show("Confermare le frazioni con l'apposito tasto.");
                check = true;
                return;
            }

            parse1 = int.TryParse(Numer1.Text, out numer1);
            parse2 = int.TryParse(Denom1.Text, out denom1);

            parse3 = int.TryParse(Numer2.Text, out numer2);
            parse4 = int.TryParse(Denom2.Text, out denom2);

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
            int num1, den1;

            if (SingFrazBut.Checked == false)
            {
                MessageBox.Show("Prima di semplificare, spuntare l'apposita casella.");
                return;
            }

            if (!(String.IsNullOrEmpty(Numer1.Text) && String.IsNullOrEmpty(Denom1.Text)))
            {
                (num1, den1) = frazione1.Semplifica(frazione1);
                Display.Items.Add($"La frazione semplificata è: {num1}/{den1}\n");
            }

            check = true;
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            (risultato.Numeratore, risultato.Denominatore) = risultato.Somma(frazione1, frazione2);

            if (risultato.Numeratore == 0)
            {
                Display.Items.Add($"Il risultato dell'addizione è: {risultato.Numeratore}\n");
                check = true;
                return;
            }

            Display.Items.Add($"Il risultato dell'addizione è: {risultato.Numeratore}/{risultato.Denominatore}\n");

            check = true;
        }

        private void SingFrazBut_CheckedChanged(object sender, EventArgs e)
        {
            if (SingFrazBut.Checked == true)
            {
                AddBut.Hide();
                SottBut.Hide();
                MoltBut.Hide();
                DivBut.Hide();

                FrazLab2.Hide();
                NumLab2.Hide();
                DenLab2.Hide();
                Numer2.Hide();
                Denom2.Hide();

                FrazLab1.Text = "Frazione";
                SalvaBut.Text = "Salva Frazione";
            }
            else
            {
                AddBut.Show();
                SottBut.Show();
                MoltBut.Show();
                DivBut.Show();

                FrazLab2.Show();
                NumLab2.Show();
                DenLab2.Show();
                Numer2.Show();
                Denom2.Show();

                FrazLab1.Text = "Frazione 1";
                SalvaBut.Text = "Salva Frazioni";
            }
        }

        private void SottBut_Click(object sender, EventArgs e)
        {
            (risultato.Numeratore, risultato.Denominatore) = risultato.Sottrai(frazione1, frazione2);

            if (risultato.Numeratore == 0)
            {
                Display.Items.Add($"Il risultato della sottrazione è: {risultato.Numeratore}\n");
                check = true;
                return;
            }

            Display.Items.Add($"Il risultato della sottrazione è: {risultato.Numeratore}/{risultato.Denominatore}\n");

            check = true;
        }

        private void MoltBut_Click(object sender, EventArgs e)
        {
            (risultato.Numeratore, risultato.Denominatore) = risultato.Moltiplica(frazione1, frazione2);

            if (risultato.Numeratore == 0)
            {
                Display.Items.Add($"Il risultato della moltiplicazione è: {risultato.Numeratore}\n");
                check = true;
                return;
            }

            Display.Items.Add($"Il risultato della moltiplicazione è: {risultato.Numeratore}/{risultato.Denominatore}\n");

            check = true;
        }

        private void DivBut_Click(object sender, EventArgs e)
        {
            (risultato.Numeratore, risultato.Denominatore) = risultato.Dividi(frazione1, frazione2);

            if (risultato.Numeratore == 0)
            {
                Display.Items.Add($"Il risultato della divisione è: {risultato.Numeratore}\n");
                check = true;
                return;
            }

            Display.Items.Add($"Il risultato della divisione è: {risultato.Numeratore}/{risultato.Denominatore}\n");

            check = true;
        }
    }
}
