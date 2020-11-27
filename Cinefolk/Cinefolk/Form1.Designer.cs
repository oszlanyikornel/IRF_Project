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
            this.seriesSwitchBtn = new Cinefolk.Components.Common.RoundedButton();
            this.movieSwitchBtn = new Cinefolk.Components.Common.RoundedButton();
            this.iconButton5 = new Cinefolk.Components.Common.IconButton();
            this.iconButton4 = new Cinefolk.Components.Common.IconButton();
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
            this.moviesFlowLayoutPanel.Location = new System.Drawing.Point(105, 119);
            this.moviesFlowLayoutPanel.Name = "moviesFlowLayoutPanel";
            this.moviesFlowLayoutPanel.Size = new System.Drawing.Size(696, 807);
            this.moviesFlowLayoutPanel.TabIndex = 5;
            // 
            // seriesSwitchBtn
            // 
            this.seriesSwitchBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.seriesSwitchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.seriesSwitchBtn.FlatAppearance.BorderSize = 0;
            this.seriesSwitchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seriesSwitchBtn.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold);
            this.seriesSwitchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.seriesSwitchBtn.Location = new System.Drawing.Point(668, 53);
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
            this.movieSwitchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.movieSwitchBtn.FlatAppearance.BorderSize = 0;
            this.movieSwitchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movieSwitchBtn.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold);
            this.movieSwitchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.movieSwitchBtn.Location = new System.Drawing.Point(587, 53);
            this.movieSwitchBtn.Name = "movieSwitchBtn";
            this.movieSwitchBtn.Size = new System.Drawing.Size(75, 34);
            this.movieSwitchBtn.TabIndex = 4;
            this.movieSwitchBtn.Text = "Movie";
            this.movieSwitchBtn.UseVisualStyleBackColor = false;
            this.movieSwitchBtn.Click += new System.EventHandler(this.movieSwitchBtn_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Image = ((System.Drawing.Image)(resources.GetObject("iconButton5.Image")));
            this.iconButton5.Location = new System.Drawing.Point(458, 925);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(34, 34);
            this.iconButton5.TabIndex = 3;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            this.iconButton4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Image = ((System.Drawing.Image)(resources.GetObject("iconButton4.Image")));
            this.iconButton4.Location = new System.Drawing.Point(414, 925);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(34, 34);
            this.iconButton4.TabIndex = 3;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // exportIconBtn
            // 
            this.exportIconBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exportIconBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.exportIconBtn.FlatAppearance.BorderSize = 0;
            this.exportIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportIconBtn.Image = ((System.Drawing.Image)(resources.GetObject("exportIconBtn.Image")));
            this.exportIconBtn.Location = new System.Drawing.Point(767, 53);
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
            this.searchIconBtn.Location = new System.Drawing.Point(425, 53);
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
            this.yearTextBox.Location = new System.Drawing.Point(484, 53);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(81, 34);
            this.yearTextBox.TabIndex = 1;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.searchTextBox.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold);
            this.searchTextBox.Location = new System.Drawing.Point(105, 53);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(294, 34);
            this.searchTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(947, 983);
            this.Controls.Add(this.moviesFlowLayoutPanel);
            this.Controls.Add(this.seriesSwitchBtn);
            this.Controls.Add(this.movieSwitchBtn);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.exportIconBtn);
            this.Controls.Add(this.searchIconBtn);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.searchTextBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
        private Components.Common.IconButton iconButton4;
        private Components.Common.IconButton iconButton5;
        private System.Windows.Forms.FlowLayoutPanel moviesFlowLayoutPanel;
    }
}

