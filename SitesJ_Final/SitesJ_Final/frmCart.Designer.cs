
namespace SitesJ_Final
{
    partial class frmCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCart));
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.tbxLName = new System.Windows.Forms.TextBox();
            this.tbxFName = new System.Windows.Forms.TextBox();
            this.lblNetTotalOutput = new System.Windows.Forms.Label();
            this.lblNetTotal = new System.Windows.Forms.Label();
            this.lblTaxAmountOutput = new System.Windows.Forms.Label();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.lblSubtotalOutput = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(11, 10);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.Size = new System.Drawing.Size(737, 367);
            this.dgvCart.TabIndex = 31;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(754, 72);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(88, 20);
            this.lblLName.TabIndex = 30;
            this.lblLName.Text = "Last name:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(754, 10);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(88, 20);
            this.lblFName.TabIndex = 29;
            this.lblFName.Text = "First name:";
            // 
            // tbxLName
            // 
            this.tbxLName.BackColor = System.Drawing.Color.FloralWhite;
            this.tbxLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLName.Location = new System.Drawing.Point(754, 95);
            this.tbxLName.Name = "tbxLName";
            this.tbxLName.Size = new System.Drawing.Size(220, 26);
            this.tbxLName.TabIndex = 28;
            // 
            // tbxFName
            // 
            this.tbxFName.BackColor = System.Drawing.Color.FloralWhite;
            this.tbxFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFName.Location = new System.Drawing.Point(754, 33);
            this.tbxFName.Name = "tbxFName";
            this.tbxFName.Size = new System.Drawing.Size(220, 26);
            this.tbxFName.TabIndex = 27;
            // 
            // lblNetTotalOutput
            // 
            this.lblNetTotalOutput.BackColor = System.Drawing.Color.FloralWhite;
            this.lblNetTotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNetTotalOutput.Location = new System.Drawing.Point(487, 389);
            this.lblNetTotalOutput.Name = "lblNetTotalOutput";
            this.lblNetTotalOutput.Size = new System.Drawing.Size(73, 23);
            this.lblNetTotalOutput.TabIndex = 26;
            // 
            // lblNetTotal
            // 
            this.lblNetTotal.AutoSize = true;
            this.lblNetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNetTotal.Location = new System.Drawing.Point(404, 389);
            this.lblNetTotal.Name = "lblNetTotal";
            this.lblNetTotal.Size = new System.Drawing.Size(77, 20);
            this.lblNetTotal.TabIndex = 25;
            this.lblNetTotal.Text = "Net Total:";
            // 
            // lblTaxAmountOutput
            // 
            this.lblTaxAmountOutput.BackColor = System.Drawing.Color.FloralWhite;
            this.lblTaxAmountOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTaxAmountOutput.Location = new System.Drawing.Point(329, 389);
            this.lblTaxAmountOutput.Name = "lblTaxAmountOutput";
            this.lblTaxAmountOutput.Size = new System.Drawing.Size(73, 23);
            this.lblTaxAmountOutput.TabIndex = 24;
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTaxAmount.Location = new System.Drawing.Point(166, 389);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(157, 20);
            this.lblTaxAmount.TabIndex = 23;
            this.lblTaxAmount.Text = "Tax Amount (8.25%):";
            // 
            // lblSubtotalOutput
            // 
            this.lblSubtotalOutput.BackColor = System.Drawing.Color.FloralWhite;
            this.lblSubtotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSubtotalOutput.Location = new System.Drawing.Point(89, 389);
            this.lblSubtotalOutput.Name = "lblSubtotalOutput";
            this.lblSubtotalOutput.Size = new System.Drawing.Size(73, 23);
            this.lblSubtotalOutput.TabIndex = 22;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSubtotal.Location = new System.Drawing.Point(10, 389);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(73, 20);
            this.lblSubtotal.TabIndex = 21;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Indigo;
            this.btnCheckOut.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.Magenta;
            this.btnCheckOut.Location = new System.Drawing.Point(878, 384);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(96, 30);
            this.btnCheckOut.TabIndex = 20;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Indigo;
            this.btnRemove.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Magenta;
            this.btnRemove.Location = new System.Drawing.Point(10, 420);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(117, 30);
            this.btnRemove.TabIndex = 19;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Indigo;
            this.btnClear.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Magenta;
            this.btnClear.Location = new System.Drawing.Point(133, 420);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 30);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear Cart";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Indigo;
            this.btnContinue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.Magenta;
            this.btnContinue.Location = new System.Drawing.Point(821, 420);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(153, 30);
            this.btnContinue.TabIndex = 17;
            this.btnContinue.Text = "Continue Shopping";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // frmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.tbxLName);
            this.Controls.Add(this.tbxFName);
            this.Controls.Add(this.lblNetTotalOutput);
            this.Controls.Add(this.lblNetTotal);
            this.Controls.Add(this.lblTaxAmountOutput);
            this.Controls.Add(this.lblTaxAmount);
            this.Controls.Add(this.lblSubtotalOutput);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnContinue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Castle";
            this.Load += new System.EventHandler(this.frmCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox tbxLName;
        private System.Windows.Forms.TextBox tbxFName;
        private System.Windows.Forms.Label lblNetTotalOutput;
        private System.Windows.Forms.Label lblNetTotal;
        private System.Windows.Forms.Label lblTaxAmountOutput;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.Label lblSubtotalOutput;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnContinue;
    }
}