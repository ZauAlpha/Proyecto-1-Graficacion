namespace Proyecto_1_Graficacion
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.TB_ROTATION = new System.Windows.Forms.TrackBar();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.TREE = new System.Windows.Forms.TreeView();
            this.NEW_FIGURE = new System.Windows.Forms.Button();
            this.label_Rotation = new System.Windows.Forms.Label();
            this.TB_SCALE = new System.Windows.Forms.TrackBar();
            this.labelScale = new System.Windows.Forms.Label();
            this.TB_FRAMES = new System.Windows.Forms.TrackBar();
            this.NEW_FRAME = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Animate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_ROTATION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_SCALE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_FRAMES)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox.Location = new System.Drawing.Point(204, 57);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(898, 516);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDoubleClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // TB_ROTATION
            // 
            this.TB_ROTATION.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TB_ROTATION.Cursor = System.Windows.Forms.Cursors.Cross;
            this.TB_ROTATION.Location = new System.Drawing.Point(194, 594);
            this.TB_ROTATION.Maximum = 360;
            this.TB_ROTATION.Minimum = -360;
            this.TB_ROTATION.Name = "TB_ROTATION";
            this.TB_ROTATION.Size = new System.Drawing.Size(908, 45);
            this.TB_ROTATION.TabIndex = 1;
            this.TB_ROTATION.Scroll += new System.EventHandler(this.TB_ROTATION_Scroll);
            this.TB_ROTATION.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TB_ROTATION_MouseUp);
            // 
            // TIMER
            // 
            this.TIMER.Enabled = true;
            this.TIMER.Interval = 40;
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // TREE
            // 
            this.TREE.Location = new System.Drawing.Point(28, 9);
            this.TREE.Name = "TREE";
            this.TREE.Size = new System.Drawing.Size(121, 490);
            this.TREE.TabIndex = 2;
            this.TREE.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TREE_AfterSelect);
            // 
            // NEW_FIGURE
            // 
            this.NEW_FIGURE.BackColor = System.Drawing.Color.Gold;
            this.NEW_FIGURE.Location = new System.Drawing.Point(28, 505);
            this.NEW_FIGURE.Name = "NEW_FIGURE";
            this.NEW_FIGURE.Size = new System.Drawing.Size(121, 23);
            this.NEW_FIGURE.TabIndex = 3;
            this.NEW_FIGURE.Text = "New Figure";
            this.NEW_FIGURE.UseVisualStyleBackColor = false;
            this.NEW_FIGURE.Click += new System.EventHandler(this.New_Figure_Click);
            // 
            // label_Rotation
            // 
            this.label_Rotation.AutoSize = true;
            this.label_Rotation.Location = new System.Drawing.Point(628, 576);
            this.label_Rotation.Name = "label_Rotation";
            this.label_Rotation.Size = new System.Drawing.Size(52, 15);
            this.label_Rotation.TabIndex = 4;
            this.label_Rotation.Text = "Rotation";
            // 
            // TB_SCALE
            // 
            this.TB_SCALE.Location = new System.Drawing.Point(1108, 67);
            this.TB_SCALE.Maximum = 200;
            this.TB_SCALE.Name = "TB_SCALE";
            this.TB_SCALE.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TB_SCALE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_SCALE.Size = new System.Drawing.Size(45, 506);
            this.TB_SCALE.TabIndex = 5;
            this.TB_SCALE.Value = 100;
            this.TB_SCALE.Scroll += new System.EventHandler(this.TB_SCALE_Scroll);
            this.TB_SCALE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TB_SCALE_MouseUp);
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Location = new System.Drawing.Point(1108, 24);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(34, 15);
            this.labelScale.TabIndex = 6;
            this.labelScale.Text = "Scale";
            // 
            // TB_FRAMES
            // 
            this.TB_FRAMES.Location = new System.Drawing.Point(194, 24);
            this.TB_FRAMES.Maximum = 240;
            this.TB_FRAMES.Name = "TB_FRAMES";
            this.TB_FRAMES.Size = new System.Drawing.Size(908, 45);
            this.TB_FRAMES.TabIndex = 7;
            this.TB_FRAMES.Scroll += new System.EventHandler(this.TB_MOVE_Scroll);
            // 
            // NEW_FRAME
            // 
            this.NEW_FRAME.BackColor = System.Drawing.Color.Thistle;
            this.NEW_FRAME.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NEW_FRAME.Location = new System.Drawing.Point(28, 534);
            this.NEW_FRAME.Name = "NEW_FRAME";
            this.NEW_FRAME.Size = new System.Drawing.Size(121, 23);
            this.NEW_FRAME.TabIndex = 8;
            this.NEW_FRAME.Text = "New Frame";
            this.NEW_FRAME.UseVisualStyleBackColor = false;
            this.NEW_FRAME.Click += new System.EventHandler(this.NEW_FRAME_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Frames";
            // 
            // Animate
            // 
            this.Animate.BackColor = System.Drawing.Color.GreenYellow;
            this.Animate.Location = new System.Drawing.Point(28, 563);
            this.Animate.Name = "Animate";
            this.Animate.Size = new System.Drawing.Size(121, 23);
            this.Animate.TabIndex = 12;
            this.Animate.Text = "Animate";
            this.Animate.UseVisualStyleBackColor = false;
            this.Animate.Click += new System.EventHandler(this.Animate_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.Animate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NEW_FRAME);
            this.Controls.Add(this.TB_FRAMES);
            this.Controls.Add(this.labelScale);
            this.Controls.Add(this.TB_SCALE);
            this.Controls.Add(this.label_Rotation);
            this.Controls.Add(this.NEW_FIGURE);
            this.Controls.Add(this.TREE);
            this.Controls.Add(this.TB_ROTATION);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_ROTATION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_SCALE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_FRAMES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox;
        
        private TrackBar TB_ROTATION;
        private System.Windows.Forms.Timer TIMER;
        private TreeView TREE;
        private Button NEW_FIGURE;
        private Label label_Rotation;
        private TrackBar TB_SCALE;
        private Label labelScale;
        private TrackBar TB_FRAMES;
        private Button NEW_FRAME;
        private Label label2;
        private Button Animate;
    }
}