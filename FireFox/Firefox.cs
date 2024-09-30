using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using FireFox.Dependencies;
using FireFox.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace FireFox
{
    public partial class Firefox : DevExpress.XtraBars.TabForm
    {
        [DllImport("user32.dll")]
        public static extern uint SetWindowDisplayAffinity(IntPtr hwnd, uint dwAffinity);
        public Firefox()
        {
            InitializeComponent();
            //SetWindowDisplayAffinity(this.Handle, 0x00000001);
            Anti.IntAntisStart();
            Misc.FireFoxCheckAssetFiles.FireFoxStartProtectCheck();
            Misc.Globals.firefox = this;
            MainTab.Globals.FireFoxConnectOptions = this;
            Weapons.Globals.FireFoxWeaponOptions = this;
            FireFoxMainDocker.ForceInitialize();
            FireFoxWeaponSpawningDocker.ForceInitialize();
            FireFoxDataDocker.ForceInitialize();
            LoginPageUsername.Text = Settings.Default["Username"].ToString();
            LoginPagePassword.Text = Settings.Default["Password"].ToString();
            LoginPageKey.Text = Settings.Default["Key"].ToString();
            Misc.FireFoxRemovePages();
            Misc.FireFoxHideDockers();
            MainTab.FireFoxSetDefaultImages.FireFoxSetImagesDefault();
            Weapons.FireFoxWeaponImages.SetWeaponImages();
            Misc.FireFoxLogoChanger.FireFoxLogoChangerStart();
        }

        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            Firefox form = new Firefox();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;

        private void Firefox_Load(object sender, EventArgs e)
        {
        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            Misc.FireFoxIsCleaningFiles = false;
            Misc.Login(LoginPageUsername.Text, LoginPagePassword.Text , LoginPageKey.Text);
        }
        private void FireFoxCleanButton_Click_1(object sender, EventArgs e)
        {
            Misc.FireFoxCleanUp(LoginPagePassword.Text);
        }

        private void FireFoxTabControl_SelectedPageChanged(object sender, TabFormSelectedPageChangedEventArgs e)
        {
            Misc.FireFoxUpdateDockerPanels();
        }

        private void FireFoxConnect_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxConnectionOptions.FireFoxConnect();
        }

        private void FireFoxPLUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainTab.FireFoxUpdatePlayersInfo.FireFoxUpdatePlayerNames();
        }
        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxSingleClientOptions.FireFoxClientGodOn();
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxSingleClientOptions.FireFoxClientGodOff();
        }

        private void enableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxSingleClientOptions.FireFoxClientInfraredOn();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxSingleClientOptions.FireFoxClientInfraredOff();
        }

        private void enableToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxSingleClientOptions.FireFoxClientRapidFireOn();
        }

        private void disableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxSingleClientOptions.FireFoxClientRapidFireOff();
        }

        private void enableToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxSingleClientOptions.FireFoxClientEnable();
        }

        private void disableToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxSingleClientOptions.FireFoxClientDisable();
        }

        private void add1000PointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxSingleClientOptions.FireFoxSetCash(1000);
        }

        private void add10000PointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxSingleClientOptions.FireFoxSetCash(10000);
        }

        private void add100000PointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxSingleClientOptions.FireFoxSetCash(100000);
        }

        private void add1000000PointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxSingleClientOptions.FireFoxSetCash(1000000);
        }

        private void add10000000PointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxSingleClientOptions.FireFoxSetCash(10000000);
        }

        private void add100000000PointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxSingleClientOptions.FireFoxSetCash(100000000);
        }

        private void FireFoxWeaponSpawnXM4_Click(object sender, EventArgs e)
        {
                Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponXM4();
        }

        private void FireFoxWeaponSpawnAK47_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponAK47();
        }

        private void FireFoxWeaponSpawnKraig6_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponKrigz6();
        }

        private void FireFoxWeaponSpawnQBZ83_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponQBZ83();
        }

        private void FireFoxWeaponSpawnGroza_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponGroza();
        }

        private void FireFoxWeaponSpawnFARA1_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponFFAR1();
        }

        private void FireFoxWeaponSpawnMP5_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponMP5();
        }

        private void FireFoxWeaponSpawnMilano821_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponMilano821();
        }

        private void FireFoxWeaponSpawnAK74u_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponAK74u();
        }

        private void FireFoxWeaponSpawnKSP45_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponKSP45();
        }

        private void FireFoxWeaponSpawnBullfrog_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponBullfrog();
        }

        private void FireFoxWeaponSpawnMAC10_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponMac10();
        }

        private void FireFoxWeaponSpawnType63_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponType63();
        }

        private void FireFoxWeaponSpawnM16_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponM16();
        }

        private void FireFoxWeaponSpawnAUG_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponAUG();
        }

        private void FireFoxWeaponSpawnDMR14_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponDMR14();
        }

        private void FireFoxWeaponSpawnStoner63_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponStoner63();
        }

        private void FireFoxWeaponSpawnM60_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponM60();
        }

        private void FireFoxWeaponSpawnRPD_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponRPD();
        }

        private void FireFoxWeaponSpawnPellington703_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponPelington703();
        }

        private void FireFoxWeaponSpawnLW3Tundra_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponLW3Tundra();
        }

        private void FireFoxWeaponSpawnM82_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponM82();
        }

        private void FireFoxWeaponSpawnHauer_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponHauer77();
        }

        private void FireFoxWeaponSpawnGalloSA12_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponGalloSA12();
        }

        private void FireFoxWeaponSpawnStreetSweeper_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponStreetSweeper();
        }

        private void FireFoxWeaponSpawn1911_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeapon1911();
        }

        private void FireFoxWeaponSpawnMagnum_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponMagnum();
        }

        private void FireFoxWeaponSpawnDiamatti_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponDiamatti();
        }

        private void FireFoxWeaponSpawnRPG7_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponRPG7();
        }

        private void Cigma2_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCigma2();
        }

        private void FireFoxWeaponSpawnKnife_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponKnife();
        }

        private void FireFoxWeaponSpawnSledgehammer_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponSledgeHammer();
        }

        private void FireFoxWeaponSpawnWakizashi_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponWakizashi();
        }

        private void FireFoxWeaponSpawnM79_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponM79();
        }

        private void FireFoxWeaponSpawnFARA83_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponFARA83();
        }

        private void FireFoxWeaponSpawnLC10_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponLC10();
        }

        private void FireFoxWeaponSpawnMachete_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponMachete();
        }

        private void FireFoxWeaponSpawnCrossbow_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponR1ShadowhunterCrossbow();
        }

        private void FireFoxWeaponSpawnPPSH41_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponPPSh41();
        }

        private void FireFoxWeaponSpawnEtool_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponETool();
        }

        private void FireFoxWeaponSpawnBallisticKnife_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponBallisticKnife();
        }

        private void FireFoxWeaponSpawnZRG20MM_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponZRG20mm();
        }

        private void FireFoxWeaponSpawnSwissK31_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponSwissK31();
        }

        private void FireFoxWeaponSpawnCARV2_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCARV2();
        }

        private void FireFoxWeaponSpawnDiscordianDisruptor_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponDiscordianDisruptor();
        }

        private void FireFoxWeaponSpawnDIEShockwave_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponDIEShockWave();
        }

        private void FireFoxWeaponSpawnDIENova_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponDieNova5();
        }

        private void DIEelectro_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponDieElectro();
        }

        private void FireFoxWeaponSpawnDIECryo_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponDieCryo();
        }

        private void FireFoxWeaponSpawnDIEThermo_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponDieThermo();
        }

        private void FireFoxWeaponSpawnGunShip_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponGunship();
        }

        private void FireFoxWeaponSpawnCruiseMissle_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCruiseMissle();
        }

        private void FireFoxWeaponSpawnChopperGunner_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponChopperGunner();
        }

        private void FireFoxWeaponSpawnTomahawk_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponTomahawk();
        }

        private void FireFoxWeaponSpawnMonkeyBomb_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponMonkeyBomb();
        }

        private void FireFoxWeaponSpawnElSlasher_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponElSlasher();
        }

        private void FireFoxWeaponSpawnSerketsKiss_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponSecretKiss();
        }

        private void FireFoxWeaponSpawnFrenziedGuard_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponFrenziedGuard();
        }

        private void FireFoxWeaponSpawnFrostBlast_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponFrostBlast();
        }

        private void FireFoxWeaponSpawnEnerygyMine_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponEnergyMine();
        }

        private void FireFoxWeaponSpawnAetherShroud_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponAetherShroud();
        }

        private void FireFoxWeaponSpawnHealingAura_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponHealingAura();
        }

        private void FireFoxWeaponSpawnRingOfFire_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponRingofFire();
        }

        private void FireFoxWeaponSpawnEssenceTrap_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponEssenceTrap();
        }

        private void FireFoxWeaponSpawnClaymore_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponClaymore();
        }

        private void FireFoxWeaponSpawnCoal_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCoal();
        }

        private void FireFoxWeaponSpawnMolotov_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponMolotov();
        }

        private void FireFoxWeaponSpawnShockCharge_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponShockCharge();
        }

        private void FireFoxWeaponSpawnTrophySystem_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponTrophySystem();
        }

        private void FireFoxWeaponSpawnFlashbang_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponFlashbang();
        }

        private void FireFoxWeaponSpawnThermite_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponThermite();
        }

        private void FireFoxWeaponSpawnSnowBall_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponSnowball();
        }

        private void FireFoxWeaponSpawnJammer_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponJammer();
        }

        private void FireFoxWeaponSpawnSmokeGrenade_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponSmokeGrenade();
        }

        private void FireFoxWeaponSpawnDecoy_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponDecoy();
        }

        private void FireFoxWeaponSpawnDroneSquad_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponDroneSquad();
        }

        private void FireFoxWeaponSpawnStunGrenade_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponStunGrenade();
        }

        private void toolStripMenuItem95_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponFrag();
        }

        private void FireFoxWeaponSpawnZombiesHead_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponZombiesHead();
        }

        private void FireFoxGodOn_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxAllClientOptions.FireFoxAllGodOn();
        }

        private void FireFoxGodOff_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxAllClientOptions.FireFoxAllGodOff();
        }

        private void FireFoxInstantKillOn_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxAllClientOptions.FireFoxAllInstantKillEnable();
        }

        private void FireFoxInstantKillOff_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxAllClientOptions.FireFoxAllInstantKillDisable();
        }

        private void FireFoxTPZombiesOn_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxAllClientOptions.FireFoxAllTPZombiesOn();
        }

        private void FireFoxTPZombiesOff_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxAllClientOptions.FireFoxAllTPZombiesOff();
        }

        private void FireFoxCritKillsOn_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxAllClientOptions.FireFoxAllCritsOn();
        }

        private void FireFoxCritKillsOff_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxAllClientOptions.FireFoxAllCritsOff();
        }

        private void FireFoxUnlimitedAmmoOn_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxAllClientOptions.FireFoxAllUnlimitedAmmoOn();
        }

        private void FireFoxUnlimitedAmmoOff_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxAllClientOptions.FireFoxAllUnlimitedAmmoOff();
        }

        private void FireFoxInfraredOn_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxAllClientOptions.FireFoxAllClientsInfraredVisionOn();
        }

        private void FireFoxInfraredOff_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxAllClientOptions.FireFoxAllClientsInfraredVisionOff();
        }

        private void FireFoxRapidFireOn_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxAllClientOptions.FireFoxAllClientsRapidFireOn();
        }

        private void FireFoxRapidFireOff_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxAllClientOptions.FireFoxAllClientsRapidFireOff();
        }

        private void FireFoxXM4Spawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponXM4();
        }

        private void FireFoxAK47Spawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponAK47();
        }

        private void FireFoxKraig6Spawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponKrigz6();
        }

        private void FireFoxQBZ83Spawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponQBZ83();
        }

        private void FireFoxFFAR1Spawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponFFAR1();
        }

        private void FireFoxGrozaSpawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponGroza();
        }

        private void FireFoxMP5Spawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponMP5();
        }

        private void FireFoxMilano821Spawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponMilano821();
        }

        private void FireFoxAK74uSpawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponAK74u();
        }

        private void FireFoxKSP45Spawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponKSP45();
        }

        private void FireFoxBullFrogSpawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponBullfrog();
        }

        private void FireFoxMAC10Spawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponMac10();
        }

        private void FireFoxType63Spawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponType63();
        }

        private void FireFoxM16Spawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponM16();
        }

        private void FireFoxAUGSpawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponAUG();
        }

        private void FireFoxDMR14Spawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponDMR14();
        }

        private void FireFoxStoner63Spawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponStoner63();
        }

        private void FireFoxRDPSpawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponRPD();
        }

        private void FireFoxM60Spawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponM60();
        }

        private void FireFoxPelington703Spawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponPelington703();
        }

        private void FireFoxLW3TundraSpawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponLW3Tundra();
        }

        private void FireFoxM82Spawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponM82();
        }

        private void FireFoxHauer77Spawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponHauer77();
        }

        private void FireFoxGalloSA12Spawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponGalloSA12();
        }

        private void FireFoxStreetsweeperSpawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponStreetSweeper();
        }

        private void FireFoxSpawn1911_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeapon1911();
        }

        private void FireFoxMagnumSpawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponMagnum();
        }

        private void FireFoxDiamattiSpawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponDiamatti();
        }

        private void FireFoxCigma2_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponCigma2();
        }

        private void FireFoxRPG7_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponRPG7();
        }

        private void FireFoxKnifeSpawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponKnife();
        }

        private void FireFoxSledgehammerSpawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponSledgeHammer();
        }

        private void FireFoxWakizashiSpawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponWakizashi();
        }

        private void FireFoxM79Spawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponM79();
        }

        private void FireFoxFARA83Spawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponFARA83();
        }

        private void FireFoxLC10Spawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponLC10();
        }

        private void FireFoxCrossbowSpawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponR1ShadowhunterCrossbow();
        }

        private void FireFoxMacheteSpawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponMachete();
        }

        private void FireFoxPPSH41Spawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponPPSh41();
        }

        private void FireFoxEtoolSpawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponETool();
        }

        private void FireFoxBallisticKnifeSpawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponBallisticKnife();
        }

        private void FireFoxZRG20MMSpawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponZRG20mm();
        }

        private void FireFoxSwissK31Spawn_Click(object sender, EventArgs e)
        {
            Weapons.FireFoxWeaponFunctions.FireFoxSpawnWeaponSwissK31();
        }

        private void FireFoxCustomSpawnFireBase_CheckedChanged(object sender, EventArgs e)
        {
            MainTab.FireFoxCustomSpawns.FireFoxIfFireBaseChoseExitDIE();
        }

        private void FireFoxCustomSpawnDIE_CheckedChanged(object sender, EventArgs e)
        {
            MainTab.FireFoxCustomSpawns.FireFoxIfDIEChoseExitFireBase();
        }

        private void FireFoxCustomSpawnAddSpawn_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxCustomSpawns.FireFoxAddCustomSpawnPointButton();
        }

        public void FireFoxCustomSpawnRefreshSpawn_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxCustomSpawns.FireFoxRefreshCustomSpawnPoints();
        }

        private void FireFoxCustomSpawnsChooseFireBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainTab.FireFoxCustomSpawns.FireFoxCustomFireBaseSpawnDropDownIndexChanged();
        }

        private void FireFoxCustomSpawnsChooseDIE_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainTab.FireFoxCustomSpawns.FireFoxCustomDIESpawnDropDownIndexChanged();
        }

        private void toPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxCustomSpawns.FireFoxTeleportToPlayer();
        }

        private void playerToMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxCustomSpawns.FireFoxTeleportPlayerToMe();
        }

        private void FireFoxTeleportDIECombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainTab.FireFoxCustomSpawns.FireFoxDIEPresetSpawns();
        }

        private void FireFoxTeleportFireBaseCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainTab.FireFoxCustomSpawns.FireFoxFireBasePresetSpawns();
        }

        private void FireFoxXYZSpawnX_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxCustomSpawns.FireFoxXYZMoveX();
        }

        private void FireFoxXYZSpawnY_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxCustomSpawns.FireFoxXYZMoveY();
        }

        private void FireFoxXYZSpawnZ_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxCustomSpawns.FireFoxXYZMoveZ();
        }

        private void FireFoxXYZSpawnPlus_CheckedChanged(object sender, EventArgs e)
        {
            MainTab.FireFoxCustomSpawns.FireFoxXYZifPlusSelectedKillMinus();
        }

        private void FireFoxXYZSpawnMinus_CheckedChanged(object sender, EventArgs e)
        {
            MainTab.FireFoxCustomSpawns.FireFoxXYZifMinusSelectedKillPlus();
        }

        private void Firefox_FormClosed(object sender, FormClosedEventArgs e)
        {
            Misc.FireFoxCheckAssetFiles.FireFoxCloseAssetsWhenFormClose();
        }

        private void Firefox_FormClosing(object sender, FormClosingEventArgs e)
        {
            Misc.FireFoxCheckAssetFiles.FireFoxCloseAssetsWhenFormClose();
        }

        private void FireFoxLobbyOptionsJumpHeightButton_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxLobbyOptions.FireFoxLobbyOptionsSetJumpHeight();
        }

        private void FireFoxLobbyOptionsJumpHeightTrackController_EditValueChanged(object sender, EventArgs e)
        {
            FireFoxLobbyOptionsJumpHeightValue.Text = FireFoxLobbyOptionsJumpHeightTrackController.Value.ToString();
        }

        private void FireFoxLobbyOptionsSpeedButton_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxLobbyOptions.FireFoxLobbyOptionsSetSpeed();
        }

        private void FireFoxLobbyOptionsSpeedTrackController_EditValueChanged(object sender, EventArgs e)
        {
            FireFoxLobbyOptionsSpeedValue.Text = FireFoxLobbyOptionsSpeedTrackController.Value.ToString();
        }

        private void FireFoxStartCrystalButton_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxCrystalOptions.FireFoxStartCrystals();
        }

        private void FireFoxPlayerXPSet_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxXPOptions.FireFoxSetPlayerXP();
        }

        private void FireFoxPlayerXPReset_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxXPOptions.FireFoxReSetPlayerXP();
        }

        private void FireFoxPlayerXPSetTrackBar_EditValueChanged(object sender, EventArgs e)
        {
            FireFoxPlayerXPValue.Text = FireFoxPlayerXPSetTrackBar.Value.ToString();
        }

        private void FireFoxLevelXPSet_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxXPOptions.FireFoxSetLevelXP();
        }

        private void FireFoxLevelXPReset_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxXPOptions.FireFoxReSetLevelXP();
        }

        private void FireFoxLevelXPSetTrackBar_EditValueChanged(object sender, EventArgs e)
        {
            FireFoxLevelXPValue.Text = FireFoxLevelXPSetTrackBar.Value.ToString();
        }

        private void FireFoxQuickXPOption_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxXPOptions.FireFoxInstantLevel();
        }

        private void FirFoxP1DA_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxDarkAetherOptionsP1.FireFoxStartDarkAetherP1();
        }

        private void FireFoxResetKillCountP1_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxDarkAetherOptionsP1.FireFoxResetKillCountP1();
        }

        private void FireFoxStartSpawnWeaponsButtonP1_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxDarkAetherOptionsP1.FireFoxSpawnWeaponCycleTypeKillP1();
        }

        private void FireFoxStartWeaponSpawningKeyPressP1_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxDarkAetherOptionsP1.FireFoxSpawnWeaponCycleTypePressP1();
        }

        private void FirFoxP2DA_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxDarkAetherOptionsP2.FireFoxStartDarkAetherP2();
        }

        private void FireFoxResetKillCountP2_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxDarkAetherOptionsP2.FireFoxResetKillCountP2();
        }

        private void FireFoxStartSpawnWeaponsButtonP2_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxDarkAetherOptionsP2.FireFoxSpawnWeaponCycleTypeKillP2();
        }

        private void FireFoxStartWeaponSpawningKeyPressP2_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxDarkAetherOptionsP2.FireFoxSpawnWeaponCycleTypePressP2();
        }

        private void FirFoxP3DA_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxDarkAetherOptionsP3.FireFoxStartDarkAetherP3();
        }

        private void FireFoxResetKillCountP3_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxDarkAetherOptionsP3.FireFoxResetKillCountP3();
        }

        private void FireFoxStartSpawnWeaponsButtonP3_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxDarkAetherOptionsP3.FireFoxSpawnWeaponCycleTypeKillP3();
        }

        private void FireFoxStartWeaponSpawningKeyPressP3_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxDarkAetherOptionsP3.FireFoxSpawnWeaponCycleTypePressP3();
        }

        private void FirFoxP4DA_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxDarkAetherOptionsP4.FireFoxStartDarkAetherP4();
        }

        private void FireFoxResetKillCountP4_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxDarkAetherOptionsP4.FireFoxResetKillCountP4();
        }

        private void FireFoxStartSpawnWeaponsButtonP4_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxDarkAetherOptionsP4.FireFoxSpawnWeaponCycleTypeKillP4();
        }

        private void FireFoxStartWeaponSpawningKeyPressP4_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxDarkAetherOptionsP4.FireFoxSpawnWeaponCycleTypePressP4();
        }

        private void FireFoxP1StatsRefresh_CheckedChanged(object sender, EventArgs e)
        {
            MainTab.FireFoxStatsOptions.FireFoxIfStatsChosenKillOthersP1();
        }

        private void FireFoxP2StatsRefresh_CheckedChanged(object sender, EventArgs e)
        {
            MainTab.FireFoxStatsOptions.FireFoxIfStatsChosenKillOthersP2();
        }

        private void FireFoxP3StatsRefresh_CheckedChanged(object sender, EventArgs e)
        {
            MainTab.FireFoxStatsOptions.FireFoxIfStatsChosenKillOthersP3();
        }

        private void FireFoxP4StatsRefresh_CheckedChanged(object sender, EventArgs e)
        {
            MainTab.FireFoxStatsOptions.FireFoxIfStatsChosenKillOthersP4();
        }

        private void FireFoxRandomStatsMax_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxStatsOptions.FireFoxRandomizeMaxStats();
        }

        private void FireFoxRandomStatsMedium_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxStatsOptions.FireFoxRandomzieMediumStats();
        }

        private void FireFoxRandomStatsLow_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxStatsOptions.FireFoxRandomizeLowStats();
        }

        private void FireFoxSendStatsButton_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxStatsOptions.FireFoxSendStatsToPlayer();
        }

        private void FireFoxEnableQuickOptions_CheckedChanged(object sender, EventArgs e)
        {
            if(FireFoxAutoConnect.Checked)
            {
                FireFoxAutoConnect.Checked = true;
            }
        }

        private void FirFoxP1Reticles_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxStatsOptions.FireFoxReticlesUnlockStart(0);
        }

        private void FireFoxResetKillCountReticlesP1_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxDarkAetherOptionsP1.FireFoxResetKillCountP1();
        }

        private void FireFoxStartSpawnWeaponsButtonReticlesP1_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxReticlesStartP1.FireFoxStartReticlesP1();
        }

        private void FireFoxKillAllPlayers_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxAdditionalFeatures.FireFoxSuicideAllPlayers();
        }

        private void FireFoxFastRoundsStart_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxAdditionalFeatures.FireFoxEnableFastRounds();
        }

        private void FirFoxP2Reticles_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxStatsOptions.FireFoxReticlesUnlockStart(1);
        }

        private void FireFoxResetKillCountReticlesP2_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxDarkAetherOptionsP2.FireFoxResetKillCountP2();
        }

        private void FireFoxStartSpawnWeaponsButtonReticlesP2_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxReticlesStartP2.FireFoxStartReticlesP2();
        }

        private void FirFoxP3Reticles_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxStatsOptions.FireFoxReticlesUnlockStart(2);
        }

        private void FireFoxResetKillCountReticlesP3_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxDarkAetherOptionsP3.FireFoxResetKillCountP3();
        }

        private void FireFoxStartSpawnWeaponsButtonReticlesP3_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxReticlesStartP3.FireFoxStartReticlesP3();
        }

        private void FirFoxP4Reticles_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxStatsOptions.FireFoxReticlesUnlockStart(3);
        }

        private void FireFoxResetKillCountReticlesP4_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxDarkAetherOptionsP4.FireFoxResetKillCountP4();
        }

        private void FireFoxStartSpawnWeaponsButtonReticlesP4_Click(object sender, EventArgs e)
        {
            MainTab.FireFoxReticlesStartP4.FireFoxStartReticlesP4();
        }

        private void StartGameTest_Click(object sender, EventArgs e)
        {
            MainTab.CMDStuff.SendCommand("LobbyLaunchGame");
        }
    }
}
