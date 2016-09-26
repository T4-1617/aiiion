namespace BanKing
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnOpenNew = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnConfirmNew = new System.Windows.Forms.Button();
            this.btnCancelNew = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Customer",
            "Employee"});
            this.comboBox1.Location = new System.Drawing.Point(257, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(112, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(132, 160);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(17, 13);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(130, 134);
            this.listBox2.TabIndex = 2;
            // 
            // btnOpenNew
            // 
            this.btnOpenNew.Location = new System.Drawing.Point(48, 153);
            this.btnOpenNew.Name = "btnOpenNew";
            this.btnOpenNew.Size = new System.Drawing.Size(99, 23);
            this.btnOpenNew.TabIndex = 3;
            this.btnOpenNew.Text = "Open Account";
            this.btnOpenNew.UseVisualStyleBackColor = true;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(3, 61);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(99, 23);
            this.btnDeposit.TabIndex = 4;
            this.btnDeposit.Text = "Deposit$";
            this.btnDeposit.UseVisualStyleBackColor = true;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(2, 32);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(100, 23);
            this.btnWithdraw.TabIndex = 5;
            this.btnWithdraw.Text = "Withdraw$";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(3, 3);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(99, 23);
            this.btnBalance.TabIndex = 6;
            this.btnBalance.Text = "Check Balance";
            this.btnBalance.UseVisualStyleBackColor = true;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(424, 174);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(100, 23);
            this.btnDetails.TabIndex = 7;
            this.btnDetails.Text = "Account details";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(559, 33);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(140, 355);
            this.listBox3.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBalance);
            this.panel1.Controls.Add(this.btnDeposit);
            this.panel1.Controls.Add(this.btnWithdraw);
            this.panel1.Location = new System.Drawing.Point(421, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 91);
            this.panel1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(63, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Withdraw:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Deposit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Balance:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(265, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 44);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(265, 318);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 35);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(265, 359);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(166, 29);
            this.panel4.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox4);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.btnCancelNew);
            this.panel5.Controls.Add(this.btnConfirmNew);
            this.panel5.Location = new System.Drawing.Point(44, 268);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 156);
            this.panel5.TabIndex = 20;
            // 
            // btnConfirmNew
            // 
            this.btnConfirmNew.Location = new System.Drawing.Point(103, 121);
            this.btnConfirmNew.Name = "btnConfirmNew";
            this.btnConfirmNew.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmNew.TabIndex = 0;
            this.btnConfirmNew.Text = "Create";
            this.btnConfirmNew.UseVisualStyleBackColor = true;
            // 
            // btnCancelNew
            // 
            this.btnCancelNew.Location = new System.Drawing.Point(13, 121);
            this.btnCancelNew.Name = "btnCancelNew";
            this.btnCancelNew.Size = new System.Drawing.Size(75, 23);
            this.btnCancelNew.TabIndex = 1;
            this.btnCancelNew.Text = "Cancel";
            this.btnCancelNew.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name your account:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(13, 64);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(165, 20);
            this.textBox4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "I am a:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnOpenNew);
            this.panel6.Controls.Add(this.listBox2);
            this.panel6.Location = new System.Drawing.Point(256, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(159, 183);
            this.panel6.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 483);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnOpenNew;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelNew;
        private System.Windows.Forms.Button btnConfirmNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
    }
}

