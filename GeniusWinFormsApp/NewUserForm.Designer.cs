namespace GeniusWinFormsApp
{
    partial class newUserForm
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
            newUserLabel = new Label();
            newUserNameTextBox = new TextBox();
            startGameButton = new Button();
            SuspendLayout();
            // 
            // newUserLabel
            // 
            newUserLabel.AutoSize = true;
            newUserLabel.Location = new Point(34, 26);
            newUserLabel.Name = "newUserLabel";
            newUserLabel.Size = new Size(57, 15);
            newUserLabel.TabIndex = 0;
            newUserLabel.Text = "Твое имя";
            // 
            // newUserNameTextBox
            // 
            newUserNameTextBox.Location = new Point(34, 60);
            newUserNameTextBox.Name = "newUserNameTextBox";
            newUserNameTextBox.Size = new Size(100, 23);
            newUserNameTextBox.TabIndex = 1;
            // 
            // startGameButton
            // 
            startGameButton.Location = new Point(34, 103);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(75, 23);
            startGameButton.TabIndex = 2;
            startGameButton.Text = "Начать";
            startGameButton.UseVisualStyleBackColor = true;
            startGameButton.Click += startGameButton_Click;
            // 
            // newUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(171, 147);
            Controls.Add(startGameButton);
            Controls.Add(newUserNameTextBox);
            Controls.Add(newUserLabel);
            Name = "newUserForm";
            Text = "Новый пользователь";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label newUserLabel;
        public TextBox newUserNameTextBox;
        private Button startGameButton;
    }
}