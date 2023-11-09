using System;
using ModulControl;
using Xunit;

namespace Test {
    public class Tests {
        [Fact]
        public void PenTest() {
            var pen = new Pentagon(1, 2);
            Assert.Equal(5, pen.P());
            Assert.Equal(5, pen.S());
        }

        [Fact]
        public void PenPyrTest() {
            var pen = new Pentagon_Pyramid(1, 2, 3, 4);
            Assert.Equal(12, pen.V());
            Assert.Equal(12, pen.S());
        }

        [Fact]
        public void RacTest() {
            var rac = new Ractangle(1, 2);
            Assert.Equal(1.1, Math.Round(rac.R_Opisano(), 1));
            Assert.Equal(2, rac.S());
        }

        [Fact]
        public void RhombTest() {
            var rh = new Rhombus(5, 2);
            Assert.Equal(1, Math.Round(rh.R_Vpisano(), 1));
            Assert.Equal(10, Math.Round(rh.S(), 1));
        }

        [Fact]
        public void SphereTest() {
            var sp = new Sphere(4);
            Assert.Equal(201.1, Math.Round(sp.S(), 1));
            Assert.Equal(268.1, Math.Round(sp.V(),1));
        }

        [Fact]
        public void ConeTest() {
            var co = new Cone(2, 4);
            Assert.Equal(25.1, Math.Round(co.S_Bichna(), 1));
        }
    }
}