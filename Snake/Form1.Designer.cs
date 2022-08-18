namespace Snake
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.baslaButton = new System.Windows.Forms.Button();
            this.snapButton = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.highTScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saat = new System.Windows.Forms.Label();
            this.deq = new System.Windows.Forms.Label();
            this.san = new System.Windows.Forms.Label();
            this.noq1 = new System.Windows.Forms.Label();
            this.hgsaat = new System.Windows.Forms.Label();
            this.hgdeq = new System.Windows.Forms.Label();
            this.hgsan = new System.Windows.Forms.Label();
            this.noq2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // baslaButton
            // 
            this.baslaButton.BackColor = System.Drawing.SystemColors.Window;
            this.baslaButton.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baslaButton.ForeColor = System.Drawing.Color.LawnGreen;
            this.baslaButton.Location = new System.Drawing.Point(448, 15);
            this.baslaButton.Margin = new System.Windows.Forms.Padding(2);
            this.baslaButton.Name = "baslaButton";
            this.baslaButton.Size = new System.Drawing.Size(107, 41);
            this.baslaButton.TabIndex = 0;
            this.baslaButton.Text = "Başla";
            this.baslaButton.UseVisualStyleBackColor = false;
            this.baslaButton.Click += new System.EventHandler(this.oyunBasla);
            // 
            // snapButton
            // 
            this.snapButton.BackColor = System.Drawing.SystemColors.Window;
            this.snapButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snapButton.ForeColor = System.Drawing.Color.LightSlateGray;
            this.snapButton.Location = new System.Drawing.Point(448, 62);
            this.snapButton.Margin = new System.Windows.Forms.Padding(2);
            this.snapButton.Name = "snapButton";
            this.snapButton.Size = new System.Drawing.Size(107, 41);
            this.snapButton.TabIndex = 0;
            this.snapButton.Text = "Screen Shot";
            this.snapButton.UseVisualStyleBackColor = false;
            this.snapButton.Click += new System.EventHandler(this.SnapShot);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.Chartreuse;
            this.picCanvas.Location = new System.Drawing.Point(9, 14);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(2);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(435, 552);
            this.picCanvas.TabIndex = 2;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphic);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 60;
            this.gameTimer.Tick += new System.EventHandler(this.oyunvaxti);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(448, 119);
            this.txtScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(55, 13);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "Score: 0";
            this.txtScore.UseMnemonic = false;
            this.txtScore.Click += new System.EventHandler(this.score_Click);
            // 
            // highTScore
            // 
            this.highTScore.AutoSize = true;
            this.highTScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highTScore.Location = new System.Drawing.Point(448, 142);
            this.highTScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.highTScore.Name = "highTScore";
            this.highTScore.Size = new System.Drawing.Size(70, 13);
            this.highTScore.TabIndex = 1;
            this.highTScore.Text = "High Score";
            this.highTScore.UseMnemonic = false;
            this.highTScore.Visible = false;
            this.highTScore.Click += new System.EventHandler(this.score_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(482, 545);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(513, 545);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = ":";
            // 
            // saat
            // 
            this.saat.AutoSize = true;
            this.saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saat.Location = new System.Drawing.Point(459, 546);
            this.saat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(27, 20);
            this.saat.TabIndex = 3;
            this.saat.Text = "00";
            // 
            // deq
            // 
            this.deq.AutoSize = true;
            this.deq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deq.Location = new System.Drawing.Point(491, 546);
            this.deq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deq.Name = "deq";
            this.deq.Size = new System.Drawing.Size(27, 20);
            this.deq.TabIndex = 3;
            this.deq.Text = "00";
            // 
            // san
            // 
            this.san.AutoSize = true;
            this.san.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.san.Location = new System.Drawing.Point(522, 546);
            this.san.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.san.Name = "san";
            this.san.Size = new System.Drawing.Size(27, 20);
            this.san.TabIndex = 3;
            this.san.Text = "00";
            // 
            // noq1
            // 
            this.noq1.AutoSize = true;
            this.noq1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noq1.ForeColor = System.Drawing.Color.DarkRed;
            this.noq1.Location = new System.Drawing.Point(472, 163);
            this.noq1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noq1.Name = "noq1";
            this.noq1.Size = new System.Drawing.Size(14, 20);
            this.noq1.TabIndex = 3;
            this.noq1.Text = ":";
            this.noq1.Visible = false;
            // 
            // hgsaat
            // 
            this.hgsaat.AutoSize = true;
            this.hgsaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hgsaat.ForeColor = System.Drawing.Color.DarkRed;
            this.hgsaat.Location = new System.Drawing.Point(447, 164);
            this.hgsaat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hgsaat.Name = "hgsaat";
            this.hgsaat.Size = new System.Drawing.Size(29, 20);
            this.hgsaat.TabIndex = 3;
            this.hgsaat.Text = "00";
            this.hgsaat.Visible = false;
            // 
            // hgdeq
            // 
            this.hgdeq.AutoSize = true;
            this.hgdeq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hgdeq.ForeColor = System.Drawing.Color.DarkRed;
            this.hgdeq.Location = new System.Drawing.Point(484, 164);
            this.hgdeq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hgdeq.Name = "hgdeq";
            this.hgdeq.Size = new System.Drawing.Size(29, 20);
            this.hgdeq.TabIndex = 3;
            this.hgdeq.Text = "00";
            this.hgdeq.Visible = false;
            // 
            // hgsan
            // 
            this.hgsan.AutoSize = true;
            this.hgsan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hgsan.ForeColor = System.Drawing.Color.DarkRed;
            this.hgsan.Location = new System.Drawing.Point(524, 164);
            this.hgsan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hgsan.Name = "hgsan";
            this.hgsan.Size = new System.Drawing.Size(29, 20);
            this.hgsan.TabIndex = 3;
            this.hgsan.Text = "00";
            this.hgsan.Visible = false;
            // 
            // noq2
            // 
            this.noq2.AutoSize = true;
            this.noq2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noq2.ForeColor = System.Drawing.Color.DarkRed;
            this.noq2.Location = new System.Drawing.Point(512, 163);
            this.noq2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noq2.Name = "noq2";
            this.noq2.Size = new System.Drawing.Size(13, 20);
            this.noq2.TabIndex = 3;
            this.noq2.Text = ":";
            this.noq2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 583);
            this.Controls.Add(this.noq2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hgsan);
            this.Controls.Add(this.hgdeq);
            this.Controls.Add(this.san);
            this.Controls.Add(this.hgsaat);
            this.Controls.Add(this.deq);
            this.Controls.Add(this.noq1);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.highTScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.snapButton);
            this.Controls.Add(this.baslaButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Asagi);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Yuxari);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button baslaButton;
        private System.Windows.Forms.Button snapButton;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label highScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label highTScore;
        private System.Windows.Forms.Label vaxth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label vaxtm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label vaxts;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Label deq;
        private System.Windows.Forms.Label san;
        private System.Windows.Forms.Label noq1;
        private System.Windows.Forms.Label hgsaat;
        private System.Windows.Forms.Label hgdeq;
        private System.Windows.Forms.Label hgsan;
        private System.Windows.Forms.Label noq2;
    }
}

