using OCP.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    public class NewYearSaleTotalAmount : ISaleTotalAmount
    {
        public decimal CalculateTotalAmount(decimal SubTotal)
        {
            return SubTotal - (SubTotal * 0.2M);
        }
    }
}
