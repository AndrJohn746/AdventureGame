namespace AdventureGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.heading = new System.Windows.Forms.Label();
            this.releaseVersion = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.backingColor = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.Label();
            this.blueButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.BackColor = System.Drawing.Color.LightCoral;
            this.heading.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.Color.White;
            this.heading.Location = new System.Drawing.Point(-11, 0);
            this.heading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(851, 57);
            this.heading.TabIndex = 0;
            this.heading.Text = "Wario Dating Simulator";
            this.heading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // releaseVersion
            // 
            this.releaseVersion.AutoSize = true;
            this.releaseVersion.BackColor = System.Drawing.Color.LightCoral;
            this.releaseVersion.ForeColor = System.Drawing.Color.White;
            this.releaseVersion.Location = new System.Drawing.Point(560, 40);
            this.releaseVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.releaseVersion.Name = "releaseVersion";
            this.releaseVersion.Size = new System.Drawing.Size(47, 17);
            this.releaseVersion.TabIndex = 1;
            this.releaseVersion.Text = "v1.0.0";
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.LightPink;
            this.outputLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(333, 72);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(486, 329);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "Welcome to Wario Dating Simulator, currently in build v1.0.0!";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backingColor
            // 
            this.backingColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.backingColor.Location = new System.Drawing.Point(-2, 57);
            this.backingColor.Name = "backingColor";
            this.backingColor.Size = new System.Drawing.Size(839, 363);
            this.backingColor.TabIndex = 7;
            this.backingColor.Text = ".";
            this.backingColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageBox
            // 
            this.imageBox.BackColor = System.Drawing.Color.White;
            this.imageBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageBox.Image = global::AdventureGame.Properties.Resources.scene_0;
            this.imageBox.Location = new System.Drawing.Point(13, 72);
            this.imageBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(300, 329);
            this.imageBox.TabIndex = 2;
            this.imageBox.Text = ".";
            // 
            // blueButton
            // 
            this.blueButton.FlatAppearance.BorderSize = 0;
            this.blueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueButton.Image = ((System.Drawing.Image)(resources.GetObject("blueButton.Image")));
            this.blueButton.Location = new System.Drawing.Point(13, 424);
            this.blueButton.Margin = new System.Windows.Forms.Padding(4);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(155, 155);
            this.blueButton.TabIndex = 6;
            this.blueButton.Text = "Play Game";
            this.blueButton.UseVisualStyleBackColor = true;
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Transparent;
            this.yellowButton.FlatAppearance.BorderSize = 0;
            this.yellowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowButton.Image = global::AdventureGame.Properties.Resources.yellow;
            this.yellowButton.Location = new System.Drawing.Point(339, 424);
            this.yellowButton.Margin = new System.Windows.Forms.Padding(4);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(155, 155);
            this.yellowButton.TabIndex = 5;
            this.yellowButton.Text = ".";
            this.yellowButton.UseVisualStyleBackColor = false;
            // 
            // redButton
            // 
            this.redButton.FlatAppearance.BorderSize = 0;
            this.redButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redButton.Image = ((System.Drawing.Image)(resources.GetObject("redButton.Image")));
            this.redButton.Location = new System.Drawing.Point(663, 424);
            this.redButton.Margin = new System.Windows.Forms.Padding(4);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(155, 155);
            this.redButton.TabIndex = 1;
            this.redButton.Text = "Exit Game";
            this.redButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(832, 582);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.backingColor);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.releaseVersion);
            this.Controls.Add(this.heading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Wario Dating Simulator - Beta Release v1.0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label releaseVersion;
        private System.Windows.Forms.Label imageBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Label backingColor;
    }
}

