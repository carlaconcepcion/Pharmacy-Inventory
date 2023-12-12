namespace Pharmacy_Inventory_System
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
            textBoxNewUsername = new TextBox();
            textBoxNewPassword = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            pharmacylabel = new Label();
            SuspendLayout();
            // 
            // textBoxNewUsername
            // 
            textBoxNewUsername.Location = new Point(345, 123);
            textBoxNewUsername.Multiline = true;
            textBoxNewUsername.Name = "textBoxNewUsername";
            textBoxNewUsername.Size = new Size(175, 34);
            textBoxNewUsername.TabIndex = 0;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Location = new Point(345, 184);
            textBoxNewPassword.Multiline = true;
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(175, 34);
            textBoxNewPassword.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(351, 276);
            button1.Name = "button1";
            button1.Size = new Size(169, 37);
            button1.TabIndex = 2;
            button1.Text = "Create account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(163, 276);
            button2.Name = "button2";
            button2.Size = new Size(169, 37);
            button2.TabIndex = 3;
            button2.Text = "Back to login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(163, 123);
            label1.Name = "label1";
            label1.Size = new Size(151, 34);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(163, 184);
            label2.Name = "label2";
            label2.Size = new Size(143, 34);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // pharmacylabel
            // 
            pharmacylabel.AutoSize = true;
            pharmacylabel.Font = new Font("Cambria", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            pharmacylabel.Location = new Point(35, 47);
            pharmacylabel.Name = "pharmacylabel";
            pharmacylabel.Size = new Size(603, 34);
            pharmacylabel.TabIndex = 6;
            pharmacylabel.Text = "EASY CARE PHARMACY INVENTORY SYSTEM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg6;
            ClientSize = new Size(664, 426);
            Controls.Add(pharmacylabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxNewPassword);
            Controls.Add(textBoxNewUsername);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNewUsername;
        private TextBox textBoxNewPassword;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label pharmacylabel;
    }
}