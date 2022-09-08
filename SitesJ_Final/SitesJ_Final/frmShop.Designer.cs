
namespace SitesJ_Final
{
    partial class frmShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShop));
            this.pbxGame = new System.Windows.Forms.PictureBox();
            this.cbxQuantity = new System.Windows.Forms.ComboBox();
            this.dgvGames = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxGame
            // 
            this.pbxGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxGame.Location = new System.Drawing.Point(12, 305);
            this.pbxGame.Name = "pbxGame";
            this.pbxGame.Size = new System.Drawing.Size(330, 107);
            this.pbxGame.TabIndex = 11;
            this.pbxGame.TabStop = false;
            // 
            // cbxQuantity
            // 
            this.cbxQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuantity.FormattingEnabled = true;
            this.cbxQuantity.Location = new System.Drawing.Point(124, 425);
            this.cbxQuantity.Name = "cbxQuantity";
            this.cbxQuantity.Size = new System.Drawing.Size(106, 21);
            this.cbxQuantity.TabIndex = 10;
            // 
            // dgvGames
            // 
            this.dgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGames.Location = new System.Drawing.Point(12, 11);
            this.dgvGames.Name = "dgvGames";
            this.dgvGames.ReadOnly = true;
            this.dgvGames.Size = new System.Drawing.Size(960, 288);
            this.dgvGames.TabIndex = 9;
            this.dgvGames.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGames_CellContentClick);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Indigo;
            this.btnHome.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Magenta;
            this.btnHome.Location = new System.Drawing.Point(901, 418);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(71, 31);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.Indigo;
            this.btnCart.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.Magenta;
            this.btnCart.Location = new System.Drawing.Point(776, 418);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(119, 31);
            this.btnCart.TabIndex = 7;
            this.btnCart.Text = "Shopping Cart";
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Indigo;
            this.btnAdd.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Magenta;
            this.btnAdd.Location = new System.Drawing.Point(12, 418);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 31);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pbxGame);
            this.Controls.Add(this.cbxQuantity);
            this.Controls.Add(this.dgvGames);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Castle";
            this.Load += new System.EventHandler(this.frmShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxGame;
        private System.Windows.Forms.ComboBox cbxQuantity;
        private System.Windows.Forms.DataGridView dgvGames;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnAdd;
    }
}