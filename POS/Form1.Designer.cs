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
            this.Coke = new System.Windows.Forms.Button();
            this.Lasagna = new System.Windows.Forms.Button();
            this.IcedTea = new System.Windows.Forms.Button();
            this.Sprite = new System.Windows.Forms.Button();
            this.Spinach = new System.Windows.Forms.Button();
            this.Pepperoni = new System.Windows.Forms.Button();
            this.ClassicPizza = new System.Windows.Forms.Button();
            this.Carbonara = new System.Windows.Forms.Button();
            this.Spaghetti = new System.Windows.Forms.Button();
            this.Pesto = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Remove = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.Pay = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cboPayment = new System.Windows.Forms.ComboBox();
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
            this.Water = new System.Windows.Forms.Button();
            this.ShrimpPizza = new System.Windows.Forms.Button();
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
            this.panel2.Controls.Add(this.ShrimpPizza);
            this.panel2.Controls.Add(this.Water);
            this.panel2.Controls.Add(this.Coke);
            this.panel2.Controls.Add(this.Lasagna);
            this.panel2.Controls.Add(this.IcedTea);
            this.panel2.Controls.Add(this.Sprite);
            this.panel2.Controls.Add(this.Spinach);
            this.panel2.Controls.Add(this.Pepperoni);
            this.panel2.Controls.Add(this.ClassicPizza);
            this.panel2.Controls.Add(this.Carbonara);
            this.panel2.Controls.Add(this.Spaghetti);
            this.panel2.Controls.Add(this.Pesto);
            this.panel2.Location = new System.Drawing.Point(825, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 478);
            this.panel2.TabIndex = 1;
            // 
            // Coke
            // 
            this.Coke.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Coke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coke.Image = ((System.Drawing.Image)(resources.GetObject("Coke.Image")));
            this.Coke.Location = new System.Drawing.Point(263, 311);
            this.Coke.Name = "Coke";
            this.Coke.Size = new System.Drawing.Size(118, 134);
            this.Coke.TabIndex = 25;
            this.Coke.Text = "Coke";
            this.Coke.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Coke.UseVisualStyleBackColor = true;
            this.Coke.Click += new System.EventHandler(this.Coke_Click);
            // 
            // Lasagna
            // 
            this.Lasagna.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Lasagna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lasagna.Image = ((System.Drawing.Image)(resources.GetObject("Lasagna.Image")));
            this.Lasagna.Location = new System.Drawing.Point(383, 17);
            this.Lasagna.Name = "Lasagna";
            this.Lasagna.Size = new System.Drawing.Size(118, 134);
            this.Lasagna.TabIndex = 24;
            this.Lasagna.Text = "Lasagna";
            this.Lasagna.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Lasagna.UseVisualStyleBackColor = true;
            this.Lasagna.Click += new System.EventHandler(this.Lasagna_Click);
            // 
            // IcedTea
            // 
            this.IcedTea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IcedTea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IcedTea.Image = ((System.Drawing.Image)(resources.GetObject("IcedTea.Image")));
            this.IcedTea.Location = new System.Drawing.Point(139, 311);
            this.IcedTea.Name = "IcedTea";
            this.IcedTea.Size = new System.Drawing.Size(118, 134);
            this.IcedTea.TabIndex = 19;
            this.IcedTea.Text = "Iced Tea";
            this.IcedTea.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IcedTea.UseVisualStyleBackColor = true;
            this.IcedTea.Click += new System.EventHandler(this.IcedTea_Click);
            // 
            // Sprite
            // 
            this.Sprite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sprite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sprite.Image = ((System.Drawing.Image)(resources.GetObject("Sprite.Image")));
            this.Sprite.Location = new System.Drawing.Point(15, 311);
            this.Sprite.Name = "Sprite";
            this.Sprite.Size = new System.Drawing.Size(118, 134);
            this.Sprite.TabIndex = 18;
            this.Sprite.Text = "Sprite";
            this.Sprite.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Sprite.UseVisualStyleBackColor = true;
            this.Sprite.Click += new System.EventHandler(this.Sprite_Click);
            // 
            // Spinach
            // 
            this.Spinach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Spinach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spinach.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Spinach.Image = ((System.Drawing.Image)(resources.GetObject("Spinach.Image")));
            this.Spinach.Location = new System.Drawing.Point(263, 165);
            this.Spinach.Name = "Spinach";
            this.Spinach.Size = new System.Drawing.Size(118, 134);
            this.Spinach.TabIndex = 17;
            this.Spinach.Text = "Spinach";
            this.Spinach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Spinach.UseVisualStyleBackColor = true;
            this.Spinach.Click += new System.EventHandler(this.Spinach_Click);
            // 
            // Pepperoni
            // 
            this.Pepperoni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pepperoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pepperoni.Image = ((System.Drawing.Image)(resources.GetObject("Pepperoni.Image")));
            this.Pepperoni.Location = new System.Drawing.Point(139, 165);
            this.Pepperoni.Name = "Pepperoni";
            this.Pepperoni.Size = new System.Drawing.Size(118, 134);
            this.Pepperoni.TabIndex = 16;
            this.Pepperoni.Text = "Pepperoni";
            this.Pepperoni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pepperoni.UseVisualStyleBackColor = true;
            this.Pepperoni.Click += new System.EventHandler(this.Pepperoni_Click);
            // 
            // ClassicPizza
            // 
            this.ClassicPizza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClassicPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassicPizza.Image = ((System.Drawing.Image)(resources.GetObject("ClassicPizza.Image")));
            this.ClassicPizza.Location = new System.Drawing.Point(15, 165);
            this.ClassicPizza.Name = "ClassicPizza";
            this.ClassicPizza.Size = new System.Drawing.Size(118, 134);
            this.ClassicPizza.TabIndex = 15;
            this.ClassicPizza.Text = "Classic Pizza";
            this.ClassicPizza.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ClassicPizza.UseVisualStyleBackColor = true;
            this.ClassicPizza.Click += new System.EventHandler(this.ClassicPizza_Click);
            // 
            // Carbonara
            // 
            this.Carbonara.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Carbonara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carbonara.Image = ((System.Drawing.Image)(resources.GetObject("Carbonara.Image")));
            this.Carbonara.Location = new System.Drawing.Point(263, 17);
            this.Carbonara.Name = "Carbonara";
            this.Carbonara.Size = new System.Drawing.Size(118, 134);
            this.Carbonara.TabIndex = 14;
            this.Carbonara.Text = "Carbonara";
            this.Carbonara.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Carbonara.UseVisualStyleBackColor = true;
            this.Carbonara.Click += new System.EventHandler(this.Carbonara_Click);
            // 
            // Spaghetti
            // 
            this.Spaghetti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Spaghetti.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spaghetti.Image = ((System.Drawing.Image)(resources.GetObject("Spaghetti.Image")));
            this.Spaghetti.Location = new System.Drawing.Point(139, 17);
            this.Spaghetti.Name = "Spaghetti";
            this.Spaghetti.Size = new System.Drawing.Size(118, 134);
            this.Spaghetti.TabIndex = 13;
            this.Spaghetti.Text = "Spaghetti";
            this.Spaghetti.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Spaghetti.UseVisualStyleBackColor = true;
            this.Spaghetti.Click += new System.EventHandler(this.Spaghetti_Click);
            // 
            // Pesto
            // 
            this.Pesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pesto.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesto.ForeColor = System.Drawing.Color.Black;
            this.Pesto.Image = ((System.Drawing.Image)(resources.GetObject("Pesto.Image")));
            this.Pesto.Location = new System.Drawing.Point(15, 17);
            this.Pesto.Name = "Pesto";
            this.Pesto.Size = new System.Drawing.Size(118, 134);
            this.Pesto.TabIndex = 12;
            this.Pesto.Text = "Pesto";
            this.Pesto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pesto.UseVisualStyleBackColor = true;
            this.Pesto.UseWaitCursor = true;
            this.Pesto.Click += new System.EventHandler(this.Pesto_Click);
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
            // cboPayment
            // 
            this.cboPayment.FormattingEnabled = true;
            this.cboPayment.Location = new System.Drawing.Point(265, 19);
            this.cboPayment.Name = "cboPayment";
            this.cboPayment.Size = new System.Drawing.Size(217, 24);
            this.cboPayment.TabIndex = 16;
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
            // Water
            // 
            this.Water.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Water.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Water.Image = ((System.Drawing.Image)(resources.GetObject("Water.Image")));
            this.Water.Location = new System.Drawing.Point(387, 311);
            this.Water.Name = "Water";
            this.Water.Size = new System.Drawing.Size(118, 134);
            this.Water.TabIndex = 26;
            this.Water.Text = "Water";
            this.Water.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Water.UseVisualStyleBackColor = true;
            this.Water.Click += new System.EventHandler(this.Water_Click);
            // 
            // ShrimpPizza
            // 
            this.ShrimpPizza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShrimpPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShrimpPizza.Image = ((System.Drawing.Image)(resources.GetObject("ShrimpPizza.Image")));
            this.ShrimpPizza.Location = new System.Drawing.Point(387, 165);
            this.ShrimpPizza.Name = "ShrimpPizza";
            this.ShrimpPizza.Size = new System.Drawing.Size(118, 134);
            this.ShrimpPizza.TabIndex = 27;
            this.ShrimpPizza.Text = "Shrimp Pizza";
            this.ShrimpPizza.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ShrimpPizza.UseVisualStyleBackColor = true;
            this.ShrimpPizza.Click += new System.EventHandler(this.ShrimpPizza_Click);
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
        private System.Windows.Forms.Button IcedTea;
        private System.Windows.Forms.Button Sprite;
        private System.Windows.Forms.Button Spinach;
        private System.Windows.Forms.Button Pepperoni;
        private System.Windows.Forms.Button ClassicPizza;
        private System.Windows.Forms.Button Carbonara;
        private System.Windows.Forms.Button Spaghetti;
        private System.Windows.Forms.Button Pesto;
        private System.Windows.Forms.Button Coke;
        private System.Windows.Forms.Button Lasagna;
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
        private System.Windows.Forms.Button ShrimpPizza;
        private System.Windows.Forms.Button Water;
    }
}

