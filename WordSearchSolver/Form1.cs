using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordSearchSolver {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public WordSearchHolder holder;
        private bool Loaded;
        public Dictionary<char, List<Point>> charmap;
        public List<PositionList> poses = new List<PositionList>();

        public void PaintTextbox(object sender, PaintEventArgs e) {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            if (Loaded) {
                if (poses.Count > 0) {
                    foreach (PositionList p in poses) {
                        for (int i = 0; i < p.Length; i++) {
                            Rectangle r = new Rectangle(new Point(p[i].Y * (int)(tb_gridenter.Font.Size + 5), p[i].X * (int)(tb_gridenter.Font.Size + 5)), new Size(10, 10));
                            g.FillEllipse(Brushes.Red, r);
                            if(i > 0) {
                                g.DrawLine(Pens.Black, p[i], p[i - 1]);
                            }
                        }
                    }
                }
                for (int x = 0; x < holder.Width; x++) {
                    for (int y = 0; y < holder.Height; y++) {
                        g.DrawString(holder[x, y].ToString(), tb_gridenter.Font, Brushes.Black, y * (tb_gridenter.Font.Size + 5), x * (tb_gridenter.Font.Size + 5));
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            holder = WordSearchHolder.BuildFromString(tb_gridenter.Text);
            charmap = holder.BuildIndexes();
            Loaded = true;
            textgrid.Invalidate();
        }

        private void tb_search_TextChanged(object sender, EventArgs e) {
            if (tb_search.Text.Length < 1) return;
            char n = tb_search.Text.Last();
            List<Point> points = charmap[n];
            foreach(Point p in points) {
                if (poses.Count > 0) {
                    foreach (PositionList l in poses) {
                        if (l.IsPointValid(p)) {
                            l.Add(p);
                        }
                    }
                } else {
                    PositionList l = new PositionList();
                    l.Add(p);
                    poses.Add(l);
                }
            }
            textgrid.Invalidate();
        }
    }
}
