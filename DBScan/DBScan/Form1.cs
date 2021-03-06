﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBScan
{
    public partial class Form1 : Form
    {
        Graphics g;
        SolidBrush brush = new SolidBrush(Color.Black);
        List<MyPoint> lst = new List<MyPoint>();

        public Form1()
        {
            InitializeComponent();
            g = pnlContainer.CreateGraphics();
        }

        private void pnlContainer_MouseClick(object sender, MouseEventArgs e)
        {
            g.FillEllipse(brush, new Rectangle(e.Location, new Size(10, 10)));
            MyPoint p = new MyPoint(e.Location, false, false);
            
            lst.Add(p);
        }

        private void pnlContainer_MouseMove(object sender, MouseEventArgs e)
        {
            txtLocate.Text = "X: " + e.Location.X + ", Y: " + e.Location.Y;
        }

        private void DBScan(List<MyPoint> lst, float Eps, int MinPts, Graphics g, Brush brush)
        {
            List<Color> lstColor = new List<Color>();
            lstColor.Add(Color.Red);
            lstColor.Add(Color.Green);
            lstColor.Add(Color.Blue);
            lstColor.Add(Color.Yellow);
            lstColor.Add(Color.Orange);
            lstColor.Add(Color.Pink);
            lstColor.Add(Color.Purple);
            lstColor.Add(Color.Magenta);
            lstColor.Add(Color.Lime);
            lstColor.Add(Color.PowderBlue);
            lstColor.Add(Color.Gray);
            lstColor.Add(Color.PaleVioletRed);
            lstColor.Add(Color.Peru);
            lstColor.Add(Color.YellowGreen);
            int k = 0;

            List<MyPoint> C = new List<MyPoint>();
            foreach (MyPoint p in lst)
            {
                if (!p.visited)
                {
                    p.visited = true;
                    List<MyPoint> sphere_points = regionQuery(p, lst, Eps);
                    if (sphere_points.Count < MinPts)
                    {
                        continue;
                    }
                    else
                    {
                        C.Clear();
                        expandCluster(lst, p, sphere_points, C, Eps, MinPts, g, brush, lstColor[k]);
                        if (k != lstColor.Count - 1)
                            k++;
                    }
                }               
            }
        }

        private void expandCluster(List<MyPoint> lst, MyPoint p, List<MyPoint> sphere_points, List<MyPoint> C, float Eps, int MinPts, Graphics g, Brush brush, Color color)
        {
            brush = new SolidBrush(color);

            C.Add(p);
            g.FillEllipse(brush, new Rectangle(p.vt, new Size(10, 10)));
            Thread.Sleep(100);
            p.isChild = true;
            for (int i = 0; i < sphere_points.Count; i++)
            {
                if (!sphere_points[i].visited)
                {
                    sphere_points[i].visited = true;
                    List<MyPoint> sphere_points_1 = regionQuery(sphere_points[i], lst, Eps);
                    if (sphere_points_1.Count >= MinPts)
                    {
                        sphere_points.AddRange(sphere_points_1);
                    }
                    if (!sphere_points[i].isChild)
                    {
                        C.Add(sphere_points[i]);
                        sphere_points[i].isChild = true;
                        g.FillEllipse(brush, new Rectangle(sphere_points[i].vt, new Size(10, 10)));
                        Thread.Sleep(100);
                    }
                }
            }

            int x = C[0].vt.X, y = C[0].vt.Y;
            int width = C[0].vt.X, height = C[0].vt.Y;

            for (int i = 1; i < C.Count; i++)
            {
                if (x > C[i].vt.X)
                {
                    x = C[i].vt.X;
                }
                if (y > C[i].vt.Y)
                {
                    y = C[i].vt.Y;
                }
                if (width < C[i].vt.X)
                {
                    width = C[i].vt.X;
                }
                if (height < C[i].vt.Y)
                {
                    height = C[i].vt.Y;
                }
            }

            int padding = 5;
            g.DrawRectangle(new Pen(new SolidBrush(Color.Red)), x - padding, y - padding, width - x + padding * 4, height - y + padding * 4);
        }

        private List<MyPoint> regionQuery(MyPoint p, List<MyPoint> lst, float Eps)
        {
            List<MyPoint> lstRegion = new List<MyPoint>();

            for (int i = 0; i < lst.Count; i++)
            {
                if (distanceEuclide(p, lst[i]) <= Eps)
                {
                    lstRegion.Add(lst[i]);
                }
            }
            return lstRegion;
        }

        private double distanceEuclide(MyPoint a, MyPoint b)
        {
            return Math.Sqrt(Math.Pow(a.vt.X - b.vt.X, 2) + Math.Pow(a.vt.Y - b.vt.Y, 2));
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            for (int i = 0; i < lst.Count; i++)
            {
                g.FillEllipse(new SolidBrush(Color.Black), new Rectangle(lst[i].vt, new Size(10, 10)));
                lst[i].isChild = false;
                lst[i].visited = false;
            }

            DBScan(lst, float.Parse(txtEps.Text), int.Parse(cboMinPts.Text), g, brush);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            lst.Clear();
        }
    }

    public class MyPoint
    {
        public Point vt { get; set; }
        public bool visited { get; set; }
        public bool isChild { get; set; }

        public MyPoint() { }
        public MyPoint(Point vt, bool visited, bool isChild)
        {
            this.vt = vt;
            this.visited = visited;
            this.isChild = isChild;
        }
    }
}
