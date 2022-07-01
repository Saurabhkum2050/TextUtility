namespace TextUtility
{
    partial class TextUtilityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextUtilityForm));
            this.FormTitle = new System.Windows.Forms.Label();
            this.LabelFormatType = new System.Windows.Forms.Label();
            this.FormatTypes = new System.Windows.Forms.ComboBox();
            this.LabelTextData = new System.Windows.Forms.Label();
            this.TextData = new System.Windows.Forms.TextBox();
            this.Divider = new System.Windows.Forms.Label();
            this.LabelCharacterCount = new System.Windows.Forms.Label();
            this.NumOfSpaces = new System.Windows.Forms.Label();
            this.NumOfNumbers = new System.Windows.Forms.Label();
            this.NumOfCharacters = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormTitle.Location = new System.Drawing.Point(12, 9);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(89, 21);
            this.FormTitle.TabIndex = 2;
            this.FormTitle.Text = "Task No. 02";
            // 
            // LabelFormatType
            // 
            this.LabelFormatType.AutoSize = true;
            this.LabelFormatType.Location = new System.Drawing.Point(12, 70);
            this.LabelFormatType.Name = "LabelFormatType";
            this.LabelFormatType.Size = new System.Drawing.Size(72, 15);
            this.LabelFormatType.TabIndex = 3;
            this.LabelFormatType.Text = "Format Type";
            // 
            // FormatTypes
            // 
            this.FormatTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormatTypes.FormattingEnabled = true;
            this.FormatTypes.Items.AddRange(new object[] {
            "lower case",
            "UPPER CASE",
            "Sentence case",
            "Title Case"});
            this.FormatTypes.Location = new System.Drawing.Point(150, 70);
            this.FormatTypes.Name = "FormatTypes";
            this.FormatTypes.Size = new System.Drawing.Size(440, 23);
            this.FormatTypes.TabIndex = 4;
            this.FormatTypes.SelectedIndexChanged += new System.EventHandler(this.TextData_TextChanged);
            // 
            // LabelTextData
            // 
            this.LabelTextData.AutoSize = true;
            this.LabelTextData.Location = new System.Drawing.Point(12, 120);
            this.LabelTextData.Name = "LabelTextData";
            this.LabelTextData.Size = new System.Drawing.Size(55, 15);
            this.LabelTextData.TabIndex = 5;
            this.LabelTextData.Text = "Text Data";
            // 
            // TextData
            // 
            this.TextData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextData.Location = new System.Drawing.Point(150, 120);
            this.TextData.Multiline = true;
            this.TextData.Name = "TextData";
            this.TextData.PlaceholderText = "Please type here...";
            this.TextData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextData.Size = new System.Drawing.Size(440, 280);
            this.TextData.TabIndex = 6;
            this.TextData.TextChanged += new System.EventHandler(this.TextData_TextChanged);
            // 
            // Divider
            // 
            this.Divider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Divider.Location = new System.Drawing.Point(0, 40);
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(676, 2);
            this.Divider.TabIndex = 7;
            this.Divider.Text = "Divider";
            // 
            // LabelCharacterCount
            // 
            this.LabelCharacterCount.AutoSize = true;
            this.LabelCharacterCount.Location = new System.Drawing.Point(447, 403);
            this.LabelCharacterCount.Name = "LabelCharacterCount";
            this.LabelCharacterCount.Size = new System.Drawing.Size(143, 15);
            this.LabelCharacterCount.TabIndex = 8;
            this.LabelCharacterCount.Text = "Word Count: 0000 / 10000";
            this.LabelCharacterCount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // NumOfSpaces
            // 
            this.NumOfSpaces.AutoSize = true;
            this.NumOfSpaces.Location = new System.Drawing.Point(150, 403);
            this.NumOfSpaces.Name = "NumOfSpaces";
            this.NumOfSpaces.Size = new System.Drawing.Size(67, 15);
            this.NumOfSpaces.TabIndex = 9;
            this.NumOfSpaces.Text = "Spaces: 000";
            // 
            // NumOfNumbers
            // 
            this.NumOfNumbers.AutoSize = true;
            this.NumOfNumbers.Location = new System.Drawing.Point(223, 403);
            this.NumOfNumbers.Name = "NumOfNumbers";
            this.NumOfNumbers.Size = new System.Drawing.Size(80, 15);
            this.NumOfNumbers.TabIndex = 10;
            this.NumOfNumbers.Text = "Numbers: 000";
            // 
            // NumOfCharacters
            // 
            this.NumOfCharacters.AutoSize = true;
            this.NumOfCharacters.Location = new System.Drawing.Point(309, 403);
            this.NumOfCharacters.Name = "NumOfCharacters";
            this.NumOfCharacters.Size = new System.Drawing.Size(87, 15);
            this.NumOfCharacters.TabIndex = 11;
            this.NumOfCharacters.Text = "Characters: 000";
            // 
            // TextUtilityForm
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 523);
            this.Controls.Add(this.NumOfCharacters);
            this.Controls.Add(this.NumOfNumbers);
            this.Controls.Add(this.NumOfSpaces);
            this.Controls.Add(this.LabelCharacterCount);
            this.Controls.Add(this.Divider);
            this.Controls.Add(this.TextData);
            this.Controls.Add(this.LabelTextData);
            this.Controls.Add(this.FormatTypes);
            this.Controls.Add(this.LabelFormatType);
            this.Controls.Add(this.FormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextUtilityForm";
            this.Text = "Text Utility";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextUtilityForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label FormTitle;
        private Label LabelFormatType;
        private ComboBox FormatTypes;
        private Label LabelTextData;
        private TextBox TextData;
        private Label Divider;
        private Label LabelCharacterCount;
        private Label NumOfSpaces;
        private Label NumOfNumbers;
        private Label NumOfCharacters;
    }
}