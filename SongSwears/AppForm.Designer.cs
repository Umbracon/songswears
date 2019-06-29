namespace SongSwears
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.run = new System.Windows.Forms.Button();
            this.tooltip1 = new System.Windows.Forms.Label();
            this.lyrics = new System.Windows.Forms.RichTextBox();
            this.tooltip2 = new System.Windows.Forms.Label();
            this.artist = new System.Windows.Forms.RichTextBox();
            this.tooltip3 = new System.Windows.Forms.Label();
            this.tooltip4 = new System.Windows.Forms.Label();
            this.quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // run
            // 
            this.run.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.run.BackColor = System.Drawing.Color.White;
            this.run.Cursor = System.Windows.Forms.Cursors.Hand;
            this.run.ForeColor = System.Drawing.Color.Black;
            this.run.Location = new System.Drawing.Point(359, 248);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(90, 40);
            this.run.TabIndex = 1;
            this.run.TabStop = false;
            this.run.Text = "ANALYZE";
            this.run.UseVisualStyleBackColor = false;
            this.run.Click += new System.EventHandler(this.Run_Click);
            // 
            // tooltip1
            // 
            this.tooltip1.AutoSize = true;
            this.tooltip1.BackColor = System.Drawing.Color.Transparent;
            this.tooltip1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tooltip1.ForeColor = System.Drawing.Color.White;
            this.tooltip1.Location = new System.Drawing.Point(164, 59);
            this.tooltip1.Name = "tooltip1";
            this.tooltip1.Size = new System.Drawing.Size(471, 20);
            this.tooltip1.TabIndex = 2;
            this.tooltip1.Text = "Please paste the lyrics of your song and press ANALYZE";
            // 
            // lyrics
            // 
            this.lyrics.BackColor = System.Drawing.Color.Black;
            this.lyrics.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lyrics.ForeColor = System.Drawing.Color.White;
            this.lyrics.Location = new System.Drawing.Point(52, 110);
            this.lyrics.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.lyrics.Name = "lyrics";
            this.lyrics.Size = new System.Drawing.Size(690, 110);
            this.lyrics.TabIndex = 3;
            this.lyrics.Text = "";
            // 
            // tooltip2
            // 
            this.tooltip2.AutoSize = true;
            this.tooltip2.BackColor = System.Drawing.Color.Transparent;
            this.tooltip2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tooltip2.Location = new System.Drawing.Point(49, 223);
            this.tooltip2.Name = "tooltip2";
            this.tooltip2.Size = new System.Drawing.Size(68, 15);
            this.tooltip2.TabIndex = 4;
            this.tooltip2.Text = "paste here";
            // 
            // artist
            // 
            this.artist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.artist.BackColor = System.Drawing.Color.Black;
            this.artist.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.artist.ForeColor = System.Drawing.Color.Orchid;
            this.artist.Location = new System.Drawing.Point(407, 363);
            this.artist.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.artist.Name = "artist";
            this.artist.ReadOnly = true;
            this.artist.Size = new System.Drawing.Size(264, 27);
            this.artist.TabIndex = 3;
            this.artist.Text = "";
            // 
            // tooltip3
            // 
            this.tooltip3.AutoSize = true;
            this.tooltip3.BackColor = System.Drawing.Color.Transparent;
            this.tooltip3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tooltip3.Location = new System.Drawing.Point(404, 393);
            this.tooltip3.Name = "tooltip3";
            this.tooltip3.Size = new System.Drawing.Size(116, 15);
            this.tooltip3.TabIndex = 4;
            this.tooltip3.Text = "your result, darling";
            // 
            // tooltip4
            // 
            this.tooltip4.AutoSize = true;
            this.tooltip4.BackColor = System.Drawing.Color.Transparent;
            this.tooltip4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tooltip4.ForeColor = System.Drawing.Color.White;
            this.tooltip4.Location = new System.Drawing.Point(144, 368);
            this.tooltip4.Name = "tooltip4";
            this.tooltip4.Size = new System.Drawing.Size(250, 20);
            this.tooltip4.TabIndex = 2;
            this.tooltip4.Text = "I reckon this song belongs to";
            // 
            // quit
            // 
            this.quit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quit.BackColor = System.Drawing.Color.White;
            this.quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit.ForeColor = System.Drawing.Color.Black;
            this.quit.Location = new System.Drawing.Point(744, 421);
            this.quit.Margin = new System.Windows.Forms.Padding(0);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(50, 20);
            this.quit.TabIndex = 1;
            this.quit.TabStop = false;
            this.quit.Text = "QUIT";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // AppForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::SongSwears.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.tooltip3);
            this.Controls.Add(this.tooltip2);
            this.Controls.Add(this.artist);
            this.Controls.Add(this.lyrics);
            this.Controls.Add(this.tooltip4);
            this.Controls.Add(this.tooltip1);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.run);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "SongSwears";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Label tooltip1;
        private System.Windows.Forms.Label tooltip2;
        private System.Windows.Forms.RichTextBox artist;
        private System.Windows.Forms.Label tooltip3;
        private System.Windows.Forms.Label tooltip4;
        private System.Windows.Forms.RichTextBox lyrics;
        private System.Windows.Forms.Button quit;
    }
}