using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Top10
{
    public partial class FormTop10 : Form
    {
        public List<string> listSingers;
        public List<int> listCountVotes;
        public FormTop10()
        {
            InitializeComponent();
        }

        private void FormTop10_Load(object sender, EventArgs e)
        {
            var keys = listCountVotes.ToArray();
            var values = listSingers.ToArray();
            Array.Sort(keys, values);
            keys = keys.Reverse().ToArray();
            values = values.Reverse().ToArray();
            listCountVotes.Sort();
            for (int i = 0; i < Math.Min(10, listSingers.Count); i++)
            {
                string[] row = { values[i], keys[i].ToString()};
                listViewTop10.Items.Add(new ListViewItem(row));
            }
            
        }
    }
}
