namespace GameCharacterWinForms1
{
    partial class MageForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textLevel = new System.Windows.Forms.TextBox();
            this.textHealth = new System.Windows.Forms.TextBox();
            this.textMana = new System.Windows.Forms.TextBox();
            this.buttonStartMage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureMage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DeepPink;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(684, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 44);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.Pink;
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textName.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textName.Location = new System.Drawing.Point(275, 90);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(268, 37);
            this.textName.TabIndex = 12;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // textLevel
            // 
            this.textLevel.BackColor = System.Drawing.Color.Pink;
            this.textLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLevel.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLevel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textLevel.Location = new System.Drawing.Point(275, 154);
            this.textLevel.Name = "textLevel";
            this.textLevel.Size = new System.Drawing.Size(268, 37);
            this.textLevel.TabIndex = 13;
            this.textLevel.TextChanged += new System.EventHandler(this.textLevel_TextChanged);
            // 
            // textHealth
            // 
            this.textHealth.BackColor = System.Drawing.Color.Pink;
            this.textHealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textHealth.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHealth.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textHealth.Location = new System.Drawing.Point(275, 225);
            this.textHealth.Name = "textHealth";
            this.textHealth.Size = new System.Drawing.Size(268, 37);
            this.textHealth.TabIndex = 14;
            this.textHealth.TextChanged += new System.EventHandler(this.textHealth_TextChanged);
            // 
            // textMana
            // 
            this.textMana.BackColor = System.Drawing.Color.Pink;
            this.textMana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMana.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMana.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textMana.Location = new System.Drawing.Point(275, 286);
            this.textMana.Name = "textMana";
            this.textMana.Size = new System.Drawing.Size(268, 37);
            this.textMana.TabIndex = 15;
            this.textMana.TextChanged += new System.EventHandler(this.textMana_TextChanged);
            // 
            // buttonStartMage
            // 
            this.buttonStartMage.BackColor = System.Drawing.Color.DeepPink;
            this.buttonStartMage.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.buttonStartMage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStartMage.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartMage.ForeColor = System.Drawing.Color.White;
            this.buttonStartMage.Location = new System.Drawing.Point(275, 351);
            this.buttonStartMage.Name = "buttonStartMage";
            this.buttonStartMage.Size = new System.Drawing.Size(255, 46);
            this.buttonStartMage.TabIndex = 16;
            this.buttonStartMage.Text = "Start Game";
            this.buttonStartMage.UseVisualStyleBackColor = false;
            this.buttonStartMage.Click += new System.EventHandler(this.buttonStartMage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(121, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(107, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "Health";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(126, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 32);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mana";
            // 
            // pictureMage
            // 
            this.pictureMage.Image = global::GameCharacterWinForms1.Properties.Resources._81;
            this.pictureMage.Location = new System.Drawing.Point(-18, -40);
            this.pictureMage.Name = "pictureMage";
            this.pictureMage.Size = new System.Drawing.Size(806, 497);
            this.pictureMage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMage.TabIndex = 1;
            this.pictureMage.TabStop = false;
            // 
            // MageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStartMage);
            this.Controls.Add(this.textMana);
            this.Controls.Add(this.textHealth);
            this.Controls.Add(this.textLevel);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureMage);
            this.Name = "MageForm";
            this.Text = "MageForm";
            this.Load += new System.EventHandler(this.MageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureMage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textLevel;
        private System.Windows.Forms.TextBox textHealth;
        private System.Windows.Forms.TextBox textMana;
        private System.Windows.Forms.Button buttonStartMage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}