
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
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
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
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(112, 433);
            button1.Name = "button1";
            button1.Size = new Size(100, 55);
            button1.TabIndex = 3;
            button1.Text = "Giocatori con meno partite";
            button1.UseVisualStyleBackColor = true;
            button1.Click += lessButtonGame_Click;
            // 
            // button2
            // 
            button2.Location = new Point(112, 372);
            button2.Name = "button2";
            button2.Size = new Size(100, 55);
            button2.TabIndex = 4;
            button2.Text = "Giocatori con più partite";
            button2.UseVisualStyleBackColor = true;
            button2.Click += mostGameButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(56, 372);
            button3.Name = "button3";
            button3.Size = new Size(50, 55);
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
            // button4
            // 
            button4.Location = new Point(218, 372);
            button4.Name = "button4";
            button4.Size = new Size(100, 55);
            button4.TabIndex = 8;
            button4.Text = "Giocatori con più minuti per partita";
            button4.UseVisualStyleBackColor = true;
            button4.Click += mostMinutesPerGameButton_Click;
            // 
            // button5
            // 
            button5.Location = new Point(218, 433);
            button5.Name = "button5";
            button5.Size = new Size(100, 55);
            button5.TabIndex = 9;
            button5.Text = "Giocatori con meno minuti per partita";
            button5.UseVisualStyleBackColor = true;
            button5.Click += lessMinutesPerGameButton_Click;
            // 
            // button6
            // 
            button6.Location = new Point(324, 372);
            button6.Name = "button6";
            button6.Size = new Size(100, 55);
            button6.TabIndex = 10;
            button6.Text = "Giocatori con più punti per partita";
            button6.UseVisualStyleBackColor = true;
            button6.Click += mostPointsPerGameButton_Click;
            // 
            // button7
            // 
            button7.Location = new Point(324, 433);
            button7.Name = "button7";
            button7.Size = new Size(100, 55);
            button7.TabIndex = 11;
            button7.Text = "Giocatori con meno punti per partita";
            button7.UseVisualStyleBackColor = true;
            button7.Click += lessPointsPerGameButton_Click;
            // 
            // button8
            // 
            button8.Location = new Point(430, 372);
            button8.Name = "button8";
            button8.Size = new Size(100, 55);
            button8.TabIndex = 12;
            button8.Text = "Giocatori con più rimbalzi per partita";
            button8.UseVisualStyleBackColor = true;
            button8.Click += mostReboundsPerGameButton_Click;
            // 
            // button9
            // 
            button9.Location = new Point(430, 433);
            button9.Name = "button9";
            button9.Size = new Size(100, 55);
            button9.TabIndex = 13;
            button9.Text = "Giocatori con meno rimbalzi per partita";
            button9.UseVisualStyleBackColor = true;
            button9.Click += lessReboundsPerGameButton_Click;
            // 
            // button10
            // 
            button10.Location = new Point(536, 372);
            button10.Name = "button10";
            button10.Size = new Size(100, 55);
            button10.TabIndex = 14;
            button10.Text = "Giocatori con più assist per partita";
            button10.UseVisualStyleBackColor = true;
            button10.Click += mostAssistPerGameButton_Click;
            // 
            // button11
            // 
            button11.Location = new Point(642, 372);
            button11.Name = "button11";
            button11.Size = new Size(84, 55);
            button11.TabIndex = 15;
            button11.Text = "Giocatori con più palle rubate";
            button11.UseVisualStyleBackColor = true;
            button11.Click += mostStealsPerGameButton_Click;
            // 
            // button12
            // 
            button12.Location = new Point(536, 433);
            button12.Name = "button12";
            button12.Size = new Size(100, 55);
            button12.TabIndex = 16;
            button12.Text = "Giocatori con meno assist per partita";
            button12.UseVisualStyleBackColor = true;
            button12.Click += lessAssistPerGameButton_Click;
            // 
            // button13
            // 
            button13.Location = new Point(642, 433);
            button13.Name = "button13";
            button13.Size = new Size(84, 55);
            button13.TabIndex = 17;
            button13.Text = "Giocatori con meno palle rubate";
            button13.UseVisualStyleBackColor = true;
            button13.Click += lessStealsPerGameButton_Click;
            // 
            // button14
            // 
            button14.Location = new Point(872, 402);
            button14.Name = "button14";
            button14.Size = new Size(108, 53);
            button14.TabIndex = 18;
            button14.Text = "Return to main window";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // TeamPlayersStats
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 498);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
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
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
    }
}