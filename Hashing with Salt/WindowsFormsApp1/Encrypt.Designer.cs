namespace WindowsFormsApp1
{
    partial class Encrypt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnHash = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbSHA1 = new System.Windows.Forms.RadioButton();
            this.gbAlgorithms = new System.Windows.Forms.GroupBox();
            this.rbSHA256 = new System.Windows.Forms.RadioButton();
            this.rbSHA512 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalt = new System.Windows.Forms.TextBox();
            this.gbAlgorithms.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hashing";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text to Encrypt:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(344, 88);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(265, 20);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnHash
            // 
            this.btnHash.Enabled = false;
            this.btnHash.Location = new System.Drawing.Point(366, 345);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(126, 43);
            this.btnHash.TabIndex = 3;
            this.btnHash.Text = "Encrypt";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Encrypted Code:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(185, 355);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(0, 20);
            this.lblCode.TabIndex = 5;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(254, 400);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(440, 20);
            this.txtCode.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(87, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hashing Algorithms:";
            // 
            // rbSHA1
            // 
            this.rbSHA1.AutoSize = true;
            this.rbSHA1.Checked = true;
            this.rbSHA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSHA1.Location = new System.Drawing.Point(21, 29);
            this.rbSHA1.Name = "rbSHA1";
            this.rbSHA1.Size = new System.Drawing.Size(65, 20);
            this.rbSHA1.TabIndex = 8;
            this.rbSHA1.TabStop = true;
            this.rbSHA1.Text = "SHA-1";
            this.rbSHA1.UseVisualStyleBackColor = true;
            // 
            // gbAlgorithms
            // 
            this.gbAlgorithms.Controls.Add(this.txtSalt);
            this.gbAlgorithms.Controls.Add(this.label5);
            this.gbAlgorithms.Controls.Add(this.rbSHA256);
            this.gbAlgorithms.Controls.Add(this.rbSHA512);
            this.gbAlgorithms.Controls.Add(this.rbSHA1);
            this.gbAlgorithms.Location = new System.Drawing.Point(254, 130);
            this.gbAlgorithms.Name = "gbAlgorithms";
            this.gbAlgorithms.Size = new System.Drawing.Size(440, 198);
            this.gbAlgorithms.TabIndex = 9;
            this.gbAlgorithms.TabStop = false;
            this.gbAlgorithms.Text = "Algorithms";
            // 
            // rbSHA256
            // 
            this.rbSHA256.AutoSize = true;
            this.rbSHA256.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbSHA256.Location = new System.Drawing.Point(21, 68);
            this.rbSHA256.Name = "rbSHA256";
            this.rbSHA256.Size = new System.Drawing.Size(138, 21);
            this.rbSHA256.TabIndex = 10;
            this.rbSHA256.Text = "SHA-256 (SHA-2)";
            this.rbSHA256.UseVisualStyleBackColor = true;
            // 
            // rbSHA512
            // 
            this.rbSHA512.AutoSize = true;
            this.rbSHA512.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSHA512.Location = new System.Drawing.Point(21, 110);
            this.rbSHA512.Name = "rbSHA512";
            this.rbSHA512.Size = new System.Drawing.Size(129, 20);
            this.rbSHA512.TabIndex = 9;
            this.rbSHA512.Text = "SHA-512 (SHA-3)";
            this.rbSHA512.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(156, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Salt (Optional) : ";
            // 
            // txtSalt
            // 
            this.txtSalt.Location = new System.Drawing.Point(263, 167);
            this.txtSalt.Name = "txtSalt";
            this.txtSalt.Size = new System.Drawing.Size(155, 20);
            this.txtSalt.TabIndex = 12;
            // 
            // Encrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbAlgorithms);
            this.Name = "Encrypt";
            this.Text = "Hashing with Salt";
            this.gbAlgorithms.ResumeLayout(false);
            this.gbAlgorithms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbSHA1;
        private System.Windows.Forms.GroupBox gbAlgorithms;
        private System.Windows.Forms.RadioButton rbSHA512;
        private System.Windows.Forms.RadioButton rbSHA256;
        private System.Windows.Forms.TextBox txtSalt;
        private System.Windows.Forms.Label label5;
    }
}

