namespace AutomatedInformationSystemOfARealEstateAgency.Views
{
    partial class MainMenuView
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
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OutputShoppingStoreButton = new System.Windows.Forms.Button();
            this.AddNewFlatButton = new System.Windows.Forms.Button();
            this.SearchClientButton = new System.Windows.Forms.Button();
            this.SearchFlatButton = new System.Windows.Forms.Button();
            this.AdminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminPanel
            // 
            this.AdminPanel.Controls.Add(this.ExitButton);
            this.AdminPanel.Controls.Add(this.OutputShoppingStoreButton);
            this.AdminPanel.Controls.Add(this.AddNewFlatButton);
            this.AdminPanel.Controls.Add(this.SearchClientButton);
            this.AdminPanel.Controls.Add(this.SearchFlatButton);
            this.AdminPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AdminPanel.Location = new System.Drawing.Point(0, 0);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(247, 553);
            this.AdminPanel.TabIndex = 1;
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(0, 454);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(247, 44);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.TabStop = false;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // OutputShoppingStoreButton
            // 
            this.OutputShoppingStoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OutputShoppingStoreButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputShoppingStoreButton.Location = new System.Drawing.Point(0, 404);
            this.OutputShoppingStoreButton.Name = "OutputShoppingStoreButton";
            this.OutputShoppingStoreButton.Size = new System.Drawing.Size(247, 44);
            this.OutputShoppingStoreButton.TabIndex = 4;
            this.OutputShoppingStoreButton.TabStop = false;
            this.OutputShoppingStoreButton.Text = "Вывод отчетности";
            this.OutputShoppingStoreButton.UseVisualStyleBackColor = true;
            // 
            // AddNewFlatButton
            // 
            this.AddNewFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewFlatButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewFlatButton.Location = new System.Drawing.Point(0, 354);
            this.AddNewFlatButton.Name = "AddNewFlatButton";
            this.AddNewFlatButton.Size = new System.Drawing.Size(247, 44);
            this.AddNewFlatButton.TabIndex = 3;
            this.AddNewFlatButton.TabStop = false;
            this.AddNewFlatButton.Text = "Добавить квартиру на продажу";
            this.AddNewFlatButton.UseVisualStyleBackColor = true;
            // 
            // SearchClientButton
            // 
            this.SearchClientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchClientButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchClientButton.Location = new System.Drawing.Point(0, 304);
            this.SearchClientButton.Name = "SearchClientButton";
            this.SearchClientButton.Size = new System.Drawing.Size(247, 44);
            this.SearchClientButton.TabIndex = 1;
            this.SearchClientButton.TabStop = false;
            this.SearchClientButton.Text = "Поиск клиентов";
            this.SearchClientButton.UseVisualStyleBackColor = true;
            // 
            // SearchFlatButton
            // 
            this.SearchFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchFlatButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchFlatButton.Location = new System.Drawing.Point(0, 254);
            this.SearchFlatButton.Name = "SearchFlatButton";
            this.SearchFlatButton.Size = new System.Drawing.Size(247, 44);
            this.SearchFlatButton.TabIndex = 0;
            this.SearchFlatButton.TabStop = false;
            this.SearchFlatButton.Text = "Поиск квартиры";
            this.SearchFlatButton.UseVisualStyleBackColor = true;
            // 
            // MainMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.AdminPanel);
            this.Name = "MainMenuView";
            this.Text = "MainMenuView";
            this.AdminPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button OutputShoppingStoreButton;
        private System.Windows.Forms.Button AddNewFlatButton;
        private System.Windows.Forms.Button SearchClientButton;
        private System.Windows.Forms.Button SearchFlatButton;
    }
}