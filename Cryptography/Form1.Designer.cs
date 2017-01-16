namespace Cryptography
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.decryptedString = new System.Windows.Forms.TextBox();
            this.HDD_ID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.processorID = new System.Windows.Forms.TextBox();
            this.originalString = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.containerName = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.generateKeyPair = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.decryptedAddressTextBox = new System.Windows.Forms.TextBox();
            this.decryptedNameTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.registeredAddressTextBox = new System.Windows.Forms.TextBox();
            this.registeredNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.publicKeyTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 494);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.decryptedString);
            this.tabPage1.Controls.Add(this.HDD_ID);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.processorID);
            this.tabPage1.Controls.Add(this.originalString);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(624, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PERSONAL LICENSE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "HDD ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 34);
            this.button1.TabIndex = 29;
            this.button1.Text = "CHECK LICENSE FILE CONTENT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "PROCESSOR ID";
            // 
            // decryptedString
            // 
            this.decryptedString.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptedString.Location = new System.Drawing.Point(53, 369);
            this.decryptedString.Name = "decryptedString";
            this.decryptedString.Size = new System.Drawing.Size(491, 29);
            this.decryptedString.TabIndex = 28;
            // 
            // HDD_ID
            // 
            this.HDD_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDD_ID.Location = new System.Drawing.Point(246, 206);
            this.HDD_ID.Name = "HDD_ID";
            this.HDD_ID.Size = new System.Drawing.Size(283, 29);
            this.HDD_ID.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 34);
            this.button2.TabIndex = 27;
            this.button2.Text = "CREATE LICENSE FILE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // processorID
            // 
            this.processorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processorID.Location = new System.Drawing.Point(246, 171);
            this.processorID.Name = "processorID";
            this.processorID.Size = new System.Drawing.Size(283, 29);
            this.processorID.TabIndex = 30;
            // 
            // originalString
            // 
            this.originalString.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalString.Location = new System.Drawing.Point(53, 248);
            this.originalString.Name = "originalString";
            this.originalString.Size = new System.Drawing.Size(491, 29);
            this.originalString.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.containerName);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(53, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 131);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(228, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 34);
            this.button3.TabIndex = 29;
            this.button3.Text = "DELETE KEY FROM CONTAINER";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "CONTAINER NAME";
            // 
            // containerName
            // 
            this.containerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerName.Location = new System.Drawing.Point(193, 31);
            this.containerName.Name = "containerName";
            this.containerName.Size = new System.Drawing.Size(190, 29);
            this.containerName.TabIndex = 27;
            this.containerName.Text = "POS_CONTAINER";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(43, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 34);
            this.button4.TabIndex = 26;
            this.button4.Text = "STORE KEY TO CONTAINER";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage2.Controls.Add(this.generateKeyPair);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.keywordTextBox);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.decryptedAddressTextBox);
            this.tabPage2.Controls.Add(this.decryptedNameTextBox);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.registeredAddressTextBox);
            this.tabPage2.Controls.Add(this.registeredNameTextBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.publicKeyTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(624, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "VOLUME LICENSE";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // generateKeyPair
            // 
            this.generateKeyPair.AutoSize = true;
            this.generateKeyPair.Checked = true;
            this.generateKeyPair.CheckState = System.Windows.Forms.CheckState.Checked;
            this.generateKeyPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateKeyPair.Location = new System.Drawing.Point(39, 222);
            this.generateKeyPair.Name = "generateKeyPair";
            this.generateKeyPair.Size = new System.Drawing.Size(190, 24);
            this.generateKeyPair.TabIndex = 47;
            this.generateKeyPair.Text = "Generate new Key Pair";
            this.generateKeyPair.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(48, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "LICENSE KEYWORD";
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordTextBox.Location = new System.Drawing.Point(235, 66);
            this.keywordTextBox.MaxLength = 30;
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.Size = new System.Drawing.Size(381, 29);
            this.keywordTextBox.TabIndex = 45;
            this.keywordTextBox.Text = "AlphaSoft";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(232, 283);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(193, 34);
            this.button6.TabIndex = 44;
            this.button6.Text = "CHECK LICENSE FILE CONTENT";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "LICENSE ADDRESS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "LICENSE NAME";
            // 
            // decryptedAddressTextBox
            // 
            this.decryptedAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptedAddressTextBox.Location = new System.Drawing.Point(235, 367);
            this.decryptedAddressTextBox.Multiline = true;
            this.decryptedAddressTextBox.Name = "decryptedAddressTextBox";
            this.decryptedAddressTextBox.ReadOnly = true;
            this.decryptedAddressTextBox.Size = new System.Drawing.Size(381, 75);
            this.decryptedAddressTextBox.TabIndex = 42;
            // 
            // decryptedNameTextBox
            // 
            this.decryptedNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptedNameTextBox.Location = new System.Drawing.Point(235, 332);
            this.decryptedNameTextBox.Name = "decryptedNameTextBox";
            this.decryptedNameTextBox.ReadOnly = true;
            this.decryptedNameTextBox.Size = new System.Drawing.Size(381, 29);
            this.decryptedNameTextBox.TabIndex = 40;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(235, 217);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(193, 34);
            this.button5.TabIndex = 39;
            this.button5.Text = "CREATE LICENSE FILE ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "REGISTERED ADDRESS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "REGISTERED NAME";
            // 
            // registeredAddressTextBox
            // 
            this.registeredAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registeredAddressTextBox.Location = new System.Drawing.Point(235, 136);
            this.registeredAddressTextBox.MaxLength = 100;
            this.registeredAddressTextBox.Multiline = true;
            this.registeredAddressTextBox.Name = "registeredAddressTextBox";
            this.registeredAddressTextBox.Size = new System.Drawing.Size(381, 75);
            this.registeredAddressTextBox.TabIndex = 37;
            // 
            // registeredNameTextBox
            // 
            this.registeredNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registeredNameTextBox.Location = new System.Drawing.Point(235, 101);
            this.registeredNameTextBox.MaxLength = 50;
            this.registeredNameTextBox.Name = "registeredNameTextBox";
            this.registeredNameTextBox.Size = new System.Drawing.Size(381, 29);
            this.registeredNameTextBox.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "PUBLIC KEY";
            // 
            // publicKeyTextBox
            // 
            this.publicKeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicKeyTextBox.Location = new System.Drawing.Point(235, 17);
            this.publicKeyTextBox.Name = "publicKeyTextBox";
            this.publicKeyTextBox.Size = new System.Drawing.Size(190, 29);
            this.publicKeyTextBox.TabIndex = 29;
            this.publicKeyTextBox.Text = "POS_CONTAINER";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 494);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LICENSE FILE CREATOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox decryptedString;
        private System.Windows.Forms.TextBox HDD_ID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox processorID;
        private System.Windows.Forms.TextBox originalString;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox containerName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox publicKeyTextBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox decryptedAddressTextBox;
        private System.Windows.Forms.TextBox decryptedNameTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox registeredAddressTextBox;
        private System.Windows.Forms.TextBox registeredNameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox keywordTextBox;
        private System.Windows.Forms.CheckBox generateKeyPair;
    }
}

