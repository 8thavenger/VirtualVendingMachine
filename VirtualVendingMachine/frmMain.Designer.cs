namespace VirtualVendingMachine
{
    partial class frmMain
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
            this.lstInventory = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Inser_Half_Dolar = new System.Windows.Forms.Button();
            this.btn_Insert_Quarter = new System.Windows.Forms.Button();
            this.btn_Insert_Dime = new System.Windows.Forms.Button();
            this.btn_Insert_Nickle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDisplayValue = new System.Windows.Forms.Label();
            this.btn_Selector_9 = new System.Windows.Forms.Button();
            this.btn_Selector_8 = new System.Windows.Forms.Button();
            this.btn_Selector_6 = new System.Windows.Forms.Button();
            this.btn_Selector_5 = new System.Windows.Forms.Button();
            this.btn_Selector_3 = new System.Windows.Forms.Button();
            this.btn_Selector_7 = new System.Windows.Forms.Button();
            this.btn_Selector_2 = new System.Windows.Forms.Button();
            this.btn_Selector_4 = new System.Windows.Forms.Button();
            this.btn_Selector_C = new System.Windows.Forms.Button();
            this.btn_Selector_1 = new System.Windows.Forms.Button();
            this.btn_Selector_B = new System.Windows.Forms.Button();
            this.btn_Selector_A = new System.Windows.Forms.Button();
            this.lblSlot = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstInventory
            // 
            this.lstInventory.FormattingEnabled = true;
            this.lstInventory.Location = new System.Drawing.Point(12, 12);
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(177, 264);
            this.lstInventory.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Inser_Half_Dolar);
            this.groupBox1.Controls.Add(this.btn_Insert_Quarter);
            this.groupBox1.Controls.Add(this.btn_Insert_Dime);
            this.groupBox1.Controls.Add(this.btn_Insert_Nickle);
            this.groupBox1.Location = new System.Drawing.Point(205, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coin Slot";
            // 
            // btn_Inser_Half_Dolar
            // 
            this.btn_Inser_Half_Dolar.Location = new System.Drawing.Point(89, 49);
            this.btn_Inser_Half_Dolar.Name = "btn_Inser_Half_Dolar";
            this.btn_Inser_Half_Dolar.Size = new System.Drawing.Size(75, 23);
            this.btn_Inser_Half_Dolar.TabIndex = 3;
            this.btn_Inser_Half_Dolar.Text = "Half-Dolar";
            this.btn_Inser_Half_Dolar.UseVisualStyleBackColor = true;
            this.btn_Inser_Half_Dolar.Click += new System.EventHandler(this.btn_Inser_Half_Dolar_Click);
            // 
            // btn_Insert_Quarter
            // 
            this.btn_Insert_Quarter.Location = new System.Drawing.Point(89, 19);
            this.btn_Insert_Quarter.Name = "btn_Insert_Quarter";
            this.btn_Insert_Quarter.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert_Quarter.TabIndex = 2;
            this.btn_Insert_Quarter.Text = "Quarter";
            this.btn_Insert_Quarter.UseVisualStyleBackColor = true;
            this.btn_Insert_Quarter.Click += new System.EventHandler(this.btn_Insert_Quarter_Click);
            // 
            // btn_Insert_Dime
            // 
            this.btn_Insert_Dime.Location = new System.Drawing.Point(7, 50);
            this.btn_Insert_Dime.Name = "btn_Insert_Dime";
            this.btn_Insert_Dime.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert_Dime.TabIndex = 1;
            this.btn_Insert_Dime.Text = "Dime";
            this.btn_Insert_Dime.UseVisualStyleBackColor = true;
            this.btn_Insert_Dime.Click += new System.EventHandler(this.btn_Insert_Dime_Click);
            // 
            // btn_Insert_Nickle
            // 
            this.btn_Insert_Nickle.Location = new System.Drawing.Point(7, 20);
            this.btn_Insert_Nickle.Name = "btn_Insert_Nickle";
            this.btn_Insert_Nickle.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert_Nickle.TabIndex = 0;
            this.btn_Insert_Nickle.Text = "Nickel";
            this.btn_Insert_Nickle.UseVisualStyleBackColor = true;
            this.btn_Insert_Nickle.Click += new System.EventHandler(this.btn_Insert_Nickle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDisplayValue);
            this.groupBox2.Controls.Add(this.btn_Selector_9);
            this.groupBox2.Controls.Add(this.btn_Selector_8);
            this.groupBox2.Controls.Add(this.btn_Selector_6);
            this.groupBox2.Controls.Add(this.btn_Selector_5);
            this.groupBox2.Controls.Add(this.btn_Selector_3);
            this.groupBox2.Controls.Add(this.btn_Selector_7);
            this.groupBox2.Controls.Add(this.btn_Selector_2);
            this.groupBox2.Controls.Add(this.btn_Selector_4);
            this.groupBox2.Controls.Add(this.btn_Selector_C);
            this.groupBox2.Controls.Add(this.btn_Selector_1);
            this.groupBox2.Controls.Add(this.btn_Selector_B);
            this.groupBox2.Controls.Add(this.btn_Selector_A);
            this.groupBox2.Location = new System.Drawing.Point(222, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 172);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KeyPad";
            // 
            // lblDisplayValue
            // 
            this.lblDisplayValue.AutoEllipsis = true;
            this.lblDisplayValue.BackColor = System.Drawing.Color.Black;
            this.lblDisplayValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayValue.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayValue.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblDisplayValue.Location = new System.Drawing.Point(15, 20);
            this.lblDisplayValue.Name = "lblDisplayValue";
            this.lblDisplayValue.Size = new System.Drawing.Size(105, 23);
            this.lblDisplayValue.TabIndex = 2;
            this.lblDisplayValue.Text = "Insert Coin";
            // 
            // btn_Selector_9
            // 
            this.btn_Selector_9.Location = new System.Drawing.Point(89, 133);
            this.btn_Selector_9.Name = "btn_Selector_9";
            this.btn_Selector_9.Size = new System.Drawing.Size(31, 23);
            this.btn_Selector_9.TabIndex = 1;
            this.btn_Selector_9.Text = "9";
            this.btn_Selector_9.UseVisualStyleBackColor = true;
            this.btn_Selector_9.Click += new System.EventHandler(this.Selector_Click);
            // 
            // btn_Selector_8
            // 
            this.btn_Selector_8.Location = new System.Drawing.Point(52, 133);
            this.btn_Selector_8.Name = "btn_Selector_8";
            this.btn_Selector_8.Size = new System.Drawing.Size(31, 23);
            this.btn_Selector_8.TabIndex = 1;
            this.btn_Selector_8.Text = "8";
            this.btn_Selector_8.UseVisualStyleBackColor = true;
            this.btn_Selector_8.Click += new System.EventHandler(this.Selector_Click);
            // 
            // btn_Selector_6
            // 
            this.btn_Selector_6.Location = new System.Drawing.Point(89, 104);
            this.btn_Selector_6.Name = "btn_Selector_6";
            this.btn_Selector_6.Size = new System.Drawing.Size(31, 23);
            this.btn_Selector_6.TabIndex = 1;
            this.btn_Selector_6.Text = "6";
            this.btn_Selector_6.UseVisualStyleBackColor = true;
            this.btn_Selector_6.Click += new System.EventHandler(this.Selector_Click);
            // 
            // btn_Selector_5
            // 
            this.btn_Selector_5.Location = new System.Drawing.Point(52, 104);
            this.btn_Selector_5.Name = "btn_Selector_5";
            this.btn_Selector_5.Size = new System.Drawing.Size(31, 23);
            this.btn_Selector_5.TabIndex = 1;
            this.btn_Selector_5.Text = "5";
            this.btn_Selector_5.UseVisualStyleBackColor = true;
            this.btn_Selector_5.Click += new System.EventHandler(this.Selector_Click);
            // 
            // btn_Selector_3
            // 
            this.btn_Selector_3.Location = new System.Drawing.Point(89, 75);
            this.btn_Selector_3.Name = "btn_Selector_3";
            this.btn_Selector_3.Size = new System.Drawing.Size(31, 23);
            this.btn_Selector_3.TabIndex = 1;
            this.btn_Selector_3.Text = "3";
            this.btn_Selector_3.UseVisualStyleBackColor = true;
            this.btn_Selector_3.Click += new System.EventHandler(this.Selector_Click);
            // 
            // btn_Selector_7
            // 
            this.btn_Selector_7.Location = new System.Drawing.Point(15, 134);
            this.btn_Selector_7.Name = "btn_Selector_7";
            this.btn_Selector_7.Size = new System.Drawing.Size(31, 23);
            this.btn_Selector_7.TabIndex = 0;
            this.btn_Selector_7.Text = "7";
            this.btn_Selector_7.UseVisualStyleBackColor = true;
            this.btn_Selector_7.Click += new System.EventHandler(this.Selector_Click);
            // 
            // btn_Selector_2
            // 
            this.btn_Selector_2.Location = new System.Drawing.Point(52, 75);
            this.btn_Selector_2.Name = "btn_Selector_2";
            this.btn_Selector_2.Size = new System.Drawing.Size(31, 23);
            this.btn_Selector_2.TabIndex = 1;
            this.btn_Selector_2.Text = "2";
            this.btn_Selector_2.UseVisualStyleBackColor = true;
            this.btn_Selector_2.Click += new System.EventHandler(this.Selector_Click);
            // 
            // btn_Selector_4
            // 
            this.btn_Selector_4.Location = new System.Drawing.Point(15, 105);
            this.btn_Selector_4.Name = "btn_Selector_4";
            this.btn_Selector_4.Size = new System.Drawing.Size(31, 23);
            this.btn_Selector_4.TabIndex = 0;
            this.btn_Selector_4.Text = "4";
            this.btn_Selector_4.UseVisualStyleBackColor = true;
            this.btn_Selector_4.Click += new System.EventHandler(this.Selector_Click);
            // 
            // btn_Selector_C
            // 
            this.btn_Selector_C.Location = new System.Drawing.Point(89, 46);
            this.btn_Selector_C.Name = "btn_Selector_C";
            this.btn_Selector_C.Size = new System.Drawing.Size(31, 23);
            this.btn_Selector_C.TabIndex = 1;
            this.btn_Selector_C.Text = "C";
            this.btn_Selector_C.UseVisualStyleBackColor = true;
            this.btn_Selector_C.Click += new System.EventHandler(this.Selector_Click);
            // 
            // btn_Selector_1
            // 
            this.btn_Selector_1.Location = new System.Drawing.Point(15, 76);
            this.btn_Selector_1.Name = "btn_Selector_1";
            this.btn_Selector_1.Size = new System.Drawing.Size(31, 23);
            this.btn_Selector_1.TabIndex = 0;
            this.btn_Selector_1.Text = "1";
            this.btn_Selector_1.UseVisualStyleBackColor = true;
            this.btn_Selector_1.Click += new System.EventHandler(this.Selector_Click);
            // 
            // btn_Selector_B
            // 
            this.btn_Selector_B.Location = new System.Drawing.Point(52, 46);
            this.btn_Selector_B.Name = "btn_Selector_B";
            this.btn_Selector_B.Size = new System.Drawing.Size(31, 23);
            this.btn_Selector_B.TabIndex = 1;
            this.btn_Selector_B.Text = "B";
            this.btn_Selector_B.UseVisualStyleBackColor = true;
            this.btn_Selector_B.Click += new System.EventHandler(this.Selector_Click);
            // 
            // btn_Selector_A
            // 
            this.btn_Selector_A.Location = new System.Drawing.Point(15, 47);
            this.btn_Selector_A.Name = "btn_Selector_A";
            this.btn_Selector_A.Size = new System.Drawing.Size(31, 23);
            this.btn_Selector_A.TabIndex = 0;
            this.btn_Selector_A.Text = "A";
            this.btn_Selector_A.UseVisualStyleBackColor = true;
            this.btn_Selector_A.Click += new System.EventHandler(this.Selector_Click);
            // 
            // lblSlot
            // 
            this.lblSlot.Location = new System.Drawing.Point(13, 287);
            this.lblSlot.Name = "lblSlot";
            this.lblSlot.Size = new System.Drawing.Size(360, 34);
            this.lblSlot.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 331);
            this.Controls.Add(this.lblSlot);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstInventory);
            this.Name = "frmMain";
            this.Text = "Virtual Vending Machine";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstInventory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Inser_Half_Dolar;
        private System.Windows.Forms.Button btn_Insert_Quarter;
        private System.Windows.Forms.Button btn_Insert_Dime;
        private System.Windows.Forms.Button btn_Insert_Nickle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Selector_B;
        private System.Windows.Forms.Button btn_Selector_A;
        private System.Windows.Forms.Label lblDisplayValue;
        private System.Windows.Forms.Button btn_Selector_9;
        private System.Windows.Forms.Button btn_Selector_8;
        private System.Windows.Forms.Button btn_Selector_6;
        private System.Windows.Forms.Button btn_Selector_5;
        private System.Windows.Forms.Button btn_Selector_3;
        private System.Windows.Forms.Button btn_Selector_7;
        private System.Windows.Forms.Button btn_Selector_2;
        private System.Windows.Forms.Button btn_Selector_4;
        private System.Windows.Forms.Button btn_Selector_C;
        private System.Windows.Forms.Button btn_Selector_1;
        private System.Windows.Forms.Label lblSlot;
    }
}

