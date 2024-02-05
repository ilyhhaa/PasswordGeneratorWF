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
            passwordLength_Label = new Label();
            passwordLengthSlider = new TrackBar();
            copyPasswordButton = new Button();
            ((System.ComponentModel.ISupportInitialize)passwordLengthSlider).BeginInit();
            SuspendLayout();
            // 
            // passwordLabel
            // 
            passwordLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(225, 53);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(482, 54);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "label1";
            // 
            // passwordLength_Label
            // 
            passwordLength_Label.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLength_Label.Location = new Point(335, 173);
            passwordLength_Label.Name = "passwordLength_Label";
            passwordLength_Label.Size = new Size(338, 66);
            passwordLength_Label.TabIndex = 1;
            passwordLength_Label.Text = "Password Length : 5";
            passwordLength_Label.Click += passwordLength_Click;
            // 
            // passwordLengthSlider
            // 
            passwordLengthSlider.Location = new Point(225, 259);
            passwordLengthSlider.Name = "passwordLengthSlider";
            passwordLengthSlider.Size = new Size(448, 45);
            passwordLengthSlider.TabIndex = 2;
            passwordLengthSlider.Scroll += passwordLengthSlider_Scroll;
            // 
            // copyPasswordButton
            // 
            copyPasswordButton.Location = new Point(225, 411);
            copyPasswordButton.Name = "copyPasswordButton";
            copyPasswordButton.Size = new Size(448, 34);
            copyPasswordButton.TabIndex = 3;
            copyPasswordButton.Text = "CopyPassword";
            copyPasswordButton.UseVisualStyleBackColor = true;
            copyPasswordButton.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 473);
            Controls.Add(copyPasswordButton);
            Controls.Add(passwordLengthSlider);
            Controls.Add(passwordLength_Label);
            Controls.Add(passwordLabel);
            Name = "Form1";
            Text = "PasswordGenerator";
            ((System.ComponentModel.ISupportInitialize)passwordLengthSlider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label passwordLabel;
        private Label passwordLength_Label;
        private TrackBar passwordLengthSlider;
        private Button copyPasswordButton;
    }
}