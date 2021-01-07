using OCP.interfaces;
using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            ISaleTotalAmount winterSalesAmount = new WinterSaleTotalAmount();
            
            decimal subTotal = winterSalesAmount.CalculateTotalAmount(100);

            Console.WriteLine();
            Console.WriteLine(subTotal);

            //SaleTotalAmount winterSales = new SaleTotalAmount();
            //decimal sale = winterSales.CalculateTotalAmount("winter", 600);
            //Console.WriteLine(sale);

            Console.ReadLine();
        }
    }
}
