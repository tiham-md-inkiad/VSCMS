namespace vehicle_service_center_management_system
{
    partial class Customerfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customerfrm));
            this.label5 = new System.Windows.Forms.Label();
            this.txtcusaddress = new System.Windows.Forms.TextBox();
            this.dtvgcus = new System.Windows.Forms.DataGridView();
            this.btnhome = new System.Windows.Forms.Button();
            this.btneditcu = new System.Windows.Forms.Button();
            this.btncudelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcusnumber = new System.Windows.Forms.TextBox();
            this.txtcusfullname = new System.Windows.Forms.TextBox();
            this.lblheader = new System.Windows.Forms.Label();
            this.lblheardermain = new System.Windows.Forms.Label();
            this.btnshowcus = new System.Windows.Forms.Button();
            this.btnaddcusm = new System.Windows.Forms.Button();
            this.btncuSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvgcus)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "Address";
            // 
            // txtcusaddress
            // 
            this.txtcusaddress.BackColor = System.Drawing.SystemColors.Info;
            this.txtcusaddress.Location = new System.Drawing.Point(138, 264);
            this.txtcusaddress.Multiline = true;
            this.txtcusaddress.Name = "txtcusaddress";
            this.txtcusaddress.Size = new System.Drawing.Size(180, 24);
            this.txtcusaddress.TabIndex = 38;
            // 
            // dtvgcus
            // 
            this.dtvgcus.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dtvgcus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvgcus.Location = new System.Drawing.Point(396, 154);
            this.dtvgcus.Name = "dtvgcus";
            this.dtvgcus.RowHeadersWidth = 51;
            this.dtvgcus.RowTemplate.Height = 24;
            this.dtvgcus.Size = new System.Drawing.Size(642, 401);
            this.dtvgcus.TabIndex = 36;
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Location = new System.Drawing.Point(159, 452);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(75, 38);
            this.btnhome.TabIndex = 35;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btneditcu
            // 
            this.btneditcu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btneditcu.FlatAppearance.BorderSize = 0;
            this.btneditcu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditcu.Location = new System.Drawing.Point(113, 397);
            this.btneditcu.Name = "btneditcu";
            this.btneditcu.Size = new System.Drawing.Size(75, 38);
            this.btneditcu.TabIndex = 34;
            this.btneditcu.Text = "Edit";
            this.btneditcu.UseVisualStyleBackColor = false;
            this.btneditcu.Click += new System.EventHandler(this.btneditcu_Click);
            // 
            // btncudelete
            // 
            this.btncudelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btncudelete.FlatAppearance.BorderSize = 0;
            this.btncudelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncudelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncudelete.Location = new System.Drawing.Point(207, 397);
            this.btncudelete.Name = "btncudelete";
            this.btncudelete.Size = new System.Drawing.Size(75, 38);
            this.btncudelete.TabIndex = 33;
            this.btncudelete.Text = "Delete";
            this.btncudelete.UseVisualStyleBackColor = false;
            this.btncudelete.Click += new System.EventHandler(this.btncudelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Full Name";
            // 
            // txtcusnumber
            // 
            this.txtcusnumber.BackColor = System.Drawing.SystemColors.Info;
            this.txtcusnumber.Location = new System.Drawing.Point(138, 306);
            this.txtcusnumber.Multiline = true;
            this.txtcusnumber.Name = "txtcusnumber";
            this.txtcusnumber.Size = new System.Drawing.Size(180, 24);
            this.txtcusnumber.TabIndex = 27;
            // 
            // txtcusfullname
            // 
            this.txtcusfullname.BackColor = System.Drawing.SystemColors.Info;
            this.txtcusfullname.Location = new System.Drawing.Point(138, 224);
            this.txtcusfullname.Multiline = true;
            this.txtcusfullname.Name = "txtcusfullname";
            this.txtcusfullname.Size = new System.Drawing.Size(180, 24);
            this.txtcusfullname.TabIndex = 25;
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblheader.Location = new System.Drawing.Point(436, 68);
            this.lblheader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(182, 31);
            this.lblheader.TabIndex = 40;
            this.lblheader.Text = "Customer  list";
            // 
            // lblheardermain
            // 
            this.lblheardermain.AutoSize = true;
            this.lblheardermain.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheardermain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblheardermain.Location = new System.Drawing.Point(242, 19);
            this.lblheardermain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblheardermain.Name = "lblheardermain";
            this.lblheardermain.Size = new System.Drawing.Size(615, 36);
            this.lblheardermain.TabIndex = 41;
            this.lblheardermain.Text = "Vehicle Service Center Management System";
            // 
            // btnshowcus
            // 
            this.btnshowcus.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnshowcus.FlatAppearance.BorderSize = 0;
            this.btnshowcus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshowcus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowcus.Location = new System.Drawing.Point(302, 397);
            this.btnshowcus.Name = "btnshowcus";
            this.btnshowcus.Size = new System.Drawing.Size(75, 38);
            this.btnshowcus.TabIndex = 42;
            this.btnshowcus.Text = "Show";
            this.btnshowcus.UseVisualStyleBackColor = false;
            this.btnshowcus.Click += new System.EventHandler(this.btnshowcus_Click);
            // 
            // btnaddcusm
            // 
            this.btnaddcusm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnaddcusm.FlatAppearance.BorderSize = 0;
            this.btnaddcusm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddcusm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddcusm.Location = new System.Drawing.Point(23, 397);
            this.btnaddcusm.Name = "btnaddcusm";
            this.btnaddcusm.Size = new System.Drawing.Size(75, 38);
            this.btnaddcusm.TabIndex = 43;
            this.btnaddcusm.Text = "Add";
            this.btnaddcusm.UseVisualStyleBackColor = false;
            this.btnaddcusm.Click += new System.EventHandler(this.btnaddcusm_Click);
            // 
            // btncuSearch
            // 
            this.btncuSearch.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btncuSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncuSearch.Location = new System.Drawing.Point(329, 224);
            this.btncuSearch.Name = "btncuSearch";
            this.btncuSearch.Size = new System.Drawing.Size(61, 26);
            this.btncuSearch.TabIndex = 44;
            this.btncuSearch.Text = "Search";
            this.btncuSearch.UseVisualStyleBackColor = false;
            this.btncuSearch.Click += new System.EventHandler(this.btncuSearch_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1088, 636);
            this.Controls.Add(this.btncuSearch);
            this.Controls.Add(this.btnaddcusm);
            this.Controls.Add(this.btnshowcus);
            this.Controls.Add(this.lblheardermain);
            this.Controls.Add(this.lblheader);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcusaddress);
            this.Controls.Add(this.dtvgcus);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btneditcu);
            this.Controls.Add(this.btncudelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcusnumber);
            this.Controls.Add(this.txtcusfullname);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customerfrm";
            ((System.ComponentModel.ISupportInitialize)(this.dtvgcus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcusaddress;
        private System.Windows.Forms.DataGridView dtvgcus;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btneditcu;
        private System.Windows.Forms.Button btncudelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcusnumber;
        private System.Windows.Forms.TextBox txtcusfullname;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Label lblheardermain;
        private System.Windows.Forms.Button btnshowcus;
        private System.Windows.Forms.Button btnaddcusm;
        private System.Windows.Forms.Button btncuSearch;
    }
}