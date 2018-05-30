using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WodApp
{
    public partial class RandomWod : Form
    {
        List<Random> random = new List<Random>();

        public RandomWod()
        {
            InitializeComponent();

            RandomListBox.DataSource = random;
            RandomListBox.DisplayMember = "FullInfo";
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            random = db.GetRandoms(testBox.Text);

            RandomListBox.DataSource = random;
            RandomListBox.DisplayMember = "FullInfo";
        }
    }
}
