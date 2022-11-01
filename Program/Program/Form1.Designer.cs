namespace TrackBar_kontrola
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
            this.trb1 = new System.Windows.Forms.TrackBar();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trb1)).BeginInit();
            this.SuspendLayout();
            // 
            // trb1
            // 
            this.trb1.Location = new System.Drawing.Point(12, 24);
            this.trb1.Maximum = 100;
            this.trb1.Name = "trb1";
            this.trb1.Size = new System.Drawing.Size(379, 45);
            this.trb1.TabIndex = 0;
            this.trb1.Scroll += new System.EventHandler(this.trb1_Scroll);
            // 
            // txtBox1
            // 
            this.txtBox1.Enabled = false;
            this.txtBox1.Location = new System.Drawing.Point(189, 115);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(43, 20);
            this.txtBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(58, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 13);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Postavljena vrijednost je:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 186);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.trb1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trb1;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

