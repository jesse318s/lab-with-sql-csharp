
namespace SitesJ_Final
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblAboutHeading = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAboutHeading
            // 
            this.lblAboutHeading.AutoSize = true;
            this.lblAboutHeading.BackColor = System.Drawing.Color.Indigo;
            this.lblAboutHeading.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutHeading.ForeColor = System.Drawing.Color.Magenta;
            this.lblAboutHeading.Location = new System.Drawing.Point(434, 10);
            this.lblAboutHeading.Name = "lblAboutHeading";
            this.lblAboutHeading.Size = new System.Drawing.Size(101, 40);
            this.lblAboutHeading.TabIndex = 5;
            this.lblAboutHeading.Text = "About";
            // 
            // lblAbout
            // 
            this.lblAbout.BackColor = System.Drawing.Color.Indigo;
            this.lblAbout.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.Magenta;
            this.lblAbout.Location = new System.Drawing.Point(12, 63);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(960, 339);
            this.lblAbout.TabIndex = 4;
            this.lblAbout.Text = resources.GetString("lblAbout.Text");
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Indigo;
            this.btnClose.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Magenta;
            this.btnClose.Location = new System.Drawing.Point(892, 413);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 37);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.lblAboutHeading);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gaming Castle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAboutHeading;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Button btnClose;
    }
}