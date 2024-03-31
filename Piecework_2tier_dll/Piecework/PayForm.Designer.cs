namespace Piecework
{
    partial class PayForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            CalculateBtn = new Button();
            SummaryBtn = new Button();
            Clear = new Button();
            ClearAll = new Button();
            label2 = new Label();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            calculatePayToolStripMenuItem = new ToolStripMenuItem();
            summaryToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            clearAllToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip = new ContextMenuStrip(components);
            calculatePayToolStripMenuItem1 = new ToolStripMenuItem();
            summaryToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            clearToolStripMenuItem1 = new ToolStripMenuItem();
            clearAllToolStripMenuItem1 = new ToolStripMenuItem();
            Wname = new Label();
            label1 = new Label();
            nameTextBox1 = new TextBox();
            piecesTextBox1 = new TextBox();
            paymentLabel = new Label();
            nameTextBox2 = new TextBox();
            nameTextBox3 = new TextBox();
            nameTextBox4 = new TextBox();
            nameTextBox5 = new TextBox();
            piecesTextBox2 = new TextBox();
            piecesTextBox3 = new TextBox();
            piecesTextBox4 = new TextBox();
            piecesTextBox5 = new TextBox();
            menuStrip.SuspendLayout();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // CalculateBtn
            // 
            CalculateBtn.Font = new Font("Segoe UI", 11F);
            CalculateBtn.Location = new Point(102, 191);
            CalculateBtn.Margin = new Padding(2);
            CalculateBtn.Name = "CalculateBtn";
            CalculateBtn.Size = new Size(88, 28);
            CalculateBtn.TabIndex = 0;
            CalculateBtn.Text = "Calculate";
            CalculateBtn.UseVisualStyleBackColor = true;
            CalculateBtn.Click += Calculate_Click;
            // 
            // SummaryBtn
            // 
            SummaryBtn.Font = new Font("Segoe UI", 11F);
            SummaryBtn.Location = new Point(205, 191);
            SummaryBtn.Margin = new Padding(2);
            SummaryBtn.Name = "SummaryBtn";
            SummaryBtn.Size = new Size(88, 28);
            SummaryBtn.TabIndex = 1;
            SummaryBtn.Text = "Summary";
            SummaryBtn.UseVisualStyleBackColor = true;
            SummaryBtn.Click += Summary_Click;
            // 
            // Clear
            // 
            Clear.Font = new Font("Segoe UI", 11F);
            Clear.Location = new Point(310, 191);
            Clear.Margin = new Padding(2);
            Clear.Name = "Clear";
            Clear.Size = new Size(88, 28);
            Clear.TabIndex = 2;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // ClearAll
            // 
            ClearAll.Font = new Font("Segoe UI", 11F);
            ClearAll.Location = new Point(416, 191);
            ClearAll.Margin = new Padding(2);
            ClearAll.Name = "ClearAll";
            ClearAll.Size = new Size(88, 28);
            ClearAll.TabIndex = 3;
            ClearAll.Text = "Clear All";
            ClearAll.UseVisualStyleBackColor = true;
            ClearAll.Click += ClearAll_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 70);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 5;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(4, 1, 0, 1);
            menuStrip.Size = new Size(651, 24);
            menuStrip.TabIndex = 6;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculatePayToolStripMenuItem, summaryToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 22);
            fileToolStripMenuItem.Text = "File";
            // 
            // calculatePayToolStripMenuItem
            // 
            calculatePayToolStripMenuItem.Name = "calculatePayToolStripMenuItem";
            calculatePayToolStripMenuItem.Size = new Size(145, 22);
            calculatePayToolStripMenuItem.Text = "Calculate Pay";
            calculatePayToolStripMenuItem.Click += calculatePayToolStripMenuItem_Click;
            // 
            // summaryToolStripMenuItem
            // 
            summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            summaryToolStripMenuItem.Size = new Size(145, 22);
            summaryToolStripMenuItem.Text = "Summary";
            summaryToolStripMenuItem.Click += summaryToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(145, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearToolStripMenuItem, clearAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 22);
            editToolStripMenuItem.Text = "Edit";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(118, 22);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // clearAllToolStripMenuItem
            // 
            clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            clearAllToolStripMenuItem.Size = new Size(118, 22);
            clearAllToolStripMenuItem.Text = "Clear All";
            clearAllToolStripMenuItem.Click += clearAllToolStripMenuItem_Click;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(24, 24);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { calculatePayToolStripMenuItem1, summaryToolStripMenuItem1, exitToolStripMenuItem1, clearToolStripMenuItem1, clearAllToolStripMenuItem1 });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(146, 114);
            // 
            // calculatePayToolStripMenuItem1
            // 
            calculatePayToolStripMenuItem1.Name = "calculatePayToolStripMenuItem1";
            calculatePayToolStripMenuItem1.Size = new Size(145, 22);
            calculatePayToolStripMenuItem1.Text = "Calculate Pay";
            calculatePayToolStripMenuItem1.Click += calculatePayToolStripMenuItem1_Click;
            // 
            // summaryToolStripMenuItem1
            // 
            summaryToolStripMenuItem1.Name = "summaryToolStripMenuItem1";
            summaryToolStripMenuItem1.Size = new Size(145, 22);
            summaryToolStripMenuItem1.Text = "Summary";
            summaryToolStripMenuItem1.Click += summaryToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(145, 22);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // clearToolStripMenuItem1
            // 
            clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            clearToolStripMenuItem1.Size = new Size(145, 22);
            clearToolStripMenuItem1.Text = "Clear";
            clearToolStripMenuItem1.Click += clearToolStripMenuItem1_Click;
            // 
            // clearAllToolStripMenuItem1
            // 
            clearAllToolStripMenuItem1.Name = "clearAllToolStripMenuItem1";
            clearAllToolStripMenuItem1.Size = new Size(145, 22);
            clearAllToolStripMenuItem1.Text = "Clear All";
            clearAllToolStripMenuItem1.Click += clearAllToolStripMenuItem1_Click;
            // 
            // Wname
            // 
            Wname.AutoSize = true;
            Wname.Font = new Font("Segoe UI", 11F);
            Wname.Location = new Point(198, 38);
            Wname.Margin = new Padding(2, 0, 2, 0);
            Wname.Name = "Wname";
            Wname.Size = new Size(100, 20);
            Wname.TabIndex = 8;
            Wname.Text = "Worker Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(323, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(203, 20);
            label1.TabIndex = 9;
            label1.Text = "Number of pieces completed";
            // 
            // nameTextBox1
            // 
            nameTextBox1.Location = new Point(197, 67);
            nameTextBox1.Margin = new Padding(2);
            nameTextBox1.Name = "nameTextBox1";
            nameTextBox1.Size = new Size(106, 23);
            nameTextBox1.TabIndex = 10;
            // 
            // piecesTextBox1
            // 
            piecesTextBox1.Location = new Point(367, 65);
            piecesTextBox1.Margin = new Padding(2);
            piecesTextBox1.Name = "piecesTextBox1";
            piecesTextBox1.Size = new Size(106, 23);
            piecesTextBox1.TabIndex = 11;
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Font = new Font("Segoe UI", 11F);
            paymentLabel.Location = new Point(134, 221);
            paymentLabel.Margin = new Padding(2, 0, 2, 0);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new Size(15, 20);
            paymentLabel.TabIndex = 12;
            paymentLabel.Text = "-";
            // 
            // nameTextBox2
            // 
            nameTextBox2.Location = new Point(198, 89);
            nameTextBox2.Margin = new Padding(2);
            nameTextBox2.Name = "nameTextBox2";
            nameTextBox2.Size = new Size(106, 23);
            nameTextBox2.TabIndex = 13;
            // 
            // nameTextBox3
            // 
            nameTextBox3.Location = new Point(197, 111);
            nameTextBox3.Margin = new Padding(2);
            nameTextBox3.Name = "nameTextBox3";
            nameTextBox3.Size = new Size(106, 23);
            nameTextBox3.TabIndex = 14;
            // 
            // nameTextBox4
            // 
            nameTextBox4.Location = new Point(198, 133);
            nameTextBox4.Margin = new Padding(2);
            nameTextBox4.Name = "nameTextBox4";
            nameTextBox4.Size = new Size(106, 23);
            nameTextBox4.TabIndex = 15;
            // 
            // nameTextBox5
            // 
            nameTextBox5.Location = new Point(197, 155);
            nameTextBox5.Margin = new Padding(2);
            nameTextBox5.Name = "nameTextBox5";
            nameTextBox5.Size = new Size(106, 23);
            nameTextBox5.TabIndex = 16;
            // 
            // piecesTextBox2
            // 
            piecesTextBox2.Location = new Point(367, 87);
            piecesTextBox2.Margin = new Padding(2);
            piecesTextBox2.Name = "piecesTextBox2";
            piecesTextBox2.Size = new Size(106, 23);
            piecesTextBox2.TabIndex = 17;
            // 
            // piecesTextBox3
            // 
            piecesTextBox3.Location = new Point(367, 111);
            piecesTextBox3.Margin = new Padding(2);
            piecesTextBox3.Name = "piecesTextBox3";
            piecesTextBox3.Size = new Size(106, 23);
            piecesTextBox3.TabIndex = 18;
            // 
            // piecesTextBox4
            // 
            piecesTextBox4.Location = new Point(367, 133);
            piecesTextBox4.Margin = new Padding(2);
            piecesTextBox4.Name = "piecesTextBox4";
            piecesTextBox4.Size = new Size(106, 23);
            piecesTextBox4.TabIndex = 19;
            // 
            // piecesTextBox5
            // 
            piecesTextBox5.Location = new Point(367, 155);
            piecesTextBox5.Margin = new Padding(2);
            piecesTextBox5.Name = "piecesTextBox5";
            piecesTextBox5.Size = new Size(106, 23);
            piecesTextBox5.TabIndex = 20;
            // 
            // PayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 270);
            ContextMenuStrip = contextMenuStrip;
            Controls.Add(piecesTextBox5);
            Controls.Add(piecesTextBox4);
            Controls.Add(piecesTextBox3);
            Controls.Add(piecesTextBox2);
            Controls.Add(nameTextBox5);
            Controls.Add(nameTextBox4);
            Controls.Add(nameTextBox3);
            Controls.Add(nameTextBox2);
            Controls.Add(paymentLabel);
            Controls.Add(piecesTextBox1);
            Controls.Add(nameTextBox1);
            Controls.Add(label1);
            Controls.Add(Wname);
            Controls.Add(label2);
            Controls.Add(ClearAll);
            Controls.Add(Clear);
            Controls.Add(SummaryBtn);
            Controls.Add(CalculateBtn);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new Padding(2);
            Name = "PayForm";
            Text = "PayForm";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CalculateBtn;
        private Button SummaryBtn;
        private Button Clear;
        private Button ClearAll;
        private Label label2;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem calculatePayToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem summaryToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem clearAllToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem calculatePayToolStripMenuItem1;
        private ToolStripMenuItem summaryToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem clearToolStripMenuItem1;
        private ToolStripMenuItem clearAllToolStripMenuItem1;
        private Label Wname;
        private Label label1;
        private TextBox nameTextBox1;
        private TextBox piecesTextBox1;
        private Label paymentLabel;
        private TextBox nameTextBox2;
        private TextBox nameTextBox3;
        private TextBox nameTextBox4;
        private TextBox nameTextBox5;
        private TextBox piecesTextBox2;
        private TextBox piecesTextBox3;
        private TextBox piecesTextBox4;
        private TextBox piecesTextBox5;
    }
}
