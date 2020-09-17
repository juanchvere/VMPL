namespace Presentador
{
    partial class Vista
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
            this.TxtValor1 = new System.Windows.Forms.TextBox();
            this.LbRta = new System.Windows.Forms.Label();
            this.BtConsulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtValor1
            // 
            this.TxtValor1.Location = new System.Drawing.Point(324, 86);
            this.TxtValor1.Name = "TxtValor1";
            this.TxtValor1.Size = new System.Drawing.Size(100, 20);
            this.TxtValor1.TabIndex = 0;
            // 
            // LbRta
            // 
            this.LbRta.AutoSize = true;
            this.LbRta.Location = new System.Drawing.Point(500, 148);
            this.LbRta.Name = "LbRta";
            this.LbRta.Size = new System.Drawing.Size(35, 13);
            this.LbRta.TabIndex = 1;
            this.LbRta.Text = "label1";
            // 
            // BtConsulta
            // 
            this.BtConsulta.Location = new System.Drawing.Point(324, 127);
            this.BtConsulta.Name = "BtConsulta";
            this.BtConsulta.Size = new System.Drawing.Size(75, 23);
            this.BtConsulta.TabIndex = 2;
            this.BtConsulta.Text = "button1";
            this.BtConsulta.UseVisualStyleBackColor = true;
            // 
            // Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtConsulta);
            this.Controls.Add(this.LbRta);
            this.Controls.Add(this.TxtValor1);
            this.Name = "Vista";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtValor1;
        private System.Windows.Forms.Label LbRta;
        private System.Windows.Forms.Button BtConsulta;
    }
}

