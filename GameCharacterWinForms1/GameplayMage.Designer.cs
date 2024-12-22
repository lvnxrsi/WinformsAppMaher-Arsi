namespace GameCharacterWinForms1
{
    partial class GameplayMage
    {
        private System.ComponentModel.IContainer components = null;

        // Clean up any resources being used
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.buttonLevelUp = new System.Windows.Forms.Button();
            this.buttonDefend = new System.Windows.Forms.Button();
            this.buttonAttack = new System.Windows.Forms.Button();
            this.listDetails = new System.Windows.Forms.ListBox();
            this.listLog = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLevelUp
            // 
            this.buttonLevelUp.BackColor = System.Drawing.Color.HotPink;
            this.buttonLevelUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLevelUp.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLevelUp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLevelUp.Location = new System.Drawing.Point(23, 247);
            this.buttonLevelUp.Name = "buttonLevelUp";
            this.buttonLevelUp.Size = new System.Drawing.Size(118, 61);
            this.buttonLevelUp.TabIndex = 28;
            this.buttonLevelUp.Text = "Level Up!";
            this.buttonLevelUp.UseVisualStyleBackColor = false;
            this.buttonLevelUp.Click += new System.EventHandler(this.buttonLevelUp_Click);
            // 
            // buttonDefend
            // 
            this.buttonDefend.BackColor = System.Drawing.Color.HotPink;
            this.buttonDefend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDefend.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDefend.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDefend.Location = new System.Drawing.Point(430, 373);
            this.buttonDefend.Name = "buttonDefend";
            this.buttonDefend.Size = new System.Drawing.Size(137, 46);
            this.buttonDefend.TabIndex = 27;
            this.buttonDefend.Text = "Defend";
            this.buttonDefend.UseVisualStyleBackColor = false;
            this.buttonDefend.Click += new System.EventHandler(this.buttonDefend_Click);
            // 
            // buttonAttack
            // 
            this.buttonAttack.BackColor = System.Drawing.Color.HotPink;
            this.buttonAttack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAttack.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttack.ForeColor = System.Drawing.Color.White;
            this.buttonAttack.Location = new System.Drawing.Point(227, 373);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(144, 46);
            this.buttonAttack.TabIndex = 26;
            this.buttonAttack.Text = "Attack";
            this.buttonAttack.UseVisualStyleBackColor = false;
            this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click_1);
            // 
            // listDetails
            // 
            this.listDetails.BackColor = System.Drawing.Color.LightPink;
            this.listDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listDetails.Font = new System.Drawing.Font("Yu Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDetails.FormattingEnabled = true;
            this.listDetails.ItemHeight = 21;
            this.listDetails.Location = new System.Drawing.Point(12, 22);
            this.listDetails.Name = "listDetails";
            this.listDetails.Size = new System.Drawing.Size(154, 191);
            this.listDetails.TabIndex = 25;
            // 
            // listLog
            // 
            this.listLog.BackColor = System.Drawing.Color.Pink;
            this.listLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listLog.Font = new System.Drawing.Font("Yu Gothic Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listLog.FormattingEnabled = true;
            this.listLog.ItemHeight = 21;
            this.listLog.Location = new System.Drawing.Point(590, 331);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(198, 107);
            this.listLog.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.HotPink;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(667, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 46);
            this.button1.TabIndex = 29;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GameCharacterWinForms1.Properties.Resources._10;
            this.pictureBox1.Location = new System.Drawing.Point(2, -82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(821, 558);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // GameplayMage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLevelUp);
            this.Controls.Add(this.buttonDefend);
            this.Controls.Add(this.buttonAttack);
            this.Controls.Add(this.listDetails);
            this.Controls.Add(this.listLog);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GameplayMage";
            this.Text = "GameplayMage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonLevelUp;
        private System.Windows.Forms.Button buttonDefend;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.ListBox listDetails;
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
