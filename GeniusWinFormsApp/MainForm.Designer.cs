namespace GeniusWinFormsApp
{
    partial class MainForm
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
            QuestionNumberLabel = new Label();
            QuestionTextLabel = new Label();
            UserAnswerTextBox = new TextBox();
            NextButton = new Button();
            SuspendLayout();
            // 
            // QuestionNumberLabel
            // 
            QuestionNumberLabel.AutoSize = true;
            QuestionNumberLabel.Location = new Point(58, 17);
            QuestionNumberLabel.Name = "QuestionNumberLabel";
            QuestionNumberLabel.Size = new Size(64, 15);
            QuestionNumberLabel.TabIndex = 0;
            QuestionNumberLabel.Text = "Вопрос №";
            // 
            // QuestionTextLabel
            // 
            QuestionTextLabel.AutoSize = true;
            QuestionTextLabel.Location = new Point(58, 49);
            QuestionTextLabel.Name = "QuestionTextLabel";
            QuestionTextLabel.Size = new Size(85, 15);
            QuestionTextLabel.TabIndex = 1;
            QuestionTextLabel.Text = "Текст вопроса";
            // 
            // UserAnswerTextBox
            // 
            UserAnswerTextBox.Location = new Point(58, 293);
            UserAnswerTextBox.Name = "UserAnswerTextBox";
            UserAnswerTextBox.Size = new Size(100, 23);
            UserAnswerTextBox.TabIndex = 2;
            UserAnswerTextBox.Text = "Ответ";
            // 
            // NextButton
            // 
            NextButton.Location = new Point(58, 336);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(85, 23);
            NextButton.TabIndex = 3;
            NextButton.Text = "Следующий";
            NextButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 450);
            Controls.Add(NextButton);
            Controls.Add(UserAnswerTextBox);
            Controls.Add(QuestionTextLabel);
            Controls.Add(QuestionNumberLabel);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label QuestionNumberLabel;
        private Label QuestionTextLabel;
        private TextBox UserAnswerTextBox;
        private Button NextButton;
    }
}
