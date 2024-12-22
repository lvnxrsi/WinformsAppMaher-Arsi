namespace GameCharacterWinForms1
{
    partial class Gameplay
    {
        private System.ComponentModel.IContainer components = null;

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
            this.listDetails = new System.Windows.Forms.ListBox();
            this.buttonLevelUp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAttack = new System.Windows.Forms.Button();
            this.buttonDefend = new System.Windows.Forms.Button();
            this.listLog = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listDetails
            // 
            this.listDetails.BackColor = System.Drawing.Color.LightPink;
            this.listDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listDetails.Font = new System.Drawing.Font("Yu Gothic", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDetails.FormattingEnabled = true;
            this.listDetails.Location = new System.Drawing.Point(12, 12);
            this.listDetails.Name = "listDetails";
            this.listDetails.Size = new System.Drawing.Size(154, 184);
            this.listDetails.TabIndex = 26;
            // 
            // buttonLevelUp
            // 
            this.buttonLevelUp.BackColor = System.Drawing.Color.HotPink;
            this.buttonLevelUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLevelUp.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLevelUp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLevelUp.Location = new System.Drawing.Point(22, 220);
            this.buttonLevelUp.Name = "buttonLevelUp";
            this.buttonLevelUp.Size = new System.Drawing.Size(118, 61);
            this.buttonLevelUp.TabIndex = 29;
            this.buttonLevelUp.Text = "Level Up!";
            this.buttonLevelUp.UseVisualStyleBackColor = false;
            this.buttonLevelUp.Click += new System.EventHandler(this.buttonLevelUp_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.HotPink;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(670, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 46);
            this.button1.TabIndex = 30;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAttack
            // 
            this.buttonAttack.BackColor = System.Drawing.Color.HotPink;
            this.buttonAttack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAttack.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttack.ForeColor = System.Drawing.Color.White;
            this.buttonAttack.Location = new System.Drawing.Point(221, 392);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(151, 46);
            this.buttonAttack.TabIndex = 31;
            this.buttonAttack.Text = "Attack";
            this.buttonAttack.UseVisualStyleBackColor = false;
            this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click);
            // 
            // buttonDefend
            // 
            this.buttonDefend.BackColor = System.Drawing.Color.HotPink;
            this.buttonDefend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDefend.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDefend.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDefend.Location = new System.Drawing.Point(401, 392);
            this.buttonDefend.Name = "buttonDefend";
            this.buttonDefend.Size = new System.Drawing.Size(137, 46);
            this.buttonDefend.TabIndex = 32;
            this.buttonDefend.Text = "Defend";
            this.buttonDefend.UseVisualStyleBackColor = false;
            this.buttonDefend.Click += new System.EventHandler(this.buttonDefend_Click_1);
            // 
            // listLog
            // 
            this.listLog.BackColor = System.Drawing.Color.Pink;
            this.listLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listLog.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listLog.FormattingEnabled = true;
            this.listLog.ItemHeight = 21;
            this.listLog.Location = new System.Drawing.Point(591, 331);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(197, 107);
            this.listLog.TabIndex = 33;
            this.listLog.SelectedIndexChanged += new System.EventHandler(this.listLog_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::GameCharacterWinForms1.Properties.Resources._9;
            this.pictureBox1.Location = new System.Drawing.Point(-7, -82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(852, 567);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Gameplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listLog);
            this.Controls.Add(this.buttonDefend);
            this.Controls.Add(this.buttonAttack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLevelUp);
            this.Controls.Add(this.listDetails);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Gameplay";
            this.Text = "Gameplay";
            this.Load += new System.EventHandler(this.Gameplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listDetails;
        private System.Windows.Forms.Button buttonLevelUp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.Button buttonDefend;
        private System.Windows.Forms.ListBox listLog;
    }
}
