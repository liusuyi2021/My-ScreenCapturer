namespace ScreenCapturer
{
    partial class DrawToolsControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawToolsControl));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRectangular = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEllipse = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonText = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonArrow = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAccept = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRectangular,
            this.toolStripButtonEllipse,
            this.toolStripButtonText,
            this.toolStripButtonArrow,
            this.toolStripButtonLine,
            this.toolStripSeparator1,
            this.toolStripButtonRedo,
            this.toolStripButtonSave,
            this.toolStripSeparator2,
            this.toolStripButtonExit,
            this.toolStripButtonAccept});
            this.toolStrip.Location = new System.Drawing.Point(2, 2);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(578, 31);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonLine
            // 
            this.toolStripButtonLine.AutoSize = false;
            this.toolStripButtonLine.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLine.Image = global::ScreenCapturer.Properties.Resources.icons8_pencil_drawing_40;
            this.toolStripButtonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLine.Name = "toolStripButtonLine";
            this.toolStripButtonLine.Size = new System.Drawing.Size(30, 30);
            this.toolStripButtonLine.Text = "画笔";
            this.toolStripButtonLine.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButtonRectangular
            // 
            this.toolStripButtonRectangular.AutoSize = false;
            this.toolStripButtonRectangular.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonRectangular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRectangular.Image = global::ScreenCapturer.Properties.Resources.Rectangle;
            this.toolStripButtonRectangular.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonRectangular.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripButtonRectangular.Name = "toolStripButtonRectangular";
            this.toolStripButtonRectangular.Size = new System.Drawing.Size(30, 30);
            this.toolStripButtonRectangular.Text = "矩形";
            this.toolStripButtonRectangular.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripButtonEllipse
            // 
            this.toolStripButtonEllipse.AutoSize = false;
            this.toolStripButtonEllipse.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEllipse.Image = global::ScreenCapturer.Properties.Resources.Circle;
            this.toolStripButtonEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEllipse.Name = "toolStripButtonEllipse";
            this.toolStripButtonEllipse.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripButtonEllipse.Size = new System.Drawing.Size(30, 30);
            this.toolStripButtonEllipse.Text = "椭圆";
            this.toolStripButtonEllipse.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripButtonText
            // 
            this.toolStripButtonText.AutoSize = false;
            this.toolStripButtonText.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonText.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonText.Image")));
            this.toolStripButtonText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonText.Name = "toolStripButtonText";
            this.toolStripButtonText.Size = new System.Drawing.Size(30, 30);
            this.toolStripButtonText.Text = "文字";
            this.toolStripButtonText.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripButtonArrow
            // 
            this.toolStripButtonArrow.AutoSize = false;
            this.toolStripButtonArrow.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonArrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonArrow.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonArrow.Image")));
            this.toolStripButtonArrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonArrow.Name = "toolStripButtonArrow";
            this.toolStripButtonArrow.Size = new System.Drawing.Size(30, 30);
            this.toolStripButtonArrow.Text = "箭头";
            this.toolStripButtonArrow.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripButtonRedo
            // 
            this.toolStripButtonRedo.AutoSize = false;
            this.toolStripButtonRedo.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRedo.Image = global::ScreenCapturer.Properties.Resources.Undo;
            this.toolStripButtonRedo.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonRedo.Name = "toolStripButtonRedo";
            this.toolStripButtonRedo.Size = new System.Drawing.Size(30, 30);
            this.toolStripButtonRedo.Text = "撤销";
            this.toolStripButtonRedo.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.AutoSize = false;
            this.toolStripButtonSave.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = global::ScreenCapturer.Properties.Resources.Save;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(30, 30);
            this.toolStripButtonSave.Text = "保存";
            this.toolStripButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.AutoSize = false;
            this.toolStripButtonExit.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.Image = global::ScreenCapturer.Properties.Resources.Exit;
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(30, 30);
            this.toolStripButtonExit.Text = "退出";
            this.toolStripButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripButtonAccept
            // 
            this.toolStripButtonAccept.AutoSize = false;
            this.toolStripButtonAccept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAccept.Image = global::ScreenCapturer.Properties.Resources.Accept;
            this.toolStripButtonAccept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAccept.Name = "toolStripButtonAccept";
            this.toolStripButtonAccept.Size = new System.Drawing.Size(30, 30);
            this.toolStripButtonAccept.Text = "完成";
            this.toolStripButtonAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // DrawToolsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.toolStrip);
            this.DoubleBuffered = true;
            this.Name = "DrawToolsControl";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(582, 45);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripButton toolStripButtonRectangular;
        private System.Windows.Forms.ToolStripButton toolStripButtonEllipse;
        private System.Windows.Forms.ToolStripButton toolStripButtonText;
        private System.Windows.Forms.ToolStripButton toolStripButtonArrow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonLine;
        private System.Windows.Forms.ToolStripButton toolStripButtonRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.ToolStripButton toolStripButtonAccept;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        public System.Windows.Forms.ToolStrip toolStrip;
    }
}
