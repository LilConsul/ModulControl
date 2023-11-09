using System;

namespace ModulControl {
    public class Rectangular_Prism : Figure {
        private double _h; //Висота
        private double _a; //Довжина сторони основи
        private Ractangle _rac;

        public Rectangular_Prism(double h, double a) {
            if (a < 0 || h < 0)
                throw new Exception("Сторони менше 0!");
            _a = a;
            _h = h;
            _rac = new Ractangle(_a, _a);
        }

        public double V() {
            return S_Base() * _h;
        }
        
        public double S() {
            return 2 * S_Base() + S_Bichna();
        }

        public double S_Base() {
            return _rac.S();
        }

        public double S_Bichna() {
            return P_Base() * _h;
        }

        public double P_Base() {
            return _a * 4;
        }
    }
}