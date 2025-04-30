using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP11
{
    public partial class Control : Form
    {
        List<Foursider> shapes;
        public Control()
        {
            InitializeComponent();
            shapes = new List<Foursider>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewShape newShape = new NewShape(this);
            newShape.ShowDialog();
            
        }
        public void AddShape(Foursider shape)
        {
            shapes.Add(shape);
            listBox1.DataSource = null;
            listBox1.DataSource = shapes;
            listBox1.Update();

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int n = shapes.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    int rez = shapes[j].CompareTo(shapes[j + 1]);
                    if (rez ==1)
                    {
                        Foursider temp = shapes[j];
                        shapes[j] = shapes[j + 1];
                        shapes[j + 1] = temp;
                    }
                }
            }
            listBox1.DataSource = null;
            listBox1.DataSource = shapes;
            listBox1.Update();


        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            List<Foursider> clones =  new List<Foursider>();
            for(int i = 0; i < shapes.Count; i++)
            {
               clones.Add( shapes[i].Clone());
            }
            for (int i = 0;i < clones.Count; i++)
            {
                Random random = new Random();
                shapes.Insert( random.Next(0, i + 1), clones[i]);
            }
            listBox1.DataSource = null;
            listBox1.DataSource = shapes;
            listBox1.Update();

        }

        private void Control_Load(object sender, EventArgs e)
        {

        }
    }
}
