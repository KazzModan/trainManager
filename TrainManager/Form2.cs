using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainManager
{



    public partial class trainForm : Form
    {
        class Train
        {
            public Train(string name, string arr, string dep)
            {
                Name = name;
                ArrTime = arr;
                DepTime = dep;
            }
            public string Name { get; set; }
            public string ArrTime { get; set; }
            public string DepTime { get; set; }
            public object[] getParm()
            {
                return new object[] { Name, ArrTime, DepTime };
            }
        }
        public trainForm()
        {

            InitializeComponent();

        }
        List<Train> trains = new List<Train>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Train train = new Train(nameBox.Text, dateTimePicker1.Value.ToString(), dateTimePicker1.Value.ToString());
            trains.Add(train);
            dataGridView1.Rows.Add(train.getParm());

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            foreach (var item in trains)
            {
                long time = long.Parse(item.ArrTime);
                DateTime dt = new DateTime(time);
                if (dt > DateTime.Now)
                    dataGridView1.DefaultCellStyle.BackColor = Color.Yellow;
            }
        }
        public void doUserView()
        {
            btnAdd.Enabled = false;
            btnRem.Enabled = false;
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Clear();
            

        }
    }
}
