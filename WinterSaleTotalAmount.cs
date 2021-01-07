using OCP.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    public class WinterSaleTotalAmount : ISaleTotalAmount
    {
        public decimal CalculateTotalAmount(decimal SubTotal)
        {
            return SubTotal - (SubTotal * 0.1M); 
        }
    }
}
