using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    public class SaleTotalAmount
    {
        decimal totalAmount = 0.00M;
        public decimal CalculateTotalAmount(string filter, decimal SubTotal)
        {
            if (filter == "winter")
            {
                totalAmount = SubTotal - (SubTotal * 0.1M);
            }
            else if (filter == "newyear")
            {
                totalAmount = SubTotal - (SubTotal * 0.2M);
            }
            else
            {
                totalAmount = SubTotal;
            }
            return totalAmount;
        }
    }
}
