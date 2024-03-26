namespace PirateGame
{
    partial class pirateVoyage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pirateVoyage));
            this.titleLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.option1 = new System.Windows.Forms.Button();
            this.option2 = new System.Windows.Forms.Button();
            this.option3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(33, 9);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(221, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Pirate Voyage";
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 46);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(251, 296);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startButton.BackgroundImage")));
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.ForeColor = System.Drawing.Color.Black;
            this.startButton.Location = new System.Drawing.Point(392, 146);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(161, 55);
            this.startButton.TabIndex = 2;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.outputLabel.Location = new System.Drawing.Point(282, 46);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(410, 155);
            this.outputLabel.TabIndex = 3;
            // 
            // option1
            // 
            this.option1.BackColor = System.Drawing.Color.Black;
            this.option1.ForeColor = System.Drawing.Color.Turquoise;
            this.option1.Location = new System.Drawing.Point(363, 220);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(209, 23);
            this.option1.TabIndex = 4;
            this.option1.Text = "..";
            this.option1.UseVisualStyleBackColor = false;
            this.option1.Click += new System.EventHandler(this.option1_Click);
            // 
            // option2
            // 
            this.option2.BackColor = System.Drawing.Color.Black;
            this.option2.ForeColor = System.Drawing.Color.Turquoise;
            this.option2.Location = new System.Drawing.Point(363, 259);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(209, 23);
            this.option2.TabIndex = 5;
            this.option2.Text = "..";
            this.option2.UseVisualStyleBackColor = false;
            this.option2.Click += new System.EventHandler(this.option2_Click);
            // 
            // option3
            // 
            this.option3.BackColor = System.Drawing.Color.Black;
            this.option3.ForeColor = System.Drawing.Color.Turquoise;
            this.option3.Location = new System.Drawing.Point(363, 299);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(209, 23);
            this.option3.TabIndex = 6;
            this.option3.Text = "..";
            this.option3.UseVisualStyleBackColor = false;
            this.option3.Click += new System.EventHandler(this.option3_Click);
            // 
            // pirateVoyage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(704, 354);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.outputLabel);
            this.Font = new System.Drawing.Font("NSimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "pirateVoyage";
            this.Text = "Pirate Voyage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button option1;
        private System.Windows.Forms.Button option2;
        private System.Windows.Forms.Button option3;
    }
}

