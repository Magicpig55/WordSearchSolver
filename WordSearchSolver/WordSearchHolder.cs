using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WordSearchSolver {
    public class WordSearchHolder {
        private char[][] Characters;
        public int Width;
        public int Height;
        public WordSearchHolder(char[][] chars) {
            Characters = chars;
            Width = chars.Length;
            Height = chars[0].Length;
        }
        public char this[int x, int y] {
            get {
                return Characters[x][y];
            }
            set {
                Characters[x][y] = value;
            }
        }
        public Dictionary<char, List<Point>> BuildIndexes() {
            Dictionary<char, List<Point>> d = new Dictionary<char, List<Point>>();
            for(int i = 0; i < Width; i++) {
                for(int j = 0; j < Height; j++) {
                    List<Point> p;
                    if(!d.TryGetValue(Characters[i][j], out p)) {
                        p = new List<Point>();
                        d.Add(Characters[i][j], p);
                    }
                    p.Add(new Point(i, j));
                }
            }
            return d;
        }
        public static WordSearchHolder BuildFromString(string str) {
            string[] lines = str.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            char[][] n = new char[lines.Length][];
            int len = lines[0].Length;
            for(int i = 0; i < lines.Length; i++) {
                if (lines[i].Length != len)
                    throw new Exception();
                n[i] = lines[i].ToCharArray();
            }
            return new WordSearchHolder(n);
        }
    }
}
