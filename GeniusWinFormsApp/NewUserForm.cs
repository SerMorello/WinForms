using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniusWinFormsApp
{
    public partial class newUserForm : Form
    {
        public string newUser = "";
        public newUserForm()
        {
            InitializeComponent();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            newUser = newUserNameTextBox.Text;
            Close();
        }
    }
}
