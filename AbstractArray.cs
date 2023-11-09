using System;
using System.Collections.Generic;

namespace ModulControl {
    public class AbstractArray {
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
                } else {
                    throw new IndexOutOfRangeException();
                }
            }
        }
        
        
    }
}