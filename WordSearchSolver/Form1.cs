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
        private Pen LinePen = new Pen(Color.Red);

        public void PaintTextbox(object sender, PaintEventArgs e) {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            LinePen.Width = tb_gridenter.Font.Size + 5;
            if (Loaded) {
                if (poses.Count > 0) {
                    foreach (PositionList p in poses) {
                        for (int i = 0; i < p.Length; i++) {
                            Rectangle r = new Rectangle(new Point(p[i].Y * (int)(tb_gridenter.Font.Size + 5), p[i].X * (int)(tb_gridenter.Font.Size + 5)), new Size(10, 10));
                            g.FillEllipse(Brushes.Red, r);
                            if(i > 0) {
                                g.DrawLine(LinePen, new Point(p[i].Y * (int)(tb_gridenter.Font.Size + 5) + (int)(tb_gridenter.Font.Size / 2), p[i].X * (int)(tb_gridenter.Font.Size + 5) + (int)(tb_gridenter.Font.Size / 2)), new Point(p[i - 1].Y * (int)(tb_gridenter.Font.Size + 5) + (int)(tb_gridenter.Font.Size / 2), p[i - 1].X * (int)(tb_gridenter.Font.Size + 5) + (int)(tb_gridenter.Font.Size / 2)));
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
            poses.Clear();
            if (tb_search.Text.Length < 1) return;
            for(int i = 0; i < tb_search.Text.Length; i++) {
                char c = tb_search.Text[i];
                List<Point> points = charmap[c];
                if (i == 1) poses.Clear();
                foreach (Point p in points) {
                    if (i == 0) {
                        PositionList l = new PositionList();
                        l.Add(p);
                        poses.Add(l);
                    } else if (i == 1) {
                        List<Point> pls = charmap[tb_search.Text[0]];
                        foreach (Point p1 in pls) {
                            PositionList l = new PositionList();
                            l.Add(p1);
                            if (l.IsPointValid(p)) {
                                l.Add(p);
                                poses.Add(l);
                            }
                        }
                    } else {
                        foreach (PositionList l in poses) {
                            if (l.IsPointValid(p)) {
                                l.Add(p);
                            }
                        }
                        poses.RemoveAll(l => l.Length < i + 1);
                    }
                }
            }
            textgrid.Invalidate();
        }
    }
}
