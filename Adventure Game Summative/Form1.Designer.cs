namespace Adventure_Game_Summative
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.firstButtonLabel = new System.Windows.Forms.Label();
            this.middlePictureBox = new System.Windows.Forms.PictureBox();
            this.redButtonPicture = new System.Windows.Forms.PictureBox();
            this.blueButtonPicture = new System.Windows.Forms.PictureBox();
            this.firstChoiceLabel = new System.Windows.Forms.Label();
            this.yellowButtonPicture = new System.Windows.Forms.PictureBox();
            this.secondChoiceLabel = new System.Windows.Forms.Label();
            this.thirdChoiceLabel = new System.Windows.Forms.Label();
            this.beginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.middlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redButtonPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueButtonPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowButtonPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(13, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(344, 73);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Welcome adventurer, what is your name? ";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(297, 14);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(60, 20);
            this.nameInput.TabIndex = 1;
            // 
            // firstButtonLabel
            // 
            this.firstButtonLabel.AutoSize = true;
            this.firstButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstButtonLabel.ForeColor = System.Drawing.Color.White;
            this.firstButtonLabel.Location = new System.Drawing.Point(13, 90);
            this.firstButtonLabel.Name = "firstButtonLabel";
            this.firstButtonLabel.Size = new System.Drawing.Size(170, 18);
            this.firstButtonLabel.TabIndex = 2;
            this.firstButtonLabel.Text = "Click the button to begin.";
            // 
            // middlePictureBox
            // 
            this.middlePictureBox.Location = new System.Drawing.Point(16, 127);
            this.middlePictureBox.Name = "middlePictureBox";
            this.middlePictureBox.Size = new System.Drawing.Size(341, 122);
            this.middlePictureBox.TabIndex = 4;
            this.middlePictureBox.TabStop = false;
            // 
            // redButtonPicture
            // 
            this.redButtonPicture.BackColor = System.Drawing.Color.Red;
            this.redButtonPicture.Location = new System.Drawing.Point(16, 255);
            this.redButtonPicture.Name = "redButtonPicture";
            this.redButtonPicture.Size = new System.Drawing.Size(59, 44);
            this.redButtonPicture.TabIndex = 5;
            this.redButtonPicture.TabStop = false;
            // 
            // blueButtonPicture
            // 
            this.blueButtonPicture.BackColor = System.Drawing.Color.Blue;
            this.blueButtonPicture.Location = new System.Drawing.Point(16, 305);
            this.blueButtonPicture.Name = "blueButtonPicture";
            this.blueButtonPicture.Size = new System.Drawing.Size(59, 42);
            this.blueButtonPicture.TabIndex = 6;
            this.blueButtonPicture.TabStop = false;
            // 
            // firstChoiceLabel
            // 
            this.firstChoiceLabel.ForeColor = System.Drawing.Color.White;
            this.firstChoiceLabel.Location = new System.Drawing.Point(82, 255);
            this.firstChoiceLabel.Name = "firstChoiceLabel";
            this.firstChoiceLabel.Size = new System.Drawing.Size(275, 44);
            this.firstChoiceLabel.TabIndex = 7;
            // 
            // yellowButtonPicture
            // 
            this.yellowButtonPicture.BackColor = System.Drawing.Color.Yellow;
            this.yellowButtonPicture.Location = new System.Drawing.Point(16, 353);
            this.yellowButtonPicture.Name = "yellowButtonPicture";
            this.yellowButtonPicture.Size = new System.Drawing.Size(59, 42);
            this.yellowButtonPicture.TabIndex = 8;
            this.yellowButtonPicture.TabStop = false;
            // 
            // secondChoiceLabel
            // 
            this.secondChoiceLabel.ForeColor = System.Drawing.Color.White;
            this.secondChoiceLabel.Location = new System.Drawing.Point(82, 303);
            this.secondChoiceLabel.Name = "secondChoiceLabel";
            this.secondChoiceLabel.Size = new System.Drawing.Size(275, 44);
            this.secondChoiceLabel.TabIndex = 9;
            // 
            // thirdChoiceLabel
            // 
            this.thirdChoiceLabel.ForeColor = System.Drawing.Color.White;
            this.thirdChoiceLabel.Location = new System.Drawing.Point(82, 351);
            this.thirdChoiceLabel.Name = "thirdChoiceLabel";
            this.thirdChoiceLabel.Size = new System.Drawing.Size(275, 44);
            this.thirdChoiceLabel.TabIndex = 10;
            // 
            // beginButton
            // 
            this.beginButton.Location = new System.Drawing.Point(297, 90);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(59, 23);
            this.beginButton.TabIndex = 11;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(369, 417);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.thirdChoiceLabel);
            this.Controls.Add(this.secondChoiceLabel);
            this.Controls.Add(this.yellowButtonPicture);
            this.Controls.Add(this.firstChoiceLabel);
            this.Controls.Add(this.blueButtonPicture);
            this.Controls.Add(this.redButtonPicture);
            this.Controls.Add(this.middlePictureBox);
            this.Controls.Add(this.firstButtonLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.middlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redButtonPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueButtonPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowButtonPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label firstButtonLabel;
        private System.Windows.Forms.PictureBox middlePictureBox;
        private System.Windows.Forms.PictureBox redButtonPicture;
        private System.Windows.Forms.PictureBox blueButtonPicture;
        private System.Windows.Forms.Label firstChoiceLabel;
        private System.Windows.Forms.PictureBox yellowButtonPicture;
        private System.Windows.Forms.Label secondChoiceLabel;
        private System.Windows.Forms.Label thirdChoiceLabel;
        private System.Windows.Forms.Button beginButton;
    }
}

