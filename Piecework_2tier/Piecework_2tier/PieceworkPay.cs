using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piecework_2tier
{
    public class PieceworkPay
    {
        public string Name { get; set; }
        public int Pieces { get; set; }

        public static int TotalPieces { get; private set; }
        public static decimal TotalPayment { get; private set; }
        public static int WorkerCount { get; private set; }

        public virtual decimal CalculatePay()
        {
            decimal payRate = Pieces <= 199 ? 0.50m :
                              Pieces <= 399 ? 0.55m :
                              Pieces <= 599 ? 0.60m : 0.65m;
            decimal payment = Pieces * payRate;

            // Update static properties
            TotalPieces += Pieces;
            TotalPayment += payment;
            WorkerCount++;

            return payment;
        }
    }
}
