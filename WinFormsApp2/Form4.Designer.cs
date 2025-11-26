namespace WinFormsApp2
{
    partial class Form4
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
            button1 = new Button();
            Mixitems1 = new ListBox();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(297, 12);
            button1.Name = "button1";
            button1.Size = new Size(143, 43);
            button1.TabIndex = 0;
            button1.Text = "Mixings";
            button1.UseVisualStyleBackColor = true;
            // 
            // Mixitems1
            // 
            Mixitems1.FormattingEnabled = true;
            Mixitems1.Location = new Point(26, 12);
            Mixitems1.Name = "Mixitems1";
            Mixitems1.Size = new Size(120, 94);
            Mixitems1.TabIndex = 4;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(688, 27);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 28);
            progressBar1.TabIndex = 5;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(Mixitems1);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox Mixitems1;
        private ProgressBar progressBar1;
    }
}