namespace MenStore.PresentationLayer
{
    partial class productsForUser
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
            menuStrip1 = new MenuStrip();
            loadToolStripMenuItem = new ToolStripMenuItem();
            txtSearch = new ToolStripTextBox();
            categorySelect = new ToolStripComboBox();
            btnPrevious = new Button();
            btnHome = new Button();
            btnNext = new Button();
            PanelProducts = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { loadToolStripMenuItem, txtSearch, categorySelect });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1271, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(56, 28);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // txtSearch
            // 
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 28);
            txtSearch.Text = "Search";
            txtSearch.Click += toolStripTextBox1_Click;
            // 
            // categorySelect
            // 
            categorySelect.Name = "categorySelect";
            categorySelect.Size = new Size(121, 28);
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(342, 607);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(150, 55);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(565, 610);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(150, 55);
            btnHome.TabIndex = 2;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(793, 610);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(150, 55);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // PanelProducts
            // 
            PanelProducts.Location = new Point(12, 47);
            PanelProducts.Name = "PanelProducts";
            PanelProducts.Size = new Size(1247, 537);
            PanelProducts.TabIndex = 4;
            // 
            // productsForUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 674);
            Controls.Add(PanelProducts);
            Controls.Add(btnNext);
            Controls.Add(btnHome);
            Controls.Add(btnPrevious);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "productsForUser";
            Text = "productsForUser";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripTextBox txtSearch;
        private ToolStripComboBox categorySelect;
        private Button btnPrevious;
        private Button btnHome;
        private Button btnNext;
        private Panel PanelProducts;
    }
}