namespace WindowsFormsApplication3
{
    partial class frmMain
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
            this.btnallcust = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.cryrptbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnallcust
            // 
            this.btnallcust.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnallcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnallcust.ForeColor = System.Drawing.Color.Black;
            this.btnallcust.Location = new System.Drawing.Point(130, 176);
            this.btnallcust.Name = "btnallcust";
            this.btnallcust.Size = new System.Drawing.Size(236, 192);
            this.btnallcust.TabIndex = 1;
            this.btnallcust.Text = "View \r\nAll Customers";
            this.btnallcust.UseVisualStyleBackColor = false;
            this.btnallcust.Click += new System.EventHandler(this.btnallcust_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(129, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 125);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADD NEW";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(247, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 125);
            this.button2.TabIndex = 3;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(366, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 125);
            this.button3.TabIndex = 4;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.CadetBlue;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(484, 52);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(119, 125);
            this.searchbtn.TabIndex = 5;
            this.searchbtn.Text = "SEARCH";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.OliveDrab;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(700, 390);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(119, 47);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Logout";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // cryrptbtn
            // 
            this.cryrptbtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.cryrptbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cryrptbtn.Location = new System.Drawing.Point(366, 176);
            this.cryrptbtn.Name = "cryrptbtn";
            this.cryrptbtn.Size = new System.Drawing.Size(237, 193);
            this.cryrptbtn.TabIndex = 6;
            this.cryrptbtn.Text = "Export Report";
            this.cryrptbtn.UseVisualStyleBackColor = false;
            this.cryrptbtn.Click += new System.EventHandler(this.cryrptbtn_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(831, 449);
            this.Controls.Add(this.cryrptbtn);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnallcust);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard -- Customer Information Management System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnallcust;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button cryrptbtn;
    }
}