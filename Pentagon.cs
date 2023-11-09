using System;

namespace ModulControl {
    public class Pentagon : IFigure, IHasP {
        private double _a;
        private double _d;

        public Pentagon(double a, double d) {
            if (a < 0 || d < 0)
                throw new Exception("Сторони менше 0!");
            _d = d;
            _a = a;
        }

        public double S() {
            return 1 / 2 * P() * _d;
        }

        public double P() {
            return 5 * _a;
        }
    }
}