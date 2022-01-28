
namespace CrtanjeKruznice
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
            this.labelOpseg = new System.Windows.Forms.Label();
            this.labelPovrsina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOpseg
            // 
            this.labelOpseg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOpseg.AutoSize = true;
            this.labelOpseg.Location = new System.Drawing.Point(57, 579);
            this.labelOpseg.Name = "labelOpseg";
            this.labelOpseg.Size = new System.Drawing.Size(84, 13);
            this.labelOpseg.TabIndex = 0;
            this.labelOpseg.Text = "Opseg kruznice:";
            // 
            // labelPovrsina
            // 
            this.labelPovrsina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPovrsina.AutoSize = true;
            this.labelPovrsina.Location = new System.Drawing.Point(57, 601);
            this.labelPovrsina.Name = "labelPovrsina";
            this.labelPovrsina.Size = new System.Drawing.Size(94, 13);
            this.labelPovrsina.TabIndex = 1;
            this.labelPovrsina.Text = "Povrsina kruznice:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.labelPovrsina);
            this.Controls.Add(this.labelOpseg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelOpseg;
        private System.Windows.Forms.Label labelPovrsina;
    }
}

#endregion