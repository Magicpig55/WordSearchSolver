using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordSearchSolver {
    public class PositionList {
        private List<Point> points = new List<Point>();
        private Direction dir = Direction.None;
        public Point this[int i] {
            get {
                return points[i];
            }
            set {
                points[i] = value;
            }
        }
        public int Length {
            get {
                return points.Count;
            }
        }
        public bool IsPointValid(Point p) {
            Point pn = points.Last();
            switch (dir) {
                case Direction.North: {
                        if (p.Y == pn.Y - 1) return true;
                        break;
                    }
                case Direction.South: {
                        if (p.Y == pn.Y + 1) return true;
                        break;
                    }
                case Direction.East: {
                        if (p.X == pn.X + 1) return true;
                        break;
                    }
                case Direction.West: {
                        if (p.X == pn.X - 1) return true;
                        break;
                    }
                case Direction.North_East: {
                        if (p.Y == pn.Y - 1 && p.X == pn.X + 1) return true;
                        break;
                    }
                case Direction.North_West: {
                        if (p.Y == pn.Y - 1 && p.X == pn.X - 1) return true;
                        break;
                    }
                case Direction.South_East: {
                        if (p.Y == pn.Y + 1 && p.X == pn.X + 1) return true;
                        break;
                    }
                case Direction.South_West: {
                        if (p.Y == pn.Y + 1 && p.X == pn.X - 1) return true;
                        break;
                    }
                case Direction.None: {
                        return true;
                    }
            }
            return false;
        }
        public void Add(Point p) {
            if (points.Count == 0)
                points.Add(p);
            else {
                Point pn = points.Last();
                bool f = true;
                if (p.Y == pn.Y - 1) dir = Direction.North;
                else
                if (p.Y == pn.Y + 1) dir = Direction.South;
                else
                if (p.X == pn.X + 1) dir = Direction.East;
                else
                if (p.X == pn.X - 1) dir = Direction.West;
                else
                if (p.Y == pn.Y - 1 && p.X == pn.X + 1) dir = Direction.North_East;
                else
                if (p.Y == pn.Y - 1 && p.X == pn.X - 1) dir = Direction.North_West;
                else
                if (p.Y == pn.Y + 1 && p.X == pn.X + 1) dir = Direction.South_East;
                else
                if (p.Y == pn.Y + 1 && p.X == pn.X - 1) dir = Direction.South_West;
                else {
                    dir = Direction.None;
                    f = false;
                }
                if (f) points.Add(p);
            }
        }
        public enum Direction {
            None,
            North,
            North_East,
            East,
            South_East,
            South,
            South_West,
            West,
            North_West
        }
    }
}
