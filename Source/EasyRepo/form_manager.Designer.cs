namespace EasyRepo
{
    partial class form_manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_manager));
            this.button_close = new System.Windows.Forms.Button();
            this.button_buildPackages = new System.Windows.Forms.Button();
            this.button_addpackage = new System.Windows.Forms.Button();
            this.button_refreshPackages = new System.Windows.Forms.Button();
            this.combo_packages = new System.Windows.Forms.ComboBox();
            this.button_getPackageInfo = new System.Windows.Forms.Button();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.button_changeIcon = new System.Windows.Forms.Button();
            this.label_repoPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Location = new System.Drawing.Point(578, 9);
            this.button_close.Margin = new System.Windows.Forms.Padding(0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(25, 25);
            this.button_close.TabIndex = 8;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_buildPackages
            // 
            this.button_buildPackages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_buildPackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_buildPackages.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buildPackages.ForeColor = System.Drawing.Color.White;
            this.button_buildPackages.Location = new System.Drawing.Point(309, 282);
            this.button_buildPackages.Name = "button_buildPackages";
            this.button_buildPackages.Size = new System.Drawing.Size(291, 90);
            this.button_buildPackages.TabIndex = 9;
            this.button_buildPackages.Text = "Build Packages.bz2";
            this.button_buildPackages.UseVisualStyleBackColor = false;
            this.button_buildPackages.Click += new System.EventHandler(this.button_buildPackages_Click);
            // 
            // button_addpackage
            // 
            this.button_addpackage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.button_addpackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addpackage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addpackage.ForeColor = System.Drawing.Color.White;
            this.button_addpackage.Location = new System.Drawing.Point(12, 186);
            this.button_addpackage.Name = "button_addpackage";
            this.button_addpackage.Size = new System.Drawing.Size(291, 90);
            this.button_addpackage.TabIndex = 10;
            this.button_addpackage.Text = "Add package";
            this.button_addpackage.UseVisualStyleBackColor = false;
            this.button_addpackage.Click += new System.EventHandler(this.button_addpackage_Click);
            // 
            // button_refreshPackages
            // 
            this.button_refreshPackages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_refreshPackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refreshPackages.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refreshPackages.ForeColor = System.Drawing.Color.White;
            this.button_refreshPackages.Location = new System.Drawing.Point(12, 282);
            this.button_refreshPackages.Name = "button_refreshPackages";
            this.button_refreshPackages.Size = new System.Drawing.Size(291, 90);
            this.button_refreshPackages.TabIndex = 11;
            this.button_refreshPackages.Text = "Refresh Packages";
            this.button_refreshPackages.UseVisualStyleBackColor = false;
            this.button_refreshPackages.Click += new System.EventHandler(this.button_refreshPackages_Click);
            // 
            // combo_packages
            // 
            this.combo_packages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.combo_packages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_packages.ForeColor = System.Drawing.Color.White;
            this.combo_packages.FormattingEnabled = true;
            this.combo_packages.Location = new System.Drawing.Point(12, 105);
            this.combo_packages.Name = "combo_packages";
            this.combo_packages.Size = new System.Drawing.Size(291, 21);
            this.combo_packages.TabIndex = 12;
            // 
            // button_getPackageInfo
            // 
            this.button_getPackageInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.button_getPackageInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_getPackageInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_getPackageInfo.ForeColor = System.Drawing.Color.White;
            this.button_getPackageInfo.Location = new System.Drawing.Point(12, 9);
            this.button_getPackageInfo.Name = "button_getPackageInfo";
            this.button_getPackageInfo.Size = new System.Drawing.Size(291, 90);
            this.button_getPackageInfo.TabIndex = 13;
            this.button_getPackageInfo.Text = "Get Package Info";
            this.button_getPackageInfo.UseVisualStyleBackColor = false;
            this.button_getPackageInfo.Click += new System.EventHandler(this.button_getPackageInfo_Click);
            // 
            // button_minimize
            // 
            this.button_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minimize.ForeColor = System.Drawing.Color.White;
            this.button_minimize.Location = new System.Drawing.Point(543, 9);
            this.button_minimize.Margin = new System.Windows.Forms.Padding(0);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(25, 25);
            this.button_minimize.TabIndex = 14;
            this.button_minimize.Text = "-";
            this.button_minimize.UseVisualStyleBackColor = false;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // button_return
            // 
            this.button_return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.button_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_return.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_return.ForeColor = System.Drawing.Color.White;
            this.button_return.Location = new System.Drawing.Point(309, 9);
            this.button_return.Margin = new System.Windows.Forms.Padding(0);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(224, 25);
            this.button_return.TabIndex = 15;
            this.button_return.Text = "Return to start page";
            this.button_return.UseVisualStyleBackColor = false;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // button_changeIcon
            // 
            this.button_changeIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.button_changeIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_changeIcon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_changeIcon.ForeColor = System.Drawing.Color.White;
            this.button_changeIcon.Location = new System.Drawing.Point(309, 186);
            this.button_changeIcon.Name = "button_changeIcon";
            this.button_changeIcon.Size = new System.Drawing.Size(291, 90);
            this.button_changeIcon.TabIndex = 16;
            this.button_changeIcon.Text = "Change repo icon";
            this.button_changeIcon.UseVisualStyleBackColor = false;
            this.button_changeIcon.Click += new System.EventHandler(this.button_changeIcon_Click);
            // 
            // label_repoPath
            // 
            this.label_repoPath.AutoSize = true;
            this.label_repoPath.ForeColor = System.Drawing.Color.White;
            this.label_repoPath.Location = new System.Drawing.Point(309, 44);
            this.label_repoPath.Name = "label_repoPath";
            this.label_repoPath.Size = new System.Drawing.Size(0, 13);
            this.label_repoPath.TabIndex = 17;
            this.label_repoPath.Click += new System.EventHandler(this.label_repoPath_Click);
            // 
            // form_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(612, 384);
            this.Controls.Add(this.label_repoPath);
            this.Controls.Add(this.button_changeIcon);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.button_minimize);
            this.Controls.Add(this.button_getPackageInfo);
            this.Controls.Add(this.combo_packages);
            this.Controls.Add(this.button_refreshPackages);
            this.Controls.Add(this.button_addpackage);
            this.Controls.Add(this.button_buildPackages);
            this.Controls.Add(this.button_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_manager";
            this.Text = "form_manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_manager_FormClosed);
            this.Load += new System.EventHandler(this.form_manager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_buildPackages;
        private System.Windows.Forms.Button button_addpackage;
        private System.Windows.Forms.Button button_refreshPackages;
        private System.Windows.Forms.ComboBox combo_packages;
        private System.Windows.Forms.Button button_getPackageInfo;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Button button_changeIcon;
        private System.Windows.Forms.Label label_repoPath;
    }
}