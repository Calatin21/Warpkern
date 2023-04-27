namespace Warpkern {
    internal class Warpkern {
        public event EventHandler<WarpeventArgs> WarpEventTAE;
        public event EventHandler<WarpeventArgs> WarpEventTUE;
        public event EventHandler<WarpeventArgs> WarpEventSCH;
        public int Temperatur { get; set; }
        public void InBetrieb() {
            Random rnd = new Random();
            int neueTemperatur;
            WarpeventArgs Args = null;
            while (true) {
                neueTemperatur = rnd.Next(0, 1001);
                if (neueTemperatur != this.Temperatur) {
                    Args = (new WarpeventArgs() { AlteTemperatur = this.Temperatur, Temperatur = neueTemperatur, Zeit = DateTime.Now.ToLongTimeString() });
                    if (neueTemperatur > 500) {
                        this.EventtemperaturUeber(Args);
                    }
                    if (neueTemperatur == 1000) {
                        this.EventKernschmelze(Args);
                    }
                    this.EventtemperaturAenderung(Args);
                }
                Thread.Sleep(1000);
                this.Temperatur = neueTemperatur;
            }
        }
        public void EventtemperaturAenderung(WarpeventArgs e) {
            if (WarpEventTAE != null) {
                WarpEventTAE(this, e);
            }
        }
        public void EventtemperaturUeber(WarpeventArgs e) {
            if (WarpEventTUE != null) {
                WarpEventTUE(this, e);
            }
        }
        public void EventKernschmelze(WarpeventArgs e) {
            if (WarpEventSCH != null) {
                WarpEventSCH(this, e);
            }
        }

    }
}
