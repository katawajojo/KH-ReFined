/*
===================================================
      KINGDOM HEARTS - RE:FIXED FOR 1 FM!
       COPYRIGHT TOPAZ WHITELOCK - 2022
 LICENSED UNDER DBAD. GIVE CREDIT WHERE IT'S DUE! 
===================================================
*/

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

using DiscordRPC;

namespace ReFixed
{
	public partial class Variables
	{
		public static DiscordRpcClient RichClient = new DiscordRpcClient("837171155076513834");

	    public static string[] ModeText = new string[] { "Beginner", "Standard", "Proud" };
        public static string[] WorldImages = new string[] { "", "di", "", "tt", "wn", "tz", "po", "", "al", "lm", "nm", "he", "pn", "nv", "", "hb", "eh" };
       
        public static Process GameProcess;
        public static IntPtr GameHandle;

        public static ulong GameAddress;
		public static ulong ExeAddress;

		public static ulong BaseAddress = 0x3A0606;
		public static ulong FovSwitchAddress = 0x2A5B7DA;

		public static ulong InputAddress = 0x1F9CA2E;

		public static ulong SoraMPAddress = 0x246E512;
		public static ulong SoraMagicAddress = 0x2A4543E;
		
		public static ulong SaveMenuSelect = 0x2A7C552; 
		public static ulong[] ResetAddresses = new ulong[] { 0x1F480D6, 0x1F480DA, 0x1F9BC3A };

		public static ulong[] FovTextAddresses = new ulong[] { 0x2A76F66, 0x2A78F86 };
		public static ulong[] CamTextAddresses = new ulong[] { 0x2A76F6E, 0x2A79D4D };

		public static ushort[] FovTextOffsets = new ushort[] { 0x1EBA, 0x1EC8, 0x1ED0, 0x1ED9 };
		public static ushort[] CamTextOffsets = new ushort[] { 0x2C88, 0x2C8F };

		public static float[] FovClassic = new float[] { 400, -50, -100, 350, 300, 300, 300, 300 };
		public static float[] FovEnhanced = new float[] { 600, 0, -150, 600, 600, 600, 600, 600 };

		public static ulong InformationPointer = 0x2B379CA;
		public static ulong SaveAddress = 0x2A5BFCA;

		public static ulong LevelAddress = 0x02A453CE;
		public static ulong DifficultyAddress = 0x02A5B7F6;
		public static ulong WorldAddress = 0x01F9C4D6;
		public static ulong TimeAddress = 0x01F9BC4E;
		public static ulong MunnyAddress = 0x2A5B7E6;

		public static byte SaveIterator;
		public static byte SaveWorld;
		public static byte SaveRoom;

        public static ulong[] FovAddresses = new ulong[] 
        { 
            0x2194066, 0x2194072, 0x219406E, 
            0x0163352, 0x0163372, 0x0163392, 0x01633B2,
            0x2A4518E
        };

		public static string FovTextString = "Field of View{0x00}Classic{0x00}Enhanced{0x00}Toggle between Field of View modes.";
		public static string CamTextString = "X-Axis{0x00}Y-Axis";
	}
}
