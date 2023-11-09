using System;
namespace ModulControl {
    public class InfoShow {
        private string info;
        private IFigure figure;

        public string GetInfo(IFigure _figure) {
            figure = _figure;
            info = $"Тип: {_figure.GetType().Name} \t";
            info += $"Площа: {_figure.S()} \t";

            if (figure is IHasVolume)
                VolumeInfo((IHasVolume)figure);

            if (figure is IHasBichna)
                BichnaInfo((IHasBichna)figure);

            if (figure is IHasBase)
                BaseInfo((IHasBase)figure);

            if (figure is IHasP)
                PInfo((IHasP)figure);

            if (figure is IHasOpisano)
                OpisanoInfo((IHasOpisano)figure);

            if (figure is IHasVpisano)
                VpisanoInfo((IHasVpisano)figure);

            return info;
        }

        private void VolumeInfo(IHasVolume hasVolume) {
            info += $"Об'єм: {Math.Round(hasVolume.V(), 3)} \t";
        }

        private void BichnaInfo(IHasBichna hasBichna) {
            info += $"Площа бічна: {Math.Round(hasBichna.S_Bichna(), 3)} \t";
        }

        private void BaseInfo(IHasBase hasBase) {
            info += $"Площа основи: {Math.Round(hasBase.S_Base(), 3)} \t";
        }

        private void PInfo(IHasP hasP) {
            info += $"Периметр: {Math.Round(hasP.P(), 3)} \t";
        }

        private void OpisanoInfo(IHasOpisano hasOpisano) {
            info += $"Радіус Описаної: {Math.Round(hasOpisano.R_Opisano(), 3)} \t";
        }

        private void VpisanoInfo(IHasVpisano hasVpisano) {
            info += $"Радіус Описаної: {Math.Round(hasVpisano.R_Vpisano(), 3)} \t";
        }
    }
}