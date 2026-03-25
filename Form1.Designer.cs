namespace Player
{
    partial class Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.playerBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playerBox
            // 
            this.playerBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerBox.BackColor = System.Drawing.Color.Transparent;
            this.playerBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playerBox.BackgroundImage")));
            this.playerBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerBox.InitialImage = null;
            this.playerBox.Location = new System.Drawing.Point(375, 375);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(50, 50);
            this.playerBox.TabIndex = 0;
            this.playerBox.TabStop = false;
            this.playerBox.LocationChanged += new System.EventHandler(this.playerBox_KeyDown);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.playerBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Player";
            this.Text = "Player";
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playerBox;
    }
}

