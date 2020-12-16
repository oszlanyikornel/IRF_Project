namespace Cinefolk.Components
{
    partial class ExportForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ratingSwitchBtn = new Cinefolk.Components.Common.RoundedButton();
            this.titleSwitchBtn = new Cinefolk.Components.Common.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.exportBtn = new Cinefolk.Components.Common.RoundedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pageNumInc = new Cinefolk.Components.Common.RoundedNumInc();
            this.ratingNumInc = new Cinefolk.Components.Common.RoundedNumInc();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Cinefolk.Properties.Resources.Icons_X;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(324, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 15);
            this.panel1.TabIndex = 8;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // ratingSwitchBtn
            // 
            this.ratingSwitchBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ratingSwitchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.ratingSwitchBtn.FlatAppearance.BorderSize = 0;
            this.ratingSwitchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.ratingSwitchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.ratingSwitchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ratingSwitchBtn.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold);
            this.ratingSwitchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.ratingSwitchBtn.Location = new System.Drawing.Point(241, 128);
            this.ratingSwitchBtn.Name = "ratingSwitchBtn";
            this.ratingSwitchBtn.Size = new System.Drawing.Size(75, 34);
            this.ratingSwitchBtn.TabIndex = 9;
            this.ratingSwitchBtn.Text = "Rating";
            this.ratingSwitchBtn.UseVisualStyleBackColor = false;
            this.ratingSwitchBtn.Click += new System.EventHandler(this.ratingSwitchBtn_Click);
            // 
            // titleSwitchBtn
            // 
            this.titleSwitchBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleSwitchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.titleSwitchBtn.FlatAppearance.BorderSize = 0;
            this.titleSwitchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.titleSwitchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.titleSwitchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleSwitchBtn.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold);
            this.titleSwitchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.titleSwitchBtn.Location = new System.Drawing.Point(160, 128);
            this.titleSwitchBtn.Name = "titleSwitchBtn";
            this.titleSwitchBtn.Size = new System.Drawing.Size(75, 34);
            this.titleSwitchBtn.TabIndex = 10;
            this.titleSwitchBtn.Text = "Title";
            this.titleSwitchBtn.UseVisualStyleBackColor = false;
            this.titleSwitchBtn.Click += new System.EventHandler(this.titleSwitchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.label1.Location = new System.Drawing.Point(35, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sort By";
            // 
            // exportBtn
            // 
            this.exportBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.exportBtn.FlatAppearance.BorderSize = 0;
            this.exportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportBtn.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold);
            this.exportBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.exportBtn.Location = new System.Drawing.Point(140, 238);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(80, 34);
            this.exportBtn.TabIndex = 9;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.label2.Location = new System.Drawing.Point(35, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Minimum Rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.label3.Location = new System.Drawing.Point(35, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Number Of Pages";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.label4.Location = new System.Drawing.Point(33, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Export As CSV";
            // 
            // pageNumInc
            // 
            this.pageNumInc.BackColor = System.Drawing.Color.Transparent;
            this.pageNumInc.Location = new System.Drawing.Point(160, 173);
            this.pageNumInc.Name = "pageNumInc";
            this.pageNumInc.Size = new System.Drawing.Size(79, 40);
            this.pageNumInc.TabIndex = 12;
            // 
            // ratingNumInc
            // 
            this.ratingNumInc.BackColor = System.Drawing.Color.Transparent;
            this.ratingNumInc.Location = new System.Drawing.Point(160, 78);
            this.ratingNumInc.Name = "ratingNumInc";
            this.ratingNumInc.Size = new System.Drawing.Size(79, 40);
            this.ratingNumInc.TabIndex = 12;
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(360, 299);
            this.Controls.Add(this.ratingNumInc);
            this.Controls.Add(this.pageNumInc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.ratingSwitchBtn);
            this.Controls.Add(this.titleSwitchBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Common.RoundedButton ratingSwitchBtn;
        private Common.RoundedButton titleSwitchBtn;
        private System.Windows.Forms.Label label1;
        private Common.RoundedButton exportBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Common.RoundedNumInc pageNumInc;
        private Common.RoundedNumInc ratingNumInc;
    }
}