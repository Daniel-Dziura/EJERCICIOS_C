
namespace TextFile
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
            this.saveList = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.isAlive = new System.Windows.Forms.CheckBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.age = new System.Windows.Forms.NumericUpDown();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.userListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
            this.SuspendLayout();
            // 
            // saveList
            // 
            this.saveList.Location = new System.Drawing.Point(185, 330);
            this.saveList.Margin = new System.Windows.Forms.Padding(2);
            this.saveList.Name = "saveList";
            this.saveList.Size = new System.Drawing.Size(106, 33);
            this.saveList.TabIndex = 19;
            this.saveList.Text = "Save List";
            this.saveList.UseVisualStyleBackColor = true;
            this.saveList.Click += new System.EventHandler(this.saveList_Click);
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(185, 285);
            this.addUser.Margin = new System.Windows.Forms.Padding(2);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(106, 33);
            this.addUser.TabIndex = 18;
            this.addUser.Text = "Add User";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // isAlive
            // 
            this.isAlive.AutoSize = true;
            this.isAlive.Location = new System.Drawing.Point(235, 229);
            this.isAlive.Margin = new System.Windows.Forms.Padding(2);
            this.isAlive.Name = "isAlive";
            this.isAlive.Size = new System.Drawing.Size(60, 17);
            this.isAlive.TabIndex = 17;
            this.isAlive.Text = "Is Alive";
            this.isAlive.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(139, 181);
            this.maskedTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBox3.TabIndex = 16;
            this.maskedTextBox3.Text = "Age";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(235, 181);
            this.age.Margin = new System.Windows.Forms.Padding(2);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(90, 20);
            this.age.TabIndex = 15;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(139, 129);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBox2.TabIndex = 14;
            this.maskedTextBox2.Text = "Last Name";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(235, 129);
            this.lastName.Margin = new System.Windows.Forms.Padding(2);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(127, 20);
            this.lastName.TabIndex = 13;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(139, 87);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBox1.TabIndex = 12;
            this.maskedTextBox1.Text = "First Name";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(235, 87);
            this.firstName.Margin = new System.Windows.Forms.Padding(2);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(127, 20);
            this.firstName.TabIndex = 11;
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.Location = new System.Drawing.Point(457, 130);
            this.userListBox.Margin = new System.Windows.Forms.Padding(2);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(205, 212);
            this.userListBox.TabIndex = 10;
            this.userListBox.SelectedIndexChanged += new System.EventHandler(this.userListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveList);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.isAlive);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.age);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.userListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveList;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.CheckBox isAlive;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.ListBox userListBox;
    }
}

