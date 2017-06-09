namespace One_ArmedBandit
{
    partial class MachineScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MachineScreen));
            this.buttSpin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labPlayerName = new System.Windows.Forms.Label();
            this.labTokens = new System.Windows.Forms.Label();
            this.labCash = new System.Windows.Forms.Label();
            this.labTokensPool = new System.Windows.Forms.Label();
            this.buttSell = new System.Windows.Forms.Button();
            this.buttBuy = new System.Windows.Forms.Button();
            this.buttCollect = new System.Windows.Forms.Button();
            this.labBet = new System.Windows.Forms.Label();
            this.buttHints = new System.Windows.Forms.Button();
            this.buttExit = new System.Windows.Forms.Button();
            this.labAlert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttSpin
            // 
            this.buttSpin.BackColor = System.Drawing.Color.Gold;
            this.buttSpin.BackgroundImage = global::One_ArmedBandit.Properties.Resources.lever;
            this.buttSpin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttSpin.Location = new System.Drawing.Point(336, 32);
            this.buttSpin.Name = "buttSpin";
            this.buttSpin.Size = new System.Drawing.Size(60, 170);
            this.buttSpin.TabIndex = 0;
            this.buttSpin.UseVisualStyleBackColor = false;
            this.buttSpin.Click += new System.EventHandler(this.buttSpin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(10, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(116, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(222, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // labPlayerName
            // 
            this.labPlayerName.AutoSize = true;
            this.labPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.labPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labPlayerName.Location = new System.Drawing.Point(12, 135);
            this.labPlayerName.Name = "labPlayerName";
            this.labPlayerName.Size = new System.Drawing.Size(100, 17);
            this.labPlayerName.TabIndex = 4;
            this.labPlayerName.Text = "PlayerName:";
            // 
            // labTokens
            // 
            this.labTokens.AutoSize = true;
            this.labTokens.BackColor = System.Drawing.Color.Transparent;
            this.labTokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labTokens.Location = new System.Drawing.Point(12, 150);
            this.labTokens.Name = "labTokens";
            this.labTokens.Size = new System.Drawing.Size(66, 17);
            this.labTokens.TabIndex = 10;
            this.labTokens.Text = "Tokens:";
            // 
            // labCash
            // 
            this.labCash.AutoSize = true;
            this.labCash.BackColor = System.Drawing.Color.Transparent;
            this.labCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labCash.Location = new System.Drawing.Point(12, 164);
            this.labCash.Name = "labCash";
            this.labCash.Size = new System.Drawing.Size(49, 17);
            this.labCash.TabIndex = 11;
            this.labCash.Text = "Cash:";
            // 
            // labTokensPool
            // 
            this.labTokensPool.AutoSize = true;
            this.labTokensPool.BackColor = System.Drawing.Color.Transparent;
            this.labTokensPool.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labTokensPool.Location = new System.Drawing.Point(171, 135);
            this.labTokensPool.Name = "labTokensPool";
            this.labTokensPool.Size = new System.Drawing.Size(129, 15);
            this.labTokensPool.TabIndex = 12;
            this.labTokensPool.Text = "Tokens in the pool:";
            // 
            // buttSell
            // 
            this.buttSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttSell.Location = new System.Drawing.Point(12, 183);
            this.buttSell.Name = "buttSell";
            this.buttSell.Size = new System.Drawing.Size(75, 36);
            this.buttSell.TabIndex = 13;
            this.buttSell.Text = "SELL TOKENS";
            this.buttSell.UseVisualStyleBackColor = false;
            this.buttSell.Click += new System.EventHandler(this.buttSell_Click);
            // 
            // buttBuy
            // 
            this.buttBuy.BackColor = System.Drawing.Color.GreenYellow;
            this.buttBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttBuy.Location = new System.Drawing.Point(93, 183);
            this.buttBuy.Name = "buttBuy";
            this.buttBuy.Size = new System.Drawing.Size(75, 36);
            this.buttBuy.TabIndex = 14;
            this.buttBuy.Text = "BUY TOKENS";
            this.buttBuy.UseVisualStyleBackColor = false;
            this.buttBuy.Click += new System.EventHandler(this.buttBuy_Click);
            // 
            // buttCollect
            // 
            this.buttCollect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttCollect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttCollect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttCollect.Location = new System.Drawing.Point(174, 183);
            this.buttCollect.Name = "buttCollect";
            this.buttCollect.Size = new System.Drawing.Size(75, 36);
            this.buttCollect.TabIndex = 15;
            this.buttCollect.Text = "COLLECT";
            this.buttCollect.UseVisualStyleBackColor = false;
            this.buttCollect.Click += new System.EventHandler(this.buttCollect_Click);
            // 
            // labBet
            // 
            this.labBet.AutoSize = true;
            this.labBet.BackColor = System.Drawing.Color.Transparent;
            this.labBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labBet.Location = new System.Drawing.Point(171, 150);
            this.labBet.Name = "labBet";
            this.labBet.Size = new System.Drawing.Size(82, 15);
            this.labBet.TabIndex = 16;
            this.labBet.Text = "Current bet:";
            // 
            // buttHints
            // 
            this.buttHints.BackColor = System.Drawing.Color.Aqua;
            this.buttHints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttHints.Location = new System.Drawing.Point(255, 183);
            this.buttHints.Name = "buttHints";
            this.buttHints.Size = new System.Drawing.Size(75, 36);
            this.buttHints.TabIndex = 17;
            this.buttHints.Text = "HINTS";
            this.buttHints.UseVisualStyleBackColor = false;
            this.buttHints.Click += new System.EventHandler(this.buttHints_Click);
            // 
            // buttExit
            // 
            this.buttExit.BackColor = System.Drawing.Color.Red;
            this.buttExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttExit.Location = new System.Drawing.Point(9, 4);
            this.buttExit.Name = "buttExit";
            this.buttExit.Size = new System.Drawing.Size(50, 23);
            this.buttExit.TabIndex = 18;
            this.buttExit.Text = "EXIT";
            this.buttExit.UseVisualStyleBackColor = false;
            this.buttExit.Click += new System.EventHandler(this.buttExit_Click);
            // 
            // labAlert
            // 
            this.labAlert.AutoSize = true;
            this.labAlert.BackColor = System.Drawing.Color.Transparent;
            this.labAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labAlert.ForeColor = System.Drawing.Color.Red;
            this.labAlert.Location = new System.Drawing.Point(78, 10);
            this.labAlert.Name = "labAlert";
            this.labAlert.Size = new System.Drawing.Size(47, 17);
            this.labAlert.TabIndex = 19;
            this.labAlert.Text = "Alert:";
            // 
            // MachineScreen
            // 
            this.AcceptButton = this.buttSpin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.buttExit;
            this.ClientSize = new System.Drawing.Size(409, 231);
            this.Controls.Add(this.labAlert);
            this.Controls.Add(this.buttExit);
            this.Controls.Add(this.buttHints);
            this.Controls.Add(this.labBet);
            this.Controls.Add(this.buttCollect);
            this.Controls.Add(this.buttBuy);
            this.Controls.Add(this.buttSell);
            this.Controls.Add(this.labTokensPool);
            this.Controls.Add(this.labCash);
            this.Controls.Add(this.labTokens);
            this.Controls.Add(this.labPlayerName);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttSpin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MachineScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Machine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MachineScreen_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttSpin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labPlayerName;
        private System.Windows.Forms.Label labTokens;
        private System.Windows.Forms.Label labCash;
        private System.Windows.Forms.Label labTokensPool;
        private System.Windows.Forms.Button buttSell;
        private System.Windows.Forms.Button buttBuy;
        private System.Windows.Forms.Button buttCollect;
        private System.Windows.Forms.Label labBet;
        private System.Windows.Forms.Button buttHints;
        private System.Windows.Forms.Button buttExit;
        private System.Windows.Forms.Label labAlert;
    }
}

