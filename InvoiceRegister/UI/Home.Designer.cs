namespace InvoiceRegister
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.zarejestrujButton = new System.Windows.Forms.Label();
            this.zalogujButton = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.loginPanel1 = new InvoiceRegister.LoginPanel();
            this.registerPanel1 = new InvoiceRegister.RegisterPanel();
            this.listInvoicesPanel1 = new InvoiceRegister.ListInvoicesPanel();
            this.testListButton = new System.Windows.Forms.Label();
            this.sidepanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sidepanel.Controls.Add(this.testListButton);
            this.sidepanel.Controls.Add(this.zarejestrujButton);
            this.sidepanel.Controls.Add(this.zalogujButton);
            this.sidepanel.Controls.Add(this.panel1);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(200, 587);
            this.sidepanel.TabIndex = 0;
            // 
            // zarejestrujButton
            // 
            this.zarejestrujButton.AutoSize = true;
            this.zarejestrujButton.BackColor = System.Drawing.Color.Transparent;
            this.zarejestrujButton.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zarejestrujButton.ForeColor = System.Drawing.Color.White;
            this.zarejestrujButton.Location = new System.Drawing.Point(39, 180);
            this.zarejestrujButton.Name = "zarejestrujButton";
            this.zarejestrujButton.Size = new System.Drawing.Size(117, 25);
            this.zarejestrujButton.TabIndex = 4;
            this.zarejestrujButton.Text = "Zarejestruj";
            this.zarejestrujButton.Click += new System.EventHandler(this.zarejestrujButton_Click);
            // 
            // zalogujButton
            // 
            this.zalogujButton.AutoSize = true;
            this.zalogujButton.BackColor = System.Drawing.Color.Transparent;
            this.zalogujButton.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zalogujButton.ForeColor = System.Drawing.Color.White;
            this.zalogujButton.Location = new System.Drawing.Point(55, 119);
            this.zalogujButton.Name = "zalogujButton";
            this.zalogujButton.Size = new System.Drawing.Size(87, 25);
            this.zalogujButton.TabIndex = 3;
            this.zalogujButton.Text = "Zaloguj";
            this.zalogujButton.Click += new System.EventHandler(this.zalogujButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 75);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rejestr faktur";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.White;
            this.header.Controls.Add(this.exit);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(200, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(825, 75);
            this.header.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.Active = false;
            this.exit.Activecolor = System.Drawing.Color.White;
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.BorderRadius = 0;
            this.exit.ButtonText = "X";
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.DisabledColor = System.Drawing.Color.Gray;
            this.exit.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit.Iconcolor = System.Drawing.Color.Transparent;
            this.exit.Iconimage = null;
            this.exit.Iconimage_right = null;
            this.exit.Iconimage_right_Selected = null;
            this.exit.Iconimage_Selected = null;
            this.exit.IconMarginLeft = 0;
            this.exit.IconMarginRight = 0;
            this.exit.IconRightVisible = true;
            this.exit.IconRightZoom = 0D;
            this.exit.IconVisible = true;
            this.exit.IconZoom = 90D;
            this.exit.IsTab = false;
            this.exit.Location = new System.Drawing.Point(789, 13);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exit.Name = "exit";
            this.exit.Normalcolor = System.Drawing.Color.White;
            this.exit.OnHovercolor = System.Drawing.Color.White;
            this.exit.OnHoverTextColor = System.Drawing.Color.Black;
            this.exit.selected = false;
            this.exit.Size = new System.Drawing.Size(23, 33);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Textcolor = System.Drawing.Color.Black;
            this.exit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // loginPanel1
            // 
            this.loginPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel1.Location = new System.Drawing.Point(200, 75);
            this.loginPanel1.Name = "loginPanel1";
            this.loginPanel1.Size = new System.Drawing.Size(825, 512);
            this.loginPanel1.TabIndex = 2;
            this.loginPanel1.Visible = false;
            // 
            // registerPanel1
            // 
            this.registerPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerPanel1.Location = new System.Drawing.Point(200, 75);
            this.registerPanel1.Name = "registerPanel1";
            this.registerPanel1.Size = new System.Drawing.Size(825, 512);
            this.registerPanel1.TabIndex = 3;
            this.registerPanel1.Visible = false;
            // 
            // listInvoicesPanel1
            // 
            this.listInvoicesPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listInvoicesPanel1.Location = new System.Drawing.Point(200, 75);
            this.listInvoicesPanel1.Name = "listInvoicesPanel1";
            this.listInvoicesPanel1.Size = new System.Drawing.Size(825, 512);
            this.listInvoicesPanel1.TabIndex = 4;
            this.listInvoicesPanel1.Visible = false;
            // 
            // testListButton
            // 
            this.testListButton.AutoSize = true;
            this.testListButton.BackColor = System.Drawing.Color.Transparent;
            this.testListButton.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.testListButton.ForeColor = System.Drawing.Color.White;
            this.testListButton.Location = new System.Drawing.Point(57, 281);
            this.testListButton.Name = "testListButton";
            this.testListButton.Size = new System.Drawing.Size(51, 25);
            this.testListButton.TabIndex = 5;
            this.testListButton.Text = "Test";
            this.testListButton.Click += new System.EventHandler(this.testListButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1025, 587);
            this.Controls.Add(this.listInvoicesPanel1);
            this.Controls.Add(this.registerPanel1);
            this.Controls.Add(this.loginPanel1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.sidepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.sidepanel.ResumeLayout(false);
            this.sidepanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton exit;
        private System.Windows.Forms.Label zarejestrujButton;
        private System.Windows.Forms.Label zalogujButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private RegisterPanel registerPanel1;
        private LoginPanel loginPanel1;
        private ListInvoicesPanel listInvoicesPanel1;
        private System.Windows.Forms.Label testListButton;
    }
}

