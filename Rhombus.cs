using System;

namespace ModulControl {
    public class Rhombus : Figure {
        private double _a;
        private double _h;

        public Rhombus(double a, double h) {
            if (a < 0 || h < 0)
                throw new Exception("Сторони менше 0!");
            _a = a;
            _h = h;
        }
        
        public double S() {
            return _a * _h;
        }

        public double P() {
            return _a * 4;
        }

        public double R_Vpisano() {
            return S() / (2 * _a);
        }
    }
}