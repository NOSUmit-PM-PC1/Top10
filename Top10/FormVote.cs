using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Top10
{
    public partial class FormVote : Form
    {

        List<string> listSingers;
        List<int> countVotesForSinger = new List<int>();
        public FormVote()
        {
            InitializeComponent();
        }

        List<string> getFromFileListSingers(List<int> listCount)
        {
            List<string> listSingers = new List<string>();
            listCount.Clear();
            string fileName = "data/uniqeSingers.txt";
            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split('|');
                listSingers.Add(line[0]);
                listCount.Add(Convert.ToInt32(line[1]));
            }
            return listSingers;
        }
        private void FormVote_Load(object sender, EventArgs e)
        {
            listBoxUniqeSinger.Items.Clear();
            listSingers = getFromFileListSingers(countVotesForSinger);
            listBoxUniqeSinger.Items.AddRange(listSingers.ToArray());
        }

        int getIndexFromList(List<string> lst, string query)
        {
            for (int i = 0; i < lst.Count; i++)
                if (textBoxSinger1.Text == lst[i])
                    return i;
            return -1;
        }
        private void buttonVote_Click(object sender, EventArgs e)
        {
            int index = getIndexFromList(listSingers, textBoxSinger1.Text);
            if (index == -1)
            {
                listSingers.Add(textBoxSinger1.Text);
                countVotesForSinger.Add(1);
            }
            else
                countVotesForSinger[index] += 1;
            

            FormTop10 form = new FormTop10();
            form.listSingers = this.listSingers;
            form.Show();
        }
    }
}
