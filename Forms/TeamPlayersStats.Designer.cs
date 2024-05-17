
namespace ProgettoTPS
{
    partial class TeamPlayersStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamPlayersStats));
            dataGridView1 = new DataGridView();
            teamPictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teamPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(714, 332);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // teamPictureBox1
            // 
            teamPictureBox1.Location = new Point(732, 34);
            teamPictureBox1.Name = "teamPictureBox1";
            teamPictureBox1.Size = new Size(388, 332);
            teamPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            teamPictureBox1.TabIndex = 1;
            teamPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(248, 372);
            button1.Name = "button1";
            button1.Size = new Size(90, 45);
            button1.TabIndex = 3;
            button1.Text = "Giocatori con meno partite";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(152, 372);
            button2.Name = "button2";
            button2.Size = new Size(90, 45);
            button2.TabIndex = 4;
            button2.Text = "Giocatori con più partite";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(56, 372);
            button3.Name = "button3";
            button3.Size = new Size(90, 45);
            button3.TabIndex = 5;
            button3.Text = "Reset Filters";
            button3.UseVisualStyleBackColor = true;
            button3.Click += resetButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 387);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "Filters";
            // 
            // TeamPlayersStats
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 498);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(teamPictureBox1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TeamPlayersStats";
            Text = "Players Stats";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)teamPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox teamPictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
    }
}