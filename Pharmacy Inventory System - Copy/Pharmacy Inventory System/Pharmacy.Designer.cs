namespace Pharmacy_Inventory_System
{
    partial class Pharmacy
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
            dataGridViewInventory = new DataGridView();
            txtDrugName = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRetrieve = new Button();
            pharmacylabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewInventory
            // 
            dataGridViewInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventory.Location = new Point(37, 172);
            dataGridViewInventory.Name = "dataGridViewInventory";
            dataGridViewInventory.RowTemplate.Height = 25;
            dataGridViewInventory.Size = new Size(425, 225);
            dataGridViewInventory.TabIndex = 0;
            // 
            // txtDrugName
            // 
            txtDrugName.Location = new Point(37, 126);
            txtDrugName.Multiline = true;
            txtDrugName.Name = "txtDrugName";
            txtDrugName.Size = new Size(124, 30);
            txtDrugName.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(184, 126);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(124, 30);
            txtQuantity.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(338, 126);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(124, 30);
            txtPrice.TabIndex = 4;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.Location = new Point(496, 233);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(111, 44);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(496, 172);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(111, 44);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(496, 293);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 44);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRetrieve
            // 
            btnRetrieve.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRetrieve.Location = new Point(496, 352);
            btnRetrieve.Name = "btnRetrieve";
            btnRetrieve.Size = new Size(111, 45);
            btnRetrieve.TabIndex = 8;
            btnRetrieve.Text = "Retrieve";
            btnRetrieve.UseVisualStyleBackColor = true;
            btnRetrieve.Click += btnRetrieve_Click;
            // 
            // pharmacylabel
            // 
            pharmacylabel.AutoSize = true;
            pharmacylabel.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            pharmacylabel.Location = new Point(70, 29);
            pharmacylabel.Name = "pharmacylabel";
            pharmacylabel.Size = new Size(558, 32);
            pharmacylabel.TabIndex = 9;
            pharmacylabel.Text = "EASY CARE PHARMACY INVENTORY SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 87);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 10;
            label1.Text = "Drug Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(184, 87);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 11;
            label2.Text = "Quantity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(338, 87);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 12;
            label3.Text = "Price:";
            // 
            // Pharmacy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg6;
            ClientSize = new Size(664, 426);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pharmacylabel);
            Controls.Add(btnRetrieve);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtDrugName);
            Controls.Add(dataGridViewInventory);
            Name = "Pharmacy";
            Text = "Pharmacy";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewInventory;
        private TextBox txtDrugName;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRetrieve;
        private Label pharmacylabel;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}