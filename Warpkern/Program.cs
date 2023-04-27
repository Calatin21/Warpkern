namespace Warpkern {
    internal class Program {
        static void Main(string[] args) {
            Warpkern ncc = new Warpkern();
            WarpkernKonsole konsole = new WarpkernKonsole();
            ncc.WarpEvent += konsole.TemperaturVeraenderung;
            ncc.WarpEvent += konsole.Überhitzt;
            ncc.WarpEvent += konsole.Kernschmelze;
            ncc.InBetrieb();
        }
    }
}