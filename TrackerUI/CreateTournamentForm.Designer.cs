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
            teamsLabel = new Label();
            tournamentTeamsListBox = new ListBox();
            deletePlayersButton = new Button();
            deletePrizessButton = new Button();
            prizesListBox = new ListBox();
            PrizesLabel = new Label();
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
            createTeamButton.Click += createTeamButton_Click;
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
            addTeamButton.Click += addTeamButton_Click;
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
            createPrizeButton.Click += createPrizeButton_Click;
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
            // teamsLabel
            // 
            teamsLabel.AutoSize = true;
            teamsLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            teamsLabel.Location = new Point(401, 84);
            teamsLabel.Margin = new Padding(2, 0, 2, 0);
            teamsLabel.Name = "teamsLabel";
            teamsLabel.Size = new Size(64, 25);
            teamsLabel.TabIndex = 19;
            teamsLabel.Text = "Teams";
            // 
            // tournamentTeamsListBox
            // 
            tournamentTeamsListBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentTeamsListBox.FormattingEnabled = true;
            tournamentTeamsListBox.ItemHeight = 25;
            tournamentTeamsListBox.Location = new Point(401, 111);
            tournamentTeamsListBox.Margin = new Padding(2);
            tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            tournamentTeamsListBox.Size = new Size(258, 154);
            tournamentTeamsListBox.TabIndex = 20;
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
            deletePlayersButton.Click += deletePlayersButton_Click;
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
            deletePrizessButton.Click += deletePrizessButton_Click;
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
            // PrizesLabel
            // 
            PrizesLabel.AutoSize = true;
            PrizesLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            PrizesLabel.Location = new Point(401, 288);
            PrizesLabel.Margin = new Padding(2, 0, 2, 0);
            PrizesLabel.Name = "PrizesLabel";
            PrizesLabel.Size = new Size(62, 25);
            PrizesLabel.TabIndex = 22;
            PrizesLabel.Text = "Prizes";
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(deletePrizessButton);
            Controls.Add(prizesListBox);
            Controls.Add(PrizesLabel);
            Controls.Add(deletePlayersButton);
            Controls.Add(tournamentTeamsListBox);
            Controls.Add(teamsLabel);
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
        private Label teamsLabel;
        private ListBox tournamentTeamsListBox;
        private Button deletePlayersButton;
        private Button deletePrizessButton;
        private ListBox prizesListBox;
        private Label PrizesLabel;
    }
}