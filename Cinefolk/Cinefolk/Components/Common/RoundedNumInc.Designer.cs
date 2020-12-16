namespace Cinefolk.Components.Common
{
    partial class RoundedNumInc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numIconBtn = new Cinefolk.Components.Common.IconButton();
            this.upIconBtn = new Cinefolk.Components.Common.IconButton();
            this.downButton1 = new Cinefolk.Components.Common.IconButton();
            this.SuspendLayout();
            // 
            // numIconBtn
            // 
            this.numIconBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.numIconBtn.FlatAppearance.BorderSize = 0;
            this.numIconBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.numIconBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.numIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numIconBtn.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold);
            this.numIconBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.numIconBtn.Location = new System.Drawing.Point(2, 2);
            this.numIconBtn.Name = "numIconBtn";
            this.numIconBtn.Size = new System.Drawing.Size(34, 34);
            this.numIconBtn.TabIndex = 4;
            this.numIconBtn.Text = "1";
            this.numIconBtn.UseVisualStyleBackColor = false;
            // 
            // upIconBtn
            // 
            this.upIconBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.upIconBtn.FlatAppearance.BorderSize = 0;
            this.upIconBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.upIconBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.upIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upIconBtn.Image = global::Cinefolk.Properties.Resources.Icons_UpIcon_01;
            this.upIconBtn.Location = new System.Drawing.Point(40, 2);
            this.upIconBtn.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.upIconBtn.Name = "upIconBtn";
            this.upIconBtn.Size = new System.Drawing.Size(34, 15);
            this.upIconBtn.TabIndex = 5;
            this.upIconBtn.UseVisualStyleBackColor = false;
            this.upIconBtn.Click += new System.EventHandler(this.upIconBtn_Click);
            // 
            // downButton1
            // 
            this.downButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.downButton1.FlatAppearance.BorderSize = 0;
            this.downButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.downButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.downButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downButton1.Image = global::Cinefolk.Properties.Resources.Icons_DownIcon_03;
            this.downButton1.Location = new System.Drawing.Point(40, 20);
            this.downButton1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.downButton1.Name = "downButton1";
            this.downButton1.Size = new System.Drawing.Size(34, 15);
            this.downButton1.TabIndex = 5;
            this.downButton1.UseVisualStyleBackColor = false;
            this.downButton1.Click += new System.EventHandler(this.downButton1_Click);
            // 
            // RoundedNumInc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.downButton1);
            this.Controls.Add(this.upIconBtn);
            this.Controls.Add(this.numIconBtn);
            this.Name = "RoundedNumInc";
            this.Size = new System.Drawing.Size(79, 40);
            this.ResumeLayout(false);

        }

        #endregion
        private IconButton numIconBtn;
        private IconButton upIconBtn;
        private IconButton downButton1;
    }
}
