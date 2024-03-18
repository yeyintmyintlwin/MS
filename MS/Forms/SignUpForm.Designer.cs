namespace MS
{
    partial class SignUpForm
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
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.Repassword_textBox = new System.Windows.Forms.TextBox();
            this.fullname_textBox = new System.Windows.Forms.TextBox();
            this.signup_button = new System.Windows.Forms.Button();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_textBox
            // 
            this.username_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textBox.Location = new System.Drawing.Point(515, 210);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(420, 49);
            this.username_textBox.TabIndex = 1;
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textBox.Location = new System.Drawing.Point(515, 302);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(420, 49);
            this.password_textBox.TabIndex = 2;
            // 
            // Repassword_textBox
            // 
            this.Repassword_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repassword_textBox.Location = new System.Drawing.Point(515, 399);
            this.Repassword_textBox.Name = "Repassword_textBox";
            this.Repassword_textBox.Size = new System.Drawing.Size(420, 49);
            this.Repassword_textBox.TabIndex = 3;
            // 
            // fullname_textBox
            // 
            this.fullname_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname_textBox.Location = new System.Drawing.Point(515, 502);
            this.fullname_textBox.Name = "fullname_textBox";
            this.fullname_textBox.Size = new System.Drawing.Size(420, 49);
            this.fullname_textBox.TabIndex = 4;
            // 
            // signup_button
            // 
            this.signup_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_button.Location = new System.Drawing.Point(601, 696);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(151, 62);
            this.signup_button.TabIndex = 6;
            this.signup_button.Text = "SignUp";
            this.signup_button.UseVisualStyleBackColor = true;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // email_textBox
            // 
            this.email_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_textBox.Location = new System.Drawing.Point(515, 599);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(420, 49);
            this.email_textBox.TabIndex = 7;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(288, 213);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(190, 42);
            this.username_label.TabIndex = 8;
            this.username_label.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 42);
            this.label2.TabIndex = 10;
            this.label2.Text = "Re-password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 42);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fullname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 602);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 42);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(784, 696);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(151, 62);
            this.cancel_button.TabIndex = 13;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 943);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.fullname_textBox);
            this.Controls.Add(this.Repassword_textBox);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.username_textBox);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox Repassword_textBox;
        private System.Windows.Forms.TextBox fullname_textBox;
        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancel_button;
    }
}