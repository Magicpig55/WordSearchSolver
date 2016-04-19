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
                        return (p.Y == pn.Y - 1 && p.X == pn.X);
                    }
                case Direction.South: {
                        return (p.Y == pn.Y + 1 && p.X == pn.X);
                    }
                case Direction.East: {
                        return (p.X == pn.X + 1 && p.Y == pn.Y);
                    }
                case Direction.West: {
                        return (p.X == pn.X - 1 && p.Y == pn.Y);
                    }
                case Direction.North_East: {
                        return (p.Y == pn.Y - 1 && p.X == pn.X + 1);
                    }
                case Direction.North_West: {
                        return (p.Y == pn.Y - 1 && p.X == pn.X - 1);
                    }
                case Direction.South_East: {
                        return (p.Y == pn.Y + 1 && p.X == pn.X + 1);
                    }
                case Direction.South_West: {
                        return (p.Y == pn.Y + 1 && p.X == pn.X - 1);
                    }
                case Direction.None: {
                        return Math.Abs(p.X - pn.X) == 1 || Math.Abs(p.Y - pn.Y) == 1;
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
                if (p.Y == pn.Y - 1 && p.X == pn.X) dir = Direction.North;
                else
                if (p.Y == pn.Y + 1 && p.X == pn.X) dir = Direction.South;
                else
                if (p.X == pn.X + 1 && p.Y == pn.Y) dir = Direction.East;
                else
                if (p.X == pn.X - 1 && p.Y == pn.Y) dir = Direction.West;
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
