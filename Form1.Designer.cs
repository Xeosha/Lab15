namespace Lab15
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
            label1 = new Label();
            groupBoxCreateTeam = new GroupBox();
            CountSoldiersLabel = new Label();
            CreateTeamLabel = new Label();
            CreateTeamButton = new Button();
            CountSoldiersText = new TextBox();
            NameTeamText = new TextBox();
            ThreadPriorityGroupBox = new GroupBox();
            SavePriorityThreadButton = new Button();
            ChoosePriorityThreadLabel = new Label();
            ChooseThreadLabel = new Label();
            PriorityThreadComboBox = new ComboBox();
            ThreadComboBox = new ComboBox();
            CreateThreadGroupBox = new GroupBox();
            TeamDefendComboxBox = new ComboBox();
            TeamAttackComboBox = new ComboBox();
            CreateThreadButton = new Button();
            ChooseTeam2Label = new Label();
            ChooseTeam1Label = new Label();
            StartButton = new Button();
            ResultListBox = new ListBox();
            ResultLabel = new Label();
            ResultGroupBox = new GroupBox();
            ResultLabel2 = new Label();
            ResultListBox2 = new ListBox();
            groupBoxCreateTeam.SuspendLayout();
            ThreadPriorityGroupBox.SuspendLayout();
            CreateThreadGroupBox.SuspendLayout();
            ResultGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 131);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // groupBoxCreateTeam
            // 
            groupBoxCreateTeam.Controls.Add(CountSoldiersLabel);
            groupBoxCreateTeam.Controls.Add(CreateTeamLabel);
            groupBoxCreateTeam.Controls.Add(CreateTeamButton);
            groupBoxCreateTeam.Controls.Add(CountSoldiersText);
            groupBoxCreateTeam.Controls.Add(NameTeamText);
            groupBoxCreateTeam.Location = new Point(28, 37);
            groupBoxCreateTeam.Name = "groupBoxCreateTeam";
            groupBoxCreateTeam.Size = new Size(550, 100);
            groupBoxCreateTeam.TabIndex = 1;
            groupBoxCreateTeam.TabStop = false;
            groupBoxCreateTeam.Text = "Создание команды";
            // 
            // CountSoldiersLabel
            // 
            CountSoldiersLabel.AutoSize = true;
            CountSoldiersLabel.Location = new Point(158, 26);
            CountSoldiersLabel.Name = "CountSoldiersLabel";
            CountSoldiersLabel.Size = new Size(90, 15);
            CountSoldiersLabel.TabIndex = 4;
            CountSoldiersLabel.Text = "Кол-во бойцов";
            // 
            // CreateTeamLabel
            // 
            CreateTeamLabel.AutoSize = true;
            CreateTeamLabel.Location = new Point(19, 26);
            CreateTeamLabel.Name = "CreateTeamLabel";
            CreateTeamLabel.Size = new Size(112, 15);
            CreateTeamLabel.TabIndex = 3;
            CreateTeamLabel.Text = "Название команды";
            // 
            // CreateTeamButton
            // 
            CreateTeamButton.Location = new Point(333, 18);
            CreateTeamButton.Name = "CreateTeamButton";
            CreateTeamButton.Size = new Size(187, 72);
            CreateTeamButton.TabIndex = 2;
            CreateTeamButton.Text = "Создать команду";
            CreateTeamButton.UseVisualStyleBackColor = true;
            CreateTeamButton.Click += CreateTeamButton_Click;
            // 
            // CountSoldiersText
            // 
            CountSoldiersText.Location = new Point(158, 44);
            CountSoldiersText.Name = "CountSoldiersText";
            CountSoldiersText.Size = new Size(118, 23);
            CountSoldiersText.TabIndex = 1;
            // 
            // NameTeamText
            // 
            NameTeamText.Location = new Point(19, 44);
            NameTeamText.Name = "NameTeamText";
            NameTeamText.Size = new Size(119, 23);
            NameTeamText.TabIndex = 0;
            // 
            // ThreadPriorityGroupBox
            // 
            ThreadPriorityGroupBox.Controls.Add(SavePriorityThreadButton);
            ThreadPriorityGroupBox.Controls.Add(ChoosePriorityThreadLabel);
            ThreadPriorityGroupBox.Controls.Add(ChooseThreadLabel);
            ThreadPriorityGroupBox.Controls.Add(PriorityThreadComboBox);
            ThreadPriorityGroupBox.Controls.Add(ThreadComboBox);
            ThreadPriorityGroupBox.Location = new Point(28, 280);
            ThreadPriorityGroupBox.Name = "ThreadPriorityGroupBox";
            ThreadPriorityGroupBox.Size = new Size(550, 100);
            ThreadPriorityGroupBox.TabIndex = 2;
            ThreadPriorityGroupBox.TabStop = false;
            ThreadPriorityGroupBox.Text = "Выбор приоритета потока";
            // 
            // SavePriorityThreadButton
            // 
            SavePriorityThreadButton.Location = new Point(333, 22);
            SavePriorityThreadButton.Name = "SavePriorityThreadButton";
            SavePriorityThreadButton.Size = new Size(187, 57);
            SavePriorityThreadButton.TabIndex = 4;
            SavePriorityThreadButton.Text = "Сохранить";
            SavePriorityThreadButton.UseVisualStyleBackColor = true;
            SavePriorityThreadButton.Click += SavePriorityThreadButton_Click;
            // 
            // ChoosePriorityThreadLabel
            // 
            ChoosePriorityThreadLabel.AutoSize = true;
            ChoosePriorityThreadLabel.Location = new Point(158, 29);
            ChoosePriorityThreadLabel.Name = "ChoosePriorityThreadLabel";
            ChoosePriorityThreadLabel.Size = new Size(122, 15);
            ChoosePriorityThreadLabel.TabIndex = 3;
            ChoosePriorityThreadLabel.Text = "Выберите приоритет";
            // 
            // ChooseThreadLabel
            // 
            ChooseThreadLabel.AutoSize = true;
            ChooseThreadLabel.Location = new Point(19, 29);
            ChooseThreadLabel.Name = "ChooseThreadLabel";
            ChooseThreadLabel.Size = new Size(96, 15);
            ChooseThreadLabel.TabIndex = 2;
            ChooseThreadLabel.Text = "Выберите поток";
            // 
            // PriorityThreadComboBox
            // 
            PriorityThreadComboBox.FormattingEnabled = true;
            PriorityThreadComboBox.Location = new Point(158, 47);
            PriorityThreadComboBox.Name = "PriorityThreadComboBox";
            PriorityThreadComboBox.Size = new Size(121, 23);
            PriorityThreadComboBox.TabIndex = 1;
            // 
            // ThreadComboBox
            // 
            ThreadComboBox.FormattingEnabled = true;
            ThreadComboBox.Location = new Point(19, 47);
            ThreadComboBox.Name = "ThreadComboBox";
            ThreadComboBox.Size = new Size(121, 23);
            ThreadComboBox.TabIndex = 0;
            // 
            // CreateThreadGroupBox
            // 
            CreateThreadGroupBox.Controls.Add(TeamDefendComboxBox);
            CreateThreadGroupBox.Controls.Add(TeamAttackComboBox);
            CreateThreadGroupBox.Controls.Add(CreateThreadButton);
            CreateThreadGroupBox.Controls.Add(ChooseTeam2Label);
            CreateThreadGroupBox.Controls.Add(ChooseTeam1Label);
            CreateThreadGroupBox.Location = new Point(28, 149);
            CreateThreadGroupBox.Name = "CreateThreadGroupBox";
            CreateThreadGroupBox.Size = new Size(550, 109);
            CreateThreadGroupBox.TabIndex = 3;
            CreateThreadGroupBox.TabStop = false;
            CreateThreadGroupBox.Text = "Создание потока для сражения выбранных команд";
            // 
            // TeamDefendComboxBox
            // 
            TeamDefendComboxBox.FormattingEnabled = true;
            TeamDefendComboxBox.Location = new Point(159, 59);
            TeamDefendComboxBox.Name = "TeamDefendComboxBox";
            TeamDefendComboxBox.Size = new Size(121, 23);
            TeamDefendComboxBox.TabIndex = 4;
            // 
            // TeamAttackComboBox
            // 
            TeamAttackComboBox.FormattingEnabled = true;
            TeamAttackComboBox.Location = new Point(19, 59);
            TeamAttackComboBox.Name = "TeamAttackComboBox";
            TeamAttackComboBox.Size = new Size(121, 23);
            TeamAttackComboBox.TabIndex = 3;
            // 
            // CreateThreadButton
            // 
            CreateThreadButton.Location = new Point(333, 22);
            CreateThreadButton.Name = "CreateThreadButton";
            CreateThreadButton.Size = new Size(187, 71);
            CreateThreadButton.TabIndex = 2;
            CreateThreadButton.Text = "Создать поток";
            CreateThreadButton.UseVisualStyleBackColor = true;
            CreateThreadButton.Click += CreateThreadButton_Click;
            // 
            // ChooseTeam2Label
            // 
            ChooseTeam2Label.AutoSize = true;
            ChooseTeam2Label.Location = new Point(158, 29);
            ChooseTeam2Label.Name = "ChooseTeam2Label";
            ChooseTeam2Label.Size = new Size(98, 15);
            ChooseTeam2Label.TabIndex = 1;
            ChooseTeam2Label.Text = "Кто защищается";
            // 
            // ChooseTeam1Label
            // 
            ChooseTeam1Label.AutoSize = true;
            ChooseTeam1Label.Location = new Point(19, 32);
            ChooseTeam1Label.Name = "ChooseTeam1Label";
            ChooseTeam1Label.Size = new Size(78, 15);
            ChooseTeam1Label.TabIndex = 0;
            ChooseTeam1Label.Text = "Кто нападает";
            // 
            // StartButton
            // 
            StartButton.Location = new Point(183, 22);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(183, 55);
            StartButton.TabIndex = 4;
            StartButton.Text = "Запустить";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // ResultListBox
            // 
            ResultListBox.FormattingEnabled = true;
            ResultListBox.ItemHeight = 15;
            ResultListBox.Location = new Point(19, 98);
            ResultListBox.Name = "ResultListBox";
            ResultListBox.Size = new Size(522, 94);
            ResultListBox.TabIndex = 5;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(19, 80);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(95, 15);
            ResultLabel.TabIndex = 6;
            ResultLabel.Text = "Что происходит";
            // 
            // ResultGroupBox
            // 
            ResultGroupBox.Controls.Add(ResultLabel2);
            ResultGroupBox.Controls.Add(ResultListBox2);
            ResultGroupBox.Controls.Add(ResultListBox);
            ResultGroupBox.Controls.Add(ResultLabel);
            ResultGroupBox.Controls.Add(StartButton);
            ResultGroupBox.Location = new Point(19, 398);
            ResultGroupBox.Name = "ResultGroupBox";
            ResultGroupBox.Size = new Size(559, 332);
            ResultGroupBox.TabIndex = 7;
            ResultGroupBox.TabStop = false;
            ResultGroupBox.Text = "Визуал";
            // 
            // ResultLabel2
            // 
            ResultLabel2.AutoSize = true;
            ResultLabel2.Location = new Point(19, 195);
            ResultLabel2.Name = "ResultLabel2";
            ResultLabel2.Size = new Size(169, 15);
            ResultLabel2.TabIndex = 8;
            ResultLabel2.Text = "Количество бойцов у команд";
            // 
            // ResultListBox2
            // 
            ResultListBox2.FormattingEnabled = true;
            ResultListBox2.ItemHeight = 15;
            ResultListBox2.Location = new Point(19, 217);
            ResultListBox2.Name = "ResultListBox2";
            ResultListBox2.Size = new Size(522, 94);
            ResultListBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 742);
            Controls.Add(ResultGroupBox);
            Controls.Add(CreateThreadGroupBox);
            Controls.Add(ThreadPriorityGroupBox);
            Controls.Add(groupBoxCreateTeam);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBoxCreateTeam.ResumeLayout(false);
            groupBoxCreateTeam.PerformLayout();
            ThreadPriorityGroupBox.ResumeLayout(false);
            ThreadPriorityGroupBox.PerformLayout();
            CreateThreadGroupBox.ResumeLayout(false);
            CreateThreadGroupBox.PerformLayout();
            ResultGroupBox.ResumeLayout(false);
            ResultGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBoxCreateTeam;
        private Button CreateTeamButton;
        private TextBox CountSoldiersText;
        private TextBox NameTeamText;
        private Label CountSoldiersLabel;
        private Label CreateTeamLabel;
        private GroupBox ThreadPriorityGroupBox;
        private GroupBox CreateThreadGroupBox;
        private Button CreateThreadButton;
        private Label ChooseTeam2Label;
        private Label ChooseTeam1Label;
        private Label ChoosePriorityThreadLabel;
        private Label ChooseThreadLabel;
        private ComboBox PriorityThreadComboBox;
        private ComboBox ThreadComboBox;
        private Button SavePriorityThreadButton;
        private Button StartButton;
        private ListBox ResultListBox;
        private Label ResultLabel;
        private ComboBox TeamDefendComboxBox;
        private ComboBox TeamAttackComboBox;
        private GroupBox ResultGroupBox;
        private Label ResultLabel2;
        private ListBox ResultListBox2;
    }
}