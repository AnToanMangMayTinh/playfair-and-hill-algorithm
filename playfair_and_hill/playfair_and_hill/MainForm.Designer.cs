namespace playfair_and_hill
{
    partial class MainForm
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
            this.metroTabPanel2 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.collapsibleSplitContainer1 = new DevComponents.DotNetBar.Controls.CollapsibleSplitContainer();
            this.btnDecrypt = new DevComponents.DotNetBar.ButtonX();
            this.btnEncrypt = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn6x6 = new System.Windows.Forms.RadioButton();
            this.rbtn5x5 = new System.Windows.Forms.RadioButton();
            this.flptxt = new System.Windows.Forms.FlowLayoutPanel();
            this.txtKey = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtCipherText = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtPlainTextAfter = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtPlainText = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.metroTabPanel1 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.metroShell1 = new DevComponents.DotNetBar.Metro.MetroShell();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.metroAppButton1 = new DevComponents.DotNetBar.Metro.MetroAppButton();
            this.metroTabItem2 = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.metroTabItem1 = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.metroTabPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collapsibleSplitContainer1)).BeginInit();
            this.collapsibleSplitContainer1.Panel1.SuspendLayout();
            this.collapsibleSplitContainer1.Panel2.SuspendLayout();
            this.collapsibleSplitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroShell1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabPanel2
            // 
            this.metroTabPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel2.Controls.Add(this.collapsibleSplitContainer1);
            this.metroTabPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel2.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel2.Name = "metroTabPanel2";
            this.metroTabPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel2.Size = new System.Drawing.Size(810, 434);
            // 
            // 
            // 
            this.metroTabPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel2.TabIndex = 2;
            // 
            // collapsibleSplitContainer1
            // 
            this.collapsibleSplitContainer1.BackColor = System.Drawing.Color.White;
            this.collapsibleSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collapsibleSplitContainer1.ForeColor = System.Drawing.Color.Black;
            this.collapsibleSplitContainer1.Location = new System.Drawing.Point(3, 0);
            this.collapsibleSplitContainer1.Name = "collapsibleSplitContainer1";
            // 
            // collapsibleSplitContainer1.Panel1
            // 
            this.collapsibleSplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.collapsibleSplitContainer1.Panel1.Controls.Add(this.btnDecrypt);
            this.collapsibleSplitContainer1.Panel1.Controls.Add(this.btnEncrypt);
            this.collapsibleSplitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.collapsibleSplitContainer1.Panel1.Controls.Add(this.txtKey);
            this.collapsibleSplitContainer1.Panel1.Controls.Add(this.labelX1);
            this.collapsibleSplitContainer1.Panel1.ForeColor = System.Drawing.Color.Black;
            // 
            // collapsibleSplitContainer1.Panel2
            // 
            this.collapsibleSplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.collapsibleSplitContainer1.Panel2.Controls.Add(this.txtCipherText);
            this.collapsibleSplitContainer1.Panel2.Controls.Add(this.labelX4);
            this.collapsibleSplitContainer1.Panel2.Controls.Add(this.txtPlainTextAfter);
            this.collapsibleSplitContainer1.Panel2.Controls.Add(this.labelX3);
            this.collapsibleSplitContainer1.Panel2.Controls.Add(this.txtPlainText);
            this.collapsibleSplitContainer1.Panel2.Controls.Add(this.labelX2);
            this.collapsibleSplitContainer1.Panel2.ForeColor = System.Drawing.Color.Black;
            this.collapsibleSplitContainer1.Size = new System.Drawing.Size(804, 431);
            this.collapsibleSplitContainer1.SplitterDistance = 376;
            this.collapsibleSplitContainer1.SplitterWidth = 20;
            this.collapsibleSplitContainer1.TabIndex = 0;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDecrypt.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.Location = new System.Drawing.Point(200, 367);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(111, 33);
            this.btnDecrypt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "DECRYPT";
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEncrypt.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Location = new System.Drawing.Point(40, 367);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(111, 33);
            this.btnEncrypt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "ENCRYPT";
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbtn6x6);
            this.groupBox1.Controls.Add(this.rbtn5x5);
            this.groupBox1.Controls.Add(this.flptxt);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 266);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matrix Key";
            // 
            // rbtn6x6
            // 
            this.rbtn6x6.AutoSize = true;
            this.rbtn6x6.ForeColor = System.Drawing.Color.Black;
            this.rbtn6x6.Location = new System.Drawing.Point(292, 45);
            this.rbtn6x6.Name = "rbtn6x6";
            this.rbtn6x6.Size = new System.Drawing.Size(42, 17);
            this.rbtn6x6.TabIndex = 2;
            this.rbtn6x6.TabStop = true;
            this.rbtn6x6.Text = "6x6";
            this.rbtn6x6.UseVisualStyleBackColor = true;
            this.rbtn6x6.CheckedChanged += new System.EventHandler(this.rbtn6x6_CheckedChanged);
            // 
            // rbtn5x5
            // 
            this.rbtn5x5.AutoSize = true;
            this.rbtn5x5.ForeColor = System.Drawing.Color.Black;
            this.rbtn5x5.Location = new System.Drawing.Point(292, 22);
            this.rbtn5x5.Name = "rbtn5x5";
            this.rbtn5x5.Size = new System.Drawing.Size(42, 17);
            this.rbtn5x5.TabIndex = 1;
            this.rbtn5x5.TabStop = true;
            this.rbtn5x5.Text = "5x5";
            this.rbtn5x5.UseVisualStyleBackColor = true;
            this.rbtn5x5.CheckedChanged += new System.EventHandler(this.rbtn5x5_CheckedChanged);
            // 
            // flptxt
            // 
            this.flptxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.flptxt.ForeColor = System.Drawing.Color.Black;
            this.flptxt.Location = new System.Drawing.Point(7, 22);
            this.flptxt.Name = "flptxt";
            this.flptxt.Size = new System.Drawing.Size(256, 228);
            this.flptxt.TabIndex = 0;
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtKey.Border.Class = "TextBoxBorder";
            this.txtKey.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtKey.DisabledBackColor = System.Drawing.Color.White;
            this.txtKey.ForeColor = System.Drawing.Color.Black;
            this.txtKey.Location = new System.Drawing.Point(40, 19);
            this.txtKey.Name = "txtKey";
            this.txtKey.PreventEnterBeep = true;
            this.txtKey.Size = new System.Drawing.Size(327, 22);
            this.txtKey.TabIndex = 1;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged_1);
            this.txtKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKey_KeyPress);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(12, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(38, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Key:";
            // 
            // txtCipherText
            // 
            this.txtCipherText.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCipherText.Border.Class = "TextBoxBorder";
            this.txtCipherText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCipherText.DisabledBackColor = System.Drawing.Color.White;
            this.txtCipherText.ForeColor = System.Drawing.Color.Black;
            this.txtCipherText.Location = new System.Drawing.Point(17, 319);
            this.txtCipherText.Multiline = true;
            this.txtCipherText.Name = "txtCipherText";
            this.txtCipherText.PreventEnterBeep = true;
            this.txtCipherText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCipherText.Size = new System.Drawing.Size(370, 100);
            this.txtCipherText.TabIndex = 9;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(17, 290);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(160, 23);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "Chuỗi sau mã hóa/giải mã:";
            // 
            // txtPlainTextAfter
            // 
            this.txtPlainTextAfter.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPlainTextAfter.Border.Class = "TextBoxBorder";
            this.txtPlainTextAfter.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPlainTextAfter.DisabledBackColor = System.Drawing.Color.White;
            this.txtPlainTextAfter.ForeColor = System.Drawing.Color.Black;
            this.txtPlainTextAfter.Location = new System.Drawing.Point(17, 179);
            this.txtPlainTextAfter.Multiline = true;
            this.txtPlainTextAfter.Name = "txtPlainTextAfter";
            this.txtPlainTextAfter.PreventEnterBeep = true;
            this.txtPlainTextAfter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlainTextAfter.Size = new System.Drawing.Size(370, 100);
            this.txtPlainTextAfter.TabIndex = 7;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(17, 150);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(109, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Chuỗi sau khi tách:";
            // 
            // txtPlainText
            // 
            this.txtPlainText.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPlainText.Border.Class = "TextBoxBorder";
            this.txtPlainText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPlainText.DisabledBackColor = System.Drawing.Color.White;
            this.txtPlainText.ForeColor = System.Drawing.Color.Black;
            this.txtPlainText.Location = new System.Drawing.Point(17, 44);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.PreventEnterBeep = true;
            this.txtPlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlainText.Size = new System.Drawing.Size(370, 100);
            this.txtPlainText.TabIndex = 5;
            this.txtPlainText.TextChanged += new System.EventHandler(this.txtPlainText_TextChanged);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(17, 16);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(85, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Chuỗi ban đầu:";
            // 
            // metroTabPanel1
            // 
            this.metroTabPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroTabPanel1.Name = "metroTabPanel1";
            this.metroTabPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel1.Size = new System.Drawing.Size(804, 485);
            // 
            // 
            // 
            this.metroTabPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel1.TabIndex = 1;
            this.metroTabPanel1.Visible = false;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // metroShell1
            // 
            this.metroShell1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroShell1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroShell1.CaptionVisible = true;
            this.metroShell1.Controls.Add(this.metroTabPanel2);
            this.metroShell1.Controls.Add(this.metroTabPanel1);
            this.metroShell1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroShell1.ForeColor = System.Drawing.Color.Black;
            this.metroShell1.HelpButtonText = null;
            this.metroShell1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1,
            this.metroTabItem2,
            this.metroTabItem1});
            this.metroShell1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.metroShell1.Location = new System.Drawing.Point(1, 1);
            this.metroShell1.Name = "metroShell1";
            this.metroShell1.Size = new System.Drawing.Size(810, 485);
            this.metroShell1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.metroShell1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.metroShell1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.metroShell1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.metroShell1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.metroShell1.SystemText.QatDialogAddButton = "&Add >>";
            this.metroShell1.SystemText.QatDialogCancelButton = "Cancel";
            this.metroShell1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.metroShell1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.metroShell1.SystemText.QatDialogOkButton = "OK";
            this.metroShell1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatDialogRemoveButton = "&Remove";
            this.metroShell1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.metroShell1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.metroShell1.TabIndex = 0;
            this.metroShell1.TabStripFont = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroShell1.Text = "metroShell1";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroAppButton1});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroAppButton1
            // 
            this.metroAppButton1.AutoExpandOnClick = true;
            this.metroAppButton1.CanCustomize = false;
            this.metroAppButton1.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.metroAppButton1.ImagePaddingHorizontal = 0;
            this.metroAppButton1.ImagePaddingVertical = 0;
            this.metroAppButton1.Name = "metroAppButton1";
            this.metroAppButton1.ShowSubItems = false;
            this.metroAppButton1.Text = "&File";
            // 
            // metroTabItem2
            // 
            this.metroTabItem2.Checked = true;
            this.metroTabItem2.Name = "metroTabItem2";
            this.metroTabItem2.Panel = this.metroTabPanel2;
            this.metroTabItem2.Text = "&PLAYFAIR";
            // 
            // metroTabItem1
            // 
            this.metroTabItem1.Name = "metroTabItem1";
            this.metroTabItem1.Panel = this.metroTabPanel1;
            this.metroTabItem1.Text = "&HILL";
            // 
            // metroStatusBar1
            // 
            this.metroStatusBar1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            this.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar1.DragDropSupport = true;
            this.metroStatusBar1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar1.ForeColor = System.Drawing.Color.Black;
            this.metroStatusBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1});
            this.metroStatusBar1.Location = new System.Drawing.Point(1, 489);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(810, 24);
            this.metroStatusBar1.TabIndex = 1;
            this.metroStatusBar1.Text = "metroStatusBar1";
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "Ready";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 514);
            this.Controls.Add(this.metroStatusBar1);
            this.Controls.Add(this.metroShell1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Encypt And Decrypt App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroTabPanel2.ResumeLayout(false);
            this.collapsibleSplitContainer1.Panel1.ResumeLayout(false);
            this.collapsibleSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.collapsibleSplitContainer1)).EndInit();
            this.collapsibleSplitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroShell1.ResumeLayout(false);
            this.metroShell1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel2;
        private DevComponents.DotNetBar.Controls.CollapsibleSplitContainer collapsibleSplitContainer1;
        private DevComponents.DotNetBar.ButtonX btnDecrypt;
        private DevComponents.DotNetBar.ButtonX btnEncrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn6x6;
        private System.Windows.Forms.RadioButton rbtn5x5;
        private System.Windows.Forms.FlowLayoutPanel flptxt;
        private DevComponents.DotNetBar.Controls.TextBoxX txtKey;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCipherText;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPlainTextAfter;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPlainText;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel1;
        private DevComponents.DotNetBar.Metro.MetroShell metroShell1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroAppButton metroAppButton1;
        private DevComponents.DotNetBar.Metro.MetroTabItem metroTabItem2;
        private DevComponents.DotNetBar.Metro.MetroTabItem metroTabItem1;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
    }
}

