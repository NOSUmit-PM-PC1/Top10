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
        string FILENAME = "data/uniqeSingers.txt";

        List<string> listSingers;
        List<int> listcountVotesForSinger = new List<int>();

        TextBox[] textBoxnameSingers;
        public FormVote()
        {
            InitializeComponent();
            textBoxnameSingers = new TextBox[] { textBoxSinger1, textBoxSinger2, textBoxSinger3};
        }

        void saveToFile()
        {
            StreamWriter sw = new StreamWriter(FILENAME);
            for (int i = 0; i < listSingers.Count; i++)
            {
                sw.WriteLine($"{listSingers[i]}|{listcountVotesForSinger[i]}");
            }
            sw.Close();
        }
        List<string> getFromFileListSingers(List<int> listCount)
        {
            List<string> listSingers = new List<string>();
            listCount.Clear();
            string fileName = FILENAME;
            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split('|');
                listSingers.Add(line[0]);
                listCount.Add(Convert.ToInt32(line[1]));
            }
            sr.Close();
            return listSingers;
        }
        private void FormVote_Load(object sender, EventArgs e)
        {
            listBoxUniqeSinger.Items.Clear();
            listSingers = getFromFileListSingers(listcountVotesForSinger);
            listBoxUniqeSinger.Items.AddRange(listSingers.ToArray());
        }

        int getIndexFromList(List<string> lst, string query)
        {
            for (int i = 0; i < lst.Count; i++)
                if (query == lst[i])
                    return i;
            return -1;
        }
        private void buttonVote_Click(object sender, EventArgs e)
        {
            
            foreach (var nameSinger in textBoxnameSingers)
            {
                int index = getIndexFromList(listSingers, nameSinger.Text);
                if (index == -1)
                {
                    listSingers.Add(nameSinger.Text);
                    listcountVotesForSinger.Add(1);
                }
                else
                    listcountVotesForSinger[index] += 1;
            }
            saveToFile();
            FormTop10 form = new FormTop10();
            form.listSingers = this.listSingers;
            form.listCountVotes = this.listcountVotesForSinger;
            form.Show();
        }

        private void listBoxUniqeSinger_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameSinger = listBoxUniqeSinger.Text;
            foreach (var textBox in textBoxnameSingers)
            {
                if (textBox.Text == "")
                {
                    textBox.Text = nameSinger;
                    break;
                }
            }
        }
    }
}
