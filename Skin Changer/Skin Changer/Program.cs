//Credits to Trelli for base

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using System.Reflection;

namespace Skin_Changer
{
    class Program
    {
        public static int currSkinId = 0;
        public static int tempSkinId = 0;
        public static Dictionary<string, int> numSkins = new Dictionary<string, int>();
        public static Menu Config;
        public static bool changedForm = false;
        public static Obj_AI_Hero skinTarget = null;
        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        public static void Game_OnGameLoad(EventArgs args)
        {
            Game.PrintChat(
            string.Format(
                "{0} v{1} Skin Changer - Parable of the cheap man by MetaPhorce.",
                Assembly.GetExecutingAssembly().GetName().Name,
                Assembly.GetExecutingAssembly().GetName().Version
            ));

            //Skin Dictionary
            numSkins.Add("Aatrox", 2);
            numSkins.Add("Ahri", 4);
            numSkins.Add("Akali", 6);
            numSkins.Add("Alistar", 7);
            numSkins.Add("Amumu", 7);
            numSkins.Add("Anivia", 5);
            numSkins.Add("Annie", 8);
            numSkins.Add("Ashe", 6);
            numSkins.Add("Azir", 1);
            numSkins.Add("Blitzcrank", 7);
            numSkins.Add("Brand", 4);
            numSkins.Add("Braum", 1);
            numSkins.Add("Caitlyn", 6);
            numSkins.Add("Cassiopeia", 4);
            numSkins.Add("Chogath", 5);
            numSkins.Add("Corki", 7);
            numSkins.Add("Darius", 4);
            numSkins.Add("Diana", 2);
            numSkins.Add("Draven", 5);
            numSkins.Add("DrMundo", 7);
            numSkins.Add("Elise", 2);
            numSkins.Add("Evelynn", 4);
            numSkins.Add("Ezreal", 7);
            numSkins.Add("Fiddlesticks", 8);
            numSkins.Add("Fiora", 3);
            numSkins.Add("Fizz", 4);
            numSkins.Add("Galio", 4);
            numSkins.Add("Gangplank", 6);
            numSkins.Add("Garen", 6);
            numSkins.Add("Gnar", 1);
            numSkins.Add("Gragas", 8);
            numSkins.Add("Graves", 5);
            numSkins.Add("Hecarim", 5);
            numSkins.Add("Heimerdinger", 7);
            numSkins.Add("Irelia", 4);
            numSkins.Add("Janna", 6);
            numSkins.Add("JarvanIV", 6);
            numSkins.Add("Jax", 8);
            numSkins.Add("Jayce", 2);
            numSkins.Add("Jinx", 1);
            numSkins.Add("Kalista", 1);
            numSkins.Add("Karma", 4);
            numSkins.Add("Karthus", 5);
            numSkins.Add("Kassadin", 4);
            numSkins.Add("Katarina", 7);
            numSkins.Add("Kayle", 7);
            numSkins.Add("Kennen", 5);
            numSkins.Add("Khazix", 3);
            numSkins.Add("KogMaw", 8);
            numSkins.Add("Leblanc", 4);
            numSkins.Add("LeeSin", 6);
            numSkins.Add("Leona", 4);
            numSkins.Add("Lissandra", 2);
            numSkins.Add("Lucian", 2);
            numSkins.Add("Lulu", 4);
            numSkins.Add("Lux", 5);
            numSkins.Add("Malphite", 6);
            numSkins.Add("Malzahar", 4);
            numSkins.Add("Maokai", 5);
            numSkins.Add("Masteryi", 5);
            numSkins.Add("MasterYi", 5);
            numSkins.Add("MissFortune", 7);
            numSkins.Add("MonkeyKing", 4);
            numSkins.Add("Mordekaiser", 4);
            numSkins.Add("Morgana", 5);
            numSkins.Add("Nami", 2);
            numSkins.Add("Nasus", 5);
            numSkins.Add("Nautilus", 3);
            numSkins.Add("Nidalee", 6);
            numSkins.Add("Nocturne", 5);
            numSkins.Add("Nunu", 6);
            numSkins.Add("Olaf", 4);
            numSkins.Add("Orianna", 4);
            numSkins.Add("Pantheon", 6);
            numSkins.Add("Poppy", 6);
            numSkins.Add("Quinn", 2);
            numSkins.Add("Rammus", 6);
            numSkins.Add("Renekton", 6);
            numSkins.Add("Rengar", 2);
            numSkins.Add("Riven", 5);
            numSkins.Add("Rumble", 3);
            numSkins.Add("Ryze", 8);
            numSkins.Add("Sejuani", 4);
            numSkins.Add("Shaco", 6);
            numSkins.Add("Shen", 6);
            numSkins.Add("Shyvana", 5);
            numSkins.Add("Singed", 6);
            numSkins.Add("Sion", 4);
            numSkins.Add("Sivir", 6);
            numSkins.Add("Skarner", 3);
            numSkins.Add("Sona", 5);
            numSkins.Add("Soraka", 4);
            numSkins.Add("Swain", 3);
            numSkins.Add("Syndra", 2);
            numSkins.Add("Talon", 3);
            numSkins.Add("Taric", 3);
            numSkins.Add("Teemo", 7);
            numSkins.Add("Thresh", 2);
            numSkins.Add("Tristana", 6);
            numSkins.Add("Trundle", 4);
            numSkins.Add("Tryndamere", 6);
            numSkins.Add("TwistedFate", 8);
            numSkins.Add("Twitch", 6);
            numSkins.Add("Udyr", 3);
            numSkins.Add("Urgot", 3);
            numSkins.Add("Varus", 3);
            numSkins.Add("Vayne", 5);
            numSkins.Add("Veigar", 8);
            numSkins.Add("Velkoz", 1);
            numSkins.Add("Viktor", 3);
            numSkins.Add("Vi", 3);
            numSkins.Add("Vladimir", 6);
            numSkins.Add("Volibear", 4);
            numSkins.Add("Warwick", 7);
            numSkins.Add("Xerath", 3);
            numSkins.Add("XinZhao", 5);
            numSkins.Add("Yasuo", 2);
            numSkins.Add("Yorick", 2);
            numSkins.Add("Zac", 1);
            numSkins.Add("Zed", 3);
            numSkins.Add("Ziggs", 4);
            numSkins.Add("Zilean", 4);
            numSkins.Add("Zyra", 3);

            Config = new Menu("SkinChanger", "SkinChanger", true);
            var ChangeSkin = Config.AddItem(new MenuItem("CycleSkins", "CycleSkins!").SetValue(new KeyBind("9".ToCharArray()[0], KeyBindType.Toggle)));
            Config.AddItem(new MenuItem("cChange", "Select champ to change (LftClk)").SetValue(new KeyBind("I".ToCharArray()[0], KeyBindType.Toggle)));

            ChangeSkin.ValueChanged += delegate(object sender, OnValueChangeEventArgs EventArgs)
            {
                if (skinTarget != null && Config.Item("cChange").GetValue<KeyBind>().Active)
                {
                    if (numSkins[skinTarget.ChampionName] > tempSkinId)
                        tempSkinId++;
                    else
                        tempSkinId = 0;

                    GenerateSkinPacket(skinTarget.ChampionName, tempSkinId);
                }
                else
                {
                    if (numSkins[ObjectManager.Player.ChampionName] > currSkinId)
                        currSkinId++;
                    else
                        currSkinId = 0;

                    GenerateSkinPacket(ObjectManager.Player.BaseSkinName, currSkinId);
                }
            };

            Config.AddToMainMenu();
            Game.OnGameProcessPacket += OnGameProcessPacket;
            Game.OnUpdate += UpdateGame;
            Game.OnWndProc += Game_OnWndProc;
        }

        public static void GenerateSkinPacket(string currentChampion, int skinNumber)
        {
            int netID;
            if (skinTarget != null && Config.Item("cChange").GetValue<KeyBind>().Active)
            {
                netID = skinTarget.NetworkId;
            }
            else
            {
                netID = ObjectManager.Player.NetworkId;
            }
            GamePacket model = Packet.S2C.UpdateModel.Encoded(new Packet.S2C.UpdateModel.Struct(netID, skinNumber, currentChampion));
            model.Process(PacketChannel.S2C);
        }

        private static void OnGameProcessPacket(GamePacketEventArgs args)
        {
            if (PacketChannel.S2C == args.Channel && args.PacketData[0] == Packet.S2C.UpdateModel.Header) // Update Packet recieved. 
            {
                var decoded = Packet.S2C.UpdateModel.Decoded(args.PacketData);
                if(decoded.NetworkId == ObjectManager.Player.NetworkId)
                {
                    changedForm = true;
                }
            }
        }

        private static void UpdateGame(EventArgs args)
        {
            //Game.PrintChat("Base skin is: " + ObjectManager.Player.BaseSkinName);
            //Game.PrintChat("skin is: " + ObjectManager.Player.SkinName);
            if (changedForm == true)
            {
                if(ObjectManager.Player.ChampionName == "Udyr")
                {
                    GenerateSkinPacket(ObjectManager.Player.SkinName, currSkinId);
                }
                else
                {
                    GenerateSkinPacket(ObjectManager.Player.BaseSkinName, currSkinId);
                }
                changedForm = false;
            }
        }

        private static void Game_OnWndProc(WndEventArgs args)
        {
            if (args.Msg != (uint)WindowsMessages.WM_LBUTTONDOWN || !Config.Item("cChange").GetValue<KeyBind>().Active)
            {
                //Game.PrintChat("Wasn't true: " + Config.Item("cChange").GetValue<KeyBind>().Active);
                return;
            }
            skinTarget = null;
            foreach (var hero in ObjectManager.Get<Obj_AI_Hero>())
            {
                if (SharpDX.Vector2.Distance(Game.CursorPos.To2D(), hero.ServerPosition.To2D()) < 300 && !hero.IsMe)
                {
                    Game.PrintChat(hero.ChampionName + " selected. You may now cycle their skin!");
                    skinTarget = hero;
                    tempSkinId = 0; //reset for each new champ selected
                    return;
                }
            }
        }
    }
}
