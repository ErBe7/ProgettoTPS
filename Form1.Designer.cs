namespace ProgettoTPS
{
    partial class NBA_Teams
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NBA_Teams));
            form1BindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            fILTRIToolStripMenuItem = new ToolStripMenuItem();
            wLToolStripMenuItem = new ToolStripMenuItem();
            conferenceToolStripMenuItem = new ToolStripMenuItem();
            eastToolStripMenuItem = new ToolStripMenuItem();
            westToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // form1BindingSource
            // 
            form1BindingSource.DataSource = typeof(NBA_Teams);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fILTRIToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(971, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fILTRIToolStripMenuItem
            // 
            fILTRIToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { wLToolStripMenuItem, conferenceToolStripMenuItem });
            fILTRIToolStripMenuItem.Name = "fILTRIToolStripMenuItem";
            fILTRIToolStripMenuItem.Size = new Size(42, 20);
            fILTRIToolStripMenuItem.Text = "Filtri";
            // 
            // wLToolStripMenuItem
            // 
            wLToolStripMenuItem.Name = "wLToolStripMenuItem";
            wLToolStripMenuItem.Size = new Size(135, 22);
            wLToolStripMenuItem.Text = "W/L";
            // 
            // conferenceToolStripMenuItem
            // 
            conferenceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eastToolStripMenuItem, westToolStripMenuItem });
            conferenceToolStripMenuItem.Name = "conferenceToolStripMenuItem";
            conferenceToolStripMenuItem.Size = new Size(135, 22);
            conferenceToolStripMenuItem.Text = "Conference";
            // 
            // eastToolStripMenuItem
            // 
            eastToolStripMenuItem.Name = "eastToolStripMenuItem";
            eastToolStripMenuItem.Size = new Size(100, 22);
            eastToolStripMenuItem.Text = "East";
            // 
            // westToolStripMenuItem
            // 
            westToolStripMenuItem.Name = "westToolStripMenuItem";
            westToolStripMenuItem.Size = new Size(100, 22);
            westToolStripMenuItem.Text = "West";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(561, 511);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NBA_Teams
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(971, 550);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "NBA_Teams";
            Text = "NBA Teams";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource form1BindingSource;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fILTRIToolStripMenuItem;
        private ToolStripMenuItem wLToolStripMenuItem;
        private ToolStripMenuItem conferenceToolStripMenuItem;
        private ToolStripMenuItem eastToolStripMenuItem;
        private ToolStripMenuItem westToolStripMenuItem;
        private DataGridView dataGridView1;
    }
}
