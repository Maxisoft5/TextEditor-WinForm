﻿namespace Текстовый_редактор
{
    partial class blank
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip5 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sbAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip5;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(284, 261);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // contextMenuStrip5
            // 
            this.contextMenuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuCut,
            this.cmnuCopy,
            this.cmnuPaste,
            this.cmnuDelete,
            this.cmnuSelectAll});
            this.contextMenuStrip5.Name = "contextMenuStrip5";
            this.contextMenuStrip5.Size = new System.Drawing.Size(123, 114);
            // 
            // cmnuCut
            // 
            this.cmnuCut.Name = "cmnuCut";
            this.cmnuCut.ShowShortcutKeys = false;
            this.cmnuCut.Size = new System.Drawing.Size(122, 22);
            this.cmnuCut.Text = "Cut";
            this.cmnuCut.Click += new System.EventHandler(this.cmnuCut_Click);
            // 
            // cmnuCopy
            // 
            this.cmnuCopy.Name = "cmnuCopy";
            this.cmnuCopy.ShowShortcutKeys = false;
            this.cmnuCopy.Size = new System.Drawing.Size(122, 22);
            this.cmnuCopy.Text = "Copy";
            this.cmnuCopy.Click += new System.EventHandler(this.cmnuCopy_Click);
            // 
            // cmnuPaste
            // 
            this.cmnuPaste.Name = "cmnuPaste";
            this.cmnuPaste.ShowShortcutKeys = false;
            this.cmnuPaste.Size = new System.Drawing.Size(122, 22);
            this.cmnuPaste.Text = "Paste";
            this.cmnuPaste.Click += new System.EventHandler(this.cmnuPaste_Click);
            // 
            // cmnuDelete
            // 
            this.cmnuDelete.Name = "cmnuDelete";
            this.cmnuDelete.ShowShortcutKeys = false;
            this.cmnuDelete.Size = new System.Drawing.Size(122, 22);
            this.cmnuDelete.Text = "Delete";
            this.cmnuDelete.Click += new System.EventHandler(this.cmnuDelete_Click);
            // 
            // cmnuSelectAll
            // 
            this.cmnuSelectAll.Name = "cmnuSelectAll";
            this.cmnuSelectAll.Size = new System.Drawing.Size(122, 22);
            this.cmnuSelectAll.Text = "Select All";
            this.cmnuSelectAll.Click += new System.EventHandler(this.cmnuSelectAll_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Gold;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbAmount,
            this.sbTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 237);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 24);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sbAmount
            // 
            this.sbAmount.BackColor = System.Drawing.Color.Yellow;
            this.sbAmount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sbAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sbAmount.Name = "sbAmount";
            this.sbAmount.Size = new System.Drawing.Size(119, 19);
            this.sbAmount.Text = "Amound of symbols";
            // 
            // sbTime
            // 
            this.sbTime.BackColor = System.Drawing.Color.Yellow;
            this.sbTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sbTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sbTime.Name = "sbTime";
            this.sbTime.Size = new System.Drawing.Size(38, 19);
            this.sbTime.Text = "Time";
            // 
            // blank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "blank";
            this.Text = "blank";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.blank_FormClosing);
            this.Load += new System.EventHandler(this.blank_Load);
            this.contextMenuStrip5.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

   public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip5;
        private System.Windows.Forms.ToolStripMenuItem cmnuCut;
        private System.Windows.Forms.ToolStripMenuItem cmnuCopy;
        private System.Windows.Forms.ToolStripMenuItem cmnuPaste;
        private System.Windows.Forms.ToolStripMenuItem cmnuDelete;
        private System.Windows.Forms.ToolStripMenuItem cmnuSelectAll;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sbAmount;
        private System.Windows.Forms.ToolStripStatusLabel sbTime;
    }
}