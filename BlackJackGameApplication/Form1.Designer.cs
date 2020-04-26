
using System.Drawing;
namespace BlackJackGameApplication

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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnHitMe = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.lblPlayersCards = new System.Windows.Forms.Label();
            this.pbPlayerCard1 = new System.Windows.Forms.PictureBox();
            this.pbPlayerCard2 = new System.Windows.Forms.PictureBox();
            this.pbPlayerCard3 = new System.Windows.Forms.PictureBox();
            this.pbPlayerCard4 = new System.Windows.Forms.PictureBox();
            this.pbPlayerCard5 = new System.Windows.Forms.PictureBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.pnlDealer = new System.Windows.Forms.Panel();
            this.lblDealersCards = new System.Windows.Forms.Label();
            this.pbDealerCard1 = new System.Windows.Forms.PictureBox();
            this.pbDealerCard2 = new System.Windows.Forms.PictureBox();
            this.pbDealerCard3 = new System.Windows.Forms.PictureBox();
            this.pbDealerCard4 = new System.Windows.Forms.PictureBox();
            this.pbDealerCard5 = new System.Windows.Forms.PictureBox();
            this.lblDealer = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtMessageBox = new System.Windows.Forms.TextBox();
            this.pnlPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerCard5)).BeginInit();
            this.pnlDealer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealerCard5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(66, 71);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(114, 30);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play Game";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHitMe
            // 
            this.btnHitMe.Enabled = false;
            this.btnHitMe.Location = new System.Drawing.Point(66, 119);
            this.btnHitMe.Name = "btnHitMe";
            this.btnHitMe.Size = new System.Drawing.Size(114, 30);
            this.btnHitMe.TabIndex = 1;
            this.btnHitMe.Text = "Hit Me";
            this.btnHitMe.UseVisualStyleBackColor = true;
            this.btnHitMe.Click += new System.EventHandler(this.btnHitMe_Click);
            // 
            // btnStay
            // 
            this.btnStay.Enabled = false;
            this.btnStay.Location = new System.Drawing.Point(66, 171);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(114, 29);
            this.btnStay.TabIndex = 2;
            this.btnStay.Text = "Stay Put";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlPlayer.Controls.Add(this.lblPlayersCards);
            this.pnlPlayer.Controls.Add(this.pbPlayerCard1);
            this.pnlPlayer.Controls.Add(this.pbPlayerCard2);
            this.pnlPlayer.Controls.Add(this.pbPlayerCard3);
            this.pnlPlayer.Controls.Add(this.pbPlayerCard4);
            this.pnlPlayer.Controls.Add(this.pbPlayerCard5);
            this.pnlPlayer.Controls.Add(this.lblPlayer);
            this.pnlPlayer.Location = new System.Drawing.Point(303, 71);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlPlayer.Size = new System.Drawing.Size(518, 193);
            this.pnlPlayer.TabIndex = 5;
            this.pnlPlayer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPlayer_Paint);
            // 
            // lblPlayersCards
            // 
            this.lblPlayersCards.AutoSize = true;
            this.lblPlayersCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayersCards.Location = new System.Drawing.Point(33, 14);
            this.lblPlayersCards.Name = "lblPlayersCards";
            this.lblPlayersCards.Size = new System.Drawing.Size(106, 16);
            this.lblPlayersCards.TabIndex = 6;
            this.lblPlayersCards.Text = "Players Cards";
            // 
            // pbPlayerCard1
            // 
            this.pbPlayerCard1.Location = new System.Drawing.Point(37, 48);
            this.pbPlayerCard1.Name = "pbPlayerCard1";
            this.pbPlayerCard1.Size = new System.Drawing.Size(75, 96);
            this.pbPlayerCard1.TabIndex = 1;
            this.pbPlayerCard1.TabStop = false;
            // 
            // pbPlayerCard2
            // 
            this.pbPlayerCard2.Location = new System.Drawing.Point(135, 48);
            this.pbPlayerCard2.Name = "pbPlayerCard2";
            this.pbPlayerCard2.Size = new System.Drawing.Size(75, 96);
            this.pbPlayerCard2.TabIndex = 2;
            this.pbPlayerCard2.TabStop = false;
            // 
            // pbPlayerCard3
            // 
            this.pbPlayerCard3.Location = new System.Drawing.Point(232, 48);
            this.pbPlayerCard3.Name = "pbPlayerCard3";
            this.pbPlayerCard3.Size = new System.Drawing.Size(75, 96);
            this.pbPlayerCard3.TabIndex = 3;
            this.pbPlayerCard3.TabStop = false;
            // 
            // pbPlayerCard4
            // 
            this.pbPlayerCard4.Location = new System.Drawing.Point(326, 48);
            this.pbPlayerCard4.Name = "pbPlayerCard4";
            this.pbPlayerCard4.Size = new System.Drawing.Size(75, 96);
            this.pbPlayerCard4.TabIndex = 4;
            this.pbPlayerCard4.TabStop = false;
            // 
            // pbPlayerCard5
            // 
            this.pbPlayerCard5.Location = new System.Drawing.Point(422, 48);
            this.pbPlayerCard5.Name = "pbPlayerCard5";
            this.pbPlayerCard5.Size = new System.Drawing.Size(75, 96);
            this.pbPlayerCard5.TabIndex = 5;
            this.pbPlayerCard5.TabStop = false;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(240, 195);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(93, 16);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "Players Cards";
            // 
            // pnlDealer
            // 
            this.pnlDealer.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlDealer.Controls.Add(this.lblDealersCards);
            this.pnlDealer.Controls.Add(this.pbDealerCard1);
            this.pnlDealer.Controls.Add(this.pbDealerCard2);
            this.pnlDealer.Controls.Add(this.pbDealerCard3);
            this.pnlDealer.Controls.Add(this.pbDealerCard4);
            this.pnlDealer.Controls.Add(this.pbDealerCard5);
            this.pnlDealer.Controls.Add(this.lblDealer);
            this.pnlDealer.Location = new System.Drawing.Point(303, 270);
            this.pnlDealer.Name = "pnlDealer";
            this.pnlDealer.Size = new System.Drawing.Size(518, 194);
            this.pnlDealer.TabIndex = 6;
            // 
            // lblDealersCards
            // 
            this.lblDealersCards.AutoSize = true;
            this.lblDealersCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealersCards.Location = new System.Drawing.Point(33, 16);
            this.lblDealersCards.Name = "lblDealersCards";
            this.lblDealersCards.Size = new System.Drawing.Size(108, 16);
            this.lblDealersCards.TabIndex = 7;
            this.lblDealersCards.Text = "Dealers Cards";
            // 
            // pbDealerCard1
            // 
            this.pbDealerCard1.Location = new System.Drawing.Point(36, 57);
            this.pbDealerCard1.Name = "pbDealerCard1";
            this.pbDealerCard1.Size = new System.Drawing.Size(75, 96);
            this.pbDealerCard1.TabIndex = 1;
            this.pbDealerCard1.TabStop = false;
            //
            // pbDealerCard2
            // 
            this.pbDealerCard2.Location = new System.Drawing.Point(135, 57);
            this.pbDealerCard2.Name = "pbDealerCard2";
            this.pbDealerCard2.Size = new System.Drawing.Size(75, 96);
            this.pbDealerCard2.TabIndex = 2;
            this.pbDealerCard2.TabStop = false;
            //
            // pbDealerCard3
            // 
            this.pbDealerCard3.Location = new System.Drawing.Point(232, 57);
            this.pbDealerCard3.Name = "pbDealerCard3";
            this.pbDealerCard3.Size = new System.Drawing.Size(75, 96);
            this.pbDealerCard3.TabIndex = 3;
            this.pbDealerCard3.TabStop = false;
            // 
            // pbDealerCard4
            // 
            this.pbDealerCard4.Location = new System.Drawing.Point(326, 57);
            this.pbDealerCard4.Name = "pbDealerCard4";
            this.pbDealerCard4.Size = new System.Drawing.Size(75, 96);
            this.pbDealerCard4.TabIndex = 4;
            this.pbDealerCard4.TabStop = false;
            // 
            // pbDealerCard5
            // 
            this.pbDealerCard5.Location = new System.Drawing.Point(422, 57);
            this.pbDealerCard5.Name = "pbDealerCard5";
            this.pbDealerCard5.Size = new System.Drawing.Size(75, 96);
            this.pbDealerCard5.TabIndex = 5;
            this.pbDealerCard5.TabStop = false;
            // 
            //
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer.Location = new System.Drawing.Point(243, 205);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(95, 16);
            this.lblDealer.TabIndex = 0;
            this.lblDealer.Text = "Dealers Cards";
            // 
            // txtBoxName
            // 
            this.txtBoxName.AcceptsReturn = true;
            this.txtBoxName.Location = new System.Drawing.Point(489, 26);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(164, 20);
            this.txtBoxName.TabIndex = 7;
            
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(336, 30);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(138, 16);
            this.lblPlayerName.TabIndex = 8;
            this.lblPlayerName.Text = "Enter Player Name";
            // 
            // txtMessageBox
            // 
            this.txtMessageBox.Location = new System.Drawing.Point(16, 233);
            this.txtMessageBox.Multiline = true;
            this.txtMessageBox.Name = "txtMessageBox";
            this.txtMessageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageBox.Size = new System.Drawing.Size(263, 231);
            this.txtMessageBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(866, 520);
            this.Controls.Add(this.txtMessageBox);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.pnlDealer);
            this.Controls.Add(this.pnlPlayer);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHitMe);
            this.Controls.Add(this.btnPlay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlPlayer.ResumeLayout(false);
            this.pnlPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerCard5)).EndInit();
            this.pnlDealer.ResumeLayout(false);
            this.pnlDealer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealerCard5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnHitMe;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Panel pnlPlayer;
        private System.Windows.Forms.Panel pnlDealer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblDealer;
        //private System.Windows.Forms.PictureBox[] pbPlayerCard;
        private System.Windows.Forms.PictureBox pbPlayerCard1;
        private System.Windows.Forms.PictureBox pbPlayerCard2;
        private System.Windows.Forms.PictureBox pbPlayerCard3;
        private System.Windows.Forms.PictureBox pbPlayerCard4;
        private System.Windows.Forms.PictureBox pbPlayerCard5;
        private System.Windows.Forms.PictureBox pbDealerCard1;
        private System.Windows.Forms.PictureBox pbDealerCard2;
        private System.Windows.Forms.PictureBox pbDealerCard3;
        private System.Windows.Forms.PictureBox pbDealerCard4;
        private System.Windows.Forms.PictureBox pbDealerCard5;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox txtMessageBox;
        private System.Windows.Forms.Label lblPlayersCards;
        private System.Windows.Forms.Label lblDealersCards;

    }
}

