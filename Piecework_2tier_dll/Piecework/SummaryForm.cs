using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clearwater;


namespace Piecework
{
    public partial class SummaryForm : Form
    {

        public int TotalPieces { get; set; }
        public decimal TotalPayment { get; set; }
        public decimal AveragePayment { get; set; }

        public SummaryForm()
        {
            InitializeComponent();
        }

        private void SummaryForm_Load_1(object sender, EventArgs e)
        {
            // Ensure you have labels named appropriately on the form
            lblTotalPieces.Text = $"Total Pieces: {TotalPieces}";
            lblTotalPayment.Text = $"Total Payment: {TotalPayment:C2}";
            lblAveragePayment.Text = $"Average Payment: {AveragePayment:C2}";
        }
    }
}
