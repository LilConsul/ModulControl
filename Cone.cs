using System;
namespace ModulControl {
    public class Cone : IFigure, IHasBichna, IHasBase {
        private double _r;
        private double _l;
        private double _h;
        
        public Cone(double r, double l) {
            if (r < 0 || l < 0)
                throw new Exception("Сторони менше 0!");
            _l = l;
            _r = r;
            _h = Find_H();
        }

        private double Find_H() {
            return Math.Sqrt(Math.Pow(_l, 2) - Math.Pow(_r, 2));
        }
        
        public double S() {
            return S_Base() + S_Bichna();
        }

        public double V() {
            return (1 / 3) * _h * S_Base();
        }

        public double S_Base() {
            return Math.PI * _r * _r;
        }

        public double S_Bichna() {
            return Math.PI * _r * _l;
        }
    }
}