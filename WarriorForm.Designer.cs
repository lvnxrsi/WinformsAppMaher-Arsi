namespace GameCharacterWinForms1
{
    partial class WarriorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarriorForm));
            this.pictureFighter = new System.Windows.Forms.PictureBox();
            this.textIntelligence = new System.Windows.Forms.TextBox();
            this.textStrength = new System.Windows.Forms.TextBox();
            this.textLevel = new System.Windows.Forms.TextBox();
            this.textHealth = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFighter)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureFighter
            // 
            this.pictureFighter.Image = ((System.Drawing.Image)(resources.GetObject("pictureFighter.Image")));
            this.pictureFighter.Location = new System.Drawing.Point(0, 3);
            this.pictureFighter.Name = "pictureFighter";
            this.pictureFighter.Size = new System.Drawing.Size(806, 454);
            this.pictureFighter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFighter.TabIndex = 0;
            this.pictureFighter.TabStop = false;
            // 
            // textIntelligence
            // 
            this.textIntelligence.BackColor = System.Drawing.Color.DarkKhaki;
            this.textIntelligence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textIntelligence.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIntelligence.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textIntelligence.Location = new System.Drawing.Point(250, 300);
            this.textIntelligence.Name = "textIntelligence";
            this.textIntelligence.Size = new System.Drawing.Size(307, 45);
            this.textIntelligence.TabIndex = 5;
            this.textIntelligence.TextChanged += new System.EventHandler(this.textIntelligence_TextChanged);
            // 
            // textStrength
            // 
            this.textStrength.BackColor = System.Drawing.Color.DarkKhaki;
            this.textStrength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textStrength.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStrength.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textStrength.Location = new System.Drawing.Point(250, 249);
            this.textStrength.Name = "textStrength";
            this.textStrength.Size = new System.Drawing.Size(307, 45);
            this.textStrength.TabIndex = 6;
            this.textStrength.TextChanged += new System.EventHandler(this.textStrength_TextChanged);
            // 
            // textLevel
            // 
            this.textLevel.BackColor = System.Drawing.Color.DarkKhaki;
            this.textLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLevel.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLevel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textLevel.Location = new System.Drawing.Point(250, 147);
            this.textLevel.Name = "textLevel";
            this.textLevel.Size = new System.Drawing.Size(307, 45);
            this.textLevel.TabIndex = 7;
            this.textLevel.TextChanged += new System.EventHandler(this.textLevel_TextChanged);
            // 
            // textHealth
            // 
            this.textHealth.BackColor = System.Drawing.Color.DarkKhaki;
            this.textHealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textHealth.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHealth.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textHealth.Location = new System.Drawing.Point(250, 198);
            this.textHealth.Name = "textHealth";
            this.textHealth.Size = new System.Drawing.Size(307, 45);
            this.textHealth.TabIndex = 8;
            this.textHealth.TextChanged += new System.EventHandler(this.textHealth_TextChanged);
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.DarkKhaki;
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textName.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textName.Location = new System.Drawing.Point(250, 96);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(307, 45);
            this.textName.TabIndex = 9;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnExit.Location = new System.Drawing.Point(693, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 44);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStartGame.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.buttonStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStartGame.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartGame.ForeColor = System.Drawing.Color.DarkKhaki;
            this.buttonStartGame.Location = new System.Drawing.Point(500, 361);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(255, 46);
            this.buttonStartGame.TabIndex = 17;
            this.buttonStartGame.Text = "Start Game";
            this.buttonStartGame.UseVisualStyleBackColor = false;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(72, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 35);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(72, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 35);
            this.label2.TabIndex = 19;
            this.label2.Text = "Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(72, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 35);
            this.label3.TabIndex = 20;
            this.label3.Text = "Health";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(72, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 35);
            this.label4.TabIndex = 21;
            this.label4.Text = "Strength";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(67, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 35);
            this.label5.TabIndex = 22;
            this.label5.Text = "Intelligence";
            // 
            // WarriorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textHealth);
            this.Controls.Add(this.textLevel);
            this.Controls.Add(this.textStrength);
            this.Controls.Add(this.textIntelligence);
            this.Controls.Add(this.pictureFighter);
            this.Name = "WarriorForm";
            this.Text = "FighterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureFighter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureFighter;
        private System.Windows.Forms.TextBox textIntelligence;
        private System.Windows.Forms.TextBox textStrength;
        private System.Windows.Forms.TextBox textLevel;
        private System.Windows.Forms.TextBox textHealth;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
