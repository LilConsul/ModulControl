using System;

namespace ModulControl {
    public class Pentagon_Pyramid : Figure {
        private double _h; //Висота
        private double _l; //Довжина грані
        private Pentagon _pent;
        private double _a; //Довжина сторони основи
        private double _d; //Діаметр основи


        public Pentagon_Pyramid(double a, double l, double h, double d) {
            if (a < 0 || h < 0 || l < 0 || d < 0)
                throw new Exception("Сторони менше 0!");
            _a = a;
            _l = l;
            _h = h;
            _d = d;
            _pent = new Pentagon(_a, _d);
        }

        public double S() {
            return 5 / 4 * _a * _l + S_Base();
        }

        public double S_Base() {
            return _pent.S();
        }

        public double V() {
            return (1 / 3) * S() * _h;
        }
    }
}