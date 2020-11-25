using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFiles
{
    public partial class Form1 : Form
    {
        

        BindingList<UserModel> users = new BindingList<UserModel>();

        public Form1()
        {
            InitializeComponent();

            WirteUpDropDown();
        }

        private void WirteUpDropDown()
        {
            userListBox.DataSource = users;
            userListBox.DisplayMember = nameof(UserModel.DisplayText);
        }

        private void addUser_Click(object sender, EventArgs e)
        {

        }

        

        
    }
}
