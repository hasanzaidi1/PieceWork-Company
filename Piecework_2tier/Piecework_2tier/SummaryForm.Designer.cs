namespace Piecework
{
    partial class SummaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTotalPieces = new Label();
            lblTotalPayment = new Label();
            lblAveragePayment = new Label();
            SuspendLayout();
            // 
            // lblTotalPieces
            // 
            lblTotalPieces.AutoSize = true;
            lblTotalPieces.Location = new Point(151, 107);
            lblTotalPieces.Name = "lblTotalPieces";
            lblTotalPieces.Size = new Size(59, 25);
            lblTotalPieces.TabIndex = 0;
            lblTotalPieces.Text = "label1";
            // 
            // lblTotalPayment
            // 
            lblTotalPayment.AutoSize = true;
            lblTotalPayment.Location = new Point(151, 166);
            lblTotalPayment.Name = "lblTotalPayment";
            lblTotalPayment.Size = new Size(59, 25);
            lblTotalPayment.TabIndex = 1;
            lblTotalPayment.Text = "label2";
            // 
            // lblAveragePayment
            // 
            lblAveragePayment.AutoSize = true;
            lblAveragePayment.Location = new Point(151, 221);
            lblAveragePayment.Name = "lblAveragePayment";
            lblAveragePayment.Size = new Size(59, 25);
            lblAveragePayment.TabIndex = 2;
            lblAveragePayment.Text = "label3";
            // 
            // SummaryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 450);
            Controls.Add(lblAveragePayment);
            Controls.Add(lblTotalPayment);
            Controls.Add(lblTotalPieces);
            Name = "SummaryForm";
            Text = "SummaryForm";
            Load += SummaryForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalPieces;
        private Label lblTotalPayment;
        private Label lblAveragePayment;
    }
}