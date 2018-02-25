namespace TimeFrame
{
    partial class frm_startup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_startup));
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_footer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(132, 83);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(173, 73);
            this.btn_enter.TabIndex = 0;
            this.btn_enter.Text = "Enter TimeFrame";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(438, 83);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(173, 73);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_footer
            // 
            this.lbl_footer.AutoSize = true;
            this.lbl_footer.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbl_footer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_footer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_footer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_footer.Location = new System.Drawing.Point(-1, 283);
            this.lbl_footer.Name = "lbl_footer";
            this.lbl_footer.Size = new System.Drawing.Size(676, 15);
            this.lbl_footer.TabIndex = 2;
            this.lbl_footer.Text = "System Developed by - Vision Studio Softare. All rights reserved.  Phone: 01960 0" +
    "23443, info@visionstudio.com.bd, www.visionstudio.com.bd";
            this.lbl_footer.Click += new System.EventHandler(this.lbl_footer_Click);
            // 
            // frm_startup
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(687, 307);
            this.Controls.Add(this.lbl_footer);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_enter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_startup";
            this.Opacity = 0.95D;
            this.Text = "TimeFrame :: Automatic Routine Maker";
            this.TransparencyKey = System.Drawing.Color.Green;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_footer;
    }
}