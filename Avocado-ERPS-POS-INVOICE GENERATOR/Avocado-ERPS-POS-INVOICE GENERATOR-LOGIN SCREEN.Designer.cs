namespace Avocado_ERPS_POS_INVOICE_GENERATOR
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
            this.Login_Input_Button = new MaterialSkin.Controls.MaterialFlatButton();
            this.Username_Input_TextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Password_Input_TextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Error_Label = new MaterialSkin.Controls.MaterialLabel();
            this.Status_Lable_NonEdit = new MaterialSkin.Controls.MaterialLabel();
            this.Status_Label_Edit = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_Input_Button
            // 
            this.Login_Input_Button.AutoSize = true;
            this.Login_Input_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Login_Input_Button.BackColor = System.Drawing.Color.Coral;
            this.Login_Input_Button.Depth = 0;
            this.Login_Input_Button.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Login_Input_Button.FlatAppearance.BorderSize = 2000;
            this.Login_Input_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Login_Input_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Login_Input_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Input_Button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Login_Input_Button.Icon = ((System.Drawing.Image)(resources.GetObject("Login_Input_Button.Icon")));
            this.Login_Input_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Login_Input_Button.Location = new System.Drawing.Point(181, 409);
            this.Login_Input_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Login_Input_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.Login_Input_Button.Name = "Login_Input_Button";
            this.Login_Input_Button.Primary = false;
            this.Login_Input_Button.Size = new System.Drawing.Size(89, 36);
            this.Login_Input_Button.TabIndex = 4;
            this.Login_Input_Button.TabStop = false;
            this.Login_Input_Button.Text = "LOGIN";
            this.Login_Input_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Login_Input_Button.UseVisualStyleBackColor = false;
            this.Login_Input_Button.Click += new System.EventHandler(this.Login_Input_Button_Click);
            // 
            // Username_Input_TextField
            // 
            this.Username_Input_TextField.Cursor = System.Windows.Forms.Cursors.Default;
            this.Username_Input_TextField.Depth = 0;
            this.Username_Input_TextField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Username_Input_TextField.Hint = "Username ";
            this.Username_Input_TextField.Location = new System.Drawing.Point(107, 271);
            this.Username_Input_TextField.MaxLength = 32767;
            this.Username_Input_TextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.Username_Input_TextField.Name = "Username_Input_TextField";
            this.Username_Input_TextField.PasswordChar = '\0';
            this.Username_Input_TextField.SelectedText = "";
            this.Username_Input_TextField.SelectionLength = 0;
            this.Username_Input_TextField.SelectionStart = 0;
            this.Username_Input_TextField.Size = new System.Drawing.Size(241, 23);
            this.Username_Input_TextField.TabIndex = 5;
            this.Username_Input_TextField.TabStop = false;
            this.Username_Input_TextField.UseSystemPasswordChar = false;
            this.Username_Input_TextField.Click += new System.EventHandler(this.Username_Input_TextField_Click);
            // 
            // Password_Input_TextField
            // 
            this.Password_Input_TextField.Depth = 0;
            this.Password_Input_TextField.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Input_TextField.Hint = "Password";
            this.Password_Input_TextField.Location = new System.Drawing.Point(107, 327);
            this.Password_Input_TextField.MaxLength = 32767;
            this.Password_Input_TextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.Password_Input_TextField.Name = "Password_Input_TextField";
            this.Password_Input_TextField.PasswordChar = '\0';
            this.Password_Input_TextField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Password_Input_TextField.SelectedText = "";
            this.Password_Input_TextField.SelectionLength = 0;
            this.Password_Input_TextField.SelectionStart = 0;
            this.Password_Input_TextField.Size = new System.Drawing.Size(241, 23);
            this.Password_Input_TextField.TabIndex = 6;
            this.Password_Input_TextField.TabStop = false;
            this.Password_Input_TextField.UseSystemPasswordChar = true;
            this.Password_Input_TextField.Click += new System.EventHandler(this.Password_Input_TextField_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(181, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(307, 259);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(307, 312);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Error_Label
            // 
            this.Error_Label.AutoSize = true;
            this.Error_Label.Depth = 0;
            this.Error_Label.Font = new System.Drawing.Font("Roboto", 11F);
            this.Error_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Error_Label.Location = new System.Drawing.Point(198, 581);
            this.Error_Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.Error_Label.Name = "Error_Label";
            this.Error_Label.Size = new System.Drawing.Size(38, 23);
            this.Error_Label.TabIndex = 10;
            this.Error_Label.Text = "Error";
            this.Error_Label.UseCompatibleTextRendering = true;
            this.Error_Label.Visible = false;
            this.Error_Label.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // Status_Lable_NonEdit
            // 
            this.Status_Lable_NonEdit.AutoSize = true;
            this.Status_Lable_NonEdit.Depth = 0;
            this.Status_Lable_NonEdit.Font = new System.Drawing.Font("Roboto", 11F);
            this.Status_Lable_NonEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Status_Lable_NonEdit.Location = new System.Drawing.Point(13, 636);
            this.Status_Lable_NonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.Status_Lable_NonEdit.Name = "Status_Lable_NonEdit";
            this.Status_Lable_NonEdit.Size = new System.Drawing.Size(56, 19);
            this.Status_Lable_NonEdit.TabIndex = 11;
            this.Status_Lable_NonEdit.Text = "Status:";
            this.Status_Lable_NonEdit.Click += new System.EventHandler(this.materialLabel1_Click_1);
            // 
            // Status_Label_Edit
            // 
            this.Status_Label_Edit.AutoSize = true;
            this.Status_Label_Edit.Depth = 0;
            this.Status_Label_Edit.Font = new System.Drawing.Font("Roboto", 11F);
            this.Status_Label_Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Status_Label_Edit.Location = new System.Drawing.Point(66, 636);
            this.Status_Label_Edit.MouseState = MaterialSkin.MouseState.HOVER;
            this.Status_Label_Edit.Name = "Status_Label_Edit";
            this.Status_Label_Edit.Size = new System.Drawing.Size(0, 19);
            this.Status_Label_Edit.TabIndex = 12;
            this.Status_Label_Edit.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 661);
            this.Controls.Add(this.Status_Label_Edit);
            this.Controls.Add(this.Status_Lable_NonEdit);
            this.Controls.Add(this.Error_Label);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Password_Input_TextField);
            this.Controls.Add(this.Username_Input_TextField);
            this.Controls.Add(this.Login_Input_Button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Avocado-ERPS-POS-INVOICE GENERATOR-LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton Login_Input_Button;
        private MaterialSkin.Controls.MaterialSingleLineTextField Password_Input_TextField;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField Username_Input_TextField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialLabel Error_Label;
        private MaterialSkin.Controls.MaterialLabel Status_Lable_NonEdit;
        private MaterialSkin.Controls.MaterialLabel Status_Label_Edit;
    }
}

