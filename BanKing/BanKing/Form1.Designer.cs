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
            this.panCusBtns = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panWithdraw = new System.Windows.Forms.Panel();
            this.panDeposit = new System.Windows.Forms.Panel();
            this.panBalance = new System.Windows.Forms.Panel();
            this.panNewAcc = new System.Windows.Forms.Panel();
            this.btnConfirmNew = new System.Windows.Forms.Button();
            this.btnCancelNew = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panAccounts = new System.Windows.Forms.Panel();
            this.panCusBtns.SuspendLayout();
            this.panWithdraw.SuspendLayout();
            this.panDeposit.SuspendLayout();
            this.panBalance.SuspendLayout();
            this.panNewAcc.SuspendLayout();
            this.panAccounts.SuspendLayout();
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
            // panCusBtns
            // 
            this.panCusBtns.Controls.Add(this.btnBalance);
            this.panCusBtns.Controls.Add(this.btnDeposit);
            this.panCusBtns.Controls.Add(this.btnWithdraw);
            this.panCusBtns.Location = new System.Drawing.Point(421, 82);
            this.panCusBtns.Name = "panCusBtns";
            this.panCusBtns.Size = new System.Drawing.Size(122, 91);
            this.panCusBtns.TabIndex = 9;
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
            // panWithdraw
            // 
            this.panWithdraw.Controls.Add(this.textBox2);
            this.panWithdraw.Controls.Add(this.label1);
            this.panWithdraw.Location = new System.Drawing.Point(265, 268);
            this.panWithdraw.Name = "panWithdraw";
            this.panWithdraw.Size = new System.Drawing.Size(166, 44);
            this.panWithdraw.TabIndex = 17;
            // 
            // panDeposit
            // 
            this.panDeposit.Controls.Add(this.textBox1);
            this.panDeposit.Controls.Add(this.label2);
            this.panDeposit.Location = new System.Drawing.Point(265, 318);
            this.panDeposit.Name = "panDeposit";
            this.panDeposit.Size = new System.Drawing.Size(166, 35);
            this.panDeposit.TabIndex = 18;
            // 
            // panBalance
            // 
            this.panBalance.Controls.Add(this.textBox3);
            this.panBalance.Controls.Add(this.label3);
            this.panBalance.Location = new System.Drawing.Point(265, 359);
            this.panBalance.Name = "panBalance";
            this.panBalance.Size = new System.Drawing.Size(166, 29);
            this.panBalance.TabIndex = 19;
            // 
            // panNewAcc
            // 
            this.panNewAcc.Controls.Add(this.textBox4);
            this.panNewAcc.Controls.Add(this.label4);
            this.panNewAcc.Controls.Add(this.btnCancelNew);
            this.panNewAcc.Controls.Add(this.btnConfirmNew);
            this.panNewAcc.Location = new System.Drawing.Point(44, 268);
            this.panNewAcc.Name = "panNewAcc";
            this.panNewAcc.Size = new System.Drawing.Size(200, 156);
            this.panNewAcc.TabIndex = 20;
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
            // panAccounts
            // 
            this.panAccounts.Controls.Add(this.btnOpenNew);
            this.panAccounts.Controls.Add(this.listBox2);
            this.panAccounts.Location = new System.Drawing.Point(256, 50);
            this.panAccounts.Name = "panAccounts";
            this.panAccounts.Size = new System.Drawing.Size(159, 183);
            this.panAccounts.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 483);
            this.Controls.Add(this.panAccounts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panNewAcc);
            this.Controls.Add(this.panBalance);
            this.Controls.Add(this.panDeposit);
            this.Controls.Add(this.panWithdraw);
            this.Controls.Add(this.panCusBtns);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panCusBtns.ResumeLayout(false);
            this.panWithdraw.ResumeLayout(false);
            this.panWithdraw.PerformLayout();
            this.panDeposit.ResumeLayout(false);
            this.panDeposit.PerformLayout();
            this.panBalance.ResumeLayout(false);
            this.panBalance.PerformLayout();
            this.panNewAcc.ResumeLayout(false);
            this.panNewAcc.PerformLayout();
            this.panAccounts.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panCusBtns;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panWithdraw;
        private System.Windows.Forms.Panel panDeposit;
        private System.Windows.Forms.Panel panBalance;
        private System.Windows.Forms.Panel panNewAcc;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelNew;
        private System.Windows.Forms.Button btnConfirmNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panAccounts;
    }
}

