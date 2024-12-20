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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gameplay));
            this.listLog = new System.Windows.Forms.ListBox();
            this.listDetails = new System.Windows.Forms.ListBox();
            this.buttonAttack = new System.Windows.Forms.Button();
            this.buttonDefend = new System.Windows.Forms.Button();
            this.buttonLevelUp = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listLog
            // 
            this.listLog.BackColor = System.Drawing.SystemColors.InfoText;
            this.listLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.listLog.FormattingEnabled = true;
            this.listLog.ItemHeight = 20;
            this.listLog.Location = new System.Drawing.Point(668, 12);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(120, 122);
            this.listLog.TabIndex = 1;
            this.listLog.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listDetails
            // 
            this.listDetails.BackColor = System.Drawing.Color.Olive;
            this.listDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listDetails.Font = new System.Drawing.Font("Papyrus", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDetails.FormattingEnabled = true;
            this.listDetails.ItemHeight = 25;
            this.listDetails.Location = new System.Drawing.Point(12, 294);
            this.listDetails.Name = "listDetails";
            this.listDetails.Size = new System.Drawing.Size(136, 127);
            this.listDetails.TabIndex = 2;
            // 
            // buttonAttack
            // 
            this.buttonAttack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAttack.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.buttonAttack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAttack.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttack.ForeColor = System.Drawing.Color.DarkKhaki;
            this.buttonAttack.Location = new System.Drawing.Point(235, 390);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(151, 46);
            this.buttonAttack.TabIndex = 18;
            this.buttonAttack.Text = "Attack";
            this.buttonAttack.UseVisualStyleBackColor = false;
            this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click_1);
            // 
            // buttonDefend
            // 
            this.buttonDefend.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDefend.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.buttonDefend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDefend.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDefend.ForeColor = System.Drawing.Color.DarkKhaki;
            this.buttonDefend.Location = new System.Drawing.Point(436, 390);
            this.buttonDefend.Name = "buttonDefend";
            this.buttonDefend.Size = new System.Drawing.Size(137, 46);
            this.buttonDefend.TabIndex = 19;
            this.buttonDefend.Text = "Defend";
            this.buttonDefend.UseVisualStyleBackColor = false;
            this.buttonDefend.Click += new System.EventHandler(this.buttonDefend_Click);
            // 
            // buttonLevelUp
            // 
            this.buttonLevelUp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLevelUp.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.buttonLevelUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLevelUp.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLevelUp.ForeColor = System.Drawing.Color.DarkKhaki;
            this.buttonLevelUp.Location = new System.Drawing.Point(670, 152);
            this.buttonLevelUp.Name = "buttonLevelUp";
            this.buttonLevelUp.Size = new System.Drawing.Size(118, 42);
            this.buttonLevelUp.TabIndex = 20;
            this.buttonLevelUp.Text = "Level Up!";
            this.buttonLevelUp.UseVisualStyleBackColor = false;
            this.buttonLevelUp.Click += new System.EventHandler(this.buttonLevelUp_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.DarkKhaki;
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(118, 46);
            this.buttonBack.TabIndex = 21;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(453, 196);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(182, 159);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(200, 102);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(228, 272);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(818, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Gameplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonLevelUp);
            this.Controls.Add(this.buttonDefend);
            this.Controls.Add(this.buttonAttack);
            this.Controls.Add(this.listDetails);
            this.Controls.Add(this.listLog);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Gameplay";
            this.Text = "Gameplay";
            this.Load += new System.EventHandler(this.Gameplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.ListBox listDetails;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.Button buttonDefend;
        private System.Windows.Forms.Button buttonLevelUp;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}