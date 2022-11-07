namespace AutomatedInformationSystemOfARealEstateAgency.Views
{
    partial class FlatView
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
            this.ShowInfoAboutFlatButton = new System.Windows.Forms.Button();
            this.DataSourseFlat = new System.Windows.Forms.DataGridView();
            this.SearchFlatButton = new System.Windows.Forms.Button();
            this.InputFieldForSearchFlat = new System.Windows.Forms.TextBox();
            this.SearchEmployee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataSourseFlat)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowInfoAboutFlatButton
            // 
            this.ShowInfoAboutFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowInfoAboutFlatButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowInfoAboutFlatButton.Location = new System.Drawing.Point(560, 440);
            this.ShowInfoAboutFlatButton.Name = "ShowInfoAboutFlatButton";
            this.ShowInfoAboutFlatButton.Size = new System.Drawing.Size(217, 45);
            this.ShowInfoAboutFlatButton.TabIndex = 11;
            this.ShowInfoAboutFlatButton.Text = "Просмотреть информацию";
            this.ShowInfoAboutFlatButton.UseVisualStyleBackColor = true;
            // 
            // DataSourseFlat
            // 
            this.DataSourseFlat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSourseFlat.Location = new System.Drawing.Point(16, 62);
            this.DataSourseFlat.Name = "DataSourseFlat";
            this.DataSourseFlat.RowHeadersWidth = 51;
            this.DataSourseFlat.RowTemplate.Height = 24;
            this.DataSourseFlat.Size = new System.Drawing.Size(761, 372);
            this.DataSourseFlat.TabIndex = 10;
            // 
            // SearchFlatButton
            // 
            this.SearchFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchFlatButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchFlatButton.Location = new System.Drawing.Point(655, 12);
            this.SearchFlatButton.Name = "SearchFlatButton";
            this.SearchFlatButton.Size = new System.Drawing.Size(122, 33);
            this.SearchFlatButton.TabIndex = 9;
            this.SearchFlatButton.Text = "Найти";
            this.SearchFlatButton.UseVisualStyleBackColor = true;
            // 
            // InputFieldForSearchFlat
            // 
            this.InputFieldForSearchFlat.Location = new System.Drawing.Point(103, 18);
            this.InputFieldForSearchFlat.Name = "InputFieldForSearchFlat";
            this.InputFieldForSearchFlat.Size = new System.Drawing.Size(529, 22);
            this.InputFieldForSearchFlat.TabIndex = 8;
            // 
            // SearchEmployee
            // 
            this.SearchEmployee.AutoSize = true;
            this.SearchEmployee.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchEmployee.Location = new System.Drawing.Point(12, 16);
            this.SearchEmployee.Name = "SearchEmployee";
            this.SearchEmployee.Size = new System.Drawing.Size(68, 24);
            this.SearchEmployee.TabIndex = 7;
            this.SearchEmployee.Text = "Поиск:";
            // 
            // FlatView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 497);
            this.Controls.Add(this.ShowInfoAboutFlatButton);
            this.Controls.Add(this.DataSourseFlat);
            this.Controls.Add(this.SearchFlatButton);
            this.Controls.Add(this.InputFieldForSearchFlat);
            this.Controls.Add(this.SearchEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlatView";
            this.Text = "FlatView";
            ((System.ComponentModel.ISupportInitialize)(this.DataSourseFlat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ShowInfoAboutFlatButton;
        private System.Windows.Forms.DataGridView DataSourseFlat;
        private System.Windows.Forms.Button SearchFlatButton;
        private System.Windows.Forms.TextBox InputFieldForSearchFlat;
        private System.Windows.Forms.Label SearchEmployee;
    }
}