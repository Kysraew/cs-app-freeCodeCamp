namespace TrackerUI
{
    partial class TournamentDashboard
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
            tournamentsDropDown = new ComboBox();
            selectTournamentLabel = new Label();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            headerLabel.Location = new Point(34, 29);
            headerLabel.Margin = new Padding(2, 0, 2, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(393, 47);
            headerLabel.TabIndex = 4;
            headerLabel.Text = "Tournament Dashboard";
            // 
            // tournamentsDropDown
            // 
            tournamentsDropDown.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentsDropDown.FormattingEnabled = true;
            tournamentsDropDown.Location = new Point(69, 151);
            tournamentsDropDown.Margin = new Padding(2);
            tournamentsDropDown.Name = "tournamentsDropDown";
            tournamentsDropDown.Size = new Size(267, 33);
            tournamentsDropDown.TabIndex = 16;
            // 
            // selectTournamentLabel
            // 
            selectTournamentLabel.AutoSize = true;
            selectTournamentLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            selectTournamentLabel.Location = new Point(69, 112);
            selectTournamentLabel.Margin = new Padding(2, 0, 2, 0);
            selectTournamentLabel.Name = "selectTournamentLabel";
            selectTournamentLabel.Size = new Size(233, 25);
            selectTournamentLabel.TabIndex = 15;
            selectTournamentLabel.Text = "Load Existing Torunament:";
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            loadTournamentButton.Location = new Point(69, 207);
            loadTournamentButton.Margin = new Padding(2);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(200, 41);
            loadTournamentButton.TabIndex = 24;
            loadTournamentButton.Text = "Load tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            createTournamentButton.Location = new Point(69, 294);
            createTournamentButton.Margin = new Padding(2);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(200, 61);
            createTournamentButton.TabIndex = 25;
            createTournamentButton.Text = "Create tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(tournamentsDropDown);
            Controls.Add(selectTournamentLabel);
            Controls.Add(headerLabel);
            Name = "TournamentDashboard";
            Text = "TournamentDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private ComboBox tournamentsDropDown;
        private Label selectTournamentLabel;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}