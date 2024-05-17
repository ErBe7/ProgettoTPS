using System.Security.Principal;

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
            Table = new DataGridView();
            WinButton = new Button();
            ResetButton = new Button();
            Label = new Label();
            EastButton = new Button();
            WestButton = new Button();
            LossButton = new Button();
            OldestFoundation = new Button();
            RecentFountation = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Table).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // form1BindingSource
            // 
            form1BindingSource.DataSource = typeof(NBA_Teams);
            // 
            // Table
            // 
            Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Table.Location = new Point(164, 27);
            Table.Name = "Table";
            Table.Size = new Size(867, 511);
            Table.TabIndex = 4;
            Table.CellContentClick += Table_CellContentClick;
            // 
            // WinButton
            // 
            WinButton.Location = new Point(37, 98);
            WinButton.Name = "WinButton";
            WinButton.Size = new Size(96, 36);
            WinButton.TabIndex = 5;
            WinButton.Text = "Win ";
            WinButton.UseVisualStyleBackColor = true;
            WinButton.Click += winButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(37, 56);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(96, 36);
            ResetButton.TabIndex = 6;
            ResetButton.Text = "Reset filters";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += resetButton_Click;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Location = new Point(62, 27);
            Label.Name = "Label";
            Label.Size = new Size(38, 15);
            Label.TabIndex = 7;
            Label.Text = "Filters";
            Label.TextAlign = ContentAlignment.TopCenter;
            // 
            // EastButton
            // 
            EastButton.Location = new Point(37, 182);
            EastButton.Name = "EastButton";
            EastButton.Size = new Size(96, 36);
            EastButton.TabIndex = 8;
            EastButton.Text = "Eastern teams";
            EastButton.UseVisualStyleBackColor = true;
            EastButton.Click += easternConferenceButton_Click;
            // 
            // WestButton
            // 
            WestButton.Location = new Point(37, 224);
            WestButton.Name = "WestButton";
            WestButton.Size = new Size(96, 36);
            WestButton.TabIndex = 9;
            WestButton.Text = "Western teams";
            WestButton.UseVisualStyleBackColor = true;
            WestButton.Click += westernConferenceButton_Click;
            // 
            // LossButton
            // 
            LossButton.Location = new Point(37, 140);
            LossButton.Name = "LossButton";
            LossButton.Size = new Size(96, 36);
            LossButton.TabIndex = 10;
            LossButton.Text = "Loss";
            LossButton.UseVisualStyleBackColor = true;
            LossButton.Click += lossButton_Click;
            // 
            // OldestFoundation
            // 
            OldestFoundation.Location = new Point(37, 308);
            OldestFoundation.Name = "OldestFoundation";
            OldestFoundation.Size = new Size(96, 36);
            OldestFoundation.TabIndex = 12;
            OldestFoundation.Text = "Oldest teams";
            OldestFoundation.UseVisualStyleBackColor = true;
            OldestFoundation.Click += oldestFoundation_Click;
            // 
            // RecentFountation
            // 
            RecentFountation.Location = new Point(37, 266);
            RecentFountation.Name = "RecentFountation";
            RecentFountation.Size = new Size(96, 36);
            RecentFountation.TabIndex = 13;
            RecentFountation.Text = "Recent teams";
            RecentFountation.UseVisualStyleBackColor = true;
            RecentFountation.Click += recentFountation_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 350);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // NBA_Teams
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1043, 550);
            Controls.Add(pictureBox1);
            Controls.Add(RecentFountation);
            Controls.Add(OldestFoundation);
            Controls.Add(LossButton);
            Controls.Add(WestButton);
            Controls.Add(EastButton);
            Controls.Add(Label);
            Controls.Add(ResetButton);
            Controls.Add(WinButton);
            Controls.Add(Table);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NBA_Teams";
            Text = "NBA Teams";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)Table).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private BindingSource form1BindingSource;
        private DataGridView Table;
        private Button WinButton;
        private Button ResetButton;
        private Label Label;
        private Button EastButton;
        private Button WestButton;
        private Button LossButton;
        private Button OldestFoundation;
        private Button RecentFountation;
        private PictureBox pictureBox1;
    }
}
