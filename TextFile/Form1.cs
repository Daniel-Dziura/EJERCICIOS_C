using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//Leer y escribir, con patron
namespace TextFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadListFromFile();
            WirteUpDropDown();
        }

        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        BindingList<UserModel> users = new BindingList<UserModel>();

        private void LoadListFromFile()
        {
            //Load the file
            string[] lines = File.ReadAllLines("StandardDataSet.csv");


            //Parse each line
            for (int i = 1; i < lines.Length; i++)
            {
                //Split the line
                string[] columns = lines[i].Split(',');

                bool isAlive = false;

                if (columns[3] == "1")
                {
                    isAlive = true;
                }

                //Creater a model from the line
                //Add to list
                users.Add(new UserModel
                {
                    FirstName = columns[0],
                    LastName = columns[1],
                    Age = int.Parse(columns[2]),
                    IsAlive = isAlive
                });
            }
        }

        private void WirteUpDropDown()
        {
            userListBox.DataSource = users;
            userListBox.DisplayMember = nameof(UserModel.DisplayText);
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            users.Add(new UserModel
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                Age = (int)age.Value,
                IsAlive = isAlive.Checked
            });

            firstName.Text = "";
            lastName.Text = "";
            age.Value = 0;
            isAlive.Checked = false;
        }

        private void saveList_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();

            lines.Add("FirstName,LastName,Age,IsAlive");

            foreach (UserModel user in users)
            {
                int isAliveValue = 0;

                if (user.IsAlive == true)
                {
                    isAliveValue = 1;
                }

                lines.Add($"{ user.FirstName },{ user.LastName },{ user.Age },{ isAliveValue }");
            }

            File.WriteAllLines("StandardDataSet.csv", lines);

            MessageBox.Show("Save complete");
        }
    }
}

//Leer y escribir simple
/*
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadListFromFile();
            WirteUpDropDown();
        }

        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        BindingList<UserModel> users = new BindingList<UserModel>();

        private void LoadListFromFile()
        {
            //Load the file
            string[] lines = File.ReadAllLines("StandardDataSet.csv");


            //Parse each line
            for (int i = 1; i < lines.Length; i++)
            {
                //Split the line
                string[] columns = lines[i].Split(',');

                bool isAlive = false;

                if (columns[3] == "1") 
                {
                    isAlive = true;
                }

                //Creater a model from the line
                //Add to list
                users.Add(new UserModel
                {
                    FirstName = columns[0],
                    LastName = columns[1],
                    Age = int.Parse(columns[2]),
                    IsAlive = isAlive
                });
            }
        }

        private void WirteUpDropDown()
        {
            userListBox.DataSource = users;
            userListBox.DisplayMember = nameof(UserModel.DisplayText);
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            users.Add(new UserModel
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                Age = (int)age.Value,
                IsAlive = isAlive.Checked
            });

            firstName.Text = "";
            lastName.Text = "";
            age.Value = 0;
            isAlive.Checked = false;
        }

        private void saveList_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();

            lines.Add("FirstName,LastName,Age,IsAlive");

            foreach (UserModel user in users)
            {
                int isAliveValue = 0;

                if (user.IsAlive == true)
                {
                    isAliveValue = 1;
                }

                lines.Add($"{ user.FirstName },{ user.LastName },{ user.Age },{ isAliveValue }");
            }

            File.WriteAllLines("StandardDataSet.csv", lines);

            MessageBox.Show("Save complete");
        }
    }
}

*/
