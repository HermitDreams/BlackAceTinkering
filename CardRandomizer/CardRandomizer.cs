// See https://aka.ms/new-console-template for more information
// Mega Man Star Force 3: Black Ace Card Randomizer in C#, by Linkshot, 2025
using System;
using System.IO;
using System.Text;

namespace sf3ba_cardshuffler
{
    internal class CardRandomizer
    {
        #region Initialization
        public static int sf3baCardColour = 0;
		public static int sf3baElement = 0;
		public static int sf3baClass = 0;
		public static bool sf3baShowDamage = true;
		public static bool sf3baStopTime = false;
		public static bool sf3baTextColour = true;
		public static bool sf3baMega = false;
		public static bool sf3baCounterAttack = false;
		public static bool sf3baSword = false;
		public static bool sf3baBreak = false;
		public static bool sf3baSnipe = false;
		public static bool sf3baWind = false;
		public static bool sf3baInvis = true;
		public static bool sf3baFlinch = true;
		public static bool sf3baSummon = false;
		public static int sf3baPortrait = 0;
		public static int sf3baPalette = 0;
		public static int sf3baPower = 0;
		public static int sf3baKeyFrame1 = 0;
		public static int sf3baKeyFrame2 = 0;
		public static int sf3baKeyFrame3 = 0;
		public static int sf3baKeyFrame4 = 0;
		public static int sf3baKeyFrame5 = 0;
		public static int sf3baKeyFrame6 = 0;
        #region BehavVars
        public static int sf3baTier = 0;
		public static int sf3baVariant = 0;
		public static int sf3baLockOn = 0;
		public static int sf3baState = 0;
		public static int sf3baEffect = 0;
		public static int sf3baSubEffect = 0;
		public static int sf3baCooldown = 0;
        #endregion BehavVars

        public static int sf3baLibByte1;
        public static int sf3baVersByte = 255;
        public static int sf3baTraitByte1 = 0;
        public static int sf3baTraitByte2 = 0;
        public static int sf3baPortByte1 = 0;
        public static int sf3baPortByte2 = 0;
        public static int sf3baPalByte1 = 0;
		public static int sf3baPalByte2 = 0;
		public static int sf3baDmgByte1 = 0;
		public static int sf3baDmgByte2 = 0;
		public static int sf3baAnimByte1 = 0;
		public static int sf3baAnimByte2 = 0;
		public static int sf3baAnimByte3 = 0;
		public static int sf3baAnimByte4 = 0;
		public static int sf3baAnimByte5 = 0;
		public static int sf3baAnimByte6 = 0;
		
		public static int sf3baTierByte = 0;
		public static int sf3baLockOnByte = 0;
		public static int sf3baStateByte = 0;
		public static int sf3baEffectByte = 0;
		public static int sf3baSubByte1 = 0;
		public static int sf3baSubByte2 = 0;
		public static int sf3baCooldownByte = 0;

		public static int sf3baSlot = 0;
        #endregion Initialization
        static void Main()
        {
            #region Reinitialization
            var ffrspretries = 0;
        retry:
            // colors.echo(ffrspretries, $"Spellbinding! Attempt {ffrspretries + 1}..");
            sf3baCardColour = 0;
			sf3baElement = 0;
			sf3baClass = 0;
			sf3baShowDamage = true;
			sf3baStopTime = false;
			sf3baTextColour = true;
			sf3baMega = false;
			sf3baCounterAttack = false;
			sf3baSword = false;
			sf3baBreak = false;
			sf3baSnipe = false;
			sf3baWind = false;
			sf3baInvis = true;
			sf3baFlinch = true;
			sf3baSummon = false;
			sf3baPortrait = 0;
			sf3baPalette = 0;
			sf3baPower = 0;
			sf3baKeyFrame1 = 0;
			sf3baKeyFrame2 = 0;
			sf3baKeyFrame3 = 0;
			sf3baKeyFrame4 = 0;
			sf3baKeyFrame5 = 0;
			sf3baKeyFrame6 = 0;
			#region BehavVars
			sf3baTier = 0;
			sf3baVariant = 0;
			sf3baLockOn = 0;
			sf3baState = 0;
			sf3baEffect = 0;
			sf3baSubEffect = 0;
			sf3baCooldown = 0;
			#endregion BehavVars
	
			sf3baLibByte1 = 0;
			sf3baVersByte = 255;
			sf3baTraitByte1 = 0;
			sf3baTraitByte2 = 0;
			sf3baPortByte1 = 0;
			sf3baPortByte2 = 0;
			sf3baPalByte1 = 0;
			sf3baPalByte2 = 0;
			sf3baDmgByte1 = 0;
			sf3baDmgByte2 = 0;
			sf3baAnimByte1 = 0;
			sf3baAnimByte2 = 0;
			sf3baAnimByte3 = 0;
			sf3baAnimByte4 = 0;
			sf3baAnimByte5 = 0;
			sf3baAnimByte6 = 0;
			
			sf3baTierByte = 0;
			sf3baLockOnByte = 0;
			sf3baStateByte = 0;
			sf3baEffectByte = 0;
			sf3baSubByte1 = 0;
			sf3baSubByte2 = 0;
			sf3baCooldownByte = 0;
			
			sf3baSlot = 0;
            var path = @"C:\Users\Linkshot\Utilities\SF3BATools\CardRandomizer\output\";
            var data = $@"patch\CardShuffleTest_{DateTime.UtcNow.Ticks.ToString()}.ips";
            #endregion Reinitialization
            using (BinaryWriter etch = new BinaryWriter(System.IO.File.OpenWrite($@"{path}{data}")))
                {

                var cardDice = new System.Random();
                // var sf3baLibraryPatch = new List<byte>();
                   // var sf3baAttributePatch = new List<byte>();
                   // var sf3baPatchCount = 0;
                    etch.Write(Encoding.ASCII.GetBytes("PATCH"));
				etch.Write((byte)0x0D); etch.Write(0xA01CFC54);

			libraloop:
				sf3baSlot++;

                int sf3baCardColour = cardDice.Next(0, 4);
                int sf3baElement = cardDice.Next(0, 5);
                int sf3baClass = cardDice.Next(1, 4);
				int sf3baShowDamage = cardDice.Next(0, 2);
				int sf3baStopTime = cardDice.Next(0, 2);
				int sf3baTextColour = cardDice.Next(0, 2);
				int sf3baMega = cardDice.Next(0, 2);
                int sf3baCounterAttack = cardDice.Next(0, 2);
                int sf3baSword = cardDice.Next(0, 2);
                int sf3baBreak = cardDice.Next(0, 2);
                int sf3baSnipe = cardDice.Next(0, 2);
                int sf3baWind = cardDice.Next(0, 2);
                int sf3baInvis = cardDice.Next(0, 2);
                int sf3baFlinch = cardDice.Next(0, 2);
                int sf3baSummon = cardDice.Next(0, 2);

				int sf3baPortrait = cardDice.Next(0, 167);
				int sf3baPalette = cardDice.Next(167, 575);
				int sf3baPower = cardDice.Next(10, 251);

				int sf3baStar1 = cardDice.Next(0, 26);
                int sf3baStar2 = cardDice.Next(0, 51);
                int sf3baStar3 = cardDice.Next(0, 76);
                int sf3baStar4 = cardDice.Next(0, 101);
                int sf3baStar5 = cardDice.Next(0, 101);
                int sf3baStar6 = cardDice.Next(0, 101);

                int sf3baPowerOff = cardDice.Next(0, 5);
				int sf3baPowerUp = cardDice.Next(0, 10);

				//switch (sf3baCardColour)
				//{
				//	case 0: sf3baCardColour = 0; break;
				//	default: sf3baCardColour = 1; break;
				//}

				int sf3baElemBits = 0;
				switch (sf3baElement)
				{
					case 0: sf3baElemBits = 0; break;
					case 1: sf3baElemBits = 4; break;
					case 2: sf3baElemBits = 8; break;
					case 3: sf3baElemBits = 12; break;
					case 4: sf3baElemBits = 16; break;
				}

				int sf3baClassBits = 0;
				//switch (sf3baClass)
				//{
				//	case 0: sf3baClassBits = 0; break;
				//	case 1: sf3baClassBits = 32; break;
				//	case 2: sf3baClassBits = 64; break;
				//}

				if (sf3baPowerOff == 0) { sf3baPower = 0; }
				if (sf3baPowerUp == 0) { sf3baPower = sf3baPower * 2; }

				sf3baLibByte1 = (sf3baCardColour + sf3baElemBits + sf3baClassBits);
				sf3baTraitByte1 = (sf3baShowDamage + (sf3baStopTime * 2) + (sf3baTextColour * 8) + (sf3baMega * 16) + (sf3baCounterAttack * 32) + (sf3baSword * 128));
				sf3baTraitByte2 = (sf3baBreak + (sf3baSnipe * 2) + (sf3baWind * 4) + (sf3baInvis * 8) + (sf3baFlinch * 16) + (sf3baSummon * 32));
				sf3baPortByte1 = sf3baPortrait;
				sf3baPalByte1 = sf3baPalette;
				sf3baPalByte2 = (int)Math.Floor(sf3baPalette / 256.0);
				sf3baDmgByte1 = sf3baPower;
				sf3baDmgByte2 = (int)Math.Floor(sf3baPower / 256.0);

				etch.Write((byte)sf3baLibByte1);
				etch.Write((byte)0xFF);
				etch.Write((byte)sf3baTraitByte1); etch.Write((byte)sf3baTraitByte2);
				etch.Write((byte)sf3baPortByte1); etch.Write((byte)0x00);
				etch.Write((byte)sf3baPalByte1); etch.Write((byte)sf3baPalByte2);
				etch.Write((byte)sf3baDmgByte1); etch.Write((byte)sf3baDmgByte2);
				etch.Write((byte)sf3baStar1); etch.Write((byte)sf3baStar2); etch.Write((byte)sf3baStar3); etch.Write((byte)sf3baStar4); etch.Write((byte)sf3baStar5); etch.Write((byte)sf3baStar6);

				etch.Flush();
                if (sf3baSlot < 458) { goto libraloop; }


				sf3baSlot = 0;
				etch.Write((byte)0x0D); etch.Write(0x500E7472);
                etch.Flush();
            attriloop:
                    sf3baSlot++;
					
					int sf3baTier = cardDice.Next(0,12);
					int sf3baVariant = cardDice.Next(1,13);
					int sf3baLockOn = cardDice.Next(1,16);
					int sf3baState = cardDice.Next(1,7);
					int sf3baEffect = cardDice.Next(4,99);
					int sf3baSubEffect = cardDice.Next(0,31);
					int sf3baCooldown = cardDice.Next(0,17);
					
					switch (sf3baLockOn)
					{
						case 1: sf3baLockOnByte = 0x00; break;
						case 2: sf3baLockOnByte = 0x01; break;
						case 3: sf3baLockOnByte = 0x02; break;
						case 4: sf3baLockOnByte = 0x03; break;
						case 5: sf3baLockOnByte = 0x07; break;
						case 6: sf3baLockOnByte = 0x11; break;
						case 7: sf3baLockOnByte = 0x16; break;
						case 8: sf3baLockOnByte = 0x23; break;
						case 9: sf3baLockOnByte = 0x34; break;
						case 10: sf3baLockOnByte = 0x35; break;
						case 11: sf3baLockOnByte = 0x44; break;
						case 12: sf3baLockOnByte = 0x51; break;
						case 13: sf3baLockOnByte = 0x61; break;
						case 14: sf3baLockOnByte = 0x74; break;
						case 15: sf3baLockOnByte = 0x84; break;
					}
					switch (sf3baState)
					{
						case 1: sf3baStateByte = 0x00; break;
						case 2: sf3baStateByte = 0x06; break;
						case 3: sf3baStateByte = 0x0A; break;
						case 4: sf3baStateByte = 0x14; break;
						case 5: sf3baStateByte = 0x1E; break;
						case 6: sf3baStateByte = 0x28; break;
					}
					switch (sf3baEffect)
					{
						case 97: sf3baEffectByte = 0x64; break;
						case 98: sf3baEffectByte = 0x65; break;
                    default: sf3baEffectByte = sf3baEffect; break;
                }
					switch (sf3baEffect)
					{
						case 97: sf3baVariant = (int)Math.Floor(sf3baVariant / 1.5); break;
                    default: sf3baVariant = (int)Math.Floor(sf3baVariant / 3.0); break;
                }
					switch (sf3baEffect)
					{
					case 33: sf3baSubByte1 = sf3baSubEffect * 20; break;
					case 51: sf3baSubByte1 = sf3baSubEffect * 20; break;
					case 61: sf3baSubByte1 = sf3baSubEffect * 20; break;
						case 75: sf3baSubByte1 = sf3baSubEffect * 20; break;
						case 87: sf3baSubByte1 = sf3baSubEffect * 10; break;
						case 89: sf3baSubByte1 = (int)Math.Floor(sf3baSubEffect / 11.0); break;
					default: sf3baSubByte1 = sf3baSubEffect; break;
					}
					sf3baTierByte = sf3baTier + (sf3baVariant * 16);
					sf3baCooldownByte = sf3baCooldown;
				sf3baSubByte2 = (int)Math.Floor(sf3baSubByte1 / 256.0);

                etch.Write((byte)sf3baTierByte);
                etch.Write((byte)sf3baLockOnByte);
                etch.Write((byte)sf3baStateByte);
                etch.Write((byte)sf3baEffectByte);
                etch.Write((byte)sf3baSubByte1);
				etch.Write((byte)sf3baSubByte2);
                etch.Write((byte)sf3baCooldownByte);
                etch.Write((byte)0x00);

                etch.Flush();
					if (sf3baSlot < 458) { goto attriloop; }
                etch.Write(Encoding.ASCII.GetBytes("EOF"));
            }
            }
        }
    }