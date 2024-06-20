using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mood_Food
{
    public partial class MyMessageBox : Form
    {
        static MyMessageBox message;


        public MyMessageBox()
        {
            InitializeComponent();
        }

        public static void Show(string text)
        {
            message = new MyMessageBox();
            message.label1.Text = text;
            message.ShowDialog();
        }
        public string LabelText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public void SetDataGridViewData(List<string> dataList)
        {
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Name = "Foods";

            foreach (string data in dataList)
            {
                dataGridView1.Rows.Add(data);
            }
        }
    }
}
