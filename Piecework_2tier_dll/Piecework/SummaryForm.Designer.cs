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
            lblTotalPieces.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblTotalPieces.Location = new Point(242, 72);
            lblTotalPieces.Margin = new Padding(2, 0, 2, 0);
            lblTotalPieces.Name = "lblTotalPieces";
            lblTotalPieces.Size = new Size(65, 25);
            lblTotalPieces.TabIndex = 0;
            lblTotalPieces.Text = "label1";
            // 
            // lblTotalPayment
            // 
            lblTotalPayment.AutoSize = true;
            lblTotalPayment.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblTotalPayment.Location = new Point(242, 108);
            lblTotalPayment.Margin = new Padding(2, 0, 2, 0);
            lblTotalPayment.Name = "lblTotalPayment";
            lblTotalPayment.Size = new Size(65, 25);
            lblTotalPayment.TabIndex = 1;
            lblTotalPayment.Text = "label2";
            // 
            // lblAveragePayment
            // 
            lblAveragePayment.AutoSize = true;
            lblAveragePayment.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblAveragePayment.Location = new Point(242, 141);
            lblAveragePayment.Margin = new Padding(2, 0, 2, 0);
            lblAveragePayment.Name = "lblAveragePayment";
            lblAveragePayment.Size = new Size(65, 25);
            lblAveragePayment.TabIndex = 2;
            lblAveragePayment.Text = "label3";
            // 
            // SummaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 270);
            Controls.Add(lblAveragePayment);
            Controls.Add(lblTotalPayment);
            Controls.Add(lblTotalPieces);
            Margin = new Padding(2, 2, 2, 2);
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