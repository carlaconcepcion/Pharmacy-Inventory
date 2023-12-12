namespace Pharmacy_Inventory_System
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            timer2 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            SuspendLayout();
            // 
            // timer2
            // 
            timer2.Interval = 20;
            // 
            // button1
            // 
            button1.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(256, 303);
            button1.Name = "button1";
            button1.Size = new Size(253, 23);
            button1.TabIndex = 0;
            button1.Text = "Easy Care";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot__1020__removebg_preview;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(664, 426);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Button button1;
    }
}