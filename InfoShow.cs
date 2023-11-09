namespace ModulControl {
    public class InfoShow {
        private string info;
        private IFigure figure;

        public string GetInfo(IFigure _figure) {
            figure = _figure;
            info = $"Тип: {_figure.GetType().Name}\t";
            info += $"Площа: {_figure.S()}\t";

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
            info += $"Об'єм: {hasVolume.V()}\t";
        }

        private void BichnaInfo(IHasBichna hasBichna) {
            info += $"Площа бічна: {hasBichna.S_Bichna()}\t";
        }

        private void BaseInfo(IHasBase hasBase) {
            info += $"Площа основи: {hasBase.S_Base()}\t";
        }

        private void PInfo(IHasP hasP) {
            info += $"Периметр: {hasP.P()}\t";
        }

        private void OpisanoInfo(IHasOpisano hasOpisano) {
            info += $"Радіус Описаної: {hasOpisano.R_Opisano()}\t";
        }

        private void VpisanoInfo(IHasVpisano hasVpisano) {
            info += $"Радіус Описаної: {hasVpisano.R_Vpisano()}\t";
        }
    }
}