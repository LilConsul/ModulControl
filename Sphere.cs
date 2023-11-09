using System;

namespace ModulControl {
    public class Sphere : IFigure, IHasVolume {
        private double _r;

        public Sphere(double r) {
            if (r < 0)
                throw new Exception("Сторони менше 0!");
            _r = r;
        }

        public double S() {
            return 4 * Math.PI * _r * _r;
        }

        public double V() {
            return (4 * Math.PI * Math.Pow(_r, 3)) / 3;
        }
    }
}