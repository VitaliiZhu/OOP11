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
        QuadCollection shapes = new QuadCollection();
        public Control()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewShape newShape = new NewShape(this);
            newShape.ShowDialog();
            
        }
        public void AddShape(Foursider shape)
        {
            shapes.list.Push(shape);
            shapes.stack.Push(shape);
            List<Foursider> tempList = new List<Foursider>(shapes.list.Reverse()); // Preserve stack order
            listBox1.DataSource = null;
            listBox1.DataSource = tempList;
            listBox1.Update();
            listBox2.DataSource = null;
            listBox2.DataSource = tempList;
            listBox2.Update();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            List<Foursider> tempList = new List<Foursider>(shapes.list.Reverse());
            tempList.Sort();  // Ensure Foursider implements IComparable<Foursider>

            shapes.list.Clear();
            foreach (Foursider obj in tempList)
            {
                shapes.list.Push(obj);
            }

            listBox1.DataSource = null;
            listBox1.DataSource = tempList;
            listBox1.Update();
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            List<Foursider> tempList = new List<Foursider>(shapes.list.Reverse());
            List<Foursider> clones = new List<Foursider>();

            foreach (Foursider shape in tempList)
            {
                clones.Add(shape.Clone());
            }

            Random random = new Random();
            foreach (Foursider clone in clones)
            {
                tempList.Insert(random.Next(0, tempList.Count), clone);
            }

            shapes.list.Clear();
            foreach (Foursider obj in tempList)
            {
                shapes.list.Push(obj);
            }

            listBox1.DataSource = null;
            listBox1.DataSource = tempList;
            listBox1.Update();
        }


        private void Control_Load(object sender, EventArgs e)
        {

        }

        private void btnCloneStack_Click(object sender, EventArgs e)
        {

            object[] tempArray = shapes.stack.ToArray();
            List<Foursider> tempList = tempArray.Cast<Foursider>().ToList();
            List<Foursider> clones = new List<Foursider>();

            foreach (Foursider shape in tempList)
            {
                clones.Add(shape.Clone());
            }

            Random random = new Random();
            foreach (Foursider clone in clones)
            {
                tempList.Insert(random.Next(0, tempList.Count), clone);
            }

            shapes.stack.Clear();
            foreach (Foursider obj in tempList)
            {
                shapes.stack.Push(obj);
            }

            listBox2.DataSource = null;
            listBox2.DataSource = tempList;
            listBox2.Update();

        }

        private void btnSortStack_Click(object sender, EventArgs e)
        {
            object[] tempArray = shapes.stack.ToArray();
            List<Foursider> tempList = tempArray.Cast<Foursider>().ToList();

            tempList.Sort(); // Ensure Foursider implements IComparable<Foursider>

            shapes.stack.Clear();
            foreach (Foursider obj in tempList)
            {
                shapes.stack.Push(obj);
            }

            listBox2.DataSource = null;
            listBox2.DataSource = tempList;
            listBox2.Update();

        }
    }
}
