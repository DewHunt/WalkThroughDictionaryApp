using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalkThroughDictionaryApp
{
    public partial class DictionaryUI : Form
    {
        public DictionaryUI()
        {
            InitializeComponent();
        }

        Dictionary<int, string> citizenInfo = new Dictionary<int, string>();

        private void saveButton_Click(object sender, EventArgs e)
        {
            int saveId = Convert.ToInt32(saveIdTextBox.Text);
            string details = detailsTextBox.Text;

            citizenInfo.Add(saveId, details);

            saveIdTextBox.Clear();
            detailsTextBox.Clear();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int searchId = Convert.ToInt32(searchIdTextBox.Text);

            if(citizenInfo.ContainsKey(searchId))
            {
                MessageBox.Show(citizenInfo[searchId]);
            }
            else
            {
                MessageBox.Show("Id is not found...");
            }

            searchIdTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            showAllListBox.Items.Clear();
            foreach(KeyValuePair<int, string> show in citizenInfo)
            {
                showAllListBox.Items.Add(show);
            }
        }
    }
}
