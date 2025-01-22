using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public enum MemoryStateEnum
    {
        Clear,
        Saved,
        Full
    }

    public class Memory
    {
        private double memory1;
        public double Memory1
        {
            get { return memory1; }
            set { memory1 = value; }
        }

        private MemoryStateEnum memoryState;
        public MemoryStateEnum MemoryState
        {
            get { return memoryState; }
            set { memoryState = value; }
        }
        /// <summary>
        /// Constructeur de la classe Memory
        /// </summary>
        public Memory() 
        {
            memory1 = 0.0 ;
            memoryState = MemoryStateEnum.Clear;
        }
    }
}
