namespace Ass1
{
    partial class Form1
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
            btnHello = new Button();
            btnBye = new Button();
            SuspendLayout();
            // 
            // btnHello
            // 
            btnHello.Location = new Point(350, 57);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(94, 29);
            btnHello.TabIndex = 0;
            btnHello.Text = "Xin chào";
            btnHello.UseVisualStyleBackColor = true;
            btnHello.Click += btnHello_Click;
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBye);
            Controls.Add(btnHello);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnHello;
    }
}
