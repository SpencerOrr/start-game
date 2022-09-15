namespace start_game
{
    partial class startGameBackground
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
            this.startButton = new System.Windows.Forms.Button();
            this.countdownTimer = new System.Windows.Forms.Label();
            this.startGameGO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startButton.Location = new System.Drawing.Point(144, 89);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(109, 42);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Button";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // countdownTimer
            // 
            this.countdownTimer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.countdownTimer.CausesValidation = false;
            this.countdownTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownTimer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.countdownTimer.Location = new System.Drawing.Point(109, 162);
            this.countdownTimer.Name = "countdownTimer";
            this.countdownTimer.Size = new System.Drawing.Size(178, 17);
            this.countdownTimer.TabIndex = 1;
            this.countdownTimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.countdownTimer.Click += new System.EventHandler(this.countdownTimer_Click);
            // 
            // startGameGO
            // 
            this.startGameGO.BackColor = System.Drawing.Color.Lime;
            this.startGameGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameGO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startGameGO.Location = new System.Drawing.Point(-1, 0);
            this.startGameGO.Name = "startGameGO";
            this.startGameGO.Size = new System.Drawing.Size(407, 225);
            this.startGameGO.TabIndex = 2;
            this.startGameGO.Text = "GO";
            this.startGameGO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startGameBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(406, 224);
            this.Controls.Add(this.countdownTimer);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.startGameGO);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "startGameBackground";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label countdownTimer;
        private System.Windows.Forms.Label startGameGO;
    }
}

