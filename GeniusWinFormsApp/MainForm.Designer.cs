namespace GeniusWinFormsApp
{
    partial class mainForm
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
            userAnswerTextBox = new TextBox();
            NextButton = new Button();
            menuStrip1 = new MenuStrip();
            менюшечкаToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            показатьРезыToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // QuestionNumberLabel
            // 
            QuestionNumberLabel.AutoSize = true;
            QuestionNumberLabel.Location = new Point(12, 40);
            QuestionNumberLabel.Name = "QuestionNumberLabel";
            QuestionNumberLabel.Size = new Size(64, 15);
            QuestionNumberLabel.TabIndex = 0;
            QuestionNumberLabel.Text = "Вопрос №";
            // 
            // QuestionTextLabel
            // 
            QuestionTextLabel.AutoEllipsis = true;
            QuestionTextLabel.Location = new Point(12, 70);
            QuestionTextLabel.Name = "QuestionTextLabel";
            QuestionTextLabel.Size = new Size(171, 163);
            QuestionTextLabel.TabIndex = 1;
            QuestionTextLabel.Text = "Текст вопроса";
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Location = new Point(12, 236);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(100, 23);
            userAnswerTextBox.TabIndex = 2;
            userAnswerTextBox.Text = "Ответ";
            // 
            // NextButton
            // 
            NextButton.Location = new Point(12, 279);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(100, 23);
            NextButton.TabIndex = 3;
            NextButton.Text = "Следующий";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюшечкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(208, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюшечкаToolStripMenuItem
            // 
            менюшечкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, показатьРезыToolStripMenuItem, выходToolStripMenuItem });
            менюшечкаToolStripMenuItem.Name = "менюшечкаToolStripMenuItem";
            менюшечкаToolStripMenuItem.Size = new Size(87, 20);
            менюшечкаToolStripMenuItem.Text = "менюшечка";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "новая игра";
            // 
            // показатьРезыToolStripMenuItem
            // 
            показатьРезыToolStripMenuItem.Name = "показатьРезыToolStripMenuItem";
            показатьРезыToolStripMenuItem.Size = new Size(180, 22);
            показатьРезыToolStripMenuItem.Text = "показать резы";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(180, 22);
            выходToolStripMenuItem.Text = "выход";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(208, 326);
            Controls.Add(NextButton);
            Controls.Add(userAnswerTextBox);
            Controls.Add(QuestionTextLabel);
            Controls.Add(QuestionNumberLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "mainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label QuestionNumberLabel;
        private Label QuestionTextLabel;
        private TextBox userAnswerTextBox;
        private Button NextButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюшечкаToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem показатьРезыToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
    }
}
