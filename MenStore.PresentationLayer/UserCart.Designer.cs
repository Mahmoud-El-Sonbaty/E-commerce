namespace MenStore.PresentationLayer
{
    partial class UserCart
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
            menuStrip1 = new MenuStrip();
            orderHistoryToolStripMenuItem = new ToolStripMenuItem();
            cartToolStripMenuItem = new ToolStripMenuItem();
            processingToolStripMenuItem = new ToolStripMenuItem();
            MasterDataGrid = new DataGridView();
            DetailDataGrid = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MasterDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DetailDataGrid).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { orderHistoryToolStripMenuItem, cartToolStripMenuItem, processingToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1182, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // orderHistoryToolStripMenuItem
            // 
            orderHistoryToolStripMenuItem.Name = "orderHistoryToolStripMenuItem";
            orderHistoryToolStripMenuItem.Size = new Size(112, 24);
            orderHistoryToolStripMenuItem.Text = "Order History";
            orderHistoryToolStripMenuItem.Click += orderHistoryToolStripMenuItem_Click;
            // 
            // cartToolStripMenuItem
            // 
            cartToolStripMenuItem.Name = "cartToolStripMenuItem";
            cartToolStripMenuItem.Size = new Size(50, 24);
            cartToolStripMenuItem.Text = "Cart";
            cartToolStripMenuItem.Click += cartToolStripMenuItem_Click;
            // 
            // processingToolStripMenuItem
            // 
            processingToolStripMenuItem.Name = "processingToolStripMenuItem";
            processingToolStripMenuItem.Size = new Size(93, 24);
            processingToolStripMenuItem.Text = "Processing";
            processingToolStripMenuItem.Click += processingToolStripMenuItem_Click;
            // 
            // MasterDataGrid
            // 
            MasterDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MasterDataGrid.Location = new Point(12, 62);
            MasterDataGrid.Name = "MasterDataGrid";
            MasterDataGrid.RowHeadersWidth = 51;
            MasterDataGrid.Size = new Size(604, 301);
            MasterDataGrid.TabIndex = 1;
            MasterDataGrid.CellContentClick += MasterDataGrid_CellContentClick;
            // 
            // DetailDataGrid
            // 
            DetailDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DetailDataGrid.Location = new Point(676, 62);
            DetailDataGrid.Name = "DetailDataGrid";
            DetailDataGrid.RowHeadersWidth = 51;
            DetailDataGrid.Size = new Size(494, 301);
            DetailDataGrid.TabIndex = 2;
            DetailDataGrid.CellContentClick += DetailDataGrid_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 39);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 3;
            label1.Text = "Masters";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(907, 39);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 4;
            label2.Text = "Details";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(70, 24);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // UserCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 553);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DetailDataGrid);
            Controls.Add(MasterDataGrid);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1000, 600);
            Name = "UserCart";
            Text = "My Orders";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MasterDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)DetailDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem orderHistoryToolStripMenuItem;
        private ToolStripMenuItem cartToolStripMenuItem;
        private ToolStripMenuItem processingToolStripMenuItem;
        private DataGridView MasterDataGrid;
        private DataGridView DetailDataGrid;
        private Label label1;
        private Label label2;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}
