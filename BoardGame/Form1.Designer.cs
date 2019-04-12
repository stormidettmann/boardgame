namespace BoardGame
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.soundOnOff = new System.Windows.Forms.ImageList(this.components);
            this.sound_button = new System.Windows.Forms.Button();
            this.p1_name_score = new System.Windows.Forms.Label();
            this.p2_name_score = new System.Windows.Forms.Label();
            this.p3_name_score = new System.Windows.Forms.Label();
            this.p4_name_score = new System.Windows.Forms.Label();
            this.p4_score = new System.Windows.Forms.Label();
            this.p3_score = new System.Windows.Forms.Label();
            this.p2_score = new System.Windows.Forms.Label();
            this.p1_score = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rollDieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roll_button = new System.Windows.Forms.Button();
            this.dice = new System.Windows.Forms.ImageList(this.components);
            this.active_player_label = new System.Windows.Forms.Label();
            this.roll_prompt = new System.Windows.Forms.Label();
            this.plus_score_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(75, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(650, 450);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // soundOnOff
            // 
            this.soundOnOff.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("soundOnOff.ImageStream")));
            this.soundOnOff.TransparentColor = System.Drawing.Color.Transparent;
            this.soundOnOff.Images.SetKeyName(0, "sound_off_black.png");
            this.soundOnOff.Images.SetKeyName(1, "sound_on_black.png");
            // 
            // sound_button
            // 
            this.sound_button.BackColor = System.Drawing.Color.Black;
            this.sound_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.sound_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.sound_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sound_button.ImageIndex = 1;
            this.sound_button.ImageList = this.soundOnOff;
            this.sound_button.Location = new System.Drawing.Point(639, 476);
            this.sound_button.Name = "sound_button";
            this.sound_button.Size = new System.Drawing.Size(57, 48);
            this.sound_button.TabIndex = 3;
            this.sound_button.UseVisualStyleBackColor = false;
            this.sound_button.Click += new System.EventHandler(this.sound_button_Click);
            // 
            // p1_name_score
            // 
            this.p1_name_score.AutoSize = true;
            this.p1_name_score.BackColor = System.Drawing.Color.Black;
            this.p1_name_score.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_name_score.ForeColor = System.Drawing.Color.White;
            this.p1_name_score.Location = new System.Drawing.Point(90, 377);
            this.p1_name_score.Name = "p1_name_score";
            this.p1_name_score.Size = new System.Drawing.Size(125, 28);
            this.p1_name_score.TabIndex = 4;
            this.p1_name_score.Text = "Player 1   ";
            // 
            // p2_name_score
            // 
            this.p2_name_score.AutoSize = true;
            this.p2_name_score.BackColor = System.Drawing.Color.Black;
            this.p2_name_score.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_name_score.ForeColor = System.Drawing.Color.White;
            this.p2_name_score.Location = new System.Drawing.Point(90, 412);
            this.p2_name_score.Name = "p2_name_score";
            this.p2_name_score.Size = new System.Drawing.Size(125, 28);
            this.p2_name_score.TabIndex = 5;
            this.p2_name_score.Text = "Player 2   ";
            // 
            // p3_name_score
            // 
            this.p3_name_score.AutoSize = true;
            this.p3_name_score.BackColor = System.Drawing.Color.Black;
            this.p3_name_score.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3_name_score.ForeColor = System.Drawing.Color.White;
            this.p3_name_score.Location = new System.Drawing.Point(90, 447);
            this.p3_name_score.Name = "p3_name_score";
            this.p3_name_score.Size = new System.Drawing.Size(125, 28);
            this.p3_name_score.TabIndex = 6;
            this.p3_name_score.Text = "Player 3   ";
            // 
            // p4_name_score
            // 
            this.p4_name_score.AutoSize = true;
            this.p4_name_score.BackColor = System.Drawing.Color.Black;
            this.p4_name_score.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4_name_score.ForeColor = System.Drawing.Color.White;
            this.p4_name_score.Location = new System.Drawing.Point(90, 482);
            this.p4_name_score.Name = "p4_name_score";
            this.p4_name_score.Size = new System.Drawing.Size(125, 28);
            this.p4_name_score.TabIndex = 7;
            this.p4_name_score.Text = "Player 4   ";
            // 
            // p4_score
            // 
            this.p4_score.AutoSize = true;
            this.p4_score.BackColor = System.Drawing.Color.Black;
            this.p4_score.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4_score.ForeColor = System.Drawing.Color.White;
            this.p4_score.Location = new System.Drawing.Point(218, 482);
            this.p4_score.Name = "p4_score";
            this.p4_score.Size = new System.Drawing.Size(25, 28);
            this.p4_score.TabIndex = 11;
            this.p4_score.Text = "0";
            // 
            // p3_score
            // 
            this.p3_score.AutoSize = true;
            this.p3_score.BackColor = System.Drawing.Color.Black;
            this.p3_score.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3_score.ForeColor = System.Drawing.Color.Red;
            this.p3_score.Location = new System.Drawing.Point(218, 447);
            this.p3_score.Name = "p3_score";
            this.p3_score.Size = new System.Drawing.Size(25, 28);
            this.p3_score.TabIndex = 10;
            this.p3_score.Text = "0";
            // 
            // p2_score
            // 
            this.p2_score.AutoSize = true;
            this.p2_score.BackColor = System.Drawing.Color.Black;
            this.p2_score.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_score.ForeColor = System.Drawing.Color.SteelBlue;
            this.p2_score.Location = new System.Drawing.Point(218, 412);
            this.p2_score.Name = "p2_score";
            this.p2_score.Size = new System.Drawing.Size(25, 28);
            this.p2_score.TabIndex = 9;
            this.p2_score.Text = "0";
            // 
            // p1_score
            // 
            this.p1_score.AutoSize = true;
            this.p1_score.BackColor = System.Drawing.Color.Black;
            this.p1_score.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_score.ForeColor = System.Drawing.Color.Gold;
            this.p1_score.Location = new System.Drawing.Point(218, 377);
            this.p1_score.Name = "p1_score";
            this.p1_score.Size = new System.Drawing.Size(25, 28);
            this.p1_score.TabIndex = 8;
            this.p1_score.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soundToolStripMenuItem,
            this.rollDieToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // soundToolStripMenuItem
            // 
            this.soundToolStripMenuItem.Name = "soundToolStripMenuItem";
            this.soundToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.soundToolStripMenuItem.Text = "Toggle Mute";
            this.soundToolStripMenuItem.Click += new System.EventHandler(this.soundToolStripMenuItem_Click);
            // 
            // rollDieToolStripMenuItem
            // 
            this.rollDieToolStripMenuItem.Name = "rollDieToolStripMenuItem";
            this.rollDieToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.rollDieToolStripMenuItem.Text = "Roll Die";
            this.rollDieToolStripMenuItem.Click += new System.EventHandler(this.rollDieToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToToolStripMenuItem
            // 
            this.howToToolStripMenuItem.Name = "howToToolStripMenuItem";
            this.howToToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.howToToolStripMenuItem.Text = "How To Play";
            this.howToToolStripMenuItem.Click += new System.EventHandler(this.howToToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // roll_button
            // 
            this.roll_button.BackColor = System.Drawing.Color.Black;
            this.roll_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roll_button.BackgroundImage")));
            this.roll_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roll_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.roll_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.roll_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roll_button.ImageIndex = 5;
            this.roll_button.ImageList = this.dice;
            this.roll_button.Location = new System.Drawing.Point(333, 310);
            this.roll_button.Name = "roll_button";
            this.roll_button.Size = new System.Drawing.Size(140, 121);
            this.roll_button.TabIndex = 13;
            this.roll_button.UseVisualStyleBackColor = false;
            this.roll_button.Click += new System.EventHandler(this.roll_button_Click);
            // 
            // dice
            // 
            this.dice.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("dice.ImageStream")));
            this.dice.TransparentColor = System.Drawing.Color.Transparent;
            this.dice.Images.SetKeyName(0, "1.png");
            this.dice.Images.SetKeyName(1, "1.png");
            this.dice.Images.SetKeyName(2, "2.png");
            this.dice.Images.SetKeyName(3, "3.png");
            this.dice.Images.SetKeyName(4, "4.png");
            this.dice.Images.SetKeyName(5, "5.png");
            this.dice.Images.SetKeyName(6, "6.png");
            // 
            // active_player_label
            // 
            this.active_player_label.AutoSize = true;
            this.active_player_label.BackColor = System.Drawing.Color.Black;
            this.active_player_label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.active_player_label.ForeColor = System.Drawing.Color.White;
            this.active_player_label.Location = new System.Drawing.Point(319, 227);
            this.active_player_label.Name = "active_player_label";
            this.active_player_label.Size = new System.Drawing.Size(184, 28);
            this.active_player_label.TabIndex = 15;
            this.active_player_label.Text = "Player 1\'s turn  ";
            this.active_player_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // roll_prompt
            // 
            this.roll_prompt.AutoSize = true;
            this.roll_prompt.BackColor = System.Drawing.Color.Black;
            this.roll_prompt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roll_prompt.ForeColor = System.Drawing.Color.White;
            this.roll_prompt.Location = new System.Drawing.Point(320, 278);
            this.roll_prompt.Name = "roll_prompt";
            this.roll_prompt.Size = new System.Drawing.Size(162, 19);
            this.roll_prompt.TabIndex = 16;
            this.roll_prompt.Text = "(Click the die to roll)";
            // 
            // plus_score_label
            // 
            this.plus_score_label.AutoSize = true;
            this.plus_score_label.BackColor = System.Drawing.Color.Black;
            this.plus_score_label.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_score_label.ForeColor = System.Drawing.Color.White;
            this.plus_score_label.Location = new System.Drawing.Point(589, 135);
            this.plus_score_label.Name = "plus_score_label";
            this.plus_score_label.Size = new System.Drawing.Size(107, 77);
            this.plus_score_label.TabIndex = 17;
            this.plus_score_label.Text = "+5";
            this.plus_score_label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 628);
            this.Controls.Add(this.plus_score_label);
            this.Controls.Add(this.roll_prompt);
            this.Controls.Add(this.active_player_label);
            this.Controls.Add(this.roll_button);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.sound_button);
            this.Controls.Add(this.p4_score);
            this.Controls.Add(this.p3_score);
            this.Controls.Add(this.p2_score);
            this.Controls.Add(this.p1_score);
            this.Controls.Add(this.p4_name_score);
            this.Controls.Add(this.p3_name_score);
            this.Controls.Add(this.p2_name_score);
            this.Controls.Add(this.p1_name_score);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Space Quest";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList soundOnOff;
        private System.Windows.Forms.Button sound_button;
        private System.Windows.Forms.Label p1_name_score;
        private System.Windows.Forms.Label p2_name_score;
        private System.Windows.Forms.Label p3_name_score;
        private System.Windows.Forms.Label p4_name_score;
        private System.Windows.Forms.Label p4_score;
        private System.Windows.Forms.Label p3_score;
        private System.Windows.Forms.Label p2_score;
        private System.Windows.Forms.Label p1_score;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button roll_button;
        private System.Windows.Forms.Label active_player_label;
        private System.Windows.Forms.ImageList dice;
        private System.Windows.Forms.Label roll_prompt;
        private System.Windows.Forms.ToolStripMenuItem soundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rollDieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label plus_score_label;
    }
}

