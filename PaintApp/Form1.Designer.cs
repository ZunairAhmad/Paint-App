namespace PaintApp
{
    partial class Form1
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
            this.SidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Fill = new System.Windows.Forms.Button();
            this.btn_Pen = new System.Windows.Forms.Button();
            this.btn_Erase = new System.Windows.Forms.Button();
            this.btn_Circle = new System.Windows.Forms.Button();
            this.btn_Sqr = new System.Windows.Forms.Button();
            this.btn_Line = new System.Windows.Forms.Button();
            this.btn_Arc = new System.Windows.Forms.Button();
            this.btn_Brush = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PicPannel = new System.Windows.Forms.PictureBox();
            this.PicColor = new System.Windows.Forms.Button();
            this.shapeBtn = new System.Windows.Forms.Button();
            this.SidePanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPannel)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Silver;
            this.SidePanel.Controls.Add(this.btn_Fill);
            this.SidePanel.Controls.Add(this.btn_Pen);
            this.SidePanel.Controls.Add(this.btn_Erase);
            this.SidePanel.Controls.Add(this.btn_Circle);
            this.SidePanel.Controls.Add(this.btn_Sqr);
            this.SidePanel.Controls.Add(this.btn_Line);
            this.SidePanel.Controls.Add(this.btn_Arc);
            this.SidePanel.Controls.Add(this.btn_Brush);
            this.SidePanel.Controls.Add(this.btn_Clear);
            this.SidePanel.Controls.Add(this.shapeBtn);
            this.SidePanel.Controls.Add(this.PicColor);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 24);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(145, 487);
            this.SidePanel.TabIndex = 1;
            // 
            // btn_Fill
            // 
            this.btn_Fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_Fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fill.Image = global::PaintApp.Properties.Resources.paint_bucket;
            this.btn_Fill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Fill.Location = new System.Drawing.Point(3, 3);
            this.btn_Fill.Name = "btn_Fill";
            this.btn_Fill.Size = new System.Drawing.Size(47, 57);
            this.btn_Fill.TabIndex = 1;
            this.btn_Fill.Text = "Fill";
            this.btn_Fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Fill.UseVisualStyleBackColor = true;
            this.btn_Fill.Click += new System.EventHandler(this.btn_Fill_Click);
            // 
            // btn_Pen
            // 
            this.btn_Pen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_Pen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Pen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pen.Image = global::PaintApp.Properties.Resources._187_pencil;
            this.btn_Pen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Pen.Location = new System.Drawing.Point(56, 3);
            this.btn_Pen.Name = "btn_Pen";
            this.btn_Pen.Size = new System.Drawing.Size(53, 57);
            this.btn_Pen.TabIndex = 2;
            this.btn_Pen.Text = "Pencil";
            this.btn_Pen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Pen.UseVisualStyleBackColor = true;
            this.btn_Pen.Click += new System.EventHandler(this.btn_Pen_Click);
            // 
            // btn_Erase
            // 
            this.btn_Erase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Erase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_Erase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Erase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Erase.Image = global::PaintApp.Properties.Resources.Eraser;
            this.btn_Erase.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Erase.Location = new System.Drawing.Point(3, 66);
            this.btn_Erase.Name = "btn_Erase";
            this.btn_Erase.Size = new System.Drawing.Size(47, 57);
            this.btn_Erase.TabIndex = 3;
            this.btn_Erase.Text = "Erase";
            this.btn_Erase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Erase.UseVisualStyleBackColor = true;
            this.btn_Erase.Click += new System.EventHandler(this.btn_Erase_Click);
            // 
            // btn_Circle
            // 
            this.btn_Circle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Circle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_Circle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Circle.Image = global::PaintApp.Properties.Resources.elipse;
            this.btn_Circle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Circle.Location = new System.Drawing.Point(56, 66);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.Size = new System.Drawing.Size(53, 57);
            this.btn_Circle.TabIndex = 4;
            this.btn_Circle.Text = "Circle";
            this.btn_Circle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Circle.UseVisualStyleBackColor = true;
            this.btn_Circle.Click += new System.EventHandler(this.btn_Circle_Click);
            // 
            // btn_Sqr
            // 
            this.btn_Sqr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sqr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_Sqr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Sqr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sqr.Image = global::PaintApp.Properties.Resources.rectangle;
            this.btn_Sqr.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Sqr.Location = new System.Drawing.Point(3, 129);
            this.btn_Sqr.Name = "btn_Sqr";
            this.btn_Sqr.Size = new System.Drawing.Size(56, 57);
            this.btn_Sqr.TabIndex = 5;
            this.btn_Sqr.Text = "Square";
            this.btn_Sqr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Sqr.UseVisualStyleBackColor = true;
            this.btn_Sqr.Click += new System.EventHandler(this.btn_Rect_Click);
            // 
            // btn_Line
            // 
            this.btn_Line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_Line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Line.Image = global::PaintApp.Properties.Resources.draw_line1;
            this.btn_Line.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Line.Location = new System.Drawing.Point(65, 129);
            this.btn_Line.Name = "btn_Line";
            this.btn_Line.Size = new System.Drawing.Size(44, 57);
            this.btn_Line.TabIndex = 6;
            this.btn_Line.Text = "Line";
            this.btn_Line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Line.UseVisualStyleBackColor = true;
            this.btn_Line.Click += new System.EventHandler(this.btn_Line_Click);
            // 
            // btn_Arc
            // 
            this.btn_Arc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Arc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_Arc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Arc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Arc.Image = global::PaintApp.Properties.Resources.Arc;
            this.btn_Arc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Arc.Location = new System.Drawing.Point(3, 192);
            this.btn_Arc.Name = "btn_Arc";
            this.btn_Arc.Size = new System.Drawing.Size(53, 57);
            this.btn_Arc.TabIndex = 7;
            this.btn_Arc.Text = "Arc";
            this.btn_Arc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Arc.UseVisualStyleBackColor = true;
            this.btn_Arc.Click += new System.EventHandler(this.btn_Arc_Click);
            // 
            // btn_Brush
            // 
            this.btn_Brush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Brush.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_Brush.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Brush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Brush.Image = global::PaintApp.Properties.Resources.childish_Brush;
            this.btn_Brush.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Brush.Location = new System.Drawing.Point(62, 192);
            this.btn_Brush.Name = "btn_Brush";
            this.btn_Brush.Size = new System.Drawing.Size(47, 57);
            this.btn_Brush.TabIndex = 8;
            this.btn_Brush.Text = "Brush";
            this.btn_Brush.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Brush.UseVisualStyleBackColor = true;
            this.btn_Brush.Click += new System.EventHandler(this.btn_Brush_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Image = global::PaintApp.Properties.Resources.childish_Cross;
            this.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Clear.Location = new System.Drawing.Point(3, 255);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(53, 57);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.addNewToolStripMenuItem.Text = "Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click_1);
            // 
            // PicPannel
            // 
            this.PicPannel.BackColor = System.Drawing.Color.White;
            this.PicPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicPannel.Location = new System.Drawing.Point(0, 24);
            this.PicPannel.Name = "PicPannel";
            this.PicPannel.Size = new System.Drawing.Size(864, 487);
            this.PicPannel.TabIndex = 2;
            this.PicPannel.TabStop = false;
            this.PicPannel.Click += new System.EventHandler(this.pictureBox1_Click);
            this.PicPannel.DragDrop += new System.Windows.Forms.DragEventHandler(this.PicPannel_DragDrop);
            this.PicPannel.DragEnter += new System.Windows.Forms.DragEventHandler(this.PicPannel_DragEnter);
            this.PicPannel.Paint += new System.Windows.Forms.PaintEventHandler(this.picbox1_Paint);
            this.PicPannel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picbox1_MouseClick);
            this.PicPannel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picbox1_MouseDown);
            this.PicPannel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picbox1_MouseMove);
            this.PicPannel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picbox1_MouseUp);
            // 
            // PicColor
            // 
            this.PicColor.Location = new System.Drawing.Point(3, 318);
            this.PicColor.Name = "PicColor";
            this.PicColor.Size = new System.Drawing.Size(106, 64);
            this.PicColor.TabIndex = 12;
            this.PicColor.Text = "Color";
            this.PicColor.UseVisualStyleBackColor = true;
            this.PicColor.Click += new System.EventHandler(this.PicColor_Click);
            // 
            // shapeBtn
            // 
            this.shapeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shapeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.shapeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shapeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shapeBtn.Image = global::PaintApp.Properties.Resources.elipse;
            this.shapeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.shapeBtn.Location = new System.Drawing.Point(62, 255);
            this.shapeBtn.Name = "shapeBtn";
            this.shapeBtn.Size = new System.Drawing.Size(53, 57);
            this.shapeBtn.TabIndex = 4;
            this.shapeBtn.Text = "Shape";
            this.shapeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.shapeBtn.UseVisualStyleBackColor = true;
            this.shapeBtn.Click += new System.EventHandler(this.shapeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 511);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.PicPannel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SidePanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPannel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel SidePanel;
        private System.Windows.Forms.PictureBox PicPannel;
        private System.Windows.Forms.Button btn_Fill;
        private System.Windows.Forms.Button btn_Pen;
        private System.Windows.Forms.Button btn_Erase;
        private System.Windows.Forms.Button btn_Circle;
        private System.Windows.Forms.Button btn_Sqr;
        private System.Windows.Forms.Button btn_Line;
        private System.Windows.Forms.Button btn_Arc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.Button btn_Brush;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button PicColor;
        private System.Windows.Forms.Button shapeBtn;
    }
}

