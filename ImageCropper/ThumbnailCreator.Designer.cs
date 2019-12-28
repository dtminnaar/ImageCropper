namespace ImageCropper
{
    partial class ThumbnailCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThumbnailCreator));
            this.pbViewer = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pbThumbnail = new System.Windows.Forms.PictureBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.trackSize = new System.Windows.Forms.TrackBar();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.NotifyPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbViewer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSize)).BeginInit();
            this.NotifyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbViewer
            // 
            this.pbViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbViewer.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbViewer.Location = new System.Drawing.Point(12, 12);
            this.pbViewer.Name = "pbViewer";
            this.pbViewer.Size = new System.Drawing.Size(554, 537);
            this.pbViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbViewer.TabIndex = 0;
            this.pbViewer.TabStop = false;
            this.pbViewer.Click += new System.EventHandler(this.OnViewerClick);
            this.pbViewer.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnViewerDragDrop);
            this.pbViewer.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnViewerDragEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.pbThumbnail);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.trackSize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(572, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 561);
            this.panel1.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(84, 244);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(35, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "..";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.OnLoadClick);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(125, 244);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.OnNextClick);
            // 
            // pbThumbnail
            // 
            this.pbThumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbThumbnail.Location = new System.Drawing.Point(0, 12);
            this.pbThumbnail.Name = "pbThumbnail";
            this.pbThumbnail.Size = new System.Drawing.Size(200, 200);
            this.pbThumbnail.TabIndex = 0;
            this.pbThumbnail.TabStop = false;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(3, 244);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "&Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.OnPrevClick);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(3, 497);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(197, 52);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save [Enter]";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.OnSaveClick);
            this.btnSave.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // trackSize
            // 
            this.trackSize.Location = new System.Drawing.Point(0, 206);
            this.trackSize.Maximum = 100;
            this.trackSize.Minimum = 1;
            this.trackSize.Name = "trackSize";
            this.trackSize.Size = new System.Drawing.Size(200, 45);
            this.trackSize.TabIndex = 1;
            this.trackSize.Value = 25;
            this.trackSize.ValueChanged += new System.EventHandler(this.OnTrackBarChange);
            this.trackSize.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // NotifyPanel
            // 
            this.NotifyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotifyPanel.BackColor = System.Drawing.SystemColors.Info;
            this.NotifyPanel.Controls.Add(this.label1);
            this.NotifyPanel.Location = new System.Drawing.Point(100, 450);
            this.NotifyPanel.Name = "NotifyPanel";
            this.NotifyPanel.Size = new System.Drawing.Size(600, 45);
            this.NotifyPanel.TabIndex = 2;
            this.NotifyPanel.Visible = false;
            this.NotifyPanel.Click += new System.EventHandler(this.NotifyClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thumbnail Saved...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.NotifyClick);
            // 
            // notifyTimer
            // 
            this.notifyTimer.Interval = 2500;
            this.notifyTimer.Tick += new System.EventHandler(this.OnTick);
            // 
            // ThumbnailCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.NotifyPanel);
            this.Controls.Add(this.pbViewer);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "ThumbnailCreator";
            this.Text = "Thumbnail Creator";
            ((System.ComponentModel.ISupportInitialize)(this.pbViewer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSize)).EndInit();
            this.NotifyPanel.ResumeLayout(false);
            this.NotifyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbViewer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbThumbnail;
        private System.Windows.Forms.TrackBar trackSize;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel NotifyPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer notifyTimer;
    }
}

