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
        public FormTop10()
        {
            InitializeComponent();
        }

        private void FormTop10_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < Math.Min(10, listSingers.Count); i++)
                listViewTop10.Items.Add(listSingers[i]);
            
        }
    }
}
