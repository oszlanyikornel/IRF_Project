namespace Cinefolk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.moviesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.seriesSwitchBtn = new Cinefolk.Components.Common.RoundedButton();
            this.movieSwitchBtn = new Cinefolk.Components.Common.RoundedButton();
            this.forwardIconBtn = new Cinefolk.Components.Common.IconButton();
            this.backwardsIconBtn = new Cinefolk.Components.Common.IconButton();
            this.exportIconBtn = new Cinefolk.Components.Common.IconButton();
            this.searchIconBtn = new Cinefolk.Components.Common.IconButton();
            this.iconButton1 = new Cinefolk.Components.Common.IconButton();
            this.yearTextBox = new Cinefolk.Components.YearTextBox();
            this.searchTextBox = new Cinefolk.Components.Common.RoundedTextBox();
            this.SuspendLayout();
            // 
            // moviesFlowLayoutPanel
            // 
            this.moviesFlowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.moviesFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.moviesFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.moviesFlowLayoutPanel.Location = new System.Drawing.Point(105, 71);
            this.moviesFlowLayoutPanel.Name = "moviesFlowLayoutPanel";
            this.moviesFlowLayoutPanel.Size = new System.Drawing.Size(696, 895);
            this.moviesFlowLayoutPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(914, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 15);
            this.panel1.TabIndex = 7;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // seriesSwitchBtn
            // 
            this.seriesSwitchBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.seriesSwitchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.seriesSwitchBtn.FlatAppearance.BorderSize = 0;
            this.seriesSwitchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seriesSwitchBtn.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold);
            this.seriesSwitchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.seriesSwitchBtn.Location = new System.Drawing.Point(668, 23);
            this.seriesSwitchBtn.Name = "seriesSwitchBtn";
            this.seriesSwitchBtn.Size = new System.Drawing.Size(75, 34);
            this.seriesSwitchBtn.TabIndex = 4;
            this.seriesSwitchBtn.Text = "Series";
            this.seriesSwitchBtn.UseVisualStyleBackColor = false;
            this.seriesSwitchBtn.Click += new System.EventHandler(this.seriesSwitchBtn_Click);
            // 
            // movieSwitchBtn
            // 
            this.movieSwitchBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.movieSwitchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.movieSwitchBtn.FlatAppearance.BorderSize = 0;
            this.movieSwitchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movieSwitchBtn.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold);
            this.movieSwitchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.movieSwitchBtn.Location = new System.Drawing.Point(587, 23);
            this.movieSwitchBtn.Name = "movieSwitchBtn";
            this.movieSwitchBtn.Size = new System.Drawing.Size(75, 34);
            this.movieSwitchBtn.TabIndex = 4;
            this.movieSwitchBtn.Text = "Movie";
            this.movieSwitchBtn.UseVisualStyleBackColor = false;
            this.movieSwitchBtn.Click += new System.EventHandler(this.movieSwitchBtn_Click);
            // 
            // forwardIconBtn
            // 
            this.forwardIconBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.forwardIconBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.forwardIconBtn.Enabled = false;
            this.forwardIconBtn.FlatAppearance.BorderSize = 0;
            this.forwardIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardIconBtn.Image = ((System.Drawing.Image)(resources.GetObject("forwardIconBtn.Image")));
            this.forwardIconBtn.Location = new System.Drawing.Point(458, 967);
            this.forwardIconBtn.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.forwardIconBtn.Name = "forwardIconBtn";
            this.forwardIconBtn.Size = new System.Drawing.Size(34, 34);
            this.forwardIconBtn.TabIndex = 3;
            this.forwardIconBtn.UseVisualStyleBackColor = false;
            this.forwardIconBtn.Click += new System.EventHandler(this.forwardIconBtn_Click);
            // 
            // backwardsIconBtn
            // 
            this.backwardsIconBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backwardsIconBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.backwardsIconBtn.Enabled = false;
            this.backwardsIconBtn.FlatAppearance.BorderSize = 0;
            this.backwardsIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backwardsIconBtn.Image = ((System.Drawing.Image)(resources.GetObject("backwardsIconBtn.Image")));
            this.backwardsIconBtn.Location = new System.Drawing.Point(414, 967);
            this.backwardsIconBtn.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.backwardsIconBtn.Name = "backwardsIconBtn";
            this.backwardsIconBtn.Size = new System.Drawing.Size(34, 34);
            this.backwardsIconBtn.TabIndex = 3;
            this.backwardsIconBtn.UseVisualStyleBackColor = false;
            this.backwardsIconBtn.Click += new System.EventHandler(this.backwardsIconBtn_Click);
            // 
            // exportIconBtn
            // 
            this.exportIconBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exportIconBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.exportIconBtn.FlatAppearance.BorderSize = 0;
            this.exportIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportIconBtn.Image = ((System.Drawing.Image)(resources.GetObject("exportIconBtn.Image")));
            this.exportIconBtn.Location = new System.Drawing.Point(767, 23);
            this.exportIconBtn.Name = "exportIconBtn";
            this.exportIconBtn.Size = new System.Drawing.Size(34, 34);
            this.exportIconBtn.TabIndex = 3;
            this.exportIconBtn.UseVisualStyleBackColor = false;
            this.exportIconBtn.Click += new System.EventHandler(this.exportIconBtn_Click);
            // 
            // searchIconBtn
            // 
            this.searchIconBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchIconBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.searchIconBtn.FlatAppearance.BorderSize = 0;
            this.searchIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchIconBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchIconBtn.Image")));
            this.searchIconBtn.Location = new System.Drawing.Point(425, 23);
            this.searchIconBtn.Name = "searchIconBtn";
            this.searchIconBtn.Size = new System.Drawing.Size(34, 34);
            this.searchIconBtn.TabIndex = 3;
            this.searchIconBtn.UseVisualStyleBackColor = false;
            this.searchIconBtn.Click += new System.EventHandler(this.searchIconBtn_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Location = new System.Drawing.Point(328, 242);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(34, 34);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.yearTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.yearTextBox.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold);
            this.yearTextBox.Location = new System.Drawing.Point(484, 23);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(81, 34);
            this.yearTextBox.TabIndex = 1;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.searchTextBox.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold);
            this.searchTextBox.Location = new System.Drawing.Point(105, 23);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(294, 34);
            this.searchTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(947, 1019);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.moviesFlowLayoutPanel);
            this.Controls.Add(this.seriesSwitchBtn);
            this.Controls.Add(this.movieSwitchBtn);
            this.Controls.Add(this.forwardIconBtn);
            this.Controls.Add(this.backwardsIconBtn);
            this.Controls.Add(this.exportIconBtn);
            this.Controls.Add(this.searchIconBtn);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.searchTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown_1);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.Common.RoundedTextBox searchTextBox;
        private Components.YearTextBox yearTextBox;
        private Components.Common.IconButton iconButton1;
        private Components.Common.IconButton searchIconBtn;
        private Components.Common.RoundedButton movieSwitchBtn;
        private Components.Common.RoundedButton seriesSwitchBtn;
        private Components.Common.IconButton exportIconBtn;
        private Components.Common.IconButton backwardsIconBtn;
        private Components.Common.IconButton forwardIconBtn;
        private System.Windows.Forms.FlowLayoutPanel moviesFlowLayoutPanel;
        private System.Windows.Forms.Panel panel1;
    }
}

