﻿namespace ColdWarZombieTrainer
{
    class Offsets
    {
        public static int PlayerBase = 0xFD6B7C8;

        public static class PlayerCompPtr
        {
            public static int ArraySizeOffset = 0xB830;
            public static int GodMode = 0xE67;
            public static int RunSpeed = 0x5C30;
            public static int Ammo = 0x13D4;
            public static int Points = 0x5CE4;
        }


        public class PlayerPedPtr
        {
            public static int Coords = 0x2D4;
            public static int HeadingXY = 0x38;
            public static int HeadingZ = 0x34;
            public static int ArraySizeOffset = 0x5F8;
        }

        public class ZombieBotListBase
        {
            public static int BotMaxHealth = 0x39C;
            public static int BotHealth = 0x398;
            public static int BotArraySizeOffset = 0x5F8;
            public static int Coords = 0x2D4;
        }

        public class ZombieGlobalClass
        {
            public static int ZombieLeftCount = 0x3C;
        }

        public class ZombieXpScaleBase
        {
            public int XPGun = 0x30; //XPGun_Offset

            public int XPUserFake = 0x20; //Fake XPEP_InGame_Offset
            public int XPUserReal = 0x28; //Real XPEP_RealAdd_Offset
        }
    }
}
