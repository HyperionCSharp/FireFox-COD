using DevExpress.XtraEditors;
using FireFoxAPI1One;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFox.Dependencies
{
    class Weapons
    {
        public static class Globals
        {
            public static Firefox FireFoxWeaponOptions;
        }
        public static class FireFoxWeaponIDs
        {
            // --------------------------------------------//
            //               Assult Rifles
            // --------------------------------------------//
            //XM4 Regular
            public static string WeaponXM4 = "66";
            //XM4 Pack
            public static string WeaponXM4PAP = "318";
            //AK-47 Regular
            public static string WeaponAK47 = "8";
            //AK-47 Pack
            public static string WeaponAK47PAP = "331";
            //Krigz 6
            public static string WeaponKrig6 = "16";
            //Krig 6 Pack
            public static string WeaponKrig6PAP = "301";
            //QBZ-83
            public static string WeaponQBZ83 = "62";
            //QBZ-83 Pack
            public static string WeaponQBZ83PAP = "332";
            //FFAR 1
            public static string WeaponFFAR1 = "40";
            //FFAR 1 Pack
            public static string WeaponFFAR1PAP = "334";
            //Groza
            public static string WeaponGroza = "61";
            //Groza Pack
            public static string WeaponGrozaPAP = "366";

            // --------------------------------------------//
            //               Sub Machine Guns
            // --------------------------------------------//

            //MP5
            public static string WeaponMP5 = "50";
            //MP5 Pack
            public static string WeaponMP5PAP = "394";
            //Milano 821
            public static string WeaponMilano821 = "71";
            //Milano 821 Pack
            public static string WeaponMilano821PAP = "384";
            //AK-74u
            public static string WeaponAk74u = "54";
            //AK-74u Pack
            public static string WeaponAk74uPAP = "421";
            //KSP 45
            public static string WeaponKSP45 = "25";
            //KSP 45 Pack
            public static string WeaponKSP45PAP = "411";
            //Bullfrog
            public static string WeaponBullfrog = "20";
            //Bullfrog Pack
            public static string WeaponBullfrogPAP = "349";
            //Mac-10
            public static string WeaponMac10 = "56";
            //Mac-10 Pack
            public static string WeaponMac10PAP = "423";

            // --------------------------------------------//
            //             Tactical Rifles
            // --------------------------------------------//

            //Type 63
            public static string WeaponType63 = "43";
            //Type 63 Pack
            public static string WeaponType63PAP = "396";
            //M16
            public static string WeaponM16 = "47";
            //M16 Pack
            public static string WeaponM16PAP = "418";
            //AUG
            public static string WeaponAUG = "46";
            //AUG Pack
            public static string WeaponAUGPAP = "279";
            //DMR 14
            public static string WeaponDMR14 = "42";
            //DMR 14 Pack
            public static string WeaponDMR14PAP = "309";

            // --------------------------------------------//
            //               Light Machine Guns
            // --------------------------------------------//

            //Stoner 63
            public static string WeaponStoner63 = "5";
            //Stoner 63 Pack
            public static string WeaponStoner63PAP = "367";
            //RPD
            public static string WeaponRPD = "57";
            //RPD Pack
            public static string WeaponRPDPAP = "414";
            //M60
            public static string WeaponM60 = "75";
            //M60 Pack
            public static string WeaponM60PAP = "329";

            // --------------------------------------------//
            //                 Sniper Rifles
            // --------------------------------------------//

            //Pelington 703
            public static string WeaponPelington703 = "39";
            //Pelington 703 Pack
            public static string WeaponPelington703PAP = "356";
            //LW3-Tundra
            public static string WeaponLW3Tundra = "58";
            //LW3-Tundra Pack
            public static string WeaponLW3TundraPAP = "298";
            //M82
            public static string WeaponM82 = "7";
            //M82 Pack
            public static string WeaponM82PAP = "326";

            // --------------------------------------------//
            //                    Pistols 
            // --------------------------------------------//

            //1911
            public static string Weapon1911 = "22";
            //1911 Pack
            public static string Weapon1911PAP = "306";
            //Magnum
            public static string WeaponMagnum = "27";
            //Magnum Pack
            public static string WeaponMagnumPAP = "297";
            //Diamatti
            public static string WeaponDiamatti = "35";
            //Diamatti Pack
            public static string WeaponDiamattiPAP = "439";

            // --------------------------------------------//
            //                    ShotGuns 
            // --------------------------------------------//

            //Hauer 77
            public static string WeaponHauer77 = "44";
            //Hauer 77 Pack
            public static string WeaponHauer77PAP = "345";
            //Gallo SA12
            public static string WeaponGalloSA12 = "64";
            //Gallo SA12 Pack
            public static string WeaponGalloSA12PAP = "438";
            //Street Sweeper
            public static string WeaponStreetSweeper = "73";
            //Street Sweeper Pack
            public static string WeaponStreetSweeperPAP = "271";

            // --------------------------------------------//
            //                    Launchers 
            // --------------------------------------------//

            //Cigma 2
            public static string WeaponCigma2 = "29";
            //Cigma 2 Pack
            public static string WeaponCigma2PAP = "355";
            //RPG-7
            public static string WeaponRPG7 = "15";
            //RPG-7 Pack
            public static string WeaponRPG7PAP = "319";

            // --------------------------------------------//
            //                    Melee 
            // --------------------------------------------//

            //Knife
            public static string WeaponKnife = "18";
            //Knife Pack
            public static string WeaponKnifePAP = "432";
            //Sledge Hammer
            public static string WeaponSledgeHammer = "34";
            //Sledge Hammer Pack
            public static string WeaponSledgeHammerPAP = "387";
            //Wakizashi
            public static string WeaponWakizashi = "38";
            //Wakizashi PAP
            public static string WeaponWakizashiPAP = "348";

            // --------------------------------------------//
            //                    Special 
            // --------------------------------------------//

            //M79
            public static string WeaponM79 = "13";
            //M79 Pack
            public static string WeaponM79PAP = "403";

            // --------------------------------------------//
            //               NEW DLC WEAPONS 
            // --------------------------------------------//

            //FARA 83
            public static string WeaponFARA83 = "40";
            //FARA 83 Pack
            public static string WeaponFARA83PAP = "372";
            //LC 10
            public static string WeaponLC10 = "53";
            //LC 10 Pack
            public static string WeaponLC10PAP = "295";
            //R1 Shadowhunter Crossbow
            public static string WeaponR1ShadowhunterCrossbow = "10";
            //R1 Shadowhunter Crossbow Pack
            public static string WeaponR1ShadowhunterCrossbowPAP = "303";
            //Machete
            public static string WeaponMachete = "14";
            //Machete Pack
            public static string WeaponMachetePAP = "402";
            //Ballistic Knife 
            public static string WeaponBallisticKnife = "31";
            //Ballistic Knife Pack
            public static string WeaponBallisticKnifPAP = "344";
            //PPSh-41
            public static string WeaponPPSh41 = "59";
            public static string WeaponPPSh41PAP = "313";
            //ZRG 20mm
            public static string WeaponZRGmm = "63";
            public static string WeaponZRGmmEPAP = "294";
            //Swiss K31
            public static string WeaponSwissK31 = "36";
            public static string WeaponSwissK31PAP = "381";
            //CARV.2
            public static string WeaponCARV2 = "4";
            public static string WeaponCARV2PAP = "320";
            //E-Tool
            public static string WeaponETool = "6";
            public static string WeaponETool2PAP = "405";
            // --------------------------------------------//
            //              Wonder Weapon + More
            // --------------------------------------------//
            //Discordian Disruptor --> WONDER WEAPON
            public static string WeaponWWPlusMoreDiscordianDisruptor = "282";
            //D.I.E ShockWave --> WONDER WEAPON
            public static string WeaponWWPlusMoreShockWave = "33";
            //Die Nova-5 --> WONDER WEAPON
            public static string WeaponWWPlusMoreNova = "285";
            //Die Electro --> WONDER WEAPON
            public static string WeaponWWPlusMoreElectro = "398";
            //Die Cryo --> WONDER WEAPON
            public static string WeaponWWPlusMoreCryo = "407";
            //Die Thermo --> WONDER WEAPON
            public static string WeaponWWPlusMoreThermo = "419";
            //Gunship BUGGY WEAPON
            public static string WeaponWWPlusMoreGunship = "76";
            //Chopper Gunner BUGGY WEAPON
            public static string WeaponWWPlusMoreChopperGunner = "91";
            //Tomahawk
            public static string WeaponWWPlusMoreTomahawk = "19";
            //Monkey Bomb
            public static string WeaponWWPlusMoreMonkeyBomb = "72";
            //El Slasher
            public static string WeaponWWPlusMoreElSlasher = "402";
            //Secret Kiss
            public static string WeaponWWPlusMoreSecretKiss = "307";
            //Cruise Missle BUGGY WEAPON
            public static string WeaponWWPlusMoreCruiseMissle = "145";
            //Essence Trap (Grenade)
            public static string WeaponWWPlusMoreEssenceTrap = "342";
            //Claymore
            public static string WeaponWWPlusMoreClaymore = "425";
            //Coal
            public static string WeaponWWPlusMoreCoal = "424";
            //Molotov
            public static string WeaponWWPlusMoreMolotov = "55";
            //Shock Charge
            public static string WeaponWWPlusMoreShockCharge = "379";
            //Trophy System
            public static string WeaponWWPlusMoreTrophySystem = "205";
            //Flashbang
            public static string WeaponWWPlusMoreFlashbang = "199";
            //Thermite
            public static string WeaponWWPlusMoreThermite = "147";
            //Snowball
            public static string WeaponWWPlusMoreSnowball = "192";
            //Jammer
            public static string WeaponWWPlusMoreJammer = "174";
            //Smoke Grenade
            public static string WeaponWWPlusMoreSmokeGrenade = "148";
            //Decoy
            public static string WeaponWWPlusMoreDecoy = "11";
            //Drone Squad
            public static string WeaponWWPlusMoreDroneSquad = "84";
            //Stun Grenade
            public static string WeaponWWPlusMoreStunGrenade = "51";
            //Frag
            public static string WeaponWWPlusMoreFrag = "153";
            //Zombies Head?
            public static string WeaponWWPlusMoreZombiesHead = "294";
            //Frenzied Guard
            public static string WeaponWWPlusMoreFrenziedGuard = "361";
            //Frost Blast
            public static string WeaponWWPlusMoreFrostBlast = "337";
            //Energy Mine
            public static string WeaponWWPlusMoreEnergyMine = "360";
            //Aether Shroud
            public static string WeaponWWPlusMoreAetherShroud = "336";
            //Healing Aura
            public static string WeaponWWPlusMoreHealingAura = "350";
            //Ring of Fire
            public static string WeaponWWPlusMoreRingofFire = "323";
            //Hands
            public static string FireFoxHands = "200";

            // --------------------------------------------//
            //                 Relex Sights 
            // --------------------------------------------//
            //Millstop Reflex
            public static string MillstopReflex = "46135";
            //Visiontech 2x
            public static string Visiontech2x = "1030";
            //Kobra Red Dot
            public static string KobraRedDot = "45068";
            //Quickdot LED
            public static string QuickdotLED = "10292";
            //Axial Arms
            public static string AxialArms = "50231";
            //Sillix Holoscout
            public static string SillixHoloscout = "23607";
            //Microflex LED
            public static string Microflex = "11319";
            //Hawksmoor
            public static string Hawksmoor = "47159";
            //Royal & Kross 4X
            public static string RoyalKross4X = "51255";
            //Susat Multizoom
            public static string SusatMultizoom = "8247";
            //Diamondback Reflex
            public static string DiamondbackReflex = "48183";
            //Snappoint
            public static string Snappoint = "12330";
            //Fastpoint Reflex
            public static string FastpointReflex = "49194";
            //Axial Arms 3x
            public static string AxialArms3x = "50218";
            //Iron Sights
            public static string IronSights = "10272";
            //Otero Mini Reflex
            public static string OteroMiniReflex = "46096";
        }

        public static class FireFoxWeaponFunctions
        {

            public static void FireFoxSpawnWeaponCycle(string FireFoxWeaponID, int FireFoxPlayersID)
            {
                if (MainTab.FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                int num = Int32.Parse(FireFoxWeaponID);
                if (FireFoxPlayersID == 0)
                {
                    FireFoxAPI1.WriteProcessMemory(MainTab.FireFoxhProc, MainTab.FireFoxPlayerCompPtr + (MainTab.FireFoxPC_ArraySize_Offset * FireFoxPlayersID) + 176, 0, 4, out _);
                    FireFoxAPI1.WriteProcessMemory(MainTab.FireFoxhProc, MainTab.FireFoxPlayerCompPtr + (MainTab.FireFoxPC_ArraySize_Offset * FireFoxPlayersID) + 240, num, 4, out _);
                }
                else
                {
                    FireFoxAPI1.WriteProcessMemory(MainTab.FireFoxhProc, MainTab.FireFoxPlayerCompPtr + (MainTab.FireFoxPC_ArraySize_Offset * FireFoxPlayersID) + 176, 0, 4, out _);
                    FireFoxAPI1.WriteProcessMemory(MainTab.FireFoxhProc, MainTab.FireFoxPlayerCompPtr + (MainTab.FireFoxPC_ArraySize_Offset * FireFoxPlayersID) + 240, num, 4, out _);
                }
            }
            public static void FireFoxSpawnWeapon(string FireFoxWeaponID)
            {
                if (MainTab.FireFoxIsInGame == false)
                {
                    XtraMessageBox.Show("You Must Be In Game Before Enabling Options!");
                    return;
                }
                int num = Int32.Parse(FireFoxWeaponID);
                if (MainTab.FireFoxPlayerID == 0)
                {
                    //cwapi.WriteProcessMemory(hProc, PlayerCompPtr + (PC_ArraySize_Offset * PlayerID) + 176, num, 4, out _);
                    FireFoxAPI1.WriteProcessMemory(MainTab.FireFoxhProc, MainTab.FireFoxPlayerCompPtr + (MainTab.FireFoxPC_ArraySize_Offset * MainTab.FireFoxPlayerID) + 176, 0, 4, out _);
                    FireFoxAPI1.WriteProcessMemory(MainTab.FireFoxhProc, MainTab.FireFoxPlayerCompPtr + (MainTab.FireFoxPC_ArraySize_Offset * MainTab.FireFoxPlayerID) + 240, num, 4, out _);
                }
                else
                {
                    FireFoxAPI1.WriteProcessMemory(MainTab.FireFoxhProc, MainTab.FireFoxPlayerCompPtr + (MainTab.FireFoxPC_ArraySize_Offset * MainTab.FireFoxPlayerID) + 176, 0, 4, out _);
                    FireFoxAPI1.WriteProcessMemory(MainTab.FireFoxhProc, MainTab.FireFoxPlayerCompPtr + (MainTab.FireFoxPC_ArraySize_Offset * MainTab.FireFoxPlayerID) + 240, num, 4, out _);
                }
            }
            // Weapon Spawning Start
            public static void FireFoxSpawnWeaponXM4()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponXM4);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponXM4PAP);
                }
            }
            public static void FireFoxSpawnWeaponAK47()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponAK47);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponAK47PAP);
                }
            }
            public static void FireFoxSpawnWeaponKrigz6()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponKrig6);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponKrig6PAP);
                }
            }
            public static void FireFoxSpawnWeaponQBZ83()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponQBZ83);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponQBZ83PAP);
                }
            }
            public static void FireFoxSpawnWeaponFFAR1()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponFFAR1);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponFFAR1PAP);
                }
            }
            public static void FireFoxSpawnWeaponGroza()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponGroza);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponGrozaPAP);
                }
            }
            public static void FireFoxSpawnWeaponMP5()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponMP5);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponMP5PAP);
                }
            }
            public static void FireFoxSpawnWeaponMilano821()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponMilano821);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponMilano821PAP);
                }
            }
            public static void FireFoxSpawnWeaponAK74u()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponAk74u);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponAk74uPAP);
                }
            }
            public static void FireFoxSpawnWeaponKSP45()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponKSP45);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponKSP45PAP);
                }
            }
            public static void FireFoxSpawnWeaponBullfrog()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponBullfrog);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponBullfrogPAP);
                }
            }
            public static void FireFoxSpawnWeaponMac10()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponMac10);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponMac10PAP);
                }
            }
            public static void FireFoxSpawnWeaponType63()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponType63);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponType63PAP);
                }
            }
            public static void FireFoxSpawnWeaponM16()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponM16);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponM16PAP);
                }
            }
            public static void FireFoxSpawnWeaponAUG()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponAUG);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponAUGPAP);
                }
            }
            public static void FireFoxSpawnWeaponDMR14()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponDMR14);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponDMR14PAP);
                }
            }
            public static void FireFoxSpawnWeaponStoner63()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponStoner63);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponStoner63PAP);
                }
            }
            public static void FireFoxSpawnWeaponRPD()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponRPD);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponRPDPAP);
                }
            }
            public static void FireFoxSpawnWeaponM60()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponM60);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponM60PAP);
                }
            }
            public static void FireFoxSpawnWeaponPelington703()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponPelington703);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponPelington703PAP);
                }
            }
            public static void FireFoxSpawnWeaponLW3Tundra()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponLW3Tundra);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponLW3TundraPAP);
                }
            }
            public static void FireFoxSpawnWeaponM82()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponM82);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponM82PAP);
                }
            }
            public static void FireFoxSpawnWeapon1911()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.Weapon1911);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.Weapon1911PAP);
                }
            }
            public static void FireFoxSpawnWeaponMagnum()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponMagnum);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponMagnumPAP);
                }
            }
            public static void FireFoxSpawnWeaponDiamatti()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponDiamatti);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponDiamattiPAP);
                }
            }
            public static void FireFoxSpawnWeaponHauer77()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponHauer77);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponHauer77PAP);
                }
            }
            public static void FireFoxSpawnWeaponGalloSA12()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponGalloSA12);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponGalloSA12PAP);
                }
            }
            public static void FireFoxSpawnWeaponStreetSweeper()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponStreetSweeper);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponStreetSweeperPAP);
                }
            }
            public static void FireFoxSpawnWeaponCigma2()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponCigma2);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponCigma2PAP);
                }
            }
            public static void FireFoxSpawnWeaponRPG7()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponRPG7);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponRPG7PAP);
                }
            }
            public static void FireFoxSpawnWeaponKnife()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponKnife);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponKnifePAP);
                }
            }
            public static void FireFoxSpawnWeaponSledgeHammer()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponSledgeHammer);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponSledgeHammerPAP);
                }
            }
            public static void FireFoxSpawnWeaponWakizashi()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWakizashi);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWakizashiPAP);
                }
            }
            public static void FireFoxSpawnWeaponM79()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponM79);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponM79PAP);
                }
            }
            public static void FireFoxSpawnWeaponFARA83()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponFARA83);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponFARA83PAP);
                }
            }
            public static void FireFoxSpawnWeaponLC10()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponLC10);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponLC10PAP);
                }
            }
            public static void FireFoxSpawnWeaponR1ShadowhunterCrossbow()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponR1ShadowhunterCrossbow);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponR1ShadowhunterCrossbowPAP);
                }
            }
            public static void FireFoxSpawnWeaponMachete()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponMachete);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponMachetePAP);
                }
            }
            public static void FireFoxSpawnWeaponBallisticKnife()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponBallisticKnife);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponBallisticKnifPAP);
                }
            }
            public static void FireFoxSpawnWeaponPPSh41()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponPPSh41);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponPPSh41PAP);
                }
            }
            public static void FireFoxSpawnWeaponZRG20mm()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponZRGmm);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponZRGmmEPAP);
                }
            }
            public static void FireFoxSpawnWeaponSwissK31()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponSwissK31);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponSwissK31PAP);
                }
            }
            public static void FireFoxSpawnWeaponCARV2()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponCARV2);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponCARV2PAP);
                }
            }
            public static void FireFoxSpawnWeaponETool()
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponETool);
                }
                else
                {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponETool2PAP);
                }
            }
            public static void FireFoxSpawnWeaponDiscordianDisruptor()
            {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreDiscordianDisruptor);
            }
            public static void FireFoxSpawnWeaponDIEShockWave()
            {
                    FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreShockWave);
            }
            public static void FireFoxSpawnWeaponDieNova5()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreNova);
            }
            public static void FireFoxSpawnWeaponDieElectro()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreElectro);
            }
            public static void FireFoxSpawnWeaponDieCryo()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreCryo);
            }
            public static void FireFoxSpawnWeaponDieThermo()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreThermo);
            }
            public static void FireFoxSpawnWeaponGunship()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreGunship);
            }
            public static void FireFoxSpawnWeaponChopperGunner()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreChopperGunner);
            }
            public static void FireFoxSpawnWeaponTomahawk()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreTomahawk);
            }
            public static void FireFoxSpawnWeaponMonkeyBomb()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreMonkeyBomb);
            }
            public static void FireFoxSpawnWeaponElSlasher()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreElSlasher);
            }
            public static void FireFoxSpawnWeaponSecretKiss()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreSecretKiss);
            }
            public static void FireFoxSpawnWeaponCruiseMissle()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreCruiseMissle);
            }
            public static void FireFoxSpawnWeaponEssenceTrap()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreEssenceTrap);
            }
            public static void FireFoxSpawnWeaponClaymore()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreClaymore);
            }
            public static void FireFoxSpawnWeaponCoal()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreCoal);
            }
            public static void FireFoxSpawnWeaponMolotov()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreMolotov);
            }
            public static void FireFoxSpawnWeaponShockCharge()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreShockCharge);
            }
            public static void FireFoxSpawnWeaponTrophySystem()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreTrophySystem);
            }
            public static void FireFoxSpawnWeaponFlashbang()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreFlashbang);
            }
            public static void FireFoxSpawnWeaponThermite()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreThermite);
            }
            public static void FireFoxSpawnWeaponSnowball()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreSnowball);
            }
            public static void FireFoxSpawnWeaponJammer()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreJammer);
            }
            public static void FireFoxSpawnWeaponSmokeGrenade()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreSmokeGrenade);
            }
            public static void FireFoxSpawnWeaponDecoy()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreDecoy);
            }
            public static void FireFoxSpawnWeaponDroneSquad()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreDroneSquad);
            }
            public static void FireFoxSpawnWeaponStunGrenade()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreStunGrenade);
            }
            public static void FireFoxSpawnWeaponFrag()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreFrag);
            }
            public static void FireFoxSpawnWeaponZombiesHead()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreZombiesHead);
            }
            public static void FireFoxSpawnWeaponFrenziedGuard()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreFrenziedGuard);
            }
            public static void FireFoxSpawnWeaponFrostBlast()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreFrostBlast);
            }
            public static void FireFoxSpawnWeaponEnergyMine()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreEnergyMine);
            }
            public static void FireFoxSpawnWeaponAetherShroud()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreAetherShroud);
            }
            public static void FireFoxSpawnWeaponHealingAura()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreHealingAura);
            }
            public static void FireFoxSpawnWeaponRingofFire()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.WeaponWWPlusMoreRingofFire);
            }
            //REFLEX SIGHTS
            public static void FireFoxSpawnWeaponMillstopReflex()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.MillstopReflex);
            }
            public static void FireFoxSpawnWeaponVisiontech2x()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.Visiontech2x);
            }
            public static void FireFoxSpawnWeaponKobraRedDot()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.QuickdotLED);
            }
            public static void FireFoxSpawnWeaponAxialArms()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.AxialArms);
            }
            public static void FireFoxSpawnWeaponSillixHoloscout()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.SillixHoloscout);
            }
            public static void FireFoxSpawnWeaponMicroflexLED()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.Microflex);
            }
            public static void FireFoxSpawnWeaponHawksmoor()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.Hawksmoor);
            }
            public static void FireFoxSpawnWeaponRoyalKross4X()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.RoyalKross4X);
            }
            public static void FireFoxSpawnWeaponSusatMultizoom()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.SusatMultizoom);
            }
            public static void FireFoxSpawnWeaponDiamondbackReflex()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.DiamondbackReflex);
            }
            public static void FireFoxSpawnWeaponSnappoint()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.Snappoint);
            }
            public static void FireFoxSpawnWeaponFastpointReflex()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.FastpointReflex);
            }
            public static void FireFoxSpawnWeaponAxialArms3x()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.AxialArms3x);
            }
            public static void FireFoxSpawnWeaponIronSights()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.IronSights);
            }
            public static void FireFoxSpawnWeaponOteroMiniReflex()
            {
                FireFoxSpawnWeapon(FireFoxWeaponIDs.OteroMiniReflex);
            }
            public static void FireFoxSpawnWeaponCycleXM4Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponXM4, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponXM4PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleAK47Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponAK47, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponAK47PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleKrigz6Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponKrig6, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponKrig6PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleQBZ83Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponQBZ83, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponQBZ83PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleFFAR1Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponFFAR1, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponFFAR1PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleGrozaCycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponGroza, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponGrozaPAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleMP5Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponMP5, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponMP5PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleMilano821Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponMilano821, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponMilano821PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleAK74uCycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponAk74u, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponAk74uPAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleKSP45Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponKSP45, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponKSP45PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleBullfrogCycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponBullfrog, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponBullfrogPAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleMac10Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponMac10, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponMac10PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleType63Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponType63, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponType63PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleM16Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponM16, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponM16PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleAUGCycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponAUG, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponAUGPAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleDMR14Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponDMR14, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponDMR14PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleStoner63Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponStoner63, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponStoner63PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleRPDCycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponRPD, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponRPDPAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleM60Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponM60, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponM60PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCyclePelington703Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponPelington703, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponPelington703PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleLW3TundraCycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponLW3Tundra, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponLW3TundraPAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleM82Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponM82, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponM82PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycle1911Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.Weapon1911, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.Weapon1911PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleMagnumCycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponMagnum, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponMagnumPAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleDiamattiCycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponDiamatti, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponDiamattiPAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleHauer77Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponHauer77, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponHauer77PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleGalloSA12Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponGalloSA12, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponGalloSA12PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleStreetSweeperCycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponStreetSweeper, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponStreetSweeperPAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleCigma2Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponCigma2, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponCigma2PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleRPG7Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponRPG7, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponRPG7PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleKnifeCycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponKnife, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponKnifePAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleSledgeHammerCycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponSledgeHammer, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponSledgeHammerPAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleWakizashiCycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWakizashi, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWakizashiPAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleM79Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponM79, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponM79PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleFARA83Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponFARA83, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponFARA83PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleLC10Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponLC10, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponLC10PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleR1ShadowhunterCrossbowCycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponR1ShadowhunterCrossbow, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponR1ShadowhunterCrossbowPAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleMacheteCycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponMachete, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponMachetePAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleBallisticKnifeCycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponBallisticKnife, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponBallisticKnifPAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCyclePPSh41Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponPPSh41, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponPPSh41PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleZRG20mmCycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponZRGmm, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponZRGmmEPAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleSwissK31Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponSwissK31, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponSwissK31PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleCARV2Cycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponCARV2, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponCARV2PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleEToolCycle(int FireFoxPlayersID)
            {
                if (!Globals.FireFoxWeaponOptions.FireFoxUsePAPWeapons.Checked)
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponETool, FireFoxPlayersID);
                }
                else
                {
                    FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponETool2PAP, FireFoxPlayersID);
                }
            }
            public static void FireFoxSpawnWeaponCycleDiscordianDisruptorCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreDiscordianDisruptor, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleDIEShockWaveCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreShockWave, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleDieNova5Cycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreNova, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleDieElectroCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreElectro, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleDieCryoCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreCryo, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleDieThermoCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreThermo, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleGunshipCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreGunship, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleChopperGunnerCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreChopperGunner, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleTomahawkCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreTomahawk, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleMonkeyBombCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreMonkeyBomb, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleElSlasherCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreElSlasher, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleSecretKissCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreSecretKiss, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleCruiseMissleCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreCruiseMissle, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleEssenceTrapCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreEssenceTrap, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleClaymoreCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreClaymore, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleCoalCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreCoal, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleMolotovCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreMolotov, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleShockChargeCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreShockCharge, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleTrophySystemCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreTrophySystem, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleFlashbangCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreFlashbang, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleThermiteCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreThermite, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleSnowballCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreSnowball, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleJammerCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreJammer, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleSmokeGrenadeCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreSmokeGrenade, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleDecoyCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreDecoy, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleDroneSquadCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreDroneSquad, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleStunGrenadeCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreStunGrenade, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleFragCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreFrag, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleZombiesHeadCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreZombiesHead, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleFrenziedGuardCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreFrenziedGuard, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleFrostBlastCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreFrostBlast, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleEnergyMineCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreEnergyMine, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleAetherShroudCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreAetherShroud, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleHealingAuraCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreHealingAura, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleRingofFireCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.WeaponWWPlusMoreRingofFire, FireFoxPlayersID);
            }
            //REFLEX SIGHTS
            public static void FireFoxSpawnWeaponCycleMillstopReflexCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.MillstopReflex, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleVisiontech2xCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.Visiontech2x, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleKobraRedDotCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.QuickdotLED, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleAxialArmsCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.AxialArms, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleSillixHoloscoutCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.SillixHoloscout, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleMicroflexLEDCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.Microflex, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleHawksmoorCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.Hawksmoor, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleRoyalKross4XCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.RoyalKross4X, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleSusatMultizoomCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.SusatMultizoom, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleDiamondbackReflexCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.DiamondbackReflex, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleSnappointCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.Snappoint, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleFastpointReflexCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.FastpointReflex, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleAxialArms3xCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.AxialArms3x, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleIronSightsCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.IronSights, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleOteroMiniReflexCycle(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.OteroMiniReflex, FireFoxPlayersID);
            }
            public static void FireFoxSpawnWeaponCycleHands(int FireFoxPlayersID)
            {
                FireFoxSpawnWeaponCycle(FireFoxWeaponIDs.FireFoxHands, FireFoxPlayersID);
            }
        }

        public static class FireFoxWeaponImages
        {
            public static void SetWeaponImages()
            {
                //Regular Weapons
                Globals.FireFoxWeaponOptions.FireFoxXM4Spawn.Image = Properties.Resources.FireFox_xm4;
                Globals.FireFoxWeaponOptions.FireFoxAK47Spawn.Image = Properties.Resources.FireFox_ak_47;
                Globals.FireFoxWeaponOptions.FireFoxKraig6Spawn.Image = Properties.Resources.FireFox_krig_6;
                Globals.FireFoxWeaponOptions.FireFoxQBZ83Spawn.Image = Properties.Resources.FireFox_qbz_83;
                Globals.FireFoxWeaponOptions.FireFoxFFAR1Spawn.Image = Properties.Resources.FireFox_ffar_1_2;
                Globals.FireFoxWeaponOptions.FireFoxGrozaSpawn.Image = Properties.Resources.FireFox_groza_0;
                Globals.FireFoxWeaponOptions.FireFoxMP5Spawn.Image = Properties.Resources.FireFox_mp5;
                Globals.FireFoxWeaponOptions.FireFoxMilano821Spawn.Image = Properties.Resources.FireFox_type_63;
                Globals.FireFoxWeaponOptions.FireFoxAK74uSpawn.Image = Properties.Resources.FireFox_ak_47_u;
                Globals.FireFoxWeaponOptions.FireFoxKSP45Spawn.Image = Properties.Resources.FireFox_ksp_45;
                Globals.FireFoxWeaponOptions.FireFoxBullFrogSpawn.Image = Properties.Resources.FireFox_bullfrog_1;
                Globals.FireFoxWeaponOptions.FireFoxMAC10Spawn.Image = Properties.Resources.FireFox_mac_10_1;
                Globals.FireFoxWeaponOptions.FireFoxType63Spawn.Image = Properties.Resources.FireFox_type_63;
                Globals.FireFoxWeaponOptions.FireFoxM16Spawn.Image = Properties.Resources.FireFox_m16;
                Globals.FireFoxWeaponOptions.FireFoxAUGSpawn.Image = Properties.Resources.FireFox_aug_2;
                Globals.FireFoxWeaponOptions.FireFoxDMR14Spawn.Image = Properties.Resources.FireFox_dmr_14_1;
                Globals.FireFoxWeaponOptions.FireFoxStoner63Spawn.Image = Properties.Resources.FireFox_stoner_63;
                Globals.FireFoxWeaponOptions.FireFoxRDPSpawn.Image = Properties.Resources.FireFox_rpd;
                Globals.FireFoxWeaponOptions.FireFoxM60Spawn.Image = Properties.Resources.FireFox_m60_3;
                Globals.FireFoxWeaponOptions.FireFoxPelington703Spawn.Image = Properties.Resources.FireFox_pelington_703;
                Globals.FireFoxWeaponOptions.FireFoxLW3TundraSpawn.Image = Properties.Resources.FireFox_lw3_tundra;
                Globals.FireFoxWeaponOptions.FireFoxM82Spawn.Image = Properties.Resources.FireFox_m82_2;
                Globals.FireFoxWeaponOptions.FireFoxHauer77Spawn.Image = Properties.Resources.FireFox_hauer_77;
                Globals.FireFoxWeaponOptions.FireFoxGalloSA12Spawn.Image = Properties.Resources.FireFox_gallo_sa12;
                Globals.FireFoxWeaponOptions.FireFoxStreetsweeperSpawn.Image = Properties.Resources.FireFox_Streetsweeper;
                Globals.FireFoxWeaponOptions.FireFoxSpawn1911.Image = Properties.Resources.FireFox_1911;
                Globals.FireFoxWeaponOptions.FireFoxMagnumSpawn.Image = Properties.Resources.FireFox_magnum;
                Globals.FireFoxWeaponOptions.FireFoxDiamattiSpawn.Image = Properties.Resources.FireFox_diamatti;
                Globals.FireFoxWeaponOptions.FireFoxCigma2.Image = Properties.Resources.FireFox_cigma_2_1;
                Globals.FireFoxWeaponOptions.FireFoxRPG7.Image = Properties.Resources.FireFox_rpg_7_1;
                Globals.FireFoxWeaponOptions.FireFoxKnifeSpawn.Image = Properties.Resources.FireFox_knife_0;
                Globals.FireFoxWeaponOptions.FireFoxSledgehammerSpawn.Image = Properties.Resources.FireFox_sledgehammer;
                Globals.FireFoxWeaponOptions.FireFoxWakizashiSpawn.Image = Properties.Resources.FireFox_wakizashi;
                Globals.FireFoxWeaponOptions.FireFoxM79Spawn.Image = Properties.Resources.FireFox_m79;
                Globals.FireFoxWeaponOptions.FireFoxFARA83Spawn.Image = Properties.Resources.FireFox_FARA83;
                Globals.FireFoxWeaponOptions.FireFoxLC10Spawn.Image = Properties.Resources.FireFox_LC10;
                Globals.FireFoxWeaponOptions.FireFoxCrossbowSpawn.Image = Properties.Resources.FireFox_Crossbow;
                Globals.FireFoxWeaponOptions.FireFoxMacheteSpawn.Image = Properties.Resources.FireFox_Machete;
                Globals.FireFoxWeaponOptions.FireFoxPPSH41Spawn.Image = Properties.Resources.FireFox_PPSh_41;
                Globals.FireFoxWeaponOptions.FireFoxEtoolSpawn.Image = Properties.Resources.FireFox_ETool;
                Globals.FireFoxWeaponOptions.FireFoxBallisticKnifeSpawn.Image = Properties.Resources.FireFox_Ballistic_Knife;
                Globals.FireFoxWeaponOptions.FireFoxZRG20MMSpawn.Image = Properties.Resources.FireFox_ZRG_20mm;
                Globals.FireFoxWeaponOptions.FireFoxSwissK31Spawn.Image = Properties.Resources.FireFox_Swiss_K31;
            }
        }
    }
}
