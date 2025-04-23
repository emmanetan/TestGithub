namespace TestGithub
{
    partial class Test
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
            this.btnProduct = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.btnUser = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.btnReport = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.Label = new System.Windows.Forms.Label();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.mainpanel = new Siticone.UI.WinForms.SiticonePanel();
            this.btnLogout = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.sidepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProduct
            // 
            this.btnProduct.CheckedState.Parent = this.btnProduct;
            this.btnProduct.CustomImages.Parent = this.btnProduct;
            this.btnProduct.FillColor = System.Drawing.Color.Gray;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.HoveredState.Parent = this.btnProduct;
            this.btnProduct.Location = new System.Drawing.Point(12, 214);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.ShadowDecoration.Parent = this.btnProduct;
            this.btnProduct.Size = new System.Drawing.Size(233, 56);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "Product";
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnUser
            // 
            this.btnUser.CheckedState.Parent = this.btnUser;
            this.btnUser.CustomImages.Parent = this.btnUser;
            this.btnUser.FillColor = System.Drawing.Color.Gray;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.HoveredState.Parent = this.btnUser;
            this.btnUser.Location = new System.Drawing.Point(12, 276);
            this.btnUser.Name = "btnUser";
            this.btnUser.ShadowDecoration.Parent = this.btnUser;
            this.btnUser.Size = new System.Drawing.Size(233, 56);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "User";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnReport
            // 
            this.btnReport.CheckedState.Parent = this.btnReport;
            this.btnReport.CustomImages.Parent = this.btnReport;
            this.btnReport.FillColor = System.Drawing.Color.Gray;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.HoveredState.Parent = this.btnReport;
            this.btnReport.Location = new System.Drawing.Point(12, 338);
            this.btnReport.Name = "btnReport";
            this.btnReport.ShadowDecoration.Parent = this.btnReport;
            this.btnReport.Size = new System.Drawing.Size(233, 56);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Report";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.BackColor = System.Drawing.Color.Transparent;
            this.Label.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label.Location = new System.Drawing.Point(67, 57);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(133, 20);
            this.Label.TabIndex = 3;
            this.Label.Text = "Inventory System";
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sidepanel.Controls.Add(this.btnLogout);
            this.sidepanel.Controls.Add(this.btnReport);
            this.sidepanel.Controls.Add(this.Label);
            this.sidepanel.Controls.Add(this.btnProduct);
            this.sidepanel.Controls.Add(this.btnUser);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(261, 784);
            this.sidepanel.TabIndex = 4;
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(261, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.ShadowDecoration.Parent = this.mainpanel;
            this.mainpanel.Size = new System.Drawing.Size(1042, 784);
            this.mainpanel.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.Gray;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoveredState.Parent = this.btnLogout;
            this.btnLogout.Location = new System.Drawing.Point(71, 718);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(114, 44);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 784);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.sidepanel);
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sidepanel.ResumeLayout(false);
            this.sidepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Label;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnReport;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnUser;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnProduct;
        private System.Windows.Forms.Panel sidepanel;
        private Siticone.UI.WinForms.SiticonePanel mainpanel;
        private Siticone.UI.WinForms.SiticoneRoundedButton btnLogout;
    }
}

