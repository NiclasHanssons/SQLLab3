﻿namespace TheBookShelf
{
    partial class UserControlTreeView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlTreeView = new System.Windows.Forms.TabControl();
            this.tabPageButiker = new System.Windows.Forms.TabPage();
            this.treeViewUcButiker = new System.Windows.Forms.TreeView();
            this.tabPageFörfattare = new System.Windows.Forms.TabPage();
            this.treeViewFörfattare = new System.Windows.Forms.TreeView();
            this.tabPageBöcker = new System.Windows.Forms.TabPage();
            this.treeViewBöcker = new System.Windows.Forms.TreeView();
            this.tabControlTreeView.SuspendLayout();
            this.tabPageButiker.SuspendLayout();
            this.tabPageFörfattare.SuspendLayout();
            this.tabPageBöcker.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlTreeView
            // 
            this.tabControlTreeView.Controls.Add(this.tabPageButiker);
            this.tabControlTreeView.Controls.Add(this.tabPageFörfattare);
            this.tabControlTreeView.Controls.Add(this.tabPageBöcker);
            this.tabControlTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTreeView.Location = new System.Drawing.Point(0, 0);
            this.tabControlTreeView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlTreeView.Name = "tabControlTreeView";
            this.tabControlTreeView.SelectedIndex = 3;
            this.tabControlTreeView.Size = new System.Drawing.Size(394, 748);
            this.tabControlTreeView.TabIndex = 0;
            // 
            // tabPageButiker
            // 
            this.tabPageButiker.Controls.Add(this.treeViewUcButiker);
            this.tabPageButiker.Location = new System.Drawing.Point(4, 29);
            this.tabPageButiker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageButiker.Name = "tabPageButiker";
            this.tabPageButiker.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageButiker.Size = new System.Drawing.Size(386, 715);
            this.tabPageButiker.TabIndex = 0;
            this.tabPageButiker.Text = "Butiker";
            this.tabPageButiker.UseVisualStyleBackColor = true;
            // 
            // treeViewUcButiker
            // 
            this.treeViewUcButiker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewUcButiker.Location = new System.Drawing.Point(3, 4);
            this.treeViewUcButiker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeViewUcButiker.Name = "treeViewUcButiker";
            this.treeViewUcButiker.Size = new System.Drawing.Size(380, 707);
            this.treeViewUcButiker.TabIndex = 0;
            this.treeViewUcButiker.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewUcButiker_NodeMouseClick);
            // 
            // tabPageFörfattare
            // 
            this.tabPageFörfattare.Controls.Add(this.treeViewFörfattare);
            this.tabPageFörfattare.Location = new System.Drawing.Point(4, 29);
            this.tabPageFörfattare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageFörfattare.Name = "tabPageFörfattare";
            this.tabPageFörfattare.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageFörfattare.Size = new System.Drawing.Size(386, 715);
            this.tabPageFörfattare.TabIndex = 1;
            this.tabPageFörfattare.Text = "Författare";
            this.tabPageFörfattare.UseVisualStyleBackColor = true;
            // 
            // treeViewFörfattare
            // 
            this.treeViewFörfattare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewFörfattare.Location = new System.Drawing.Point(3, 4);
            this.treeViewFörfattare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeViewFörfattare.Name = "treeViewFörfattare";
            this.treeViewFörfattare.Size = new System.Drawing.Size(380, 707);
            this.treeViewFörfattare.TabIndex = 0;
            // 
            // tabPageBöcker
            // 
            this.tabPageBöcker.Controls.Add(this.treeViewBöcker);
            this.tabPageBöcker.Location = new System.Drawing.Point(4, 29);
            this.tabPageBöcker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageBöcker.Name = "tabPageBöcker";
            this.tabPageBöcker.Size = new System.Drawing.Size(386, 715);
            this.tabPageBöcker.TabIndex = 2;
            this.tabPageBöcker.Text = "Böcker";
            // 
            // treeViewBöcker
            // 
            this.treeViewBöcker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewBöcker.Location = new System.Drawing.Point(0, 0);
            this.treeViewBöcker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeViewBöcker.Name = "treeViewBöcker";
            this.treeViewBöcker.Size = new System.Drawing.Size(386, 715);
            this.treeViewBöcker.TabIndex = 0;
            // 
            // UserControlTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlTreeView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlTreeView";
            this.Size = new System.Drawing.Size(394, 748);
            this.Load += new System.EventHandler(this.UserControlTreeView_Load);
            this.tabControlTreeView.ResumeLayout(false);
            this.tabPageButiker.ResumeLayout(false);
            this.tabPageFörfattare.ResumeLayout(false);
            this.tabPageBöcker.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTreeView;
        private System.Windows.Forms.TabPage tabPageButiker;
        private System.Windows.Forms.TabPage tabPageFörfattare;
        private System.Windows.Forms.TabPage tabPageBöcker;
        private System.Windows.Forms.TreeView treeViewUcButiker;
        private System.Windows.Forms.TreeView treeViewFörfattare;
        private System.Windows.Forms.TreeView treeViewBöcker;
    }
}
