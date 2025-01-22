namespace Calculatrice
{
    public partial class FormCalculatrice : Form
    {
        private Calcul _calculate;
        private Memory _memory;
        public FormCalculatrice()
        {
            

            InitializeComponent();

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
            if(_calculate.CalculState == CalculStateEnum.BeginAquireOperand2)
            {
                txbCalcul.Text = string.Empty;
                _calculate.CalculState = CalculStateEnum.AquireOperand2;
            }
            if(_memory.MemoryState == MemorySta)
        }
    }
}
