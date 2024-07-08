namespace TrackerUI
{
    partial class CreatePrizeForm
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
            prizeNumberTextBox = new TextBox();
            prizeNumberLabel = new Label();
            prizeNameTextBox = new TextBox();
            prizeNameLabel = new Label();
            prizePercentageTextBox = new TextBox();
            prizePercentageLabel = new Label();
            prizeAmountTextBox = new TextBox();
            prizeAmountLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            headerLabel.Location = new Point(31, 23);
            headerLabel.Margin = new Padding(2, 0, 2, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(211, 47);
            headerLabel.TabIndex = 3;
            headerLabel.Text = "Create Prize";
            // 
            // prizeNumberTextBox
            // 
            prizeNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            prizeNumberTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prizeNumberTextBox.Location = new Point(222, 102);
            prizeNumberTextBox.Margin = new Padding(2);
            prizeNumberTextBox.Name = "prizeNumberTextBox";
            prizeNumberTextBox.Size = new Size(144, 29);
            prizeNumberTextBox.TabIndex = 12;
            // 
            // prizeNumberLabel
            // 
            prizeNumberLabel.AutoSize = true;
            prizeNumberLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            prizeNumberLabel.Location = new Point(62, 102);
            prizeNumberLabel.Margin = new Padding(2, 0, 2, 0);
            prizeNumberLabel.Name = "prizeNumberLabel";
            prizeNumberLabel.Size = new Size(129, 25);
            prizeNumberLabel.TabIndex = 11;
            prizeNumberLabel.Text = "Prize number:";
            // 
            // prizeNameTextBox
            // 
            prizeNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            prizeNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prizeNameTextBox.Location = new Point(222, 144);
            prizeNameTextBox.Margin = new Padding(2);
            prizeNameTextBox.Name = "prizeNameTextBox";
            prizeNameTextBox.Size = new Size(144, 29);
            prizeNameTextBox.TabIndex = 14;
            // 
            // prizeNameLabel
            // 
            prizeNameLabel.AutoSize = true;
            prizeNameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            prizeNameLabel.Location = new Point(62, 144);
            prizeNameLabel.Margin = new Padding(2, 0, 2, 0);
            prizeNameLabel.Name = "prizeNameLabel";
            prizeNameLabel.Size = new Size(110, 25);
            prizeNameLabel.TabIndex = 13;
            prizeNameLabel.Text = "Prize name:";
            // 
            // prizePercentageTextBox
            // 
            prizePercentageTextBox.BorderStyle = BorderStyle.FixedSingle;
            prizePercentageTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentageTextBox.Location = new Point(222, 276);
            prizePercentageTextBox.Margin = new Padding(2);
            prizePercentageTextBox.Name = "prizePercentageTextBox";
            prizePercentageTextBox.Size = new Size(144, 29);
            prizePercentageTextBox.TabIndex = 18;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentageLabel.Location = new Point(60, 280);
            prizePercentageLabel.Margin = new Padding(2, 0, 2, 0);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(158, 25);
            prizePercentageLabel.TabIndex = 17;
            prizePercentageLabel.Text = "Prize percentage:";
            // 
            // prizeAmountTextBox
            // 
            prizeAmountTextBox.BorderStyle = BorderStyle.FixedSingle;
            prizeAmountTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountTextBox.Location = new Point(222, 188);
            prizeAmountTextBox.Margin = new Padding(2);
            prizeAmountTextBox.Name = "prizeAmountTextBox";
            prizeAmountTextBox.Size = new Size(144, 29);
            prizeAmountTextBox.TabIndex = 16;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountLabel.Location = new Point(62, 188);
            prizeAmountLabel.Margin = new Padding(2, 0, 2, 0);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(128, 25);
            prizeAmountLabel.TabIndex = 15;
            prizeAmountLabel.Text = "Prize amount:";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            orLabel.Location = new Point(185, 235);
            orLabel.Margin = new Padding(2, 0, 2, 0);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(46, 25);
            orLabel.TabIndex = 19;
            orLabel.Text = "-or-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            createPrizeButton.Location = new Point(140, 334);
            createPrizeButton.Margin = new Padding(2);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(159, 50);
            createPrizeButton.TabIndex = 23;
            createPrizeButton.Text = "Create prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageTextBox);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizeAmountTextBox);
            Controls.Add(prizeAmountLabel);
            Controls.Add(prizeNameTextBox);
            Controls.Add(prizeNameLabel);
            Controls.Add(prizeNumberTextBox);
            Controls.Add(prizeNumberLabel);
            Controls.Add(headerLabel);
            Name = "CreatePrizeForm";
            Text = "CreatePrizeForm";
            Load += CreatePrizeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox prizeNumberTextBox;
        private Label prizeNumberLabel;
        private TextBox prizeNameTextBox;
        private Label prizeNameLabel;
        private TextBox prizePercentageTextBox;
        private Label prizePercentageLabel;
        private TextBox prizeAmountTextBox;
        private Label prizeAmountLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}