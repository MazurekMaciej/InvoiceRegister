namespace InvoiceRegister.UI
{
    partial class InvoicesForm
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicesForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.refreshButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.addButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.editButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.editInvoicePanel1 = new InvoiceRegister.UI.EditInvoicePanel();
            this.addInvoicePanel31 = new InvoiceRegister.UI.AddInvoicePanel3();
            this.addInvoicePanel21 = new InvoiceRegister.UI.AddInvoicePanel2();
            this.addInvoicePanel1 = new InvoiceRegister.UI.AddInvoicePanel();
            this.listInvoicesPanel1 = new InvoiceRegister.ListInvoicesPanel();
            this.sidepanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sidepanel.Controls.Add(this.panel1);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(200, 587);
            this.sidepanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 75);
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.White;
            this.header.Controls.Add(this.exit);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(200, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(825, 75);
            this.header.TabIndex = 7;
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
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // refreshButton
            // 
            this.refreshButton.AllowToggling = false;
            this.refreshButton.AnimationSpeed = 200;
            this.refreshButton.AutoGenerateColors = false;
            this.refreshButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.refreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshButton.BackgroundImage")));
            this.refreshButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.refreshButton.ButtonText = "Odswiez";
            this.refreshButton.ButtonTextMarginLeft = 0;
            this.refreshButton.ColorContrastOnClick = 45;
            this.refreshButton.ColorContrastOnHover = 45;
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.refreshButton.CustomizableEdges = borderEdges3;
            this.refreshButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.refreshButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.refreshButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.refreshButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.refreshButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.refreshButton.IconMarginLeft = 11;
            this.refreshButton.IconPadding = 10;
            this.refreshButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.refreshButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.refreshButton.IdleBorderRadius = 1;
            this.refreshButton.IdleBorderThickness = 1;
            this.refreshButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.refreshButton.IdleIconLeftImage = null;
            this.refreshButton.IdleIconRightImage = null;
            this.refreshButton.IndicateFocus = false;
            this.refreshButton.Location = new System.Drawing.Point(747, 540);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.refreshButton.onHoverState.BorderRadius = 1;
            this.refreshButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.refreshButton.onHoverState.BorderThickness = 1;
            this.refreshButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.refreshButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.refreshButton.onHoverState.IconLeftImage = null;
            this.refreshButton.onHoverState.IconRightImage = null;
            this.refreshButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.refreshButton.OnIdleState.BorderRadius = 1;
            this.refreshButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.refreshButton.OnIdleState.BorderThickness = 1;
            this.refreshButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.refreshButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.refreshButton.OnIdleState.IconLeftImage = null;
            this.refreshButton.OnIdleState.IconRightImage = null;
            this.refreshButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.refreshButton.OnPressedState.BorderRadius = 1;
            this.refreshButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.refreshButton.OnPressedState.BorderThickness = 1;
            this.refreshButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.refreshButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.refreshButton.OnPressedState.IconLeftImage = null;
            this.refreshButton.OnPressedState.IconRightImage = null;
            this.refreshButton.Size = new System.Drawing.Size(150, 39);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.refreshButton.TextMarginLeft = 0;
            this.refreshButton.UseDefaultRadiusAndThickness = true;
            this.refreshButton.Visible = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addButton
            // 
            this.addButton.AllowToggling = false;
            this.addButton.AnimationSpeed = 200;
            this.addButton.AutoGenerateColors = false;
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.addButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton.BackgroundImage")));
            this.addButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addButton.ButtonText = "Utworz";
            this.addButton.ButtonTextMarginLeft = 0;
            this.addButton.ColorContrastOnClick = 45;
            this.addButton.ColorContrastOnHover = 45;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.addButton.CustomizableEdges = borderEdges2;
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.addButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.addButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.addButton.IconMarginLeft = 11;
            this.addButton.IconPadding = 10;
            this.addButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.addButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.addButton.IdleBorderRadius = 1;
            this.addButton.IdleBorderThickness = 1;
            this.addButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.addButton.IdleIconLeftImage = null;
            this.addButton.IdleIconRightImage = null;
            this.addButton.IndicateFocus = false;
            this.addButton.Location = new System.Drawing.Point(283, 540);
            this.addButton.Name = "addButton";
            this.addButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.addButton.onHoverState.BorderRadius = 1;
            this.addButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addButton.onHoverState.BorderThickness = 1;
            this.addButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.addButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.addButton.onHoverState.IconLeftImage = null;
            this.addButton.onHoverState.IconRightImage = null;
            this.addButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.addButton.OnIdleState.BorderRadius = 1;
            this.addButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addButton.OnIdleState.BorderThickness = 1;
            this.addButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.addButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.addButton.OnIdleState.IconLeftImage = null;
            this.addButton.OnIdleState.IconRightImage = null;
            this.addButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.addButton.OnPressedState.BorderRadius = 1;
            this.addButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addButton.OnPressedState.BorderThickness = 1;
            this.addButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.addButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.addButton.OnPressedState.IconLeftImage = null;
            this.addButton.OnPressedState.IconRightImage = null;
            this.addButton.Size = new System.Drawing.Size(150, 39);
            this.addButton.TabIndex = 15;
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addButton.TextMarginLeft = 0;
            this.addButton.UseDefaultRadiusAndThickness = true;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.AllowToggling = false;
            this.editButton.AnimationSpeed = 200;
            this.editButton.AutoGenerateColors = false;
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.editButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editButton.BackgroundImage")));
            this.editButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.editButton.ButtonText = "Edytuj";
            this.editButton.ButtonTextMarginLeft = 0;
            this.editButton.ColorContrastOnClick = 45;
            this.editButton.ColorContrastOnHover = 45;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.editButton.CustomizableEdges = borderEdges1;
            this.editButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.editButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.editButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.editButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.editButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.editButton.IconMarginLeft = 11;
            this.editButton.IconPadding = 10;
            this.editButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.editButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.editButton.IdleBorderRadius = 1;
            this.editButton.IdleBorderThickness = 1;
            this.editButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.editButton.IdleIconLeftImage = null;
            this.editButton.IdleIconRightImage = null;
            this.editButton.IndicateFocus = false;
            this.editButton.Location = new System.Drawing.Point(526, 540);
            this.editButton.Name = "editButton";
            this.editButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.editButton.onHoverState.BorderRadius = 1;
            this.editButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.editButton.onHoverState.BorderThickness = 1;
            this.editButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.editButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.editButton.onHoverState.IconLeftImage = null;
            this.editButton.onHoverState.IconRightImage = null;
            this.editButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.editButton.OnIdleState.BorderRadius = 1;
            this.editButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.editButton.OnIdleState.BorderThickness = 1;
            this.editButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.editButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.editButton.OnIdleState.IconLeftImage = null;
            this.editButton.OnIdleState.IconRightImage = null;
            this.editButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.editButton.OnPressedState.BorderRadius = 1;
            this.editButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.editButton.OnPressedState.BorderThickness = 1;
            this.editButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.editButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.editButton.OnPressedState.IconLeftImage = null;
            this.editButton.OnPressedState.IconRightImage = null;
            this.editButton.Size = new System.Drawing.Size(150, 39);
            this.editButton.TabIndex = 16;
            this.editButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editButton.TextMarginLeft = 0;
            this.editButton.UseDefaultRadiusAndThickness = true;
            this.editButton.Visible = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // editInvoicePanel1
            // 
            this.editInvoicePanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.editInvoicePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editInvoicePanel1.Location = new System.Drawing.Point(200, 75);
            this.editInvoicePanel1.Name = "editInvoicePanel1";
            this.editInvoicePanel1.Size = new System.Drawing.Size(825, 512);
            this.editInvoicePanel1.TabIndex = 14;
            this.editInvoicePanel1.Visible = false;
            // 
            // addInvoicePanel31
            // 
            this.addInvoicePanel31.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addInvoicePanel31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addInvoicePanel31.Location = new System.Drawing.Point(200, 75);
            this.addInvoicePanel31.Name = "addInvoicePanel31";
            this.addInvoicePanel31.Size = new System.Drawing.Size(825, 512);
            this.addInvoicePanel31.TabIndex = 13;
            this.addInvoicePanel31.Visible = false;
            // 
            // addInvoicePanel21
            // 
            this.addInvoicePanel21.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addInvoicePanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addInvoicePanel21.Location = new System.Drawing.Point(200, 75);
            this.addInvoicePanel21.Name = "addInvoicePanel21";
            this.addInvoicePanel21.Size = new System.Drawing.Size(825, 512);
            this.addInvoicePanel21.TabIndex = 12;
            this.addInvoicePanel21.Visible = false;
            // 
            // addInvoicePanel1
            // 
            this.addInvoicePanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addInvoicePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addInvoicePanel1.Location = new System.Drawing.Point(200, 75);
            this.addInvoicePanel1.Name = "addInvoicePanel1";
            this.addInvoicePanel1.Size = new System.Drawing.Size(825, 512);
            this.addInvoicePanel1.TabIndex = 11;
            this.addInvoicePanel1.Visible = false;
            // 
            // listInvoicesPanel1
            // 
            this.listInvoicesPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listInvoicesPanel1.Location = new System.Drawing.Point(199, 74);
            this.listInvoicesPanel1.Name = "listInvoicesPanel1";
            this.listInvoicesPanel1.Size = new System.Drawing.Size(825, 460);
            this.listInvoicesPanel1.TabIndex = 6;
            this.listInvoicesPanel1.Load += new System.EventHandler(this.listInvoicesPanel1_Load);
            this.listInvoicesPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listInvoicesPanel1_MouseClick);
            // 
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1025, 587);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.editInvoicePanel1);
            this.Controls.Add(this.addInvoicePanel31);
            this.Controls.Add(this.addInvoicePanel21);
            this.Controls.Add(this.addInvoicePanel1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.listInvoicesPanel1);
            this.Controls.Add(this.sidepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvoicesForm";
            this.Text = "InvoicesForm";
            this.Load += new System.EventHandler(this.InvoicesForm_Load);
            this.sidepanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private ListInvoicesPanel listInvoicesPanel1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuFlatButton exit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private AddInvoicePanel addInvoicePanel1;
        private AddInvoicePanel3 addInvoicePanel31;
        private AddInvoicePanel2 addInvoicePanel21;
        private EditInvoicePanel editInvoicePanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton refreshButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton editButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton addButton;
    }
}