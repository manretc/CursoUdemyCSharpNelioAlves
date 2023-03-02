using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course {
    struct Point {

        public double X;
        public double Y;

        public double modulo() {
            return Math.Sqrt(X * X + Y * Y);
        }
        public override string ToString() {
            return "(" + X + ", " + Y + ")";
        }
    }
}
