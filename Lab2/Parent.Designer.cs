namespace Lab2
{
    partial class Parent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAllChildrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllChildrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeAllChildrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbltssName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTssColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip,
            this.selectColorToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "Child Forms";
            // 
            // menuStrip
            // 
            this.menuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewChildToolStripMenuItem,
            this.listAllChildrenToolStripMenuItem,
            this.closeAllChildrenToolStripMenuItem,
            this.cascadeAllChildrenToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(83, 20);
            this.menuStrip.Text = "Child Forms";
            // 
            // createNewChildToolStripMenuItem
            // 
            this.createNewChildToolStripMenuItem.Name = "createNewChildToolStripMenuItem";
            this.createNewChildToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.createNewChildToolStripMenuItem.Text = "Create New Child";
            this.createNewChildToolStripMenuItem.Click += new System.EventHandler(this.createNewChildToolStripMenuItem_Click);
            // 
            // listAllChildrenToolStripMenuItem
            // 
            this.listAllChildrenToolStripMenuItem.Name = "listAllChildrenToolStripMenuItem";
            this.listAllChildrenToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.listAllChildrenToolStripMenuItem.Text = "List All Children";
            this.listAllChildrenToolStripMenuItem.Click += new System.EventHandler(this.listAllChildrenToolStripMenuItem_Click);
            // 
            // closeAllChildrenToolStripMenuItem
            // 
            this.closeAllChildrenToolStripMenuItem.Name = "closeAllChildrenToolStripMenuItem";
            this.closeAllChildrenToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.closeAllChildrenToolStripMenuItem.Text = "Close All Children";
            this.closeAllChildrenToolStripMenuItem.Click += new System.EventHandler(this.closeAllChildrenToolStripMenuItem_Click);
            // 
            // cascadeAllChildrenToolStripMenuItem
            // 
            this.cascadeAllChildrenToolStripMenuItem.Name = "cascadeAllChildrenToolStripMenuItem";
            this.cascadeAllChildrenToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cascadeAllChildrenToolStripMenuItem.Text = "Cascade All Children";
            this.cascadeAllChildrenToolStripMenuItem.Click += new System.EventHandler(this.cascadeAllChildrenToolStripMenuItem_Click);
            // 
            // selectColorToolStripMenuItem
            // 
            this.selectColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.customToolStripMenuItem});
            this.selectColorToolStripMenuItem.Name = "selectColorToolStripMenuItem";
            this.selectColorToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.selectColorToolStripMenuItem.Text = "Select Color";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.customToolStripMenuItem.Text = "Custom";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbltssName,
            this.lblTssColor});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbltssName
            // 
            this.lbltssName.Name = "lbltssName";
            this.lbltssName.Size = new System.Drawing.Size(106, 17);
            this.lbltssName.Text = "Active Child: None";
            // 
            // lblTssColor
            // 
            this.lblTssColor.Name = "lblTssColor";
            this.lblTssColor.Size = new System.Drawing.Size(0, 17);
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Parent";
            this.Text = "Parent Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Parent_FormClosed);
            this.MdiChildActivate += new System.EventHandler(this.Parent_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStrip;
        private System.Windows.Forms.ToolStripMenuItem createNewChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAllChildrenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllChildrenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeAllChildrenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbltssName;
        private System.Windows.Forms.ToolStripStatusLabel lblTssColor;
    }
}

