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
            Calculate = new Button();
            Summary = new Button();
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
            // Calculate
            // 
            Calculate.Font = new Font("Segoe UI", 11F);
            Calculate.Location = new Point(146, 319);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(125, 46);
            Calculate.TabIndex = 0;
            Calculate.Text = "Calculate";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // Summary
            // 
            Summary.Font = new Font("Segoe UI", 11F);
            Summary.Location = new Point(293, 319);
            Summary.Name = "Summary";
            Summary.Size = new Size(125, 46);
            Summary.TabIndex = 1;
            Summary.Text = "Summary";
            Summary.UseVisualStyleBackColor = true;
            Summary.Click += Summary_Click;
            // 
            // Clear
            // 
            Clear.Font = new Font("Segoe UI", 11F);
            Clear.Location = new Point(443, 319);
            Clear.Name = "Clear";
            Clear.Size = new Size(125, 46);
            Clear.TabIndex = 2;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // ClearAll
            // 
            ClearAll.Font = new Font("Segoe UI", 11F);
            ClearAll.Location = new Point(595, 319);
            ClearAll.Name = "ClearAll";
            ClearAll.Size = new Size(125, 46);
            ClearAll.TabIndex = 3;
            ClearAll.Text = "Clear All";
            ClearAll.UseVisualStyleBackColor = true;
            ClearAll.Click += ClearAll_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 117);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 5;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(930, 33);
            menuStrip.TabIndex = 6;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculatePayToolStripMenuItem, summaryToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // calculatePayToolStripMenuItem
            // 
            calculatePayToolStripMenuItem.Name = "calculatePayToolStripMenuItem";
            calculatePayToolStripMenuItem.Size = new Size(216, 34);
            calculatePayToolStripMenuItem.Text = "Calculate Pay";
            calculatePayToolStripMenuItem.Click += calculatePayToolStripMenuItem_Click;
            // 
            // summaryToolStripMenuItem
            // 
            summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            summaryToolStripMenuItem.Size = new Size(216, 34);
            summaryToolStripMenuItem.Text = "Summary";
            summaryToolStripMenuItem.Click += summaryToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(216, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearToolStripMenuItem, clearAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "Edit";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(178, 34);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // clearAllToolStripMenuItem
            // 
            clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            clearAllToolStripMenuItem.Size = new Size(178, 34);
            clearAllToolStripMenuItem.Text = "Clear All";
            clearAllToolStripMenuItem.Click += clearAllToolStripMenuItem_Click;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(24, 24);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { calculatePayToolStripMenuItem1, summaryToolStripMenuItem1, exitToolStripMenuItem1, clearToolStripMenuItem1, clearAllToolStripMenuItem1 });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(187, 164);
            // 
            // calculatePayToolStripMenuItem1
            // 
            calculatePayToolStripMenuItem1.Name = "calculatePayToolStripMenuItem1";
            calculatePayToolStripMenuItem1.Size = new Size(186, 32);
            calculatePayToolStripMenuItem1.Text = "Calculate Pay";
            // 
            // summaryToolStripMenuItem1
            // 
            summaryToolStripMenuItem1.Name = "summaryToolStripMenuItem1";
            summaryToolStripMenuItem1.Size = new Size(186, 32);
            summaryToolStripMenuItem1.Text = "Summary";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(186, 32);
            exitToolStripMenuItem1.Text = "Exit";
            // 
            // clearToolStripMenuItem1
            // 
            clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            clearToolStripMenuItem1.Size = new Size(186, 32);
            clearToolStripMenuItem1.Text = "Clear";
            // 
            // clearAllToolStripMenuItem1
            // 
            clearAllToolStripMenuItem1.Name = "clearAllToolStripMenuItem1";
            clearAllToolStripMenuItem1.Size = new Size(186, 32);
            clearAllToolStripMenuItem1.Text = "Clear All";
            // 
            // Wname
            // 
            Wname.AutoSize = true;
            Wname.Font = new Font("Segoe UI", 11F);
            Wname.Location = new Point(283, 63);
            Wname.Name = "Wname";
            Wname.Size = new Size(149, 30);
            Wname.TabIndex = 8;
            Wname.Text = "Worker Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(462, 63);
            label1.Name = "label1";
            label1.Size = new Size(296, 30);
            label1.TabIndex = 9;
            label1.Text = "Number of pieces completed";
            // 
            // nameTextBox1
            // 
            nameTextBox1.Location = new Point(282, 111);
            nameTextBox1.Name = "nameTextBox1";
            nameTextBox1.Size = new Size(150, 31);
            nameTextBox1.TabIndex = 10;
            // 
            // piecesTextBox1
            // 
            piecesTextBox1.Location = new Point(524, 108);
            piecesTextBox1.Name = "piecesTextBox1";
            piecesTextBox1.Size = new Size(150, 31);
            piecesTextBox1.TabIndex = 11;
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Font = new Font("Segoe UI", 11F);
            paymentLabel.Location = new Point(192, 368);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new Size(22, 30);
            paymentLabel.TabIndex = 12;
            paymentLabel.Text = "-";
            // 
            // nameTextBox2
            // 
            nameTextBox2.Location = new Point(283, 148);
            nameTextBox2.Name = "nameTextBox2";
            nameTextBox2.Size = new Size(150, 31);
            nameTextBox2.TabIndex = 13;
            // 
            // nameTextBox3
            // 
            nameTextBox3.Location = new Point(282, 185);
            nameTextBox3.Name = "nameTextBox3";
            nameTextBox3.Size = new Size(150, 31);
            nameTextBox3.TabIndex = 14;
            // 
            // nameTextBox4
            // 
            nameTextBox4.Location = new Point(283, 222);
            nameTextBox4.Name = "nameTextBox4";
            nameTextBox4.Size = new Size(150, 31);
            nameTextBox4.TabIndex = 15;
            // 
            // nameTextBox5
            // 
            nameTextBox5.Location = new Point(282, 259);
            nameTextBox5.Name = "nameTextBox5";
            nameTextBox5.Size = new Size(150, 31);
            nameTextBox5.TabIndex = 16;
            // 
            // piecesTextBox2
            // 
            piecesTextBox2.Location = new Point(524, 145);
            piecesTextBox2.Name = "piecesTextBox2";
            piecesTextBox2.Size = new Size(150, 31);
            piecesTextBox2.TabIndex = 17;
            // 
            // piecesTextBox3
            // 
            piecesTextBox3.Location = new Point(524, 185);
            piecesTextBox3.Name = "piecesTextBox3";
            piecesTextBox3.Size = new Size(150, 31);
            piecesTextBox3.TabIndex = 18;
            // 
            // piecesTextBox4
            // 
            piecesTextBox4.Location = new Point(524, 222);
            piecesTextBox4.Name = "piecesTextBox4";
            piecesTextBox4.Size = new Size(150, 31);
            piecesTextBox4.TabIndex = 19;
            // 
            // piecesTextBox5
            // 
            piecesTextBox5.Location = new Point(524, 259);
            piecesTextBox5.Name = "piecesTextBox5";
            piecesTextBox5.Size = new Size(150, 31);
            piecesTextBox5.TabIndex = 20;
            // 
            // PayForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 450);
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
            Controls.Add(Summary);
            Controls.Add(Calculate);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "PayForm";
            Text = "PayForm";
            
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Calculate;
        private Button Summary;
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
