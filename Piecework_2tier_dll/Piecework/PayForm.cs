
using Clearwater;


namespace Piecework
{
    public partial class PayForm : Form
    {
        private int totalPieces = 0;
        private decimal totalPayment = 0.0m;
        private int totalWorkersCount = 0;
        private int workerCount = 0;
        public PayForm()
        {
            InitializeComponent();

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int piecesCompleted = 0;
            int tempPieces; // Temporary variable for parsing

            // Safely parse the text from each piecesTextBox and add it to piecesCompleted
            if (int.TryParse(piecesTextBox1.Text, out tempPieces)) piecesCompleted += tempPieces;
            if (int.TryParse(piecesTextBox2.Text, out tempPieces)) piecesCompleted += tempPieces;
            if (int.TryParse(piecesTextBox3.Text, out tempPieces)) piecesCompleted += tempPieces;
            if (int.TryParse(piecesTextBox4.Text, out tempPieces)) piecesCompleted += tempPieces;
            if (int.TryParse(piecesTextBox5.Text, out tempPieces)) piecesCompleted += tempPieces;

            decimal payment = CalculatePayment(piecesCompleted);

            paymentLabel.Text = $"Payment: ${payment:0.00}";

            totalPieces += piecesCompleted;
            totalPayment += payment;
            workerCount++;
        }

        private decimal CalculatePayment(int pieces)
        {
            if (pieces <= 199)
                return pieces * 0.50m;
            else if (pieces <= 399)
                return pieces * 0.55m;
            else if (pieces <= 599)
                return pieces * 0.60m;
            else
                return pieces * 0.65m;
        }

        private void Summary_Click(object sender, EventArgs e)
        {
            decimal averagePayment = workerCount > 0 ? totalPayment / workerCount : 0;

            SummaryForm summaryForm = new SummaryForm();
            summaryForm.TotalPieces = this.totalPieces; // Set total pieces
            summaryForm.TotalPayment = this.totalPayment; // Set total payment
            summaryForm.AveragePayment = averagePayment; // Set average payment
            summaryForm.ShowDialog(); // Show the form as a dialog
        }



        private void Clear_Click(object sender, EventArgs e)
        {

            foreach (Control ctrl in this.Controls)
            {

                if (ctrl is TextBox && ctrl.Focused)
                {
                    ctrl.Text = string.Empty;
                    break;
                }
            }


            paymentLabel.Text = string.Empty;
        }


        private void ClearAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all data?", "Clear All", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Reset the summary data
                this.totalPieces = 0;
                this.totalPayment = 0;
                this.totalWorkersCount = 0;

                // Clear the individual entry fields
                nameTextBox1.Clear();
                nameTextBox2.Clear();
                nameTextBox3.Clear();
                nameTextBox4.Clear();
                nameTextBox5.Clear();
                piecesTextBox1.Clear();
                piecesTextBox2.Clear();
                piecesTextBox3.Clear();
                piecesTextBox4.Clear();
                piecesTextBox5.Clear();
                paymentLabel.Text = string.Empty;
            }
        }

        private void calculatePayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int piecesCompleted = 0;
            piecesCompleted += int.Parse(piecesTextBox1.Text);
            piecesCompleted += int.Parse(piecesTextBox2.Text);
            piecesCompleted += int.Parse(piecesTextBox3.Text);
            piecesCompleted += int.Parse(piecesTextBox4.Text);
            piecesCompleted += int.Parse(piecesTextBox5.Text);

            decimal payment = 0.0m;

            if (piecesCompleted <= 199)
                payment = piecesCompleted * 0.50m;
            else if (piecesCompleted <= 399)
                payment = piecesCompleted * 0.55m;
            else if (piecesCompleted <= 599)
                payment = piecesCompleted * 0.60m;
            else
                payment = piecesCompleted * 0.65m;

            paymentLabel.Text = $"Payment: ${payment:0.00}";

            totalPieces += piecesCompleted;
            totalPayment += payment;
            workerCount++;
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal averagePayment = workerCount > 0 ? totalPayment / workerCount : 0;

            SummaryForm summaryForm = new SummaryForm();
            summaryForm.TotalPieces = this.totalPieces; // Set total pieces
            summaryForm.TotalPayment = this.totalPayment; // Set total payment
            summaryForm.AveragePayment = averagePayment; // Set average payment
            summaryForm.ShowDialog(); // Show the form as a dialog
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {

                if (ctrl is TextBox && ctrl.Focused)
                {
                    ctrl.Text = string.Empty;
                    break;
                }
            }


            paymentLabel.Text = string.Empty;
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all data?", "Clear All", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Reset the summary data
                this.totalPieces = 0;
                this.totalPayment = 0;
                this.totalWorkersCount = 0;

                // Clear the individual entry fields
                nameTextBox1.Clear();
                nameTextBox2.Clear();
                nameTextBox3.Clear();
                nameTextBox4.Clear();
                nameTextBox5.Clear();
                piecesTextBox1.Clear();
                piecesTextBox2.Clear();
                piecesTextBox3.Clear();
                piecesTextBox4.Clear();
                piecesTextBox5.Clear();
                paymentLabel.Text = string.Empty;
            }
        }

        private void calculatePayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CalculateBtn.PerformClick();
        }

        private void summaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SummaryBtn.PerformClick();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clear.PerformClick();
        }

        private void clearAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearAll.PerformClick();    
        }
    }
}
