namespace PasswordGeneratorWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            passwordLabel = new Label();
            passwordLength = new Label();
            passwordLengthSlider = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)passwordLengthSlider).BeginInit();
            SuspendLayout();
            // 
            // passwordLabel
            // 
            passwordLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(191, 46);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(482, 54);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "label1";
            // 
            // passwordLength
            // 
            passwordLength.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLength.Location = new Point(335, 173);
            passwordLength.Name = "passwordLength";
            passwordLength.Size = new Size(338, 66);
            passwordLength.TabIndex = 1;
            passwordLength.Text = "Password Length : 5";
            // 
            // passwordLengthSlider
            // 
            passwordLengthSlider.Location = new Point(225, 259);
            passwordLengthSlider.Name = "passwordLengthSlider";
            passwordLengthSlider.Size = new Size(448, 45);
            passwordLengthSlider.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 473);
            Controls.Add(passwordLengthSlider);
            Controls.Add(passwordLength);
            Controls.Add(passwordLabel);
            Name = "Form1";
            Text = "PasswordGenerator";
            ((System.ComponentModel.ISupportInitialize)passwordLengthSlider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label passwordLabel;
        private Label passwordLength;
        private TrackBar passwordLengthSlider;
    }
}