using Piecework_2tier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SeniorPay : PieceworkPay
{
    public override decimal CalculatePay()
    {
        decimal basePay = base.CalculatePay();
        if (Pieces >= 600)
        {
            basePay *= 1.10m; // Apply a 10% bonus for senior workers completing 600 or more pieces
        }
        return basePay;
    }
}


