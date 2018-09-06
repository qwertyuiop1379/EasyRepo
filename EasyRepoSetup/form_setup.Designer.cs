using System.IO;
using System.Windows.Forms;

namespace EasyRepoSetup
{
    partial class form_setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_setup));
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_install = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_confirm = new System.Windows.Forms.Button();
            this.check_desktop = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_path = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_browse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.Color.White;
            this.button_cancel.Location = new System.Drawing.Point(12, 206);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(208, 32);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_install
            // 
            this.button_install.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_install.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_install.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_install.ForeColor = System.Drawing.Color.White;
            this.button_install.Location = new System.Drawing.Point(230, 206);
            this.button_install.Name = "button_install";
            this.button_install.Size = new System.Drawing.Size(208, 32);
            this.button_install.TabIndex = 2;
            this.button_install.Text = "Continue";
            this.button_install.UseVisualStyleBackColor = false;
            this.button_install.Click += new System.EventHandler(this.button_install_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "You are about to install EasyRepo";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Easy repo is a program that simplifies the creation and management of Cydia repos" +
    "itories. (Please run this setup as admin)";
            // 
            // button_confirm
            // 
            this.button_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_confirm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_confirm.ForeColor = System.Drawing.Color.White;
            this.button_confirm.Location = new System.Drawing.Point(230, 206);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(208, 32);
            this.button_confirm.TabIndex = 5;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = false;
            this.button_confirm.Visible = false;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // check_desktop
            // 
            this.check_desktop.AutoSize = true;
            this.check_desktop.Checked = true;
            this.check_desktop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_desktop.ForeColor = System.Drawing.Color.White;
            this.check_desktop.Location = new System.Drawing.Point(12, 68);
            this.check_desktop.Name = "check_desktop";
            this.check_desktop.Size = new System.Drawing.Size(143, 17);
            this.check_desktop.TabIndex = 6;
            this.check_desktop.Text = "Add Shortcut to Desktop";
            this.check_desktop.UseVisualStyleBackColor = true;
            this.check_desktop.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customize";
            this.label3.Visible = false;
            // 
            // text_path
            // 
            this.text_path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.text_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_path.ForeColor = System.Drawing.Color.White;
            this.text_path.Location = new System.Drawing.Point(79, 42);
            this.text_path.Name = "text_path";
            this.text_path.Size = new System.Drawing.Size(296, 20);
            this.text_path.TabIndex = 8;
            this.text_path.Text = "C:\\Program Files (x86)\\EasyRepo";
            this.text_path.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Install Path";
            this.label4.Visible = false;
            // 
            // button_browse
            // 
            this.button_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_browse.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_browse.ForeColor = System.Drawing.Color.White;
            this.button_browse.Location = new System.Drawing.Point(381, 40);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(57, 23);
            this.button_browse.TabIndex = 10;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Visible = false;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // form_setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_path);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.check_desktop);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_install);
            this.Controls.Add(this.button_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_install;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.CheckBox check_desktop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_path;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_browse;
    }
}

