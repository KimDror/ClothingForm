namespace ClothingForm
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
            if (disposing && (components != null)) {
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
            this.lbl_cdc = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_add_item = new System.Windows.Forms.Button();
            this.btn_show_item = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.lbl_usage = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_season = new System.Windows.Forms.Label();
            this.lbl_fave = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.lbl_rev = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.txt_brand = new System.Windows.Forms.TextBox();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_cdc
            // 
            this.lbl_cdc.AutoSize = true;
            this.lbl_cdc.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_cdc.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cdc.Location = new System.Drawing.Point(143, 3);
            this.lbl_cdc.Name = "lbl_cdc";
            this.lbl_cdc.Size = new System.Drawing.Size(294, 38);
            this.lbl_cdc.TabIndex = 0;
            this.lbl_cdc.Text = "Creating Digital Closet";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(99, 73);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(132, 27);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Enter E-mail:";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(99, 108);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(163, 27);
            this.lbl_pass.TabIndex = 2;
            this.lbl_pass.Text = "Enter Password:";
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Lime;
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(297, 155);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(125, 45);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(283, 73);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(164, 26);
            this.txt_email.TabIndex = 4;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(283, 108);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(164, 26);
            this.txt_pwd.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_pwd);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.btn_submit);
            this.groupBox1.Controls.Add(this.lbl_pass);
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(this.lbl_cdc);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(73, 47);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(238, 21);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(358, 32);
            this.lbl_welcome.TabIndex = 7;
            this.lbl_welcome.Text = "Welcome To Your Closet!";
            // 
            // btn_add_item
            // 
            this.btn_add_item.Location = new System.Drawing.Point(321, 68);
            this.btn_add_item.Name = "btn_add_item";
            this.btn_add_item.Size = new System.Drawing.Size(187, 43);
            this.btn_add_item.TabIndex = 8;
            this.btn_add_item.Text = "Add an Item";
            this.btn_add_item.UseVisualStyleBackColor = true;
            // 
            // btn_show_item
            // 
            this.btn_show_item.Location = new System.Drawing.Point(321, 120);
            this.btn_show_item.Name = "btn_show_item";
            this.btn_show_item.Size = new System.Drawing.Size(187, 43);
            this.btn_show_item.TabIndex = 9;
            this.btn_show_item.Text = "Show Items";
            this.btn_show_item.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txt_type);
            this.panel1.Controls.Add(this.txt_brand);
            this.panel1.Controls.Add(this.txt_color);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.lbl_size);
            this.panel1.Controls.Add(this.lbl_rev);
            this.panel1.Controls.Add(this.lbl_brand);
            this.panel1.Controls.Add(this.lbl_type);
            this.panel1.Controls.Add(this.lbl_fave);
            this.panel1.Controls.Add(this.lbl_season);
            this.panel1.Controls.Add(this.lbl_price);
            this.panel1.Controls.Add(this.lbl_usage);
            this.panel1.Controls.Add(this.lbl_color);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Location = new System.Drawing.Point(36, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 323);
            this.panel1.TabIndex = 10;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(3, 4);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(55, 20);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(3, 40);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(50, 20);
            this.lbl_color.TabIndex = 1;
            this.lbl_color.Text = "Color:";
            // 
            // lbl_usage
            // 
            this.lbl_usage.AutoSize = true;
            this.lbl_usage.Location = new System.Drawing.Point(2, 75);
            this.lbl_usage.Name = "lbl_usage";
            this.lbl_usage.Size = new System.Drawing.Size(60, 20);
            this.lbl_usage.TabIndex = 2;
            this.lbl_usage.Text = "Usage:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(3, 113);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(48, 20);
            this.lbl_price.TabIndex = 3;
            this.lbl_price.Text = "Price:";
            // 
            // lbl_season
            // 
            this.lbl_season.AutoSize = true;
            this.lbl_season.Location = new System.Drawing.Point(4, 142);
            this.lbl_season.Name = "lbl_season";
            this.lbl_season.Size = new System.Drawing.Size(76, 20);
            this.lbl_season.TabIndex = 4;
            this.lbl_season.Text = "Seasons:";
            // 
            // lbl_fave
            // 
            this.lbl_fave.AutoSize = true;
            this.lbl_fave.Location = new System.Drawing.Point(2, 171);
            this.lbl_fave.Name = "lbl_fave";
            this.lbl_fave.Size = new System.Drawing.Size(106, 20);
            this.lbl_fave.TabIndex = 5;
            this.lbl_fave.Text = "Is It Favorite?";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(4, 202);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(47, 20);
            this.lbl_type.TabIndex = 6;
            this.lbl_type.Text = "Type:";
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Location = new System.Drawing.Point(4, 234);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(56, 20);
            this.lbl_brand.TabIndex = 7;
            this.lbl_brand.Text = "Brand:";
            // 
            // lbl_rev
            // 
            this.lbl_rev.AutoSize = true;
            this.lbl_rev.Location = new System.Drawing.Point(4, 264);
            this.lbl_rev.Name = "lbl_rev";
            this.lbl_rev.Size = new System.Drawing.Size(119, 20);
            this.lbl_rev.TabIndex = 8;
            this.lbl_rev.Text = "Is It Revealing?";
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Location = new System.Drawing.Point(2, 294);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(44, 20);
            this.lbl_size.TabIndex = 9;
            this.lbl_size.Text = "Size:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(64, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 26);
            this.txt_name.TabIndex = 11;
            // 
            // txt_color
            // 
            this.txt_color.Location = new System.Drawing.Point(64, 40);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(100, 26);
            this.txt_color.TabIndex = 12;
            // 
            // txt_brand
            // 
            this.txt_brand.Location = new System.Drawing.Point(64, 231);
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.Size = new System.Drawing.Size(100, 26);
            this.txt_brand.TabIndex = 13;
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(64, 199);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(100, 26);
            this.txt_type.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_show_item);
            this.Controls.Add(this.btn_add_item);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cdc;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_add_item;
        private System.Windows.Forms.Button btn_show_item;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Label lbl_rev;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_fave;
        private System.Windows.Forms.Label lbl_season;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_usage;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.TextBox txt_brand;
        private System.Windows.Forms.TextBox txt_type;
    }
}

