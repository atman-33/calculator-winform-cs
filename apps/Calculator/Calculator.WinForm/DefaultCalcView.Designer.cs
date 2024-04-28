﻿namespace Calculator.WinForm
{
    partial class DefaultCalcView
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
            tableLayoutPanel1 = new TableLayoutPanel();
            BackButton = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            ClearButton = new Button();
            button2 = new Button();
            DivideButton = new Button();
            SevenButton = new Button();
            EightButton = new Button();
            NineButton = new Button();
            MultipleButton = new Button();
            FourButton = new Button();
            FiveButton = new Button();
            SixButton = new Button();
            MinusButton = new Button();
            PlusButton = new Button();
            ThreeButton = new Button();
            TwoButton = new Button();
            OneButton = new Button();
            PlusMinusButton = new Button();
            ZeroButton = new Button();
            PointButton = new Button();
            EqualButton = new Button();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(BackButton, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(ClearButton, 0, 2);
            tableLayoutPanel1.Controls.Add(button2, 2, 2);
            tableLayoutPanel1.Controls.Add(DivideButton, 3, 2);
            tableLayoutPanel1.Controls.Add(SevenButton, 0, 3);
            tableLayoutPanel1.Controls.Add(EightButton, 1, 3);
            tableLayoutPanel1.Controls.Add(NineButton, 2, 3);
            tableLayoutPanel1.Controls.Add(MultipleButton, 3, 3);
            tableLayoutPanel1.Controls.Add(FourButton, 0, 4);
            tableLayoutPanel1.Controls.Add(FiveButton, 1, 4);
            tableLayoutPanel1.Controls.Add(SixButton, 2, 4);
            tableLayoutPanel1.Controls.Add(MinusButton, 3, 4);
            tableLayoutPanel1.Controls.Add(PlusButton, 3, 5);
            tableLayoutPanel1.Controls.Add(ThreeButton, 2, 5);
            tableLayoutPanel1.Controls.Add(TwoButton, 1, 5);
            tableLayoutPanel1.Controls.Add(OneButton, 0, 5);
            tableLayoutPanel1.Controls.Add(PlusMinusButton, 0, 6);
            tableLayoutPanel1.Controls.Add(ZeroButton, 1, 6);
            tableLayoutPanel1.Controls.Add(PointButton, 2, 6);
            tableLayoutPanel1.Controls.Add(EqualButton, 3, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(20, 60);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.3162394F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.8888893F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new Size(320, 478);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BackButton.BackColor = Color.FromArgb(0, 192, 192);
            BackButton.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(83, 139);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(74, 60);
            BackButton.TabIndex = 3;
            BackButton.Text = "←";
            BackButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(textBox1, 4);
            textBox1.Enabled = false;
            textBox1.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(8, 76);
            textBox1.Margin = new Padding(8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 35);
            textBox1.TabIndex = 0;
            textBox1.Text = "0.12345";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label2, 4);
            label2.Location = new Point(160, 51);
            label2.Name = "label2";
            label2.Size = new Size(157, 17);
            label2.TabIndex = 1;
            label2.Text = "12345689 + 123456789 =";
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ClearButton.BackColor = Color.FromArgb(0, 192, 192);
            ClearButton.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ClearButton.ForeColor = Color.White;
            ClearButton.Location = new Point(3, 139);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(74, 60);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "C";
            ClearButton.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(0, 192, 192);
            button2.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(163, 139);
            button2.Name = "button2";
            button2.Size = new Size(74, 60);
            button2.TabIndex = 3;
            button2.Text = "→";
            button2.UseVisualStyleBackColor = false;
            // 
            // DivideButton
            // 
            DivideButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DivideButton.BackColor = Color.FromArgb(0, 192, 192);
            DivideButton.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            DivideButton.ForeColor = Color.White;
            DivideButton.Location = new Point(243, 139);
            DivideButton.Name = "DivideButton";
            DivideButton.Size = new Size(74, 60);
            DivideButton.TabIndex = 3;
            DivideButton.Text = "÷";
            DivideButton.UseVisualStyleBackColor = false;
            // 
            // SevenButton
            // 
            SevenButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SevenButton.BackColor = Color.FromArgb(0, 192, 192);
            SevenButton.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SevenButton.ForeColor = Color.White;
            SevenButton.Location = new Point(3, 205);
            SevenButton.Name = "SevenButton";
            SevenButton.Size = new Size(74, 62);
            SevenButton.TabIndex = 2;
            SevenButton.Text = "7";
            SevenButton.UseVisualStyleBackColor = false;
            // 
            // EightButton
            // 
            EightButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EightButton.BackColor = Color.FromArgb(0, 192, 192);
            EightButton.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            EightButton.ForeColor = Color.White;
            EightButton.Location = new Point(83, 205);
            EightButton.Name = "EightButton";
            EightButton.Size = new Size(74, 62);
            EightButton.TabIndex = 2;
            EightButton.Text = "8";
            EightButton.UseVisualStyleBackColor = false;
            // 
            // NineButton
            // 
            NineButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NineButton.BackColor = Color.FromArgb(0, 192, 192);
            NineButton.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            NineButton.ForeColor = Color.White;
            NineButton.Location = new Point(163, 205);
            NineButton.Name = "NineButton";
            NineButton.Size = new Size(74, 62);
            NineButton.TabIndex = 2;
            NineButton.Text = "9";
            NineButton.UseVisualStyleBackColor = false;
            // 
            // MultipleButton
            // 
            MultipleButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MultipleButton.BackColor = Color.FromArgb(0, 192, 192);
            MultipleButton.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            MultipleButton.ForeColor = Color.White;
            MultipleButton.Location = new Point(243, 205);
            MultipleButton.Name = "MultipleButton";
            MultipleButton.Size = new Size(74, 62);
            MultipleButton.TabIndex = 2;
            MultipleButton.Text = "×";
            MultipleButton.UseVisualStyleBackColor = false;
            // 
            // FourButton
            // 
            FourButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FourButton.BackColor = Color.FromArgb(0, 192, 192);
            FourButton.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            FourButton.ForeColor = Color.White;
            FourButton.Location = new Point(3, 273);
            FourButton.Name = "FourButton";
            FourButton.Size = new Size(74, 62);
            FourButton.TabIndex = 2;
            FourButton.Text = "4";
            FourButton.UseVisualStyleBackColor = false;
            // 
            // FiveButton
            // 
            FiveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FiveButton.BackColor = Color.FromArgb(0, 192, 192);
            FiveButton.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            FiveButton.ForeColor = Color.White;
            FiveButton.Location = new Point(83, 273);
            FiveButton.Name = "FiveButton";
            FiveButton.Size = new Size(74, 62);
            FiveButton.TabIndex = 2;
            FiveButton.Text = "5";
            FiveButton.UseVisualStyleBackColor = false;
            // 
            // SixButton
            // 
            SixButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SixButton.BackColor = Color.FromArgb(0, 192, 192);
            SixButton.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SixButton.ForeColor = Color.White;
            SixButton.Location = new Point(163, 273);
            SixButton.Name = "SixButton";
            SixButton.Size = new Size(74, 62);
            SixButton.TabIndex = 2;
            SixButton.Text = "6";
            SixButton.UseVisualStyleBackColor = false;
            // 
            // MinusButton
            // 
            MinusButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MinusButton.BackColor = Color.FromArgb(0, 192, 192);
            MinusButton.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            MinusButton.ForeColor = Color.White;
            MinusButton.Location = new Point(243, 273);
            MinusButton.Name = "MinusButton";
            MinusButton.Size = new Size(74, 62);
            MinusButton.TabIndex = 2;
            MinusButton.Text = "-";
            MinusButton.UseVisualStyleBackColor = false;
            // 
            // PlusButton
            // 
            PlusButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PlusButton.BackColor = Color.FromArgb(0, 192, 192);
            PlusButton.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PlusButton.ForeColor = Color.White;
            PlusButton.Location = new Point(243, 341);
            PlusButton.Name = "PlusButton";
            PlusButton.Size = new Size(74, 62);
            PlusButton.TabIndex = 2;
            PlusButton.Text = "+";
            PlusButton.UseVisualStyleBackColor = false;
            // 
            // ThreeButton
            // 
            ThreeButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ThreeButton.BackColor = Color.FromArgb(0, 192, 192);
            ThreeButton.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ThreeButton.ForeColor = Color.White;
            ThreeButton.Location = new Point(163, 341);
            ThreeButton.Name = "ThreeButton";
            ThreeButton.Size = new Size(74, 62);
            ThreeButton.TabIndex = 2;
            ThreeButton.Text = "3";
            ThreeButton.UseVisualStyleBackColor = false;
            // 
            // TwoButton
            // 
            TwoButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TwoButton.BackColor = Color.FromArgb(0, 192, 192);
            TwoButton.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TwoButton.ForeColor = Color.White;
            TwoButton.Location = new Point(83, 341);
            TwoButton.Name = "TwoButton";
            TwoButton.Size = new Size(74, 62);
            TwoButton.TabIndex = 2;
            TwoButton.Text = "2";
            TwoButton.UseVisualStyleBackColor = false;
            // 
            // OneButton
            // 
            OneButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OneButton.BackColor = Color.FromArgb(0, 192, 192);
            OneButton.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            OneButton.ForeColor = Color.White;
            OneButton.Location = new Point(3, 341);
            OneButton.Name = "OneButton";
            OneButton.Size = new Size(74, 62);
            OneButton.TabIndex = 2;
            OneButton.Text = "1";
            OneButton.UseVisualStyleBackColor = false;
            // 
            // PlusMinusButton
            // 
            PlusMinusButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PlusMinusButton.BackColor = Color.FromArgb(0, 192, 192);
            PlusMinusButton.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PlusMinusButton.ForeColor = Color.White;
            PlusMinusButton.Location = new Point(3, 409);
            PlusMinusButton.Name = "PlusMinusButton";
            PlusMinusButton.Size = new Size(74, 66);
            PlusMinusButton.TabIndex = 2;
            PlusMinusButton.Text = "+/-";
            PlusMinusButton.UseVisualStyleBackColor = false;
            // 
            // ZeroButton
            // 
            ZeroButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ZeroButton.BackColor = Color.FromArgb(0, 192, 192);
            ZeroButton.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ZeroButton.ForeColor = Color.White;
            ZeroButton.Location = new Point(83, 409);
            ZeroButton.Name = "ZeroButton";
            ZeroButton.Size = new Size(74, 66);
            ZeroButton.TabIndex = 2;
            ZeroButton.Text = "0";
            ZeroButton.UseVisualStyleBackColor = false;
            // 
            // PointButton
            // 
            PointButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PointButton.BackColor = Color.FromArgb(0, 192, 192);
            PointButton.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PointButton.ForeColor = Color.White;
            PointButton.Location = new Point(163, 409);
            PointButton.Name = "PointButton";
            PointButton.Size = new Size(74, 66);
            PointButton.TabIndex = 2;
            PointButton.Text = ".";
            PointButton.UseVisualStyleBackColor = false;
            // 
            // EqualButton
            // 
            EqualButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EqualButton.BackColor = Color.Teal;
            EqualButton.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            EqualButton.ForeColor = Color.White;
            EqualButton.Location = new Point(243, 409);
            EqualButton.Name = "EqualButton";
            EqualButton.Size = new Size(74, 66);
            EqualButton.TabIndex = 2;
            EqualButton.Text = "=";
            EqualButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackgroundImage = Properties.Resources.hamburger_menu_svgrepo_com;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(46, 39);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Location = new Point(20, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(53, 48);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // DefaultCalcView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 580);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            Name = "DefaultCalcView";
            Controls.SetChildIndex(tableLayoutPanel1, 0);
            Controls.SetChildIndex(flowLayoutPanel1, 0);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox1;
        private Label label2;
        private Button BackButton;
        private Button ClearButton;
        private Button button2;
        private Button DivideButton;
        private Button SevenButton;
        private Button EightButton;
        private Button NineButton;
        private Button MultipleButton;
        private Button FourButton;
        private Button FiveButton;
        private Button SixButton;
        private Button MinusButton;
        private Button PlusButton;
        private Button ThreeButton;
        private Button TwoButton;
        private Button OneButton;
        private Button PlusMinusButton;
        private Button ZeroButton;
        private Button PointButton;
        private Button EqualButton;
    }
}