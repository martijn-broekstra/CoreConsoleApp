using System.Windows.Forms;

namespace LevelEditor
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.levelWidth = new System.Windows.Forms.TextBox();
            this.levelHeight = new System.Windows.Forms.TextBox();
            this.resizeButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Character = new System.Windows.Forms.TabPage();
            this.Color = new System.Windows.Forms.TabPage();
            this.Moveable = new System.Windows.Forms.TabPage();
            this.Passable = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // levelWidth
            // 
            this.levelWidth.Location = new System.Drawing.Point(10, 20);
            this.levelWidth.Name = "levelWidth";
            this.levelWidth.Size = new System.Drawing.Size(100, 20);
            this.levelWidth.TabIndex = 0;
            // 
            // levelHeight
            // 
            this.levelHeight.Location = new System.Drawing.Point(120, 20);
            this.levelHeight.Name = "levelHeight";
            this.levelHeight.Size = new System.Drawing.Size(100, 20);
            this.levelHeight.TabIndex = 0;
            // 
            // resizeButton
            // 
            this.resizeButton.Location = new System.Drawing.Point(230, 20);
            this.resizeButton.Name = "resizeButton";
            this.resizeButton.Size = new System.Drawing.Size(75, 23);
            this.resizeButton.TabIndex = 1;
            this.resizeButton.Text = "resize";
            this.resizeButton.Click += new System.EventHandler(this.ClickResize);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Character);
            this.tabControl.Controls.Add(this.Color);
            this.tabControl.Controls.Add(this.Moveable);
            this.tabControl.Controls.Add(this.Passable);
            this.tabControl.Location = new System.Drawing.Point(13, 80);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(891, 498);
            this.tabControl.TabIndex = 2;
            // 
            // Character
            // 
            this.Character.Location = new System.Drawing.Point(4, 22);
            this.Character.Name = "Character";
            this.Character.Padding = new System.Windows.Forms.Padding(3);
            this.Character.Size = new System.Drawing.Size(883, 472);
            this.Character.TabIndex = 0;
            this.Character.Text = "Character";
            this.Character.UseVisualStyleBackColor = true;
            // 
            // Color
            // 
            this.Color.Location = new System.Drawing.Point(4, 22);
            this.Color.Name = "Color";
            this.Color.Padding = new System.Windows.Forms.Padding(3);
            this.Color.Size = new System.Drawing.Size(883, 472);
            this.Color.TabIndex = 1;
            this.Color.Text = "Color";
            this.Color.UseVisualStyleBackColor = true;
            // 
            // Moveable
            // 
            this.Moveable.Location = new System.Drawing.Point(4, 22);
            this.Moveable.Name = "Moveable";
            this.Moveable.Padding = new System.Windows.Forms.Padding(3);
            this.Moveable.Size = new System.Drawing.Size(883, 472);
            this.Moveable.TabIndex = 2;
            this.Moveable.Text = "Moveable";
            this.Moveable.UseVisualStyleBackColor = true;
            // 
            // Passable
            // 
            this.Passable.Location = new System.Drawing.Point(4, 22);
            this.Passable.Name = "Passable";
            this.Passable.Padding = new System.Windows.Forms.Padding(3);
            this.Passable.Size = new System.Drawing.Size(883, 472);
            this.Passable.TabIndex = 3;
            this.Passable.Text = "Passable";
            this.Passable.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 590);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.levelWidth);
            this.Controls.Add(this.levelHeight);
            this.Controls.Add(this.resizeButton);
            this.Name = "Form1";
            this.Text = "LevelEditor";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.Button resizeButton;
        private System.Windows.Forms.TextBox levelWidth;
        private System.Windows.Forms.TextBox levelHeight;
        private TabControl tabControl;
        private TabPage Character;
        private TabPage Color;
        private TabPage Moveable;
        private TabPage Passable;
    }
}

