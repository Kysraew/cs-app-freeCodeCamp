namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label headerLabel;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckBox;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private Label teamTwoName;
        private Label teamTwoScoreLabel;
        private TextBox teamTwoScoreValue;
        private Button submitButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            headerLabel = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckBox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneName = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoName = new Label();
            teamTwoScoreLabel = new Label();
            teamTwoScoreValue = new TextBox();
            submitButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            headerLabel.Location = new Point(38, 24);
            headerLabel.Margin = new Padding(2, 0, 2, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(219, 47);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            headerLabel.Click += headerLabel_Click;
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentName.Location = new Point(261, 24);
            tournamentName.Margin = new Padding(2, 0, 2, 0);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(77, 47);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "test";
            tournamentName.Click += tournamentName_Click;
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            roundLabel.Location = new Point(38, 112);
            roundLabel.Margin = new Padding(2, 0, 2, 0);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(94, 37);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            roundLabel.Click += roundLabel_Click;
            // 
            // roundDropDown
            // 
            roundDropDown.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(148, 117);
            roundDropDown.Margin = new Padding(2);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(152, 33);
            roundDropDown.TabIndex = 3;
            roundDropDown.SelectedIndexChanged += roundDropDown_SelectedIndexChanged;
            // 
            // unplayedOnlyCheckBox
            // 
            unplayedOnlyCheckBox.AutoSize = true;
            unplayedOnlyCheckBox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCheckBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            unplayedOnlyCheckBox.Location = new Point(148, 167);
            unplayedOnlyCheckBox.Margin = new Padding(2);
            unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            unplayedOnlyCheckBox.Size = new Size(152, 29);
            unplayedOnlyCheckBox.TabIndex = 4;
            unplayedOnlyCheckBox.Text = "Unplayed Only";
            unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            unplayedOnlyCheckBox.CheckedChanged += unplayedOnlyCheckBox_CheckedChanged;
            // 
            // matchupListBox
            // 
            matchupListBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 25;
            matchupListBox.Location = new Point(38, 237);
            matchupListBox.Margin = new Padding(2);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(262, 229);
            matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneName.Location = new Point(411, 237);
            teamOneName.Margin = new Padding(2, 0, 2, 0);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(165, 37);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneScoreLabel.Location = new Point(411, 285);
            teamOneScoreLabel.Margin = new Padding(2, 0, 2, 0);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(63, 25);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Text = "Score:";
            teamOneScoreLabel.Click += teamOneScoreLabel_Click;
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.BorderStyle = BorderStyle.FixedSingle;
            teamOneScoreValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneScoreValue.Location = new Point(488, 285);
            teamOneScoreValue.Margin = new Padding(2);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(88, 29);
            teamOneScoreValue.TabIndex = 8;
            teamOneScoreValue.TextChanged += teamOneScoreValue_TextChanged;
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoName.Location = new Point(411, 383);
            teamTwoName.Margin = new Padding(2, 0, 2, 0);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(165, 37);
            teamTwoName.TabIndex = 9;
            teamTwoName.Text = "<team two>";
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoScoreLabel.Location = new Point(411, 429);
            teamTwoScoreLabel.Margin = new Padding(2, 0, 2, 0);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(63, 25);
            teamTwoScoreLabel.TabIndex = 10;
            teamTwoScoreLabel.Text = "Score:";
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.BorderStyle = BorderStyle.FixedSingle;
            teamTwoScoreValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoScoreValue.Location = new Point(488, 430);
            teamTwoScoreValue.Margin = new Padding(2);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(88, 29);
            teamTwoScoreValue.TabIndex = 11;
            // 
            // submitButton
            // 
            submitButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            submitButton.Location = new Point(622, 327);
            submitButton.Margin = new Padding(2);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(117, 52);
            submitButton.TabIndex = 12;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(submitButton);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckBox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(headerLabel);
            Margin = new Padding(2);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
