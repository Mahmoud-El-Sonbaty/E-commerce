using System.Windows.Forms;

namespace MenStore.PresentationLayer
{
    partial class ProductForAdmin
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
            panel1 = new Panel();
            txtCategoryID = new ComboBox();
            txtPrice = new DomainUpDown();
            txtUnits = new DomainUpDown();
            button3 = new Button();
            button2 = new Button();
            label5 = new Label();
            btnInsert = new Button();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            lbl = new Label();
            txtImage = new TextBox();
            txtTitle = new TextBox();
            btnHome = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            Datagrid = new DataGridView();
            menuStrip1 = new MenuStrip();
            loadToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            categorySelect = new ToolStripComboBox();
            searchToolStripMenuItem = new ToolStripMenuItem();
            txtSearch = new ToolStripTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Datagrid).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtCategoryID);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(txtUnits);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnInsert);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbl);
            panel1.Controls.Add(txtImage);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnPrevious);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(Datagrid);
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(0, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 575);
            panel1.TabIndex = 0;
            // 
            // txtCategoryID
            // 
            txtCategoryID.FormattingEnabled = true;
            txtCategoryID.Location = new Point(459, 408);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(151, 28);
            txtCategoryID.TabIndex = 47;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(459, 503);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(124, 27);
            txtPrice.TabIndex = 46;
            txtPrice.Text = "0";
            // 
            // txtUnits
            // 
            txtUnits.Location = new Point(215, 408);
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new Size(124, 27);
            txtUnits.TabIndex = 45;
            txtUnits.Text = "0";
            // 
            // button3
            // 
            button3.Location = new Point(730, 448);
            button3.Name = "button3";
            button3.Size = new Size(125, 31);
            button3.TabIndex = 44;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(730, 496);
            button2.Name = "button2";
            button2.Size = new Size(125, 31);
            button2.TabIndex = 43;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(459, 463);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 40;
            label5.Text = "Price";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(730, 403);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(125, 31);
            btnInsert.TabIndex = 42;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(459, 368);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 41;
            label3.Text = "Category ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(49, 463);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 39;
            label4.Text = "Image";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(215, 368);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 38;
            label1.Text = "Units In stock";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 11F);
            lbl.Location = new Point(49, 368);
            lbl.Name = "lbl";
            lbl.Size = new Size(48, 25);
            lbl.TabIndex = 37;
            lbl.Text = "Title";
            // 
            // txtImage
            // 
            txtImage.Location = new Point(49, 502);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(310, 27);
            txtImage.TabIndex = 36;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(49, 407);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 35;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(920, 431);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(127, 80);
            btnHome.TabIndex = 34;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(920, 82);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(127, 80);
            btnPrevious.TabIndex = 32;
            btnPrevious.Text = "previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click_1;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(920, 257);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(127, 80);
            btnNext.TabIndex = 31;
            btnNext.Text = "next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click_1;
            // 
            // Datagrid
            // 
            Datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Datagrid.Location = new Point(18, 47);
            Datagrid.Name = "Datagrid";
            Datagrid.RowHeadersWidth = 51;
            Datagrid.Size = new Size(857, 302);
            Datagrid.TabIndex = 30;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { loadToolStripMenuItem, saveToolStripMenuItem, categorySelect, searchToolStripMenuItem, txtSearch });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1082, 32);
            menuStrip1.TabIndex = 33;
            menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(56, 28);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click_1;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(54, 28);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click_2;
            // 
            // categorySelect
            // 
            categorySelect.Name = "categorySelect";
            categorySelect.Size = new Size(121, 28);
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(67, 28);
            searchToolStripMenuItem.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 28);
            // 
            // ProductForAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 555);
            Controls.Add(panel1);
            Name = "ProductForAdmin";
            Text = "productForAdmin";
            Load += productForAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Datagrid).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox txtCategoryID;
        private DomainUpDown txtPrice;
        private DomainUpDown txtUnits;
        private Button button3;
        private Button button2;
        private Label label5;
        private Button btnInsert;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label lbl;
        private TextBox txtImage;
        private TextBox txtTitle;
        private Button btnHome;
        private Button btnPrevious;
        private Button btnNext;
        private DataGridView Datagrid;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripComboBox categorySelect;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripTextBox txtSearch;
    }
}