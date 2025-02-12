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
            lblInProgress.Text = "";
            _calculate = new Calcul();
            _memory = new Memory();
        }
        /// <summary>
        /// Evenement li� au boutons numeriques
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
            
            string sNumber = txbCalcul.Text;
            string sOperand = (sender as Button).Text;
            _calculate.Operation = sOperand;

            if (_calculate.CalculState == CalculStateEnum.AquireOperand1)
            {
                lblInProgress.Text = String.Format("{0}{1}", sNumber, sOperand);
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
                // peut etre simplifi� avec operateur de plage
                // txbCalcul.Text = txbCalcul.Text[..(txbCalcul.TextLength - 1)];
            }
        }
        #region operations diverse
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
                    // le signe - sera plac� a la gauche dans le form car la propriet� righttoLeft de la txbCalcul
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
                    txbCalcul.Text = txbCalcul.Text + ',';
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
            
            double x = Double.Parse(txbCalcul.Text);
            double result = (double)Math.Pow(x, 2);
            txbCalcul.Text = result.ToString();
            lblInProgress.Text = string.Format("sqr({0})", x.ToString());
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txbCalcul.Text);
            double result = Math.Sqrt(x);
            txbCalcul.Text = result.ToString();
            lblInProgress.Text = string.Format("sqrt({0})", x.ToString());

        }

        private void btnDividedbyX_Click(object sender, EventArgs e)
        {
            double result;
            double operande1 = 1;
            double x = double.Parse(txbCalcul.Text);

            result = operande1 / x;
            txbCalcul.Text = result.ToString();
            lblInProgress.Text = string.Format("{0}/{1}", operande1.ToString(), x.ToString());

        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if (_calculate.CalculState == CalculStateEnum.AquireOperand2)
            {
                double result;

                try
                {
                    result = Double.Parse(txbCalcul.Text);
                    _calculate.Operand2 = result;
                    _calculate.CalculState = CalculStateEnum.Calculation;
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
                string sNumber = txbCalcul.Text;
                string eOperateur = (sender as Button).Text;
                double result = _calculate.Calculate();
                lblInProgress.Text += String.Format("{0}{1}", sNumber, eOperateur);
                txbCalcul.Text = result.ToString();

                // le resultat devient l'operande numero 1
                _calculate.Operand1 = result;
                

                // effacer avant d'aquerir la deuxieme operande
                _calculate.CalculState = CalculStateEnum.AquireOperand1;
                
            }
        }

        #endregion

        

        #region Clear Buttons

        private void btnClearOperand_Click(object sender, EventArgs e)
        {
            txbCalcul.Text = "0";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            _calculate = new Calcul();
            txbCalcul.Text = "0";
            lblInProgress.Text = string.Empty;
        }
        #endregion

        #region Memory

        private void btnMemorySave_Click(object sender, EventArgs e)
        {
            if (txbCalcul.Text.Length > 0)
            {
                try
                {
                    _memory.Memory1 = Double.Parse(txbCalcul.Text);
                    _memory.MemoryState = MemoryStateEnum.Saved;
                    lblMemory.Text = "M";
                }
                catch (Exception)
                {

                }
            }

        }
        private void btnMemoryAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _memory.Memory1 += Double.Parse(txbCalcul.Text);
                _memory.MemoryState = MemoryStateEnum.Saved;
                lblMemory.Text = "M";
            }
            catch (Exception)
            {

            }
        }

        private void btnMemoryRead_Click(object sender, EventArgs e)
        {
            txbCalcul.Text = _memory.Memory1.ToString();
            _memory.MemoryState = MemoryStateEnum.Saved;

            //Memoire est affich� on demande l'operande suivante
            _calculate.CalculState = CalculStateEnum.AquireOperand2;
        }

        private void btnMemoryClear_Click(object sender, EventArgs e)
        {
            lblMemory.Text = "";
            _memory = new Memory();
        }
        #endregion
    }
}
