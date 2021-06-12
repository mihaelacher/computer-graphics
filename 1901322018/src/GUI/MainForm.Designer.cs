namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.regroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeBorderColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeTransperancyColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeBorderWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusBar = new System.Windows.Forms.StatusStrip();
			this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.speedMenu = new System.Windows.Forms.ToolStrip();
			this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
			this.drawSquareSpeedButton = new System.Windows.Forms.ToolStripButton();
			this.drawEllipseSpeedButton = new System.Windows.Forms.ToolStripButton();
			this.drawCircleSpeedButton = new System.Windows.Forms.ToolStripButton();
			this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
			this.rotateShapeSpeedButton = new System.Windows.Forms.ToolStripButton();
			this.resizeSpeedButton = new System.Windows.Forms.ToolStripButton();
			this.viewPort = new Draw.DoubleBufferedPanel();
			this.mainMenu.SuspendLayout();
			this.statusBar.SuspendLayout();
			this.speedMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu
			// 
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.editToolStripMenuItem,
									this.imageToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(693, 24);
			this.mainMenu.TabIndex = 1;
			this.mainMenu.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.saveToolStripMenuItem,
									this.importToolStripMenuItem,
									this.groupToolStripMenuItem,
									this.regroupToolStripMenuItem,
									this.selectGroupToolStripMenuItem,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
			// 
			// importToolStripMenuItem
			// 
			this.importToolStripMenuItem.Name = "importToolStripMenuItem";
			this.importToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.importToolStripMenuItem.Text = "Import file";
			this.importToolStripMenuItem.Click += new System.EventHandler(this.ImportToolStripMenuItemClick);
			// 
			// groupToolStripMenuItem
			// 
			this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
			this.groupToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.groupToolStripMenuItem.Text = "Group items";
			this.groupToolStripMenuItem.Click += new System.EventHandler(this.GroupToolStripMenuItemClick);
			// 
			// regroupToolStripMenuItem
			// 
			this.regroupToolStripMenuItem.Name = "regroupToolStripMenuItem";
			this.regroupToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.regroupToolStripMenuItem.Text = "Regroup items";
			this.regroupToolStripMenuItem.Click += new System.EventHandler(this.RegroupToolStripMenuItemClick);
			// 
			// selectGroupToolStripMenuItem
			// 
			this.selectGroupToolStripMenuItem.Name = "selectGroupToolStripMenuItem";
			this.selectGroupToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.selectGroupToolStripMenuItem.Text = "Select group items";
			this.selectGroupToolStripMenuItem.Click += new System.EventHandler(this.SelectGroupToolStripMenuItemClick);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.changeBorderColorToolStripMenuItem,
									this.changeTransperancyColorToolStripMenuItem,
									this.changeBorderWidthToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// changeBorderColorToolStripMenuItem
			// 
			this.changeBorderColorToolStripMenuItem.Name = "changeBorderColorToolStripMenuItem";
			this.changeBorderColorToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.changeBorderColorToolStripMenuItem.Text = "Change border Color";
			this.changeBorderColorToolStripMenuItem.Click += new System.EventHandler(this.ChangeBorderColorToolStripMenuItemClick);
			// 
			// changeTransperancyColorToolStripMenuItem
			// 
			this.changeTransperancyColorToolStripMenuItem.Name = "changeTransperancyColorToolStripMenuItem";
			this.changeTransperancyColorToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.changeTransperancyColorToolStripMenuItem.Text = "Change transperancy of Color";
			this.changeTransperancyColorToolStripMenuItem.Click += new System.EventHandler(this.ChangeTransperancyColorToolStripMenuItemClick);
			// 
			// changeBorderWidthToolStripMenuItem
			// 
			this.changeBorderWidthToolStripMenuItem.Name = "changeBorderWidthToolStripMenuItem";
			this.changeBorderWidthToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.changeBorderWidthToolStripMenuItem.Text = "Change border width";
			this.changeBorderWidthToolStripMenuItem.Click += new System.EventHandler(this.ChangeBorderWidthToolStripMenuItemClick);
			// 
			// imageToolStripMenuItem
			// 
			this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
			this.imageToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
			this.imageToolStripMenuItem.Text = "Image";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
			this.aboutToolStripMenuItem.Text = "About...";
			// 
			// statusBar
			// 
			this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.currentStatusLabel});
			this.statusBar.Location = new System.Drawing.Point(0, 401);
			this.statusBar.Name = "statusBar";
			this.statusBar.Size = new System.Drawing.Size(693, 22);
			this.statusBar.TabIndex = 2;
			this.statusBar.Text = "statusStrip1";
			// 
			// currentStatusLabel
			// 
			this.currentStatusLabel.Name = "currentStatusLabel";
			this.currentStatusLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// speedMenu
			// 
			this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.drawRectangleSpeedButton,
									this.drawSquareSpeedButton,
									this.drawEllipseSpeedButton,
									this.drawCircleSpeedButton,
									this.pickUpSpeedButton,
									this.rotateShapeSpeedButton,
									this.resizeSpeedButton});
			this.speedMenu.Location = new System.Drawing.Point(0, 24);
			this.speedMenu.Name = "speedMenu";
			this.speedMenu.Size = new System.Drawing.Size(693, 25);
			this.speedMenu.TabIndex = 3;
			this.speedMenu.Text = "toolStrip1";
			// 
			// drawRectangleSpeedButton
			// 
			this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
			this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
			this.drawRectangleSpeedButton.Size = new System.Drawing.Size(23, 22);
			this.drawRectangleSpeedButton.Text = "DrawRectangleButton";
			this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
			// 
			// drawSquareSpeedButton
			// 
			this.drawSquareSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.drawSquareSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawSquareSpeedButton.Image")));
			this.drawSquareSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.drawSquareSpeedButton.Name = "drawSquareSpeedButton";
			this.drawSquareSpeedButton.Size = new System.Drawing.Size(23, 22);
			this.drawSquareSpeedButton.Text = "DrawSquareSpeedButton";
			this.drawSquareSpeedButton.Click += new System.EventHandler(this.DrawSquareSpeedButtonClick);

			// 
			// drawEllipseSpeedButton
			// 
			this.drawEllipseSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.drawEllipseSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawEllipseSpeedButton.Image")));
			this.drawEllipseSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.drawEllipseSpeedButton.Name = "drawEllipseSpeedButton";
			this.drawEllipseSpeedButton.Size = new System.Drawing.Size(23, 22);
			this.drawEllipseSpeedButton.Text = "DrawEllipseSpeedButton";
			this.drawEllipseSpeedButton.Click += new System.EventHandler(this.DrawEllipseSpeedButtonClick);
			// 
			// drawCircleSpeedButton
			// 
			this.drawCircleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.drawCircleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawCircleSpeedButton.Image")));
			this.drawCircleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.drawCircleSpeedButton.Name = "drawCircleSpeedButton";
			this.drawCircleSpeedButton.Size = new System.Drawing.Size(23, 22);
			this.drawCircleSpeedButton.Text = "drawCircleSpeedButton";
			this.drawCircleSpeedButton.Click += new System.EventHandler(this.DrawCircleSpeedButtonClick);
			// 
			// pickUpSpeedButton
			// 
			this.pickUpSpeedButton.CheckOnClick = true;
			this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
			this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pickUpSpeedButton.Name = "pickUpSpeedButton";
			this.pickUpSpeedButton.Size = new System.Drawing.Size(23, 22);
			this.pickUpSpeedButton.Text = "toolStripButton1";
			// 
			// rotateShapeSpeedButton
			// 
			this.rotateShapeSpeedButton.CheckOnClick = true;
			this.rotateShapeSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.rotateShapeSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("rotateShapeSpeedButton.Image")));
			this.rotateShapeSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.rotateShapeSpeedButton.Name = "rotateShapeSpeedButton";
			this.rotateShapeSpeedButton.Size = new System.Drawing.Size(23, 22);
			this.rotateShapeSpeedButton.Text = "rotateShapeSpeedButton";
			// 
			// resizeSpeedButton
			// 
			this.resizeSpeedButton.CheckOnClick = true;
			this.resizeSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.resizeSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("resizeSpeedButton.Image")));
			this.resizeSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.resizeSpeedButton.Name = "resizeSpeedButton";
			this.resizeSpeedButton.Size = new System.Drawing.Size(23, 22);
			this.resizeSpeedButton.Text = "resizeSpeedButton";
			// 
			// viewPort
			// 
			this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
			this.viewPort.Location = new System.Drawing.Point(0, 49);
			this.viewPort.Name = "viewPort";
			this.viewPort.Size = new System.Drawing.Size(693, 352);
			this.viewPort.TabIndex = 4;
			this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
			this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
			this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
			this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
			this.viewPort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
			this.viewPort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
			this.viewPort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownDeleteAll);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(693, 423);
			this.Controls.Add(this.viewPort);
			this.Controls.Add(this.speedMenu);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.mainMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mainMenu;
			this.Name = "MainForm";
			this.Text = "Draw";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.statusBar.ResumeLayout(false);
			this.statusBar.PerformLayout();
			this.speedMenu.ResumeLayout(false);
			this.speedMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripButton rotateShapeSpeedButton;
		private System.Windows.Forms.ToolStripButton resizeSpeedButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStripButton drawSquareSpeedButton;
		private System.Windows.Forms.ToolStripButton drawEllipseSpeedButton;
		private System.Windows.Forms.ToolStripButton drawCircleSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeBorderColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeTransperancyColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeBorderWidthToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem regroupToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectGroupToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
	}
}
