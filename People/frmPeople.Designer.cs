namespace DVLDAnwar
{
    partial class frmPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeople));
            this.DGVPeople = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearchPeople = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddPeople = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCloseFrmPeople = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPeople
            // 
            this.DGVPeople.AllowUserToAddRows = false;
            this.DGVPeople.AllowUserToDeleteRows = false;
            this.DGVPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPeople.Location = new System.Drawing.Point(-9, 180);
            this.DGVPeople.Name = "DGVPeople";
            this.DGVPeople.ReadOnly = true;
            this.DGVPeople.Size = new System.Drawing.Size(1107, 347);
            this.DGVPeople.TabIndex = 0;
            this.DGVPeople.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPeople_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Urdu Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(497, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage People";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(504, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearchPeople
            // 
            this.txtSearchPeople.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPeople.Location = new System.Drawing.Point(82, 146);
            this.txtSearchPeople.Name = "txtSearchPeople";
            this.txtSearchPeople.Size = new System.Drawing.Size(169, 26);
            this.txtSearchPeople.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter By:";
            // 
            // btnAddPeople
            // 
            this.btnAddPeople.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.btnAddPeople.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPeople.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPeople.Location = new System.Drawing.Point(994, 146);
            this.btnAddPeople.Name = "btnAddPeople";
            this.btnAddPeople.Size = new System.Drawing.Size(89, 28);
            this.btnAddPeople.TabIndex = 6;
            this.btnAddPeople.Text = "Add People";
            this.btnAddPeople.UseVisualStyleBackColor = true;
            this.btnAddPeople.Click += new System.EventHandler(this.btnAddPeople_Click);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(272, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCloseFrmPeople
            // 
            this.btnCloseFrmPeople.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.btnCloseFrmPeople.BackColor = System.Drawing.Color.Red;
            this.btnCloseFrmPeople.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseFrmPeople.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseFrmPeople.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseFrmPeople.Image")));
            this.btnCloseFrmPeople.Location = new System.Drawing.Point(1064, -2);
            this.btnCloseFrmPeople.Name = "btnCloseFrmPeople";
            this.btnCloseFrmPeople.Size = new System.Drawing.Size(34, 32);
            this.btnCloseFrmPeople.TabIndex = 9;
            this.btnCloseFrmPeople.UseVisualStyleBackColor = false;
            this.btnCloseFrmPeople.Click += new System.EventHandler(this.btnCloseFrmPeople_Click);
            // 
            // frmPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 599);
            this.ControlBox = false;
            this.Controls.Add(this.btnCloseFrmPeople);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddPeople);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchPeople);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVPeople);
            this.Name = "frmPeople";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearchPeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddPeople;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCloseFrmPeople;
    }
}

