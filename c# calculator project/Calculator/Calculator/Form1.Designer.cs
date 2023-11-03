namespace Calculator
{
    partial class Form1
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button20 = new Button();
            button19 = new Button();
            button18 = new Button();
            button17 = new Button();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button5 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Gray;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(665, 668);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(button20, 3, 4);
            tableLayoutPanel2.Controls.Add(button19, 2, 4);
            tableLayoutPanel2.Controls.Add(button18, 1, 4);
            tableLayoutPanel2.Controls.Add(button17, 0, 4);
            tableLayoutPanel2.Controls.Add(button16, 3, 3);
            tableLayoutPanel2.Controls.Add(button15, 2, 3);
            tableLayoutPanel2.Controls.Add(button14, 1, 3);
            tableLayoutPanel2.Controls.Add(button13, 0, 3);
            tableLayoutPanel2.Controls.Add(button12, 3, 2);
            tableLayoutPanel2.Controls.Add(button11, 2, 2);
            tableLayoutPanel2.Controls.Add(button10, 1, 2);
            tableLayoutPanel2.Controls.Add(button9, 0, 2);
            tableLayoutPanel2.Controls.Add(button8, 3, 1);
            tableLayoutPanel2.Controls.Add(button7, 2, 1);
            tableLayoutPanel2.Controls.Add(button6, 1, 1);
            tableLayoutPanel2.Controls.Add(button4, 3, 0);
            tableLayoutPanel2.Controls.Add(button3, 2, 0);
            tableLayoutPanel2.Controls.Add(button2, 1, 0);
            tableLayoutPanel2.Controls.Add(button5, 0, 1);
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 337);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(659, 328);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button20
            // 
            button20.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button20.BackColor = Color.FromArgb(255, 128, 0);
            button20.FlatAppearance.BorderSize = 0;
            button20.FlatAppearance.MouseDownBackColor = Color.White;
            button20.FlatStyle = FlatStyle.Flat;
            button20.ForeColor = SystemColors.ButtonHighlight;
            button20.Location = new Point(495, 263);
            button20.Name = "button20";
            button20.Size = new Size(161, 62);
            button20.TabIndex = 19;
            button20.Text = "=";
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // button19
            // 
            button19.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button19.BackColor = Color.FromArgb(64, 64, 64);
            button19.FlatAppearance.BorderSize = 0;
            button19.FlatAppearance.MouseDownBackColor = Color.White;
            button19.FlatStyle = FlatStyle.Flat;
            button19.ForeColor = SystemColors.ButtonHighlight;
            button19.Location = new Point(331, 263);
            button19.Name = "button19";
            button19.Size = new Size(158, 62);
            button19.TabIndex = 18;
            button19.Text = ".";
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // button18
            // 
            button18.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button18.BackColor = Color.FromArgb(64, 64, 64);
            button18.FlatAppearance.BorderSize = 0;
            button18.FlatAppearance.MouseDownBackColor = Color.White;
            button18.FlatStyle = FlatStyle.Flat;
            button18.ForeColor = SystemColors.ButtonHighlight;
            button18.Location = new Point(167, 263);
            button18.Name = "button18";
            button18.Size = new Size(158, 62);
            button18.TabIndex = 17;
            button18.Text = "0";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click_1;
            // 
            // button17
            // 
            button17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button17.BackColor = Color.FromArgb(64, 64, 64);
            button17.FlatAppearance.BorderSize = 0;
            button17.FlatAppearance.MouseDownBackColor = Color.White;
            button17.FlatStyle = FlatStyle.Flat;
            button17.ForeColor = SystemColors.ButtonHighlight;
            button17.Location = new Point(3, 263);
            button17.Name = "button17";
            button17.Size = new Size(158, 62);
            button17.TabIndex = 16;
            button17.Text = "+/-";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click_1;
            // 
            // button16
            // 
            button16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button16.BackColor = Color.FromArgb(64, 64, 64);
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatAppearance.MouseDownBackColor = Color.White;
            button16.FlatStyle = FlatStyle.Flat;
            button16.ForeColor = SystemColors.ButtonHighlight;
            button16.Location = new Point(495, 198);
            button16.Name = "button16";
            button16.Size = new Size(161, 59);
            button16.TabIndex = 15;
            button16.Text = "+";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button15
            // 
            button15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button15.BackColor = Color.FromArgb(64, 64, 64);
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatAppearance.MouseDownBackColor = Color.White;
            button15.FlatStyle = FlatStyle.Flat;
            button15.ForeColor = SystemColors.ButtonHighlight;
            button15.Location = new Point(331, 198);
            button15.Name = "button15";
            button15.Size = new Size(158, 59);
            button15.TabIndex = 14;
            button15.Text = "3";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button14
            // 
            button14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button14.BackColor = Color.FromArgb(64, 64, 64);
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatAppearance.MouseDownBackColor = Color.White;
            button14.FlatStyle = FlatStyle.Flat;
            button14.ForeColor = SystemColors.ButtonHighlight;
            button14.Location = new Point(167, 198);
            button14.Name = "button14";
            button14.Size = new Size(158, 59);
            button14.TabIndex = 13;
            button14.Text = "2";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button13
            // 
            button13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button13.BackColor = Color.FromArgb(64, 64, 64);
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatAppearance.MouseDownBackColor = Color.White;
            button13.FlatStyle = FlatStyle.Flat;
            button13.ForeColor = SystemColors.ButtonHighlight;
            button13.Location = new Point(3, 198);
            button13.Name = "button13";
            button13.Size = new Size(158, 59);
            button13.TabIndex = 12;
            button13.Text = "1";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button12.BackColor = Color.FromArgb(64, 64, 64);
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.MouseDownBackColor = Color.White;
            button12.FlatStyle = FlatStyle.Flat;
            button12.ForeColor = SystemColors.ButtonHighlight;
            button12.Location = new Point(495, 133);
            button12.Name = "button12";
            button12.Size = new Size(161, 59);
            button12.TabIndex = 11;
            button12.Text = "-";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button11.BackColor = Color.FromArgb(64, 64, 64);
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.MouseDownBackColor = Color.White;
            button11.FlatStyle = FlatStyle.Flat;
            button11.ForeColor = SystemColors.ButtonHighlight;
            button11.Location = new Point(331, 133);
            button11.Name = "button11";
            button11.Size = new Size(158, 59);
            button11.TabIndex = 10;
            button11.Text = "6";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button10.BackColor = Color.FromArgb(64, 64, 64);
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.MouseDownBackColor = Color.White;
            button10.FlatStyle = FlatStyle.Flat;
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Location = new Point(167, 133);
            button10.Name = "button10";
            button10.Size = new Size(158, 59);
            button10.TabIndex = 9;
            button10.Text = "5";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button9.BackColor = Color.FromArgb(64, 64, 64);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.MouseDownBackColor = Color.White;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = SystemColors.ButtonHighlight;
            button9.Location = new Point(3, 133);
            button9.Name = "button9";
            button9.Size = new Size(158, 59);
            button9.TabIndex = 8;
            button9.Text = "4";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button8.BackColor = Color.FromArgb(64, 64, 64);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.MouseDownBackColor = Color.White;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(495, 68);
            button8.Name = "button8";
            button8.Size = new Size(161, 59);
            button8.TabIndex = 7;
            button8.Text = "*";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button7.BackColor = Color.FromArgb(64, 64, 64);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.White;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(331, 68);
            button7.Name = "button7";
            button7.Size = new Size(158, 59);
            button7.TabIndex = 6;
            button7.Text = "9";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button6.BackColor = Color.FromArgb(64, 64, 64);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.White;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(167, 68);
            button6.Name = "button6";
            button6.Size = new Size(158, 59);
            button6.TabIndex = 5;
            button6.Text = "8";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(495, 3);
            button4.Name = "button4";
            button4.Size = new Size(161, 59);
            button4.TabIndex = 3;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(331, 3);
            button3.Name = "button3";
            button3.Size = new Size(158, 59);
            button3.TabIndex = 2;
            button3.Text = "CE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(167, 3);
            button2.Name = "button2";
            button2.Size = new Size(158, 59);
            button2.TabIndex = 1;
            button2.Text = "AC";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(64, 64, 64);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.White;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(3, 68);
            button5.Name = "button5";
            button5.Size = new Size(158, 59);
            button5.TabIndex = 4;
            button5.Text = "7";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(158, 59);
            button1.TabIndex = 0;
            button1.Text = "History ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(64, 64, 64);
            textBox1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.InactiveBorder;
            textBox1.Location = new Point(3, 190);
            textBox1.Margin = new Padding(3, 3, 3, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(659, 114);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 668);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Calculator app ";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox1;
        private Button button20;
        private Button button19;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}