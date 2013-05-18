namespace PasswordCourier
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpGenerator = new System.Windows.Forms.GroupBox();
            this.btnGenSalt = new System.Windows.Forms.Button();
            this.txtGenEncoded = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenKey = new System.Windows.Forms.Button();
            this.txtGenSalt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGenPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPresenter = new System.Windows.Forms.GroupBox();
            this.txtViewPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtViewKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpGenerator.SuspendLayout();
            this.grpPresenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // grpGenerator
            // 
            this.grpGenerator.Controls.Add(this.btnGenSalt);
            this.grpGenerator.Controls.Add(this.txtGenEncoded);
            this.grpGenerator.Controls.Add(this.label3);
            this.grpGenerator.Controls.Add(this.btnGenKey);
            this.grpGenerator.Controls.Add(this.txtGenSalt);
            this.grpGenerator.Controls.Add(this.label2);
            this.grpGenerator.Controls.Add(this.txtGenPass);
            this.grpGenerator.Controls.Add(this.label1);
            this.grpGenerator.Location = new System.Drawing.Point(1, 55);
            this.grpGenerator.Name = "grpGenerator";
            this.grpGenerator.Size = new System.Drawing.Size(283, 118);
            this.grpGenerator.TabIndex = 1;
            this.grpGenerator.TabStop = false;
            this.grpGenerator.Text = "Key Generator";
            // 
            // btnGenSalt
            // 
            this.btnGenSalt.Location = new System.Drawing.Point(93, 40);
            this.btnGenSalt.Name = "btnGenSalt";
            this.btnGenSalt.Size = new System.Drawing.Size(90, 23);
            this.btnGenSalt.TabIndex = 7;
            this.btnGenSalt.Text = "Generate Salt";
            this.btnGenSalt.UseVisualStyleBackColor = true;
            this.btnGenSalt.Click += new System.EventHandler(this.btnGenSalt_Click);
            // 
            // txtGenEncoded
            // 
            this.txtGenEncoded.Location = new System.Drawing.Point(93, 90);
            this.txtGenEncoded.Name = "txtGenEncoded";
            this.txtGenEncoded.ReadOnly = true;
            this.txtGenEncoded.Size = new System.Drawing.Size(183, 22);
            this.txtGenEncoded.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Key (Embed) :";
            // 
            // btnGenKey
            // 
            this.btnGenKey.Location = new System.Drawing.Point(185, 40);
            this.btnGenKey.Name = "btnGenKey";
            this.btnGenKey.Size = new System.Drawing.Size(91, 23);
            this.btnGenKey.TabIndex = 4;
            this.btnGenKey.Text = "Generate Key";
            this.btnGenKey.UseVisualStyleBackColor = true;
            this.btnGenKey.Click += new System.EventHandler(this.btnGenerateKeyClick);
            // 
            // txtGenSalt
            // 
            this.txtGenSalt.Location = new System.Drawing.Point(93, 66);
            this.txtGenSalt.Name = "txtGenSalt";
            this.txtGenSalt.Size = new System.Drawing.Size(183, 22);
            this.txtGenSalt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salt (Distribute) :";
            // 
            // txtGenPass
            // 
            this.txtGenPass.Location = new System.Drawing.Point(93, 16);
            this.txtGenPass.Name = "txtGenPass";
            this.txtGenPass.Size = new System.Drawing.Size(183, 22);
            this.txtGenPass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password :";
            // 
            // grpPresenter
            // 
            this.grpPresenter.Controls.Add(this.txtViewPassword);
            this.grpPresenter.Controls.Add(this.label5);
            this.grpPresenter.Controls.Add(this.txtViewKey);
            this.grpPresenter.Controls.Add(this.label4);
            this.grpPresenter.Location = new System.Drawing.Point(1, 55);
            this.grpPresenter.Name = "grpPresenter";
            this.grpPresenter.Size = new System.Drawing.Size(283, 118);
            this.grpPresenter.TabIndex = 0;
            this.grpPresenter.TabStop = false;
            this.grpPresenter.Text = "Password Viewer";
            // 
            // txtViewPassword
            // 
            this.txtViewPassword.Location = new System.Drawing.Point(11, 88);
            this.txtViewPassword.Name = "txtViewPassword";
            this.txtViewPassword.ReadOnly = true;
            this.txtViewPassword.Size = new System.Drawing.Size(261, 22);
            this.txtViewPassword.TabIndex = 3;
            this.txtViewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Your Password Is :";
            // 
            // txtViewKey
            // 
            this.txtViewKey.Location = new System.Drawing.Point(11, 37);
            this.txtViewKey.Name = "txtViewKey";
            this.txtViewKey.Size = new System.Drawing.Size(261, 22);
            this.txtViewKey.TabIndex = 1;
            this.txtViewKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter Your Key :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "(C) 2012 Christopher Walker - GNU GPL 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(285, 195);
            this.Controls.Add(this.grpGenerator);
            this.Controls.Add(this.grpPresenter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(301, 233);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(301, 233);
            this.Name = "Form1";
            this.Text = "Password Courier";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpGenerator.ResumeLayout(false);
            this.grpGenerator.PerformLayout();
            this.grpPresenter.ResumeLayout(false);
            this.grpPresenter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpGenerator;
        private System.Windows.Forms.GroupBox grpPresenter;
        private System.Windows.Forms.TextBox txtGenPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGenSalt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGenEncoded;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenKey;
        private System.Windows.Forms.TextBox txtViewPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtViewKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenSalt;
    }
}

