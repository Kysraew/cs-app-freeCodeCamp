namespace TrackerUI
{
    partial class CreateTeamForm
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
            teamNameTextBox = new TextBox();
            teamNameLabel = new Label();
            selectTeamMemeberLabel = new Label();
            selectTeamMemberDropDown = new ComboBox();
            addPlayerButton = new Button();
            groupBox1 = new GroupBox();
            createPlayerButton = new Button();
            cellphoneNumberTextBox = new TextBox();
            cellphoneNumberLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            teamMemberListBox = new ListBox();
            removeMembersButton = new Button();
            createTeamButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            headerLabel.Location = new Point(24, 9);
            headerLabel.Margin = new Padding(2, 0, 2, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(218, 47);
            headerLabel.TabIndex = 2;
            headerLabel.Text = "Create Team";
            // 
            // teamNameTextBox
            // 
            teamNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            teamNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameTextBox.Location = new Point(62, 94);
            teamNameTextBox.Margin = new Padding(2);
            teamNameTextBox.Name = "teamNameTextBox";
            teamNameTextBox.Size = new Size(194, 29);
            teamNameTextBox.TabIndex = 12;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameLabel.Location = new Point(62, 67);
            teamNameLabel.Margin = new Padding(2, 0, 2, 0);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(112, 25);
            teamNameLabel.TabIndex = 11;
            teamNameLabel.Text = "Team name:";
            // 
            // selectTeamMemeberLabel
            // 
            selectTeamMemeberLabel.AutoSize = true;
            selectTeamMemeberLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemeberLabel.Location = new Point(62, 143);
            selectTeamMemeberLabel.Margin = new Padding(2, 0, 2, 0);
            selectTeamMemeberLabel.Name = "selectTeamMemeberLabel";
            selectTeamMemeberLabel.Size = new Size(198, 25);
            selectTeamMemeberLabel.TabIndex = 13;
            selectTeamMemeberLabel.Text = "Select team memeber:";
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(62, 170);
            selectTeamMemberDropDown.Margin = new Padding(2);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(194, 33);
            selectTeamMemberDropDown.TabIndex = 14;
            // 
            // addPlayerButton
            // 
            addPlayerButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            addPlayerButton.Location = new Point(83, 220);
            addPlayerButton.Margin = new Padding(2);
            addPlayerButton.Name = "addPlayerButton";
            addPlayerButton.Size = new Size(145, 35);
            addPlayerButton.TabIndex = 17;
            addPlayerButton.Text = "Add player";
            addPlayerButton.UseVisualStyleBackColor = true;
            addPlayerButton.Click += addPlayerButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(createPlayerButton);
            groupBox1.Controls.Add(cellphoneNumberTextBox);
            groupBox1.Controls.Add(cellphoneNumberLabel);
            groupBox1.Controls.Add(emailTextBox);
            groupBox1.Controls.Add(emailLabel);
            groupBox1.Controls.Add(lastNameTextBox);
            groupBox1.Controls.Add(lastNameLabel);
            groupBox1.Controls.Add(firstNameTextBox);
            groupBox1.Controls.Add(firstNameLabel);
            groupBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(24, 270);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 279);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add new memeber";
            // 
            // createPlayerButton
            // 
            createPlayerButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            createPlayerButton.Location = new Point(106, 229);
            createPlayerButton.Margin = new Padding(2);
            createPlayerButton.Name = "createPlayerButton";
            createPlayerButton.Size = new Size(145, 35);
            createPlayerButton.TabIndex = 19;
            createPlayerButton.Text = "Create player";
            createPlayerButton.UseVisualStyleBackColor = true;
            createPlayerButton.Click += createPlayerButton_Click;
            // 
            // cellphoneNumberTextBox
            // 
            cellphoneNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            cellphoneNumberTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cellphoneNumberTextBox.Location = new Point(155, 187);
            cellphoneNumberTextBox.Margin = new Padding(2);
            cellphoneNumberTextBox.Name = "cellphoneNumberTextBox";
            cellphoneNumberTextBox.Size = new Size(171, 29);
            cellphoneNumberTextBox.TabIndex = 16;
            // 
            // cellphoneNumberLabel
            // 
            cellphoneNumberLabel.AutoSize = true;
            cellphoneNumberLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cellphoneNumberLabel.Location = new Point(38, 187);
            cellphoneNumberLabel.Margin = new Padding(2, 0, 2, 0);
            cellphoneNumberLabel.Name = "cellphoneNumberLabel";
            cellphoneNumberLabel.Size = new Size(102, 25);
            cellphoneNumberLabel.TabIndex = 15;
            cellphoneNumberLabel.Text = "Cellphone:";
            // 
            // emailTextBox
            // 
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.Location = new Point(155, 138);
            emailTextBox.Margin = new Padding(2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(171, 29);
            emailTextBox.TabIndex = 14;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(38, 138);
            emailLabel.Margin = new Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(62, 25);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            lastNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.Location = new Point(155, 93);
            lastNameTextBox.Margin = new Padding(2);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(171, 29);
            lastNameTextBox.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(38, 93);
            lastNameLabel.Margin = new Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(101, 25);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "Last name:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            firstNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameTextBox.Location = new Point(155, 44);
            firstNameTextBox.Margin = new Padding(2);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(171, 29);
            firstNameTextBox.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.Location = new Point(38, 44);
            firstNameLabel.Margin = new Padding(2, 0, 2, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(103, 25);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First name:";
            // 
            // teamMemberListBox
            // 
            teamMemberListBox.FormattingEnabled = true;
            teamMemberListBox.ItemHeight = 15;
            teamMemberListBox.Location = new Point(414, 95);
            teamMemberListBox.Name = "teamMemberListBox";
            teamMemberListBox.Size = new Size(258, 439);
            teamMemberListBox.TabIndex = 19;
            // 
            // removeMembersButton
            // 
            removeMembersButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            removeMembersButton.Location = new Point(677, 270);
            removeMembersButton.Margin = new Padding(2);
            removeMembersButton.Name = "removeMembersButton";
            removeMembersButton.Size = new Size(101, 68);
            removeMembersButton.TabIndex = 22;
            removeMembersButton.Text = "Remove Selected";
            removeMembersButton.UseVisualStyleBackColor = true;
            removeMembersButton.Click += removeMembersButton_Click;
            // 
            // createTeamButton
            // 
            createTeamButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            createTeamButton.Location = new Point(306, 565);
            createTeamButton.Margin = new Padding(2);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(196, 68);
            createTeamButton.TabIndex = 23;
            createTeamButton.Text = "Ceate Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 644);
            Controls.Add(createTeamButton);
            Controls.Add(removeMembersButton);
            Controls.Add(teamMemberListBox);
            Controls.Add(groupBox1);
            Controls.Add(addPlayerButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemeberLabel);
            Controls.Add(teamNameTextBox);
            Controls.Add(teamNameLabel);
            Controls.Add(headerLabel);
            Name = "CreateTeamForm";
            Text = "CreateTeamForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox teamNameTextBox;
        private Label teamNameLabel;
        private Label selectTeamMemeberLabel;
        private ComboBox selectTeamMemberDropDown;
        private Button addPlayerButton;
        private GroupBox groupBox1;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private Button createPlayerButton;
        private TextBox cellphoneNumberTextBox;
        private Label cellphoneNumberLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private ListBox teamMemberListBox;
        private Button removeMembersButton;
        private Button createTeamButton;
    }
}