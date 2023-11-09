using System;
using System.Collections;
using System.Collections.Generic;

namespace ModulControl {
    public class AbstractArray : IEnumerable<IFigure> {
        private List<IFigure> figures;

        public AbstractArray() {
            figures = new List<IFigure>();
        }

        public void AddFigure(IFigure figure) {
            figures.Add(figure);
        }

        public void RemoveFigure(IFigure figure) {
            figures.Remove(figure);
        }

        public IFigure this[int index] {
            get {
                if (index >= 0 && index < figures.Count) {
                    return figures[index];
                }
                else {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public IEnumerator<IFigure> GetEnumerator() {
            return figures.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}