namespace Warpkern {
    internal class Program {
        static void Main(string[] args) {
            Warpkern ncc = new Warpkern();
            WarpkernKonsole konsole = new WarpkernKonsole();
            ncc.WarpEventTAE += konsole.TemperaturVeraenderung;
            ncc.WarpEventTUE += konsole.Überhitzt;
            ncc.WarpEventSCH += konsole.Kernschmelze;
            ncc.InBetrieb();
        }
    }
}