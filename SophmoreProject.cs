
//#define DEBUG //uncomment to enabled Debug mode for easy testing (mostly increases mob spawn rates)

using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace SophmoreProject
{
	public class SophmoreProject : Mod
	{
		public override void Load()
		{
			Logger.InfoFormat("Loading Xithen Mod...");
		}
	}
}

namespace SophmoreProject.Internal
{
	public static class Palette
	{
		public static Color baseColor = new Color(78, 19, 88);
		public static Color darkColor = new Color(52, 11, 59);
		public static Color lightColor = new Color(110, 44, 122);
		public static Color brightColor = new Color(152, 85, 166);
	}

#if DEBUG
	public static class Debug
    {
		public static int XithSlimeHighSpawnRate = 5;
    }
#endif

}