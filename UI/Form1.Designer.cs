﻿
namespace NorthWind_WinUI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuPageDown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuPageUp = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(800, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuManage,
            this.toolStripMenuPageDown,
            this.toolStripMenuPageUp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuManage
            // 
            this.toolStripMenuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuLoad,
            this.toolStripMenuSave});
            this.toolStripMenuManage.Name = "toolStripMenuManage";
            this.toolStripMenuManage.Size = new System.Drawing.Size(69, 24);
            this.toolStripMenuManage.Text = "Mange";
            // 
            // toolStripMenuLoad
            // 
            this.toolStripMenuLoad.Name = "toolStripMenuLoad";
            this.toolStripMenuLoad.Size = new System.Drawing.Size(125, 26);
            this.toolStripMenuLoad.Text = "Load";
            this.toolStripMenuLoad.Click += new System.EventHandler(this.toolStripMenuLoad_Click);
            // 
            // toolStripMenuSave
            // 
            this.toolStripMenuSave.Name = "toolStripMenuSave";
            this.toolStripMenuSave.Size = new System.Drawing.Size(125, 26);
            this.toolStripMenuSave.Text = "Save";
            this.toolStripMenuSave.Click += new System.EventHandler(this.toolStripMenuSave_Click);
            // 
            // toolStripMenuPageDown
            // 
            this.toolStripMenuPageDown.Name = "toolStripMenuPageDown";
            this.toolStripMenuPageDown.Size = new System.Drawing.Size(33, 24);
            this.toolStripMenuPageDown.Text = "<";
            this.toolStripMenuPageDown.Click += new System.EventHandler(this.toolStripMenuPageDown_Click);
            // 
            // toolStripMenuPageUp
            // 
            this.toolStripMenuPageUp.Name = "toolStripMenuPageUp";
            this.toolStripMenuPageUp.Size = new System.Drawing.Size(33, 24);
            this.toolStripMenuPageUp.Text = ">";
            this.toolStripMenuPageUp.Click += new System.EventHandler(this.toolStripMenuPageUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuManage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuLoad;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuPageDown;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuPageUp;
    }
}

