namespace Warpkern {
    internal class WarpkernKonsole {
        public void Überhitzt(object source, WarpeventArgs e) {
            for (int i = 0; i < 2; i++) {
               Console.Clear();
                Console.WriteLine("Warpkern Temperatur über 500 Grad!");
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Warpkern Temperatur über 500 Grad!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Thread.Sleep(30);
            }
        }
        public void TemperaturVeraenderung(object source, WarpeventArgs e) {
            if (e.Temperatur <= 500) {
                Console.Clear();
            }
            Console.WriteLine("Aktuelle Zeit: {0}", e.Zeit);
            Console.WriteLine("Warpkern alte Temperatur: {0}", e.AlteTemperatur);
            Console.WriteLine("Warpkern neue Temperatur: {0}", e.Temperatur);
        }
        public void Kernschmelze(object source, WarpeventArgs e) {
            bool blink = false;
            while (true) {
                Console.Clear();
                //if (blink) {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Totale Katastrophe der Warpkern ist geschmolzen und die Enterprise ist zerstört!");
                    blink = false;
                    Thread.Sleep(100);
                //}
                Console.Clear();
                //else {
                Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Totale Katastrophe der Warpkern ist geschmolzen und die Enterprise ist zerstört!");
                    blink = true;
                    Thread.Sleep(400);

                //}
            }
        }
    }
}
