using System.Media;
using System.Xml.XPath;

namespace Calculatrice
{
    public partial class FormCalculatrice : Form
    {
        private Calcul _calculate;
        private Memory _memory;
        public FormCalculatrice()
        {


            InitializeComponent();
            txbCalcul.Text = "0";
            _calculate = new Calcul();
            _memory = new Memory();
        }
        /// <summary>
        /// Evenement lié au boutons numeriques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (txbCalcul.Text == "0") 
            {
                txbCalcul.Text = string.Empty;
            }
            
            if (_calculate.CalculState == CalculStateEnum.BeginAquireOperand2)
            {
                txbCalcul.Text = string.Empty;
                _calculate.CalculState = CalculStateEnum.AquireOperand2;
            }
            
            if (_memory.MemoryState == MemoryStateEnum.Saved)
            {
                txbCalcul.Text = string.Empty;
                _memory.MemoryState = MemoryStateEnum.Full;

            }

            string sNumber = (sender as Button).Text;
            txbCalcul.Text += sNumber;
        }
        /// <summary>
        /// verifie s'il n'y pas operande 
        /// donne cette derniere
        /// et clear la txbCalcul
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperand_click(object sender, EventArgs e)
        {
            string sOperand = (sender as Button).Text;
            _calculate.Operation = sOperand;

            if (_calculate.CalculState == CalculStateEnum.AquireOperand1)
            {
                double result;
                try
                {
                    result = Double.Parse(txbCalcul.Text);
                    _calculate.Operand1 = result;
                    _calculate.CalculState = CalculStateEnum.BeginAquireOperand2;
                }
                catch (Exception)
                {

                }
            }
            if (_calculate.CalculState == CalculStateEnum.BeginAquireOperand2)
            {
                _calculate.CalculState = CalculStateEnum.Calculation;
            }
            if (_calculate.CalculState == CalculStateEnum.Calculation)
            {
                double result = _calculate.Calculate();
                txbCalcul.Text = result.ToString();

                // le resultat devient l'operande 1

                _calculate.Operand1 = result;
            }

            // Efface la txb avant d'acquerir la deuxieme operande
            _calculate.CalculState = CalculStateEnum.BeginAquireOperand2;
        }
        /// <summary>
        /// Supprime le dernier caractere de tbxCalcul
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txbCalcul.Text.Length > 0)
            {
                txbCalcul.Text = txbCalcul.Text.Substring(0, txbCalcul.TextLength - 1);
                // peut etre simplifié avec operateur de plage
                // txbCalcul.Text = txbCalcul.Text[..(txbCalcul.TextLength - 1)];
            }
        }

        /// <summary>
        /// inverse la valeur de la txbCalcul 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlusMinus_Click(object sender, EventArgs e)
        {
            if (txbCalcul.Text.Length > 0)
            {
                string signe = txbCalcul.Text[0].ToString();
                if (string.Compare(signe, "-") == 0)
                    txbCalcul.Text = txbCalcul.Text.Substring(1, txbCalcul.Text.Length - 1);
                else
                {
                    // le signe - sera placé a la gauche dans le form car la proprieté righttoLeft de la txbCalcul
                    // est true
                    txbCalcul.Text = "-" + txbCalcul.Text;

                }

            }
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (txbCalcul.Text.Length > 0)
            {
                if (txbCalcul.Text.Contains(',') == false)
                {
                    txbCalcul.Text = txbCalcul.Text  + ',';
                }
                else
                {
                    SystemSounds.Beep.Play();
                }
            }
            else
            {
                txbCalcul.Text = "0," + txbCalcul.Text;
            }

        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            long x = long.Parse(txbCalcul.Text);
            x = (long)Math.Pow(x, 2);
            txbCalcul.Text = x.ToString();
        }
    }
}
