namespace Pharmacy_Inventory_System
{
    partial class LogIn
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
            label1 = new Label();
            label2 = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            bttnlogin = new Button();
            pharmacylabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(158, 149);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(158, 206);
            label2.Name = "label2";
            label2.Size = new Size(125, 28);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Cursor = Cursors.IBeam;
            textBoxUsername.Location = new Point(312, 149);
            textBoxUsername.Multiline = true;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(166, 28);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Cursor = Cursors.IBeam;
            textBoxPassword.Location = new Point(312, 206);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(166, 28);
            textBoxPassword.TabIndex = 3;
            // 
            // bttnlogin
            // 
            bttnlogin.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            bttnlogin.Location = new Point(194, 273);
            bttnlogin.Name = "bttnlogin";
            bttnlogin.Size = new Size(102, 45);
            bttnlogin.TabIndex = 4;
            bttnlogin.Text = "Log In";
            bttnlogin.UseVisualStyleBackColor = true;
            bttnlogin.Click += bttnlogin_Click;
            // 
            // pharmacylabel
            // 
            pharmacylabel.AutoSize = true;
            pharmacylabel.Font = new Font("Cambria", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            pharmacylabel.Location = new Point(35, 68);
            pharmacylabel.Name = "pharmacylabel";
            pharmacylabel.Size = new Size(603, 34);
            pharmacylabel.TabIndex = 5;
            pharmacylabel.Text = "EASY CARE PHARMACY INVENTORY SYSTEM";
            // 
            // button1
            // 
            button1.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(364, 271);
            button1.Name = "button1";
            button1.Size = new Size(93, 56);
            button1.TabIndex = 6;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg6;
            ClientSize = new Size(664, 426);
            Controls.Add(button1);
            Controls.Add(pharmacylabel);
            Controls.Add(bttnlogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button bttnlogin;
        private Label pharmacylabel;
        private Button button1;
    }
}