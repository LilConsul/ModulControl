using System;

namespace ModulControl {
    public class Ractangle : IFigure, IHasP,  IHasOpisano {
        private double _a;
        private double _b;

        public Ractangle(double a, double b) {
            if (a < 0 || b < 0)
                throw new Exception("Сторони менше 0!");
            _a = a;
            _b = b;
        }

        public double S() {
            return _a * _b;
        }

        public double P() {
            return 2 * (_a + _b);
        }

        public double R_Opisano() {
            return Math.Sqrt(Math.Pow(_a, 2) + Math.Pow(_b, 2)) / 2;
        }
    }
}