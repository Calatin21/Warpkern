namespace Warpkern {
    internal class WarpkernKonsole {
        public void Überhitzt(object source, EventArgs e) {
            if (((Warpkern)source).Temperatur > 500) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Warpkern Temperatur über 500 Grad!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        public void TemperaturVeraenderung(object source, WarpeventArgs e) {
            Console.Clear();
            Console.WriteLine("Aktuelle Zeit: {0}", e.Zeit);
            Console.WriteLine("Warpkern alte Temperatur: {0}", e.AlteTemperatur);
            Console.WriteLine("Warpkern neue Temperatur: {0}", e.Temperatur);
        }
        public void Kernschmelze(object source, WarpeventArgs e) {
            if (e.Temperatur > 999) {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Totale Katastrophe der Warpkern ist geschmolzen und die Enterprise ist zerstört!");
                System.Environment.Exit(0);
            }
        }
    }
}
