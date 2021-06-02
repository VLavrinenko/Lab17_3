
namespace Lab6_3
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Y_Label = new System.Windows.Forms.Label();
            this.X_Label = new System.Windows.Forms.Label();
            this.Y_box = new System.Windows.Forms.TextBox();
            this.X_box = new System.Windows.Forms.TextBox();
            this.Color2_Button = new System.Windows.Forms.Button();
            this.Color1_Button = new System.Windows.Forms.Button();
            this.Color2_Label = new System.Windows.Forms.Label();
            this.Color1_Label = new System.Windows.Forms.Label();
            this.One_Label = new System.Windows.Forms.Label();
            this.Zero_Label = new System.Windows.Forms.Label();
            this.Label_Two_Left = new System.Windows.Forms.Label();
            this.Label_Two_Right = new System.Windows.Forms.Label();
            this.Label_Two_Up = new System.Windows.Forms.Label();
            this.Label_Two_Down = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Play = new System.Windows.Forms.ToolStripMenuItem();
            this.Pause = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Y_Label);
            this.panel1.Controls.Add(this.X_Label);
            this.panel1.Controls.Add(this.Y_box);
            this.panel1.Controls.Add(this.X_box);
            this.panel1.Controls.Add(this.Color2_Button);
            this.panel1.Controls.Add(this.Color1_Button);
            this.panel1.Controls.Add(this.Color2_Label);
            this.panel1.Controls.Add(this.Color1_Label);
            this.panel1.Controls.Add(this.One_Label);
            this.panel1.Controls.Add(this.Zero_Label);
            this.panel1.Controls.Add(this.Label_Two_Left);
            this.panel1.Controls.Add(this.Label_Two_Right);
            this.panel1.Controls.Add(this.Label_Two_Up);
            this.panel1.Controls.Add(this.Label_Two_Down);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 760);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Y_Label
            // 
            this.Y_Label.AutoSize = true;
            this.Y_Label.BackColor = System.Drawing.Color.Transparent;
            this.Y_Label.Location = new System.Drawing.Point(390, 35);
            this.Y_Label.Name = "Y_Label";
            this.Y_Label.Size = new System.Drawing.Size(17, 20);
            this.Y_Label.TabIndex = 2;
            this.Y_Label.Text = "Y";
            this.Y_Label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label_MouseUp);
            // 
            // X_Label
            // 
            this.X_Label.AutoSize = true;
            this.X_Label.BackColor = System.Drawing.Color.Transparent;
            this.X_Label.Location = new System.Drawing.Point(708, 339);
            this.X_Label.Name = "X_Label";
            this.X_Label.Size = new System.Drawing.Size(18, 20);
            this.X_Label.TabIndex = 3;
            this.X_Label.Text = "X";
            this.X_Label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label_MouseUp);
            // 
            // Y_box
            // 
            this.Y_box.Enabled = false;
            this.Y_box.Location = new System.Drawing.Point(708, 733);
            this.Y_box.Name = "Y_box";
            this.Y_box.Size = new System.Drawing.Size(50, 27);
            this.Y_box.TabIndex = 14;
            // 
            // X_box
            // 
            this.X_box.Enabled = false;
            this.X_box.Location = new System.Drawing.Point(708, 700);
            this.X_box.Name = "X_box";
            this.X_box.Size = new System.Drawing.Size(50, 27);
            this.X_box.TabIndex = 13;
            // 
            // Color2_Button
            // 
            this.Color2_Button.Location = new System.Drawing.Point(185, 722);
            this.Color2_Button.Name = "Color2_Button";
            this.Color2_Button.Size = new System.Drawing.Size(48, 29);
            this.Color2_Button.TabIndex = 12;
            this.Color2_Button.Text = "...";
            this.Color2_Button.UseVisualStyleBackColor = true;
            this.Color2_Button.Click += new System.EventHandler(this.Color2_Button_Click);
            // 
            // Color1_Button
            // 
            this.Color1_Button.Location = new System.Drawing.Point(185, 690);
            this.Color1_Button.Name = "Color1_Button";
            this.Color1_Button.Size = new System.Drawing.Size(48, 29);
            this.Color1_Button.TabIndex = 4;
            this.Color1_Button.Text = "...";
            this.Color1_Button.UseVisualStyleBackColor = true;
            this.Color1_Button.Click += new System.EventHandler(this.Color1_Button_Click);
            // 
            // Color2_Label
            // 
            this.Color2_Label.AutoSize = true;
            this.Color2_Label.Location = new System.Drawing.Point(9, 726);
            this.Color2_Label.Name = "Color2_Label";
            this.Color2_Label.Size = new System.Drawing.Size(170, 20);
            this.Color2_Label.TabIndex = 11;
            this.Color2_Label.Text = "Цвет большой области";
            // 
            // Color1_Label
            // 
            this.Color1_Label.AutoSize = true;
            this.Color1_Label.Location = new System.Drawing.Point(9, 694);
            this.Color1_Label.Name = "Color1_Label";
            this.Color1_Label.Size = new System.Drawing.Size(151, 20);
            this.Color1_Label.TabIndex = 10;
            this.Color1_Label.Text = "Цвет малой области";
            // 
            // One_Label
            // 
            this.One_Label.AutoSize = true;
            this.One_Label.BackColor = System.Drawing.Color.Transparent;
            this.One_Label.Location = new System.Drawing.Point(358, 297);
            this.One_Label.Name = "One_Label";
            this.One_Label.Size = new System.Drawing.Size(17, 20);
            this.One_Label.TabIndex = 9;
            this.One_Label.Text = "1";
            this.One_Label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label_MouseUp);
            // 
            // Zero_Label
            // 
            this.Zero_Label.AutoSize = true;
            this.Zero_Label.BackColor = System.Drawing.Color.Transparent;
            this.Zero_Label.Location = new System.Drawing.Point(358, 358);
            this.Zero_Label.Name = "Zero_Label";
            this.Zero_Label.Size = new System.Drawing.Size(17, 20);
            this.Zero_Label.TabIndex = 4;
            this.Zero_Label.Text = "0";
            this.Zero_Label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label_MouseUp);
            // 
            // Label_Two_Left
            // 
            this.Label_Two_Left.AutoSize = true;
            this.Label_Two_Left.BackColor = System.Drawing.Color.Transparent;
            this.Label_Two_Left.Location = new System.Drawing.Point(508, 358);
            this.Label_Two_Left.Name = "Label_Two_Left";
            this.Label_Two_Left.Size = new System.Drawing.Size(17, 20);
            this.Label_Two_Left.TabIndex = 8;
            this.Label_Two_Left.Text = "2";
            this.Label_Two_Left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label_MouseUp);
            // 
            // Label_Two_Right
            // 
            this.Label_Two_Right.AutoSize = true;
            this.Label_Two_Right.BackColor = System.Drawing.Color.Transparent;
            this.Label_Two_Right.Location = new System.Drawing.Point(226, 358);
            this.Label_Two_Right.Name = "Label_Two_Right";
            this.Label_Two_Right.Size = new System.Drawing.Size(17, 20);
            this.Label_Two_Right.TabIndex = 7;
            this.Label_Two_Right.Text = "2";
            this.Label_Two_Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label_MouseUp);
            // 
            // Label_Two_Up
            // 
            this.Label_Two_Up.AutoSize = true;
            this.Label_Two_Up.BackColor = System.Drawing.Color.Transparent;
            this.Label_Two_Up.Location = new System.Drawing.Point(358, 231);
            this.Label_Two_Up.Name = "Label_Two_Up";
            this.Label_Two_Up.Size = new System.Drawing.Size(17, 20);
            this.Label_Two_Up.TabIndex = 5;
            this.Label_Two_Up.Text = "2";
            this.Label_Two_Up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label_MouseUp);
            // 
            // Label_Two_Down
            // 
            this.Label_Two_Down.AutoSize = true;
            this.Label_Two_Down.BackColor = System.Drawing.Color.Transparent;
            this.Label_Two_Down.Location = new System.Drawing.Point(386, 507);
            this.Label_Two_Down.Name = "Label_Two_Down";
            this.Label_Two_Down.Size = new System.Drawing.Size(17, 20);
            this.Label_Two_Down.TabIndex = 6;
            this.Label_Two_Down.Text = "2";
            this.Label_Two_Down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Play,
            this.Pause});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Play
            // 
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(50, 24);
            this.Play.Text = "&Play";
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Pause
            // 
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(60, 24);
            this.Pause.Text = "Pa&use";
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 803);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Play;
        private System.Windows.Forms.ToolStripMenuItem Pause;
        private System.Windows.Forms.Label Y_Label;
        private System.Windows.Forms.Label X_Label;
        private System.Windows.Forms.Label Zero_Label;
        private System.Windows.Forms.Label Label_Two_Left;
        private System.Windows.Forms.Label Label_Two_Right;
        private System.Windows.Forms.Label Label_Two_Up;
        private System.Windows.Forms.Label Label_Two_Down;
        private System.Windows.Forms.Label One_Label;
        private System.Windows.Forms.Button Color2_Button;
        private System.Windows.Forms.Button Color1_Button;
        private System.Windows.Forms.Label Color2_Label;
        private System.Windows.Forms.Label Color1_Label;
        private System.Windows.Forms.TextBox Y_box;
        private System.Windows.Forms.TextBox X_box;

        private class solo
        {
            public solo()
            {
            }
        }
    }
}

