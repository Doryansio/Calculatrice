using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public enum CalculStateEnum
    {
        AquireOperand1,
        BeginAquireOperand2,
        AquireOperand2,
        Calculation
    }
    
    public class Calcul
    {
        /// <summary>
        /// Resultat du calcul
        /// </summary>
        private double Result;

        /// <summary>
        /// Etat du calcul
        /// </summary>
        private CalculStateEnum calculState;
        private double operand1;
        private double operand2;
        private string operation;
        
        public CalculStateEnum CalculState
        {
            get { return calculState; }
            set { calculState = value; }
        }
        public double Operand1
        {
            get { return operand1; }
            set { operand1 = value; }
        }
        public double Operand2
        {
            get { return operand2; }
            set { operand2 = value; }
        }
        public string Operation
        {
            get { return operation; }
            set { operation = value; }
        }
        /// <summary>
        /// Constructeur de la classe Calcul
        /// </summary>
        public Calcul() 
        {
            calculState = CalculStateEnum.AquireOperand1;
            operand1 = Double.PositiveInfinity;
            operand2 = Double.PositiveInfinity;
            operation = string.Empty;
        }

        public double Calculate() 
        {
            switch (operation)
            {
                case "+":
                    Result = operand1 + operand2; 
                    break;
                case "-":
                    Result = operand1 - operand2;
                    break;
                case "*":
                    Result = operand1 * operand2; 
                    break;
                case "/":
                    Result = operand1 / operand2;
                    break;
                case "%":
                    break;
                default:
                    break;
            }
            return Result;
        }

    }
}
