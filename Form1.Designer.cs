namespace WindowsFormsApp2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelTotVal = new System.Windows.Forms.Label();
            this.totalPoundVal = new System.Windows.Forms.TextBox();
            this.totalPenceVal = new System.Windows.Forms.TextBox();
            this.button2Pound = new System.Windows.Forms.Button();
            this.button1Pound = new System.Windows.Forms.Button();
            this.button50p = new System.Windows.Forms.Button();
            this.button20p = new System.Windows.Forms.Button();
            this.button5p = new System.Windows.Forms.Button();
            this.button2p = new System.Windows.Forms.Button();
            this.button1p = new System.Windows.Forms.Button();
            this.button10p = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelPic10p = new System.Windows.Forms.Button();
            this.labelPic2Quid = new System.Windows.Forms.Button();
            this.labelPic1Quid = new System.Windows.Forms.Button();
            this.labelPic50p = new System.Windows.Forms.Button();
            this.labelPic20p = new System.Windows.Forms.Button();
            this.labelPic5p = new System.Windows.Forms.Button();
            this.labelPic2p = new System.Windows.Forms.Button();
            this.labelPic1p = new System.Windows.Forms.Button();
            this.label2PoundCounter = new System.Windows.Forms.Label();
            this.label1PoundCounter = new System.Windows.Forms.Label();
            this.label50pCounter = new System.Windows.Forms.Label();
            this.label20pCounter = new System.Windows.Forms.Label();
            this.label10pCounter = new System.Windows.Forms.Label();
            this.label5pCounter = new System.Windows.Forms.Label();
            this.label2pCounter = new System.Windows.Forms.Label();
            this.label1pCounter = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.creditNum = new System.Windows.Forms.TextBox();
            this.creditCost = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.resetButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.labelTotVal);
            this.groupBox1.Controls.Add(this.totalPoundVal);
            this.groupBox1.Controls.Add(this.totalPenceVal);
            this.groupBox1.Controls.Add(this.button2Pound);
            this.groupBox1.Controls.Add(this.button1Pound);
            this.groupBox1.Controls.Add(this.button50p);
            this.groupBox1.Controls.Add(this.button20p);
            this.groupBox1.Controls.Add(this.button5p);
            this.groupBox1.Controls.Add(this.button2p);
            this.groupBox1.Controls.Add(this.button1p);
            this.groupBox1.Controls.Add(this.button10p);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(319, 442);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COINS";
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 81);
            this.label3.TabIndex = 15;
            this.label3.Text = "Click A Coin To Buy Credits";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "£";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 411);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.MaximumSize = new System.Drawing.Size(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "p";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(269, 378);
            this.label13.Margin = new System.Windows.Forms.Padding(3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "p";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTotVal
            // 
            this.labelTotVal.AutoSize = true;
            this.labelTotVal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTotVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotVal.Location = new System.Drawing.Point(16, 379);
            this.labelTotVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotVal.Name = "labelTotVal";
            this.labelTotVal.Size = new System.Drawing.Size(91, 17);
            this.labelTotVal.TabIndex = 11;
            this.labelTotVal.Text = "Total Value";
            // 
            // totalPoundVal
            // 
            this.totalPoundVal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalPoundVal.Location = new System.Drawing.Point(124, 407);
            this.totalPoundVal.Margin = new System.Windows.Forms.Padding(4);
            this.totalPoundVal.Name = "totalPoundVal";
            this.totalPoundVal.Size = new System.Drawing.Size(132, 22);
            this.totalPoundVal.TabIndex = 10;
            this.totalPoundVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalPenceVal
            // 
            this.totalPenceVal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalPenceVal.Location = new System.Drawing.Point(124, 374);
            this.totalPenceVal.Margin = new System.Windows.Forms.Padding(4);
            this.totalPenceVal.Name = "totalPenceVal";
            this.totalPenceVal.Size = new System.Drawing.Size(132, 22);
            this.totalPenceVal.TabIndex = 10;
            this.totalPenceVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2Pound
            // 
            this.button2Pound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2Pound.BackgroundImage")));
            this.button2Pound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2Pound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Pound.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2Pound.Location = new System.Drawing.Point(210, 282);
            this.button2Pound.Margin = new System.Windows.Forms.Padding(4);
            this.button2Pound.Name = "button2Pound";
            this.button2Pound.Size = new System.Drawing.Size(80, 80);
            this.button2Pound.TabIndex = 7;
            this.button2Pound.Text = "£2";
            this.button2Pound.UseVisualStyleBackColor = true;
            this.button2Pound.Click += new System.EventHandler(this.button2Pound_Click);
            // 
            // button1Pound
            // 
            this.button1Pound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1Pound.BackgroundImage")));
            this.button1Pound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1Pound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Pound.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1Pound.Location = new System.Drawing.Point(132, 292);
            this.button1Pound.Margin = new System.Windows.Forms.Padding(4);
            this.button1Pound.Name = "button1Pound";
            this.button1Pound.Size = new System.Drawing.Size(70, 70);
            this.button1Pound.TabIndex = 6;
            this.button1Pound.Text = "£1";
            this.button1Pound.UseVisualStyleBackColor = true;
            this.button1Pound.Click += new System.EventHandler(this.button1Pound_Click);
            // 
            // button50p
            // 
            this.button50p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button50p.BackgroundImage")));
            this.button50p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button50p.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button50p.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button50p.Location = new System.Drawing.Point(39, 277);
            this.button50p.Margin = new System.Windows.Forms.Padding(4);
            this.button50p.Name = "button50p";
            this.button50p.Size = new System.Drawing.Size(85, 85);
            this.button50p.TabIndex = 5;
            this.button50p.Text = "50p";
            this.button50p.UseVisualStyleBackColor = true;
            this.button50p.Click += new System.EventHandler(this.button50p_Click);
            // 
            // button20p
            // 
            this.button20p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button20p.BackgroundImage")));
            this.button20p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button20p.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20p.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button20p.Location = new System.Drawing.Point(201, 205);
            this.button20p.Margin = new System.Windows.Forms.Padding(4);
            this.button20p.Name = "button20p";
            this.button20p.Size = new System.Drawing.Size(65, 65);
            this.button20p.TabIndex = 4;
            this.button20p.Text = "20p";
            this.button20p.UseVisualStyleBackColor = true;
            this.button20p.Click += new System.EventHandler(this.button20p_Click);
            // 
            // button5p
            // 
            this.button5p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5p.BackgroundImage")));
            this.button5p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5p.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5p.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5p.Location = new System.Drawing.Point(57, 209);
            this.button5p.Margin = new System.Windows.Forms.Padding(4);
            this.button5p.Name = "button5p";
            this.button5p.Size = new System.Drawing.Size(60, 60);
            this.button5p.TabIndex = 2;
            this.button5p.Text = "5p";
            this.button5p.UseVisualStyleBackColor = true;
            this.button5p.Click += new System.EventHandler(this.button5p_Click);
            // 
            // button2p
            // 
            this.button2p.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2p.BackgroundImage")));
            this.button2p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2p.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2p.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2p.Location = new System.Drawing.Point(166, 112);
            this.button2p.Margin = new System.Windows.Forms.Padding(4);
            this.button2p.Name = "button2p";
            this.button2p.Size = new System.Drawing.Size(80, 80);
            this.button2p.TabIndex = 1;
            this.button2p.Text = "2p";
            this.button2p.UseVisualStyleBackColor = true;
            this.button2p.Click += new System.EventHandler(this.button2p_Click);
            // 
            // button1p
            // 
            this.button1p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1p.BackgroundImage")));
            this.button1p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1p.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1p.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1p.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1p.Location = new System.Drawing.Point(88, 122);
            this.button1p.Margin = new System.Windows.Forms.Padding(4);
            this.button1p.MaximumSize = new System.Drawing.Size(200, 200);
            this.button1p.Name = "button1p";
            this.button1p.Size = new System.Drawing.Size(70, 70);
            this.button1p.TabIndex = 0;
            this.button1p.Text = "1p";
            this.button1p.UseVisualStyleBackColor = true;
            this.button1p.Click += new System.EventHandler(this.button1p_Click);
            // 
            // button10p
            // 
            this.button10p.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button10p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10p.BackgroundImage")));
            this.button10p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button10p.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10p.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10p.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10p.Location = new System.Drawing.Point(125, 199);
            this.button10p.Margin = new System.Windows.Forms.Padding(4);
            this.button10p.Name = "button10p";
            this.button10p.Size = new System.Drawing.Size(70, 70);
            this.button10p.TabIndex = 3;
            this.button10p.Text = "10p";
            this.button10p.UseVisualStyleBackColor = true;
            this.button10p.Click += new System.EventHandler(this.button10p_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.labelPic10p);
            this.groupBox2.Controls.Add(this.labelPic2Quid);
            this.groupBox2.Controls.Add(this.labelPic1Quid);
            this.groupBox2.Controls.Add(this.labelPic50p);
            this.groupBox2.Controls.Add(this.labelPic20p);
            this.groupBox2.Controls.Add(this.labelPic5p);
            this.groupBox2.Controls.Add(this.labelPic2p);
            this.groupBox2.Controls.Add(this.labelPic1p);
            this.groupBox2.Controls.Add(this.label2PoundCounter);
            this.groupBox2.Controls.Add(this.label1PoundCounter);
            this.groupBox2.Controls.Add(this.label50pCounter);
            this.groupBox2.Controls.Add(this.label20pCounter);
            this.groupBox2.Controls.Add(this.label10pCounter);
            this.groupBox2.Controls.Add(this.label5pCounter);
            this.groupBox2.Controls.Add(this.label2pCounter);
            this.groupBox2.Controls.Add(this.label1pCounter);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(330, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(140, 607);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COINS ENTERED";
            // 
            // labelPic10p
            // 
            this.labelPic10p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("labelPic10p.BackgroundImage")));
            this.labelPic10p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.labelPic10p.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPic10p.ForeColor = System.Drawing.Color.Gold;
            this.labelPic10p.Location = new System.Drawing.Point(50, 225);
            this.labelPic10p.Margin = new System.Windows.Forms.Padding(4);
            this.labelPic10p.Name = "labelPic10p";
            this.labelPic10p.Size = new System.Drawing.Size(70, 70);
            this.labelPic10p.TabIndex = 11;
            this.labelPic10p.Text = "10p";
            this.labelPic10p.UseVisualStyleBackColor = true;
            // 
            // labelPic2Quid
            // 
            this.labelPic2Quid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("labelPic2Quid.BackgroundImage")));
            this.labelPic2Quid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.labelPic2Quid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPic2Quid.ForeColor = System.Drawing.Color.Gold;
            this.labelPic2Quid.Location = new System.Drawing.Point(50, 522);
            this.labelPic2Quid.Margin = new System.Windows.Forms.Padding(4);
            this.labelPic2Quid.Name = "labelPic2Quid";
            this.labelPic2Quid.Size = new System.Drawing.Size(70, 70);
            this.labelPic2Quid.TabIndex = 14;
            this.labelPic2Quid.Text = "£2";
            this.labelPic2Quid.UseVisualStyleBackColor = true;
            // 
            // labelPic1Quid
            // 
            this.labelPic1Quid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("labelPic1Quid.BackgroundImage")));
            this.labelPic1Quid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.labelPic1Quid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPic1Quid.ForeColor = System.Drawing.Color.Gold;
            this.labelPic1Quid.Location = new System.Drawing.Point(50, 449);
            this.labelPic1Quid.Margin = new System.Windows.Forms.Padding(4);
            this.labelPic1Quid.Name = "labelPic1Quid";
            this.labelPic1Quid.Size = new System.Drawing.Size(65, 65);
            this.labelPic1Quid.TabIndex = 13;
            this.labelPic1Quid.Text = "£1";
            this.labelPic1Quid.UseVisualStyleBackColor = true;
            // 
            // labelPic50p
            // 
            this.labelPic50p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("labelPic50p.BackgroundImage")));
            this.labelPic50p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.labelPic50p.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPic50p.ForeColor = System.Drawing.Color.Gold;
            this.labelPic50p.Location = new System.Drawing.Point(50, 366);
            this.labelPic50p.Margin = new System.Windows.Forms.Padding(4);
            this.labelPic50p.Name = "labelPic50p";
            this.labelPic50p.Size = new System.Drawing.Size(75, 75);
            this.labelPic50p.TabIndex = 12;
            this.labelPic50p.Text = "50p";
            this.labelPic50p.UseVisualStyleBackColor = true;
            // 
            // labelPic20p
            // 
            this.labelPic20p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("labelPic20p.BackgroundImage")));
            this.labelPic20p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.labelPic20p.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPic20p.ForeColor = System.Drawing.Color.Gold;
            this.labelPic20p.Location = new System.Drawing.Point(50, 303);
            this.labelPic20p.Margin = new System.Windows.Forms.Padding(4);
            this.labelPic20p.Name = "labelPic20p";
            this.labelPic20p.Size = new System.Drawing.Size(60, 59);
            this.labelPic20p.TabIndex = 11;
            this.labelPic20p.Text = "20p";
            this.labelPic20p.UseVisualStyleBackColor = true;
            // 
            // labelPic5p
            // 
            this.labelPic5p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("labelPic5p.BackgroundImage")));
            this.labelPic5p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.labelPic5p.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPic5p.ForeColor = System.Drawing.Color.Gold;
            this.labelPic5p.Location = new System.Drawing.Point(50, 167);
            this.labelPic5p.Margin = new System.Windows.Forms.Padding(4);
            this.labelPic5p.Name = "labelPic5p";
            this.labelPic5p.Size = new System.Drawing.Size(50, 50);
            this.labelPic5p.TabIndex = 10;
            this.labelPic5p.Text = "5p";
            this.labelPic5p.UseVisualStyleBackColor = true;
            // 
            // labelPic2p
            // 
            this.labelPic2p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("labelPic2p.BackgroundImage")));
            this.labelPic2p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.labelPic2p.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPic2p.ForeColor = System.Drawing.Color.Gold;
            this.labelPic2p.Location = new System.Drawing.Point(50, 89);
            this.labelPic2p.Margin = new System.Windows.Forms.Padding(4);
            this.labelPic2p.Name = "labelPic2p";
            this.labelPic2p.Size = new System.Drawing.Size(70, 70);
            this.labelPic2p.TabIndex = 9;
            this.labelPic2p.Text = "2p";
            this.labelPic2p.UseVisualStyleBackColor = true;
            // 
            // labelPic1p
            // 
            this.labelPic1p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("labelPic1p.BackgroundImage")));
            this.labelPic1p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.labelPic1p.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelPic1p.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPic1p.ForeColor = System.Drawing.Color.Gold;
            this.labelPic1p.Location = new System.Drawing.Point(50, 23);
            this.labelPic1p.Margin = new System.Windows.Forms.Padding(4);
            this.labelPic1p.Name = "labelPic1p";
            this.labelPic1p.Size = new System.Drawing.Size(60, 60);
            this.labelPic1p.TabIndex = 8;
            this.labelPic1p.Text = "1p";
            this.labelPic1p.UseVisualStyleBackColor = true;
            // 
            // label2PoundCounter
            // 
            this.label2PoundCounter.AutoSize = true;
            this.label2PoundCounter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2PoundCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2PoundCounter.Location = new System.Drawing.Point(13, 550);
            this.label2PoundCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2PoundCounter.Name = "label2PoundCounter";
            this.label2PoundCounter.Size = new System.Drawing.Size(17, 17);
            this.label2PoundCounter.TabIndex = 7;
            this.label2PoundCounter.Text = "0";
            // 
            // label1PoundCounter
            // 
            this.label1PoundCounter.AutoSize = true;
            this.label1PoundCounter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1PoundCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1PoundCounter.Location = new System.Drawing.Point(13, 474);
            this.label1PoundCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1PoundCounter.Name = "label1PoundCounter";
            this.label1PoundCounter.Size = new System.Drawing.Size(17, 17);
            this.label1PoundCounter.TabIndex = 6;
            this.label1PoundCounter.Text = "0";
            // 
            // label50pCounter
            // 
            this.label50pCounter.AutoSize = true;
            this.label50pCounter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label50pCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50pCounter.Location = new System.Drawing.Point(13, 396);
            this.label50pCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50pCounter.Name = "label50pCounter";
            this.label50pCounter.Size = new System.Drawing.Size(17, 17);
            this.label50pCounter.TabIndex = 5;
            this.label50pCounter.Text = "0";
            // 
            // label20pCounter
            // 
            this.label20pCounter.AutoSize = true;
            this.label20pCounter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20pCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20pCounter.Location = new System.Drawing.Point(13, 323);
            this.label20pCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20pCounter.Name = "label20pCounter";
            this.label20pCounter.Size = new System.Drawing.Size(17, 17);
            this.label20pCounter.TabIndex = 4;
            this.label20pCounter.Text = "0";
            // 
            // label10pCounter
            // 
            this.label10pCounter.AutoSize = true;
            this.label10pCounter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10pCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10pCounter.Location = new System.Drawing.Point(13, 253);
            this.label10pCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10pCounter.Name = "label10pCounter";
            this.label10pCounter.Size = new System.Drawing.Size(17, 17);
            this.label10pCounter.TabIndex = 3;
            this.label10pCounter.Text = "0";
            // 
            // label5pCounter
            // 
            this.label5pCounter.AutoSize = true;
            this.label5pCounter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5pCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5pCounter.Location = new System.Drawing.Point(13, 185);
            this.label5pCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5pCounter.Name = "label5pCounter";
            this.label5pCounter.Size = new System.Drawing.Size(17, 17);
            this.label5pCounter.TabIndex = 2;
            this.label5pCounter.Text = "0";
            // 
            // label2pCounter
            // 
            this.label2pCounter.AutoSize = true;
            this.label2pCounter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2pCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2pCounter.Location = new System.Drawing.Point(13, 117);
            this.label2pCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2pCounter.Name = "label2pCounter";
            this.label2pCounter.Size = new System.Drawing.Size(17, 17);
            this.label2pCounter.TabIndex = 1;
            this.label2pCounter.Text = "0";
            // 
            // label1pCounter
            // 
            this.label1pCounter.AutoSize = true;
            this.label1pCounter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1pCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1pCounter.Location = new System.Drawing.Point(13, 49);
            this.label1pCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1pCounter.Name = "label1pCounter";
            this.label1pCounter.Size = new System.Drawing.Size(17, 17);
            this.label1pCounter.TabIndex = 0;
            this.label1pCounter.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.creditNum);
            this.groupBox3.Controls.Add(this.creditCost);
            this.groupBox3.Location = new System.Drawing.Point(4, 456);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(319, 115);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CREDITS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(104, 81);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Number of Credits";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(223, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Enter Cost Per Credit (pence)";
            // 
            // creditNum
            // 
            this.creditNum.BackColor = System.Drawing.Color.Gainsboro;
            this.creditNum.Location = new System.Drawing.Point(253, 76);
            this.creditNum.Margin = new System.Windows.Forms.Padding(4);
            this.creditNum.Name = "creditNum";
            this.creditNum.Size = new System.Drawing.Size(52, 22);
            this.creditNum.TabIndex = 1;
            this.creditNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // creditCost
            // 
            this.creditCost.BackColor = System.Drawing.Color.Gainsboro;
            this.creditCost.Location = new System.Drawing.Point(253, 28);
            this.creditCost.Margin = new System.Windows.Forms.Padding(4);
            this.creditCost.Name = "creditCost";
            this.creditCost.Size = new System.Drawing.Size(52, 22);
            this.creditCost.TabIndex = 0;
            this.creditCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.DarkGray;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(3, 576);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(320, 39);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 615);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Copyright - Adam Woodliffe 2019";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(475, 632);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money Credit Counter v2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2Pound;
        private System.Windows.Forms.Button button1Pound;
        private System.Windows.Forms.Button button50p;
        private System.Windows.Forms.Button button20p;
        private System.Windows.Forms.Button button10p;
        private System.Windows.Forms.Button button5p;
        private System.Windows.Forms.Button button2p;
        private System.Windows.Forms.Button button1p;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox totalPoundVal;
        private System.Windows.Forms.TextBox totalPenceVal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox creditNum;
        private System.Windows.Forms.TextBox creditCost;
        private System.Windows.Forms.Label label2PoundCounter;
        private System.Windows.Forms.Label label1PoundCounter;
        private System.Windows.Forms.Label label50pCounter;
        private System.Windows.Forms.Label label20pCounter;
        private System.Windows.Forms.Label label10pCounter;
        private System.Windows.Forms.Label label5pCounter;
        private System.Windows.Forms.Label label2pCounter;
        private System.Windows.Forms.Label label1pCounter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelTotVal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button labelPic10p;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button labelPic2Quid;
        private System.Windows.Forms.Button labelPic1Quid;
        private System.Windows.Forms.Button labelPic50p;
        private System.Windows.Forms.Button labelPic20p;
        private System.Windows.Forms.Button labelPic5p;
        private System.Windows.Forms.Button labelPic2p;
        private System.Windows.Forms.Button labelPic1p;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label4;
    }
}

