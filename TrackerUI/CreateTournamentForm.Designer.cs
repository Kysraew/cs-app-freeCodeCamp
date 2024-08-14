namespace TrackerUI
{
    partial class CreateTournamentForm
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
            headerLabel = new Label();
            tournamentNameTextBox = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeTextBox = new TextBox();
            entryFeeLabel = new Label();
            selectTeamLabel = new Label();
            teamsDropDown = new ComboBox();
            createTeamButton = new Button();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            createTournamentButton = new Button();
            teamsPlayersLabel = new Label();
            tournamentPlayersListBox = new ListBox();
            deletePlayersButton = new Button();
            deletePrizessButton = new Button();
            prizesListBox = new ListBox();
            teamsPrizesLabel = new Label();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            headerLabel.Location = new Point(33, 9);
            headerLabel.Margin = new Padding(2, 0, 2, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(325, 47);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Create Tournament";
            headerLabel.Click += headerLabel_Click;
            // 
            // tournamentNameTextBox
            // 
            tournamentNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameTextBox.Location = new Point(73, 111);
            tournamentNameTextBox.Margin = new Padding(2);
            tournamentNameTextBox.Name = "tournamentNameTextBox";
            tournamentNameTextBox.Size = new Size(194, 29);
            tournamentNameTextBox.TabIndex = 10;
            tournamentNameTextBox.TextChanged += teamOneScoreValue_TextChanged;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.Location = new Point(73, 84);
            tournamentNameLabel.Margin = new Padding(2, 0, 2, 0);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(169, 25);
            tournamentNameLabel.TabIndex = 9;
            tournamentNameLabel.Text = "Tournament name:";
            tournamentNameLabel.Click += teamOneScoreLabel_Click;
            // 
            // entryFeeTextBox
            // 
            entryFeeTextBox.BorderStyle = BorderStyle.FixedSingle;
            entryFeeTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeTextBox.Location = new Point(181, 183);
            entryFeeTextBox.Margin = new Padding(2);
            entryFeeTextBox.Name = "entryFeeTextBox";
            entryFeeTextBox.Size = new Size(86, 29);
            entryFeeTextBox.TabIndex = 12;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeLabel.Location = new Point(73, 183);
            entryFeeLabel.Margin = new Padding(2, 0, 2, 0);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(90, 25);
            entryFeeLabel.TabIndex = 11;
            entryFeeLabel.Text = "Entry fee:";
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.Location = new Point(73, 250);
            selectTeamLabel.Margin = new Padding(2, 0, 2, 0);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(113, 25);
            selectTeamLabel.TabIndex = 13;
            selectTeamLabel.Text = "Select team:";
            // 
            // teamsDropDown
            // 
            teamsDropDown.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamsDropDown.FormattingEnabled = true;
            teamsDropDown.Location = new Point(73, 282);
            teamsDropDown.Margin = new Padding(2);
            teamsDropDown.Name = "teamsDropDown";
            teamsDropDown.Size = new Size(194, 33);
            teamsDropDown.TabIndex = 14;
            // 
            // createTeamButton
            // 
            createTeamButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createTeamButton.Location = new Point(235, 250);
            createTeamButton.Margin = new Padding(2);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(32, 28);
            createTeamButton.TabIndex = 15;
            createTeamButton.Text = "+";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // addTeamButton
            // 
            addTeamButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            addTeamButton.Location = new Point(99, 319);
            addTeamButton.Margin = new Padding(2);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(145, 35);
            addTeamButton.TabIndex = 16;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            createPrizeButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            createPrizeButton.Location = new Point(97, 399);
            createPrizeButton.Margin = new Padding(2);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(145, 35);
            createPrizeButton.TabIndex = 17;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            createTournamentButton.Location = new Point(257, 501);
            createTournamentButton.Margin = new Padding(2);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(265, 49);
            createTournamentButton.TabIndex = 18;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // teamsPlayersLabel
            // 
            teamsPlayersLabel.AutoSize = true;
            teamsPlayersLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            teamsPlayersLabel.Location = new Point(401, 84);
            teamsPlayersLabel.Margin = new Padding(2, 0, 2, 0);
            teamsPlayersLabel.Name = "teamsPlayersLabel";
            teamsPlayersLabel.Size = new Size(131, 25);
            teamsPlayersLabel.TabIndex = 19;
            teamsPlayersLabel.Text = "Teams/Players";
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 25;
            tournamentPlayersListBox.Location = new Point(401, 111);
            tournamentPlayersListBox.Margin = new Padding(2);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(258, 154);
            tournamentPlayersListBox.TabIndex = 20;
            // 
            // deletePlayersButton
            // 
            deletePlayersButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            deletePlayersButton.Location = new Point(672, 111);
            deletePlayersButton.Margin = new Padding(2);
            deletePlayersButton.Name = "deletePlayersButton";
            deletePlayersButton.Size = new Size(101, 68);
            deletePlayersButton.TabIndex = 21;
            deletePlayersButton.Text = "Delete Selected";
            deletePlayersButton.UseVisualStyleBackColor = true;
            deletePlayersButton.Click += button1_Click;
            // 
            // deletePrizessButton
            // 
            deletePrizessButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            deletePrizessButton.Location = new Point(672, 315);
            deletePrizessButton.Margin = new Padding(2);
            deletePrizessButton.Name = "deletePrizessButton";
            deletePrizessButton.Size = new Size(101, 68);
            deletePrizessButton.TabIndex = 24;
            deletePrizessButton.Text = "Delete Selected";
            deletePrizessButton.UseVisualStyleBackColor = true;
            // 
            // prizesListBox
            // 
            prizesListBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 25;
            prizesListBox.Location = new Point(401, 315);
            prizesListBox.Margin = new Padding(2);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(258, 154);
            prizesListBox.TabIndex = 23;
            // 
            // teamsPrizesLabel
            // 
            teamsPrizesLabel.AutoSize = true;
            teamsPrizesLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            teamsPrizesLabel.Location = new Point(401, 288);
            teamsPrizesLabel.Margin = new Padding(2, 0, 2, 0);
            teamsPrizesLabel.Name = "teamsPrizesLabel";
            teamsPrizesLabel.Size = new Size(121, 25);
            teamsPrizesLabel.TabIndex = 22;
            teamsPrizesLabel.Text = "Teams/Prizes";
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(deletePrizessButton);
            Controls.Add(prizesListBox);
            Controls.Add(teamsPrizesLabel);
            Controls.Add(deletePlayersButton);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(teamsPlayersLabel);
            Controls.Add(createTournamentButton);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createTeamButton);
            Controls.Add(teamsDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeTextBox);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameTextBox);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Name = "CreateTournamentForm";
            Text = "CreateTournament";
            Load += CreateTournament_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox tournamentNameTextBox;
        private Label tournamentNameLabel;
        private TextBox entryFeeTextBox;
        private Label entryFeeLabel;
        private Label selectTeamLabel;
        private ComboBox teamsDropDown;
        private Button createTeamButton;
        private Button addTeamButton;
        private Button createPrizeButton;
        private Button createTournamentButton;
        private Label teamsPlayersLabel;
        private ListBox tournamentPlayersListBox;
        private Button deletePlayersButton;
        private Button deletePrizessButton;
        private ListBox prizesListBox;
        private Label teamsPrizesLabel;
    }
}