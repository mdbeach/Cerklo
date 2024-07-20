using osu.Framework.Platform;
using osu.Framework;
using Cerklo.Game;

namespace Cerklo.Desktop
{
    public static class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableDesktopHost(@"Cerklo"))
            using (osu.Framework.Game game = new CerkloGame())
                host.Run(game);
        }
    }
}
