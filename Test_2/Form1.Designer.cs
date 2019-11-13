namespace Test_2
{
    partial class Register_Form
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
            this.Telephone_Number = new System.Windows.Forms.Label();
            this.Last_Name = new System.Windows.Forms.Label();
            this.First_Name = new System.Windows.Forms.Label();
            this.Delete_users = new System.Windows.Forms.Button();
            this.Count_of_users = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.Clear_Form = new System.Windows.Forms.Button();
            this.Telephone_Number_Box = new System.Windows.Forms.TextBox();
            this.Last_Name_Box = new System.Windows.Forms.TextBox();
            this.First_Name_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Telephone_Number
            // 
            this.Telephone_Number.AutoSize = true;
            this.Telephone_Number.Location = new System.Drawing.Point(222, 180);
            this.Telephone_Number.Name = "Telephone_Number";
            this.Telephone_Number.Size = new System.Drawing.Size(98, 13);
            this.Telephone_Number.TabIndex = 5;
            this.Telephone_Number.Text = "Telephone Number";
            // 
            // Last_Name
            // 
            this.Last_Name.AutoSize = true;
            this.Last_Name.Location = new System.Drawing.Point(222, 134);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(58, 13);
            this.Last_Name.TabIndex = 3;
            this.Last_Name.Text = "Last Name";
            // 
            // First_Name
            // 
            this.First_Name.AutoSize = true;
            this.First_Name.Location = new System.Drawing.Point(222, 88);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(57, 13);
            this.First_Name.TabIndex = 1;
            this.First_Name.Text = "First Name";
            // 
            // Delete_users
            // 
            this.Delete_users.Location = new System.Drawing.Point(443, 326);
            this.Delete_users.Name = "Delete_users";
            this.Delete_users.Size = new System.Drawing.Size(135, 43);
            this.Delete_users.TabIndex = 10;
            this.Delete_users.Text = "Delete users";
            this.Delete_users.UseVisualStyleBackColor = true;
            this.Delete_users.Click += new System.EventHandler(this.Delete_users_Click);
            // 
            // Count_of_users
            // 
            this.Count_of_users.Location = new System.Drawing.Point(291, 326);
            this.Count_of_users.Name = "Count_of_users";
            this.Count_of_users.Size = new System.Drawing.Size(135, 43);
            this.Count_of_users.TabIndex = 9;
            this.Count_of_users.Text = "Count of users";
            this.Count_of_users.UseVisualStyleBackColor = true;
            this.Count_of_users.Click += new System.EventHandler(this.Count_of_users_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(443, 256);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(135, 43);
            this.Register.TabIndex = 8;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Clear_Form
            // 
            this.Clear_Form.Location = new System.Drawing.Point(291, 256);
            this.Clear_Form.Name = "Clear_Form";
            this.Clear_Form.Size = new System.Drawing.Size(135, 43);
            this.Clear_Form.TabIndex = 7;
            this.Clear_Form.Text = "Clear Form";
            this.Clear_Form.UseVisualStyleBackColor = true;
            this.Clear_Form.Click += new System.EventHandler(this.Clear_Form_Click);
            // 
            // Telephone_Number_Box
            // 
            this.Telephone_Number_Box.Location = new System.Drawing.Point(355, 173);
            this.Telephone_Number_Box.Name = "Telephone_Number_Box";
            this.Telephone_Number_Box.Size = new System.Drawing.Size(223, 20);
            this.Telephone_Number_Box.TabIndex = 6;
            // 
            // Last_Name_Box
            // 
            this.Last_Name_Box.Location = new System.Drawing.Point(355, 127);
            this.Last_Name_Box.Name = "Last_Name_Box";
            this.Last_Name_Box.Size = new System.Drawing.Size(223, 20);
            this.Last_Name_Box.TabIndex = 4;
            // 
            // First_Name_Box
            // 
            this.First_Name_Box.Location = new System.Drawing.Point(355, 81);
            this.First_Name_Box.Name = "First_Name_Box";
            this.First_Name_Box.Size = new System.Drawing.Size(223, 20);
            this.First_Name_Box.TabIndex = 2;
            // 
            // Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Telephone_Number);
            this.Controls.Add(this.Last_Name);
            this.Controls.Add(this.First_Name);
            this.Controls.Add(this.Delete_users);
            this.Controls.Add(this.Count_of_users);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Clear_Form);
            this.Controls.Add(this.Telephone_Number_Box);
            this.Controls.Add(this.Last_Name_Box);
            this.Controls.Add(this.First_Name_Box);
            this.Name = "Register_Form";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Telephone_Number;
        private System.Windows.Forms.Label Last_Name;
        private System.Windows.Forms.Label First_Name;
        private System.Windows.Forms.Button Delete_users;
        private System.Windows.Forms.Button Count_of_users;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button Clear_Form;
        private System.Windows.Forms.TextBox Telephone_Number_Box;
        private System.Windows.Forms.TextBox Last_Name_Box;
        private System.Windows.Forms.TextBox First_Name_Box;
    }
}

