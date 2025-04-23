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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(textBoxA.Text, out double alpha) && double.TryParse(textBoxB.Text, out double beta) && double.TryParse(textBoxC.Text, out double gamma) && double.TryParse(textBoxD.Text, out double delta))
                {
                    if ( alpha + beta + gamma + delta != 360)
                    {
                        throw new Exception("Сума кутів має бути рівна 360");
                    }
                    else if(alpha <= 0 || beta <= 0 || gamma <= 0 || delta <= 0)
                    {
                        throw new Exception("Кути мають бути додатними");
                    }
                    else 
                    {
                        if (double.TryParse(textBoxAB.Text, out double ab) && double.TryParse(textBoxBC.Text, out double bc) && double.TryParse(textBoxCD.Text, out double cd) && double.TryParse(textBoxAD.Text, out double ad))
                        {
                            if (ab <= 0 || bc <= 0 || cd <= 0 || ad <= 0) { throw new Exception("Сторони мають бути додатніми"); }
                            else
                            {
                                
                                if(alpha == 90 && beta == 90 &&  gamma == 90 && delta == 90)
                                {
                                    if (ab != cd || bc != ad)
                                    {
                                        throw new Exception("Некоректні значення сторін");
                                    }
                                    else {
                                        if (ab != bc || bc != cd || cd != ad)
                                        {
                                            rectangle rc = new rectangle(ab,bc);
                                            MessageBox.Show("Фігура = " + rc.getName() + "\nПлоща = " + rc.getArea());
                                        }
                                        else
                                        {
                                            square s = new square(ab);
                                            MessageBox.Show("Фігура = " + s.getName() + "\nПлоща = " + s.getArea());
                                        }
                                    }
                                }
                                else
                                {
                                    if(alpha==gamma&&beta==delta)
                                    {
                                        if (ab != cd || bc != ad)
                                        {
                                            throw new Exception("Некоректні значення сторін");
                                        }
                                        else
                                        {
                                            if(ab == bc)
                                            {
                                                rombus rm = new rombus(ab,alpha);
                                                MessageBox.Show("Фігура = " + rm.getName() + "\nПлоща = " + rm.getArea());
                                            }
                                            else
                                            {
                                                paralelogram pr = new paralelogram(ab,bc,alpha);
                                                MessageBox.Show("Фігура = " + pr.getName() + "\nПлоща = " + pr.getArea());
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Foursider fs = new Foursider(ab,bc,cd,ad,alpha,gamma);
                                        MessageBox.Show("Фігура = " + fs.getName() + "\nПлоща = " + fs.getArea());
                                    }
                                }
                                
                            }
                        }
                        else throw new Exception("Введіть коректні значення сторін");
                    }
                   
                }
                else throw new Exception("Введіть коректні значення кутів");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
