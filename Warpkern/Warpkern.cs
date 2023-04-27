namespace Warpkern {
    internal class Warpkern {
        public event EventHandler<WarpeventArgs> WarpEvent;
        public int Temperatur { get; set; }
        public int AlteTemperatur { get; set; }
        public void InBetrieb() {
            Random rnd = new Random();
            while (this.Temperatur < 1000) {
                this.AlteTemperatur = this.Temperatur;
                this.Temperatur = rnd.Next(0, 1001);
                if (this.Temperatur != this.AlteTemperatur) {
                    this.Event();
                }
                Thread.Sleep(1000);
            }
        }
        public void Event() {
            if (WarpEvent != null) {
                WarpEvent(this, new WarpeventArgs() { AlteTemperatur = this.AlteTemperatur, Temperatur = this.Temperatur, Zeit = DateTime.Now.ToLongTimeString() });

            }
        }

    }
}
