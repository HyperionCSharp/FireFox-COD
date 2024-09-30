using BlueRain;
using FireFoxAPI1One;
using FireFoxAPITwo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireFox.Utils;
using System.IO;
using DevExpress.XtraEditors;
using Discord.Webhook;
using Discord;
using static FireFox.Dependencies.Weapons;
using FireFoxAPIThree;
using FireFox.Dependencies;
using System.Security.Cryptography;
using System.Net;
using Leaf.xNet;

namespace FireFox
{

    class MainTab
    {
        //Stuff Used To Connect To The Game...
        //Process Name Handle
        public static string FireFoxTargetProcessName = "BlackOpsColdWar";
        public static bool FireFoxIsInGame = true;
        public static Process FireFoxgameProc;
        public static int FireFoxgamePID;
        public static IntPtr FireFoxhProc;
        private static NativeMemory FireFox_memory;
        public static IntPtr FireFoxPlayerCompPtr;

        //Gathering Main Addresses
        public static IntPtr FireFoxbaseAddress = IntPtr.Zero;
        public static IntPtr FireFoxPlayerPedPtr;
        public static IntPtr FireFoxPlayerBase;
        public static IntPtr FireFoxZMGlobalBase;
        public static IntPtr FireFoxZMBotBase;
        public static IntPtr FireFoxZMBotListBase;
        public static int FireFoxPlayerBase2;

        //Players Names
        //Player Names Save
        public static string FireFoxPlayer1Name;
        public static string FireFoxPlayer2Name;
        public static string FireFoxPlayer3Name;
        public static string FireFoxPlayer4Name;
        public static int FireFoxPlayerID;
        public static string FireFoxPlayerName;

        //Stats Stuff
        public static long FireFoxclientSize = 0x114D8;

        //Functions Time
        public static int FireFoxPC_ArraySize_Offset;
        public static int FireFoxMainCamo;
        public static int FireFoxGodMode;
        public static int FireFoxPC_Name;
        public static int FireFoxInfraredVision;
        public static int FireFoxJumpHeight;
        public static int FireFoxPP_Coords;
        public static int FireFoxXPBaseLevel;
        public static int FireFoxXPBaseLevelFake;
        public static int FireFoxXPBaseWeapon;


        //Rapid Fire Shit
        public static BackgroundWorker FireFoxClientsRapidFireEnable = new BackgroundWorker();
        public static BackgroundWorker FireFoxClientsRapidFireDisable = new BackgroundWorker();
        public static bool FireFoxRapidFireEnabledP1 = false;
        public static bool FireFoxRapidFireEnabledP2 = false;
        public static bool FireFoxRapidFireEnabledP3 = false;
        public static bool FireFoxRapidFireEnabledP4 = false;
        public static bool FireFoxRapidFireAlreadyEnabled = false;
        public static bool FireFoxRapidFireAlreadyDisabled = false;
        public static int FireFoxRapidFire1 = 0xE6C;
        public static int FireFoxRapidFire2 = 0xE80;

        //All Other Offsets
        public static int FireFoxPC_Points = 0x5D24;

        //Instant Kill Zombies
        public static BackgroundWorker FireFoxInstantKillAllClientsBGWorker = new BackgroundWorker();
        public static bool FireFoxInstantKillZombiesHasBeenEnabled = false;
        public static bool FireFoxInstantKillZombiesToggle = false;

        //Teleport Functionality
        //Teleport Origins/Options
        public static BackgroundWorker FireFoxAllClientTPZMBGWorker = new BackgroundWorker();
        public static Vector3 FireFoxupdatedPlayerPos = Vector3.Zero;
        public static float FireFoxorigx;
        public static float FireFoxorigy;
        public static float FireFoxorigz;
        //TP Dogs Seperate
        public static bool FireFoxAllClientTPEnabledPreviously = false;
        public static bool FireFoxTurnOnFreezeZombies = false;
        public static bool FireFoxTPDogsSeperate = false;
        public static bool FireFoxTPDogsOnground = false;

        //Crit Kills
        public static BackgroundWorker FireFoxAllClientCritKillsBGWorker = new BackgroundWorker();
        public static bool FireFoxCriticalKillsHasBeenEnabled = false;
        public static bool FireFoxTurnOnCrits = false;
        public static int FireFoxCritKill1 = 0x10D2;
        public static int FireFoxCritKill2 = 0x10D8;
        public static int FireFoxCritKill3 = 0x10EA;
        public static int FireFoxCritKill4 = 0x10EE;
        public static int FireFoxCritKill5 = 0x10CA;
        public static int FireFoxCritKill6 = 0x10CE;
        public static int FireFoxCritKill7 = 0x10DA;
        public static int FireFoxCritKill8 = 0x10DC;

        //Unlimited Ammo Stuff
        public static BackgroundWorker FireFoxAllClientUnlimitedAmmoBGWorker = new BackgroundWorker();
        public static int FireFoxAmmo = 0x13D4;
        public static bool FireFoxUnlimitedAmmoToggle = false;
        public static bool FireFoxUnlimitedAmmoHasBeenEnabled = false;

        //CMD Shit
        public static int CMDBufferBase = 0xD8AC3F0;

        //Rapid Fire Stuff
        public static BackgroundWorker FireFoxAllClientRapidFireBGWorker = new BackgroundWorker();
        public static bool FireFoxRapidFireHasBeenEnabled = false;
        public static bool FireFoxTurnOnRapidFire = false;

        //Custom Spawn Points
        //Custom Spawn Point Shit
        public static List<string> FireFoxFireBaseCustomSpawn = new List<string>();
        public static List<string> FireFoxDIECustomSpawn = new List<string>();

        //Get Player Kill Count
        public static int FireFoxKillCount = 0x5D48;
        public static int FireFoxPC_CurrentUsedWeaponID = 0x28;

        //Player One Options Bools
        public static bool FireFoxSpawnWeaponP1InProgress = false;
        public static bool FireFoxSpawnWeaponP1InProgressReticals = false;
        public static bool FireFoxSpawnWeaponP1InProgressKeyPress = false;
        public static int FireFoxPlayer1KillStart;

        //Player Two Options Bools
        public static bool FireFoxSpawnWeaponP2InProgress = false;
        public static bool FireFoxSpawnWeaponP2InProgressReticals = false;
        public static bool FireFoxSpawnWeaponP2InProgressKeyPress = false;
        public static int FireFoxPlayer2KillStart;

        //Player Three Options Bools
        public static bool FireFoxSpawnWeaponP3InProgress = false;
        public static bool FireFoxSpawnWeaponP3InProgressReticals = false;
        public static bool FireFoxSpawnWeaponP3InProgressKeyPress = false;
        public static int FireFoxPlayer3KillStart;

        //Player Four Options Bools
        public static bool FireFoxSpawnWeaponP4InProgress = false;
        public static bool FireFoxSpawnWeaponP4InProgressReticals = false;
        public static bool FireFoxSpawnWeaponP4InProgressKeyPress = false;
        public static int FireFoxPlayer4KillStart;

        //Stats Options
        public static bool IsSettingStats = false;

        //Hashes
        static string PasswordHash2 = "eKGxhCwLzMuF3d3wC8xuD";
        static string SaltKey2 = "GxZ3PHFN";
        static readonly string VIKey2 = "@hdHSrz37Xrh6zpF";
        public static WebClient client = new WebClient();

        //Check Status If In Game
        public static BackgroundWorker FireFoxCheckInGameStatusBGWorker = new BackgroundWorker();

        //Fast Rounds
        public static BackgroundWorker FireFoxFastRoundsBGWorker = new BackgroundWorker();
        public static bool FireFoxFastRoundsEnabled = false;
        public static bool FireFoxFastRoundsEnabledBefore = false;
        public static long FireFoxskipround1;
        public static long FireFoxskiproundMain;

        public static class Globals
        {
            public static Firefox FireFoxConnectOptions;
        }

        public static class FireFoxSentThread
        {
            public static void FireFoxSendThreadToServer(string ForumID, string Title, string Body)
            {
                using (HttpRequest httpRequest = new HttpRequest())
                {
                    httpRequest.AddHeader("Authorization", "Bearer " + Misc.FireFoxSavedOathToken);
                    string CreateTestThread = httpRequest.Post("https://epictools.org/api/forums/topics?forum=" + ForumID + "&title=" + Title + "&post= <center>" + Body + " </center>").ToString();
                }
            }
        }

        public static class CMDStuff
        {
            public static void SendCommand(string SendCommand)
            {
                if (FireFoxAPI3.IsProcessRunning(FireFoxTargetProcessName))
                {
                    FireFoxAPI3.WriteString(FireFoxAPI3.ReadInt64(FireFoxAPI3.BaseAddress + CMDBufferBase), SendCommand);
                    FireFoxAPI3.WriteBool(FireFoxAPI3.ReadInt64(FireFoxAPI3.BaseAddress + CMDBufferBase) - 0x1B, true);
                    Thread.Sleep(10);
                    FireFoxAPI3.WriteString(FireFoxAPI3.ReadInt64(FireFoxAPI3.BaseAddress + CMDBufferBase), "\0");
                    FireFoxAPI3.WriteBool(FireFoxAPI3.ReadInt64(FireFoxAPI3.BaseAddress + CMDBufferBase) - 0x1B, true);
                }
            }
        }

        public static class FireFoxSetDefaultImages
        {
            public static void FireFoxSetImagesDefault()
            {
                Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFoxLogo3;
                Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFoxLogo3;
                Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFoxLogo3;
                Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFoxLogo3;
                Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.Image = Properties.Resources.FireFoxLogo3;
                Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.Image = Properties.Resources.FireFoxLogo3;
                Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.Image = Properties.Resources.FireFoxLogo3;
                Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.Image = Properties.Resources.FireFoxLogo3;
            }
        }

        public static class FireFoxReticlesStartP1
        {
            public static void FireFoxStartReticlesP1()
            {
                if (FireFoxIsInGame == false)
                {
                    MessageBox.Show("Options Can Only Be Enabled When In Game!");
                    return;
                }
                if (Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueReticlesP1.Text == "Kill Swap Value" || Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueReticlesP1.Text == null || Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueReticlesP1.Text == "")
                {
                    MessageBox.Show("Please Enter A Valid Amount Of Kills Between Weapon Swap.");
                    return;
                }
                if (FireFoxSpawnWeaponP1InProgress == true)
                {
                    MessageBox.Show("Player Must Finish Regular Weapon Cycle Before Starting A New One...");
                    return;
                }
                if (FireFoxSpawnWeaponP1InProgressReticals == true)
                {
                    MessageBox.Show("Player Must Finish Retical Weapon Cycle Before Starting A New One...");
                    return;
                }
                string FireFoxToolUsername = Globals.FireFoxConnectOptions.LoginPageUsername.Text;
                string FireFoxClientUsername = FireFoxPlayer1Name.Replace("�", "").Replace("?", "");
                try
                {
                    FireFoxDiscordWebHook.FireFoxSendMessage(">>> Reticle Lobby Started...\nTool Owner: " + FireFoxToolUsername + "\nClient: " + FireFoxClientUsername + "\nPlayer Number: (Player 1)\nTime: " + DateTime.Now, FireFoxToolUsername + " --> " + FireFoxClientUsername, "https://derekknox.com/lab/reticledesigner/assets/img/reticle-designer-fui-example-3.png", "https://discord.com/api/webhooks/821280738476556330/2kHveEr9cfu_dxHnOxrN0iD07Z-ErqhbOpcS_snQWPnvU9ScPMhNkVue_jZcEGVXd9rh");
                }
                catch
                {

                }
                try
                {
                    FireFoxSentThread.FireFoxSendThreadToServer("11", "Reticle Lobby Started", ">>> Reticle Lobby Started.. <<< <br>Tool Owner: " + FireFoxToolUsername + "<br>nClient: " + FireFoxClientUsername + "<br>Player Number: (Player 1)<br>Time: " + DateTime.Now);
                }
                catch
                {

                }
                FireFoxSpawnWeaponP1InProgressKeyPress = false;
                FireFoxSpawnWeaponP1InProgress = false;
                FireFoxSpawnWeaponP1InProgressReticals = false;
                FireFoxSpawnWeaponP1InProgressReticals = true;
                Thread threadingstuff = new Thread(FireFoxStartWeaponSpawnThreadPlayer1Reticals);
                threadingstuff.Start();
            }
            public static void FireFoxStartWeaponSpawnThreadPlayer1Reticals()
            {
                //Getting Player Kill Count
                byte[] PlayerKillsStart = new byte[4];
                var KillsStart = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 0) + FireFoxKillCount, PlayerKillsStart, 4, out _);
                FireFoxPlayer1KillStart = BitConverter.ToInt32(PlayerKillsStart, 0);
                while (FireFoxSpawnWeaponP1InProgressReticals == true)
                {
                    byte[] PlayerKills = new byte[4];
                    var Kills = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 0) + FireFoxKillCount, PlayerKills, 4, out _);
                    int PlayerKillCount = BitConverter.ToInt32(PlayerKills, 0);
                    int BaseKillsmultiplier = Int32.Parse(Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueReticlesP1.Text);
                    string formattype = "{0:#,###,###.##}";
                    string KillCountTotal = string.Format(formattype, PlayerKillCount);
                    Globals.FireFoxConnectOptions.FireFoxP1KillCountReticles.Text = "Total Kills: " + KillCountTotal;
                    if (PlayerKillCount - FireFoxPlayer1KillStart == 0)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.Image = Properties.Resources.FireFox_Millstop_Reflex;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMillstopReflexCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP1.Text = "Current Weapon 1/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 1)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.Image = Properties.Resources.FireFox_Visiontech_2x;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleVisiontech2xCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP1.Text = "Current Weapon 2/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 2)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.Image = Properties.Resources.FireFox_Kobra_Red_Dot;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKobraRedDotCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP1.Text = "Current Weapon 2/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 3)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.Image = Properties.Resources.FireFox_Quickdot_LED;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKobraRedDotCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP1.Text = "Current Weapon 4/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 4)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.Image = Properties.Resources.FireFox_Axial_Arms;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAxialArmsCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP1.Text = "Current Weapon 5/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 5)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.Image = Properties.Resources.FireFox_Sillix_Holoscout;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSillixHoloscoutCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP1.Text = "Current Weapon 6/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 6)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.Image = Properties.Resources.FireFox_Microflex_LED;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMicroflexLEDCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP1.Text = "Current Weapon 7/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 7)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.Image = Properties.Resources.FireFox_Hawksmoor;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHawksmoorCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP1.Text = "Current Weapon 8/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 8)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.Image = Properties.Resources.FireFox_Royal___Kross_4X;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleRoyalKross4XCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP1.Text = "Current Weapon 9/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 9)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.Image = Properties.Resources.FireFox_Susat_Multizoom;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSusatMultizoomCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP1.Text = "Current Weapon 10/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 10)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.Image = Properties.Resources.FireFox_Diamondback_Reflex;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleDiamondbackReflexCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP1.Text = "Current Weapon 11/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 11)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.Image = Properties.Resources.FireFox_Snappoint;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSnappointCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP1.Text = "Current Weapon 12/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 12)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.Image = Properties.Resources.FireFox_Fastpoint_Reflex;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleFastpointReflexCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP1.Text = "Current Weapon 13/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 13)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.Image = Properties.Resources.FireFox_Axial_Arms_3x;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAxialArms3xCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP1.Text = "Current Weapon 14/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 14)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.Image = Properties.Resources.FireFox_Iron_Sights;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleIronSightsCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP1.Text = "Current Weapon 15/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 15)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.Image = Properties.Resources.FireFox_Otero_Mini_Reflex;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleOteroMiniReflexCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP1.Text = "Current Weapon 16/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer1KillStart > BaseKillsmultiplier * 16)
                    {
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHands(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP1.Text = "Player Has Finished Cycle!";
                        FireFoxSpawnWeaponP1InProgress = false;
                        FireFoxSpawnWeaponP1InProgressReticals = false;
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.Image = Properties.Resources.FireFoxLogo3;
                    }
                }
            }
        }

        public static class FireFoxReticlesStartP2
        {
            public static void FireFoxStartReticlesP2()
            {
                if (FireFoxIsInGame == false)
                {
                    MessageBox.Show("Options Can Only Be Enabled When In Game!");
                    return;
                }
                if (Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueReticlesP2.Text == "Kill Swap Value" || Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueReticlesP2.Text == null || Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueReticlesP2.Text == "")
                {
                    MessageBox.Show("Please Enter A Valid Amount Of Kills Between Weapon Swap.");
                    return;
                }
                if (FireFoxSpawnWeaponP2InProgress == true)
                {
                    MessageBox.Show("Player Must Finish Regular Weapon Cycle Before Starting A New One...");
                    return;
                }
                if (FireFoxSpawnWeaponP2InProgressReticals == true)
                {
                    MessageBox.Show("Player Must Finish Retical Weapon Cycle Before Starting A New One...");
                    return;
                }
                string FireFoxToolUsername = Globals.FireFoxConnectOptions.LoginPageUsername.Text;
                string FireFoxClientUsername = FireFoxPlayer2Name.Replace("�", "").Replace("?", "");
                try
                {
                    FireFoxDiscordWebHook.FireFoxSendMessage(">>> Reticle Lobby Started...\nTool Owner: " + FireFoxToolUsername + "\nClient: " + FireFoxClientUsername + "\nPlayer Number: (Player 2)\nTime: " + DateTime.Now, FireFoxToolUsername + " --> " + FireFoxClientUsername, "https://derekknox.com/lab/reticledesigner/assets/img/reticle-designer-fui-example-3.png", "https://discord.com/api/webhooks/821280738476556330/2kHveEr9cfu_dxHnOxrN0iD07Z-ErqhbOpcS_snQWPnvU9ScPMhNkVue_jZcEGVXd9rh");
                }
                catch
                {

                }
                try
                {
                    FireFoxSentThread.FireFoxSendThreadToServer("11", "Reticle Lobby Started", ">>> Reticle Lobby Started.. <<< <br>Tool Owner: " + FireFoxToolUsername + "<br>nClient: " + FireFoxClientUsername + "<br>Player Number: (Player 2)<br>Time: " + DateTime.Now);
                }
                catch
                {

                }
                FireFoxSpawnWeaponP2InProgressKeyPress = false;
                FireFoxSpawnWeaponP2InProgress = false;
                FireFoxSpawnWeaponP2InProgressReticals = false;
                FireFoxSpawnWeaponP2InProgressReticals = true;
                Thread threadingstuff = new Thread(FireFoxStartWeaponSpawnThreadPlayer2Reticals);
                threadingstuff.Start();
            }
            public static void FireFoxStartWeaponSpawnThreadPlayer2Reticals()
            {
                //Getting Player Kill Count
                byte[] PlayerKillsStart = new byte[4];
                var KillsStart = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 1) + FireFoxKillCount, PlayerKillsStart, 4, out _);
                FireFoxPlayer2KillStart = BitConverter.ToInt32(PlayerKillsStart, 0);
                while (FireFoxSpawnWeaponP2InProgressReticals == true)
                {
                    byte[] PlayerKills = new byte[4];
                    var Kills = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 1) + FireFoxKillCount, PlayerKills, 4, out _);
                    int PlayerKillCount = BitConverter.ToInt32(PlayerKills, 0);
                    int BaseKillsmultiplier = Int32.Parse(Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueReticlesP2.Text);
                    string formattype = "{0:#,###,###.##}";
                    string KillCountTotal = string.Format(formattype, PlayerKillCount);
                    Globals.FireFoxConnectOptions.FireFoxP2KillCountReticles.Text = "Total Kills: " + KillCountTotal;
                    if (PlayerKillCount - FireFoxPlayer2KillStart == 0)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.Image = Properties.Resources.FireFox_Millstop_Reflex;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMillstopReflexCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP2.Text = "Current Weapon 1/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 1)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.Image = Properties.Resources.FireFox_Visiontech_2x;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleVisiontech2xCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP2.Text = "Current Weapon 2/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 2)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.Image = Properties.Resources.FireFox_Kobra_Red_Dot;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKobraRedDotCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP2.Text = "Current Weapon 2/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 3)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.Image = Properties.Resources.FireFox_Quickdot_LED;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKobraRedDotCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP2.Text = "Current Weapon 4/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 4)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.Image = Properties.Resources.FireFox_Axial_Arms;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAxialArmsCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP2.Text = "Current Weapon 5/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 5)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.Image = Properties.Resources.FireFox_Sillix_Holoscout;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSillixHoloscoutCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP2.Text = "Current Weapon 6/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 6)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.Image = Properties.Resources.FireFox_Microflex_LED;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMicroflexLEDCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP2.Text = "Current Weapon 7/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 7)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.Image = Properties.Resources.FireFox_Hawksmoor;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHawksmoorCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP2.Text = "Current Weapon 8/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 8)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.Image = Properties.Resources.FireFox_Royal___Kross_4X;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleRoyalKross4XCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP2.Text = "Current Weapon 9/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 9)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.Image = Properties.Resources.FireFox_Susat_Multizoom;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSusatMultizoomCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP2.Text = "Current Weapon 10/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 10)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.Image = Properties.Resources.FireFox_Diamondback_Reflex;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleDiamondbackReflexCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP2.Text = "Current Weapon 11/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 11)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.Image = Properties.Resources.FireFox_Snappoint;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSnappointCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP2.Text = "Current Weapon 12/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 12)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.Image = Properties.Resources.FireFox_Fastpoint_Reflex;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleFastpointReflexCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP2.Text = "Current Weapon 13/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 13)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.Image = Properties.Resources.FireFox_Axial_Arms_3x;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAxialArms3xCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP2.Text = "Current Weapon 14/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 14)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.Image = Properties.Resources.FireFox_Iron_Sights;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleIronSightsCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP2.Text = "Current Weapon 15/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 15)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.Image = Properties.Resources.FireFox_Otero_Mini_Reflex;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleOteroMiniReflexCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP2.Text = "Current Weapon 16/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer2KillStart > BaseKillsmultiplier * 16)
                    {
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHands(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP2.Text = "Player Has Finished Cycle!";
                        FireFoxSpawnWeaponP2InProgress = false;
                        FireFoxSpawnWeaponP2InProgressReticals = false;
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.Image = Properties.Resources.FireFoxLogo3;
                    }
                }
            }
        }

        public static class FireFoxReticlesStartP3
        {
            public static void FireFoxStartReticlesP3()
            {
                if (FireFoxIsInGame == false)
                {
                    MessageBox.Show("Options Can Only Be Enabled When In Game!");
                    return;
                }
                if (Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueReticlesP3.Text == "Kill Swap Value" || Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueReticlesP3.Text == null || Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueReticlesP3.Text == "")
                {
                    MessageBox.Show("Please Enter A Valid Amount Of Kills Between Weapon Swap.");
                    return;
                }
                if (FireFoxSpawnWeaponP3InProgress == true)
                {
                    MessageBox.Show("Player Must Finish Regular Weapon Cycle Before Starting A New One...");
                    return;
                }
                if (FireFoxSpawnWeaponP3InProgressReticals == true)
                {
                    MessageBox.Show("Player Must Finish Retical Weapon Cycle Before Starting A New One...");
                    return;
                }
                string FireFoxToolUsername = Globals.FireFoxConnectOptions.LoginPageUsername.Text;
                string FireFoxClientUsername = FireFoxPlayer3Name.Replace("�", "").Replace("?", "");
                try
                {
                    FireFoxDiscordWebHook.FireFoxSendMessage(">>> Reticle Lobby Started...\nTool Owner: " + FireFoxToolUsername + "\nClient: " + FireFoxClientUsername + "\nPlayer Number: (Player 3)\nTime: " + DateTime.Now, FireFoxToolUsername + " --> " + FireFoxClientUsername, "https://derekknox.com/lab/reticledesigner/assets/img/reticle-designer-fui-example-3.png", "https://discord.com/api/webhooks/821280738476556330/2kHveEr9cfu_dxHnOxrN0iD07Z-ErqhbOpcS_snQWPnvU9ScPMhNkVue_jZcEGVXd9rh");
                }
                catch
                {

                }
                try
                {
                    FireFoxSentThread.FireFoxSendThreadToServer("11", "Reticle Lobby Started", ">>> Reticle Lobby Started.. <<< <br>Tool Owner: " + FireFoxToolUsername + "<br>nClient: " + FireFoxClientUsername + "<br>Player Number: (Player 3)<br>Time: " + DateTime.Now);
                }
                catch
                {

                }
                FireFoxSpawnWeaponP3InProgressKeyPress = false;
                FireFoxSpawnWeaponP3InProgress = false;
                FireFoxSpawnWeaponP3InProgressReticals = false;
                FireFoxSpawnWeaponP3InProgressReticals = true;
                Thread threadingstuff = new Thread(FireFoxStartWeaponSpawnThreadPlayer3Reticals);
                threadingstuff.Start();
            }
            public static void FireFoxStartWeaponSpawnThreadPlayer3Reticals()
            {
                //Getting Player Kill Count
                byte[] PlayerKillsStart = new byte[4];
                var KillsStart = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 2) + FireFoxKillCount, PlayerKillsStart, 4, out _);
                FireFoxPlayer3KillStart = BitConverter.ToInt32(PlayerKillsStart, 0);
                while (FireFoxSpawnWeaponP3InProgressReticals == true)
                {
                    byte[] PlayerKills = new byte[4];
                    var Kills = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 2) + FireFoxKillCount, PlayerKills, 4, out _);
                    int PlayerKillCount = BitConverter.ToInt32(PlayerKills, 0);
                    int BaseKillsmultiplier = Int32.Parse(Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueReticlesP3.Text);
                    string formattype = "{0:#,###,###.##}";
                    string KillCountTotal = string.Format(formattype, PlayerKillCount);
                    Globals.FireFoxConnectOptions.FireFoxP3KillCountReticles.Text = "Total Kills: " + KillCountTotal;
                    if (PlayerKillCount - FireFoxPlayer3KillStart == 0)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.Image = Properties.Resources.FireFox_Millstop_Reflex;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMillstopReflexCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP3.Text = "Current Weapon 1/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 1)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.Image = Properties.Resources.FireFox_Visiontech_2x;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleVisiontech2xCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP3.Text = "Current Weapon 2/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 2)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.Image = Properties.Resources.FireFox_Kobra_Red_Dot;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKobraRedDotCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP3.Text = "Current Weapon 2/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 3)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.Image = Properties.Resources.FireFox_Quickdot_LED;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKobraRedDotCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP3.Text = "Current Weapon 4/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 4)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.Image = Properties.Resources.FireFox_Axial_Arms;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAxialArmsCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP3.Text = "Current Weapon 5/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 5)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.Image = Properties.Resources.FireFox_Sillix_Holoscout;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSillixHoloscoutCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP3.Text = "Current Weapon 6/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 6)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.Image = Properties.Resources.FireFox_Microflex_LED;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMicroflexLEDCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP3.Text = "Current Weapon 7/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 7)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.Image = Properties.Resources.FireFox_Hawksmoor;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHawksmoorCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP3.Text = "Current Weapon 8/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 8)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.Image = Properties.Resources.FireFox_Royal___Kross_4X;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleRoyalKross4XCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP3.Text = "Current Weapon 9/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 9)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.Image = Properties.Resources.FireFox_Susat_Multizoom;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSusatMultizoomCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP3.Text = "Current Weapon 10/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 10)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.Image = Properties.Resources.FireFox_Diamondback_Reflex;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleDiamondbackReflexCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP3.Text = "Current Weapon 11/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 11)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.Image = Properties.Resources.FireFox_Snappoint;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSnappointCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP3.Text = "Current Weapon 12/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 12)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.Image = Properties.Resources.FireFox_Fastpoint_Reflex;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleFastpointReflexCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP3.Text = "Current Weapon 13/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 13)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.Image = Properties.Resources.FireFox_Axial_Arms_3x;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAxialArms3xCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP3.Text = "Current Weapon 14/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 14)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.Image = Properties.Resources.FireFox_Iron_Sights;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleIronSightsCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP3.Text = "Current Weapon 15/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 15)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.Image = Properties.Resources.FireFox_Otero_Mini_Reflex;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleOteroMiniReflexCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP3.Text = "Current Weapon 16/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer3KillStart > BaseKillsmultiplier * 16)
                    {
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHands(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP3.Text = "Player Has Finished Cycle!";
                        FireFoxSpawnWeaponP3InProgress = false;
                        FireFoxSpawnWeaponP3InProgressReticals = false;
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.Image = Properties.Resources.FireFoxLogo3;
                    }
                }
            }
        }

        public static class FireFoxReticlesStartP4
        {
            public static void FireFoxStartReticlesP4()
            {
                if (FireFoxIsInGame == false)
                {
                    MessageBox.Show("Options Can Only Be Enabled When In Game!");
                    return;
                }
                if (Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueReticlesP4.Text == "Kill Swap Value" || Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueReticlesP4.Text == null || Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueReticlesP4.Text == "")
                {
                    MessageBox.Show("Please Enter A Valid Amount Of Kills Between Weapon Swap.");
                    return;
                }
                if (FireFoxSpawnWeaponP4InProgress == true)
                {
                    MessageBox.Show("Player Must Finish Regular Weapon Cycle Before Starting A New One...");
                    return;
                }
                if (FireFoxSpawnWeaponP4InProgressReticals == true)
                {
                    MessageBox.Show("Player Must Finish Retical Weapon Cycle Before Starting A New One...");
                    return;
                }
                string FireFoxToolUsername = Globals.FireFoxConnectOptions.LoginPageUsername.Text;
                string FireFoxClientUsername = FireFoxPlayer4Name.Replace("�", "").Replace("?", "");
                try
                {
                    FireFoxDiscordWebHook.FireFoxSendMessage(">>> Reticle Lobby Started...\nTool Owner: " + FireFoxToolUsername + "\nClient: " + FireFoxClientUsername + "\nPlayer Number: (Player 4)\nTime: " + DateTime.Now, FireFoxToolUsername + " --> " + FireFoxClientUsername, "https://derekknox.com/lab/reticledesigner/assets/img/reticle-designer-fui-example-3.png", "https://discord.com/api/webhooks/821280738476556330/2kHveEr9cfu_dxHnOxrN0iD07Z-ErqhbOpcS_snQWPnvU9ScPMhNkVue_jZcEGVXd9rh");
                }
                catch
                {

                }
                try
                {
                    FireFoxSentThread.FireFoxSendThreadToServer("11", "Reticle Lobby Started", ">>> Reticle Lobby Started.. <<< <br>Tool Owner: " + FireFoxToolUsername + "<br>nClient: " + FireFoxClientUsername + "<br>Player Number: (Player 4)<br>Time: " + DateTime.Now);
                }
                catch
                {

                }
                FireFoxSpawnWeaponP4InProgressKeyPress = false;
                FireFoxSpawnWeaponP4InProgress = false;
                FireFoxSpawnWeaponP4InProgressReticals = false;
                FireFoxSpawnWeaponP4InProgressReticals = true;
                Thread threadingstuff = new Thread(FireFoxStartWeaponSpawnThreadPlayer4Reticals);
                threadingstuff.Start();
            }
            public static void FireFoxStartWeaponSpawnThreadPlayer4Reticals()
            {
                //Getting Player Kill Count
                byte[] PlayerKillsStart = new byte[4];
                var KillsStart = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 3) + FireFoxKillCount, PlayerKillsStart, 4, out _);
                FireFoxPlayer4KillStart = BitConverter.ToInt32(PlayerKillsStart, 0);
                while (FireFoxSpawnWeaponP4InProgressReticals == true)
                {
                    byte[] PlayerKills = new byte[4];
                    var Kills = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 3) + FireFoxKillCount, PlayerKills, 4, out _);
                    int PlayerKillCount = BitConverter.ToInt32(PlayerKills, 0);
                    int BaseKillsmultiplier = Int32.Parse(Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueReticlesP4.Text);
                    string formattype = "{0:#,###,###.##}";
                    string KillCountTotal = string.Format(formattype, PlayerKillCount);
                    Globals.FireFoxConnectOptions.FireFoxP4KillCountReticles.Text = "Total Kills: " + KillCountTotal;
                    if (PlayerKillCount - FireFoxPlayer4KillStart == 0)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.Image = Properties.Resources.FireFox_Millstop_Reflex;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMillstopReflexCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP4.Text = "Current Weapon 1/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 1)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.Image = Properties.Resources.FireFox_Visiontech_2x;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleVisiontech2xCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP4.Text = "Current Weapon 2/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 2)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.Image = Properties.Resources.FireFox_Kobra_Red_Dot;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKobraRedDotCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP4.Text = "Current Weapon 2/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 3)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.Image = Properties.Resources.FireFox_Quickdot_LED;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKobraRedDotCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP4.Text = "Current Weapon 4/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 4)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.Image = Properties.Resources.FireFox_Axial_Arms;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAxialArmsCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP4.Text = "Current Weapon 5/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 5)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.Image = Properties.Resources.FireFox_Sillix_Holoscout;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSillixHoloscoutCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP4.Text = "Current Weapon 6/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 6)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.Image = Properties.Resources.FireFox_Microflex_LED;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMicroflexLEDCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP4.Text = "Current Weapon 7/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 7)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.Image = Properties.Resources.FireFox_Hawksmoor;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHawksmoorCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP4.Text = "Current Weapon 8/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 8)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.Image = Properties.Resources.FireFox_Royal___Kross_4X;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleRoyalKross4XCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP4.Text = "Current Weapon 9/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 9)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.Image = Properties.Resources.FireFox_Susat_Multizoom;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSusatMultizoomCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP4.Text = "Current Weapon 10/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 10)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.Image = Properties.Resources.FireFox_Diamondback_Reflex;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleDiamondbackReflexCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP4.Text = "Current Weapon 11/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 11)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.Image = Properties.Resources.FireFox_Snappoint;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSnappointCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP4.Text = "Current Weapon 12/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 12)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.Image = Properties.Resources.FireFox_Fastpoint_Reflex;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleFastpointReflexCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP4.Text = "Current Weapon 13/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 13)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.Image = Properties.Resources.FireFox_Axial_Arms_3x;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAxialArms3xCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP4.Text = "Current Weapon 14/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 14)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.Image = Properties.Resources.FireFox_Iron_Sights;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleIronSightsCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP4.Text = "Current Weapon 15/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 15)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.Image = Properties.Resources.FireFox_Otero_Mini_Reflex;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleOteroMiniReflexCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP4.Text = "Current Weapon 16/16";
                    }
                    if (PlayerKillCount - FireFoxPlayer4KillStart > BaseKillsmultiplier * 16)
                    {
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHands(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponReticlesP4.Text = "Player Has Finished Cycle!";
                        FireFoxSpawnWeaponP4InProgress = false;
                        FireFoxSpawnWeaponP4InProgressReticals = false;
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.Image = Properties.Resources.FireFoxLogo3;
                    }
                }
            }
        }



        public static class FireFoxStatsOptions
        {
            public static void FireFoxReticlesUnlockStart(int ClientNum)
            {
                FireFoxStatsClass.FireFoxSendIntStats(ClientNum, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxMillStopReticlesUnlock, 5000);
                FireFoxStatsClass.FireFoxSendIntStats(ClientNum, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxVisiontech2xReticlesUnlock, 5000);
                FireFoxStatsClass.FireFoxSendIntStats(ClientNum, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxKobraRedDotReticlesUnlock, 5000);
                FireFoxStatsClass.FireFoxSendIntStats(ClientNum, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxQuickdotLEDReticlesUnlock, 5000);
                FireFoxStatsClass.FireFoxSendIntStats(ClientNum, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxAxialArmsReticlesUnlock, 5000);
                FireFoxStatsClass.FireFoxSendIntStats(ClientNum, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxSillixHoloscoutReticlesUnlock, 5000);
                FireFoxStatsClass.FireFoxSendIntStats(ClientNum, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxMicroflexLEDReticlesUnlock, 5000);
                FireFoxStatsClass.FireFoxSendIntStats(ClientNum, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxHawksmoorReticlesUnlock, 5000);
                FireFoxStatsClass.FireFoxSendIntStats(ClientNum, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxRoyalKrossReticlesUnlock, 5000);
                FireFoxStatsClass.FireFoxSendIntStats(ClientNum, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxSusatMultizoomReticlesUnlock, 5000);
                FireFoxStatsClass.FireFoxSendIntStats(ClientNum, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxDiamondbackReflexReticlesUnlock, 5000);
                FireFoxStatsClass.FireFoxSendIntStats(ClientNum, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxSnappointReticlesUnlock, 5000);
                FireFoxStatsClass.FireFoxSendIntStats(ClientNum, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxFastpointReflexReticlesUnlock, 5000);
                FireFoxStatsClass.FireFoxSendIntStats(ClientNum, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxAxialArm3xReticlesUnlock, 5000);
                FireFoxStatsClass.FireFoxSendIntStats(ClientNum, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxIronSightsReticlesUnlock, 5000);
                FireFoxStatsClass.FireFoxSendIntStats(ClientNum, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxOteroMiniReflexReticlesUnlock, 5000);
            }
            public static void FireFoxIfStatsChosenKillOthersP1()
            {
                if (Globals.FireFoxConnectOptions.FireFoxP1StatsRefresh.Checked)
                {
                    Globals.FireFoxConnectOptions.FireFoxP2StatsRefresh.Checked = false;
                    Globals.FireFoxConnectOptions.FireFoxP3StatsRefresh.Checked = false;
                    Globals.FireFoxConnectOptions.FireFoxP4StatsRefresh.Checked = false;
                }
            }
            public static void FireFoxIfStatsChosenKillOthersP2()
            {
                if (Globals.FireFoxConnectOptions.FireFoxP2StatsRefresh.Checked)
                {
                    Globals.FireFoxConnectOptions.FireFoxP1StatsRefresh.Checked = false;
                    Globals.FireFoxConnectOptions.FireFoxP3StatsRefresh.Checked = false;
                    Globals.FireFoxConnectOptions.FireFoxP4StatsRefresh.Checked = false;
                }
            }
            public static void FireFoxIfStatsChosenKillOthersP3()
            {
                if (Globals.FireFoxConnectOptions.FireFoxP3StatsRefresh.Checked)
                {
                    Globals.FireFoxConnectOptions.FireFoxP1StatsRefresh.Checked = false;
                    Globals.FireFoxConnectOptions.FireFoxP2StatsRefresh.Checked = false;
                    Globals.FireFoxConnectOptions.FireFoxP4StatsRefresh.Checked = false;
                }
            }
            public static void FireFoxIfStatsChosenKillOthersP4()
            {
                if (Globals.FireFoxConnectOptions.FireFoxP4StatsRefresh.Checked)
                {
                    Globals.FireFoxConnectOptions.FireFoxP1StatsRefresh.Checked = false;
                    Globals.FireFoxConnectOptions.FireFoxP2StatsRefresh.Checked = false;
                    Globals.FireFoxConnectOptions.FireFoxP3StatsRefresh.Checked = false;
                }
            }
            public static void FireFoxRandomizeMaxStats()
            {
                var One = FireFoxStatsClass.FireFoxReadIntStats(0, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxKills1);
                var Two = FireFoxStatsClass.FireFoxReadIntStats(0, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxKills2);
                var Three = FireFoxStatsClass.FireFoxReadIntStats(0, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxKills3);
                XtraMessageBox.Show(One + "\n" + Two + "/n" + Three);

                Random FireFoxrandom = new Random();
                int FireFoxMaxStatsRounds = FireFoxrandom.Next(10000, 12000);
                int FireFoxMaxStatsKills = FireFoxrandom.Next(900000, 1000000);
                int FireFoxMaxStatsEliteKills = FireFoxrandom.Next(3500, 4500);
                int FireFoxMaxStatsCriticalKills = FireFoxrandom.Next(150000, 250000);
                int FireFoxMaxElims = FireFoxrandom.Next(30000, 40000);
                int FireFoxMaxStatsGamesPlayed = FireFoxrandom.Next(300, 500);
                int FireFoxMaxStatsPlayTimeDays = FireFoxrandom.Next(17, 20);
                int FireFoxMaxStatsPlayTimeHours = FireFoxrandom.Next(1, 23);
                int FireFoxMaxStatsPlayTimeMins = FireFoxrandom.Next(1, 59);

                Globals.FireFoxConnectOptions.FireFoxTotalRoundsInput.Text = FireFoxMaxStatsRounds.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalKillsInput.Text = FireFoxMaxStatsKills.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalEliteKillsInput.Text = FireFoxMaxStatsEliteKills.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalCriticalKillsInput.Text = FireFoxMaxStatsCriticalKills.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalElimsInput.Text = FireFoxMaxElims.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalGamesPlayedInput.Text = FireFoxMaxStatsGamesPlayed.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalTimePlayedDaysInput.Text = FireFoxMaxStatsPlayTimeDays.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalTimePlayedHoursInput.Text = FireFoxMaxStatsPlayTimeHours.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalTimePlayedMinsInput.Text = FireFoxMaxStatsPlayTimeMins.ToString();

            }
            public static void FireFoxRandomzieMediumStats()
            {
                Random FireFoxrandom = new Random();
                int FireFoxMediumStatsRounds = FireFoxrandom.Next(5000, 6000);
                int FireFoxMediumStatsKills = FireFoxrandom.Next(450000, 650000);
                int FireFoxMediumStatsEliteKills = FireFoxrandom.Next(1000, 2500);
                int FireFoxMediumStatsCriticalKills = FireFoxrandom.Next(60000, 90000);
                int FireFoxMediumElims = FireFoxrandom.Next(15000, 18000);
                int FireFoxMediumStatsGamesPlayed = FireFoxrandom.Next(150, 275);
                int FireFoxMediumStatsPlayTimeDays = FireFoxrandom.Next(10, 12);
                int FireFoxMediumStatsPlayTimeHours = FireFoxrandom.Next(1, 23);
                int FireFoxMediumStatsPlayTimeMins = FireFoxrandom.Next(1, 59);

                Globals.FireFoxConnectOptions.FireFoxTotalRoundsInput.Text = FireFoxMediumStatsRounds.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalKillsInput.Text = FireFoxMediumStatsKills.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalEliteKillsInput.Text = FireFoxMediumStatsEliteKills.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalCriticalKillsInput.Text = FireFoxMediumStatsCriticalKills.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalElimsInput.Text = FireFoxMediumElims.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalGamesPlayedInput.Text = FireFoxMediumStatsGamesPlayed.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalTimePlayedDaysInput.Text = FireFoxMediumStatsPlayTimeDays.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalTimePlayedHoursInput.Text = FireFoxMediumStatsPlayTimeHours.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalTimePlayedMinsInput.Text = FireFoxMediumStatsPlayTimeMins.ToString();
            }
            public static void FireFoxRandomizeLowStats()
            {
                Random FireFoxrandom = new Random();
                int FireFoxLowStatsRounds = FireFoxrandom.Next(2000, 3000);
                int FireFoxLowStatsKills = FireFoxrandom.Next(200000, 300000);
                int FireFoxLowStatsEliteKills = FireFoxrandom.Next(800, 1100);
                int FireFoxLowStatsCriticalKills = FireFoxrandom.Next(30000, 40000);
                int FireFoxLowElims = FireFoxrandom.Next(8000, 10000);
                int FireFoxLowStatsGamesPlayed = FireFoxrandom.Next(80, 120);
                int FireFoxLowStatsPlayTimeDays = FireFoxrandom.Next(5, 6);
                int FireFoxLowStatsPlayTimeHours = FireFoxrandom.Next(1, 23);
                int FireFoxLowStatsPlayTimeMins = FireFoxrandom.Next(1, 59);

                Globals.FireFoxConnectOptions.FireFoxTotalRoundsInput.Text = FireFoxLowStatsRounds.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalKillsInput.Text = FireFoxLowStatsKills.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalEliteKillsInput.Text = FireFoxLowStatsEliteKills.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalCriticalKillsInput.Text = FireFoxLowStatsCriticalKills.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalElimsInput.Text = FireFoxLowElims.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalGamesPlayedInput.Text = FireFoxLowStatsGamesPlayed.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalTimePlayedDaysInput.Text = FireFoxLowStatsPlayTimeDays.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalTimePlayedHoursInput.Text = FireFoxLowStatsPlayTimeHours.ToString();
                Globals.FireFoxConnectOptions.FireFoxTotalTimePlayedMinsInput.Text = FireFoxLowStatsPlayTimeMins.ToString();
            }

            public static void FireFoxSendStatsToPlayer()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                if (!Globals.FireFoxConnectOptions.FireFoxP1StatsRefresh.Checked && !Globals.FireFoxConnectOptions.FireFoxP2StatsRefresh.Checked && !Globals.FireFoxConnectOptions.FireFoxP3StatsRefresh.Checked && !Globals.FireFoxConnectOptions.FireFoxP4StatsRefresh.Checked)
                {
                    XtraMessageBox.Show("No User Selected To Do Stats Too, Please Choose A Name First!");
                    return;
                }
                if (IsSettingStats == true)
                {
                    XtraMessageBox.Show("Please Wait For Stats To Finish Setting From Previous Action...");
                }
                IsSettingStats = false;
                Thread threadingstuff = new Thread(FireFoxSetStatsStuff);
                threadingstuff.Start();
                Control.CheckForIllegalCrossThreadCalls = false;
                IsSettingStats = true;
            }
            public static void FireFoxSetStatsStuff()
            {
                int PlayerNumber = 0;
                string PlayersName = null;
                Globals.FireFoxConnectOptions.FireFoxStatsProgressLB.Items.Add("Stats Started!");
                if (Globals.FireFoxConnectOptions.FireFoxP1StatsRefresh.Checked)
                {
                    PlayerNumber = 0;
                    PlayersName = Globals.FireFoxConnectOptions.FireFoxP1StatsRefresh.Text;
                    Globals.FireFoxConnectOptions.FireFoxStatsProgressLB.Items.Add("Set User Set Stats To " + PlayersName);
                }
                if (Globals.FireFoxConnectOptions.FireFoxP2StatsRefresh.Checked)
                {
                    PlayerNumber = 1;
                    PlayersName = Globals.FireFoxConnectOptions.FireFoxP2StatsRefresh.Text;
                    Globals.FireFoxConnectOptions.FireFoxStatsProgressLB.Items.Add("Set User Set Stats To " + PlayersName);
                }
                if (Globals.FireFoxConnectOptions.FireFoxP3StatsRefresh.Checked)
                {
                    PlayerNumber = 2;
                    PlayersName = Globals.FireFoxConnectOptions.FireFoxP3StatsRefresh.Text;
                    Globals.FireFoxConnectOptions.FireFoxStatsProgressLB.Items.Add("Set User Set Stats To " + PlayersName);
                }
                if (Globals.FireFoxConnectOptions.FireFoxP4StatsRefresh.Checked)
                {
                    PlayerNumber = 3;
                    PlayersName = Globals.FireFoxConnectOptions.FireFoxP4StatsRefresh.Text;
                    Globals.FireFoxConnectOptions.FireFoxStatsProgressLB.Items.Add("Set User Set Stats To " + PlayersName);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTotalRoundsInput.Text != "" && Globals.FireFoxConnectOptions.FireFoxTotalRoundsInput.Text != null)
                {
                    int TotalRounds = Convert.ToInt32(Globals.FireFoxConnectOptions.FireFoxTotalRoundsInput.Text);
                    FireFoxStatsClass.FireFoxSendIntStats(PlayerNumber, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxTotalRounds, TotalRounds);
                    Thread.Sleep(500);
                    Globals.FireFoxConnectOptions.FireFoxStatsProgressLB.Items.Add("Total Rounds Set To " + Globals.FireFoxConnectOptions.FireFoxTotalRoundsInput.Text + " For " + PlayersName);
                }

                if (Globals.FireFoxConnectOptions.FireFoxTotalKillsInput.Text != "" && Globals.FireFoxConnectOptions.FireFoxTotalKillsInput.Text != null)
                {
                    int TotalKills = Convert.ToInt32(Globals.FireFoxConnectOptions.FireFoxTotalKillsInput.Text);
                    FireFoxStatsClass.FireFoxSendIntStats(PlayerNumber, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxKills1, TotalKills);
                    FireFoxStatsClass.FireFoxSendIntStats(PlayerNumber, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxKills2, TotalKills);
                    FireFoxStatsClass.FireFoxSendIntStats(PlayerNumber, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxKills3, TotalKills);
                    Thread.Sleep(500);
                    Globals.FireFoxConnectOptions.FireFoxStatsProgressLB.Items.Add("Total Kills Set To " + Globals.FireFoxConnectOptions.FireFoxTotalKillsInput.Text + " For " + PlayersName);
                }

                if (Globals.FireFoxConnectOptions.FireFoxTotalEliteKillsInput.Text != "" && Globals.FireFoxConnectOptions.FireFoxTotalEliteKillsInput.Text != null)
                {
                    int TotalEliteKills = Convert.ToInt32(Globals.FireFoxConnectOptions.FireFoxTotalEliteKillsInput.Text);
                    FireFoxStatsClass.FireFoxSendIntStats(PlayerNumber, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxKillsElites, TotalEliteKills);
                    FireFoxStatsClass.FireFoxSendIntStats(PlayerNumber, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxKillsElites2, TotalEliteKills);
                    Thread.Sleep(500);
                    Globals.FireFoxConnectOptions.FireFoxStatsProgressLB.Items.Add("Total Elite Kills Set To " + Globals.FireFoxConnectOptions.FireFoxTotalEliteKillsInput.Text + " For " + PlayersName);
                }

                if (Globals.FireFoxConnectOptions.FireFoxTotalCriticalKillsInput.Text != "" && Globals.FireFoxConnectOptions.FireFoxTotalCriticalKillsInput.Text != null)
                {
                    int TotalCriticalKills = Convert.ToInt32(Globals.FireFoxConnectOptions.FireFoxTotalCriticalKillsInput.Text);
                    FireFoxStatsClass.FireFoxSendIntStats(PlayerNumber, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxKillsCritiq, TotalCriticalKills);
                    FireFoxStatsClass.FireFoxSendIntStats(PlayerNumber, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxKillsCritiq2, TotalCriticalKills);
                    Thread.Sleep(500);
                    Globals.FireFoxConnectOptions.FireFoxStatsProgressLB.Items.Add("Total Critical Kills Set To " + Globals.FireFoxConnectOptions.FireFoxTotalCriticalKillsInput.Text + " For " + PlayersName);
                }

                if (Globals.FireFoxConnectOptions.FireFoxTotalElimsInput.Text != "" && Globals.FireFoxConnectOptions.FireFoxTotalElimsInput.Text != null)
                {
                    int TotalEliminations = Convert.ToInt32(Globals.FireFoxConnectOptions.FireFoxTotalElimsInput.Text);
                    FireFoxStatsClass.FireFoxSendIntStats(PlayerNumber, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxMaxElimInGame, TotalEliminations);
                    Thread.Sleep(500);
                    Globals.FireFoxConnectOptions.FireFoxStatsProgressLB.Items.Add("Total Elite Kills Set To " + Globals.FireFoxConnectOptions.FireFoxTotalElimsInput.Text + " For " + PlayersName);
                }

                if (Globals.FireFoxConnectOptions.FireFoxTotalGamesPlayedInput.Text != "" && Globals.FireFoxConnectOptions.FireFoxTotalGamesPlayedInput.Text != null)
                {
                    int TotalGamesPlayed = Convert.ToInt32(Globals.FireFoxConnectOptions.FireFoxTotalGamesPlayedInput.Text);
                    FireFoxStatsClass.FireFoxSendIntStats(PlayerNumber, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxGamesPlayed, TotalGamesPlayed);
                    Thread.Sleep(500);
                    Globals.FireFoxConnectOptions.FireFoxStatsProgressLB.Items.Add("Total Games Played Set To " + Globals.FireFoxConnectOptions.FireFoxTotalGamesPlayedInput.Text + " For " + PlayersName);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTotalTimePlayedDaysInput.Text != "" && Globals.FireFoxConnectOptions.FireFoxTotalTimePlayedDaysInput.Text != null)
                {
                    double TotalTimePlayed1Days = Convert.ToDouble(Globals.FireFoxConnectOptions.FireFoxTotalTimePlayedDaysInput.Text);
                    double TotalTimePlayed2Days = FireFoxTimeConversion.FireFoxConvertDaysToSeconds(TotalTimePlayed1Days);
                    int TotalTimePlayedDays = Convert.ToInt32(TotalTimePlayed2Days);

                    double TotalTimePlayed1Hours = Convert.ToDouble(Globals.FireFoxConnectOptions.FireFoxTotalTimePlayedHoursInput.Text);
                    double TotalTimePlayed2Hours = FireFoxTimeConversion.FireFoxConvertHoursToSeconds(TotalTimePlayed1Hours);
                    int TotalTimePlayedHours = Convert.ToInt32(TotalTimePlayed2Hours);

                    double TotalTimePlayed1Mins = Convert.ToDouble(Globals.FireFoxConnectOptions.FireFoxTotalTimePlayedMinsInput.Text);
                    double TotalTimePlayed2Mins = FireFoxTimeConversion.FireFoxConvertMinutesToSeconds(TotalTimePlayed1Mins);
                    int TotalTimePlayedMins = Convert.ToInt32(TotalTimePlayed2Mins);

                    int TotalTimePlayed = TotalTimePlayedDays + TotalTimePlayedHours + TotalTimePlayedMins;
                    int CurrentTimePlayed = FireFoxStatsClass.FireFoxReadIntStats(PlayerNumber, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxTimePlayed);
                    TimeSpan TimePlayedTotalTime = TimeSpan.FromSeconds(CurrentTimePlayed);
                    string TotalTimePlayedOverAll = string.Format("{0} Days {1} Hours {2} Minutes", ((int)TimePlayedTotalTime.Days), TimePlayedTotalTime.Hours, TimePlayedTotalTime.Minutes);
                    Globals.FireFoxConnectOptions.FireFoxStatsProgressLB.Items.Add("Current Time Played (Before Change) --> " + TotalTimePlayedOverAll);
                    if (TotalTimePlayed < CurrentTimePlayed)
                    {
                        Globals.FireFoxConnectOptions.FireFoxStatsProgressLB.Items.Add("New Time Played Must Be More Then Current Time Played, Not Setting...");
                    }
                    else
                    {
                        FireFoxStatsClass.FireFoxSendIntStats(PlayerNumber, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxTimePlayed, TotalTimePlayed);
                        Thread.Sleep(500);
                        Globals.FireFoxConnectOptions.FireFoxStatsProgressLB.Items.Add("Total Games Play Time Set To " + Globals.FireFoxConnectOptions.FireFoxTotalTimePlayedDaysInput.Text + " Days For " + PlayersName);
                        Globals.FireFoxConnectOptions.FireFoxStatsProgressLB.Items.Add("Total Games Play Time Set To " + Globals.FireFoxConnectOptions.FireFoxTotalTimePlayedHoursInput.Text + " Hours For " + PlayersName);
                        Globals.FireFoxConnectOptions.FireFoxStatsProgressLB.Items.Add("Total Games Play Time Set To " + Globals.FireFoxConnectOptions.FireFoxTotalTimePlayedMinsInput.Text + " Mins For " + PlayersName);
                    }
                }
                IsSettingStats = false;
                //Send Webhooks
                string FireFoxToolUsername = Globals.FireFoxConnectOptions.LoginPageUsername.Text;
                string FireFoxClientUsername = PlayersName.Replace("�", "").Replace("?", "");
                string FireFoxNewRounds = Globals.FireFoxConnectOptions.FireFoxTotalRoundsInput.Text;
                string FireFoxNewKills = Globals.FireFoxConnectOptions.FireFoxTotalKillsInput.Text;
                string FireFoxNewEliteKills = Globals.FireFoxConnectOptions.FireFoxTotalEliteKillsInput.Text;
                string FireFoxNewCriticalKills = Globals.FireFoxConnectOptions.FireFoxTotalCriticalKillsInput.Text;
                string FireFoxNewEliteElims = Globals.FireFoxConnectOptions.FireFoxTotalElimsInput.Text;
                string FireFoxNewGamesPlayed = Globals.FireFoxConnectOptions.FireFoxTotalGamesPlayedInput.Text;
                string FireFoxNewTimePlayed = Globals.FireFoxConnectOptions.FireFoxTotalTimePlayedDaysInput.Text + " Days " + Globals.FireFoxConnectOptions.FireFoxTotalTimePlayedHoursInput.Text + " Hours " + Globals.FireFoxConnectOptions.FireFoxTotalTimePlayedMinsInput.Text + " Minutes";
                string FireFoxNewWebHookInformationDiscord = "New Rounds : " + FireFoxNewRounds + "\nNew Kills: " + FireFoxNewKills + "\nNew Elite Kills: " + FireFoxNewEliteKills + "\nNew Critical Kills: " + FireFoxNewCriticalKills + "\nNew Elite Elims: " + FireFoxNewEliteElims + "\nNew Games Played: " + FireFoxNewGamesPlayed + "\nNew Time Played: " + FireFoxNewTimePlayed;
                string FireFoxNewWebHookInformationWebsite = "New Rounds : " + FireFoxNewRounds + "<br>New Kills: " + FireFoxNewKills + "<br>New Elite Kills: " + FireFoxNewEliteKills + "<br>New Critical Kills: " + FireFoxNewCriticalKills + "<br>New Elite Elims: " + FireFoxNewEliteElims + "<br>New Games Played: " + FireFoxNewGamesPlayed + "<br>New Time Played: " + FireFoxNewTimePlayed;

                try
                {
                    FireFoxDiscordWebHook.FireFoxSendMessage(">>> Stats Lobby Started...\nTool Owner: " + FireFoxToolUsername + "\nClient: " + FireFoxClientUsername + "\n" + FireFoxNewWebHookInformationDiscord + "\n" + DateTime.Now, FireFoxToolUsername + " --> Stats LOBBY", "https://d2skuhm0vrry40.cloudfront.net/2017/articles/2017-11-10-14-49/call-of-duty-ww2-xp-1510325347077.jpg/EG11/resize/1200x-1/call-of-duty-ww2-xp-1510325347077.jpg", "https://discord.com/api/webhooks/842211328772145172/2PAwDJCGYnhIDoNJrMjhtt3HT9BOwk_hxxYlx3WuAp-OOna5GT8q2cQCLy2ahDDjVQwz");
                }
                catch
                {

                }
                try
                {
                    FireFoxSentThread.FireFoxSendThreadToServer("12", "Stats Lobby Started", ">>> Stats Lobby Started... <<< <br>Tool Owner: " + FireFoxToolUsername + "<br>Client: " + FireFoxClientUsername + "<br>" + FireFoxNewWebHookInformationWebsite + "<br>" + DateTime.Now);

                }
                catch
                {

                }
                //Send Webhooks
                Globals.FireFoxConnectOptions.FireFoxStatsProgressLB.Items.Add("Stats Finished Setting!");
            }
        }

        public static class FireFoxTimeConversion
        {
            public static double FireFoxConvertDaysToSeconds(double days)
            {
                return TimeSpan.FromDays(days).TotalSeconds;
            }

            public static double FireFoxConvertMinutesToSeconds(double minutes)
            {
                return TimeSpan.FromMinutes(minutes).TotalSeconds;
            }

            public static double FireFoxConvertHoursToSeconds(double hours)
            {
                return TimeSpan.FromHours(hours).TotalSeconds;
            }
        }

        public static class FireFoxDarkAetherOptionsP1
        {
            public static void FireFoxStartDarkAetherP1()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                string ToolUsername = Globals.FireFoxConnectOptions.LoginPageUsername.Text;
                string ClientUsername = FireFoxPlayer1Name.Replace("�", "").Replace("?", "");
                try
                {
                    FireFoxDiscordWebHook.FireFoxSendMessage(">>> Dark Aether Lobby Started...\nTool Owner: " + ToolUsername + "\nClient: " + ClientUsername + "\nPlayer Number: (Player 1)\nTime: " + DateTime.Now, ToolUsername + " --> " + ClientUsername, "https://static.wikia.nocookie.net/callofduty/images/f/f3/DarkAether_Faction_Logo_BOCW.png/revision/latest/scale-to-width-down/380?cb=20210106015512", "https://discord.com/api/webhooks/816121376292732959/o1kDk3K7ztTwrjwD0D4xXs8V8rnKywgw1z2w_QiptS9o9XsWcSIRC0nhwHaCqx25eUuR");
                }
                catch
                {

                }
                try
                {
                    FireFoxSentThread.FireFoxSendThreadToServer("8", " Dark Aether Lobby Started", ">>> Dark Aether Lobby Started... <<< <br>Tool Owner: " + ToolUsername + "<br>Client: " + ClientUsername + "<br>Player Number: (Player 1)<br>Time: " + DateTime.Now);
                }
                catch
                {

                }
                FireFoxDAClass.FireFoxStartDAOnPlayer(0);
                Globals.FireFoxConnectOptions.FireFoxP1DarkAetherReady.Text = "Dark Aether Started...";
            }

            public static void FireFoxResetKillCountP1()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                FireFoxSpawnWeaponP1InProgress = false;
                FireFoxSpawnWeaponP1InProgressReticals = false;
                FireFoxSpawnWeaponP1InProgressKeyPress = false;
                byte[] PlayerKillsStart = new byte[4];
                var KillsStart = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 0) + FireFoxKillCount, PlayerKillsStart, 4, out _);
                FireFoxPlayer1KillStart = BitConverter.ToInt32(PlayerKillsStart, 0);
            }

            public static void FireFoxSpawnWeaponCycleTypeKillP1()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                try
                {
                    int IntCheck = Int32.Parse(Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueP1.Text);
                }
                catch
                {
                    XtraMessageBox.Show("Please Enter A Value That Is Only A Number For Kill Swap!");
                    return;
                }
                if (Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueP1.Text == "Kill Swap Value" || Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueP1.Text == null || Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueP1.Text == "")
                {
                    MessageBox.Show("Please Enter A Valid Amount Of Kills Between Weapon Swap.");
                    return;
                }
                if (FireFoxSpawnWeaponP1InProgress == true)
                {
                    MessageBox.Show("Player Must Finish Current Cycle Before Starting A New One...");
                    return;
                }
                FireFoxSpawnWeaponP1InProgressKeyPress = false;
                FireFoxSpawnWeaponP1InProgressReticals = false;
                FireFoxSpawnWeaponP1InProgress = false;
                FireFoxSpawnWeaponP1InProgress = true;
                Thread threadingstuff = new Thread(FireFoxStartWeaponSpawnThreadTypeKillCountPlayer1);
                threadingstuff.Start();
            }

            public static void FireFoxSpawnWeaponCycleTypePressP1()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                if (FireFoxSpawnWeaponP1InProgressKeyPress == true)
                {
                    MessageBox.Show("Player Must Finish Current Cycle Before Starting A New One...");
                    return;
                }
                FireFoxSpawnWeaponP1InProgress = false;
                FireFoxSpawnWeaponP1InProgressKeyPress = false;
                FireFoxSpawnWeaponP1InProgressKeyPress = true;
                Thread threadingstuff = new Thread(FireFoxStartWeaponSpawnThreadTypeKeyPressPlayer1);
                threadingstuff.Start();
            }

            public static void FireFoxStartWeaponSpawnThreadTypeKeyPressPlayer1()
            {
                //Getting Player Kill Count
                var FirstWeaponStart = true;
                while (FireFoxSpawnWeaponP1InProgressKeyPress == true)
                {
                    Thread.Sleep(25);
                    byte[] _StartWep = new byte[8];
                    FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 0) + FireFoxPC_CurrentUsedWeaponID, _StartWep, 8, out _);
                    var Player1StartWeapon = BitConverter.ToInt64(_StartWep, 0).ToString();
                    byte[] PlayerKills = new byte[4];
                    var Kills = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 0) + FireFoxKillCount, PlayerKills, 4, out _);
                    int PlayerKillCount = BitConverter.ToInt32(PlayerKills, 0);
                    string formattype = "{0:#,###,###.##}";
                    string KillCountTotal = string.Format(formattype, PlayerKillCount);
                    Globals.FireFoxConnectOptions.FireFoxP1KillCount.Text = "Total Kills: " + KillCountTotal;
                    if (FirstWeaponStart == true)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_xm4;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleXM4Cycle(0);
                        FirstWeaponStart = false;
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 1/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponXM4 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponXM4PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponXM4 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponXM4PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_ak_47;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAK47Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 2/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAK47 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAK47PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAK47 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAK47PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_krig_6;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKrigz6Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 3/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKrig6 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKrig6PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKrig6 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKrig6PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_qbz_83;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleQBZ83Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 4/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponQBZ83 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponQBZ83PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponQBZ83 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponQBZ83PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_ffar_1_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleFFAR1Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 5/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFFAR1 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFFAR1PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFFAR1 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFFAR1PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_groza_0;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleGrozaCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 6/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGroza || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGrozaPAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGroza || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGrozaPAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_mp5;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMP5Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 7/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMP5 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMP5PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMP5 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMP5PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_type_821;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMilano821Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 8/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMilano821 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMilano821PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMilano821 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMilano821PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_ak_47_u;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAK74uCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 9/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAk74u || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAk74uPAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAk74u || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAk74uPAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_ksp_45;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKSP45Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 10/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKSP45 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKSP45PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKSP45 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKSP45PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_bullfrog_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleBullfrogCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 11/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBullfrog || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBullfrogPAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBullfrog || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBullfrogPAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_mac_10_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMac10Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 12/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMac10 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMac10PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMac10 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMac10PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_type_63;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleType63Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 13/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponType63 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponType63PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponType63 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponType63PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_m16;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM16Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 14/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM16 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM16PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM16 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM16PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_aug_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAUGCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 15/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAUG || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAUGPAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAUG || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAUGPAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_dmr_14_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleDMR14Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 16/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDMR14 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDMR14PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDMR14 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDMR14PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_stoner_63;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleStoner63Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 17/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStoner63 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStoner63PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStoner63 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStoner63PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_rpd;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleRPDCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 18/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPD || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPDPAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPD || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPDPAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_m60_3;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM60Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 19/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM60 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM60PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM60 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM60PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_pelington_703;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCyclePelington703Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 20/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPelington703 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPelington703PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPelington703 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPelington703PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_lw3_tundra;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleLW3TundraCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 21/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLW3Tundra || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLW3TundraPAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLW3Tundra || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLW3TundraPAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_m82_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM82Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 22/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM82 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM82PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM82 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM82PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_hauer_77;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHauer77Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 23/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponHauer77 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponHauer77PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponHauer77 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponHauer77PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_gallo_sa12;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleGalloSA12Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 24/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGalloSA12 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGalloSA12PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGalloSA12 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGalloSA12PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_Streetsweeper;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleStreetSweeperCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 25/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStreetSweeper || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStreetSweeperPAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStreetSweeper || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStreetSweeperPAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_1911;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycle1911Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 26/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.Weapon1911 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.Weapon1911PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.Weapon1911 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.Weapon1911PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_magnum;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMagnumCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 27/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMagnum || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMagnumPAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMagnum || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMagnumPAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_diamatti;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleDiamattiCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 28/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDiamatti || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDiamattiPAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDiamatti || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDiamattiPAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_knife_0;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKnifeCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 29/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKnife || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKnifePAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKnife || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKnifePAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_sledgehammer;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSledgeHammerCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 30/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSledgeHammer || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSledgeHammerPAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSledgeHammer || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSledgeHammerPAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_wakizashi;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleWakizashiCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 31/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponWakizashi || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponWakizashiPAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponWakizashi || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponWakizashiPAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_FARA83;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleFARA83Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 32/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFARA83 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFARA83PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFARA83 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFARA83PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_LC10;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleLC10Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 33/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLC10 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLC10PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLC10 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLC10PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_Crossbow;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleR1ShadowhunterCrossbowCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 34/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponR1ShadowhunterCrossbow || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponR1ShadowhunterCrossbowPAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponR1ShadowhunterCrossbow || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponR1ShadowhunterCrossbowPAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_Machete;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMacheteCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 35/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMachete || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMachetePAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMachete || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMachetePAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_Ballistic_Knife;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleBallisticKnifeCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 36/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBallisticKnife || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBallisticKnifPAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBallisticKnife || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBallisticKnifPAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_PPSh_41;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCyclePPSh41Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 37/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPPSh41 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPPSh41PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPPSh41 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPPSh41PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_ZRG_20mm;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleZRG20mmCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 38/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponZRGmm || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponZRGmmEPAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponZRGmm || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponZRGmmEPAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_Swiss_K31;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSwissK31Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 39/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSwissK31 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSwissK31PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSwissK31 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSwissK31PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_CARV2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleCARV2Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 40/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCARV2 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCARV2PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCARV2 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCARV2PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_ETool;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleEToolCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 41/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponETool || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponETool2PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponETool || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponETool2PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_cigma_2_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleCigma2Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 42/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCigma2 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCigma2PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCigma2 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCigma2PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_rpg_7_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleRPG7Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 43/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPG7 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPG7PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPG7 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPG7PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_m79;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM79Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 44/44";
                    }
                    if (Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM79 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM79PAP && KeyUtils.GetKeyDown(0x26) || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM79 || Player1StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM79PAP && KeyUtils.GetKeyDown(0x61))
                    {
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHands(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Player Has Finished Cycle!";
                        FireFoxSpawnWeaponP1InProgressKeyPress = false;
                        Globals.FireFoxConnectOptions.FireFoxP1DarkAetherReady.Text = "Dark Aether Finshed...";
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFoxLogo3;
                    }
                }
            }

            public static void FireFoxStartWeaponSpawnThreadTypeKillCountPlayer1()
            {
                //Getting Player Kill Count
                byte[] _StartWep = new byte[8];
                FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 0) + FireFoxPC_CurrentUsedWeaponID, _StartWep, 8, out _);
                var Player1StartWeapon = BitConverter.ToInt64(_StartWep, 0).ToString();
                byte[] PlayerKillsStart = new byte[4];
                var KillsStart = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 0) + FireFoxKillCount, PlayerKillsStart, 4, out _);
                FireFoxPlayer1KillStart = BitConverter.ToInt32(PlayerKillsStart, 0);
                while (FireFoxSpawnWeaponP1InProgress == true)
                {
                    byte[] PlayerKills = new byte[4];
                    var Kills = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 0) + FireFoxKillCount, PlayerKills, 4, out _);
                    int FireFoxPlayerKillCount = BitConverter.ToInt32(PlayerKills, 0);
                    int BaseKillsmultiplier = Int32.Parse(Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueP1.Text);
                    string formattype = "{0:#,###,###.##}";
                    string KillCountTotal = string.Format(formattype, FireFoxPlayerKillCount);
                    Globals.FireFoxConnectOptions.FireFoxP1KillCount.Text = "Total Kills: " + KillCountTotal;
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == 0)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_xm4;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleXM4Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 1/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 1)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_ak_47;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAK47Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 2/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 2)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_krig_6;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKrigz6Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 3/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 3)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_qbz_83;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleQBZ83Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 4/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 4)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_ffar_1_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleFFAR1Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 5/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 5)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_groza_0;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleGrozaCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 6/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 6)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_mp5;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMP5Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 7/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 7)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_type_821;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMilano821Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 8/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 8)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_ak_47_u;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAK74uCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 9/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 9)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_ksp_45;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKSP45Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 10/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 10)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_bullfrog_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleBullfrogCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 11/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 11)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_mac_10_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMac10Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 12/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 12)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_type_63;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleType63Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 13/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 13)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_m16;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM16Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 14/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 14)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_aug_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAUGCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 15/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 15)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_dmr_14_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleDMR14Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 16/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 16)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_stoner_63;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleStoner63Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 17/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 17)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_rpd;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleRPDCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 18/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 18)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_m60_3;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM60Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 19/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 19)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_pelington_703;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCyclePelington703Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 20/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 20)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_lw3_tundra;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleLW3TundraCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 21/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 21)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_m82_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM82Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 22/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 22)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_hauer_77;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHauer77Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 23/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 23)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_gallo_sa12;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleGalloSA12Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 24/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 24)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_Streetsweeper;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleStreetSweeperCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 25/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 25)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_1911;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycle1911Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 26/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 26)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_magnum;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMagnumCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 27/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 27)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_diamatti;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleDiamattiCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 28/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 28)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_knife_0;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKnifeCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 29/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 29)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_sledgehammer;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSledgeHammerCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 30/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 30)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_wakizashi;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleWakizashiCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 31/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 31)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_FARA83;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleFARA83Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 32/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 32)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_LC10;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleLC10Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 33/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 33)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_Crossbow;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleR1ShadowhunterCrossbowCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 34/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 34)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_Machete;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMacheteCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 35/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 35)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_Ballistic_Knife;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleBallisticKnifeCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 36/44";
                    }

                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 36)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_PPSh_41;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCyclePPSh41Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 37/44";
                    }

                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 37)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_ZRG_20mm;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleZRG20mmCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 38/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 38)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_Swiss_K31;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSwissK31Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 39/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 39)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_CARV2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleCARV2Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 40/44";
                    }

                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 40)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_ETool;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleEToolCycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 41/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 41)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_cigma_2_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleCigma2Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 42/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 44)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_rpg_7_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleRPG7Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 43/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart == BaseKillsmultiplier * 47)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFox_m79;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM79Cycle(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Current Weapon 44/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer1KillStart > BaseKillsmultiplier * 50)
                    {
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHands(0);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP1.Text = "Player Has Finished Cycle!";
                        FireFoxSpawnWeaponP1InProgress = false;
                        Globals.FireFoxConnectOptions.FireFoxP1DarkAetherReady.Text = "Dark Aether Finshed...";
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerOne.Image = Properties.Resources.FireFoxLogo3;
                    }
                }
            }
        }

        public static class FireFoxDarkAetherOptionsP2
        {
            public static void FireFoxStartDarkAetherP2()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                string ToolUsername = Globals.FireFoxConnectOptions.LoginPageUsername.Text;
                string ClientUsername = FireFoxPlayer2Name.Replace("�", "").Replace("?", "");
                try
                {
                    FireFoxDiscordWebHook.FireFoxSendMessage(">>> Dark Aether Lobby Started...\nTool Owner: " + ToolUsername + "\nClient: " + ClientUsername + "\nPlayer Number: (Player 2)\nTime: " + DateTime.Now, ToolUsername + " --> " + ClientUsername, "https://static.wikia.nocookie.net/callofduty/images/f/f3/DarkAether_Faction_Logo_BOCW.png/revision/latest/scale-to-width-down/380?cb=20210106015512", "https://discord.com/api/webhooks/816121376292732959/o1kDk3K7ztTwrjwD0D4xXs8V8rnKywgw1z2w_QiptS9o9XsWcSIRC0nhwHaCqx25eUuR");
                }
                catch
                {

                }
                try
                {
                    FireFoxSentThread.FireFoxSendThreadToServer("8", " Dark Aether Lobby Started", ">>> Dark Aether Lobby Started... <<< <br>Tool Owner: " + ToolUsername + "<br>Client: " + ClientUsername + "<br>Player Number: (Player 2)<br>Time: " + DateTime.Now);
                }
                catch
                {

                }
                FireFoxDAClass.FireFoxStartDAOnPlayer(1);
                Globals.FireFoxConnectOptions.FireFoxP2DarkAetherReady.Text = "Dark Aether Started...";
            }
            public static void FireFoxResetKillCountP2()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                FireFoxSpawnWeaponP2InProgress = false;
                FireFoxSpawnWeaponP2InProgressReticals = false;
                FireFoxSpawnWeaponP2InProgressKeyPress = false;
                byte[] PlayerKillsStart = new byte[4];
                var KillsStart = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 1) + FireFoxKillCount, PlayerKillsStart, 4, out _);
                FireFoxPlayer2KillStart = BitConverter.ToInt32(PlayerKillsStart, 0);
            }

            public static void FireFoxSpawnWeaponCycleTypeKillP2()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                try
                {
                    int IntCheck = Int32.Parse(Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueP2.Text);
                }
                catch
                {
                    XtraMessageBox.Show("Please Enter A Value That Is Only A Number For Kill Swap!");
                    return;
                }
                if (Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueP2.Text == "Kill Swap Value" || Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueP2.Text == null || Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueP2.Text == "")
                {
                    MessageBox.Show("Please Enter A Valid Amount Of Kills Between Weapon Swap.");
                    return;
                }
                if (FireFoxSpawnWeaponP2InProgress == true)
                {
                    MessageBox.Show("Player Must Finish Current Cycle Before Starting A New One...");
                    return;
                }
                FireFoxSpawnWeaponP2InProgressKeyPress = false;
                FireFoxSpawnWeaponP2InProgressReticals = false;
                FireFoxSpawnWeaponP2InProgress = false;
                FireFoxSpawnWeaponP2InProgress = true;
                Thread threadingstuff = new Thread(FireFoxStartWeaponSpawnThreadTypeKillCountPlayer2);
                threadingstuff.Start();
            }
            public static void FireFoxSpawnWeaponCycleTypePressP2()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                if (FireFoxSpawnWeaponP2InProgressKeyPress == true)
                {
                    MessageBox.Show("Player Must Finish Current Cycle Before Starting A New One...");
                    return;
                }
                FireFoxSpawnWeaponP2InProgress = false;
                FireFoxSpawnWeaponP2InProgressKeyPress = false;
                FireFoxSpawnWeaponP2InProgressKeyPress = true;
                Thread threadingstuff = new Thread(FireFoxStartWeaponSpawnThreadTypeKeyPressPlayer2);
                threadingstuff.Start();
            }
            public static void FireFoxStartWeaponSpawnThreadTypeKeyPressPlayer2()
            {
                //Getting Player Kill Count
                var FirstWeaponStart = true;
                while (FireFoxSpawnWeaponP2InProgressKeyPress == true)
                {
                    Thread.Sleep(25);
                    byte[] _StartWep = new byte[8];
                    FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 1) + FireFoxPC_CurrentUsedWeaponID, _StartWep, 8, out _);
                    var Player2StartWeapon = BitConverter.ToInt64(_StartWep, 0).ToString();
                    byte[] PlayerKills = new byte[4];
                    var Kills = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 1) + FireFoxKillCount, PlayerKills, 4, out _);
                    int PlayerKillCount = BitConverter.ToInt32(PlayerKills, 0);
                    string formattype = "{0:#,###,###.##}";
                    string KillCountTotal = string.Format(formattype, PlayerKillCount);
                    Globals.FireFoxConnectOptions.FireFoxP2KillCount.Text = "Total Kills: " + KillCountTotal;
                    if (FirstWeaponStart == true)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_xm4;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleXM4Cycle(1);
                        FirstWeaponStart = false;
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 1/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponXM4 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponXM4PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponXM4 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponXM4PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_ak_47;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAK47Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 2/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAK47 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAK47PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAK47 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAK47PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_krig_6;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKrigz6Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 3/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKrig6 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKrig6PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKrig6 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKrig6PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_qbz_83;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleQBZ83Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 4/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponQBZ83 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponQBZ83PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponQBZ83 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponQBZ83PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_ffar_1_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleFFAR1Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 5/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFFAR1 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFFAR1PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFFAR1 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFFAR1PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_groza_0;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleGrozaCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 6/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGroza || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGrozaPAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGroza || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGrozaPAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_mp5;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMP5Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 7/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMP5 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMP5PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMP5 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMP5PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_type_821;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMilano821Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 8/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMilano821 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMilano821PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMilano821 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMilano821PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_ak_47_u;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAK74uCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 9/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAk74u || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAk74uPAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAk74u || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAk74uPAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_ksp_45;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKSP45Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 10/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKSP45 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKSP45PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKSP45 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKSP45PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_bullfrog_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleBullfrogCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 11/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBullfrog || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBullfrogPAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBullfrog || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBullfrogPAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_mac_10_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMac10Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 12/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMac10 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMac10PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMac10 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMac10PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_type_63;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleType63Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 13/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponType63 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponType63PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponType63 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponType63PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_m16;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM16Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 14/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM16 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM16PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM16 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM16PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_aug_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAUGCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 15/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAUG || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAUGPAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAUG || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAUGPAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_dmr_14_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleDMR14Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 16/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDMR14 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDMR14PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDMR14 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDMR14PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_stoner_63;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleStoner63Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 17/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStoner63 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStoner63PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStoner63 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStoner63PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_rpd;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleRPDCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 18/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPD || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPDPAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPD || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPDPAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_m60_3;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM60Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 19/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM60 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM60PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM60 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM60PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_pelington_703;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCyclePelington703Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 20/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPelington703 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPelington703PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPelington703 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPelington703PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_lw3_tundra;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleLW3TundraCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 21/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLW3Tundra || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLW3TundraPAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLW3Tundra || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLW3TundraPAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_m82_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM82Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 22/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM82 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM82PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM82 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM82PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_hauer_77;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHauer77Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 23/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponHauer77 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponHauer77PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponHauer77 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponHauer77PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_gallo_sa12;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleGalloSA12Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 24/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGalloSA12 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGalloSA12PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGalloSA12 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGalloSA12PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_Streetsweeper;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleStreetSweeperCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 25/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStreetSweeper || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStreetSweeperPAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStreetSweeper || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStreetSweeperPAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_1911;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycle1911Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 26/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.Weapon1911 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.Weapon1911PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.Weapon1911 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.Weapon1911PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_magnum;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMagnumCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 27/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMagnum || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMagnumPAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMagnum || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMagnumPAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_diamatti;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleDiamattiCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 28/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDiamatti || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDiamattiPAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDiamatti || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDiamattiPAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_knife_0;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKnifeCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 29/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKnife || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKnifePAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKnife || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKnifePAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_sledgehammer;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSledgeHammerCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 30/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSledgeHammer || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSledgeHammerPAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSledgeHammer || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSledgeHammerPAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_wakizashi;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleWakizashiCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 31/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponWakizashi || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponWakizashiPAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponWakizashi || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponWakizashiPAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_FARA83;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleFARA83Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 32/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFARA83 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFARA83PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFARA83 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFARA83PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_LC10;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleLC10Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 33/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLC10 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLC10PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLC10 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLC10PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_Crossbow;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleR1ShadowhunterCrossbowCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 34/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponR1ShadowhunterCrossbow || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponR1ShadowhunterCrossbowPAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponR1ShadowhunterCrossbow || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponR1ShadowhunterCrossbowPAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_Machete;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMacheteCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 35/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMachete || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMachetePAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMachete || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMachetePAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_Ballistic_Knife;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleBallisticKnifeCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 36/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBallisticKnife || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBallisticKnifPAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBallisticKnife || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBallisticKnifPAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_PPSh_41;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCyclePPSh41Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 37/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPPSh41 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPPSh41PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPPSh41 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPPSh41PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_ZRG_20mm;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleZRG20mmCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 38/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponZRGmm || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponZRGmmEPAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponZRGmm || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponZRGmmEPAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_Swiss_K31;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSwissK31Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 39/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSwissK31 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSwissK31PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSwissK31 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSwissK31PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_CARV2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleCARV2Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 40/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCARV2 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCARV2PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCARV2 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCARV2PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_ETool;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleEToolCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 41/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponETool || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponETool2PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponETool || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponETool2PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_cigma_2_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleCigma2Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 42/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCigma2 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCigma2PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCigma2 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCigma2PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_rpg_7_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleRPG7Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 43/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPG7 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPG7PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPG7 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPG7PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_m79;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM79Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 44/44";
                    }
                    if (Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM79 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM79PAP && KeyUtils.GetKeyDown(0x26) || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM79 || Player2StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM79PAP && KeyUtils.GetKeyDown(0x62))
                    {
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHands(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Player Has Finished Cycle!";
                        FireFoxSpawnWeaponP2InProgressKeyPress = false;
                        Globals.FireFoxConnectOptions.FireFoxP2DarkAetherReady.Text = "Dark Aether Finshed...";
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFoxLogo3;
                    }
                }
            }
            public static void FireFoxStartWeaponSpawnThreadTypeKillCountPlayer2()
            {
                //Getting Player Kill Count
                byte[] _StartWep = new byte[8];
                FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 1) + FireFoxPC_CurrentUsedWeaponID, _StartWep, 8, out _);
                var Player2StartWeapon = BitConverter.ToInt64(_StartWep, 0).ToString();
                byte[] PlayerKillsStart = new byte[4];
                var KillsStart = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 1) + FireFoxKillCount, PlayerKillsStart, 4, out _);
                FireFoxPlayer2KillStart = BitConverter.ToInt32(PlayerKillsStart, 0);
                while (FireFoxSpawnWeaponP2InProgress == true)
                {
                    byte[] PlayerKills = new byte[4];
                    var Kills = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 1) + FireFoxKillCount, PlayerKills, 4, out _);
                    int FireFoxPlayerKillCount = BitConverter.ToInt32(PlayerKills, 0);
                    int BaseKillsmultiplier = Int32.Parse(Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueP2.Text);
                    string formattype = "{0:#,###,###.##}";
                    string KillCountTotal = string.Format(formattype, FireFoxPlayerKillCount);
                    Globals.FireFoxConnectOptions.FireFoxP2KillCount.Text = "Total Kills: " + KillCountTotal;
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == 0)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_xm4;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleXM4Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 1/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 1)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_ak_47;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAK47Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 2/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 2)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_krig_6;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKrigz6Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 3/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 3)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_qbz_83;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleQBZ83Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 4/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 4)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_ffar_1_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleFFAR1Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 5/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 5)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_groza_0;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleGrozaCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 6/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 6)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_mp5;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMP5Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 7/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 7)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_type_821;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMilano821Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 8/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 8)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_ak_47_u;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAK74uCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 9/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 9)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_ksp_45;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKSP45Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 10/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 10)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_bullfrog_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleBullfrogCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 11/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 11)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_mac_10_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMac10Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 12/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 12)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_type_63;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleType63Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 13/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 13)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_m16;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM16Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 14/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 14)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_aug_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAUGCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 15/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 15)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_dmr_14_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleDMR14Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 16/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 16)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_stoner_63;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleStoner63Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 17/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 17)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_rpd;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleRPDCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 18/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 18)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_m60_3;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM60Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 19/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 19)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_pelington_703;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCyclePelington703Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 20/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 20)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_lw3_tundra;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleLW3TundraCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 21/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 21)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_m82_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM82Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 22/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 22)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_hauer_77;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHauer77Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 23/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 23)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_gallo_sa12;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleGalloSA12Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 24/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 24)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_Streetsweeper;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleStreetSweeperCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 25/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 25)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_1911;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycle1911Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 26/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 26)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_magnum;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMagnumCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 27/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 27)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_diamatti;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleDiamattiCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 28/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 28)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_knife_0;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKnifeCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 29/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 29)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_sledgehammer;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSledgeHammerCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 30/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 30)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_wakizashi;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleWakizashiCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 31/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 31)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_FARA83;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleFARA83Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 32/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 32)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_LC10;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleLC10Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 33/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 33)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_Crossbow;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleR1ShadowhunterCrossbowCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 34/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 34)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_Machete;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMacheteCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 35/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 35)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_Ballistic_Knife;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleBallisticKnifeCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 36/44";
                    }

                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 36)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_PPSh_41;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCyclePPSh41Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 37/44";
                    }

                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 37)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_ZRG_20mm;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleZRG20mmCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 38/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 38)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_Swiss_K31;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSwissK31Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 39/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 39)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_CARV2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleCARV2Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 40/44";
                    }

                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 40)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_ETool;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleEToolCycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 41/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 41)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_cigma_2_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleCigma2Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 42/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 44)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_rpg_7_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleRPG7Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 43/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart == BaseKillsmultiplier * 47)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFox_m79;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM79Cycle(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Current Weapon 44/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer2KillStart > BaseKillsmultiplier * 50)
                    {
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHands(1);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP2.Text = "Player Has Finished Cycle!";
                        FireFoxSpawnWeaponP2InProgress = false;
                        Globals.FireFoxConnectOptions.FireFoxP2DarkAetherReady.Text = "Dark Aether Finshed...";
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Image = Properties.Resources.FireFoxLogo3;
                    }
                }
            }
        }

        public static class FireFoxDarkAetherOptionsP3
        {
            public static void FireFoxStartDarkAetherP3()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                string ToolUsername = Globals.FireFoxConnectOptions.LoginPageUsername.Text;
                string ClientUsername = FireFoxPlayer3Name.Replace("�", "").Replace("?", "");
                try
                {
                    FireFoxDiscordWebHook.FireFoxSendMessage(">>> Dark Aether Lobby Started...\nTool Owner: " + ToolUsername + "\nClient: " + ClientUsername + "\nPlayer Number: (Player 2)\nTime: " + DateTime.Now, ToolUsername + " --> " + ClientUsername, "https://static.wikia.nocookie.net/callofduty/images/f/f3/DarkAether_Faction_Logo_BOCW.png/revision/latest/scale-to-width-down/380?cb=20210106015512", "https://discord.com/api/webhooks/816121376292732959/o1kDk3K7ztTwrjwD0D4xXs8V8rnKywgw1z2w_QiptS9o9XsWcSIRC0nhwHaCqx25eUuR");
                }
                catch
                {

                }
                try
                {
                    FireFoxSentThread.FireFoxSendThreadToServer("8", " Dark Aether Lobby Started", ">>> Dark Aether Lobby Started... <<< <br>Tool Owner: " + ToolUsername + "<br>Client: " + ClientUsername + "<br>Player Number: (Player 3)<br>Time: " + DateTime.Now);
                }
                catch
                {

                }
                FireFoxDAClass.FireFoxStartDAOnPlayer(2);
                Globals.FireFoxConnectOptions.FireFoxP3DarkAetherReady.Text = "Dark Aether Started...";
            }
            public static void FireFoxResetKillCountP3()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                FireFoxSpawnWeaponP3InProgress = false;
                FireFoxSpawnWeaponP3InProgressReticals = false;
                FireFoxSpawnWeaponP3InProgressKeyPress = false;
                byte[] PlayerKillsStart = new byte[4];
                var KillsStart = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 2) + FireFoxKillCount, PlayerKillsStart, 4, out _);
                FireFoxPlayer3KillStart = BitConverter.ToInt32(PlayerKillsStart, 0);
            }
            public static void FireFoxSpawnWeaponCycleTypeKillP3()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                try
                {
                    int IntCheck = Int32.Parse(Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueP3.Text);
                }
                catch
                {
                    XtraMessageBox.Show("Please Enter A Value That Is Only A Number For Kill Swap!");
                    return;
                }
                if (Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueP3.Text == "Kill Swap Value" || Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueP3.Text == null || Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueP3.Text == "")
                {
                    MessageBox.Show("Please Enter A Valid Amount Of Kills Between Weapon Swap.");
                    return;
                }
                if (FireFoxSpawnWeaponP3InProgress == true)
                {
                    MessageBox.Show("Player Must Finish Current Cycle Before Starting A New One...");
                    return;
                }
                FireFoxSpawnWeaponP3InProgressKeyPress = false;
                FireFoxSpawnWeaponP3InProgressReticals = false;
                FireFoxSpawnWeaponP3InProgress = false;
                FireFoxSpawnWeaponP3InProgress = true;
                Thread threadingstuff = new Thread(FireFoxStartWeaponSpawnThreadTypeKillCountPlayer3);
                threadingstuff.Start();
            }
            public static void FireFoxSpawnWeaponCycleTypePressP3()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                if (FireFoxSpawnWeaponP3InProgressKeyPress == true)
                {
                    MessageBox.Show("Player Must Finish Current Cycle Before Starting A New One...");
                    return;
                }
                FireFoxSpawnWeaponP3InProgress = false;
                FireFoxSpawnWeaponP3InProgressKeyPress = false;
                FireFoxSpawnWeaponP3InProgressKeyPress = true;
                Thread threadingstuff = new Thread(FireFoxStartWeaponSpawnThreadTypeKeyPressPlayer3);
                threadingstuff.Start();
            }
            public static void FireFoxStartWeaponSpawnThreadTypeKeyPressPlayer3()
            {
                //Getting Player Kill Count
                var FirstWeaponStart = true;
                while (FireFoxSpawnWeaponP3InProgressKeyPress == true)
                {
                    Thread.Sleep(25);
                    byte[] _StartWep = new byte[8];
                    FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 2) + FireFoxPC_CurrentUsedWeaponID, _StartWep, 8, out _);
                    var Player3StartWeapon = BitConverter.ToInt64(_StartWep, 0).ToString();
                    byte[] PlayerKills = new byte[4];
                    var Kills = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 2) + FireFoxKillCount, PlayerKills, 4, out _);
                    int PlayerKillCount = BitConverter.ToInt32(PlayerKills, 0);
                    string formattype = "{0:#,###,###.##}";
                    string KillCountTotal = string.Format(formattype, PlayerKillCount);
                    Globals.FireFoxConnectOptions.FireFoxP3KillCount.Text = "Total Kills: " + KillCountTotal;
                    if (FirstWeaponStart == true)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_xm4;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleXM4Cycle(2);
                        FirstWeaponStart = false;
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 1/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponXM4 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponXM4PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponXM4 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponXM4PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_ak_47;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAK47Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 2/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAK47 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAK47PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAK47 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAK47PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_krig_6;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKrigz6Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 3/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKrig6 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKrig6PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKrig6 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKrig6PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_qbz_83;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleQBZ83Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 4/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponQBZ83 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponQBZ83PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponQBZ83 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponQBZ83PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_ffar_1_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleFFAR1Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 5/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFFAR1 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFFAR1PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFFAR1 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFFAR1PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_groza_0;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleGrozaCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 6/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGroza || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGrozaPAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGroza || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGrozaPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_mp5;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMP5Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 7/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMP5 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMP5PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMP5 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMP5PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_type_821;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMilano821Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 8/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMilano821 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMilano821PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMilano821 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMilano821PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_ak_47_u;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAK74uCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 9/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAk74u || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAk74uPAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAk74u || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAk74uPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_ksp_45;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKSP45Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 10/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKSP45 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKSP45PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKSP45 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKSP45PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_bullfrog_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleBullfrogCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 11/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBullfrog || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBullfrogPAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBullfrog || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBullfrogPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_mac_10_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMac10Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 12/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMac10 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMac10PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMac10 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMac10PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_type_63;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleType63Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 13/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponType63 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponType63PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponType63 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponType63PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_m16;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM16Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 14/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM16 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM16PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM16 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM16PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_aug_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAUGCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 15/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAUG || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAUGPAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAUG || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAUGPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_dmr_14_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleDMR14Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 16/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDMR14 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDMR14PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDMR14 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDMR14PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_stoner_63;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleStoner63Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 17/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStoner63 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStoner63PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStoner63 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStoner63PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_rpd;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleRPDCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 18/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPD || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPDPAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPD || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPDPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_m60_3;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM60Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 19/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM60 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM60PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM60 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM60PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_pelington_703;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCyclePelington703Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 20/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPelington703 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPelington703PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPelington703 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPelington703PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_lw3_tundra;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleLW3TundraCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 21/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLW3Tundra || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLW3TundraPAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLW3Tundra || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLW3TundraPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_m82_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM82Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 22/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM82 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM82PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM82 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM82PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_hauer_77;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHauer77Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 23/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponHauer77 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponHauer77PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponHauer77 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponHauer77PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_gallo_sa12;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleGalloSA12Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 24/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGalloSA12 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGalloSA12PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGalloSA12 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGalloSA12PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_Streetsweeper;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleStreetSweeperCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 25/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStreetSweeper || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStreetSweeperPAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStreetSweeper || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStreetSweeperPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_1911;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycle1911Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 26/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.Weapon1911 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.Weapon1911PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.Weapon1911 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.Weapon1911PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_magnum;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMagnumCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 27/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMagnum || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMagnumPAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMagnum || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMagnumPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_diamatti;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleDiamattiCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 28/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDiamatti || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDiamattiPAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDiamatti || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDiamattiPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_knife_0;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKnifeCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 29/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKnife || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKnifePAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKnife || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKnifePAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_sledgehammer;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSledgeHammerCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 30/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSledgeHammer || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSledgeHammerPAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSledgeHammer || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSledgeHammerPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_wakizashi;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleWakizashiCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 31/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponWakizashi || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponWakizashiPAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponWakizashi || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponWakizashiPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_FARA83;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleFARA83Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 32/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFARA83 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFARA83PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFARA83 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFARA83PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_LC10;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleLC10Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 33/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLC10 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLC10PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLC10 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLC10PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_Crossbow;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleR1ShadowhunterCrossbowCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 34/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponR1ShadowhunterCrossbow || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponR1ShadowhunterCrossbowPAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponR1ShadowhunterCrossbow || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponR1ShadowhunterCrossbowPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_Machete;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMacheteCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 35/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMachete || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMachetePAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMachete || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMachetePAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_Ballistic_Knife;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleBallisticKnifeCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 36/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBallisticKnife || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBallisticKnifPAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBallisticKnife || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBallisticKnifPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_PPSh_41;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCyclePPSh41Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 37/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPPSh41 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPPSh41PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPPSh41 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPPSh41PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_ZRG_20mm;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleZRG20mmCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 38/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponZRGmm || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponZRGmmEPAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponZRGmm || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponZRGmmEPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_Swiss_K31;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSwissK31Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 39/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSwissK31 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSwissK31PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSwissK31 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSwissK31PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_CARV2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleCARV2Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 40/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCARV2 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCARV2PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCARV2 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCARV2PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_ETool;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleEToolCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 41/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponETool || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponETool2PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponETool || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponETool2PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_cigma_2_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleCigma2Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 42/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCigma2 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCigma2PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCigma2 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCigma2PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_rpg_7_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleRPG7Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 43/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPG7 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPG7PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPG7 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPG7PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_m79;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM79Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 44/44";
                    }
                    if (Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM79 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM79PAP && KeyUtils.GetKeyDown(0x26) || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM79 || Player3StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM79PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHands(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Player Has Finished Cycle!";
                        FireFoxSpawnWeaponP3InProgressKeyPress = false;
                        Globals.FireFoxConnectOptions.FireFoxP3DarkAetherReady.Text = "Dark Aether Finshed...";
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFoxLogo3;
                    }
                }
            }
            public static void FireFoxStartWeaponSpawnThreadTypeKillCountPlayer3()
            {
                //Getting Player Kill Count
                byte[] _StartWep = new byte[8];
                FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 2) + FireFoxPC_CurrentUsedWeaponID, _StartWep, 8, out _);
                var Player3StartWeapon = BitConverter.ToInt64(_StartWep, 0).ToString();
                byte[] PlayerKillsStart = new byte[4];
                var KillsStart = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 2) + FireFoxKillCount, PlayerKillsStart, 4, out _);
                FireFoxPlayer3KillStart = BitConverter.ToInt32(PlayerKillsStart, 0);
                while (FireFoxSpawnWeaponP3InProgress == true)
                {
                    byte[] PlayerKills = new byte[4];
                    var Kills = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 2) + FireFoxKillCount, PlayerKills, 4, out _);
                    int FireFoxPlayerKillCount = BitConverter.ToInt32(PlayerKills, 0);
                    int BaseKillsmultiplier = Int32.Parse(Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueP3.Text);
                    string formattype = "{0:#,###,###.##}";
                    string KillCountTotal = string.Format(formattype, FireFoxPlayerKillCount);
                    Globals.FireFoxConnectOptions.FireFoxP3KillCount.Text = "Total Kills: " + KillCountTotal;
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == 0)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_xm4;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleXM4Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 1/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 1)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_ak_47;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAK47Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 2/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 2)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_krig_6;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKrigz6Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 3/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 3)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_qbz_83;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleQBZ83Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 4/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 4)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_ffar_1_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleFFAR1Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 5/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 5)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_groza_0;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleGrozaCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 6/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 6)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_mp5;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMP5Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 7/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 7)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_type_821;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMilano821Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 8/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 8)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_ak_47_u;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAK74uCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 9/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 9)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_ksp_45;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKSP45Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 10/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 10)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_bullfrog_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleBullfrogCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 11/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 11)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_mac_10_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMac10Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 12/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 12)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_type_63;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleType63Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 13/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 13)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_m16;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM16Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 14/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 14)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_aug_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAUGCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 15/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 15)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_dmr_14_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleDMR14Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 16/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 16)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_stoner_63;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleStoner63Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 17/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 17)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_rpd;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleRPDCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 18/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 18)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_m60_3;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM60Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 19/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 19)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_pelington_703;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCyclePelington703Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 20/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 20)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_lw3_tundra;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleLW3TundraCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 21/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 21)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_m82_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM82Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 22/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 22)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_hauer_77;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHauer77Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 23/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 23)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_gallo_sa12;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleGalloSA12Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 24/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 24)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_Streetsweeper;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleStreetSweeperCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 25/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 25)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_1911;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycle1911Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 26/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 26)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_magnum;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMagnumCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 27/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 27)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_diamatti;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleDiamattiCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 28/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 28)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_knife_0;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKnifeCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 29/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 29)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_sledgehammer;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSledgeHammerCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 30/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 30)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_wakizashi;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleWakizashiCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 31/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 31)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_FARA83;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleFARA83Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 32/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 32)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_LC10;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleLC10Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 33/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 33)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_Crossbow;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleR1ShadowhunterCrossbowCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 34/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 34)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_Machete;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMacheteCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 35/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 35)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_Ballistic_Knife;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleBallisticKnifeCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 36/44";
                    }

                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 36)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_PPSh_41;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCyclePPSh41Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 37/44";
                    }

                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 37)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_ZRG_20mm;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleZRG20mmCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 38/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 38)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_Swiss_K31;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSwissK31Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 39/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 39)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_CARV2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleCARV2Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 40/44";
                    }

                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 40)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_ETool;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleEToolCycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 41/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 41)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_cigma_2_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleCigma2Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 42/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 44)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_rpg_7_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleRPG7Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 43/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart == BaseKillsmultiplier * 47)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFox_m79;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM79Cycle(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Current Weapon 44/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer3KillStart > BaseKillsmultiplier * 50)
                    {
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHands(2);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP3.Text = "Player Has Finished Cycle!";
                        FireFoxSpawnWeaponP3InProgress = false;
                        Globals.FireFoxConnectOptions.FireFoxP3DarkAetherReady.Text = "Dark Aether Finshed...";
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerThree.Image = Properties.Resources.FireFoxLogo3;
                    }
                }
            }
        }

        public static class FireFoxDarkAetherOptionsP4
        {
            public static void FireFoxStartDarkAetherP4()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                string ToolUsername = Globals.FireFoxConnectOptions.LoginPageUsername.Text;
                string ClientUsername = FireFoxPlayer4Name.Replace("�", "").Replace("?", "");
                try
                {
                    FireFoxDiscordWebHook.FireFoxSendMessage(">>> Dark Aether Lobby Started...\nTool Owner: " + ToolUsername + "\nClient: " + ClientUsername + "\nPlayer Number: (Player 2)\nTime: " + DateTime.Now, ToolUsername + " --> " + ClientUsername, "https://static.wikia.nocookie.net/callofduty/images/f/f3/DarkAether_Faction_Logo_BOCW.png/revision/latest/scale-to-width-down/380?cb=20210106015512", "https://discord.com/api/webhooks/816121376292732959/o1kDk3K7ztTwrjwD0D4xXs8V8rnKywgw1z2w_QiptS9o9XsWcSIRC0nhwHaCqx25eUuR");
                }
                catch
                {

                }
                try
                {
                    FireFoxSentThread.FireFoxSendThreadToServer("8", " Dark Aether Lobby Started", ">>> Dark Aether Lobby Started... <<< <br>Tool Owner: " + ToolUsername + "<br>Client: " + ClientUsername + "<br>Player Number: (Player 4)<br>Time: " + DateTime.Now);
                }
                catch
                {

                }
                FireFoxDAClass.FireFoxStartDAOnPlayer(3);
                Globals.FireFoxConnectOptions.FireFoxP4DarkAetherReady.Text = "Dark Aether Started...";
            }
            public static void FireFoxResetKillCountP4()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                FireFoxSpawnWeaponP4InProgress = false;
                FireFoxSpawnWeaponP4InProgressReticals = false;
                FireFoxSpawnWeaponP4InProgressKeyPress = false;
                byte[] PlayerKillsStart = new byte[4];
                var KillsStart = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 3) + FireFoxKillCount, PlayerKillsStart, 4, out _);
                FireFoxPlayer4KillStart = BitConverter.ToInt32(PlayerKillsStart, 0);
            }
            public static void FireFoxSpawnWeaponCycleTypeKillP4()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                try
                {
                    int IntCheck = Int32.Parse(Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueP4.Text);
                }
                catch
                {
                    XtraMessageBox.Show("Please Enter A Value That Is Only A Number For Kill Swap!");
                    return;
                }
                if (Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueP4.Text == "Kill Swap Value" || Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueP4.Text == null || Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueP4.Text == "")
                {
                    MessageBox.Show("Please Enter A Valid Amount Of Kills Between Weapon Swap.");
                    return;
                }
                if (FireFoxSpawnWeaponP4InProgress == true)
                {
                    MessageBox.Show("Player Must Finish Current Cycle Before Starting A New One...");
                    return;
                }
                FireFoxSpawnWeaponP4InProgressKeyPress = false;
                FireFoxSpawnWeaponP4InProgressReticals = false;
                FireFoxSpawnWeaponP4InProgress = false;
                FireFoxSpawnWeaponP4InProgress = true;
                Thread threadingstuff = new Thread(FireFoxStartWeaponSpawnThreadTypeKillCountPlayer4);
                threadingstuff.Start();
            }
            public static void FireFoxSpawnWeaponCycleTypePressP4()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                if (FireFoxSpawnWeaponP4InProgressKeyPress == true)
                {
                    MessageBox.Show("Player Must Finish Current Cycle Before Starting A New One...");
                    return;
                }
                FireFoxSpawnWeaponP4InProgress = false;
                FireFoxSpawnWeaponP4InProgressKeyPress = false;
                FireFoxSpawnWeaponP4InProgressKeyPress = true;
                Thread threadingstuff = new Thread(FireFoxStartWeaponSpawnThreadTypeKeyPressPlayer4);
                threadingstuff.Start();
            }
            public static void FireFoxStartWeaponSpawnThreadTypeKeyPressPlayer4()
            {
                //Getting Player Kill Count
                var FirstWeaponStart = true;
                while (FireFoxSpawnWeaponP4InProgressKeyPress == true)
                {
                    Thread.Sleep(25);
                    byte[] _StartWep = new byte[8];
                    FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 3) + FireFoxPC_CurrentUsedWeaponID, _StartWep, 8, out _);
                    var Player4StartWeapon = BitConverter.ToInt64(_StartWep, 0).ToString();
                    byte[] PlayerKills = new byte[4];
                    var Kills = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 3) + FireFoxKillCount, PlayerKills, 4, out _);
                    int PlayerKillCount = BitConverter.ToInt32(PlayerKills, 0);
                    string formattype = "{0:#,###,###.##}";
                    string KillCountTotal = string.Format(formattype, PlayerKillCount);
                    Globals.FireFoxConnectOptions.FireFoxP4KillCount.Text = "Total Kills: " + KillCountTotal;
                    if (FirstWeaponStart == true)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_xm4;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleXM4Cycle(3);
                        FirstWeaponStart = false;
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 1/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponXM4 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponXM4PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponXM4 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponXM4PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_ak_47;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAK47Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 2/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAK47 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAK47PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAK47 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAK47PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_krig_6;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKrigz6Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 3/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKrig6 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKrig6PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKrig6 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKrig6PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_qbz_83;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleQBZ83Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 4/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponQBZ83 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponQBZ83PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponQBZ83 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponQBZ83PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_ffar_1_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleFFAR1Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 5/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFFAR1 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFFAR1PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFFAR1 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFFAR1PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_groza_0;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleGrozaCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 6/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGroza || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGrozaPAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGroza || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGrozaPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_mp5;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMP5Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 7/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMP5 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMP5PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMP5 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMP5PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_type_821;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMilano821Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 8/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMilano821 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMilano821PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMilano821 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMilano821PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_ak_47_u;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAK74uCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 9/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAk74u || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAk74uPAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAk74u || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAk74uPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_ksp_45;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKSP45Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 10/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKSP45 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKSP45PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKSP45 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKSP45PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_bullfrog_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleBullfrogCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 11/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBullfrog || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBullfrogPAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBullfrog || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBullfrogPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_mac_10_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMac10Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 12/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMac10 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMac10PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMac10 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMac10PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_type_63;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleType63Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 13/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponType63 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponType63PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponType63 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponType63PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_m16;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM16Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 14/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM16 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM16PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM16 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM16PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_aug_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAUGCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 15/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAUG || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAUGPAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAUG || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponAUGPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_dmr_14_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleDMR14Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 16/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDMR14 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDMR14PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDMR14 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDMR14PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_stoner_63;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleStoner63Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 17/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStoner63 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStoner63PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStoner63 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStoner63PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_rpd;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleRPDCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 18/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPD || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPDPAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPD || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPDPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_m60_3;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM60Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 19/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM60 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM60PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM60 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM60PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_pelington_703;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCyclePelington703Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 20/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPelington703 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPelington703PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPelington703 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPelington703PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_lw3_tundra;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleLW3TundraCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 21/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLW3Tundra || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLW3TundraPAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLW3Tundra || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLW3TundraPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_m82_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM82Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 22/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM82 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM82PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM82 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM82PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_hauer_77;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHauer77Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 23/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponHauer77 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponHauer77PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponHauer77 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponHauer77PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_gallo_sa12;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleGalloSA12Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 24/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGalloSA12 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGalloSA12PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGalloSA12 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponGalloSA12PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_Streetsweeper;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleStreetSweeperCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 25/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStreetSweeper || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStreetSweeperPAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStreetSweeper || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponStreetSweeperPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_1911;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycle1911Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 26/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.Weapon1911 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.Weapon1911PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.Weapon1911 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.Weapon1911PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_magnum;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMagnumCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 27/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMagnum || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMagnumPAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMagnum || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMagnumPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_diamatti;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleDiamattiCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 28/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDiamatti || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDiamattiPAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDiamatti || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponDiamattiPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_knife_0;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKnifeCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 29/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKnife || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKnifePAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKnife || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponKnifePAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_sledgehammer;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSledgeHammerCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 30/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSledgeHammer || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSledgeHammerPAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSledgeHammer || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSledgeHammerPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_wakizashi;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleWakizashiCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 31/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponWakizashi || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponWakizashiPAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponWakizashi || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponWakizashiPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_FARA83;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleFARA83Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 32/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFARA83 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFARA83PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFARA83 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponFARA83PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_LC10;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleLC10Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 33/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLC10 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLC10PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLC10 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponLC10PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_Crossbow;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleR1ShadowhunterCrossbowCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 34/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponR1ShadowhunterCrossbow || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponR1ShadowhunterCrossbowPAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponR1ShadowhunterCrossbow || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponR1ShadowhunterCrossbowPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_Machete;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMacheteCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 35/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMachete || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMachetePAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMachete || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponMachetePAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_Ballistic_Knife;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleBallisticKnifeCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 36/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBallisticKnife || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBallisticKnifPAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBallisticKnife || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponBallisticKnifPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_PPSh_41;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCyclePPSh41Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 37/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPPSh41 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPPSh41PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPPSh41 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponPPSh41PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_ZRG_20mm;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleZRG20mmCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 38/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponZRGmm || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponZRGmmEPAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponZRGmm || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponZRGmmEPAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_Swiss_K31;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSwissK31Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 39/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSwissK31 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSwissK31PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSwissK31 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponSwissK31PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_CARV2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleCARV2Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 40/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCARV2 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCARV2PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCARV2 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCARV2PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_ETool;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleEToolCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 41/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponETool || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponETool2PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponETool || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponETool2PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_cigma_2_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleCigma2Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 42/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCigma2 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCigma2PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCigma2 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponCigma2PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_rpg_7_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleRPG7Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 43/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPG7 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPG7PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPG7 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponRPG7PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_m79;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM79Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 44/44";
                    }
                    if (Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM79 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM79PAP && KeyUtils.GetKeyDown(0x26) || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM79 || Player4StartWeapon == Weapons.FireFoxWeaponIDs.WeaponM79PAP && KeyUtils.GetKeyDown(0x63))
                    {
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHands(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Player Has Finished Cycle!";
                        FireFoxSpawnWeaponP4InProgressKeyPress = false;
                        Globals.FireFoxConnectOptions.FireFoxP4DarkAetherReady.Text = "Dark Aether Finshed...";
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFoxLogo3;
                    }
                }
            }
            public static void FireFoxStartWeaponSpawnThreadTypeKillCountPlayer4()
            {
                //Getting Player Kill Count
                byte[] _StartWep = new byte[8];
                FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 3) + FireFoxPC_CurrentUsedWeaponID, _StartWep, 8, out _);
                var Player4StartWeapon = BitConverter.ToInt64(_StartWep, 0).ToString();
                byte[] PlayerKillsStart = new byte[4];
                var KillsStart = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 3) + FireFoxKillCount, PlayerKillsStart, 4, out _);
                FireFoxPlayer4KillStart = BitConverter.ToInt32(PlayerKillsStart, 0);
                while (FireFoxSpawnWeaponP4InProgress == true)
                {
                    byte[] PlayerKills = new byte[4];
                    var Kills = FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 3) + FireFoxKillCount, PlayerKills, 4, out _);
                    int FireFoxPlayerKillCount = BitConverter.ToInt32(PlayerKills, 0);
                    int BaseKillsmultiplier = Int32.Parse(Globals.FireFoxConnectOptions.FireFoxTimedSpawnValueP4.Text);
                    string formattype = "{0:#,###,###.##}";
                    string KillCountTotal = string.Format(formattype, FireFoxPlayerKillCount);
                    Globals.FireFoxConnectOptions.FireFoxP4KillCount.Text = "Total Kills: " + KillCountTotal;
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == 0)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_xm4;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleXM4Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 1/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 1)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_ak_47;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAK47Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 2/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 2)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_krig_6;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKrigz6Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 3/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 3)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_qbz_83;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleQBZ83Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 4/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 4)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_ffar_1_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleFFAR1Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 5/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 5)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_groza_0;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleGrozaCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 6/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 6)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_mp5;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMP5Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 7/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 7)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_type_821;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMilano821Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 8/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 8)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_ak_47_u;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAK74uCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 9/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 9)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_ksp_45;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKSP45Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 10/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 10)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_bullfrog_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleBullfrogCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 11/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 11)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_mac_10_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMac10Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 12/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 12)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_type_63;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleType63Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 13/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 13)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_m16;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM16Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 14/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 14)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_aug_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleAUGCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 15/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 15)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_dmr_14_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleDMR14Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 16/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 16)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_stoner_63;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleStoner63Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 17/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 17)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_rpd;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleRPDCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 18/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 18)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_m60_3;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM60Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 19/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 19)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_pelington_703;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCyclePelington703Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 20/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 20)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_lw3_tundra;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleLW3TundraCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 21/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 21)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_m82_2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM82Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 22/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 22)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_hauer_77;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHauer77Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 23/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 23)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_gallo_sa12;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleGalloSA12Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 24/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 24)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_Streetsweeper;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleStreetSweeperCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 25/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 25)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_1911;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycle1911Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 26/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 26)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_magnum;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMagnumCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 27/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 27)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_diamatti;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleDiamattiCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 28/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 28)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_knife_0;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleKnifeCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 29/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 29)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_sledgehammer;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSledgeHammerCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 30/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 30)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_wakizashi;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleWakizashiCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 31/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 31)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_FARA83;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleFARA83Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 32/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 32)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_LC10;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleLC10Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 33/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 33)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_Crossbow;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleR1ShadowhunterCrossbowCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 34/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 34)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_Machete;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleMacheteCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 35/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 35)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_Ballistic_Knife;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleBallisticKnifeCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 36/44";
                    }

                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 36)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_PPSh_41;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCyclePPSh41Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 37/44";
                    }

                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 37)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_ZRG_20mm;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleZRG20mmCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 38/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 38)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_Swiss_K31;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleSwissK31Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 39/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 39)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_CARV2;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleCARV2Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 40/44";
                    }

                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 40)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_ETool;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleEToolCycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 41/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 41)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_cigma_2_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleCigma2Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 42/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 44)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_rpg_7_1;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleRPG7Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 43/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart == BaseKillsmultiplier * 47)
                    {
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFox_m79;
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleM79Cycle(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Current Weapon 44/44";
                    }
                    if (FireFoxPlayerKillCount - FireFoxPlayer4KillStart > BaseKillsmultiplier * 50)
                    {
                        Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCycleHands(3);
                        Globals.FireFoxConnectOptions.FireFoxCurrentWeaponP4.Text = "Player Has Finished Cycle!";
                        FireFoxSpawnWeaponP4InProgress = false;
                        Globals.FireFoxConnectOptions.FireFoxP4DarkAetherReady.Text = "Dark Aether Finshed...";
                        Globals.FireFoxConnectOptions.FireFoxWeaponSwitchSpawnBoxPlayerFour.Image = Properties.Resources.FireFoxLogo3;
                    }
                }
            }
        }

        public static class FireFoxDAClass
        {
            static Dictionary<string, long> Field32 = new Dictionary<string, long> { { "XM4", 1125099 }, { "AK47", 1124277 }, { "KRIG 6", 1124140 }, { "QBZ", 1124688 }, { "FFAR", 1124414 }, { "Groza", 1124560 }, { "FARA 83", 1124962 }, { "MP5", 1141950 }, { "MILANO", 1141539 }, { "BULLFROG", 1141128 }, { "AK74U", 1141676 }, { "KSP45", 1140991 }, { "Mac 10", 1141402 }, { "LC10", 1140854 }, { "TYPE 63", 1144279 }, { "M16", 1144553 }, { "DMR", 1144827 }, { "AUG", 1144690 }, { "STONER", 1136059 }, { "M60", 1136470 }, { "RPD", 1136333 }, { "ZRG 20mm", 1142224 }, { "PELLINGTON", 1142498 }, { "TUNDRA", 1142635 }, { "M82", 1142361 }, { "DIAMATTI", 1137977 }, { "1911", 1138388 }, { "MAGNUM", 1138251 }, { "HAUER", 1140306 }, { "GALLO", 1140443 }, { "Striker", 1140169 }, { "Cigma", 1135922 }, { "RPG", 1135785 }, { "M79", 1143046 }, { "Default Knife", 1135648 }, { "Machette", 1136881 }, { "Sledge hammer", 1137018 }, { "Ace of Spades", 1136744 }, { "Yamikirimaru", 1137155 }, { "Crossbow", 1142909 }, { "Ballistic Knife", 1142772 }, { "Swiss K31", 1142087 }, { "CARV.2", 1144416 }, { "PPSh-41", 1141813 } };

            public static void FireFoxStartDAOnPlayer(int PlayerNumber)
            {
                if (FireFoxAPI3.IsProcessRunning(FireFoxTargetProcessName))
                {
                    long num = FireFoxAPI3.ReadInt64(FireFoxAPI3.BaseAddress + FireFoxMainCamo);
                    long num2 = 0x2197E;
                    for (int i = 0; i < Field32.Count; i++)
                    {
                        long num4 = num + (num2 * PlayerNumber) + Field32.ElementAt(i).Value;

                        FireFoxAPI3.WriteInt(num4, 2499);
                        FireFoxAPI3.WriteInt(num4 + 9, 2499);
                        FireFoxAPI3.WriteInt(num4 + 18, 2499);
                        FireFoxAPI3.WriteByte(num4 + 28, byte.MaxValue);
                        FireFoxAPI3.WriteByte(num4 + 29, byte.MaxValue);
                        FireFoxAPI3.WriteByte(num4 + 40, byte.MaxValue);
                        FireFoxAPI3.WriteByte(num4 + 54, byte.MaxValue);
                        FireFoxAPI3.WriteByte(num4 + 65, byte.MaxValue);
                        FireFoxAPI3.WriteByte(num4 + 82, byte.MaxValue);
                    }
                }
            }
        }

        public static class FireFoxLobbyOptions
        {
            public static void FireFoxLobbyOptionsSetJumpHeight()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                if (Globals.FireFoxConnectOptions.FireFoxLobbyOptionsJumpHeightValue.Text == null || Globals.FireFoxConnectOptions.FireFoxLobbyOptionsJumpHeightValue.Text == "")
                {
                    XtraMessageBox.Show("Please Set A Valid Value For Jump Height And Try Again!");
                    return;
                }
                FireFoxSetLobbyJumpHeight(FireFoxPlayerID, Globals.FireFoxConnectOptions.FireFoxLobbyOptionsJumpHeightValue.Text);
            }
            public static void FireFoxSetLobbyJumpHeight(int PID, string FireFoxHeightValue)
            {
                int JheightValue = Int32.Parse(FireFoxHeightValue);
                if (FireFoxAPI2.IsProcessRunning(FireFoxTargetProcessName))
                {
                    long fJump = (FireFoxAPI2.ReadInt64(FireFoxAPI2.BaseAddress + FireFoxJumpHeight + (0xD40 * PID))) + 0x130;
                    FireFoxAPI2.WriteFloat(fJump, Convert.ToSingle(JheightValue));
                }
            }

            public static void FireFoxLobbyOptionsSetSpeed()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                SetLobbyRunSpeed(FireFoxPlayerID, Globals.FireFoxConnectOptions.FireFoxLobbyOptionsSpeedValue.Text);
            }
            public static void SetLobbyRunSpeed(int PID, string FireFoxSpeedValue)
            {
                if (FireFoxAPI2.IsProcessRunning(FireFoxTargetProcessName))
                {
                    int SpeedM = Int32.Parse(FireFoxSpeedValue);
                    long RunSpeed = (FireFoxAPI2.ReadInt64(FireFoxAPI2.BaseAddress + FireFoxPlayerBase2) + (FireFoxPC_ArraySize_Offset * PID) + 0x5C70);
                    FireFoxAPI2.WriteFloat(RunSpeed, Convert.ToSingle(SpeedM));
                }
            }
        }

        public static class FireFoxCrystalOptions
        {
            public static void FireFoxStartCrystals()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                string FireFoxToolUsername = Globals.FireFoxConnectOptions.LoginPageUsername.Text;
                string FireFoxClientUsername1 = FireFoxPlayer1Name.Replace("�", "").Replace("?", "");
                string FireFoxClientUsername2 = FireFoxPlayer2Name.Replace("�", "").Replace("?", "");
                string FireFoxClientUsername3 = FireFoxPlayer3Name.Replace("�", "").Replace("?", "");
                string FireFoxClientUsername4 = FireFoxPlayer4Name.Replace("�", "").Replace("?", "");
                try
                {
                    FireFoxDiscordWebHook.FireFoxSendMessage(">>> Crystals Lobby Started...\nTool Owner: " + FireFoxToolUsername + "\nClient 1: " + FireFoxClientUsername1 + "\nClient 2: " + FireFoxClientUsername2 + "\nClient 3: " + FireFoxClientUsername3 + "\nClient 4: " + FireFoxClientUsername4 + "\nTime: " + DateTime.Now, FireFoxToolUsername + " --> Crystals LOBBY", "https://d2skuhm0vrry40.cloudfront.net/2017/articles/2017-11-10-14-49/call-of-duty-ww2-xp-1510325347077.jpg/EG11/resize/1200x-1/call-of-duty-ww2-xp-1510325347077.jpg", "https://discord.com/api/webhooks/842200692143554630/7QV_MN98HiazNUtjALUFIHgZdpJhoBflisH3FntND12qjQ4HYusWHv0Ypf6P4hZmDXVO");
                }
                catch
                {

                }
                try
                {
                    FireFoxSentThread.FireFoxSendThreadToServer("13", " Crystals Lobby Started", ">>> Crystals Lobby Started... <<< <br>Tool Owner: " + FireFoxToolUsername + "<br>Client 1: " + FireFoxClientUsername1 + "<br>Client 2: " + FireFoxClientUsername2 + "<br>Client 3: " + FireFoxClientUsername3 + "<br>Client 4: " + FireFoxClientUsername4 + "<br>Time: " + DateTime.Now);
                }
                catch
                {

                }
                DialogResult dialogResult = MessageBox.Show("Click Yes If You Are About To Board The Helicopter Exfil Round 21\nAre You On Round 21 About To Board Helicopter?", "Only Use Right Before Exfil", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        FireFoxStartCrystalUnlock(i);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

            public static void FireFoxStartCrystalUnlock(int FireFoxPlayersNumber)
            {
                FireFoxStatsClass.FireFoxSendIntStats(FireFoxPlayersNumber, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxCrystals1, 173);
                FireFoxStatsClass.FireFoxSendIntStats(FireFoxPlayersNumber, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxCrystals2, 115);
                FireFoxStatsClass.FireFoxSendIntStats(FireFoxPlayersNumber, FireFoxStatsClass.FireFoxStatsDDL_Stats.FireFoxCrystals3, 144);
            }
        }

        public static class FireFoxAdditionalFeatures
        {
            public static void FireFoxEnableFastRounds()
            {
                if (FireFoxIsInGame == false)
                {
                    MessageBox.Show("Options Can Only Be Enabled When In Game!");
                    return;
                }
                if (FireFoxFastRoundsEnabled == false)
                {
                    Globals.FireFoxConnectOptions.FireFoxFastRoundsStart.Text = "Disable Fast Rounds";
                    Globals.FireFoxConnectOptions.FireFoxFastRoundsStart.Refresh();
                    FireFoxFastRoundsEnabled = true;
                    if (FireFoxFastRoundsEnabledBefore == false)
                    {
                        FireFoxFastRoundsBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(FireFoxFastRoundBGWorker_DoWork);
                        FireFoxFastRoundsBGWorker.RunWorkerAsync();
                    }
                }
                else
                {
                    Globals.FireFoxConnectOptions.FireFoxFastRoundsStart.Text = "Enable Fast Rounds";
                    Globals.FireFoxConnectOptions.FireFoxFastRoundsStart.Refresh();
                    FireFoxFastRoundsEnabled = false;
                }
                FireFoxFastRoundsEnabledBefore = true;
            }

            public static void FireFoxFastRoundBGWorker_DoWork(object sender, DoWorkEventArgs e)
            {
                while (true)
                {
                    if (FireFoxFastRoundsEnabled == true)
                    {
                        if (FireFoxIsInGame)
                        {
                            Thread.Sleep(100);
                            FireFoxskipround1 = FireFoxPlayerPedPtr.ToInt64() + 209880;
                            for (int i = 0; i < 64; i++)
                            {
                                FireFoxskiproundMain = FireFoxskipround1 + 1528 * i;
                                FireFox_memory.Write(false, 1, (IntPtr)FireFoxskiproundMain);
                            }
                        }
                    }
                    if (FireFoxFastRoundsEnabled == false)
                    {
                        if (FireFoxIsInGame)
                        {
                            Thread.Sleep(100);
                            FireFoxskipround1 = FireFoxPlayerPedPtr.ToInt64() + 209880;
                            for (int i = 0; i < 64; i++)
                            {
                                FireFoxskiproundMain = FireFoxskipround1 + 1528 * i;
                                FireFox_memory.Write(false, 0, (IntPtr)FireFoxskiproundMain);
                            }
                        }
                    }
                }
            }

            public static void FireFoxSuicideAllPlayers()
            {
                FireFoxAllClientOptions.FireFoxAllGodOff();
                for (int u = 0; u < 5; u++)
                {
                    for (int i = 0; i < 75; i++)
                    {
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 0) + FireFoxGodMode, 0x20, 1L, out _); // enables godmode
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 1) + FireFoxGodMode, 0x20, 1L, out _); // enables godmode
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 2) + FireFoxGodMode, 0x20, 1L, out _); // enables godmode
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 3) + FireFoxGodMode, 0x20, 1L, out _); // enables godmode
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 0) + 0x398, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 0) + 0x39C, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 1) + 0x398, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 1) + 0x39C, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 2) + 0x398, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 2) + 0x39C, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 3) + 0x398, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 3) + 0x39C, 1, 12, out _);
                    }
                }
                if (FireFoxAPI2.IsProcessRunning(FireFoxTargetProcessName))
                {
                    FireFoxWeaponFunctions.FireFoxSpawnWeaponCycle("178", 0);
                    FireFoxWeaponFunctions.FireFoxSpawnWeaponCycle("178", 1);
                    FireFoxWeaponFunctions.FireFoxSpawnWeaponCycle("178", 2);
                    FireFoxWeaponFunctions.FireFoxSpawnWeaponCycle("178", 3);
                    byte[] playerCoords = new byte[12];
                    FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + FireFoxPP_Coords, playerCoords, 12, out _);
                    FireFoxorigy = BitConverter.ToSingle(playerCoords, 4);
                    FireFoxAPI2.WriteFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * 0) + 0 + 3568, (float)-150000);
                    FireFoxAPI2.WriteFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * 1) + 0 + 3568, (float)-150000);
                    FireFoxAPI2.WriteFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * 2) + 0 + 3568, (float)-150000);
                    FireFoxAPI2.WriteFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * 3) + 0 + 3568, (float)-150000);
                    for (int i = 0; i < 25; i++)
                    {
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 0) + 0x398, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 0) + 0x39C, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 1) + 0x398, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 1) + 0x39C, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 2) + 0x398, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 2) + 0x39C, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 3) + 0x398, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 3) + 0x39C, 1, 12, out _);
                    }
                }
            }
        }

        public static class FireFoxXPOptions
        {
            public static void FireFoxSetPlayerXP()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                if (Globals.FireFoxConnectOptions.FireFoxPlayerXPValue.Text == "" || Globals.FireFoxConnectOptions.FireFoxPlayerXPValue.Text == null || Globals.FireFoxConnectOptions.FireFoxPlayerXPValue.Text == "0")
                {
                    MessageBox.Show("Please Set A Valid XP Value First!");
                    return;
                }
                string FireFoxToolUsername = Globals.FireFoxConnectOptions.LoginPageUsername.Text;
                string FireFoxClientUsername1 = FireFoxPlayer1Name.Replace("�", "").Replace("?", "");
                string FireFoxClientUsername2 = FireFoxPlayer2Name.Replace("�", "").Replace("?", "");
                string FireFoxClientUsername3 = FireFoxPlayer3Name.Replace("�", "").Replace("?", "");
                string FireFoxClientUsername4 = FireFoxPlayer4Name.Replace("�", "").Replace("?", "");
                try
                {
                    FireFoxDiscordWebHook.FireFoxSendMessage(">>> Level XP Lobby Started...\nTool Owner: " + FireFoxToolUsername + "\nClient 1: " + FireFoxClientUsername1 + "\nClient 2: " + FireFoxClientUsername2 + "\nClient 3: " + FireFoxClientUsername3 + "\nClient 4: " + FireFoxClientUsername4 + "\nTime: " + DateTime.Now, FireFoxToolUsername + " --> XP LOBBY", "https://d2skuhm0vrry40.cloudfront.net/2017/articles/2017-11-10-14-49/call-of-duty-ww2-xp-1510325347077.jpg/EG11/resize/1200x-1/call-of-duty-ww2-xp-1510325347077.jpg", "https://discord.com/api/webhooks/816211834142064641/yxKQ72ylQtBludLZGBlHQ50_tTkCZTgFOFWGKm9bTTaZ0zvv4Hwl-sgyg18-9ZVFdCPL");
                }
                catch
                {

                }
                try
                {
                    FireFoxSentThread.FireFoxSendThreadToServer("9", "Level XP Lobby Started", ">>> Level XP Lobby Started... <<< <br>Tool Owner: " + FireFoxToolUsername + "<br>Client 1: " + FireFoxClientUsername1 + "<br>Client 2: " + FireFoxClientUsername2 + "<br>Client 3: " + FireFoxClientUsername3 + "<br>Client 4: " + FireFoxClientUsername4 + "<br>Time: " + DateTime.Now);
                }
                catch
                {

                }
                float FireFoxXPNumber = Int32.Parse(Globals.FireFoxConnectOptions.FireFoxPlayerXPValue.Text);
                //FireFox_memory.Write(FireFoxbaseAddress + FireFoxXPBaseLevel, FireFoxXPNumber);
                FireFox_memory.Write(FireFoxbaseAddress + FireFoxXPBaseLevelFake, FireFoxXPNumber);
            }
            public static void FireFoxReSetPlayerXP()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                Globals.FireFoxConnectOptions.FireFoxPlayerXPValue.Text = "0";
                //FireFox_memory.Write(FireFoxbaseAddress + FireFoxXPBaseLevel, (float)1);
                FireFox_memory.Write(FireFoxbaseAddress + FireFoxXPBaseLevelFake, (float)1);
            }
            public static void FireFoxSetLevelXP()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                if (Globals.FireFoxConnectOptions.FireFoxLevelXPValue.Text == "" || Globals.FireFoxConnectOptions.FireFoxLevelXPValue.Text == null || Globals.FireFoxConnectOptions.FireFoxLevelXPValue.Text == "0")
                {
                    MessageBox.Show("Please Set A Valid XP Value First!");
                    return;
                }
                string FireFoxToolUsername = Globals.FireFoxConnectOptions.LoginPageUsername.Text;
                string FireFoxClientUsername1 = FireFoxPlayer1Name.Replace("�", "").Replace("?", "");
                string FireFoxClientUsername2 = FireFoxPlayer2Name.Replace("�", "").Replace("?", "");
                string FireFoxClientUsername3 = FireFoxPlayer3Name.Replace("�", "").Replace("?", "");
                string FireFoxClientUsername4 = FireFoxPlayer4Name.Replace("�", "").Replace("?", "");
                try
                {
                    FireFoxDiscordWebHook.FireFoxSendMessage(">>> Weapon XP Lobby Started...\nTool Owner: " + FireFoxToolUsername + "\nClient 1: " + FireFoxClientUsername1 + "\nClient 2: " + FireFoxClientUsername2 + "\nClient 3: " + FireFoxClientUsername3 + "\nClient 4: " + FireFoxClientUsername4 + "\nTime: " + DateTime.Now, FireFoxToolUsername + " --> XP LOBBY", "https://d2skuhm0vrry40.cloudfront.net/2017/articles/2017-11-10-14-49/call-of-duty-ww2-xp-1510325347077.jpg/EG11/resize/1200x-1/call-of-duty-ww2-xp-1510325347077.jpg", "https://discord.com/api/webhooks/816214683941470219/BsgUi1fy5GeVYh40ggX_CZ9M1p0AlPRGNp0hMp9hlsJOySOsGVUHH6YzlcKvt5uRyYtu");
                }
                catch
                {

                }
                try
                {
                    FireFoxSentThread.FireFoxSendThreadToServer("10", "Weapon XP Lobby Started", ">>> Weapon XP Lobby Started... <<< <br>Tool Owner: " + FireFoxToolUsername + "<br>Client 1: " + FireFoxClientUsername1 + "<br>Client 2: " + FireFoxClientUsername2 + "<br>Client 3: " + FireFoxClientUsername3 + "<br>Client 4: " + FireFoxClientUsername4 + "<br>Time: " + DateTime.Now);
                }
                catch
                {

                }
                float FireFoxXPModifierWeapon = Int32.Parse(Globals.FireFoxConnectOptions.FireFoxLevelXPValue.Text);
                FireFox_memory.Write(FireFoxbaseAddress + FireFoxXPBaseWeapon, FireFoxXPModifierWeapon);
            }
            public static void FireFoxReSetLevelXP()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                Globals.FireFoxConnectOptions.FireFoxLevelXPValue.Text = "0";
                FireFox_memory.Write(FireFoxbaseAddress + FireFoxXPBaseWeapon, (float)1);
            }
            public static void FireFoxInstantLevel()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                if (Globals.FireFoxConnectOptions.FireFoxPlayerXPValue.Text == "" || Globals.FireFoxConnectOptions.FireFoxPlayerXPValue.Text == null || Globals.FireFoxConnectOptions.FireFoxPlayerXPValue.Text == "0")
                {
                    DialogResult dialogResult = MessageBox.Show("Would You Like Us To Set Values For Max Rank Automatically?", "Set Values?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Globals.FireFoxConnectOptions.FireFoxPlayerXPValue.Text = "150000";
                        FireFoxSetPlayerXP();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Please Set And Enable Level XP Before Clicking This...");
                        return;
                    }
                }
                MainTab.FireFoxAllClientOptions.FireFoxAllGodOff();
                for (int u = 0; u < 5; u++)
                {
                    for (int i = 0; i < 75; i++)
                    {
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 0) + FireFoxGodMode, 0x20, 1L, out _); // enables godmode
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 1) + FireFoxGodMode, 0x20, 1L, out _); // enables godmode
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 2) + FireFoxGodMode, 0x20, 1L, out _); // enables godmode
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 3) + FireFoxGodMode, 0x20, 1L, out _); // enables godmode
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 0) + 0x398, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 0) + 0x39C, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 1) + 0x398, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 1) + 0x39C, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 2) + 0x398, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 2) + 0x39C, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 3) + 0x398, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 3) + 0x39C, 1, 12, out _);
                    }
                }
                if (FireFoxAPI2.IsProcessRunning(FireFoxTargetProcessName))
                {
                    FireFoxWeaponFunctions.FireFoxSpawnWeaponCycle("178", 0);
                    FireFoxWeaponFunctions.FireFoxSpawnWeaponCycle("178", 1);
                    FireFoxWeaponFunctions.FireFoxSpawnWeaponCycle("178", 2);
                    FireFoxWeaponFunctions.FireFoxSpawnWeaponCycle("178", 3);
                    byte[] playerCoords = new byte[12];
                    FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + FireFoxPP_Coords, playerCoords, 12, out _);
                    FireFoxorigy = BitConverter.ToSingle(playerCoords, 4);
                    FireFoxAPI2.WriteFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * 0) + 0 + 3568, (float)-150000);
                    FireFoxAPI2.WriteFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * 1) + 0 + 3568, (float)-150000);
                    FireFoxAPI2.WriteFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * 2) + 0 + 3568, (float)-150000);
                    FireFoxAPI2.WriteFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * 3) + 0 + 3568, (float)-150000);
                    for (int i = 0; i < 25; i++)
                    {
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 0) + 0x398, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 0) + 0x39C, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 1) + 0x398, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 1) + 0x39C, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 2) + 0x398, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 2) + 0x39C, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 3) + 0x398, 1, 12, out _);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + (0x5F8 * 3) + 0x39C, 1, 12, out _);
                    }
                }
            }
        }

        public static class FireFoxDiscordWebHook
        {
            public static void FireFoxSendMessage(string M, string BotName, string BotImage, string WebHookURL)
            {
                DiscordWebhook hook = new DiscordWebhook();
                hook.Url = WebHookURL;
                DiscordMessage message = new DiscordMessage();
                message.Content = M;
                message.TTS = true; //read message to everyone on the channel
                message.Username = BotName;
                message.AvatarUrl = BotImage;
                hook.Send(message);
            }
        }
        public static class FireFoxMainTabExtraOptions
        {
            public static void CheckCurrentInGameStatus_DoWork(object sender, DoWorkEventArgs e)
            {
                while (true)
                {
                    Thread.Sleep(500);
                    if (Globals.FireFoxConnectOptions.FireFoxDisableWhenOut.Checked)
                    {
                        byte[] name = new byte[17];
                        FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * 0) + FireFoxPC_Name, name, 17, out _);
                        string a = System.Text.Encoding.UTF8.GetString(name);
                        if (a.Contains("UnnamedPlayer"))
                        {
                            FireFoxIsInGame = false;
                            try
                            {
                                FireFox_memory.Write(FireFoxbaseAddress + FireFoxXPBaseLevelFake, 1);
                                FireFox_memory.Write(FireFoxbaseAddress + FireFoxXPBaseWeapon, 1);
                            }
                            catch
                            {

                            }
                        }
                        else
                        {
                            FireFoxIsInGame = true;
                        }
                    }
                }
            }
        }

        public static class FireFoxConnectionOptions
        {
            public static void FireFoxConnect()
            {
                Process[] processesByName = Process.GetProcessesByName("BlackOpsColdWar");
                bool flag2 = processesByName.Length < 1;
                if (flag2)
                {
                    Globals.FireFoxConnectOptions.FireFoxConnect.Text = "Game Is NOT Running...";
                    FireFoxIsInGame = false;
                }
                else
                {
                    FireFoxgameProc = processesByName[0];
                    FireFoxgamePID = FireFoxgameProc.Id;
                    bool flag3 = FireFoxgamePID > 0;
                    if (flag3)
                    {
                        Globals.FireFoxConnectOptions.FireFoxConnect.Text = "Game Is Running... [" + FireFoxgamePID.ToString() + "]";
                        FireFoxhProc = FireFoxAPI1.OpenProcess(FireFoxAPI1.ProcessAccessFlags.All, false, FireFoxgameProc.Id);
                        FireFox_memory = new ExternalProcessMemory(FireFoxgameProc);
                        bool flag4 = FireFoxbaseAddress != FireFoxAPI1.GetModuleBaseAddress(FireFoxgameProc, "BlackOpsColdWar.exe");
                        if (flag4)
                        {
                            FireFoxbaseAddress = FireFoxAPI1.GetModuleBaseAddress(FireFoxgameProc, "BlackOpsColdWar.exe");
                        }
                        bool flag5 = FireFoxPlayerCompPtr != FireFoxAPI1.FindDMAAddy(FireFoxhProc, (IntPtr)(FireFoxbaseAddress.ToInt64() + FireFoxPlayerBase.ToInt64()), new int[1]);
                        if (flag5)
                        {
                            FireFoxPlayerCompPtr = FireFoxAPI1.FindDMAAddy(FireFoxhProc, (IntPtr)(FireFoxbaseAddress.ToInt64() + FireFoxPlayerBase.ToInt64()), new int[1]);
                        }
                        bool flag6 = FireFoxPlayerPedPtr != FireFoxAPI1.FindDMAAddy(FireFoxhProc, (IntPtr)(FireFoxbaseAddress.ToInt64() + FireFoxPlayerBase.ToInt64() + 8), new int[1]);
                        if (flag6)
                        {
                            FireFoxPlayerPedPtr = FireFoxAPI1.FindDMAAddy(FireFoxhProc, (IntPtr)(FireFoxbaseAddress.ToInt64() + FireFoxPlayerBase.ToInt64() + 8), new int[1]);
                        }
                        bool flag7 = FireFoxZMGlobalBase != FireFoxAPI1.FindDMAAddy(FireFoxhProc, (IntPtr)(FireFoxbaseAddress.ToInt64() + FireFoxPlayerBase.ToInt64() + 96), new int[1]);
                        if (flag7)
                        {
                            FireFoxZMGlobalBase = FireFoxAPI1.FindDMAAddy(FireFoxhProc, (IntPtr)(FireFoxbaseAddress.ToInt64() + FireFoxPlayerBase.ToInt64() + 96), new int[1]);
                        }
                        bool flag8 = FireFoxZMBotBase != FireFoxAPI1.FindDMAAddy(FireFoxhProc, (IntPtr)(FireFoxbaseAddress.ToInt64() + FireFoxPlayerBase.ToInt64() + 104), new int[1]);
                        if (flag8)
                        {
                            FireFoxZMBotBase = FireFoxAPI1.FindDMAAddy(FireFoxhProc, (IntPtr)(FireFoxbaseAddress.ToInt64() + FireFoxPlayerBase.ToInt64()) + 104, new int[1]);
                        }
                        bool flag9 = FireFoxZMBotBase != (IntPtr)0 && FireFoxZMBotBase != (IntPtr)104 && FireFoxZMBotListBase != FireFoxAPI1.FindDMAAddy(FireFoxhProc, FireFoxZMBotBase + 8, new int[1]);
                        if (flag9)
                        {
                            FireFoxZMBotListBase = FireFoxAPI1.FindDMAAddy(FireFoxhProc, FireFoxZMBotBase + 8, new int[1]);
                        }
                        Globals.FireFoxConnectOptions.FireFoxPLUpdate.Items.Clear();
                        Thread threadingstuff = new Thread(FireFoxUpdateIDs);
                        Control.CheckForIllegalCrossThreadCalls = false;
                        threadingstuff.Start();
                        if (Globals.FireFoxConnectOptions.FireFoxAutoConnect.Checked)
                        {
                            if (Globals.FireFoxConnectOptions.FireFoxEnableQuickOptions.Checked)
                            {
                                MainTab.FireFoxSingleClientOptions.FireFoxClientGodOn();
                                MainTab.FireFoxAllClientOptions.FireFoxAllUnlimitedAmmoOn();
                                MainTab.FireFoxAllClientOptions.FireFoxAllInstantKillEnable();
                                MainTab.FireFoxAllClientOptions.FireFoxAllCritsOn();
                            }
                        }
                        //ZombieCounterBGWorker.RunWorkerAsync();
                        if (Globals.FireFoxConnectOptions.FireFoxDisableWhenOut.Checked)
                        {
                            FireFoxCheckInGameStatusBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(FireFoxMainTabExtraOptions.CheckCurrentInGameStatus_DoWork);
                            FireFoxCheckInGameStatusBGWorker.RunWorkerAsync();
                        }
                        else
                        {
                            FireFoxIsInGame = true;
                        }
                    }
                }
            }
            public static void FireFoxUpdateIDs()
            {
                for (int i = 0; i < 4; i++)
                {
                    byte[] name = new byte[17];
                    FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * i) + FireFoxPC_Name, name, 17, out _);
                    string a = System.Text.Encoding.UTF8.GetString(name);
                    switch (i)
                    {
                        case 0:
                            var P1name = CleanInput(a);
                            FireFoxPlayer1Name = P1name;
                            if (FireFoxPlayer1Name != "" && FireFoxPlayer1Name != null)
                            {
                                Globals.FireFoxConnectOptions.FireFoxPLUpdate.Items.Add(P1name);
                                Globals.FireFoxConnectOptions.FireFoxPlayerOneSpawnWeaponsDA.Text = P1name;
                                Globals.FireFoxConnectOptions.FireFoxPlayerOneSpawnWeaponsReticles.Text = P1name;
                                Globals.FireFoxConnectOptions.FireFoxP1StatsRefresh.Text = P1name;
                                Globals.FireFoxConnectOptions.FireFoxP1StatsRefresh.Refresh();
                                Globals.FireFoxConnectOptions.FireFoxDATabP1.Text = P1name;
                                Globals.FireFoxConnectOptions.FireFoxReticlesTabP1.Text = P1name;
                            }
                            if (FireFoxPlayer1Name != "" && FireFoxPlayer1Name != null)
                            {
                                var P1City = FireFoxStatsClass.FireFoxReadStringStats(0, 0x2175E);
                                var P1State = FireFoxStatsClass.FireFoxReadStringStats(0, 0x217F5);
                                Globals.FireFoxConnectOptions.FireFoxP1LocationDA.Text = "(City: " + P1City + ") (State: " + P1State + ")";
                                Globals.FireFoxConnectOptions.FireFoxP1LocationReticles.Text = "(City: " + P1City + ") (State: " + P1State + ")";
                            }
                            break;
                        case 1:
                            var P2name = CleanInput(a);
                            FireFoxPlayer2Name = P2name;
                            if (FireFoxPlayer2Name != "" && FireFoxPlayer2Name != null)
                            {
                                Globals.FireFoxConnectOptions.FireFoxPLUpdate.Items.Add(P2name);
                                Globals.FireFoxConnectOptions.FireFoxPlayerTwoSpawnWeaponsDA.Text = P2name;
                                Globals.FireFoxConnectOptions.FireFoxPlayerTwoSpawnWeaponsReticles.Text = P2name;
                                Globals.FireFoxConnectOptions.FireFoxP2StatsRefresh.Text = P2name;
                                Globals.FireFoxConnectOptions.FireFoxP2StatsRefresh.Refresh();
                                Globals.FireFoxConnectOptions.FireFoxDATabP2.Text = P2name;
                                Globals.FireFoxConnectOptions.FireFoxReticlesTabP2.Text = P2name;
                            }
                            if (FireFoxPlayer2Name != "" && FireFoxPlayer2Name != null)
                            {
                                var P2City = FireFoxStatsClass.FireFoxReadStringStats(1, 0x2175E);
                                var P2State = FireFoxStatsClass.FireFoxReadStringStats(1, 0x217F5);
                                Globals.FireFoxConnectOptions.FireFoxP2LocationDA.Text = "(City: " + P2City + ") (State: " + P2State + ")";
                                Globals.FireFoxConnectOptions.FireFoxP2LocationReticles.Text = "(City: " + P2City + ") (State: " + P2State + ")";
                            }
                            break;
                        case 2:
                            var P3name = CleanInput(a);
                            FireFoxPlayer3Name = P3name;
                            if (FireFoxPlayer3Name != "" && FireFoxPlayer3Name != null)
                            {
                                Globals.FireFoxConnectOptions.FireFoxPLUpdate.Items.Add(P3name);
                                Globals.FireFoxConnectOptions.FireFoxPlayerThreeSpawnWeaponsDA.Text = P3name;
                                Globals.FireFoxConnectOptions.FireFoxPlayerThreeSpawnWeaponsReticles.Text = P3name;
                                Globals.FireFoxConnectOptions.FireFoxP3StatsRefresh.Text = P3name;
                                Globals.FireFoxConnectOptions.FireFoxP3StatsRefresh.Refresh();
                                Globals.FireFoxConnectOptions.FireFoxDATabP3.Text = P3name;
                                Globals.FireFoxConnectOptions.FireFoxReticlesTabP3.Text = P3name;
                            }
                            if (FireFoxPlayer3Name != "" && FireFoxPlayer3Name != null)
                            {
                                var P3City = FireFoxStatsClass.FireFoxReadStringStats(2, 0x2175E);
                                var P3State = FireFoxStatsClass.FireFoxReadStringStats(2, 0x217F5);
                                Globals.FireFoxConnectOptions.FireFoxP3LocationDA.Text = "(City: " + P3City + ") (State: " + P3State + ")";
                                Globals.FireFoxConnectOptions.FireFoxP3LocationReticles.Text = "(City: " + P3City + ") (State: " + P3State + ")";
                            }
                            break;
                        case 3:
                            var P4name = CleanInput(a);
                            FireFoxPlayer4Name = P4name;
                            if (FireFoxPlayer4Name != "" && FireFoxPlayer4Name != null)
                            {
                                Globals.FireFoxConnectOptions.FireFoxPLUpdate.Items.Add(P4name);
                                Globals.FireFoxConnectOptions.FireFoxPlayerFourSpawnWeaponsDA.Text = P4name;
                                Globals.FireFoxConnectOptions.FireFoxPlayerFourSpawnWeaponsReticles.Text = P4name;
                                Globals.FireFoxConnectOptions.FireFoxP4StatsRefresh.Text = P4name;
                                Globals.FireFoxConnectOptions.FireFoxP4StatsRefresh.Refresh();
                                Globals.FireFoxConnectOptions.FireFoxDATabP4.Text = P4name;
                                Globals.FireFoxConnectOptions.FireFoxReticlesTabP4.Text = P4name;
                            }
                            if (FireFoxPlayer4Name != "" && FireFoxPlayer4Name != null)
                            {
                                var P4City = FireFoxStatsClass.FireFoxReadStringStats(3, 0x2175E);
                                var P4State = FireFoxStatsClass.FireFoxReadStringStats(3, 0x217F5);
                                Globals.FireFoxConnectOptions.FireFoxP4LocationDA.Text = "(City: " + P4City + ") (State: " + P4State + ")";
                                Globals.FireFoxConnectOptions.FireFoxP4LocationReticles.Text = "(City: " + P4City + ") (State: " + P4State + ")";
                            }
                            break;
                    }
                }
            }

            static string CleanInput(string strIn)
            {
                // Replace invalid characters with empty strings.
                try
                {
                    return Regex.Replace(strIn, @"[^\w\.@-]", "",
                                         RegexOptions.None, TimeSpan.FromSeconds(1.5));
                }
                // If we timeout when replacing invalid characters,
                // we should return Empty.
                catch (RegexMatchTimeoutException)
                {
                    return String.Empty;
                }
            }
        }

        public static class FireFoxCustomSpawns
        {
            public static void FireFoxIfFireBaseChoseExitDIE()
            {
                if (Globals.FireFoxConnectOptions.FireFoxCustomSpawnFireBase.Checked)
                {
                    Globals.FireFoxConnectOptions.FireFoxCustomSpawnDIE.Checked = false;
                }
            }
            public static void FireFoxIfDIEChoseExitFireBase()
            {
                if (Globals.FireFoxConnectOptions.FireFoxCustomSpawnDIE.Checked)
                {
                    Globals.FireFoxConnectOptions.FireFoxCustomSpawnFireBase.Checked = false;
                }
            }

            public static void FireFoxCheckIfXYZEntered()
            {
                if (!Globals.FireFoxConnectOptions.FireFoxXYZSpawnPlus.Checked && !Globals.FireFoxConnectOptions.FireFoxXYZSpawnMinus.Checked)
                {
                    MessageBox.Show("Please Choose Option Plus Or Minus Before Using!");
                    return;
                }
                if (Globals.FireFoxConnectOptions.FireFoxTPValue.Text == "" || Globals.FireFoxConnectOptions.FireFoxTPValue.Text == "0" || Globals.FireFoxConnectOptions.FireFoxTPValue.Text == null)
                {
                    MessageBox.Show("Please Enter A Value To Move Before Using...");
                    return;
                }
            }

            public static void FireFoxXYZMoveX()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                FireFoxCheckIfXYZEntered();
                if (FireFoxAPI2.IsProcessRunning(FireFoxTargetProcessName))
                {
                    var NewCord = Int32.Parse(Globals.FireFoxConnectOptions.FireFoxTPValue.Text);
                    var PlayerX = FireFoxAPI2.ReadFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * FireFoxPlayerID) + 0 + 3560);
                    if (Globals.FireFoxConnectOptions.FireFoxXYZSpawnPlus.Checked)
                    {
                        FireFoxAPI2.WriteFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * FireFoxPlayerID) + 0 + 3560, (float)PlayerX + NewCord);
                    }
                    else
                    {
                        FireFoxAPI2.WriteFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * FireFoxPlayerID) + 0 + 3560, (float)PlayerX - NewCord);
                    }
                }
            }
            public static void FireFoxXYZMoveY()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                FireFoxCheckIfXYZEntered();
                if (FireFoxAPI2.IsProcessRunning(FireFoxTargetProcessName))
                {
                    var NewCord = Int32.Parse(Globals.FireFoxConnectOptions.FireFoxTPValue.Text);
                    var PlayerX = FireFoxAPI2.ReadFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * FireFoxPlayerID) + 0 + 3564);
                    if (Globals.FireFoxConnectOptions.FireFoxXYZSpawnPlus.Checked)
                    {
                        FireFoxAPI2.WriteFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * FireFoxPlayerID) + 0 + 3564, (float)PlayerX + NewCord);
                    }
                    else
                    {
                        FireFoxAPI2.WriteFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * FireFoxPlayerID) + 0 + 3564, (float)PlayerX - NewCord);
                    }
                }
            }
            public static void FireFoxXYZMoveZ()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                FireFoxCheckIfXYZEntered();
                if (FireFoxAPI2.IsProcessRunning(FireFoxTargetProcessName))
                {
                    var NewCord = Int32.Parse(Globals.FireFoxConnectOptions.FireFoxTPValue.Text);
                    var PlayerX = FireFoxAPI2.ReadFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * FireFoxPlayerID) + 0 + 3568);
                    if (Globals.FireFoxConnectOptions.FireFoxXYZSpawnPlus.Checked)
                    {
                        FireFoxAPI2.WriteFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * FireFoxPlayerID) + 0 + 3568, (float)PlayerX + NewCord);
                    }
                    else
                    {
                        FireFoxAPI2.WriteFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * FireFoxPlayerID) + 0 + 3568, (float)PlayerX - NewCord);
                    }
                }
            }

            public static void FireFoxXYZifPlusSelectedKillMinus()
            {
                if (Globals.FireFoxConnectOptions.FireFoxXYZSpawnPlus.Checked)
                {
                    Globals.FireFoxConnectOptions.FireFoxXYZSpawnMinus.Checked = false;
                }
            }
            public static void FireFoxXYZifMinusSelectedKillPlus()
            {
                if (Globals.FireFoxConnectOptions.FireFoxXYZSpawnMinus.Checked)
                {
                    Globals.FireFoxConnectOptions.FireFoxXYZSpawnPlus.Checked = false;
                }
            }

            public static void FireFoxCustomFireBaseSpawnDropDownIndexChanged()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                int Spawn = Globals.FireFoxConnectOptions.FireFoxCustomSpawnsChooseFireBase.SelectedIndex;
                string Value = FireFoxFireBaseCustomSpawn.ElementAt<string>(Spawn);
                string[] FireBaseCustomMapName = Value.Split(new char[4] { ';', ':', '|', ',' });
                float PX = float.Parse(FireBaseCustomMapName[1]);
                float PY = float.Parse(FireBaseCustomMapName[2]);
                float PZ = float.Parse(FireBaseCustomMapName[3]);
                FireFoxTeleportFunction(PX, PY, PZ);
            }
            public static void FireFoxCustomDIESpawnDropDownIndexChanged()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                int Spawn = Globals.FireFoxConnectOptions.FireFoxCustomSpawnsChooseDIE.SelectedIndex;
                string Value = FireFoxDIECustomSpawn.ElementAt<string>(Spawn);
                string[] DIECustomMapName = Value.Split(new char[4] { ';', ':', '|', ',' });
                float PX = float.Parse(DIECustomMapName[1]);
                float PY = float.Parse(DIECustomMapName[2]);
                float PZ = float.Parse(DIECustomMapName[3]);
                FireFoxTeleportFunction(PX, PY, PZ);
            }

            public static void FireFoxTeleportFunction(double x, double y, double z)
            {
                if (FireFoxAPI2.IsProcessRunning(FireFoxTargetProcessName))
                {
                    FireFoxAPI2.WriteFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * FireFoxPlayerID) + 0 + 3560, (float)x);
                    FireFoxAPI2.WriteFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * FireFoxPlayerID) + 0 + 3564, (float)y);
                    FireFoxAPI2.WriteFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * FireFoxPlayerID) + 0 + 3568, (float)z);
                }
            }

            public static void FireFoxTeleportToPlayer()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                if (FireFoxAPI2.IsProcessRunning(FireFoxTargetProcessName))
                {
                    var PlayerX = FireFoxAPI2.ReadFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * FireFoxPlayerID) + 0 + 3560);
                    var PlayerY = FireFoxAPI2.ReadFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * FireFoxPlayerID) + 0 + 3564);
                    var PlayerZ = FireFoxAPI2.ReadFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * FireFoxPlayerID) + 0 + 3568);
                    FireFoxAPI2.WriteFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * 0) + 0 + 3560, (float)PlayerX);
                    FireFoxAPI2.WriteFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * 0) + 0 + 3564, (float)PlayerY);
                    FireFoxAPI2.WriteFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * 0) + 0 + 3568, (float)PlayerZ);
                }
            }

            public static void FireFoxTeleportPlayerToMe()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                if (FireFoxAPI2.IsProcessRunning(FireFoxTargetProcessName))
                {
                    var PlayerX = FireFoxAPI2.ReadFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * 0) + 3560L);
                    var PlayerY = FireFoxAPI2.ReadFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * 0) + 3564L);
                    var PlayerZ = FireFoxAPI2.ReadFloat(FireFoxPlayerCompPtr.ToInt64() + (FireFoxPC_ArraySize_Offset * 0) + 3568L);
                    FireFoxTeleportFunction(PlayerX, PlayerY, PlayerZ);
                }
            }

            public static void FireFoxDIEPresetSpawns()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportDIECombo.SelectedText == "Spawn")
                {
                    FireFoxTeleportFunction(744.556, -351.8875, -33.54857);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportDIECombo.SelectedText == "Nacht")
                {
                    FireFoxTeleportFunction(-70.68573, 735.1465, 1.125);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportDIECombo.SelectedText == "Airplane")
                {
                    FireFoxTeleportFunction(-210.1693, 1580.252, 343.98);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportDIECombo.SelectedText == "Swamp")
                {
                    FireFoxTeleportFunction(-1751.83, 225.7206, -34.31071);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportDIECombo.SelectedText == "Power Room")
                {
                    FireFoxTeleportFunction(1024.632, -706.3374, -255.875);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportDIECombo.SelectedText == "Sniper's Nest")
                {
                    FireFoxTeleportFunction(33.50085, 793.6158, 293.125);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportDIECombo.SelectedText == "Pack-a-punch")
                {
                    FireFoxTeleportFunction(622.7785, -182.1142, -543.875);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportDIECombo.SelectedText == "MB Swamp")
                {
                    FireFoxTeleportFunction(-1100.365, 331.656, -42.21415);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportDIECombo.SelectedText == "MB Spawn")
                {
                    FireFoxTeleportFunction(892.8182, 49.16034, 51.3728);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportDIECombo.SelectedText == "MB Airplane")
                {
                    FireFoxTeleportFunction(192.0121, 2281.86, 220.6327);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportDIECombo.SelectedText == "MB Power Room")
                {
                    FireFoxTeleportFunction(504.4311, -337.5037, -671.875);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportDIECombo.SelectedText == "MB Lab 1")
                {
                    FireFoxTeleportFunction(732.1216, 1886.927, -287.875);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportDIECombo.SelectedText == "MB Lab 2")
                {
                    FireFoxTeleportFunction(-1482.76, 9.853629, -367.875);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportDIECombo.SelectedText == "JAIL")
                {
                    FireFoxTeleportFunction(-1482.76, 9.853629, -367.875);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportDIECombo.SelectedText == "Prison")
                {
                    FireFoxTeleportFunction(176.3642, 599.3618, -671.875);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportDIECombo.SelectedText == "XP Location")
                {
                    FireFoxTeleportFunction(7394.169, 1196.531, 151.5958);
                }
            }
            public static void FireFoxFireBasePresetSpawns()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportFireBaseCombo.SelectedText == "Spawn")
                {
                    FireFoxTeleportFunction(-49317.21, -20191.31, 629.078);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportFireBaseCombo.SelectedText == "Pack-A-Punch")
                {
                    FireFoxTeleportFunction(-48084.69, -20956.31, 641.7819);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportFireBaseCombo.SelectedText == "Teleporter To Firebase")
                {
                    FireFoxTeleportFunction(-49354.88, -21610.11, 957.125);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportFireBaseCombo.SelectedText == "Teleporter To Village")
                {
                    FireFoxTeleportFunction(-132.4821, -12979.64, 7350.016);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportFireBaseCombo.SelectedText == "Aether Reactor By Stamina Up")
                {
                    FireFoxTeleportFunction(1029.424, -15198.33, 7360.125);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportFireBaseCombo.SelectedText == "Aether Reactor By Speed Cola")
                {
                    FireFoxTeleportFunction(-2710.875, -15170.33, 7360.125);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportFireBaseCombo.SelectedText == "Aether Reactor By Juggernog")
                {
                    FireFoxTeleportFunction(-1321.579, -12208.71, 7307.125);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportFireBaseCombo.SelectedText == "Jump Pad 1 To Scorched Defense")
                {
                    FireFoxTeleportFunction(-281.7768, -11382.95, 7220.125);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportFireBaseCombo.SelectedText == "Jump Pad 2 To Scorched Defense")
                {
                    FireFoxTeleportFunction(-1854.24, -15190.62, 7583.125);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportFireBaseCombo.SelectedText == "Jump Pad 3 To Rocky Defence")
                {
                    FireFoxTeleportFunction(-12.33469, -15448.08, 7520.125);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportFireBaseCombo.SelectedText == "Jump Pad 4 To Jungle Defense")
                {
                    FireFoxTeleportFunction(484.0152, -14981.96, 7521.125);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportFireBaseCombo.SelectedText == "Mystery Box Motor Pool")
                {
                    FireFoxTeleportFunction(-2762.776, -14086.43, 7335.146);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportFireBaseCombo.SelectedText == "Mystery Box Barracks")
                {
                    FireFoxTeleportFunction(-1386.353, -15615.28, 7376.114);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportFireBaseCombo.SelectedText == "Mystery Box Planning Offices")
                {
                    FireFoxTeleportFunction(1495.262, -13752.25, 7480.125);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportFireBaseCombo.SelectedText == "Mystery Box Courtyard")
                {
                    FireFoxTeleportFunction(-48808.53, -20536.74, 629.125);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportFireBaseCombo.SelectedText == "Bunny Easter Egg")
                {
                    FireFoxTeleportFunction(40316.16, -60368.24, 1457.68);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportFireBaseCombo.SelectedText == "Ontop Map")
                {
                    FireFoxTeleportFunction(-1984.555, -14055.42, 7807.149);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportFireBaseCombo.SelectedText == "Prison")
                {
                    FireFoxTeleportFunction(-47849.66, -20900.86, 649.125);
                }
                if (Globals.FireFoxConnectOptions.FireFoxTeleportFireBaseCombo.SelectedText == "XP Location")
                {
                    Thread threadingstuff = new Thread(FireFoxTPXPLobbyFireBase);
                    threadingstuff.Start();
                }
            }

            public static void FireFoxTPXPLobbyFireBase()
            {
                for (int i = 0; i < 4; i++)
                {
                    FireFoxTeleportFunction(-80264.98, -50273.89, 0.125);
                    Thread.Sleep(1000);
                }
            }


            public static void FireFoxRefreshCustomSpawnPoints()
            {
                try
                {
                    //Doing Custom Spawns For FIREBASE START//
                    FireFoxFireBaseCustomSpawn.Clear();
                    Globals.FireFoxConnectOptions.FireFoxCustomSpawnsChooseFireBase.Properties.Items.Clear();
                    var FireBaseRefreshList = "Spawn Points\\FireBaseZ\\SpawnPoints.EpicTools";
                    using (StreamReader streamReader = new StreamReader(FireBaseRefreshList))
                    {
                        while (streamReader.Peek() != -1)
                            FireFoxFireBaseCustomSpawn.Add(streamReader.ReadLine());
                    }
                    foreach (Object FireBaseCustomMapAdd in FireFoxFireBaseCustomSpawn)
                    {
                        string SplitTime = FireBaseCustomMapAdd.ToString();
                        string[] FireBaseCustomMapAddFinal = SplitTime.Split(new char[4] { ';', ':', '|', ',' });
                        Globals.FireFoxConnectOptions.FireFoxCustomSpawnsChooseFireBase.Properties.Items.Add(FireBaseCustomMapAddFinal[0]);
                    }
                    //Doing Custom Spawns For FIREBASE END//
                }
                catch
                {
                    XtraMessageBox.Show("Refresing List For FireBase Failed\nThis Could Be Due To Only Saving On FireBase\nIf That Is The Case Just Ignore This Message\nTo Make Message Go Away, Save Custom Point In D.I.E");
                }
                try
                {
                    //Doing Custom Spawns For DIE START//
                    FireFoxDIECustomSpawn.Clear();
                    Globals.FireFoxConnectOptions.FireFoxCustomSpawnsChooseDIE.Properties.Items.Clear();
                    var DIERefreshList = "Spawn Points\\DIE\\SpawnPoints.EpicTools";
                    using (StreamReader streamReader = new StreamReader(DIERefreshList))
                    {
                        while (streamReader.Peek() != -1)
                            FireFoxDIECustomSpawn.Add(streamReader.ReadLine());
                    }
                    foreach (Object DIECustomMapAdd in FireFoxDIECustomSpawn)
                    {
                        string SplitTime = DIECustomMapAdd.ToString();
                        string[] DIECustomMapAddFinal = SplitTime.Split(new char[4] { ';', ':', '|', ',' });
                        Globals.FireFoxConnectOptions.FireFoxCustomSpawnsChooseDIE.Properties.Items.Add(DIECustomMapAddFinal[0]);
                    }
                    //Doing Custom Spawns For DIE END//
                }
                catch
                {
                    MessageBox.Show("Refresing List For D.I.E Failed\nThis Could Be Due To Only Saving On D.I.E\nIf That Is The Case Just Ignore This Message\nTo Make Message Go Away, Save Custom Point In FireBase");
                }
            }

            public static void FireFoxAddCustomSpawnPointButton()
            {
                if (!Globals.FireFoxConnectOptions.FireFoxCustomSpawnDIE.Checked && !Globals.FireFoxConnectOptions.FireFoxCustomSpawnFireBase.Checked)
                {
                    XtraMessageBox.Show("Please Choose A Map To Import Custom Spawn To First...");
                    return;
                }
                if (Globals.FireFoxConnectOptions.FireFoxCustomSpawnName.Text == "NAME" || Globals.FireFoxConnectOptions.FireFoxCustomSpawnName.Text == "" || Globals.FireFoxConnectOptions.FireFoxCustomSpawnName.Text == null)
                {
                    XtraMessageBox.Show("Please Change NAME To A name You Want To Add For Spawn Point First!");
                    return;
                }
                if (!Directory.Exists("Spawn Points"))
                {
                    Directory.CreateDirectory("Spawn Points");
                }
                //FIREBASEZ
                if (Globals.FireFoxConnectOptions.FireFoxCustomSpawnFireBase.Checked)
                {
                    if (!Directory.Exists("Spawn Points\\FireBaseZ"))
                    {
                        Directory.CreateDirectory("Spawn Points\\FireBaseZ");
                    }
                    using (StreamWriter w = File.AppendText("Spawn Points\\FireBaseZ\\SpawnPoints.EpicTools"))
                    {
                        try
                        {
                            byte[] playerCoords = new byte[12];
                            FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + FireFoxPP_Coords, playerCoords, 12, out _);

                            float origxP1 = BitConverter.ToSingle(playerCoords, 0);
                            float origyP1 = BitConverter.ToSingle(playerCoords, 4);
                            float origzP1 = BitConverter.ToSingle(playerCoords, 8);
                            if (origxP1 == 0 && origyP1 == 0 && origzP1 == 0)
                            {
                                XtraMessageBox.Show("Error Grabbing Cords, Please Make Sure You Are Connected To The Tool First!");
                                return;
                            }
                            w.WriteLine(Globals.FireFoxConnectOptions.FireFoxCustomSpawnName.Text + "|" + origxP1 + "|" + origyP1 + "|" + origzP1);
                        }
                        catch (Exception EX)
                        {
                            XtraMessageBox.Show("Error Grabbing Cords, Something Wen't Really Wrong...");
                            XtraMessageBox.Show(EX.Message);
                        }
                    }
                }
                //D.I.E
                if (Globals.FireFoxConnectOptions.FireFoxCustomSpawnDIE.Checked)
                {
                    if (!Directory.Exists("Spawn Points\\DIE"))
                    {
                        Directory.CreateDirectory("Spawn Points\\DIE");
                    }
                    using (StreamWriter w = File.AppendText("Spawn Points\\DIE\\SpawnPoints.EpicTools"))
                    {
                        try
                        {
                            byte[] playerCoords = new byte[12];
                            FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + FireFoxPP_Coords, playerCoords, 12, out _);
                            float origxP1 = BitConverter.ToSingle(playerCoords, 0);
                            float origyP1 = BitConverter.ToSingle(playerCoords, 4);
                            float origzP1 = BitConverter.ToSingle(playerCoords, 8);
                            if (origxP1 == 0 && origyP1 == 0 && origzP1 == 0)
                            {
                                XtraMessageBox.Show("Error Grabbing Cords, Please Make Sure You Are Connected To The Tool First!");
                                return;
                            }
                            w.WriteLine(Globals.FireFoxConnectOptions.FireFoxCustomSpawnName.Text + "|" + origxP1 + "|" + origyP1 + "|" + origzP1);
                        }
                        catch (Exception EX)
                        {
                            XtraMessageBox.Show("Error Grabbing Cords, Something Wen't Really Wrong...");
                            XtraMessageBox.Show(EX.Message);
                        }
                    }
                }
                FireFoxRefreshCustomSpawnPoints();
            }
        }

        public static class FireFoxStatsClass
        {
            public static void FireFoxSendIntStats(int FireFoxclient, uint FireFoxxPos, int FireFoxvalue)
            {
                long FireFoxStatsDLL = FireFoxStats(FireFoxclient);
                long FireFoxChallenge = FireFoxStatsDLL;
                if (Globals.FireFoxConnectOptions.LoginPageUsername.Text == "TrynCatchMe")
                {
                    File.WriteAllBytes("in-game-staters - 4.bin", FireFoxAPI2.ReadBytes(FireFoxChallenge, 0x2197E));
                }
                FireFoxAPI2.WriteInt(FireFoxChallenge + FireFoxxPos, FireFoxvalue);
            }
            public static int FireFoxReadIntStats(int client, uint xPos)
            {
                long StatsDLL = FireFoxStats(client);
                long Challenge = StatsDLL;
                int Value = FireFoxAPI2.ReadInt(Challenge + xPos);
                return Value;
            }
            public static string FireFoxReadStringStats(int FireFoxclient, uint FireFoxxPos)
            {
                long FireFoxStatsDLL = FireFoxStats(FireFoxclient);
                long FireFoxChallenge = FireFoxStatsDLL;
                string FireFoxValue = FireFoxAPI2.ReadString(FireFoxChallenge + FireFoxxPos);
                return FireFoxValue;
            }
            public static long FireFoxStats(int FireFoxindex) // get struc stats
            {
                if (FireFoxAPI2.IsProcessRunning(FireFoxTargetProcessName))
                {
                    long FireFoxPointer = FireFoxGet_ClientT(0) + 0xD1B0;
                    return FireFoxAPI2.ReadInt64(FireFoxPointer) + (0x2197E * FireFoxindex); //(0x24FFD * index)
                }
                return 0;
            }
            public static long FireFoxGet_ClientT(int FireFoxindex) // get pointer client_t
            {
                if (FireFoxAPI2.IsProcessRunning(FireFoxTargetProcessName))
                {
                    return FireFoxAPI2.ReadInt64(FireFoxAPI2.BaseAddress + FireFoxMainCamo) + (FireFoxclientSize * FireFoxindex);
                }
                return 0;
            }
            public static string FireFoxFireFoxReadStringStats(int FireFoxclient, uint FireFoxxPos)
            {
                long FireFoxStatsDLL = FireFoxStats(FireFoxclient);
                long FireFoxChallenge = FireFoxStatsDLL;
                string FireFoxValue = FireFoxAPI2.ReadString(FireFoxChallenge + FireFoxxPos);
                return FireFoxValue;
            }

            public static class FireFoxStatsDDL_Stats // stats intervalles
            {
                public static uint
                FireFoxTotalRounds = 0x19B00, // Int32 -- UPDATED
                FireFoxKills1 = 0x12743, // Uint 16 -- UPDATED 0x1BFF1
                FireFoxKills2 = 0x1E272, // Uint 16 -- UPDATED 0x1C06B
                FireFoxKills3 = 0x1F02A, // Uint 16 -- UPDATED 0x1C06E
                FireFoxKillsElites = 0x1C1A2, // Uint 16 -- UPDATED
                FireFoxKillsElites2 = 0x1C1A2, // Uint 16 -- UPDATED
                FireFoxKillsCritiq = 0x1C450, // Int32 -- UPDATED
                FireFoxKillsCritiq2 = 0x1C450, // Uint 16 -- UPDATED
                FireFoxMaxElimInGame = 0x193B1, // Uint 16
                FireFoxGamesPlayed = 0x17F0D, // Int32 -- UPDATED

                //Reticles Stuff Start //

                //Millstop Reflex
                FireFoxMillStopReticlesUnlock = 0x1759C, //OLD - 0x227B
                //Visiontech 2x
                FireFoxVisiontech2xReticlesUnlock = 0xC01,
                //Kobra Red Dot
                FireFoxKobraRedDotReticlesUnlock = 0x21F2,
                //Quickdot LED
                FireFoxQuickdotLEDReticlesUnlock = 0x1049,
                //Axial Arms
                FireFoxAxialArmsReticlesUnlock = 0x249F,
                //Sillix Holoscout
                FireFoxSillixHoloscoutReticlesUnlock = 0x173E,
                //Microflex LED
                FireFoxMicroflexLEDReticlesUnlock = 0x10D2,
                //Hawksmoor
                FireFoxHawksmoorReticlesUnlock = 0x2304,
                //Royal & Kross 4X
                FireFoxRoyalKrossReticlesUnlock = 0x2528,
                //Susat Multizoom
                FireFoxSusatMultizoomReticlesUnlock = 0xF37,
                //Diamondback Reflex
                FireFoxDiamondbackReflexReticlesUnlock = 0x238D,
                //Snappoint
                FireFoxSnappointReticlesUnlock = 0x115B,
                //Fastpoint Reflex
                FireFoxFastpointReflexReticlesUnlock = 0x2416,
                //Axial Arms 3x
                FireFoxAxialArm3xReticlesUnlock = 0x24A1,
                //Iron Sights
                FireFoxIronSightsReticlesUnlock = 0x104B,
                //Otero Mini Reflex
                FireFoxOteroMiniReflexReticlesUnlock = 0x227D,
                //Reticles Stuff END//
                //Crstals Start //
                //Crystals 1
                FireFoxCrystals1 = 0x829B,
                FireFoxCrystals2 = 0x829F,
                FireFoxCrystals3 = 0x82A3,
                //Crstals End //

                //Revive Challenge?
                FireFoxReviveChallenge = 0x1C708,


                //Weapon Stats

                //XM4
                FireFoxWeaponStatsXM4Kills1 = 0x95B2,
                FireFoxWeaponStatsXM4EliteKills1 = 0x95C4,
                FireFoxWeaponStatsXM4PackedKills1 = 0x95B8,
                FireFoxWeaponStatsXM4CritKills1 = 0x95DF,

                //AK-47
                FireFoxWeaponStatsAK47Kills1 = 0x8562,
                FireFoxWeaponStatsAK47EliteKills1 = 0x8574,
                FireFoxWeaponStatsAK47PackedKills1 = 0x8568,
                FireFoxWeaponStatsAK47CritKills1 = 0x858F,

                //Kraig 6
                FireFoxWeaponStatsKraigKills1 = 0x82AA,
                FireFoxWeaponStatsEliteKills1 = 0x82BC,
                FireFoxWeaponStatsKraigPackedKills1 = 0x82D7,
                FireFoxWeaponStatsKraigCritKills1 = 0x82B0,

                //Reaper of the Undead
                FireFoxDeadOpsChallengeReaperoftheUndead = 0x1C636,

                //Random Dead Ops Shit
                FireFoxDeadOpsArcadeTest1 = 0x1BFE2,


                FireFoxTimePlayed = 0x1C07F;

            }
        }

        public static class FireFoxOffsets
        {
            public static void FireFoxUpdateOffsets()
            {
                var FireFoxGodModeGrab = client.DownloadString("https://epictools.org/ToolFiles/Vars/6EQ4ZUcfbUpa7BPW/S45ZBtVNjJq8SGdK/r3Xg7kfETGwv39V9/God.txt");
                var FireFoxGodModeDecrypt = FireFoxDecryptEncryptVars.Decrypt(FireFoxGodModeGrab);
                FireFoxGodMode = Convert.ToInt32(FireFoxGodModeDecrypt, 16);


                var FireFoxPC_ArraySize_OffsetGrab = client.DownloadString("https://epictools.org/ToolFiles/Vars/6EQ4ZUcfbUpa7BPW/S45ZBtVNjJq8SGdK/r3Xg7kfETGwv39V9/PC_ArraySize_Offset.txt");
                var FireFoxPC_ArraySize_OffsetGrabDecrypt = FireFoxDecryptEncryptVars.Decrypt(FireFoxPC_ArraySize_OffsetGrab);
                FireFoxPC_ArraySize_Offset = Convert.ToInt32(FireFoxPC_ArraySize_OffsetGrabDecrypt, 16);


                var FireFoxPC_NameGrab = client.DownloadString("https://epictools.org/ToolFiles/Vars/6EQ4ZUcfbUpa7BPW/S45ZBtVNjJq8SGdK/r3Xg7kfETGwv39V9/PC_Name.txt");
                var FireFoxPC_NameDecrypt = FireFoxDecryptEncryptVars.Decrypt(FireFoxPC_NameGrab);
                FireFoxPC_Name = Convert.ToInt32(FireFoxPC_NameDecrypt, 16);


                var FireFoxInfraredVisionGrab = client.DownloadString("https://epictools.org/ToolFiles/Vars/6EQ4ZUcfbUpa7BPW/S45ZBtVNjJq8SGdK/r3Xg7kfETGwv39V9/InfraredVision.txt");
                var FireFoxInfraredVisionDecrypt = FireFoxDecryptEncryptVars.Decrypt(FireFoxInfraredVisionGrab);
                FireFoxInfraredVision = Convert.ToInt32(FireFoxInfraredVisionDecrypt, 16);


                var FireFoxPP_CoordsGrab = client.DownloadString("https://epictools.org/ToolFiles/Vars/6EQ4ZUcfbUpa7BPW/S45ZBtVNjJq8SGdK/r3Xg7kfETGwv39V9/PP_Cords.txt");
                var FireFoxPP_CoordsDecrypt = FireFoxDecryptEncryptVars.Decrypt(FireFoxPP_CoordsGrab);
                FireFoxPP_Coords = Convert.ToInt32(FireFoxPP_CoordsDecrypt, 16);


                var FireFoxMainCamoGrab = client.DownloadString("https://epictools.org/ToolFiles/Vars/6EQ4ZUcfbUpa7BPW/S45ZBtVNjJq8SGdK/r3Xg7kfETGwv39V9/MainCamo.txt");
                var FireFoxMainCamoDecrypt = FireFoxDecryptEncryptVars.Decrypt(FireFoxMainCamoGrab);
                FireFoxMainCamo = Convert.ToInt32(FireFoxMainCamoDecrypt, 16);


                var FireFoxXPBaseLevelGrab = client.DownloadString("https://epictools.org/ToolFiles/Vars/6EQ4ZUcfbUpa7BPW/S45ZBtVNjJq8SGdK/r3Xg7kfETGwv39V9/XPBaseLevel.txt");
                var FireFoxXPBaseLevelDecrypt = FireFoxDecryptEncryptVars.Decrypt(FireFoxXPBaseLevelGrab);
                FireFoxXPBaseLevel = Convert.ToInt32(FireFoxXPBaseLevelDecrypt, 16);


                var FireFoxXPBaseLevelFakeGrab = client.DownloadString("https://epictools.org/ToolFiles/Vars/6EQ4ZUcfbUpa7BPW/S45ZBtVNjJq8SGdK/r3Xg7kfETGwv39V9/XPBaseLevelFake.txt");
                var FireFoxXPBaseLevelFakeDecrypt = FireFoxDecryptEncryptVars.Decrypt(FireFoxXPBaseLevelFakeGrab);
                FireFoxXPBaseLevelFake = Convert.ToInt32(FireFoxXPBaseLevelFakeDecrypt, 16);

                var FireFoxXPBaseWeaponGrab = client.DownloadString("https://epictools.org/ToolFiles/Vars/6EQ4ZUcfbUpa7BPW/S45ZBtVNjJq8SGdK/r3Xg7kfETGwv39V9/XPBaseWeapon.txt");
                var FireFoxXPBaseWeaponDecrypt = FireFoxDecryptEncryptVars.Decrypt(FireFoxXPBaseWeaponGrab);
                FireFoxXPBaseWeapon = Convert.ToInt32(FireFoxXPBaseWeaponDecrypt, 16);


                var FireFoxJumpHeightGrab = client.DownloadString("https://epictools.org/ToolFiles/Vars/6EQ4ZUcfbUpa7BPW/S45ZBtVNjJq8SGdK/r3Xg7kfETGwv39V9/JumpHeight.txt");
                var FireFoxJumpHeightDecrypt = FireFoxDecryptEncryptVars.Decrypt(FireFoxJumpHeightGrab);
                FireFoxJumpHeight = Convert.ToInt32(FireFoxJumpHeightDecrypt, 16);


                var FireFoxPlayerBaseGrab = client.DownloadString("https://epictools.org/ToolFiles/Vars/6EQ4ZUcfbUpa7BPW/S45ZBtVNjJq8SGdK/r3Xg7kfETGwv39V9/PlayerBase.txt");
                var FireFoxPlayerBaseDecrypt = FireFoxDecryptEncryptVars.Decrypt(FireFoxPlayerBaseGrab);
                var FireFoxPlayerBaseInt = Int64.Parse(FireFoxPlayerBaseDecrypt);
                FireFoxPlayerBase = (IntPtr)FireFoxPlayerBaseInt;


                var FireFoxPlayerBase2Grab = client.DownloadString("https://epictools.org/ToolFiles/Vars/6EQ4ZUcfbUpa7BPW/S45ZBtVNjJq8SGdK/r3Xg7kfETGwv39V9/PlayerBase2.txt");
                var FireFoxPlayerBase2Decrypt = FireFoxDecryptEncryptVars.Decrypt(FireFoxPlayerBase2Grab);
                FireFoxPlayerBase2 = Convert.ToInt32(FireFoxPlayerBase2Decrypt, 16);
            }
        }

        public static class FireFoxDecryptEncryptVars
        {
            public static string Encrypt(string plainText)
            {
                byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
                byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash2, Encoding.ASCII.GetBytes(SaltKey2)).GetBytes(256 / 8);
                var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
                var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey2));

                byte[] cipherTextBytes;

                using (var memoryStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        cipherTextBytes = memoryStream.ToArray();
                        cryptoStream.Close();
                    }
                    memoryStream.Close();
                }
                return Convert.ToBase64String(cipherTextBytes);
            }

            public static string Decrypt(string encryptedText)
            {
                byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);
                byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash2, Encoding.ASCII.GetBytes(SaltKey2)).GetBytes(256 / 8);
                var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

                var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey2));
                var memoryStream = new MemoryStream(cipherTextBytes);
                var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                byte[] plainTextBytes = new byte[cipherTextBytes.Length];

                int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                memoryStream.Close();
                cryptoStream.Close();
                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
            }
        }

        public static class FireFoxUpdatePlayersInfo
        {
            public static void FireFoxUpdatePlayerNames()
            {
                if (Globals.FireFoxConnectOptions.FireFoxPLUpdate.SelectedIndex == 0)
                {
                    FireFoxPlayerID = 0;
                    FireFoxPlayerName = (string)Globals.FireFoxConnectOptions.FireFoxPLUpdate.SelectedValue;

                }
                else if (Globals.FireFoxConnectOptions.FireFoxPLUpdate.SelectedIndex == 1)
                {
                    FireFoxPlayerID = 1;
                    FireFoxPlayerName = (string)Globals.FireFoxConnectOptions.FireFoxPLUpdate.SelectedValue;
                }
                else if (Globals.FireFoxConnectOptions.FireFoxPLUpdate.SelectedIndex == 2)
                {
                    FireFoxPlayerID = 2;
                    FireFoxPlayerName = (string)Globals.FireFoxConnectOptions.FireFoxPLUpdate.SelectedValue;
                }
                else if (Globals.FireFoxConnectOptions.FireFoxPLUpdate.SelectedIndex == 3)
                {
                    FireFoxPlayerID = 3;
                    FireFoxPlayerName = (string)Globals.FireFoxConnectOptions.FireFoxPLUpdate.SelectedValue;
                }
            }
        }

        public static class FireFoxAllClientOptions
        {
            public static void FireFoxAllGodOn()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                Globals.FireFoxConnectOptions.FireFoxGodOff.ForeColor = System.Drawing.Color.WhiteSmoke;
                Globals.FireFoxConnectOptions.FireFoxGodOn.ForeColor = System.Drawing.Color.Green;
                for (int i = 0; i < 4; i++)
                {
                    FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * i) + FireFoxGodMode, 0xA0, 1L, out _); // enables godmode
                }
            }

            public static void FireFoxAllGodOff()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                Globals.FireFoxConnectOptions.FireFoxGodOff.ForeColor = System.Drawing.Color.Green;
                Globals.FireFoxConnectOptions.FireFoxGodOn.ForeColor = System.Drawing.Color.WhiteSmoke;
                for (int i = 0; i < 4; i++)
                {
                    FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * i) + FireFoxGodMode, 0x20, 1L, out _); // enables godmode
                }
            }

            public static void FireFoxAllInstantKillEnable()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                Globals.FireFoxConnectOptions.FireFoxInstantKillOff.ForeColor = System.Drawing.Color.WhiteSmoke;
                Globals.FireFoxConnectOptions.FireFoxInstantKillOn.ForeColor = System.Drawing.Color.Green;
                if (FireFoxInstantKillZombiesHasBeenEnabled == false)
                {
                    FireFoxInstantKillZombiesToggle = true;
                    FireFoxClientsRapidFireEnable.DoWork += new System.ComponentModel.DoWorkEventHandler(FireFoxAllInstantKill_DoWork);
                    FireFoxClientsRapidFireEnable.RunWorkerAsync();
                    FireFoxInstantKillZombiesHasBeenEnabled = true;
                }
                else
                {
                    FireFoxInstantKillZombiesToggle = true;
                }
            }

            public static void FireFoxAllInstantKillDisable()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                Globals.FireFoxConnectOptions.FireFoxInstantKillOff.ForeColor = System.Drawing.Color.Green;
                Globals.FireFoxConnectOptions.FireFoxInstantKillOn.ForeColor = System.Drawing.Color.WhiteSmoke;
                FireFoxInstantKillZombiesToggle = false;
            }

            public static void FireFoxAllInstantKill_DoWork(object sender, DoWorkEventArgs e)
            {
                IntPtr intPtr;
                while (FireFoxInstantKillZombiesToggle == true)
                {
                    Thread.Sleep(100);
                    for (int j = 0; j < 90; j++)
                    {
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxZMBotListBase + 1528 * j + 920, 1, 4L, out intPtr);
                        FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxZMBotListBase + 1528 * j + 924, 1, 4L, out intPtr);
                    }
                    FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + 3686, new byte[1], 1L, out intPtr);
                }
            }

            public static void FireFoxAllTPZombiesOn()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                Globals.FireFoxConnectOptions.FireFoxTPZombiesOff.ForeColor = System.Drawing.Color.WhiteSmoke;
                Globals.FireFoxConnectOptions.FireFoxTPZombiesOn.ForeColor = System.Drawing.Color.Green;
                DialogResult dialogResult = MessageBox.Show("Are You On OutBreak (MAP)?", "Is The Current Map OutBreak?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DialogResult dialogResult2 = MessageBox.Show("Would You Like To TP Dogs On Ground Or In Air\nYes = Ground\nNo = In Air", "Would You Like To TP Dogs On Ground Or In Air?", MessageBoxButtons.YesNo);
                    if (dialogResult2 == DialogResult.Yes)
                    {
                        FireFoxTPDogsOnground = true;
                    }
                    else if (dialogResult2 == DialogResult.No)
                    {
                        FireFoxTPDogsOnground = false;
                    }
                    FireFoxTPDogsSeperate = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    FireFoxTPDogsSeperate = false;
                }
                byte[] playerCoords = new byte[12];
                FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxPlayerPedPtr + FireFoxPP_Coords, playerCoords, 12, out _);
                FireFoxorigx = BitConverter.ToSingle(playerCoords, 0);
                FireFoxorigy = BitConverter.ToSingle(playerCoords, 4);
                FireFoxorigz = BitConverter.ToSingle(playerCoords, 8);
                if (FireFoxAllClientTPEnabledPreviously == false)
                {
                    FireFoxTurnOnFreezeZombies = true;
                    FireFoxAllClientTPEnabledPreviously = true;
                    FireFoxAllClientTPZMBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(FireFoxAllTPZombies_DoWork);
                    FireFoxAllClientTPZMBGWorker.RunWorkerAsync();
                }
                else
                {
                    FireFoxTurnOnFreezeZombies = true;
                }
            }
            public static void FireFoxAllTPZombiesOff()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                Globals.FireFoxConnectOptions.FireFoxTPZombiesOff.ForeColor = System.Drawing.Color.Green;
                Globals.FireFoxConnectOptions.FireFoxTPZombiesOn.ForeColor = System.Drawing.Color.WhiteSmoke;
                FireFoxTurnOnFreezeZombies = false;
                FireFoxAllClientTPEnabledPreviously = false;
            }
            public static void FireFoxAllTPZombies_DoWork(object sender, DoWorkEventArgs e)
            {
                IntPtr intPtr;
                while (FireFoxTurnOnFreezeZombies == true)
                {
                    Thread.Sleep(100);
                    Vector3 updatedPlayerPos2;
                    FireFoxupdatedPlayerPos = new Vector3((float)Math.Round(FireFoxorigx, 4), (float)Math.Round(FireFoxorigy, 4), (float)Math.Round(FireFoxorigz, 4));
                    if (FireFoxTPDogsOnground == true)
                    {
                        updatedPlayerPos2 = new Vector3((float)Math.Round(FireFoxorigx, 4), (float)Math.Round(FireFoxorigy + 200, 4), (float)Math.Round(FireFoxorigz, 4));
                    }
                    else
                    {
                        updatedPlayerPos2 = new Vector3((float)Math.Round(FireFoxorigx, 4), (float)Math.Round(FireFoxorigy + 200, 4), (float)Math.Round(FireFoxorigz + 150, 4));
                    }
                    for (int j = 0; j < 90; j++)
                    {
                        byte[] ZMByte = new byte[6];
                        FireFoxAPI1.ReadProcessMemory(FireFoxhProc, FireFoxZMBotListBase + (1528 * j) + 0x68, ZMByte, 12, out _);
                        int ZMType = BitConverter.ToInt32(ZMByte, 0);
                        if (FireFoxTPDogsSeperate == true)
                        {
                            if (ZMType == 128)
                            {
                                FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxZMBotListBase + 1528 * j + 724, FireFoxupdatedPlayerPos, 12, out intPtr);
                            }
                            if (ZMType == 129)
                            {
                                FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxZMBotListBase + 1528 * j + 724, updatedPlayerPos2, 12, out intPtr);
                            }
                        }
                        else
                        {
                            FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxZMBotListBase + 1528 * j + 724, FireFoxupdatedPlayerPos, 12, out intPtr);
                        }
                    }
                }
            }

            public static void FireFoxAllCritsOn()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                Globals.FireFoxConnectOptions.FireFoxCritKillsOff.ForeColor = System.Drawing.Color.WhiteSmoke;
                Globals.FireFoxConnectOptions.FireFoxCritKillsOn.ForeColor = System.Drawing.Color.Green;
                if (FireFoxCriticalKillsHasBeenEnabled == false)
                {
                    FireFoxTurnOnCrits = true;
                    FireFoxAllClientCritKillsBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(FireFoxAllCriticalKills_DoWork);
                    FireFoxAllClientCritKillsBGWorker.RunWorkerAsync();
                    FireFoxCriticalKillsHasBeenEnabled = true;
                }
                else
                {
                    FireFoxTurnOnCrits = true;
                }
            }
            public static void FireFoxAllCritsOff()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                Globals.FireFoxConnectOptions.FireFoxCritKillsOff.ForeColor = System.Drawing.Color.Green;
                Globals.FireFoxConnectOptions.FireFoxCritKillsOn.ForeColor = System.Drawing.Color.WhiteSmoke;
                FireFoxTurnOnCrits = false;
            }

            public static void FireFoxAllCriticalKills_DoWork(object sender, DoWorkEventArgs e)
            {
                while (FireFoxTurnOnCrits == true)
                {
                    Thread.Sleep(100);
                    for (int i = 0; i < 4; i++)
                    {
                        FireFox_memory.Write(false, -1, FireFoxbaseAddress + FireFoxPlayerBase2, (IntPtr)(FireFoxPC_ArraySize_Offset * i) + FireFoxCritKill7);
                    }
                }
            }

            public static void FireFoxAllUnlimitedAmmoOn()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                Globals.FireFoxConnectOptions.FireFoxUnlimitedAmmoOff.ForeColor = System.Drawing.Color.WhiteSmoke;
                Globals.FireFoxConnectOptions.FireFoxUnlimitedAmmoOn.ForeColor = System.Drawing.Color.Green;
                if (FireFoxUnlimitedAmmoHasBeenEnabled == false)
                {
                    FireFoxUnlimitedAmmoToggle = true;
                    FireFoxAllClientUnlimitedAmmoBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(FireFoxAllUnlimitedAmmo_DoWork);
                    FireFoxAllClientUnlimitedAmmoBGWorker.RunWorkerAsync();
                    FireFoxUnlimitedAmmoHasBeenEnabled = true;
                }
                else
                {
                    FireFoxUnlimitedAmmoToggle = true;
                }
            }
            public static void FireFoxAllUnlimitedAmmoOff()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                Globals.FireFoxConnectOptions.FireFoxUnlimitedAmmoOff.ForeColor = System.Drawing.Color.Green;
                Globals.FireFoxConnectOptions.FireFoxUnlimitedAmmoOn.ForeColor = System.Drawing.Color.WhiteSmoke;
                FireFoxUnlimitedAmmoToggle = false;
            }
            public static void FireFoxAllUnlimitedAmmo_DoWork(object sender, DoWorkEventArgs e)
            {
                while (FireFoxUnlimitedAmmoToggle == true)
                {

                    Thread.Sleep(100);
                    for (int i = 1; i < 6; i++)
                    {
                        FireFox_memory.Write(false, 69, FireFoxbaseAddress + FireFoxPlayerBase2, (IntPtr)(FireFoxPC_ArraySize_Offset * 0) + FireFoxAmmo + (i * 0x4));
                    }
                    for (int i = 1; i < 6; i++)
                    {
                        FireFox_memory.Write(false, 69, FireFoxbaseAddress + FireFoxPlayerBase2, (IntPtr)(FireFoxPC_ArraySize_Offset * 1) + FireFoxAmmo + (i * 0x4));
                    }
                    for (int i = 1; i < 6; i++)
                    {
                        FireFox_memory.Write(false, 69, FireFoxbaseAddress + FireFoxPlayerBase2, (IntPtr)(FireFoxPC_ArraySize_Offset * 2) + FireFoxAmmo + (i * 0x4));
                    }
                    for (int i = 1; i < 6; i++)
                    {
                        FireFox_memory.Write(false, 69, FireFoxbaseAddress + FireFoxPlayerBase2, (IntPtr)(FireFoxPC_ArraySize_Offset * 3) + FireFoxAmmo + (i * 0x4));
                    }
                    FireFox_memory.Write(false, -1, FireFoxbaseAddress + FireFoxPlayerBase2, (IntPtr)(FireFoxPC_ArraySize_Offset * 0) + FireFoxCritKill8);
                    FireFox_memory.Write(false, -1, FireFoxbaseAddress + FireFoxPlayerBase2, (IntPtr)(FireFoxPC_ArraySize_Offset * 1) + FireFoxCritKill8);
                    FireFox_memory.Write(false, -1, FireFoxbaseAddress + FireFoxPlayerBase2, (IntPtr)(FireFoxPC_ArraySize_Offset * 2) + FireFoxCritKill8);
                    FireFox_memory.Write(false, -1, FireFoxbaseAddress + FireFoxPlayerBase2, (IntPtr)(FireFoxPC_ArraySize_Offset * 3) + FireFoxCritKill8);
                }
            }

            public static void FireFoxAllClientsInfraredVisionOn()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                Globals.FireFoxConnectOptions.FireFoxInfraredOff.ForeColor = System.Drawing.Color.WhiteSmoke;
                Globals.FireFoxConnectOptions.FireFoxInfraredOn.ForeColor = System.Drawing.Color.Green;
                for (int i = 0; i < 4; i++)
                {
                    FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * i) + FireFoxInfraredVision, 0x10, 1L, out _);
                }
            }
            public static void FireFoxAllClientsInfraredVisionOff()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                Globals.FireFoxConnectOptions.FireFoxInfraredOff.ForeColor = System.Drawing.Color.Green;
                Globals.FireFoxConnectOptions.FireFoxInfraredOn.ForeColor = System.Drawing.Color.WhiteSmoke;
                for (int i = 0; i < 4; i++)
                {
                    FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * i) + FireFoxInfraredVision, 0x0, 1L, out _);
                }
            }

            public static void FireFoxAllClientsRapidFireOn()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                Globals.FireFoxConnectOptions.FireFoxRapidFireOff.ForeColor = System.Drawing.Color.WhiteSmoke;
                Globals.FireFoxConnectOptions.FireFoxRapidFireOn.ForeColor = System.Drawing.Color.Green;
                if (FireFoxRapidFireHasBeenEnabled == false)
                {
                    FireFoxTurnOnRapidFire = true;
                    FireFoxAllClientRapidFireBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(FireFoxAllRapidFire_DoWork);
                    FireFoxAllClientRapidFireBGWorker.RunWorkerAsync();
                    FireFoxRapidFireHasBeenEnabled = true;
                }
                else
                {
                    FireFoxTurnOnRapidFire = true;
                }
            }
            public static void FireFoxAllClientsRapidFireOff()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                Globals.FireFoxConnectOptions.FireFoxRapidFireOff.ForeColor = System.Drawing.Color.Green;
                Globals.FireFoxConnectOptions.FireFoxRapidFireOn.ForeColor = System.Drawing.Color.WhiteSmoke;
                FireFoxTurnOnRapidFire = false;
            }

            public static void FireFoxAllRapidFire_DoWork(object sender, DoWorkEventArgs e)
            {
                while (FireFoxTurnOnRapidFire == true)
                {

                    Thread.Sleep(100);
                    if (KeyUtils.GetKeyDown(0x1))
                    {
                        FireFoxSingleClientOptions.FireFoxEnableRapidFire(0);
                    }
                }
            }
        }

        public static class FireFoxSingleClientOptions
        {
            public static void FireFoxClientGodOn()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * FireFoxPlayerID) + FireFoxGodMode, 0xA0, 1L, out _); // enables godmode
            }
            public static void FireFoxClientGodOff()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * FireFoxPlayerID) + FireFoxGodMode, 0x20, 1L, out _); // Disables godmode
            }
            public static void FireFoxClientInfraredOn()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * FireFoxPlayerID) + FireFoxInfraredVision, 0x10, 1L, out _);
            }
            public static void FireFoxClientInfraredOff()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * FireFoxPlayerID) + FireFoxInfraredVision, 0x0, 1L, out _);

            }
            public static void FireFoxClientRapidFireOn()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                if (FireFoxPlayerID == 0)
                {
                    FireFoxRapidFireEnabledP1 = true;
                }
                if (FireFoxPlayerID == 1)
                {
                    FireFoxRapidFireEnabledP2 = true;
                }
                if (FireFoxPlayerID == 2)
                {
                    FireFoxRapidFireEnabledP3 = true;
                }
                if (FireFoxPlayerID == 3)
                {
                    FireFoxRapidFireEnabledP4 = true;
                }
                if (FireFoxRapidFireAlreadyEnabled == false)
                {
                    FireFoxClientsRapidFireEnable.DoWork += new System.ComponentModel.DoWorkEventHandler(FireFoxClientsRapidFireEnable_DoWork);
                    FireFoxClientsRapidFireEnable.RunWorkerAsync();
                }
                FireFoxRapidFireAlreadyEnabled = true;
            }
            public static void FireFoxClientRapidFireOff()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                if (FireFoxPlayerID == 0)
                {
                    FireFoxRapidFireEnabledP1 = false;
                }
                if (FireFoxPlayerID == 1)
                {
                    FireFoxRapidFireEnabledP2 = false;
                }
                if (FireFoxPlayerID == 2)
                {
                    FireFoxRapidFireEnabledP3 = false;
                }
                if (FireFoxPlayerID == 3)
                {
                    FireFoxRapidFireEnabledP4 = false;
                }
                if (FireFoxRapidFireAlreadyDisabled == false)
                {
                    FireFoxInstantKillAllClientsBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(FireFoxClientsRapidFireDisable_DoWork);
                    FireFoxInstantKillAllClientsBGWorker.RunWorkerAsync();
                }
                FireFoxRapidFireAlreadyDisabled = true;
            }

            public static void FireFoxClientsRapidFireEnable_DoWork(object sender, DoWorkEventArgs e)
            {
                while (true)
                {
                    Thread.Sleep(100);
                    if (FireFoxRapidFireEnabledP1)
                    {
                        FireFoxEnableRapidFire(0);
                    }
                    if (FireFoxRapidFireEnabledP2)
                    {
                        FireFoxEnableRapidFire(1);
                    }
                    if (FireFoxRapidFireEnabledP3)
                    {
                        FireFoxEnableRapidFire(2);
                    }
                    if (FireFoxRapidFireEnabledP4)
                    {
                        FireFoxEnableRapidFire(3);
                    }
                }
            }

            public static void FireFoxClientsRapidFireDisable_DoWork(object sender, DoWorkEventArgs e)
            {
                while (true)
                {
                    Thread.Sleep(100);
                    if (FireFoxRapidFireEnabledP1 == false)
                    {
                        FireFoxDisableRapidFire(0);
                    }
                    if (FireFoxRapidFireEnabledP2 == false)
                    {
                        FireFoxDisableRapidFire(1);
                    }
                    if (FireFoxRapidFireEnabledP3 == false)
                    {
                        FireFoxDisableRapidFire(2);
                    }
                    if (FireFoxRapidFireEnabledP4 == false)
                    {
                        FireFoxDisableRapidFire(3);
                    }
                }
            }

            public static void FireFoxEnableRapidFire(int PID)
            {
                FireFox_memory.Write(false, -1, FireFoxbaseAddress + FireFoxPlayerBase2, (IntPtr)(FireFoxPC_ArraySize_Offset * PID) + FireFoxRapidFire1);
                FireFox_memory.Write(false, -1, FireFoxbaseAddress + FireFoxPlayerBase2, (IntPtr)(FireFoxPC_ArraySize_Offset * PID) + FireFoxRapidFire2);
            }
            public static void FireFoxDisableRapidFire(int PID)
            {
                FireFox_memory.Write(false, 0, FireFoxbaseAddress + FireFoxPlayerBase2, (IntPtr)(FireFoxPC_ArraySize_Offset * PID) + FireFoxRapidFire1);
                FireFox_memory.Write(false, 0, FireFoxbaseAddress + FireFoxPlayerBase2, (IntPtr)(FireFoxPC_ArraySize_Offset * PID) + FireFoxRapidFire2);
            }
            public static void FireFoxDisableGunFunctions(int PID)
            {
                FireFox_memory.Write(false, 1000000, FireFoxbaseAddress + FireFoxPlayerBase2, (IntPtr)(FireFoxPC_ArraySize_Offset * PID) + FireFoxRapidFire1);
                FireFox_memory.Write(false, 1000000, FireFoxbaseAddress + FireFoxPlayerBase2, (IntPtr)(FireFoxPC_ArraySize_Offset * PID) + FireFoxRapidFire2);
            }
            public static void FireFoxSetLobbyJumpHeight(int PID, string HeightValue)
            {
                int JheightValue = Int32.Parse(HeightValue);
                if (FireFoxAPI2.IsProcessRunning(FireFoxTargetProcessName))
                {
                    long fJump = (FireFoxAPI2.ReadInt64(FireFoxAPI2.BaseAddress + FireFoxJumpHeight + (0xD40 * PID))) + 0x130;
                    FireFoxAPI2.WriteFloat(fJump, Convert.ToSingle(JheightValue));
                }
            }
            public static void FireFoxSetLobbyRunSpeed(int PID, string SpeedValue)
            {
                if (FireFoxAPI2.IsProcessRunning(FireFoxTargetProcessName))
                {
                    int SpeedM = Int32.Parse(SpeedValue);
                    long RunSpeed = (FireFoxAPI2.ReadInt64(FireFoxAPI2.BaseAddress + FireFoxPlayerBase2) + (FireFoxPC_ArraySize_Offset * PID) + 0x5C60);
                    FireFoxAPI2.WriteFloat(RunSpeed, Convert.ToSingle(SpeedM));
                }
            }
            public static void FireFoxClientDisable()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                FireFoxDisableRapidFire(FireFoxPlayerID);
                FireFoxSetLobbyJumpHeight(FireFoxPlayerID, "75");
                FireFoxSetLobbyRunSpeed(FireFoxPlayerID, "1");
            }
            public static void FireFoxClientEnable()
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                FireFoxDisableGunFunctions(FireFoxPlayerID);
                FireFoxSetLobbyJumpHeight(FireFoxPlayerID, "0");
                FireFoxSetLobbyRunSpeed(FireFoxPlayerID, "0");
            }
            public static void FireFoxSetCash(int Amount)
            {
                if (FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                FireFoxAPI1.WriteProcessMemory(FireFoxhProc, FireFoxPlayerCompPtr + (FireFoxPC_ArraySize_Offset * FireFoxPlayerID) + FireFoxPC_Points, Amount, 4, out _);
            }
        }
    }
}
