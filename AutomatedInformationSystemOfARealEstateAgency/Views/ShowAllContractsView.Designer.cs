namespace AutomatedInformationSystemOfARealEstateAgency.Views
{
    partial class ShowAllContractsView
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
            this.ShowInfoAboutContractsButton = new System.Windows.Forms.Button();
            this.DataSourseContracts = new System.Windows.Forms.DataGridView();
            this.SearchContractsButton = new System.Windows.Forms.Button();
            this.InputFieldForSearchContracts = new System.Windows.Forms.TextBox();
            this.SearchEmployee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataSourseContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowInfoAboutContractsButton
            // 
            this.ShowInfoAboutContractsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowInfoAboutContractsButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowInfoAboutContractsButton.Location = new System.Drawing.Point(575, 440);
            this.ShowInfoAboutContractsButton.Name = "ShowInfoAboutContractsButton";
            this.ShowInfoAboutContractsButton.Size = new System.Drawing.Size(217, 45);
            this.ShowInfoAboutContractsButton.TabIndex = 17;
            this.ShowInfoAboutContractsButton.Text = "Просмотреть информацию";
            this.ShowInfoAboutContractsButton.UseVisualStyleBackColor = true;
            // 
            // DataSourseContracts
            // 
            this.DataSourseContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSourseContracts.Location = new System.Drawing.Point(31, 62);
            this.DataSourseContracts.Name = "DataSourseContracts";
            this.DataSourseContracts.RowHeadersWidth = 51;
            this.DataSourseContracts.RowTemplate.Height = 24;
            this.DataSourseContracts.Size = new System.Drawing.Size(761, 372);
            this.DataSourseContracts.TabIndex = 16;
            // 
            // SearchContractsButton
            // 
            this.SearchContractsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchContractsButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchContractsButton.Location = new System.Drawing.Point(670, 12);
            this.SearchContractsButton.Name = "SearchContractsButton";
            this.SearchContractsButton.Size = new System.Drawing.Size(122, 33);
            this.SearchContractsButton.TabIndex = 15;
            this.SearchContractsButton.Text = "Найти";
            this.SearchContractsButton.UseVisualStyleBackColor = true;
            // 
            // InputFieldForSearchContracts
            // 
            this.InputFieldForSearchContracts.Location = new System.Drawing.Point(118, 18);
            this.InputFieldForSearchContracts.Name = "InputFieldForSearchContracts";
            this.InputFieldForSearchContracts.Size = new System.Drawing.Size(529, 22);
            this.InputFieldForSearchContracts.TabIndex = 14;
            // 
            // SearchEmployee
            // 
            this.SearchEmployee.AutoSize = true;
            this.SearchEmployee.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchEmployee.Location = new System.Drawing.Point(27, 16);
            this.SearchEmployee.Name = "SearchEmployee";
            this.SearchEmployee.Size = new System.Drawing.Size(68, 24);
            this.SearchEmployee.TabIndex = 13;
            this.SearchEmployee.Text = "Поиск:";
            // 
            // ShowAllContractsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 497);
            this.Controls.Add(this.ShowInfoAboutContractsButton);
            this.Controls.Add(this.DataSourseContracts);
            this.Controls.Add(this.SearchContractsButton);
            this.Controls.Add(this.InputFieldForSearchContracts);
            this.Controls.Add(this.SearchEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowAllContractsView";
            this.Text = "ShowAllContractsView";
            ((System.ComponentModel.ISupportInitialize)(this.DataSourseContracts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowInfoAboutContractsButton;
        private System.Windows.Forms.DataGridView DataSourseContracts;
        private System.Windows.Forms.Button SearchContractsButton;
        private System.Windows.Forms.TextBox InputFieldForSearchContracts;
        private System.Windows.Forms.Label SearchEmployee;
    }
}