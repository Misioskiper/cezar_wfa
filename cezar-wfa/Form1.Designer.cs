namespace cezar_wfa
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
            this.buton1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buton1
            // 
            this.buton1.Location = new System.Drawing.Point(12, 12);
            this.buton1.Name = "buton1";
            this.buton1.Size = new System.Drawing.Size(115, 143);
            this.buton1.TabIndex = 0;
            this.buton1.Text = "Szyfrowanie";
            this.buton1.UseVisualStyleBackColor = true;
            this.buton1.Click += new System.EventHandler(this.buton1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 142);
            this.button2.TabIndex = 1;
            this.button2.Text = "Deszyfrowanie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 213);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buton1;
        private System.Windows.Forms.Button button2;
    }
}

