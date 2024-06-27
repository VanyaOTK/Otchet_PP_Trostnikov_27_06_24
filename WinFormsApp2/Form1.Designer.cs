namespace MedicationRegistry
{
    partial class Form1
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
            nameTextBox = new TextBox();
            manufacturerTextBox = new TextBox();
            quantityTextBox = new TextBox();
            priceTextBox = new TextBox();
            addButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            medicationsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)medicationsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(183, 0);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Название";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 0;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // manufacturerTextBox
            // 
            manufacturerTextBox.Location = new Point(183, 29);
            manufacturerTextBox.Name = "manufacturerTextBox";
            manufacturerTextBox.PlaceholderText = "Производитель";
            manufacturerTextBox.Size = new Size(100, 23);
            manufacturerTextBox.TabIndex = 1;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(183, 58);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.PlaceholderText = "Количество";
            quantityTextBox.Size = new Size(100, 23);
            quantityTextBox.TabIndex = 2;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(183, 87);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.PlaceholderText = "Цена";
            priceTextBox.Size = new Size(100, 23);
            priceTextBox.TabIndex = 3;
            priceTextBox.TextChanged += priceTextBox_TextChanged;
            // 
            // addButton
            // 
            addButton.BackColor = SystemColors.Info;
            addButton.Location = new Point(90, 116);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 4;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = SystemColors.Info;
            deleteButton.Location = new Point(192, 116);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = SystemColors.Info;
            editButton.Location = new Point(285, 116);
            editButton.Name = "editButton";
            editButton.Size = new Size(97, 23);
            editButton.TabIndex = 6;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // medicationsDataGridView
            // 
            medicationsDataGridView.BackgroundColor = SystemColors.ActiveCaption;
            medicationsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            medicationsDataGridView.Location = new Point(12, 145);
            medicationsDataGridView.Name = "medicationsDataGridView";
            medicationsDataGridView.Size = new Size(437, 293);
            medicationsDataGridView.TabIndex = 7;
            medicationsDataGridView.CellContentClick += medicationsDataGridView_CellContentClick;
            // 
            // Form1
            // 
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(464, 450);
            Controls.Add(medicationsDataGridView);
            Controls.Add(editButton);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(priceTextBox);
            Controls.Add(quantityTextBox);
            Controls.Add(manufacturerTextBox);
            Controls.Add(nameTextBox);
            Name = "Form1";
            Text = "Реестр медикаментов";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)medicationsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.DataGridView medicationsDataGridView;
    }
}
