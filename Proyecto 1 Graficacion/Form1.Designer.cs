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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_ROTATION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_SCALE)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox.Location = new System.Drawing.Point(194, 42);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1274, 721);
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
            this.TB_ROTATION.Location = new System.Drawing.Point(194, 784);
            this.TB_ROTATION.Maximum = 360;
            this.TB_ROTATION.Minimum = -360;
            this.TB_ROTATION.Name = "TB_ROTATION";
            this.TB_ROTATION.Size = new System.Drawing.Size(1274, 45);
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
            this.TREE.Location = new System.Drawing.Point(28, 42);
            this.TREE.Name = "TREE";
            this.TREE.Size = new System.Drawing.Size(121, 490);
            this.TREE.TabIndex = 2;
            this.TREE.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TREE_AfterSelect);
            // 
            // NEW_FIGURE
            // 
            this.NEW_FIGURE.BackColor = System.Drawing.Color.Gold;
            this.NEW_FIGURE.Location = new System.Drawing.Point(28, 584);
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
            this.label_Rotation.Location = new System.Drawing.Point(806, 766);
            this.label_Rotation.Name = "label_Rotation";
            this.label_Rotation.Size = new System.Drawing.Size(52, 15);
            this.label_Rotation.TabIndex = 4;
            this.label_Rotation.Text = "Rotation";
            // 
            // TB_SCALE
            // 
            this.TB_SCALE.Location = new System.Drawing.Point(1491, 42);
            this.TB_SCALE.Maximum = 200;
            this.TB_SCALE.Name = "TB_SCALE";
            this.TB_SCALE.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TB_SCALE.Size = new System.Drawing.Size(45, 721);
            this.TB_SCALE.TabIndex = 5;
            this.TB_SCALE.Value = 100;
            this.TB_SCALE.Scroll += new System.EventHandler(this.TB_SCALE_Scroll);
            this.TB_SCALE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TB_SCALE_MouseUp);
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Location = new System.Drawing.Point(1491, 24);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(34, 15);
            this.labelScale.TabIndex = 6;
            this.labelScale.Text = "Scale";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(753, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 841);
            this.Controls.Add(this.label1);
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
        private Label label1;
    }
}