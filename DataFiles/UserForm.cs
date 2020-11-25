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

namespace DataFiles
{
    public partial class Form1 : Form
    {
        BindingList<UserModel> users = new BindingList<UserModel>();

        public Form1()
        {
            InitializeComponent();

            LoadListFromFile();

            WirteUpDropDown();
        }

        private void LoadListFromFile()
        {

            string[] lines = File.ReadAllLines("StandardDataSet.csv");

            for (int i = 0; i < lines.Length; i++)
            {
                string[] columns = lines[i].Split(',');
                bool isAlive = false;

                if (columns[3] == "1")
                {
                    isAlive = true;
                }

                users.Add(new UserModel
                {
                    FirstName = columns[0],
                    LastName = columns[1],
                    Age = int.Parse(columns[2]),
                    IsAlive = bool.Parse(columns[3])
                });
                    
            
            }

        }

        private void WirteUpDropDown()
        {
            userListBox.DataSource = users;
            userListBox.DisplayMember = nameof(UserModel.DisplayText);
        }

        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
