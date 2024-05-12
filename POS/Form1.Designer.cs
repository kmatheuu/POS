namespace POS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Clear = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Remove = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.Pay = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.Changee = new System.Windows.Forms.Label();
            this.MOP = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.SubTotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.cboPayment = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 475);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(244, 345);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 100);
            this.Clear.TabIndex = 11;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(138, 345);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 100);
            this.button11.TabIndex = 10;
            this.button11.Text = ".";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(32, 345);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 100);
            this.button12.TabIndex = 9;
            this.button12.Text = "0";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(244, 239);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 100);
            this.button7.TabIndex = 8;
            this.button7.Text = "3";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(138, 239);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 100);
            this.button8.TabIndex = 7;
            this.button8.Text = "2";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(32, 239);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 100);
            this.button9.TabIndex = 6;
            this.button9.Text = "1";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(244, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 100);
            this.button4.TabIndex = 5;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(138, 133);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 100);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(32, 133);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 100);
            this.button6.TabIndex = 3;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(244, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 2;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(138, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 1;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(32, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumbersOnly);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button25);
            this.panel2.Controls.Add(this.button26);
            this.panel2.Controls.Add(this.button27);
            this.panel2.Controls.Add(this.button28);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.button16);
            this.panel2.Controls.Add(this.button17);
            this.panel2.Controls.Add(this.button18);
            this.panel2.Controls.Add(this.button19);
            this.panel2.Controls.Add(this.button20);
            this.panel2.Controls.Add(this.button21);
            this.panel2.Controls.Add(this.button22);
            this.panel2.Controls.Add(this.button23);
            this.panel2.Controls.Add(this.button24);
            this.panel2.Location = new System.Drawing.Point(825, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 478);
            this.panel2.TabIndex = 1;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(401, 345);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(100, 100);
            this.button25.TabIndex = 27;
            this.button25.Text = "button25";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(401, 239);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(100, 100);
            this.button26.TabIndex = 26;
            this.button26.Text = "button26";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(401, 133);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(100, 100);
            this.button27.TabIndex = 25;
            this.button27.Text = "button27";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(401, 29);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(100, 100);
            this.button28.TabIndex = 24;
            this.button28.Text = "button28";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(295, 345);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 100);
            this.button13.TabIndex = 23;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(130, 345);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(100, 100);
            this.button14.TabIndex = 22;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(24, 345);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(100, 100);
            this.button15.TabIndex = 21;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(295, 239);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(100, 100);
            this.button16.TabIndex = 20;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(130, 239);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(100, 100);
            this.button17.TabIndex = 19;
            this.button17.Text = "button17";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(24, 239);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(100, 100);
            this.button18.TabIndex = 18;
            this.button18.Text = "button18";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(295, 133);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(100, 100);
            this.button19.TabIndex = 17;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(130, 133);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(100, 100);
            this.button20.TabIndex = 16;
            this.button20.Text = "button20";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(24, 133);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(100, 100);
            this.button21.TabIndex = 15;
            this.button21.Text = "button21";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(295, 29);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(100, 100);
            this.button22.TabIndex = 14;
            this.button22.Text = "button22";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(130, 29);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(100, 100);
            this.button23.TabIndex = 13;
            this.button23.Text = "button23";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(24, 29);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(100, 100);
            this.button24.TabIndex = 12;
            this.button24.Text = "button24";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(12, 496);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1344, 233);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.Remove);
            this.panel6.Controls.Add(this.Reset);
            this.panel6.Controls.Add(this.Print);
            this.panel6.Controls.Add(this.Pay);
            this.panel6.Location = new System.Drawing.Point(898, 15);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(430, 211);
            this.panel6.TabIndex = 2;
            // 
            // Remove
            // 
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.Location = new System.Drawing.Point(220, 103);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(194, 75);
            this.Remove.TabIndex = 26;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(220, 18);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(194, 75);
            this.Reset.TabIndex = 25;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.button31_Click);
            // 
            // Print
            // 
            this.Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.Location = new System.Drawing.Point(16, 104);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(198, 75);
            this.Print.TabIndex = 24;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.button30_Click);
            // 
            // Pay
            // 
            this.Pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay.Location = new System.Drawing.Point(16, 18);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(198, 75);
            this.Pay.TabIndex = 23;
            this.Pay.Text = "Pay";
            this.Pay.UseVisualStyleBackColor = true;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.cboPayment);
            this.panel5.Controls.Add(this.lblCash);
            this.panel5.Controls.Add(this.lblChange);
            this.panel5.Controls.Add(this.Cost);
            this.panel5.Controls.Add(this.Changee);
            this.panel5.Controls.Add(this.MOP);
            this.panel5.Location = new System.Drawing.Point(391, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(501, 211);
            this.panel5.TabIndex = 1;
            // 
            // lblCash
            // 
            this.lblCash.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCash.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblCash.Location = new System.Drawing.Point(265, 69);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(218, 37);
            this.lblCash.TabIndex = 15;
            this.lblCash.Text = "0";
            this.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChange
            // 
            this.lblChange.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblChange.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblChange.Location = new System.Drawing.Point(265, 119);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(218, 37);
            this.lblChange.TabIndex = 14;
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblChange.Click += new System.EventHandler(this.label9_Click);
            // 
            // Cost
            // 
            this.Cost.Font = new System.Drawing.Font("Calibri", 16F);
            this.Cost.Location = new System.Drawing.Point(21, 70);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(91, 37);
            this.Cost.TabIndex = 13;
            this.Cost.Text = "Cost";
            this.Cost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cost.Click += new System.EventHandler(this.label10_Click);
            // 
            // Changee
            // 
            this.Changee.Font = new System.Drawing.Font("Calibri", 16F);
            this.Changee.Location = new System.Drawing.Point(21, 119);
            this.Changee.Name = "Changee";
            this.Changee.Size = new System.Drawing.Size(111, 38);
            this.Changee.TabIndex = 12;
            this.Changee.Text = "Change";
            this.Changee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Changee.Click += new System.EventHandler(this.label11_Click);
            // 
            // MOP
            // 
            this.MOP.Font = new System.Drawing.Font("Calibri", 16F);
            this.MOP.Location = new System.Drawing.Point(15, 19);
            this.MOP.Name = "MOP";
            this.MOP.Size = new System.Drawing.Size(244, 36);
            this.MOP.TabIndex = 11;
            this.MOP.Text = "Method of Payment";
            this.MOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblSubTotal);
            this.panel4.Controls.Add(this.lblTax);
            this.panel4.Controls.Add(this.lblTotal);
            this.panel4.Controls.Add(this.Tax);
            this.panel4.Controls.Add(this.Total);
            this.panel4.Controls.Add(this.SubTotal);
            this.panel4.Location = new System.Drawing.Point(12, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(361, 211);
            this.panel4.TabIndex = 0;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubTotal.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblSubTotal.Location = new System.Drawing.Point(150, 18);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(180, 37);
            this.lblSubTotal.TabIndex = 10;
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSubTotal.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblTax
            // 
            this.lblTax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTax.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblTax.Location = new System.Drawing.Point(150, 69);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(180, 37);
            this.lblTax.TabIndex = 9;
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTax.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblTotal.Location = new System.Drawing.Point(150, 118);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(180, 37);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tax
            // 
            this.Tax.Font = new System.Drawing.Font("Calibri", 18F);
            this.Tax.Location = new System.Drawing.Point(11, 69);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(133, 37);
            this.Tax.TabIndex = 7;
            this.Tax.Text = "Tax";
            this.Tax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tax.Click += new System.EventHandler(this.label3_Click);
            // 
            // Total
            // 
            this.Total.Font = new System.Drawing.Font("Calibri", 18F);
            this.Total.Location = new System.Drawing.Point(11, 118);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(133, 38);
            this.Total.TabIndex = 6;
            this.Total.Text = "Total";
            this.Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Total.Click += new System.EventHandler(this.label2_Click);
            // 
            // SubTotal
            // 
            this.SubTotal.Font = new System.Drawing.Font("Calibri", 18F);
            this.SubTotal.Location = new System.Drawing.Point(11, 18);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(133, 36);
            this.SubTotal.TabIndex = 5;
            this.SubTotal.Text = "Sub Total";
            this.SubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubTotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(405, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(400, 413);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ITEM";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "QTY";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "AMOUNT";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // lblBarCode
            // 
            this.lblBarCode.BackColor = System.Drawing.Color.White;
            this.lblBarCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblBarCode.Location = new System.Drawing.Point(405, 432);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(400, 58);
            this.lblBarCode.TabIndex = 4;
            this.lblBarCode.Text = "hell yeah";
            this.lblBarCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBarCode.Click += new System.EventHandler(this.lblBarCode_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // cboPayment
            // 
            this.cboPayment.FormattingEnabled = true;
            this.cboPayment.Location = new System.Drawing.Point(265, 19);
            this.cboPayment.Name = "cboPayment";
            this.cboPayment.Size = new System.Drawing.Size(217, 24);
            this.cboPayment.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1368, 741);
            this.Controls.Add(this.lblBarCode);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label SubTotal;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button Pay;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.Label Changee;
        private System.Windows.Forms.Label MOP;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ComboBox cboPayment;
    }
}

