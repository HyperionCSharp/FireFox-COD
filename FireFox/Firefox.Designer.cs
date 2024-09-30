
namespace FireFox
{
    partial class Firefox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            bool isDesignMode = DesignMode;
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            if (--OpenFormCount == 0 && !isDesignMode)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Firefox));
            this.FireFoxTabControl = new DevExpress.XtraBars.TabFormControl();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemColorPickEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit();
            this.repositoryItemColorPickEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemColorPickEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit();
            this.repositoryItemColorPickEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit();
            this.FireFoxLogin = new DevExpress.XtraBars.TabFormPage();
            this.FireFoxTabPageLogin = new DevExpress.XtraBars.TabFormContentContainer();
            this.FireFoxEnableQuickOptions = new DevExpress.XtraEditors.CheckEdit();
            this.FireFoxAutoConnect = new DevExpress.XtraEditors.CheckEdit();
            this.FireFoxDisableWhenOut = new DevExpress.XtraEditors.CheckEdit();
            this.FireFoxLoginPageSlider = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.FireFoxLicenseKeyLabel = new DevExpress.XtraEditors.LabelControl();
            this.LoginPageKey = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxPasswordLabel = new DevExpress.XtraEditors.LabelControl();
            this.FireFoxUsernameLabel = new DevExpress.XtraEditors.LabelControl();
            this.LoginPageUsername = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxCleanButton = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxCleanProgress = new DevExpress.XtraEditors.ListBoxControl();
            this.LoginButton = new DevExpress.XtraEditors.SimpleButton();
            this.LoginPagePassword = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxMain = new DevExpress.XtraBars.TabFormPage();
            this.FireFoxTabPageLoginMain = new DevExpress.XtraBars.TabFormContentContainer();
            this.FireFoxWeaponPage = new DevExpress.XtraBars.TabFormPage();
            this.FireFoxTabPageWeapons = new DevExpress.XtraBars.TabFormContentContainer();
            this.FireFoxDataPageTab = new DevExpress.XtraBars.TabFormPage();
            this.FireFoxTabPageData = new DevExpress.XtraBars.TabFormContentContainer();
            this.FireFoxAllCGB = new DevExpress.XtraEditors.GroupControl();
            this.FireFoxUsePAPWeapons = new DevExpress.XtraEditors.CheckEdit();
            this.FireFoxRapidFireOff = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxRapidFireOn = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxGodOn = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxInstantKillOn = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxInfraredOff = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxTPZombiesOn = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxUnlimitedAmmoOff = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxInfraredOn = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxCritKillsOff = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxCritKillsOn = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxTPZombiesOff = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxUnlimitedAmmoOn = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxInstantKillOff = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxGodOff = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxPLGB = new DevExpress.XtraEditors.GroupControl();
            this.FireFoxPLUpdate = new DevExpress.XtraEditors.ListBoxControl();
            this.FireFoxClientsCMS = new NSContextMenu();
            this.godModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infraredVisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.rapidFireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.disablePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.addPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add1000PointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add10000PointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add100000PointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add1000000PointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add10000000PointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add100000000PointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxCMSWeapons = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnAssult = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnXM4 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnAK47 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnKraig6 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnQBZ83 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnGroza = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnFARA1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnSMGs = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnMP5 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnMilano821 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnAK74u = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnKSP45 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnBullfrog = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnMAC10 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnTACs = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnType63 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnM16 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnAUG = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnDMR14 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnLMGs = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnStoner63 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnM60 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnRPD = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnSnipers = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnPellington703 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnLW3Tundra = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnM82 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnShotguns = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnHauer = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnGalloSA12 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnStreetSweeper = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnPistols = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawn1911 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnMagnum = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnDiamatti = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem39 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnRPG7 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnCigma2 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnMelee = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnKnife = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnSledgehammer = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnWakizashi = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnSpecial = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnM79 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnDLC = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnFARA83 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnLC10 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnMachete = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnCrossbow = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnPPSH41 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnEtool = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnBallisticKnife = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnZRG20MM = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnSwissK31 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnCARV2 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnWonderWeapons = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnDiscordianDisruptor = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnDIEShockwave = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnDIENova = new System.Windows.Forms.ToolStripMenuItem();
            this.DIEelectro = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnDIECryo = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnDIEThermo = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnGunShip = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnCruiseMissle = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnChopperGunner = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnTomahawk = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnMonkeyBomb = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnElSlasher = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnSerketsKiss = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnFieldUpgrades = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnFrenziedGuard = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnFrostBlast = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnEnerygyMine = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnAetherShroud = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnHealingAura = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnRingOfFire = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnMisc = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnEssenceTrap = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnClaymore = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnCoal = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnMolotov = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnShockCharge = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnTrophySystem = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnFlashbang = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnThermite = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnSnowBall = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnJammer = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnSmokeGrenade = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnDecoy = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnDroneSquad = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnStunGrenade = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem95 = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxWeaponSpawnZombiesHead = new System.Windows.Forms.ToolStripMenuItem();
            this.teleportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FireFoxConnect = new DevExpress.XtraEditors.SimpleButton();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.FireFoxMainDocker = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.FireFoxDockerClients = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.StartGameTest = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxDockerTeleport = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.FireFoxCustomXYZSpawn = new DevExpress.XtraEditors.GroupControl();
            this.FireFoxTPValue = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxXYZSpawnMinus = new DevExpress.XtraEditors.CheckEdit();
            this.FireFoxXYZSpawnPlus = new DevExpress.XtraEditors.CheckEdit();
            this.FireFoxXYZSpawnZ = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxXYZSpawnY = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxXYZSpawnX = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxCustomSpawnPointsMapSpecific = new DevExpress.XtraEditors.GroupControl();
            this.FireFoxTeleportFireBase = new System.Windows.Forms.Label();
            this.FireFoxTeleportFireBaseCombo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.FireFoxTeleportDIE = new System.Windows.Forms.Label();
            this.FireFoxTeleportDIECombo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.FireFoxSavedSpawnPoints = new DevExpress.XtraEditors.GroupControl();
            this.FireFoxCustomSpawnsChooseDIE = new DevExpress.XtraEditors.ComboBoxEdit();
            this.FireFoxCustomDIESpawns = new System.Windows.Forms.Label();
            this.FireFoxCustomFireBasepawns = new System.Windows.Forms.Label();
            this.FireFoxCustomSpawnsChooseFireBase = new DevExpress.XtraEditors.ComboBoxEdit();
            this.FireFoxCustomSpawnRefreshSpawn = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxCustomSpawnAddSpawn = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxCustomSpawnCustomNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.FireFoxCustomSpawnName = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxCustomSpawnDIE = new DevExpress.XtraEditors.CheckEdit();
            this.FireFoxCustomSpawnFireBase = new DevExpress.XtraEditors.CheckEdit();
            this.FireFoxDockerLobby = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer13 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.FireFoxOtherOptionsMain = new DevExpress.XtraEditors.GroupControl();
            this.FireFoxFastRoundsStart = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxKillAllPlayers = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxQuickXPOption = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxLevelXPGB = new DevExpress.XtraEditors.GroupControl();
            this.FireFoxLevelXPReset = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxLevelXPSet = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxLevelXPValue = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxLevelXPSetTrackBar = new DevExpress.XtraEditors.TrackBarControl();
            this.FireFoxPlayerXPGB = new DevExpress.XtraEditors.GroupControl();
            this.FireFoxPlayerXPReset = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxPlayerXPSet = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxPlayerXPValue = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxPlayerXPSetTrackBar = new DevExpress.XtraEditors.TrackBarControl();
            this.FireFoxCrystalsGB = new DevExpress.XtraEditors.GroupControl();
            this.FireFoxStartCrystalButton = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxLobbyOptionsSpeedSettingsGB = new DevExpress.XtraEditors.GroupControl();
            this.FireFoxLobbyOptionsSpeedButton = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxLobbyOptionsSpeedValue = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxLobbyOptionsSpeedTrackController = new DevExpress.XtraEditors.TrackBarControl();
            this.FireFoxLobbyOptionsJumpHeightValue = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxLobbyOptionsJumpHeightButton = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxLobbyOptionsJumpHeightTrackController = new DevExpress.XtraEditors.TrackBarControl();
            this.FireFoxDockerDA = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer15 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.FireFoxMainTabContainer = new DevExpress.XtraTab.XtraTabControl();
            this.FireFoxDATabP1 = new DevExpress.XtraTab.XtraTabPage();
            this.FireFoxInformationP1 = new DevExpress.XtraEditors.GroupControl();
            this.FireFoxP1LocationDA = new System.Windows.Forms.Label();
            this.FireFoxP1DarkAetherReady = new System.Windows.Forms.Label();
            this.FireFoxP1KillCount = new System.Windows.Forms.Label();
            this.FireFoxCurrentWeaponP1 = new System.Windows.Forms.Label();
            this.FireFoxPlayerOneSpawnWeaponsDA = new System.Windows.Forms.Label();
            this.FireFoxStartWeaponSpawningKeyPressP1 = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxStartSpawnWeaponsButtonP1 = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxResetKillCountP1 = new DevExpress.XtraEditors.SimpleButton();
            this.FirFoxP1DA = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxTimedSpawnValueP1 = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxWeaponSwitchSpawnBoxPlayerOne = new System.Windows.Forms.PictureBox();
            this.FireFoxDATabP2 = new DevExpress.XtraTab.XtraTabPage();
            this.FireFoxInformationP2 = new DevExpress.XtraEditors.GroupControl();
            this.FireFoxP2LocationDA = new System.Windows.Forms.Label();
            this.FireFoxP2DarkAetherReady = new System.Windows.Forms.Label();
            this.FireFoxP2KillCount = new System.Windows.Forms.Label();
            this.FireFoxCurrentWeaponP2 = new System.Windows.Forms.Label();
            this.FireFoxPlayerTwoSpawnWeaponsDA = new System.Windows.Forms.Label();
            this.FireFoxStartWeaponSpawningKeyPressP2 = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxStartSpawnWeaponsButtonP2 = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxResetKillCountP2 = new DevExpress.XtraEditors.SimpleButton();
            this.FirFoxP2DA = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxTimedSpawnValueP2 = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxWeaponSwitchSpawnBoxPlayerTwo = new System.Windows.Forms.PictureBox();
            this.FireFoxDATabP3 = new DevExpress.XtraTab.XtraTabPage();
            this.FireFoxInformationP3 = new DevExpress.XtraEditors.GroupControl();
            this.FireFoxP3LocationDA = new System.Windows.Forms.Label();
            this.FireFoxP3DarkAetherReady = new System.Windows.Forms.Label();
            this.FireFoxP3KillCount = new System.Windows.Forms.Label();
            this.FireFoxCurrentWeaponP3 = new System.Windows.Forms.Label();
            this.FireFoxPlayerThreeSpawnWeaponsDA = new System.Windows.Forms.Label();
            this.FireFoxStartWeaponSpawningKeyPressP3 = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxStartSpawnWeaponsButtonP3 = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxResetKillCountP3 = new DevExpress.XtraEditors.SimpleButton();
            this.FirFoxP3DA = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxTimedSpawnValueP3 = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxWeaponSwitchSpawnBoxPlayerThree = new System.Windows.Forms.PictureBox();
            this.FireFoxDATabP4 = new DevExpress.XtraTab.XtraTabPage();
            this.FireFoxStartWeaponSpawningKeyPressP4 = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxInformationP4 = new DevExpress.XtraEditors.GroupControl();
            this.FireFoxP4LocationDA = new System.Windows.Forms.Label();
            this.FireFoxP4DarkAetherReady = new System.Windows.Forms.Label();
            this.FireFoxP4KillCount = new System.Windows.Forms.Label();
            this.FireFoxCurrentWeaponP4 = new System.Windows.Forms.Label();
            this.FireFoxPlayerFourSpawnWeaponsDA = new System.Windows.Forms.Label();
            this.FireFoxStartSpawnWeaponsButtonP4 = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxResetKillCountP4 = new DevExpress.XtraEditors.SimpleButton();
            this.FirFoxP4DA = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxTimedSpawnValueP4 = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxWeaponSwitchSpawnBoxPlayerFour = new System.Windows.Forms.PictureBox();
            this.FireFoxDockerReticles = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer16 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.FireFoxReticlesMainTabController = new DevExpress.XtraTab.XtraTabControl();
            this.FireFoxReticlesTabP1 = new DevExpress.XtraTab.XtraTabPage();
            this.FireFoxInformationReticlesP1 = new DevExpress.XtraEditors.GroupControl();
            this.FireFoxP1LocationReticles = new System.Windows.Forms.Label();
            this.FireFoxP1KillCountReticles = new System.Windows.Forms.Label();
            this.FireFoxCurrentWeaponReticlesP1 = new System.Windows.Forms.Label();
            this.FireFoxPlayerOneSpawnWeaponsReticles = new System.Windows.Forms.Label();
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne = new System.Windows.Forms.PictureBox();
            this.FireFoxStartSpawnWeaponsButtonReticlesP1 = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxResetKillCountReticlesP1 = new DevExpress.XtraEditors.SimpleButton();
            this.FirFoxP1Reticles = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxTimedSpawnValueReticlesP1 = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxReticlesTabP2 = new DevExpress.XtraTab.XtraTabPage();
            this.FireFoxStartSpawnWeaponsButtonReticlesP2 = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxResetKillCountReticlesP2 = new DevExpress.XtraEditors.SimpleButton();
            this.FirFoxP2Reticles = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxTimedSpawnValueReticlesP2 = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo = new System.Windows.Forms.PictureBox();
            this.FireFoxInformationReticlesP2 = new DevExpress.XtraEditors.GroupControl();
            this.FireFoxP2LocationReticles = new System.Windows.Forms.Label();
            this.FireFoxP2KillCountReticles = new System.Windows.Forms.Label();
            this.FireFoxCurrentWeaponReticlesP2 = new System.Windows.Forms.Label();
            this.FireFoxPlayerTwoSpawnWeaponsReticles = new System.Windows.Forms.Label();
            this.FireFoxReticlesTabP3 = new DevExpress.XtraTab.XtraTabPage();
            this.FireFoxStartSpawnWeaponsButtonReticlesP3 = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxResetKillCountReticlesP3 = new DevExpress.XtraEditors.SimpleButton();
            this.FirFoxP3Reticles = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxTimedSpawnValueReticlesP3 = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree = new System.Windows.Forms.PictureBox();
            this.FireFoxInformationReticlesP3 = new DevExpress.XtraEditors.GroupControl();
            this.FireFoxP3LocationReticles = new System.Windows.Forms.Label();
            this.FireFoxP3KillCountReticles = new System.Windows.Forms.Label();
            this.FireFoxCurrentWeaponReticlesP3 = new System.Windows.Forms.Label();
            this.FireFoxPlayerThreeSpawnWeaponsReticles = new System.Windows.Forms.Label();
            this.FireFoxReticlesTabP4 = new DevExpress.XtraTab.XtraTabPage();
            this.FireFoxStartSpawnWeaponsButtonReticlesP4 = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxResetKillCountReticlesP4 = new DevExpress.XtraEditors.SimpleButton();
            this.FirFoxP4Reticles = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxTimedSpawnValueReticlesP4 = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour = new System.Windows.Forms.PictureBox();
            this.FireFoxInformationReticlesP4 = new DevExpress.XtraEditors.GroupControl();
            this.FireFoxP4LocationReticles = new System.Windows.Forms.Label();
            this.FireFoxP4KillCountReticles = new System.Windows.Forms.Label();
            this.FireFoxCurrentWeaponReticlesP4 = new System.Windows.Forms.Label();
            this.FireFoxPlayerFourSpawnWeaponsReticles = new System.Windows.Forms.Label();
            this.FireFoxDockerStats = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer17 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.FireFoxStatsProgressGB = new DevExpress.XtraEditors.GroupControl();
            this.FireFoxStatsProgressLB = new System.Windows.Forms.ListBox();
            this.FirFoxStatsOptionGroupBox = new DevExpress.XtraEditors.GroupControl();
            this.FireFoxSendStatsButton = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxTotalTimePlayedMinsInput = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxTotalTimePlayedHoursInput = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxTotalTimePlayedDaysInput = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxTotalGamesPlayedInput = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxTotalElimsInput = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxTotalCriticalKillsInput = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxTotalEliteKillsInput = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxTotalKillsInput = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxTotalRoundsInput = new DevExpress.XtraEditors.TextEdit();
            this.FireFoxTotalTimePlayedMinsStatsLabel = new System.Windows.Forms.Label();
            this.FireFoxTotalTimePlayedHoursStatsLabel = new System.Windows.Forms.Label();
            this.FireFoxTotalTimePlayedDaysStatsLabel = new System.Windows.Forms.Label();
            this.FireFoxTotalGamesPlayedStatsLabel = new System.Windows.Forms.Label();
            this.FireFoxTotalElimsStatsLabel = new System.Windows.Forms.Label();
            this.FireFoxTotalCriticalKillsStatsLabel = new System.Windows.Forms.Label();
            this.FireFoxTotalEliteKillsStatsLabel = new System.Windows.Forms.Label();
            this.FireFoxTotalKillsStatsLabel = new System.Windows.Forms.Label();
            this.FireFoxTotalRoundsStatsLabel = new System.Windows.Forms.Label();
            this.FireFoxRandomizeStatsGB = new DevExpress.XtraEditors.GroupControl();
            this.FireFoxRandomStatsLow = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxRandomStatsMedium = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxRandomStatsMax = new DevExpress.XtraEditors.SimpleButton();
            this.FireFoxStatsPlayerListGB = new DevExpress.XtraEditors.GroupControl();
            this.FireFoxP4StatsRefresh = new DevExpress.XtraEditors.CheckEdit();
            this.FireFoxP3StatsRefresh = new DevExpress.XtraEditors.CheckEdit();
            this.FireFoxP2StatsRefresh = new DevExpress.XtraEditors.CheckEdit();
            this.FireFoxP1StatsRefresh = new DevExpress.XtraEditors.CheckEdit();
            this.FireFoxWeaponSpawningDocker = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.FireFoxWeaponDockerAR = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer2 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.FireFoxGrozaLabel = new System.Windows.Forms.Label();
            this.FireFoxFFAR1Label = new System.Windows.Forms.Label();
            this.FireFoxQBZ83Label = new System.Windows.Forms.Label();
            this.FireFoxGrozaSpawn = new System.Windows.Forms.PictureBox();
            this.FireFoxFFAR1Spawn = new System.Windows.Forms.PictureBox();
            this.FireFoxQBZ83Spawn = new System.Windows.Forms.PictureBox();
            this.FireFoxKrig6Label = new System.Windows.Forms.Label();
            this.FireFoxKraig6Spawn = new System.Windows.Forms.PictureBox();
            this.FireFoxAK47Label = new System.Windows.Forms.Label();
            this.FireFoxXM4abel = new System.Windows.Forms.Label();
            this.FireFoxAK47Spawn = new System.Windows.Forms.PictureBox();
            this.FireFoxXM4Spawn = new System.Windows.Forms.PictureBox();
            this.FireFoxWeaponDockeDLC = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer12 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.FireFoxSwissK31Label = new System.Windows.Forms.Label();
            this.FireFoxZRG20MMLabel = new System.Windows.Forms.Label();
            this.FireFoxBallisticKnifeLabel = new System.Windows.Forms.Label();
            this.FireFoxEtoolLabel = new System.Windows.Forms.Label();
            this.FireFoxPPSH41Label = new System.Windows.Forms.Label();
            this.FireFoxSwissK31Spawn = new System.Windows.Forms.PictureBox();
            this.FireFoxZRG20MMSpawn = new System.Windows.Forms.PictureBox();
            this.FireFoxBallisticKnifeSpawn = new System.Windows.Forms.PictureBox();
            this.FireFoxEtoolSpawn = new System.Windows.Forms.PictureBox();
            this.FireFoxPPSH41Spawn = new System.Windows.Forms.PictureBox();
            this.FireFoxMacheteLabel = new System.Windows.Forms.Label();
            this.FireFoxCrossbowLabel = new System.Windows.Forms.Label();
            this.FireFoxLC10Label = new System.Windows.Forms.Label();
            this.FireFoxFARA83Label = new System.Windows.Forms.Label();
            this.FireFoxMacheteSpawn = new System.Windows.Forms.PictureBox();
            this.FireFoxCrossbowSpawn = new System.Windows.Forms.PictureBox();
            this.FireFoxLC10Spawn = new System.Windows.Forms.PictureBox();
            this.FireFoxFARA83Spawn = new System.Windows.Forms.PictureBox();
            this.FireFoxWeaponDockerSMG = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer3 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.FireFoxMAC10Label = new System.Windows.Forms.Label();
            this.FireFoxBullFrogLabel = new System.Windows.Forms.Label();
            this.FireFoxKSP45Label = new System.Windows.Forms.Label();
            this.FireFoxAK74uLabel = new System.Windows.Forms.Label();
            this.FireFoxMilano821Label = new System.Windows.Forms.Label();
            this.FireFoxMP5Label = new System.Windows.Forms.Label();
            this.FireFoxMAC10Spawn = new System.Windows.Forms.PictureBox();
            this.FireFoxBullFrogSpawn = new System.Windows.Forms.PictureBox();
            this.FireFoxKSP45Spawn = new System.Windows.Forms.PictureBox();
            this.FireFoxAK74uSpawn = new System.Windows.Forms.PictureBox();
            this.FireFoxMilano821Spawn = new System.Windows.Forms.PictureBox();
            this.FireFoxMP5Spawn = new System.Windows.Forms.PictureBox();
            this.FireFoxWeaponDockeTAC = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer4 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.FireFoxDMR14Label = new System.Windows.Forms.Label();
            this.FireFoxAUGLabel = new System.Windows.Forms.Label();
            this.FireFoxM16Label = new System.Windows.Forms.Label();
            this.FireFoxType63Label = new System.Windows.Forms.Label();
            this.FireFoxType63Spawn = new System.Windows.Forms.PictureBox();
            this.FireFoxDMR14Spawn = new System.Windows.Forms.PictureBox();
            this.FireFoxAUGSpawn = new System.Windows.Forms.PictureBox();
            this.FireFoxM16Spawn = new System.Windows.Forms.PictureBox();
            this.FireFoxWeaponDockeLMG = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer5 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.FireFoxM60Label = new System.Windows.Forms.Label();
            this.FireFoxRPDLabel = new System.Windows.Forms.Label();
            this.FireFoxStoner63Label = new System.Windows.Forms.Label();
            this.FireFoxM60Spawn = new System.Windows.Forms.PictureBox();
            this.FireFoxRDPSpawn = new System.Windows.Forms.PictureBox();
            this.FireFoxStoner63Spawn = new System.Windows.Forms.PictureBox();
            this.FireFoxWeaponDockeSnipers = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer6 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.FireFoxM82Label = new System.Windows.Forms.Label();
            this.FireFoxLW3TundraLabel = new System.Windows.Forms.Label();
            this.FireFoxPelington703Label = new System.Windows.Forms.Label();
            this.FireFoxM82Spawn = new System.Windows.Forms.PictureBox();
            this.FireFoxLW3TundraSpawn = new System.Windows.Forms.PictureBox();
            this.FireFoxPelington703Spawn = new System.Windows.Forms.PictureBox();
            this.FireFoxWeaponDockeShotguns = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer7 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.FireFoxStreetsweeperLabel = new System.Windows.Forms.Label();
            this.FireFoxGalloSA12Label = new System.Windows.Forms.Label();
            this.FireFoxHauer77Label = new System.Windows.Forms.Label();
            this.FireFoxStreetsweeperSpawn = new System.Windows.Forms.PictureBox();
            this.FireFoxGalloSA12Spawn = new System.Windows.Forms.PictureBox();
            this.FireFoxHauer77Spawn = new System.Windows.Forms.PictureBox();
            this.FireFoxWeaponDockePistols = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer8 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.FireFoxDiamattiLabel = new System.Windows.Forms.Label();
            this.FireFoxMagnumLabel = new System.Windows.Forms.Label();
            this.FireFoxLabel1911 = new System.Windows.Forms.Label();
            this.FireFoxDiamattiSpawn = new System.Windows.Forms.PictureBox();
            this.FireFoxMagnumSpawn = new System.Windows.Forms.PictureBox();
            this.FireFoxSpawn1911 = new System.Windows.Forms.PictureBox();
            this.FireFoxWeaponDockeLaunchers = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer9 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.FireFoxRPG7Label = new System.Windows.Forms.Label();
            this.FireFoxCigma2Label = new System.Windows.Forms.Label();
            this.FireFoxRPG7 = new System.Windows.Forms.PictureBox();
            this.FireFoxCigma2 = new System.Windows.Forms.PictureBox();
            this.FireFoxWeaponDockeMelee = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer10 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.FireFoxWakizashi = new System.Windows.Forms.Label();
            this.FireFoxSledgehammer = new System.Windows.Forms.Label();
            this.FireFoxKnifeLabel = new System.Windows.Forms.Label();
            this.FireFoxWakizashiSpawn = new System.Windows.Forms.PictureBox();
            this.FireFoxSledgehammerSpawn = new System.Windows.Forms.PictureBox();
            this.FireFoxKnifeSpawn = new System.Windows.Forms.PictureBox();
            this.FireFoxWeaponDockeSpecial = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer11 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.FireFoxM79Label = new System.Windows.Forms.Label();
            this.FireFoxM79Spawn = new System.Windows.Forms.PictureBox();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.LoginAlerts = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.FireFoxDataDocker = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.FireFoxPanelContainerData = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer18 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.FireFoxDataSpreadSheet = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.OtherAlerts = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.stepProgressBarItem1 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem2 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem3 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem4 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem5 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem6 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem7 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem8 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem9 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem10 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem11 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem12 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem13 = new DevExpress.XtraEditors.StepProgressBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTabControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit4)).BeginInit();
            this.FireFoxTabPageLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxEnableQuickOptions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxAutoConnect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxDisableWhenOut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLoginPageSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPageKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPageUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxCleanProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPagePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxAllCGB)).BeginInit();
            this.FireFoxAllCGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxUsePAPWeapons.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxPLGB)).BeginInit();
            this.FireFoxPLGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxPLUpdate)).BeginInit();
            this.FireFoxClientsCMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxMainDocker)).BeginInit();
            this.panelContainer1.SuspendLayout();
            this.FireFoxDockerClients.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            this.FireFoxDockerTeleport.SuspendLayout();
            this.controlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxCustomXYZSpawn)).BeginInit();
            this.FireFoxCustomXYZSpawn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTPValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxXYZSpawnMinus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxXYZSpawnPlus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxCustomSpawnPointsMapSpecific)).BeginInit();
            this.FireFoxCustomSpawnPointsMapSpecific.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTeleportFireBaseCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTeleportDIECombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxSavedSpawnPoints)).BeginInit();
            this.FireFoxSavedSpawnPoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxCustomSpawnsChooseDIE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxCustomSpawnsChooseFireBase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxCustomSpawnName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxCustomSpawnDIE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxCustomSpawnFireBase.Properties)).BeginInit();
            this.FireFoxDockerLobby.SuspendLayout();
            this.controlContainer13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxOtherOptionsMain)).BeginInit();
            this.FireFoxOtherOptionsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLevelXPGB)).BeginInit();
            this.FireFoxLevelXPGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLevelXPValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLevelXPSetTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLevelXPSetTrackBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxPlayerXPGB)).BeginInit();
            this.FireFoxPlayerXPGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxPlayerXPValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxPlayerXPSetTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxPlayerXPSetTrackBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxCrystalsGB)).BeginInit();
            this.FireFoxCrystalsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLobbyOptionsSpeedSettingsGB)).BeginInit();
            this.FireFoxLobbyOptionsSpeedSettingsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLobbyOptionsSpeedValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLobbyOptionsSpeedTrackController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLobbyOptionsSpeedTrackController.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLobbyOptionsJumpHeightValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLobbyOptionsJumpHeightTrackController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLobbyOptionsJumpHeightTrackController.Properties)).BeginInit();
            this.FireFoxDockerDA.SuspendLayout();
            this.controlContainer15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxMainTabContainer)).BeginInit();
            this.FireFoxMainTabContainer.SuspendLayout();
            this.FireFoxDATabP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxInformationP1)).BeginInit();
            this.FireFoxInformationP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTimedSpawnValueP1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxWeaponSwitchSpawnBoxPlayerOne)).BeginInit();
            this.FireFoxDATabP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxInformationP2)).BeginInit();
            this.FireFoxInformationP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTimedSpawnValueP2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxWeaponSwitchSpawnBoxPlayerTwo)).BeginInit();
            this.FireFoxDATabP3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxInformationP3)).BeginInit();
            this.FireFoxInformationP3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTimedSpawnValueP3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxWeaponSwitchSpawnBoxPlayerThree)).BeginInit();
            this.FireFoxDATabP4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxInformationP4)).BeginInit();
            this.FireFoxInformationP4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTimedSpawnValueP4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxWeaponSwitchSpawnBoxPlayerFour)).BeginInit();
            this.FireFoxDockerReticles.SuspendLayout();
            this.controlContainer16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxReticlesMainTabController)).BeginInit();
            this.FireFoxReticlesMainTabController.SuspendLayout();
            this.FireFoxReticlesTabP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxInformationReticlesP1)).BeginInit();
            this.FireFoxInformationReticlesP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTimedSpawnValueReticlesP1.Properties)).BeginInit();
            this.FireFoxReticlesTabP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTimedSpawnValueReticlesP2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxInformationReticlesP2)).BeginInit();
            this.FireFoxInformationReticlesP2.SuspendLayout();
            this.FireFoxReticlesTabP3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTimedSpawnValueReticlesP3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxInformationReticlesP3)).BeginInit();
            this.FireFoxInformationReticlesP3.SuspendLayout();
            this.FireFoxReticlesTabP4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTimedSpawnValueReticlesP4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxInformationReticlesP4)).BeginInit();
            this.FireFoxInformationReticlesP4.SuspendLayout();
            this.FireFoxDockerStats.SuspendLayout();
            this.controlContainer17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxStatsProgressGB)).BeginInit();
            this.FireFoxStatsProgressGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirFoxStatsOptionGroupBox)).BeginInit();
            this.FirFoxStatsOptionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTotalTimePlayedMinsInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTotalTimePlayedHoursInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTotalTimePlayedDaysInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTotalGamesPlayedInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTotalElimsInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTotalCriticalKillsInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTotalEliteKillsInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTotalKillsInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTotalRoundsInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxRandomizeStatsGB)).BeginInit();
            this.FireFoxRandomizeStatsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxStatsPlayerListGB)).BeginInit();
            this.FireFoxStatsPlayerListGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxP4StatsRefresh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxP3StatsRefresh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxP2StatsRefresh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxP1StatsRefresh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxWeaponSpawningDocker)).BeginInit();
            this.FireFoxWeaponDockerAR.SuspendLayout();
            this.controlContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxGrozaSpawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxFFAR1Spawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxQBZ83Spawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxKraig6Spawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxAK47Spawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxXM4Spawn)).BeginInit();
            this.FireFoxWeaponDockeDLC.SuspendLayout();
            this.controlContainer12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxSwissK31Spawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxZRG20MMSpawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxBallisticKnifeSpawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxEtoolSpawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxPPSH41Spawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxMacheteSpawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxCrossbowSpawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLC10Spawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxFARA83Spawn)).BeginInit();
            this.FireFoxWeaponDockerSMG.SuspendLayout();
            this.controlContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxMAC10Spawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxBullFrogSpawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxKSP45Spawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxAK74uSpawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxMilano821Spawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxMP5Spawn)).BeginInit();
            this.FireFoxWeaponDockeTAC.SuspendLayout();
            this.controlContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxType63Spawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxDMR14Spawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxAUGSpawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxM16Spawn)).BeginInit();
            this.FireFoxWeaponDockeLMG.SuspendLayout();
            this.controlContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxM60Spawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxRDPSpawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxStoner63Spawn)).BeginInit();
            this.FireFoxWeaponDockeSnipers.SuspendLayout();
            this.controlContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxM82Spawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLW3TundraSpawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxPelington703Spawn)).BeginInit();
            this.FireFoxWeaponDockeShotguns.SuspendLayout();
            this.controlContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxStreetsweeperSpawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxGalloSA12Spawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxHauer77Spawn)).BeginInit();
            this.FireFoxWeaponDockePistols.SuspendLayout();
            this.controlContainer8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxDiamattiSpawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxMagnumSpawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxSpawn1911)).BeginInit();
            this.FireFoxWeaponDockeLaunchers.SuspendLayout();
            this.controlContainer9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxRPG7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxCigma2)).BeginInit();
            this.FireFoxWeaponDockeMelee.SuspendLayout();
            this.controlContainer10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxWakizashiSpawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxSledgehammerSpawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxKnifeSpawn)).BeginInit();
            this.FireFoxWeaponDockeSpecial.SuspendLayout();
            this.controlContainer11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxM79Spawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxDataDocker)).BeginInit();
            this.FireFoxPanelContainerData.SuspendLayout();
            this.controlContainer18.SuspendLayout();
            this.SuspendLayout();
            // 
            // FireFoxTabControl
            // 
            this.FireFoxTabControl.AllowMoveTabsToOuterForm = false;
            this.FireFoxTabControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinBarSubItem1,
            this.barButtonItem1});
            this.FireFoxTabControl.Location = new System.Drawing.Point(0, 0);
            this.FireFoxTabControl.Manager = this.tabFormDefaultManager1;
            this.FireFoxTabControl.Name = "FireFoxTabControl";
            this.FireFoxTabControl.Pages.Add(this.FireFoxLogin);
            this.FireFoxTabControl.Pages.Add(this.FireFoxMain);
            this.FireFoxTabControl.Pages.Add(this.FireFoxWeaponPage);
            this.FireFoxTabControl.Pages.Add(this.FireFoxDataPageTab);
            this.FireFoxTabControl.SelectedPage = this.FireFoxMain;
            this.FireFoxTabControl.ShowAddPageButton = false;
            this.FireFoxTabControl.Size = new System.Drawing.Size(817, 64);
            this.FireFoxTabControl.TabForm = this;
            this.FireFoxTabControl.TabIndex = 0;
            this.FireFoxTabControl.TabStop = false;
            this.FireFoxTabControl.TitleItemLinks.Add(this.skinBarSubItem1);
            this.FireFoxTabControl.SelectedPageChanged += new DevExpress.XtraBars.TabFormSelectedPageChangedEventHandler(this.FireFoxTabControl_SelectedPageChanged);
            this.FireFoxTabControl.OuterFormCreating += new DevExpress.XtraBars.OuterFormCreatingEventHandler(this.OnOuterFormCreating);
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Skins";
            this.skinBarSubItem1.Id = 1;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Test";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // tabFormDefaultManager1
            // 
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
            this.tabFormDefaultManager1.DockingEnabled = false;
            this.tabFormDefaultManager1.Form = this;
            this.tabFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinBarSubItem1,
            this.barButtonItem1});
            this.tabFormDefaultManager1.MaxItemId = 9;
            this.tabFormDefaultManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemColorPickEdit1,
            this.repositoryItemColorPickEdit2,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemColorPickEdit3,
            this.repositoryItemColorPickEdit4});
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 64);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Size = new System.Drawing.Size(817, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 474);
            this.barDockControlBottom.Manager = null;
            this.barDockControlBottom.Size = new System.Drawing.Size(817, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 64);
            this.barDockControlLeft.Manager = null;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 410);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(817, 64);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 410);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemColorPickEdit1
            // 
            this.repositoryItemColorPickEdit1.AutoHeight = false;
            this.repositoryItemColorPickEdit1.AutomaticColor = System.Drawing.Color.Black;
            this.repositoryItemColorPickEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorPickEdit1.Name = "repositoryItemColorPickEdit1";
            // 
            // repositoryItemColorPickEdit2
            // 
            this.repositoryItemColorPickEdit2.AutoHeight = false;
            this.repositoryItemColorPickEdit2.AutomaticColor = System.Drawing.Color.Black;
            this.repositoryItemColorPickEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorPickEdit2.Name = "repositoryItemColorPickEdit2";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // repositoryItemColorPickEdit3
            // 
            this.repositoryItemColorPickEdit3.AutoHeight = false;
            this.repositoryItemColorPickEdit3.AutomaticColor = System.Drawing.Color.Black;
            this.repositoryItemColorPickEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorPickEdit3.Name = "repositoryItemColorPickEdit3";
            // 
            // repositoryItemColorPickEdit4
            // 
            this.repositoryItemColorPickEdit4.AutoHeight = false;
            this.repositoryItemColorPickEdit4.AutomaticColor = System.Drawing.Color.Black;
            this.repositoryItemColorPickEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorPickEdit4.Name = "repositoryItemColorPickEdit4";
            // 
            // FireFoxLogin
            // 
            this.FireFoxLogin.ContentContainer = this.FireFoxTabPageLogin;
            this.FireFoxLogin.Name = "FireFoxLogin";
            this.FireFoxLogin.Text = "Login";
            // 
            // FireFoxTabPageLogin
            // 
            this.FireFoxTabPageLogin.Controls.Add(this.FireFoxEnableQuickOptions);
            this.FireFoxTabPageLogin.Controls.Add(this.FireFoxAutoConnect);
            this.FireFoxTabPageLogin.Controls.Add(this.FireFoxDisableWhenOut);
            this.FireFoxTabPageLogin.Controls.Add(this.FireFoxLoginPageSlider);
            this.FireFoxTabPageLogin.Controls.Add(this.FireFoxLicenseKeyLabel);
            this.FireFoxTabPageLogin.Controls.Add(this.LoginPageKey);
            this.FireFoxTabPageLogin.Controls.Add(this.FireFoxPasswordLabel);
            this.FireFoxTabPageLogin.Controls.Add(this.FireFoxUsernameLabel);
            this.FireFoxTabPageLogin.Controls.Add(this.LoginPageUsername);
            this.FireFoxTabPageLogin.Controls.Add(this.FireFoxCleanButton);
            this.FireFoxTabPageLogin.Controls.Add(this.FireFoxCleanProgress);
            this.FireFoxTabPageLogin.Controls.Add(this.LoginButton);
            this.FireFoxTabPageLogin.Controls.Add(this.LoginPagePassword);
            this.FireFoxTabPageLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FireFoxTabPageLogin.Location = new System.Drawing.Point(200, 64);
            this.FireFoxTabPageLogin.Name = "FireFoxTabPageLogin";
            this.FireFoxTabPageLogin.Size = new System.Drawing.Size(617, 410);
            this.FireFoxTabPageLogin.TabIndex = 1;
            // 
            // FireFoxEnableQuickOptions
            // 
            this.FireFoxEnableQuickOptions.Location = new System.Drawing.Point(475, 269);
            this.FireFoxEnableQuickOptions.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxEnableQuickOptions.Name = "FireFoxEnableQuickOptions";
            this.FireFoxEnableQuickOptions.Properties.Caption = "Enable Quick Options";
            this.FireFoxEnableQuickOptions.Size = new System.Drawing.Size(124, 19);
            this.FireFoxEnableQuickOptions.TabIndex = 29;
            this.FireFoxEnableQuickOptions.CheckedChanged += new System.EventHandler(this.FireFoxEnableQuickOptions_CheckedChanged);
            // 
            // FireFoxAutoConnect
            // 
            this.FireFoxAutoConnect.EditValue = true;
            this.FireFoxAutoConnect.Location = new System.Drawing.Point(475, 248);
            this.FireFoxAutoConnect.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxAutoConnect.Name = "FireFoxAutoConnect";
            this.FireFoxAutoConnect.Properties.Caption = "Auto Connect/Refresh Client List";
            this.FireFoxAutoConnect.Size = new System.Drawing.Size(181, 19);
            this.FireFoxAutoConnect.TabIndex = 28;
            // 
            // FireFoxDisableWhenOut
            // 
            this.FireFoxDisableWhenOut.EditValue = true;
            this.FireFoxDisableWhenOut.Location = new System.Drawing.Point(475, 227);
            this.FireFoxDisableWhenOut.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxDisableWhenOut.Name = "FireFoxDisableWhenOut";
            this.FireFoxDisableWhenOut.Properties.Caption = "Disable Options When Not In Game";
            this.FireFoxDisableWhenOut.Size = new System.Drawing.Size(194, 19);
            this.FireFoxDisableWhenOut.TabIndex = 27;
            // 
            // FireFoxLoginPageSlider
            // 
            this.FireFoxLoginPageSlider.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.FireFoxLoginPageSlider.Appearance.Options.UseBackColor = true;
            this.FireFoxLoginPageSlider.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward;
            this.FireFoxLoginPageSlider.AutoSlideInterval = 5000;
            this.FireFoxLoginPageSlider.Location = new System.Drawing.Point(414, 33);
            this.FireFoxLoginPageSlider.Name = "FireFoxLoginPageSlider";
            this.FireFoxLoginPageSlider.Size = new System.Drawing.Size(317, 178);
            this.FireFoxLoginPageSlider.TabIndex = 26;
            this.FireFoxLoginPageSlider.Text = "imageSlider1";
            // 
            // FireFoxLicenseKeyLabel
            // 
            this.FireFoxLicenseKeyLabel.Location = new System.Drawing.Point(319, 356);
            this.FireFoxLicenseKeyLabel.Name = "FireFoxLicenseKeyLabel";
            this.FireFoxLicenseKeyLabel.Size = new System.Drawing.Size(60, 13);
            this.FireFoxLicenseKeyLabel.TabIndex = 25;
            this.FireFoxLicenseKeyLabel.Text = "License Key:";
            // 
            // LoginPageKey
            // 
            this.LoginPageKey.Location = new System.Drawing.Point(385, 353);
            this.LoginPageKey.MenuManager = this.tabFormDefaultManager1;
            this.LoginPageKey.Name = "LoginPageKey";
            this.LoginPageKey.Size = new System.Drawing.Size(368, 20);
            this.LoginPageKey.TabIndex = 24;
            // 
            // FireFoxPasswordLabel
            // 
            this.FireFoxPasswordLabel.Location = new System.Drawing.Point(327, 330);
            this.FireFoxPasswordLabel.Name = "FireFoxPasswordLabel";
            this.FireFoxPasswordLabel.Size = new System.Drawing.Size(50, 13);
            this.FireFoxPasswordLabel.TabIndex = 23;
            this.FireFoxPasswordLabel.Text = "Password:";
            // 
            // FireFoxUsernameLabel
            // 
            this.FireFoxUsernameLabel.Location = new System.Drawing.Point(327, 304);
            this.FireFoxUsernameLabel.Name = "FireFoxUsernameLabel";
            this.FireFoxUsernameLabel.Size = new System.Drawing.Size(52, 13);
            this.FireFoxUsernameLabel.TabIndex = 22;
            this.FireFoxUsernameLabel.Text = "Username:";
            // 
            // LoginPageUsername
            // 
            this.LoginPageUsername.Location = new System.Drawing.Point(385, 301);
            this.LoginPageUsername.MenuManager = this.tabFormDefaultManager1;
            this.LoginPageUsername.Name = "LoginPageUsername";
            this.LoginPageUsername.Size = new System.Drawing.Size(368, 20);
            this.LoginPageUsername.TabIndex = 21;
            // 
            // FireFoxCleanButton
            // 
            this.FireFoxCleanButton.Location = new System.Drawing.Point(3, 52);
            this.FireFoxCleanButton.Name = "FireFoxCleanButton";
            this.FireFoxCleanButton.Size = new System.Drawing.Size(305, 23);
            this.FireFoxCleanButton.TabIndex = 19;
            this.FireFoxCleanButton.Text = "Clean Them Up...";
            this.FireFoxCleanButton.Click += new System.EventHandler(this.FireFoxCleanButton_Click_1);
            // 
            // FireFoxCleanProgress
            // 
            this.FireFoxCleanProgress.Location = new System.Drawing.Point(3, 76);
            this.FireFoxCleanProgress.Name = "FireFoxCleanProgress";
            this.FireFoxCleanProgress.Size = new System.Drawing.Size(305, 328);
            this.FireFoxCleanProgress.TabIndex = 12;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(486, 379);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(139, 23);
            this.LoginButton.TabIndex = 18;
            this.LoginButton.Text = "Proceed...";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click_1);
            // 
            // LoginPagePassword
            // 
            this.LoginPagePassword.Location = new System.Drawing.Point(385, 327);
            this.LoginPagePassword.MenuManager = this.tabFormDefaultManager1;
            this.LoginPagePassword.Name = "LoginPagePassword";
            this.LoginPagePassword.Properties.PasswordChar = '*';
            this.LoginPagePassword.Size = new System.Drawing.Size(368, 20);
            this.LoginPagePassword.TabIndex = 14;
            // 
            // FireFoxMain
            // 
            this.FireFoxMain.ContentContainer = this.FireFoxTabPageLoginMain;
            this.FireFoxMain.Name = "FireFoxMain";
            this.FireFoxMain.Text = "Main";
            // 
            // FireFoxTabPageLoginMain
            // 
            this.FireFoxTabPageLoginMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FireFoxTabPageLoginMain.Location = new System.Drawing.Point(817, 64);
            this.FireFoxTabPageLoginMain.Name = "FireFoxTabPageLoginMain";
            this.FireFoxTabPageLoginMain.Size = new System.Drawing.Size(0, 410);
            this.FireFoxTabPageLoginMain.TabIndex = 11;
            // 
            // FireFoxWeaponPage
            // 
            this.FireFoxWeaponPage.ContentContainer = this.FireFoxTabPageWeapons;
            this.FireFoxWeaponPage.Name = "FireFoxWeaponPage";
            this.FireFoxWeaponPage.Text = "Weapon Spawning";
            // 
            // FireFoxTabPageWeapons
            // 
            this.FireFoxTabPageWeapons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FireFoxTabPageWeapons.Location = new System.Drawing.Point(817, 64);
            this.FireFoxTabPageWeapons.Name = "FireFoxTabPageWeapons";
            this.FireFoxTabPageWeapons.Size = new System.Drawing.Size(0, 410);
            this.FireFoxTabPageWeapons.TabIndex = 18;
            // 
            // FireFoxDataPageTab
            // 
            this.FireFoxDataPageTab.ContentContainer = this.FireFoxTabPageData;
            this.FireFoxDataPageTab.Name = "FireFoxDataPageTab";
            this.FireFoxDataPageTab.Text = "Data/Sales Analytics";
            // 
            // FireFoxTabPageData
            // 
            this.FireFoxTabPageData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FireFoxTabPageData.Location = new System.Drawing.Point(0, 64);
            this.FireFoxTabPageData.Name = "FireFoxTabPageData";
            this.FireFoxTabPageData.Size = new System.Drawing.Size(817, 410);
            this.FireFoxTabPageData.TabIndex = 24;
            // 
            // FireFoxAllCGB
            // 
            this.FireFoxAllCGB.Controls.Add(this.FireFoxUsePAPWeapons);
            this.FireFoxAllCGB.Controls.Add(this.FireFoxRapidFireOff);
            this.FireFoxAllCGB.Controls.Add(this.FireFoxRapidFireOn);
            this.FireFoxAllCGB.Controls.Add(this.FireFoxGodOn);
            this.FireFoxAllCGB.Controls.Add(this.FireFoxInstantKillOn);
            this.FireFoxAllCGB.Controls.Add(this.FireFoxInfraredOff);
            this.FireFoxAllCGB.Controls.Add(this.FireFoxTPZombiesOn);
            this.FireFoxAllCGB.Controls.Add(this.FireFoxUnlimitedAmmoOff);
            this.FireFoxAllCGB.Controls.Add(this.FireFoxInfraredOn);
            this.FireFoxAllCGB.Controls.Add(this.FireFoxCritKillsOff);
            this.FireFoxAllCGB.Controls.Add(this.FireFoxCritKillsOn);
            this.FireFoxAllCGB.Controls.Add(this.FireFoxTPZombiesOff);
            this.FireFoxAllCGB.Controls.Add(this.FireFoxUnlimitedAmmoOn);
            this.FireFoxAllCGB.Controls.Add(this.FireFoxInstantKillOff);
            this.FireFoxAllCGB.Controls.Add(this.FireFoxGodOff);
            this.FireFoxAllCGB.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.FireFoxAllCGB.Location = new System.Drawing.Point(410, 30);
            this.FireFoxAllCGB.Name = "FireFoxAllCGB";
            this.FireFoxAllCGB.Size = new System.Drawing.Size(277, 280);
            this.FireFoxAllCGB.TabIndex = 27;
            this.FireFoxAllCGB.Text = "All Client Options";
            // 
            // FireFoxUsePAPWeapons
            // 
            this.FireFoxUsePAPWeapons.EditValue = true;
            this.FireFoxUsePAPWeapons.Location = new System.Drawing.Point(5, 30);
            this.FireFoxUsePAPWeapons.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxUsePAPWeapons.Name = "FireFoxUsePAPWeapons";
            this.FireFoxUsePAPWeapons.Properties.Caption = "Check Here To Spawn PAP Version";
            this.FireFoxUsePAPWeapons.Size = new System.Drawing.Size(260, 19);
            this.FireFoxUsePAPWeapons.TabIndex = 29;
            // 
            // FireFoxRapidFireOff
            // 
            this.FireFoxRapidFireOff.Location = new System.Drawing.Point(138, 237);
            this.FireFoxRapidFireOff.Name = "FireFoxRapidFireOff";
            this.FireFoxRapidFireOff.Size = new System.Drawing.Size(127, 23);
            this.FireFoxRapidFireOff.TabIndex = 27;
            this.FireFoxRapidFireOff.Text = "Disable RapidFire";
            this.FireFoxRapidFireOff.Click += new System.EventHandler(this.FireFoxRapidFireOff_Click);
            // 
            // FireFoxRapidFireOn
            // 
            this.FireFoxRapidFireOn.Location = new System.Drawing.Point(5, 237);
            this.FireFoxRapidFireOn.Name = "FireFoxRapidFireOn";
            this.FireFoxRapidFireOn.Size = new System.Drawing.Size(127, 23);
            this.FireFoxRapidFireOn.TabIndex = 26;
            this.FireFoxRapidFireOn.Text = "Enable RapidFire";
            this.FireFoxRapidFireOn.Click += new System.EventHandler(this.FireFoxRapidFireOn_Click);
            // 
            // FireFoxGodOn
            // 
            this.FireFoxGodOn.Location = new System.Drawing.Point(5, 57);
            this.FireFoxGodOn.Name = "FireFoxGodOn";
            this.FireFoxGodOn.Size = new System.Drawing.Size(127, 23);
            this.FireFoxGodOn.TabIndex = 14;
            this.FireFoxGodOn.Text = "Enable God Mode";
            this.FireFoxGodOn.Click += new System.EventHandler(this.FireFoxGodOn_Click);
            // 
            // FireFoxInstantKillOn
            // 
            this.FireFoxInstantKillOn.Location = new System.Drawing.Point(5, 87);
            this.FireFoxInstantKillOn.Name = "FireFoxInstantKillOn";
            this.FireFoxInstantKillOn.Size = new System.Drawing.Size(127, 23);
            this.FireFoxInstantKillOn.TabIndex = 16;
            this.FireFoxInstantKillOn.Text = "Enable Instant Kill";
            this.FireFoxInstantKillOn.Click += new System.EventHandler(this.FireFoxInstantKillOn_Click);
            // 
            // FireFoxInfraredOff
            // 
            this.FireFoxInfraredOff.Location = new System.Drawing.Point(138, 207);
            this.FireFoxInfraredOff.Name = "FireFoxInfraredOff";
            this.FireFoxInfraredOff.Size = new System.Drawing.Size(127, 23);
            this.FireFoxInfraredOff.TabIndex = 25;
            this.FireFoxInfraredOff.Text = "Disable Infrared Vision";
            this.FireFoxInfraredOff.Click += new System.EventHandler(this.FireFoxInfraredOff_Click);
            // 
            // FireFoxTPZombiesOn
            // 
            this.FireFoxTPZombiesOn.Location = new System.Drawing.Point(5, 117);
            this.FireFoxTPZombiesOn.Name = "FireFoxTPZombiesOn";
            this.FireFoxTPZombiesOn.Size = new System.Drawing.Size(127, 23);
            this.FireFoxTPZombiesOn.TabIndex = 18;
            this.FireFoxTPZombiesOn.Text = "Enable Teleport Zombies";
            this.FireFoxTPZombiesOn.Click += new System.EventHandler(this.FireFoxTPZombiesOn_Click);
            // 
            // FireFoxUnlimitedAmmoOff
            // 
            this.FireFoxUnlimitedAmmoOff.Location = new System.Drawing.Point(138, 177);
            this.FireFoxUnlimitedAmmoOff.Name = "FireFoxUnlimitedAmmoOff";
            this.FireFoxUnlimitedAmmoOff.Size = new System.Drawing.Size(127, 23);
            this.FireFoxUnlimitedAmmoOff.TabIndex = 23;
            this.FireFoxUnlimitedAmmoOff.Text = "Disable Unlimited Ammo";
            this.FireFoxUnlimitedAmmoOff.Click += new System.EventHandler(this.FireFoxUnlimitedAmmoOff_Click);
            // 
            // FireFoxInfraredOn
            // 
            this.FireFoxInfraredOn.Location = new System.Drawing.Point(5, 207);
            this.FireFoxInfraredOn.Name = "FireFoxInfraredOn";
            this.FireFoxInfraredOn.Size = new System.Drawing.Size(127, 23);
            this.FireFoxInfraredOn.TabIndex = 24;
            this.FireFoxInfraredOn.Text = "Enable Infrared Vision";
            this.FireFoxInfraredOn.Click += new System.EventHandler(this.FireFoxInfraredOn_Click);
            // 
            // FireFoxCritKillsOff
            // 
            this.FireFoxCritKillsOff.Location = new System.Drawing.Point(138, 147);
            this.FireFoxCritKillsOff.Name = "FireFoxCritKillsOff";
            this.FireFoxCritKillsOff.Size = new System.Drawing.Size(127, 23);
            this.FireFoxCritKillsOff.TabIndex = 21;
            this.FireFoxCritKillsOff.Text = "Disable Critical Kills";
            this.FireFoxCritKillsOff.Click += new System.EventHandler(this.FireFoxCritKillsOff_Click);
            // 
            // FireFoxCritKillsOn
            // 
            this.FireFoxCritKillsOn.Location = new System.Drawing.Point(5, 147);
            this.FireFoxCritKillsOn.Name = "FireFoxCritKillsOn";
            this.FireFoxCritKillsOn.Size = new System.Drawing.Size(127, 23);
            this.FireFoxCritKillsOn.TabIndex = 20;
            this.FireFoxCritKillsOn.Text = "Enable Critical Kills";
            this.FireFoxCritKillsOn.Click += new System.EventHandler(this.FireFoxCritKillsOn_Click);
            // 
            // FireFoxTPZombiesOff
            // 
            this.FireFoxTPZombiesOff.Location = new System.Drawing.Point(138, 117);
            this.FireFoxTPZombiesOff.Name = "FireFoxTPZombiesOff";
            this.FireFoxTPZombiesOff.Size = new System.Drawing.Size(127, 23);
            this.FireFoxTPZombiesOff.TabIndex = 19;
            this.FireFoxTPZombiesOff.Text = "Disable Teleport Zombies";
            this.FireFoxTPZombiesOff.Click += new System.EventHandler(this.FireFoxTPZombiesOff_Click);
            // 
            // FireFoxUnlimitedAmmoOn
            // 
            this.FireFoxUnlimitedAmmoOn.Location = new System.Drawing.Point(5, 177);
            this.FireFoxUnlimitedAmmoOn.Name = "FireFoxUnlimitedAmmoOn";
            this.FireFoxUnlimitedAmmoOn.Size = new System.Drawing.Size(127, 23);
            this.FireFoxUnlimitedAmmoOn.TabIndex = 22;
            this.FireFoxUnlimitedAmmoOn.Text = "Enable Unlimited Ammo";
            this.FireFoxUnlimitedAmmoOn.Click += new System.EventHandler(this.FireFoxUnlimitedAmmoOn_Click);
            // 
            // FireFoxInstantKillOff
            // 
            this.FireFoxInstantKillOff.Location = new System.Drawing.Point(138, 87);
            this.FireFoxInstantKillOff.Name = "FireFoxInstantKillOff";
            this.FireFoxInstantKillOff.Size = new System.Drawing.Size(127, 23);
            this.FireFoxInstantKillOff.TabIndex = 17;
            this.FireFoxInstantKillOff.Text = "Disable Instant Kill";
            this.FireFoxInstantKillOff.Click += new System.EventHandler(this.FireFoxInstantKillOff_Click);
            // 
            // FireFoxGodOff
            // 
            this.FireFoxGodOff.Location = new System.Drawing.Point(138, 57);
            this.FireFoxGodOff.Name = "FireFoxGodOff";
            this.FireFoxGodOff.Size = new System.Drawing.Size(127, 23);
            this.FireFoxGodOff.TabIndex = 15;
            this.FireFoxGodOff.Text = "Disable God Mode";
            this.FireFoxGodOff.Click += new System.EventHandler(this.FireFoxGodOff_Click);
            // 
            // FireFoxPLGB
            // 
            this.FireFoxPLGB.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.FireFoxPLGB.Controls.Add(this.FireFoxPLUpdate);
            this.FireFoxPLGB.Controls.Add(this.FireFoxConnect);
            this.FireFoxPLGB.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.FireFoxPLGB.Location = new System.Drawing.Point(136, 30);
            this.FireFoxPLGB.Name = "FireFoxPLGB";
            this.FireFoxPLGB.Size = new System.Drawing.Size(268, 280);
            this.FireFoxPLGB.TabIndex = 26;
            this.FireFoxPLGB.Text = "Players List";
            // 
            // FireFoxPLUpdate
            // 
            this.FireFoxPLUpdate.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FireFoxPLUpdate.Appearance.ForeColor = System.Drawing.Color.White;
            this.FireFoxPLUpdate.Appearance.Options.UseBackColor = true;
            this.FireFoxPLUpdate.Appearance.Options.UseFont = true;
            this.FireFoxPLUpdate.Appearance.Options.UseForeColor = true;
            this.FireFoxPLUpdate.AppearanceHighlight.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxPLUpdate.AppearanceHighlight.BackColor2 = System.Drawing.Color.Transparent;
            this.FireFoxPLUpdate.AppearanceHighlight.BorderColor = System.Drawing.Color.Transparent;
            this.FireFoxPLUpdate.AppearanceHighlight.ForeColor = System.Drawing.Color.Transparent;
            this.FireFoxPLUpdate.AppearanceHighlight.Options.UseBackColor = true;
            this.FireFoxPLUpdate.AppearanceHighlight.Options.UseBorderColor = true;
            this.FireFoxPLUpdate.AppearanceHighlight.Options.UseForeColor = true;
            this.FireFoxPLUpdate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.FireFoxPLUpdate.ContextButtonOptions.HoverStateOpacity = 0F;
            this.FireFoxPLUpdate.ContextMenuStrip = this.FireFoxClientsCMS;
            this.FireFoxPLUpdate.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.FireFoxPLUpdate.Location = new System.Drawing.Point(6, 57);
            this.FireFoxPLUpdate.LookAndFeel.UseWindowsXPTheme = true;
            this.FireFoxPLUpdate.Name = "FireFoxPLUpdate";
            this.FireFoxPLUpdate.Size = new System.Drawing.Size(256, 217);
            this.FireFoxPLUpdate.TabIndex = 0;
            this.FireFoxPLUpdate.SelectedIndexChanged += new System.EventHandler(this.FireFoxPLUpdate_SelectedIndexChanged);
            // 
            // FireFoxClientsCMS
            // 
            this.FireFoxClientsCMS.ForeColor = System.Drawing.Color.White;
            this.FireFoxClientsCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.godModeToolStripMenuItem,
            this.infraredVisionToolStripMenuItem,
            this.rapidFireToolStripMenuItem,
            this.disablePlayerToolStripMenuItem,
            this.addPointsToolStripMenuItem,
            this.FireFoxCMSWeapons,
            this.teleportToolStripMenuItem});
            this.FireFoxClientsCMS.Name = "FireFoxClientsCMS";
            this.FireFoxClientsCMS.Size = new System.Drawing.Size(151, 158);
            // 
            // godModeToolStripMenuItem
            // 
            this.godModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem,
            this.disableToolStripMenuItem});
            this.godModeToolStripMenuItem.Name = "godModeToolStripMenuItem";
            this.godModeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.godModeToolStripMenuItem.Text = "God Mode";
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.enableToolStripMenuItem.Text = "Enable";
            this.enableToolStripMenuItem.Click += new System.EventHandler(this.enableToolStripMenuItem_Click);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.disableToolStripMenuItem.Text = "Disable";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // infraredVisionToolStripMenuItem
            // 
            this.infraredVisionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem1,
            this.toolStripMenuItem2});
            this.infraredVisionToolStripMenuItem.Name = "infraredVisionToolStripMenuItem";
            this.infraredVisionToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.infraredVisionToolStripMenuItem.Text = "Infrared Vision";
            // 
            // enableToolStripMenuItem1
            // 
            this.enableToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.enableToolStripMenuItem1.Name = "enableToolStripMenuItem1";
            this.enableToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.enableToolStripMenuItem1.Text = "Enable";
            this.enableToolStripMenuItem1.Click += new System.EventHandler(this.enableToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem2.Text = "Disable";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // rapidFireToolStripMenuItem
            // 
            this.rapidFireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem2,
            this.disableToolStripMenuItem1});
            this.rapidFireToolStripMenuItem.Name = "rapidFireToolStripMenuItem";
            this.rapidFireToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.rapidFireToolStripMenuItem.Text = "Rapid Fire";
            // 
            // enableToolStripMenuItem2
            // 
            this.enableToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.enableToolStripMenuItem2.Name = "enableToolStripMenuItem2";
            this.enableToolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.enableToolStripMenuItem2.Text = "Enable";
            this.enableToolStripMenuItem2.Click += new System.EventHandler(this.enableToolStripMenuItem2_Click);
            // 
            // disableToolStripMenuItem1
            // 
            this.disableToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.disableToolStripMenuItem1.Name = "disableToolStripMenuItem1";
            this.disableToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.disableToolStripMenuItem1.Text = "Disable";
            this.disableToolStripMenuItem1.Click += new System.EventHandler(this.disableToolStripMenuItem1_Click);
            // 
            // disablePlayerToolStripMenuItem
            // 
            this.disablePlayerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem3,
            this.disableToolStripMenuItem2});
            this.disablePlayerToolStripMenuItem.Name = "disablePlayerToolStripMenuItem";
            this.disablePlayerToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.disablePlayerToolStripMenuItem.Text = "Disable Player";
            // 
            // enableToolStripMenuItem3
            // 
            this.enableToolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.enableToolStripMenuItem3.Name = "enableToolStripMenuItem3";
            this.enableToolStripMenuItem3.Size = new System.Drawing.Size(112, 22);
            this.enableToolStripMenuItem3.Text = "Enable";
            this.enableToolStripMenuItem3.Click += new System.EventHandler(this.enableToolStripMenuItem3_Click);
            // 
            // disableToolStripMenuItem2
            // 
            this.disableToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.disableToolStripMenuItem2.Name = "disableToolStripMenuItem2";
            this.disableToolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.disableToolStripMenuItem2.Text = "Disable";
            this.disableToolStripMenuItem2.Click += new System.EventHandler(this.disableToolStripMenuItem2_Click);
            // 
            // addPointsToolStripMenuItem
            // 
            this.addPointsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add1000PointsToolStripMenuItem,
            this.add10000PointsToolStripMenuItem,
            this.add100000PointsToolStripMenuItem,
            this.add1000000PointsToolStripMenuItem,
            this.add10000000PointsToolStripMenuItem,
            this.add100000000PointsToolStripMenuItem});
            this.addPointsToolStripMenuItem.Name = "addPointsToolStripMenuItem";
            this.addPointsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addPointsToolStripMenuItem.Text = "Add Points";
            // 
            // add1000PointsToolStripMenuItem
            // 
            this.add1000PointsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.add1000PointsToolStripMenuItem.Name = "add1000PointsToolStripMenuItem";
            this.add1000PointsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.add1000PointsToolStripMenuItem.Text = "Add 1,000 Points";
            this.add1000PointsToolStripMenuItem.Click += new System.EventHandler(this.add1000PointsToolStripMenuItem_Click);
            // 
            // add10000PointsToolStripMenuItem
            // 
            this.add10000PointsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.add10000PointsToolStripMenuItem.Name = "add10000PointsToolStripMenuItem";
            this.add10000PointsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.add10000PointsToolStripMenuItem.Text = "Add 10,000 Points";
            this.add10000PointsToolStripMenuItem.Click += new System.EventHandler(this.add10000PointsToolStripMenuItem_Click);
            // 
            // add100000PointsToolStripMenuItem
            // 
            this.add100000PointsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.add100000PointsToolStripMenuItem.Name = "add100000PointsToolStripMenuItem";
            this.add100000PointsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.add100000PointsToolStripMenuItem.Text = "Add 100,000 Points";
            this.add100000PointsToolStripMenuItem.Click += new System.EventHandler(this.add100000PointsToolStripMenuItem_Click);
            // 
            // add1000000PointsToolStripMenuItem
            // 
            this.add1000000PointsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.add1000000PointsToolStripMenuItem.Name = "add1000000PointsToolStripMenuItem";
            this.add1000000PointsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.add1000000PointsToolStripMenuItem.Text = "Add 1,000,000 Points";
            this.add1000000PointsToolStripMenuItem.Click += new System.EventHandler(this.add1000000PointsToolStripMenuItem_Click);
            // 
            // add10000000PointsToolStripMenuItem
            // 
            this.add10000000PointsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.add10000000PointsToolStripMenuItem.Name = "add10000000PointsToolStripMenuItem";
            this.add10000000PointsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.add10000000PointsToolStripMenuItem.Text = "Add 10,000,000 Points";
            this.add10000000PointsToolStripMenuItem.Click += new System.EventHandler(this.add10000000PointsToolStripMenuItem_Click);
            // 
            // add100000000PointsToolStripMenuItem
            // 
            this.add100000000PointsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.add100000000PointsToolStripMenuItem.Name = "add100000000PointsToolStripMenuItem";
            this.add100000000PointsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.add100000000PointsToolStripMenuItem.Text = "Add 100,000,000 Points";
            this.add100000000PointsToolStripMenuItem.Click += new System.EventHandler(this.add100000000PointsToolStripMenuItem_Click);
            // 
            // FireFoxCMSWeapons
            // 
            this.FireFoxCMSWeapons.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FireFoxWeaponSpawnAssult,
            this.FireFoxWeaponSpawnSMGs,
            this.FireFoxWeaponSpawnTACs,
            this.FireFoxWeaponSpawnLMGs,
            this.FireFoxWeaponSpawnSnipers,
            this.FireFoxWeaponSpawnShotguns,
            this.FireFoxWeaponSpawnPistols,
            this.toolStripMenuItem39,
            this.FireFoxWeaponSpawnMelee,
            this.FireFoxWeaponSpawnSpecial,
            this.FireFoxWeaponSpawnDLC,
            this.FireFoxWeaponSpawnWonderWeapons,
            this.FireFoxWeaponSpawnFieldUpgrades,
            this.FireFoxWeaponSpawnMisc});
            this.FireFoxCMSWeapons.Name = "FireFoxCMSWeapons";
            this.FireFoxCMSWeapons.Size = new System.Drawing.Size(150, 22);
            this.FireFoxCMSWeapons.Text = "Weapons";
            // 
            // FireFoxWeaponSpawnAssult
            // 
            this.FireFoxWeaponSpawnAssult.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FireFoxWeaponSpawnXM4,
            this.FireFoxWeaponSpawnAK47,
            this.FireFoxWeaponSpawnKraig6,
            this.FireFoxWeaponSpawnQBZ83,
            this.FireFoxWeaponSpawnGroza,
            this.FireFoxWeaponSpawnFARA1});
            this.FireFoxWeaponSpawnAssult.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnAssult.Name = "FireFoxWeaponSpawnAssult";
            this.FireFoxWeaponSpawnAssult.Size = new System.Drawing.Size(210, 22);
            this.FireFoxWeaponSpawnAssult.Text = "Assult Rifles";
            // 
            // FireFoxWeaponSpawnXM4
            // 
            this.FireFoxWeaponSpawnXM4.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnXM4.Name = "FireFoxWeaponSpawnXM4";
            this.FireFoxWeaponSpawnXM4.Size = new System.Drawing.Size(114, 22);
            this.FireFoxWeaponSpawnXM4.Text = "XM4";
            this.FireFoxWeaponSpawnXM4.Click += new System.EventHandler(this.FireFoxWeaponSpawnXM4_Click);
            // 
            // FireFoxWeaponSpawnAK47
            // 
            this.FireFoxWeaponSpawnAK47.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnAK47.Name = "FireFoxWeaponSpawnAK47";
            this.FireFoxWeaponSpawnAK47.Size = new System.Drawing.Size(114, 22);
            this.FireFoxWeaponSpawnAK47.Text = "AK47";
            this.FireFoxWeaponSpawnAK47.Click += new System.EventHandler(this.FireFoxWeaponSpawnAK47_Click);
            // 
            // FireFoxWeaponSpawnKraig6
            // 
            this.FireFoxWeaponSpawnKraig6.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnKraig6.Name = "FireFoxWeaponSpawnKraig6";
            this.FireFoxWeaponSpawnKraig6.Size = new System.Drawing.Size(114, 22);
            this.FireFoxWeaponSpawnKraig6.Text = "Kraig 6";
            this.FireFoxWeaponSpawnKraig6.Click += new System.EventHandler(this.FireFoxWeaponSpawnKraig6_Click);
            // 
            // FireFoxWeaponSpawnQBZ83
            // 
            this.FireFoxWeaponSpawnQBZ83.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnQBZ83.Name = "FireFoxWeaponSpawnQBZ83";
            this.FireFoxWeaponSpawnQBZ83.Size = new System.Drawing.Size(114, 22);
            this.FireFoxWeaponSpawnQBZ83.Text = "QBZ-83";
            this.FireFoxWeaponSpawnQBZ83.Click += new System.EventHandler(this.FireFoxWeaponSpawnQBZ83_Click);
            // 
            // FireFoxWeaponSpawnGroza
            // 
            this.FireFoxWeaponSpawnGroza.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnGroza.Name = "FireFoxWeaponSpawnGroza";
            this.FireFoxWeaponSpawnGroza.Size = new System.Drawing.Size(114, 22);
            this.FireFoxWeaponSpawnGroza.Text = "Groza";
            this.FireFoxWeaponSpawnGroza.Click += new System.EventHandler(this.FireFoxWeaponSpawnGroza_Click);
            // 
            // FireFoxWeaponSpawnFARA1
            // 
            this.FireFoxWeaponSpawnFARA1.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnFARA1.Name = "FireFoxWeaponSpawnFARA1";
            this.FireFoxWeaponSpawnFARA1.Size = new System.Drawing.Size(114, 22);
            this.FireFoxWeaponSpawnFARA1.Text = "FFAR 1";
            this.FireFoxWeaponSpawnFARA1.Click += new System.EventHandler(this.FireFoxWeaponSpawnFARA1_Click);
            // 
            // FireFoxWeaponSpawnSMGs
            // 
            this.FireFoxWeaponSpawnSMGs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FireFoxWeaponSpawnMP5,
            this.FireFoxWeaponSpawnMilano821,
            this.FireFoxWeaponSpawnAK74u,
            this.FireFoxWeaponSpawnKSP45,
            this.FireFoxWeaponSpawnBullfrog,
            this.FireFoxWeaponSpawnMAC10});
            this.FireFoxWeaponSpawnSMGs.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnSMGs.Name = "FireFoxWeaponSpawnSMGs";
            this.FireFoxWeaponSpawnSMGs.Size = new System.Drawing.Size(210, 22);
            this.FireFoxWeaponSpawnSMGs.Text = "Sub Machine";
            // 
            // FireFoxWeaponSpawnMP5
            // 
            this.FireFoxWeaponSpawnMP5.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnMP5.Name = "FireFoxWeaponSpawnMP5";
            this.FireFoxWeaponSpawnMP5.Size = new System.Drawing.Size(132, 22);
            this.FireFoxWeaponSpawnMP5.Text = "MP5";
            this.FireFoxWeaponSpawnMP5.Click += new System.EventHandler(this.FireFoxWeaponSpawnMP5_Click);
            // 
            // FireFoxWeaponSpawnMilano821
            // 
            this.FireFoxWeaponSpawnMilano821.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnMilano821.Name = "FireFoxWeaponSpawnMilano821";
            this.FireFoxWeaponSpawnMilano821.Size = new System.Drawing.Size(132, 22);
            this.FireFoxWeaponSpawnMilano821.Text = "Milano 821";
            this.FireFoxWeaponSpawnMilano821.Click += new System.EventHandler(this.FireFoxWeaponSpawnMilano821_Click);
            // 
            // FireFoxWeaponSpawnAK74u
            // 
            this.FireFoxWeaponSpawnAK74u.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnAK74u.Name = "FireFoxWeaponSpawnAK74u";
            this.FireFoxWeaponSpawnAK74u.Size = new System.Drawing.Size(132, 22);
            this.FireFoxWeaponSpawnAK74u.Text = "AK-74u";
            this.FireFoxWeaponSpawnAK74u.Click += new System.EventHandler(this.FireFoxWeaponSpawnAK74u_Click);
            // 
            // FireFoxWeaponSpawnKSP45
            // 
            this.FireFoxWeaponSpawnKSP45.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnKSP45.Name = "FireFoxWeaponSpawnKSP45";
            this.FireFoxWeaponSpawnKSP45.Size = new System.Drawing.Size(132, 22);
            this.FireFoxWeaponSpawnKSP45.Text = "KSP 45";
            this.FireFoxWeaponSpawnKSP45.Click += new System.EventHandler(this.FireFoxWeaponSpawnKSP45_Click);
            // 
            // FireFoxWeaponSpawnBullfrog
            // 
            this.FireFoxWeaponSpawnBullfrog.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnBullfrog.Name = "FireFoxWeaponSpawnBullfrog";
            this.FireFoxWeaponSpawnBullfrog.Size = new System.Drawing.Size(132, 22);
            this.FireFoxWeaponSpawnBullfrog.Text = "Bullfrog";
            this.FireFoxWeaponSpawnBullfrog.Click += new System.EventHandler(this.FireFoxWeaponSpawnBullfrog_Click);
            // 
            // FireFoxWeaponSpawnMAC10
            // 
            this.FireFoxWeaponSpawnMAC10.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnMAC10.Name = "FireFoxWeaponSpawnMAC10";
            this.FireFoxWeaponSpawnMAC10.Size = new System.Drawing.Size(132, 22);
            this.FireFoxWeaponSpawnMAC10.Text = "Mac-10";
            this.FireFoxWeaponSpawnMAC10.Click += new System.EventHandler(this.FireFoxWeaponSpawnMAC10_Click);
            // 
            // FireFoxWeaponSpawnTACs
            // 
            this.FireFoxWeaponSpawnTACs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FireFoxWeaponSpawnType63,
            this.FireFoxWeaponSpawnM16,
            this.FireFoxWeaponSpawnAUG,
            this.FireFoxWeaponSpawnDMR14});
            this.FireFoxWeaponSpawnTACs.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnTACs.Name = "FireFoxWeaponSpawnTACs";
            this.FireFoxWeaponSpawnTACs.Size = new System.Drawing.Size(210, 22);
            this.FireFoxWeaponSpawnTACs.Text = "Tactical Rifles";
            // 
            // FireFoxWeaponSpawnType63
            // 
            this.FireFoxWeaponSpawnType63.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnType63.Name = "FireFoxWeaponSpawnType63";
            this.FireFoxWeaponSpawnType63.Size = new System.Drawing.Size(115, 22);
            this.FireFoxWeaponSpawnType63.Text = "Type 63";
            this.FireFoxWeaponSpawnType63.Click += new System.EventHandler(this.FireFoxWeaponSpawnType63_Click);
            // 
            // FireFoxWeaponSpawnM16
            // 
            this.FireFoxWeaponSpawnM16.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnM16.Name = "FireFoxWeaponSpawnM16";
            this.FireFoxWeaponSpawnM16.Size = new System.Drawing.Size(115, 22);
            this.FireFoxWeaponSpawnM16.Text = "M16";
            this.FireFoxWeaponSpawnM16.Click += new System.EventHandler(this.FireFoxWeaponSpawnM16_Click);
            // 
            // FireFoxWeaponSpawnAUG
            // 
            this.FireFoxWeaponSpawnAUG.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnAUG.Name = "FireFoxWeaponSpawnAUG";
            this.FireFoxWeaponSpawnAUG.Size = new System.Drawing.Size(115, 22);
            this.FireFoxWeaponSpawnAUG.Text = "AUG";
            this.FireFoxWeaponSpawnAUG.Click += new System.EventHandler(this.FireFoxWeaponSpawnAUG_Click);
            // 
            // FireFoxWeaponSpawnDMR14
            // 
            this.FireFoxWeaponSpawnDMR14.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnDMR14.Name = "FireFoxWeaponSpawnDMR14";
            this.FireFoxWeaponSpawnDMR14.Size = new System.Drawing.Size(115, 22);
            this.FireFoxWeaponSpawnDMR14.Text = "DMR 14";
            this.FireFoxWeaponSpawnDMR14.Click += new System.EventHandler(this.FireFoxWeaponSpawnDMR14_Click);
            // 
            // FireFoxWeaponSpawnLMGs
            // 
            this.FireFoxWeaponSpawnLMGs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FireFoxWeaponSpawnStoner63,
            this.FireFoxWeaponSpawnM60,
            this.FireFoxWeaponSpawnRPD});
            this.FireFoxWeaponSpawnLMGs.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnLMGs.Name = "FireFoxWeaponSpawnLMGs";
            this.FireFoxWeaponSpawnLMGs.Size = new System.Drawing.Size(210, 22);
            this.FireFoxWeaponSpawnLMGs.Text = "LMG\'s";
            // 
            // FireFoxWeaponSpawnStoner63
            // 
            this.FireFoxWeaponSpawnStoner63.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnStoner63.Name = "FireFoxWeaponSpawnStoner63";
            this.FireFoxWeaponSpawnStoner63.Size = new System.Drawing.Size(123, 22);
            this.FireFoxWeaponSpawnStoner63.Text = "Stoner 63";
            this.FireFoxWeaponSpawnStoner63.Click += new System.EventHandler(this.FireFoxWeaponSpawnStoner63_Click);
            // 
            // FireFoxWeaponSpawnM60
            // 
            this.FireFoxWeaponSpawnM60.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnM60.Name = "FireFoxWeaponSpawnM60";
            this.FireFoxWeaponSpawnM60.Size = new System.Drawing.Size(123, 22);
            this.FireFoxWeaponSpawnM60.Text = "M60";
            this.FireFoxWeaponSpawnM60.Click += new System.EventHandler(this.FireFoxWeaponSpawnM60_Click);
            // 
            // FireFoxWeaponSpawnRPD
            // 
            this.FireFoxWeaponSpawnRPD.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnRPD.Name = "FireFoxWeaponSpawnRPD";
            this.FireFoxWeaponSpawnRPD.Size = new System.Drawing.Size(123, 22);
            this.FireFoxWeaponSpawnRPD.Text = "RPD";
            this.FireFoxWeaponSpawnRPD.Click += new System.EventHandler(this.FireFoxWeaponSpawnRPD_Click);
            // 
            // FireFoxWeaponSpawnSnipers
            // 
            this.FireFoxWeaponSpawnSnipers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FireFoxWeaponSpawnPellington703,
            this.FireFoxWeaponSpawnLW3Tundra,
            this.FireFoxWeaponSpawnM82});
            this.FireFoxWeaponSpawnSnipers.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnSnipers.Name = "FireFoxWeaponSpawnSnipers";
            this.FireFoxWeaponSpawnSnipers.Size = new System.Drawing.Size(210, 22);
            this.FireFoxWeaponSpawnSnipers.Text = "Snipers";
            // 
            // FireFoxWeaponSpawnPellington703
            // 
            this.FireFoxWeaponSpawnPellington703.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnPellington703.Name = "FireFoxWeaponSpawnPellington703";
            this.FireFoxWeaponSpawnPellington703.Size = new System.Drawing.Size(149, 22);
            this.FireFoxWeaponSpawnPellington703.Text = "Pellington 703";
            this.FireFoxWeaponSpawnPellington703.Click += new System.EventHandler(this.FireFoxWeaponSpawnPellington703_Click);
            // 
            // FireFoxWeaponSpawnLW3Tundra
            // 
            this.FireFoxWeaponSpawnLW3Tundra.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnLW3Tundra.Name = "FireFoxWeaponSpawnLW3Tundra";
            this.FireFoxWeaponSpawnLW3Tundra.Size = new System.Drawing.Size(149, 22);
            this.FireFoxWeaponSpawnLW3Tundra.Text = "LW3-Tundra ";
            this.FireFoxWeaponSpawnLW3Tundra.Click += new System.EventHandler(this.FireFoxWeaponSpawnLW3Tundra_Click);
            // 
            // FireFoxWeaponSpawnM82
            // 
            this.FireFoxWeaponSpawnM82.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnM82.Name = "FireFoxWeaponSpawnM82";
            this.FireFoxWeaponSpawnM82.Size = new System.Drawing.Size(149, 22);
            this.FireFoxWeaponSpawnM82.Text = "M82";
            this.FireFoxWeaponSpawnM82.Click += new System.EventHandler(this.FireFoxWeaponSpawnM82_Click);
            // 
            // FireFoxWeaponSpawnShotguns
            // 
            this.FireFoxWeaponSpawnShotguns.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FireFoxWeaponSpawnHauer,
            this.FireFoxWeaponSpawnGalloSA12,
            this.FireFoxWeaponSpawnStreetSweeper});
            this.FireFoxWeaponSpawnShotguns.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnShotguns.Name = "FireFoxWeaponSpawnShotguns";
            this.FireFoxWeaponSpawnShotguns.Size = new System.Drawing.Size(210, 22);
            this.FireFoxWeaponSpawnShotguns.Text = "Shotguns";
            // 
            // FireFoxWeaponSpawnHauer
            // 
            this.FireFoxWeaponSpawnHauer.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnHauer.Name = "FireFoxWeaponSpawnHauer";
            this.FireFoxWeaponSpawnHauer.Size = new System.Drawing.Size(151, 22);
            this.FireFoxWeaponSpawnHauer.Text = "Hauer 77";
            this.FireFoxWeaponSpawnHauer.Click += new System.EventHandler(this.FireFoxWeaponSpawnHauer_Click);
            // 
            // FireFoxWeaponSpawnGalloSA12
            // 
            this.FireFoxWeaponSpawnGalloSA12.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnGalloSA12.Name = "FireFoxWeaponSpawnGalloSA12";
            this.FireFoxWeaponSpawnGalloSA12.Size = new System.Drawing.Size(151, 22);
            this.FireFoxWeaponSpawnGalloSA12.Text = "Gallo SA12";
            this.FireFoxWeaponSpawnGalloSA12.Click += new System.EventHandler(this.FireFoxWeaponSpawnGalloSA12_Click);
            // 
            // FireFoxWeaponSpawnStreetSweeper
            // 
            this.FireFoxWeaponSpawnStreetSweeper.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnStreetSweeper.Name = "FireFoxWeaponSpawnStreetSweeper";
            this.FireFoxWeaponSpawnStreetSweeper.Size = new System.Drawing.Size(151, 22);
            this.FireFoxWeaponSpawnStreetSweeper.Text = "Street Sweeper";
            this.FireFoxWeaponSpawnStreetSweeper.Click += new System.EventHandler(this.FireFoxWeaponSpawnStreetSweeper_Click);
            // 
            // FireFoxWeaponSpawnPistols
            // 
            this.FireFoxWeaponSpawnPistols.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FireFoxWeaponSpawn1911,
            this.FireFoxWeaponSpawnMagnum,
            this.FireFoxWeaponSpawnDiamatti});
            this.FireFoxWeaponSpawnPistols.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnPistols.Name = "FireFoxWeaponSpawnPistols";
            this.FireFoxWeaponSpawnPistols.Size = new System.Drawing.Size(210, 22);
            this.FireFoxWeaponSpawnPistols.Text = "Pistols";
            // 
            // FireFoxWeaponSpawn1911
            // 
            this.FireFoxWeaponSpawn1911.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawn1911.Name = "FireFoxWeaponSpawn1911";
            this.FireFoxWeaponSpawn1911.Size = new System.Drawing.Size(123, 22);
            this.FireFoxWeaponSpawn1911.Text = "1911";
            this.FireFoxWeaponSpawn1911.Click += new System.EventHandler(this.FireFoxWeaponSpawn1911_Click);
            // 
            // FireFoxWeaponSpawnMagnum
            // 
            this.FireFoxWeaponSpawnMagnum.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnMagnum.Name = "FireFoxWeaponSpawnMagnum";
            this.FireFoxWeaponSpawnMagnum.Size = new System.Drawing.Size(123, 22);
            this.FireFoxWeaponSpawnMagnum.Text = "Magnum";
            this.FireFoxWeaponSpawnMagnum.Click += new System.EventHandler(this.FireFoxWeaponSpawnMagnum_Click);
            // 
            // FireFoxWeaponSpawnDiamatti
            // 
            this.FireFoxWeaponSpawnDiamatti.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnDiamatti.Name = "FireFoxWeaponSpawnDiamatti";
            this.FireFoxWeaponSpawnDiamatti.Size = new System.Drawing.Size(123, 22);
            this.FireFoxWeaponSpawnDiamatti.Text = "Diamatti";
            this.FireFoxWeaponSpawnDiamatti.Click += new System.EventHandler(this.FireFoxWeaponSpawnDiamatti_Click);
            // 
            // toolStripMenuItem39
            // 
            this.toolStripMenuItem39.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FireFoxWeaponSpawnRPG7,
            this.FireFoxWeaponSpawnCigma2});
            this.toolStripMenuItem39.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem39.Name = "toolStripMenuItem39";
            this.toolStripMenuItem39.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItem39.Text = "Launchers";
            // 
            // FireFoxWeaponSpawnRPG7
            // 
            this.FireFoxWeaponSpawnRPG7.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnRPG7.Name = "FireFoxWeaponSpawnRPG7";
            this.FireFoxWeaponSpawnRPG7.Size = new System.Drawing.Size(118, 22);
            this.FireFoxWeaponSpawnRPG7.Text = "RPG-7";
            this.FireFoxWeaponSpawnRPG7.Click += new System.EventHandler(this.FireFoxWeaponSpawnRPG7_Click);
            // 
            // FireFoxWeaponSpawnCigma2
            // 
            this.FireFoxWeaponSpawnCigma2.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnCigma2.Name = "FireFoxWeaponSpawnCigma2";
            this.FireFoxWeaponSpawnCigma2.Size = new System.Drawing.Size(118, 22);
            this.FireFoxWeaponSpawnCigma2.Text = "Cigma 2";
            this.FireFoxWeaponSpawnCigma2.Click += new System.EventHandler(this.Cigma2_Click);
            // 
            // FireFoxWeaponSpawnMelee
            // 
            this.FireFoxWeaponSpawnMelee.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FireFoxWeaponSpawnKnife,
            this.FireFoxWeaponSpawnSledgehammer,
            this.FireFoxWeaponSpawnWakizashi});
            this.FireFoxWeaponSpawnMelee.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnMelee.Name = "FireFoxWeaponSpawnMelee";
            this.FireFoxWeaponSpawnMelee.Size = new System.Drawing.Size(210, 22);
            this.FireFoxWeaponSpawnMelee.Text = "Melee";
            // 
            // FireFoxWeaponSpawnKnife
            // 
            this.FireFoxWeaponSpawnKnife.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnKnife.Name = "FireFoxWeaponSpawnKnife";
            this.FireFoxWeaponSpawnKnife.Size = new System.Drawing.Size(154, 22);
            this.FireFoxWeaponSpawnKnife.Text = "Knife";
            this.FireFoxWeaponSpawnKnife.Click += new System.EventHandler(this.FireFoxWeaponSpawnKnife_Click);
            // 
            // FireFoxWeaponSpawnSledgehammer
            // 
            this.FireFoxWeaponSpawnSledgehammer.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnSledgehammer.Name = "FireFoxWeaponSpawnSledgehammer";
            this.FireFoxWeaponSpawnSledgehammer.Size = new System.Drawing.Size(154, 22);
            this.FireFoxWeaponSpawnSledgehammer.Text = "Sledgehammer";
            this.FireFoxWeaponSpawnSledgehammer.Click += new System.EventHandler(this.FireFoxWeaponSpawnSledgehammer_Click);
            // 
            // FireFoxWeaponSpawnWakizashi
            // 
            this.FireFoxWeaponSpawnWakizashi.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnWakizashi.Name = "FireFoxWeaponSpawnWakizashi";
            this.FireFoxWeaponSpawnWakizashi.Size = new System.Drawing.Size(154, 22);
            this.FireFoxWeaponSpawnWakizashi.Text = "Wakizashi";
            this.FireFoxWeaponSpawnWakizashi.Click += new System.EventHandler(this.FireFoxWeaponSpawnWakizashi_Click);
            // 
            // FireFoxWeaponSpawnSpecial
            // 
            this.FireFoxWeaponSpawnSpecial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FireFoxWeaponSpawnM79});
            this.FireFoxWeaponSpawnSpecial.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnSpecial.Name = "FireFoxWeaponSpawnSpecial";
            this.FireFoxWeaponSpawnSpecial.Size = new System.Drawing.Size(210, 22);
            this.FireFoxWeaponSpawnSpecial.Text = "Specials";
            // 
            // FireFoxWeaponSpawnM79
            // 
            this.FireFoxWeaponSpawnM79.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnM79.Name = "FireFoxWeaponSpawnM79";
            this.FireFoxWeaponSpawnM79.Size = new System.Drawing.Size(97, 22);
            this.FireFoxWeaponSpawnM79.Text = "M79";
            this.FireFoxWeaponSpawnM79.Click += new System.EventHandler(this.FireFoxWeaponSpawnM79_Click);
            // 
            // FireFoxWeaponSpawnDLC
            // 
            this.FireFoxWeaponSpawnDLC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FireFoxWeaponSpawnFARA83,
            this.FireFoxWeaponSpawnLC10,
            this.FireFoxWeaponSpawnMachete,
            this.FireFoxWeaponSpawnCrossbow,
            this.FireFoxWeaponSpawnPPSH41,
            this.FireFoxWeaponSpawnEtool,
            this.FireFoxWeaponSpawnBallisticKnife,
            this.FireFoxWeaponSpawnZRG20MM,
            this.FireFoxWeaponSpawnSwissK31,
            this.FireFoxWeaponSpawnCARV2});
            this.FireFoxWeaponSpawnDLC.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnDLC.Name = "FireFoxWeaponSpawnDLC";
            this.FireFoxWeaponSpawnDLC.Size = new System.Drawing.Size(210, 22);
            this.FireFoxWeaponSpawnDLC.Text = "DLC Weapons";
            // 
            // FireFoxWeaponSpawnFARA83
            // 
            this.FireFoxWeaponSpawnFARA83.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnFARA83.Name = "FireFoxWeaponSpawnFARA83";
            this.FireFoxWeaponSpawnFARA83.Size = new System.Drawing.Size(147, 22);
            this.FireFoxWeaponSpawnFARA83.Text = "FARA 83";
            this.FireFoxWeaponSpawnFARA83.Click += new System.EventHandler(this.FireFoxWeaponSpawnFARA83_Click);
            // 
            // FireFoxWeaponSpawnLC10
            // 
            this.FireFoxWeaponSpawnLC10.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnLC10.Name = "FireFoxWeaponSpawnLC10";
            this.FireFoxWeaponSpawnLC10.Size = new System.Drawing.Size(147, 22);
            this.FireFoxWeaponSpawnLC10.Text = "LC 10";
            this.FireFoxWeaponSpawnLC10.Click += new System.EventHandler(this.FireFoxWeaponSpawnLC10_Click);
            // 
            // FireFoxWeaponSpawnMachete
            // 
            this.FireFoxWeaponSpawnMachete.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnMachete.Name = "FireFoxWeaponSpawnMachete";
            this.FireFoxWeaponSpawnMachete.Size = new System.Drawing.Size(147, 22);
            this.FireFoxWeaponSpawnMachete.Text = "Machete";
            this.FireFoxWeaponSpawnMachete.Click += new System.EventHandler(this.FireFoxWeaponSpawnMachete_Click);
            // 
            // FireFoxWeaponSpawnCrossbow
            // 
            this.FireFoxWeaponSpawnCrossbow.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnCrossbow.Name = "FireFoxWeaponSpawnCrossbow";
            this.FireFoxWeaponSpawnCrossbow.Size = new System.Drawing.Size(147, 22);
            this.FireFoxWeaponSpawnCrossbow.Text = "Crossbow";
            this.FireFoxWeaponSpawnCrossbow.Click += new System.EventHandler(this.FireFoxWeaponSpawnCrossbow_Click);
            // 
            // FireFoxWeaponSpawnPPSH41
            // 
            this.FireFoxWeaponSpawnPPSH41.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnPPSH41.Name = "FireFoxWeaponSpawnPPSH41";
            this.FireFoxWeaponSpawnPPSH41.Size = new System.Drawing.Size(147, 22);
            this.FireFoxWeaponSpawnPPSH41.Text = "PPSh-41";
            this.FireFoxWeaponSpawnPPSH41.Click += new System.EventHandler(this.FireFoxWeaponSpawnPPSH41_Click);
            // 
            // FireFoxWeaponSpawnEtool
            // 
            this.FireFoxWeaponSpawnEtool.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnEtool.Name = "FireFoxWeaponSpawnEtool";
            this.FireFoxWeaponSpawnEtool.Size = new System.Drawing.Size(147, 22);
            this.FireFoxWeaponSpawnEtool.Text = "E-Tool";
            this.FireFoxWeaponSpawnEtool.Click += new System.EventHandler(this.FireFoxWeaponSpawnEtool_Click);
            // 
            // FireFoxWeaponSpawnBallisticKnife
            // 
            this.FireFoxWeaponSpawnBallisticKnife.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnBallisticKnife.Name = "FireFoxWeaponSpawnBallisticKnife";
            this.FireFoxWeaponSpawnBallisticKnife.Size = new System.Drawing.Size(147, 22);
            this.FireFoxWeaponSpawnBallisticKnife.Text = "Ballistic Knife ";
            this.FireFoxWeaponSpawnBallisticKnife.Click += new System.EventHandler(this.FireFoxWeaponSpawnBallisticKnife_Click);
            // 
            // FireFoxWeaponSpawnZRG20MM
            // 
            this.FireFoxWeaponSpawnZRG20MM.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnZRG20MM.Name = "FireFoxWeaponSpawnZRG20MM";
            this.FireFoxWeaponSpawnZRG20MM.Size = new System.Drawing.Size(147, 22);
            this.FireFoxWeaponSpawnZRG20MM.Text = "ZRG 20mm";
            this.FireFoxWeaponSpawnZRG20MM.Click += new System.EventHandler(this.FireFoxWeaponSpawnZRG20MM_Click);
            // 
            // FireFoxWeaponSpawnSwissK31
            // 
            this.FireFoxWeaponSpawnSwissK31.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnSwissK31.Name = "FireFoxWeaponSpawnSwissK31";
            this.FireFoxWeaponSpawnSwissK31.Size = new System.Drawing.Size(147, 22);
            this.FireFoxWeaponSpawnSwissK31.Text = "Swiss K31";
            this.FireFoxWeaponSpawnSwissK31.Click += new System.EventHandler(this.FireFoxWeaponSpawnSwissK31_Click);
            // 
            // FireFoxWeaponSpawnCARV2
            // 
            this.FireFoxWeaponSpawnCARV2.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnCARV2.Name = "FireFoxWeaponSpawnCARV2";
            this.FireFoxWeaponSpawnCARV2.Size = new System.Drawing.Size(147, 22);
            this.FireFoxWeaponSpawnCARV2.Text = "CARV.2";
            this.FireFoxWeaponSpawnCARV2.Click += new System.EventHandler(this.FireFoxWeaponSpawnCARV2_Click);
            // 
            // FireFoxWeaponSpawnWonderWeapons
            // 
            this.FireFoxWeaponSpawnWonderWeapons.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FireFoxWeaponSpawnDiscordianDisruptor,
            this.FireFoxWeaponSpawnDIEShockwave,
            this.FireFoxWeaponSpawnDIENova,
            this.DIEelectro,
            this.FireFoxWeaponSpawnDIECryo,
            this.FireFoxWeaponSpawnDIEThermo,
            this.FireFoxWeaponSpawnGunShip,
            this.FireFoxWeaponSpawnCruiseMissle,
            this.FireFoxWeaponSpawnChopperGunner,
            this.FireFoxWeaponSpawnTomahawk,
            this.FireFoxWeaponSpawnMonkeyBomb,
            this.FireFoxWeaponSpawnElSlasher,
            this.FireFoxWeaponSpawnSerketsKiss});
            this.FireFoxWeaponSpawnWonderWeapons.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnWonderWeapons.Name = "FireFoxWeaponSpawnWonderWeapons";
            this.FireFoxWeaponSpawnWonderWeapons.Size = new System.Drawing.Size(210, 22);
            this.FireFoxWeaponSpawnWonderWeapons.Text = "Wonder Weapons + More";
            // 
            // FireFoxWeaponSpawnDiscordianDisruptor
            // 
            this.FireFoxWeaponSpawnDiscordianDisruptor.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnDiscordianDisruptor.Name = "FireFoxWeaponSpawnDiscordianDisruptor";
            this.FireFoxWeaponSpawnDiscordianDisruptor.Size = new System.Drawing.Size(182, 22);
            this.FireFoxWeaponSpawnDiscordianDisruptor.Text = "Discordian Disruptor";
            this.FireFoxWeaponSpawnDiscordianDisruptor.Click += new System.EventHandler(this.FireFoxWeaponSpawnDiscordianDisruptor_Click);
            // 
            // FireFoxWeaponSpawnDIEShockwave
            // 
            this.FireFoxWeaponSpawnDIEShockwave.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnDIEShockwave.Name = "FireFoxWeaponSpawnDIEShockwave";
            this.FireFoxWeaponSpawnDIEShockwave.Size = new System.Drawing.Size(182, 22);
            this.FireFoxWeaponSpawnDIEShockwave.Text = "D.I.E ShockWave";
            this.FireFoxWeaponSpawnDIEShockwave.Click += new System.EventHandler(this.FireFoxWeaponSpawnDIEShockwave_Click);
            // 
            // FireFoxWeaponSpawnDIENova
            // 
            this.FireFoxWeaponSpawnDIENova.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnDIENova.Name = "FireFoxWeaponSpawnDIENova";
            this.FireFoxWeaponSpawnDIENova.Size = new System.Drawing.Size(182, 22);
            this.FireFoxWeaponSpawnDIENova.Text = "Die Nova-5";
            this.FireFoxWeaponSpawnDIENova.Click += new System.EventHandler(this.FireFoxWeaponSpawnDIENova_Click);
            // 
            // DIEelectro
            // 
            this.DIEelectro.ForeColor = System.Drawing.Color.White;
            this.DIEelectro.Name = "DIEelectro";
            this.DIEelectro.Size = new System.Drawing.Size(182, 22);
            this.DIEelectro.Text = "Die Electro";
            this.DIEelectro.Click += new System.EventHandler(this.DIEelectro_Click);
            // 
            // FireFoxWeaponSpawnDIECryo
            // 
            this.FireFoxWeaponSpawnDIECryo.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnDIECryo.Name = "FireFoxWeaponSpawnDIECryo";
            this.FireFoxWeaponSpawnDIECryo.Size = new System.Drawing.Size(182, 22);
            this.FireFoxWeaponSpawnDIECryo.Text = "Die Cryo";
            this.FireFoxWeaponSpawnDIECryo.Click += new System.EventHandler(this.FireFoxWeaponSpawnDIECryo_Click);
            // 
            // FireFoxWeaponSpawnDIEThermo
            // 
            this.FireFoxWeaponSpawnDIEThermo.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnDIEThermo.Name = "FireFoxWeaponSpawnDIEThermo";
            this.FireFoxWeaponSpawnDIEThermo.Size = new System.Drawing.Size(182, 22);
            this.FireFoxWeaponSpawnDIEThermo.Text = "Die Thermo";
            this.FireFoxWeaponSpawnDIEThermo.Click += new System.EventHandler(this.FireFoxWeaponSpawnDIEThermo_Click);
            // 
            // FireFoxWeaponSpawnGunShip
            // 
            this.FireFoxWeaponSpawnGunShip.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnGunShip.Name = "FireFoxWeaponSpawnGunShip";
            this.FireFoxWeaponSpawnGunShip.Size = new System.Drawing.Size(182, 22);
            this.FireFoxWeaponSpawnGunShip.Text = "Gunship";
            this.FireFoxWeaponSpawnGunShip.Click += new System.EventHandler(this.FireFoxWeaponSpawnGunShip_Click);
            // 
            // FireFoxWeaponSpawnCruiseMissle
            // 
            this.FireFoxWeaponSpawnCruiseMissle.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnCruiseMissle.Name = "FireFoxWeaponSpawnCruiseMissle";
            this.FireFoxWeaponSpawnCruiseMissle.Size = new System.Drawing.Size(182, 22);
            this.FireFoxWeaponSpawnCruiseMissle.Text = "Cruise Missle";
            this.FireFoxWeaponSpawnCruiseMissle.Click += new System.EventHandler(this.FireFoxWeaponSpawnCruiseMissle_Click);
            // 
            // FireFoxWeaponSpawnChopperGunner
            // 
            this.FireFoxWeaponSpawnChopperGunner.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnChopperGunner.Name = "FireFoxWeaponSpawnChopperGunner";
            this.FireFoxWeaponSpawnChopperGunner.Size = new System.Drawing.Size(182, 22);
            this.FireFoxWeaponSpawnChopperGunner.Text = "Chopper Gunner";
            this.FireFoxWeaponSpawnChopperGunner.Click += new System.EventHandler(this.FireFoxWeaponSpawnChopperGunner_Click);
            // 
            // FireFoxWeaponSpawnTomahawk
            // 
            this.FireFoxWeaponSpawnTomahawk.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnTomahawk.Name = "FireFoxWeaponSpawnTomahawk";
            this.FireFoxWeaponSpawnTomahawk.Size = new System.Drawing.Size(182, 22);
            this.FireFoxWeaponSpawnTomahawk.Text = "Tomahawk";
            this.FireFoxWeaponSpawnTomahawk.Click += new System.EventHandler(this.FireFoxWeaponSpawnTomahawk_Click);
            // 
            // FireFoxWeaponSpawnMonkeyBomb
            // 
            this.FireFoxWeaponSpawnMonkeyBomb.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnMonkeyBomb.Name = "FireFoxWeaponSpawnMonkeyBomb";
            this.FireFoxWeaponSpawnMonkeyBomb.Size = new System.Drawing.Size(182, 22);
            this.FireFoxWeaponSpawnMonkeyBomb.Text = "Monkey Bomb";
            this.FireFoxWeaponSpawnMonkeyBomb.Click += new System.EventHandler(this.FireFoxWeaponSpawnMonkeyBomb_Click);
            // 
            // FireFoxWeaponSpawnElSlasher
            // 
            this.FireFoxWeaponSpawnElSlasher.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnElSlasher.Name = "FireFoxWeaponSpawnElSlasher";
            this.FireFoxWeaponSpawnElSlasher.Size = new System.Drawing.Size(182, 22);
            this.FireFoxWeaponSpawnElSlasher.Text = "El Slasher";
            this.FireFoxWeaponSpawnElSlasher.Click += new System.EventHandler(this.FireFoxWeaponSpawnElSlasher_Click);
            // 
            // FireFoxWeaponSpawnSerketsKiss
            // 
            this.FireFoxWeaponSpawnSerketsKiss.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnSerketsKiss.Name = "FireFoxWeaponSpawnSerketsKiss";
            this.FireFoxWeaponSpawnSerketsKiss.Size = new System.Drawing.Size(182, 22);
            this.FireFoxWeaponSpawnSerketsKiss.Text = "Serkets Kiss";
            this.FireFoxWeaponSpawnSerketsKiss.Click += new System.EventHandler(this.FireFoxWeaponSpawnSerketsKiss_Click);
            // 
            // FireFoxWeaponSpawnFieldUpgrades
            // 
            this.FireFoxWeaponSpawnFieldUpgrades.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FireFoxWeaponSpawnFrenziedGuard,
            this.FireFoxWeaponSpawnFrostBlast,
            this.FireFoxWeaponSpawnEnerygyMine,
            this.FireFoxWeaponSpawnAetherShroud,
            this.FireFoxWeaponSpawnHealingAura,
            this.FireFoxWeaponSpawnRingOfFire});
            this.FireFoxWeaponSpawnFieldUpgrades.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnFieldUpgrades.Name = "FireFoxWeaponSpawnFieldUpgrades";
            this.FireFoxWeaponSpawnFieldUpgrades.Size = new System.Drawing.Size(210, 22);
            this.FireFoxWeaponSpawnFieldUpgrades.Text = "Field Upgrades";
            // 
            // FireFoxWeaponSpawnFrenziedGuard
            // 
            this.FireFoxWeaponSpawnFrenziedGuard.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnFrenziedGuard.Name = "FireFoxWeaponSpawnFrenziedGuard";
            this.FireFoxWeaponSpawnFrenziedGuard.Size = new System.Drawing.Size(153, 22);
            this.FireFoxWeaponSpawnFrenziedGuard.Text = "Frenzied Guard";
            this.FireFoxWeaponSpawnFrenziedGuard.Click += new System.EventHandler(this.FireFoxWeaponSpawnFrenziedGuard_Click);
            // 
            // FireFoxWeaponSpawnFrostBlast
            // 
            this.FireFoxWeaponSpawnFrostBlast.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnFrostBlast.Name = "FireFoxWeaponSpawnFrostBlast";
            this.FireFoxWeaponSpawnFrostBlast.Size = new System.Drawing.Size(153, 22);
            this.FireFoxWeaponSpawnFrostBlast.Text = "Frost Blast";
            this.FireFoxWeaponSpawnFrostBlast.Click += new System.EventHandler(this.FireFoxWeaponSpawnFrostBlast_Click);
            // 
            // FireFoxWeaponSpawnEnerygyMine
            // 
            this.FireFoxWeaponSpawnEnerygyMine.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnEnerygyMine.Name = "FireFoxWeaponSpawnEnerygyMine";
            this.FireFoxWeaponSpawnEnerygyMine.Size = new System.Drawing.Size(153, 22);
            this.FireFoxWeaponSpawnEnerygyMine.Text = "Energy Mine";
            this.FireFoxWeaponSpawnEnerygyMine.Click += new System.EventHandler(this.FireFoxWeaponSpawnEnerygyMine_Click);
            // 
            // FireFoxWeaponSpawnAetherShroud
            // 
            this.FireFoxWeaponSpawnAetherShroud.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnAetherShroud.Name = "FireFoxWeaponSpawnAetherShroud";
            this.FireFoxWeaponSpawnAetherShroud.Size = new System.Drawing.Size(153, 22);
            this.FireFoxWeaponSpawnAetherShroud.Text = "Aether Shroud";
            this.FireFoxWeaponSpawnAetherShroud.Click += new System.EventHandler(this.FireFoxWeaponSpawnAetherShroud_Click);
            // 
            // FireFoxWeaponSpawnHealingAura
            // 
            this.FireFoxWeaponSpawnHealingAura.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnHealingAura.Name = "FireFoxWeaponSpawnHealingAura";
            this.FireFoxWeaponSpawnHealingAura.Size = new System.Drawing.Size(153, 22);
            this.FireFoxWeaponSpawnHealingAura.Text = "Healing Aura";
            this.FireFoxWeaponSpawnHealingAura.Click += new System.EventHandler(this.FireFoxWeaponSpawnHealingAura_Click);
            // 
            // FireFoxWeaponSpawnRingOfFire
            // 
            this.FireFoxWeaponSpawnRingOfFire.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnRingOfFire.Name = "FireFoxWeaponSpawnRingOfFire";
            this.FireFoxWeaponSpawnRingOfFire.Size = new System.Drawing.Size(153, 22);
            this.FireFoxWeaponSpawnRingOfFire.Text = "Ring of Fire ";
            this.FireFoxWeaponSpawnRingOfFire.Click += new System.EventHandler(this.FireFoxWeaponSpawnRingOfFire_Click);
            // 
            // FireFoxWeaponSpawnMisc
            // 
            this.FireFoxWeaponSpawnMisc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FireFoxWeaponSpawnEssenceTrap,
            this.FireFoxWeaponSpawnClaymore,
            this.FireFoxWeaponSpawnCoal,
            this.FireFoxWeaponSpawnMolotov,
            this.FireFoxWeaponSpawnShockCharge,
            this.FireFoxWeaponSpawnTrophySystem,
            this.FireFoxWeaponSpawnFlashbang,
            this.FireFoxWeaponSpawnThermite,
            this.FireFoxWeaponSpawnSnowBall,
            this.FireFoxWeaponSpawnJammer,
            this.FireFoxWeaponSpawnSmokeGrenade,
            this.FireFoxWeaponSpawnDecoy,
            this.FireFoxWeaponSpawnDroneSquad,
            this.FireFoxWeaponSpawnStunGrenade,
            this.toolStripMenuItem95,
            this.FireFoxWeaponSpawnZombiesHead});
            this.FireFoxWeaponSpawnMisc.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnMisc.Name = "FireFoxWeaponSpawnMisc";
            this.FireFoxWeaponSpawnMisc.Size = new System.Drawing.Size(210, 22);
            this.FireFoxWeaponSpawnMisc.Text = "Misc Weapons";
            // 
            // FireFoxWeaponSpawnEssenceTrap
            // 
            this.FireFoxWeaponSpawnEssenceTrap.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnEssenceTrap.Name = "FireFoxWeaponSpawnEssenceTrap";
            this.FireFoxWeaponSpawnEssenceTrap.Size = new System.Drawing.Size(195, 22);
            this.FireFoxWeaponSpawnEssenceTrap.Text = "Essence Trap (Grenade)";
            this.FireFoxWeaponSpawnEssenceTrap.Click += new System.EventHandler(this.FireFoxWeaponSpawnEssenceTrap_Click);
            // 
            // FireFoxWeaponSpawnClaymore
            // 
            this.FireFoxWeaponSpawnClaymore.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnClaymore.Name = "FireFoxWeaponSpawnClaymore";
            this.FireFoxWeaponSpawnClaymore.Size = new System.Drawing.Size(195, 22);
            this.FireFoxWeaponSpawnClaymore.Text = "Claymore";
            this.FireFoxWeaponSpawnClaymore.Click += new System.EventHandler(this.FireFoxWeaponSpawnClaymore_Click);
            // 
            // FireFoxWeaponSpawnCoal
            // 
            this.FireFoxWeaponSpawnCoal.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnCoal.Name = "FireFoxWeaponSpawnCoal";
            this.FireFoxWeaponSpawnCoal.Size = new System.Drawing.Size(195, 22);
            this.FireFoxWeaponSpawnCoal.Text = "Coal";
            this.FireFoxWeaponSpawnCoal.Click += new System.EventHandler(this.FireFoxWeaponSpawnCoal_Click);
            // 
            // FireFoxWeaponSpawnMolotov
            // 
            this.FireFoxWeaponSpawnMolotov.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnMolotov.Name = "FireFoxWeaponSpawnMolotov";
            this.FireFoxWeaponSpawnMolotov.Size = new System.Drawing.Size(195, 22);
            this.FireFoxWeaponSpawnMolotov.Text = "Molotov";
            this.FireFoxWeaponSpawnMolotov.Click += new System.EventHandler(this.FireFoxWeaponSpawnMolotov_Click);
            // 
            // FireFoxWeaponSpawnShockCharge
            // 
            this.FireFoxWeaponSpawnShockCharge.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnShockCharge.Name = "FireFoxWeaponSpawnShockCharge";
            this.FireFoxWeaponSpawnShockCharge.Size = new System.Drawing.Size(195, 22);
            this.FireFoxWeaponSpawnShockCharge.Text = "Shock Charge";
            this.FireFoxWeaponSpawnShockCharge.Click += new System.EventHandler(this.FireFoxWeaponSpawnShockCharge_Click);
            // 
            // FireFoxWeaponSpawnTrophySystem
            // 
            this.FireFoxWeaponSpawnTrophySystem.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnTrophySystem.Name = "FireFoxWeaponSpawnTrophySystem";
            this.FireFoxWeaponSpawnTrophySystem.Size = new System.Drawing.Size(195, 22);
            this.FireFoxWeaponSpawnTrophySystem.Text = "Trophy System";
            this.FireFoxWeaponSpawnTrophySystem.Click += new System.EventHandler(this.FireFoxWeaponSpawnTrophySystem_Click);
            // 
            // FireFoxWeaponSpawnFlashbang
            // 
            this.FireFoxWeaponSpawnFlashbang.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnFlashbang.Name = "FireFoxWeaponSpawnFlashbang";
            this.FireFoxWeaponSpawnFlashbang.Size = new System.Drawing.Size(195, 22);
            this.FireFoxWeaponSpawnFlashbang.Text = "Flashbang";
            this.FireFoxWeaponSpawnFlashbang.Click += new System.EventHandler(this.FireFoxWeaponSpawnFlashbang_Click);
            // 
            // FireFoxWeaponSpawnThermite
            // 
            this.FireFoxWeaponSpawnThermite.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnThermite.Name = "FireFoxWeaponSpawnThermite";
            this.FireFoxWeaponSpawnThermite.Size = new System.Drawing.Size(195, 22);
            this.FireFoxWeaponSpawnThermite.Text = "Thermite";
            this.FireFoxWeaponSpawnThermite.Click += new System.EventHandler(this.FireFoxWeaponSpawnThermite_Click);
            // 
            // FireFoxWeaponSpawnSnowBall
            // 
            this.FireFoxWeaponSpawnSnowBall.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnSnowBall.Name = "FireFoxWeaponSpawnSnowBall";
            this.FireFoxWeaponSpawnSnowBall.Size = new System.Drawing.Size(195, 22);
            this.FireFoxWeaponSpawnSnowBall.Text = "Snowball";
            this.FireFoxWeaponSpawnSnowBall.Click += new System.EventHandler(this.FireFoxWeaponSpawnSnowBall_Click);
            // 
            // FireFoxWeaponSpawnJammer
            // 
            this.FireFoxWeaponSpawnJammer.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnJammer.Name = "FireFoxWeaponSpawnJammer";
            this.FireFoxWeaponSpawnJammer.Size = new System.Drawing.Size(195, 22);
            this.FireFoxWeaponSpawnJammer.Text = "Jammer";
            this.FireFoxWeaponSpawnJammer.Click += new System.EventHandler(this.FireFoxWeaponSpawnJammer_Click);
            // 
            // FireFoxWeaponSpawnSmokeGrenade
            // 
            this.FireFoxWeaponSpawnSmokeGrenade.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnSmokeGrenade.Name = "FireFoxWeaponSpawnSmokeGrenade";
            this.FireFoxWeaponSpawnSmokeGrenade.Size = new System.Drawing.Size(195, 22);
            this.FireFoxWeaponSpawnSmokeGrenade.Text = "Smoke Grenade";
            this.FireFoxWeaponSpawnSmokeGrenade.Click += new System.EventHandler(this.FireFoxWeaponSpawnSmokeGrenade_Click);
            // 
            // FireFoxWeaponSpawnDecoy
            // 
            this.FireFoxWeaponSpawnDecoy.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnDecoy.Name = "FireFoxWeaponSpawnDecoy";
            this.FireFoxWeaponSpawnDecoy.Size = new System.Drawing.Size(195, 22);
            this.FireFoxWeaponSpawnDecoy.Text = "Decoy";
            this.FireFoxWeaponSpawnDecoy.Click += new System.EventHandler(this.FireFoxWeaponSpawnDecoy_Click);
            // 
            // FireFoxWeaponSpawnDroneSquad
            // 
            this.FireFoxWeaponSpawnDroneSquad.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnDroneSquad.Name = "FireFoxWeaponSpawnDroneSquad";
            this.FireFoxWeaponSpawnDroneSquad.Size = new System.Drawing.Size(195, 22);
            this.FireFoxWeaponSpawnDroneSquad.Text = "Drone Squad";
            this.FireFoxWeaponSpawnDroneSquad.Click += new System.EventHandler(this.FireFoxWeaponSpawnDroneSquad_Click);
            // 
            // FireFoxWeaponSpawnStunGrenade
            // 
            this.FireFoxWeaponSpawnStunGrenade.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnStunGrenade.Name = "FireFoxWeaponSpawnStunGrenade";
            this.FireFoxWeaponSpawnStunGrenade.Size = new System.Drawing.Size(195, 22);
            this.FireFoxWeaponSpawnStunGrenade.Text = "Stun Grenade";
            this.FireFoxWeaponSpawnStunGrenade.Click += new System.EventHandler(this.FireFoxWeaponSpawnStunGrenade_Click);
            // 
            // toolStripMenuItem95
            // 
            this.toolStripMenuItem95.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem95.Name = "toolStripMenuItem95";
            this.toolStripMenuItem95.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItem95.Text = "Frag";
            this.toolStripMenuItem95.Click += new System.EventHandler(this.toolStripMenuItem95_Click);
            // 
            // FireFoxWeaponSpawnZombiesHead
            // 
            this.FireFoxWeaponSpawnZombiesHead.ForeColor = System.Drawing.Color.White;
            this.FireFoxWeaponSpawnZombiesHead.Name = "FireFoxWeaponSpawnZombiesHead";
            this.FireFoxWeaponSpawnZombiesHead.Size = new System.Drawing.Size(195, 22);
            this.FireFoxWeaponSpawnZombiesHead.Text = "Zombies Head?";
            this.FireFoxWeaponSpawnZombiesHead.Click += new System.EventHandler(this.FireFoxWeaponSpawnZombiesHead_Click);
            // 
            // teleportToolStripMenuItem
            // 
            this.teleportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toPlayerToolStripMenuItem,
            this.playerToMeToolStripMenuItem});
            this.teleportToolStripMenuItem.Name = "teleportToolStripMenuItem";
            this.teleportToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.teleportToolStripMenuItem.Text = "Teleport";
            // 
            // toPlayerToolStripMenuItem
            // 
            this.toPlayerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.toPlayerToolStripMenuItem.Name = "toPlayerToolStripMenuItem";
            this.toPlayerToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.toPlayerToolStripMenuItem.Text = "To Player";
            this.toPlayerToolStripMenuItem.Click += new System.EventHandler(this.toPlayerToolStripMenuItem_Click);
            // 
            // playerToMeToolStripMenuItem
            // 
            this.playerToMeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.playerToMeToolStripMenuItem.Name = "playerToMeToolStripMenuItem";
            this.playerToMeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.playerToMeToolStripMenuItem.Text = "Player To Me";
            this.playerToMeToolStripMenuItem.Click += new System.EventHandler(this.playerToMeToolStripMenuItem_Click);
            // 
            // FireFoxConnect
            // 
            this.FireFoxConnect.Location = new System.Drawing.Point(6, 28);
            this.FireFoxConnect.Name = "FireFoxConnect";
            this.FireFoxConnect.Size = new System.Drawing.Size(256, 23);
            this.FireFoxConnect.TabIndex = 1;
            this.FireFoxConnect.Text = "Connect";
            this.FireFoxConnect.Click += new System.EventHandler(this.FireFoxConnect_Click);
            // 
            // dockPanel1
            // 
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.dockPanel1.ID = new System.Guid("f2e0642f-339e-48c6-ab78-957817f58a1a");
            this.dockPanel1.Location = new System.Drawing.Point(-32768, -32768);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.SavedIndex = 3;
            this.dockPanel1.Size = new System.Drawing.Size(200, 200);
            this.dockPanel1.Text = "dockPanel1";
            // 
            // FireFoxMainDocker
            // 
            this.FireFoxMainDocker.Form = this;
            this.FireFoxMainDocker.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer1});
            this.FireFoxMainDocker.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // panelContainer1
            // 
            this.panelContainer1.ActiveChild = this.FireFoxDockerReticles;
            this.panelContainer1.Controls.Add(this.FireFoxDockerClients);
            this.panelContainer1.Controls.Add(this.FireFoxDockerTeleport);
            this.panelContainer1.Controls.Add(this.FireFoxDockerLobby);
            this.panelContainer1.Controls.Add(this.FireFoxDockerDA);
            this.panelContainer1.Controls.Add(this.FireFoxDockerReticles);
            this.panelContainer1.Controls.Add(this.FireFoxDockerStats);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.panelContainer1.FloatSize = new System.Drawing.Size(833, 482);
            this.panelContainer1.FloatVertical = true;
            this.panelContainer1.ID = new System.Guid("fe7e83c8-488d-4868-be4d-f44f70937eef");
            this.panelContainer1.Location = new System.Drawing.Point(0, 64);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(817, 200);
            this.panelContainer1.Size = new System.Drawing.Size(817, 410);
            this.panelContainer1.Tabbed = true;
            this.panelContainer1.Text = "panelContainer1";
            // 
            // FireFoxDockerClients
            // 
            this.FireFoxDockerClients.Controls.Add(this.dockPanel2_Container);
            this.FireFoxDockerClients.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxDockerClients.FloatSize = new System.Drawing.Size(833, 482);
            this.FireFoxDockerClients.FloatVertical = true;
            this.FireFoxDockerClients.ID = new System.Guid("595e975e-63a4-4c61-814e-11b9cd293c75");
            this.FireFoxDockerClients.Location = new System.Drawing.Point(3, 25);
            this.FireFoxDockerClients.Name = "FireFoxDockerClients";
            this.FireFoxDockerClients.Options.AllowDockAsTabbedDocument = false;
            this.FireFoxDockerClients.Options.AllowDockBottom = false;
            this.FireFoxDockerClients.Options.AllowDockLeft = false;
            this.FireFoxDockerClients.Options.AllowDockRight = false;
            this.FireFoxDockerClients.Options.AllowDockTop = false;
            this.FireFoxDockerClients.Options.ShowAutoHideButton = false;
            this.FireFoxDockerClients.Options.ShowCloseButton = false;
            this.FireFoxDockerClients.Options.ShowMaximizeButton = false;
            this.FireFoxDockerClients.OriginalSize = new System.Drawing.Size(200, 200);
            this.FireFoxDockerClients.Size = new System.Drawing.Size(810, 357);
            this.FireFoxDockerClients.Text = "Clients";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.StartGameTest);
            this.dockPanel2_Container.Controls.Add(this.FireFoxAllCGB);
            this.dockPanel2_Container.Controls.Add(this.FireFoxPLGB);
            this.dockPanel2_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(810, 357);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // StartGameTest
            // 
            this.StartGameTest.Location = new System.Drawing.Point(410, 316);
            this.StartGameTest.Name = "StartGameTest";
            this.StartGameTest.Size = new System.Drawing.Size(127, 23);
            this.StartGameTest.TabIndex = 30;
            this.StartGameTest.Text = "Start Game Test";
            this.StartGameTest.Visible = false;
            this.StartGameTest.Click += new System.EventHandler(this.StartGameTest_Click);
            // 
            // FireFoxDockerTeleport
            // 
            this.FireFoxDockerTeleport.Controls.Add(this.controlContainer1);
            this.FireFoxDockerTeleport.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxDockerTeleport.FloatSize = new System.Drawing.Size(833, 482);
            this.FireFoxDockerTeleport.FloatVertical = true;
            this.FireFoxDockerTeleport.ID = new System.Guid("6e1b0866-ed5b-47db-aba6-c8fd8decfdba");
            this.FireFoxDockerTeleport.Location = new System.Drawing.Point(3, 25);
            this.FireFoxDockerTeleport.Name = "FireFoxDockerTeleport";
            this.FireFoxDockerTeleport.Options.AllowDockAsTabbedDocument = false;
            this.FireFoxDockerTeleport.Options.AllowDockBottom = false;
            this.FireFoxDockerTeleport.Options.AllowDockRight = false;
            this.FireFoxDockerTeleport.Options.AllowDockTop = false;
            this.FireFoxDockerTeleport.Options.ShowAutoHideButton = false;
            this.FireFoxDockerTeleport.Options.ShowCloseButton = false;
            this.FireFoxDockerTeleport.Options.ShowMaximizeButton = false;
            this.FireFoxDockerTeleport.OriginalSize = new System.Drawing.Size(810, 357);
            this.FireFoxDockerTeleport.Size = new System.Drawing.Size(810, 357);
            this.FireFoxDockerTeleport.Text = "Teleport";
            // 
            // controlContainer1
            // 
            this.controlContainer1.Controls.Add(this.FireFoxCustomXYZSpawn);
            this.controlContainer1.Controls.Add(this.FireFoxCustomSpawnPointsMapSpecific);
            this.controlContainer1.Controls.Add(this.FireFoxSavedSpawnPoints);
            this.controlContainer1.Location = new System.Drawing.Point(0, 0);
            this.controlContainer1.Name = "controlContainer1";
            this.controlContainer1.Size = new System.Drawing.Size(810, 357);
            this.controlContainer1.TabIndex = 0;
            // 
            // FireFoxCustomXYZSpawn
            // 
            this.FireFoxCustomXYZSpawn.Controls.Add(this.FireFoxTPValue);
            this.FireFoxCustomXYZSpawn.Controls.Add(this.FireFoxXYZSpawnMinus);
            this.FireFoxCustomXYZSpawn.Controls.Add(this.FireFoxXYZSpawnPlus);
            this.FireFoxCustomXYZSpawn.Controls.Add(this.FireFoxXYZSpawnZ);
            this.FireFoxCustomXYZSpawn.Controls.Add(this.FireFoxXYZSpawnY);
            this.FireFoxCustomXYZSpawn.Controls.Add(this.FireFoxXYZSpawnX);
            this.FireFoxCustomXYZSpawn.Cursor = System.Windows.Forms.Cursors.Default;
            this.FireFoxCustomXYZSpawn.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.FireFoxCustomXYZSpawn.Location = new System.Drawing.Point(428, 119);
            this.FireFoxCustomXYZSpawn.Name = "FireFoxCustomXYZSpawn";
            this.FireFoxCustomXYZSpawn.Size = new System.Drawing.Size(372, 235);
            this.FireFoxCustomXYZSpawn.TabIndex = 2;
            this.FireFoxCustomXYZSpawn.Text = "Custom X/Y/Z Movement";
            // 
            // FireFoxTPValue
            // 
            this.FireFoxTPValue.Location = new System.Drawing.Point(108, 169);
            this.FireFoxTPValue.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxTPValue.Name = "FireFoxTPValue";
            this.FireFoxTPValue.Size = new System.Drawing.Size(156, 20);
            this.FireFoxTPValue.TabIndex = 284;
            // 
            // FireFoxXYZSpawnMinus
            // 
            this.FireFoxXYZSpawnMinus.Location = new System.Drawing.Point(210, 144);
            this.FireFoxXYZSpawnMinus.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxXYZSpawnMinus.Name = "FireFoxXYZSpawnMinus";
            this.FireFoxXYZSpawnMinus.Properties.Caption = "Minus";
            this.FireFoxXYZSpawnMinus.Size = new System.Drawing.Size(54, 19);
            this.FireFoxXYZSpawnMinus.TabIndex = 283;
            this.FireFoxXYZSpawnMinus.CheckedChanged += new System.EventHandler(this.FireFoxXYZSpawnMinus_CheckedChanged);
            // 
            // FireFoxXYZSpawnPlus
            // 
            this.FireFoxXYZSpawnPlus.Location = new System.Drawing.Point(105, 144);
            this.FireFoxXYZSpawnPlus.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxXYZSpawnPlus.Name = "FireFoxXYZSpawnPlus";
            this.FireFoxXYZSpawnPlus.Properties.Caption = "Plus";
            this.FireFoxXYZSpawnPlus.Size = new System.Drawing.Size(45, 19);
            this.FireFoxXYZSpawnPlus.TabIndex = 280;
            this.FireFoxXYZSpawnPlus.CheckedChanged += new System.EventHandler(this.FireFoxXYZSpawnPlus_CheckedChanged);
            // 
            // FireFoxXYZSpawnZ
            // 
            this.FireFoxXYZSpawnZ.Location = new System.Drawing.Point(108, 115);
            this.FireFoxXYZSpawnZ.Name = "FireFoxXYZSpawnZ";
            this.FireFoxXYZSpawnZ.Size = new System.Drawing.Size(156, 23);
            this.FireFoxXYZSpawnZ.TabIndex = 282;
            this.FireFoxXYZSpawnZ.Text = "Move --> Z";
            this.FireFoxXYZSpawnZ.Click += new System.EventHandler(this.FireFoxXYZSpawnZ_Click);
            // 
            // FireFoxXYZSpawnY
            // 
            this.FireFoxXYZSpawnY.Location = new System.Drawing.Point(108, 86);
            this.FireFoxXYZSpawnY.Name = "FireFoxXYZSpawnY";
            this.FireFoxXYZSpawnY.Size = new System.Drawing.Size(156, 23);
            this.FireFoxXYZSpawnY.TabIndex = 281;
            this.FireFoxXYZSpawnY.Text = "Move --> Y";
            this.FireFoxXYZSpawnY.Click += new System.EventHandler(this.FireFoxXYZSpawnY_Click);
            // 
            // FireFoxXYZSpawnX
            // 
            this.FireFoxXYZSpawnX.Location = new System.Drawing.Point(108, 57);
            this.FireFoxXYZSpawnX.Name = "FireFoxXYZSpawnX";
            this.FireFoxXYZSpawnX.Size = new System.Drawing.Size(156, 23);
            this.FireFoxXYZSpawnX.TabIndex = 280;
            this.FireFoxXYZSpawnX.Text = "Move --> X";
            this.FireFoxXYZSpawnX.Click += new System.EventHandler(this.FireFoxXYZSpawnX_Click);
            // 
            // FireFoxCustomSpawnPointsMapSpecific
            // 
            this.FireFoxCustomSpawnPointsMapSpecific.Controls.Add(this.FireFoxTeleportFireBase);
            this.FireFoxCustomSpawnPointsMapSpecific.Controls.Add(this.FireFoxTeleportFireBaseCombo);
            this.FireFoxCustomSpawnPointsMapSpecific.Controls.Add(this.FireFoxTeleportDIE);
            this.FireFoxCustomSpawnPointsMapSpecific.Controls.Add(this.FireFoxTeleportDIECombo);
            this.FireFoxCustomSpawnPointsMapSpecific.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.FireFoxCustomSpawnPointsMapSpecific.Location = new System.Drawing.Point(428, 4);
            this.FireFoxCustomSpawnPointsMapSpecific.Name = "FireFoxCustomSpawnPointsMapSpecific";
            this.FireFoxCustomSpawnPointsMapSpecific.Size = new System.Drawing.Size(372, 112);
            this.FireFoxCustomSpawnPointsMapSpecific.TabIndex = 1;
            this.FireFoxCustomSpawnPointsMapSpecific.Text = "Pre-Set Spawn Points + More";
            // 
            // FireFoxTeleportFireBase
            // 
            this.FireFoxTeleportFireBase.AutoSize = true;
            this.FireFoxTeleportFireBase.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxTeleportFireBase.ForeColor = System.Drawing.Color.White;
            this.FireFoxTeleportFireBase.Location = new System.Drawing.Point(214, 74);
            this.FireFoxTeleportFireBase.Name = "FireFoxTeleportFireBase";
            this.FireFoxTeleportFireBase.Size = new System.Drawing.Size(99, 13);
            this.FireFoxTeleportFireBase.TabIndex = 283;
            this.FireFoxTeleportFireBase.Text = "Teleport (FireBase)";
            // 
            // FireFoxTeleportFireBaseCombo
            // 
            this.FireFoxTeleportFireBaseCombo.Location = new System.Drawing.Point(189, 49);
            this.FireFoxTeleportFireBaseCombo.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxTeleportFireBaseCombo.Name = "FireFoxTeleportFireBaseCombo";
            this.FireFoxTeleportFireBaseCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FireFoxTeleportFireBaseCombo.Properties.Items.AddRange(new object[] {
            "Prison",
            "XP Location",
            "Spawn",
            "Pack-A-Punch",
            "Teleporter To Firebase",
            "Teleporter To Village",
            "Aether Reactor By Stamina Up",
            "Aether Reactor By Speed Cola",
            "Aether Reactor By Juggernog",
            "Jump Pad 1 To Scorched Defense",
            "Jump Pad 2 To Scorched Defense",
            "Jump Pad 3 To Rocky Defence",
            "Jump Pad 4 To Jungle Defense",
            "Mystery Box Motor Pool",
            "Mystery Box Barracks",
            "Mystery Box Planning Offices",
            "Mystery Box Courtyard",
            "Bunny Easter Egg",
            "Ontop Map"});
            this.FireFoxTeleportFireBaseCombo.Size = new System.Drawing.Size(156, 20);
            this.FireFoxTeleportFireBaseCombo.TabIndex = 282;
            this.FireFoxTeleportFireBaseCombo.SelectedIndexChanged += new System.EventHandler(this.FireFoxTeleportFireBaseCombo_SelectedIndexChanged);
            // 
            // FireFoxTeleportDIE
            // 
            this.FireFoxTeleportDIE.AutoSize = true;
            this.FireFoxTeleportDIE.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxTeleportDIE.ForeColor = System.Drawing.Color.White;
            this.FireFoxTeleportDIE.Location = new System.Drawing.Point(67, 72);
            this.FireFoxTeleportDIE.Name = "FireFoxTeleportDIE";
            this.FireFoxTeleportDIE.Size = new System.Drawing.Size(83, 13);
            this.FireFoxTeleportDIE.TabIndex = 281;
            this.FireFoxTeleportDIE.Text = "Teleport (D.I.E)";
            // 
            // FireFoxTeleportDIECombo
            // 
            this.FireFoxTeleportDIECombo.Location = new System.Drawing.Point(27, 49);
            this.FireFoxTeleportDIECombo.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxTeleportDIECombo.Name = "FireFoxTeleportDIECombo";
            this.FireFoxTeleportDIECombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FireFoxTeleportDIECombo.Properties.Items.AddRange(new object[] {
            "Prison",
            "XP Location",
            "Spawn",
            "Nacht",
            "Airplane",
            "Swamp",
            "Power Room",
            "Sniper\'s Nest",
            "Pack-a-punch",
            "MB Swamp",
            "MB Spawn",
            "MB Airplane",
            "MB Power Room",
            "MB Lab 1",
            "MB Lab 2",
            "Send To Space (ON)",
            "Send To Space (OFF)"});
            this.FireFoxTeleportDIECombo.Size = new System.Drawing.Size(156, 20);
            this.FireFoxTeleportDIECombo.TabIndex = 280;
            this.FireFoxTeleportDIECombo.SelectedIndexChanged += new System.EventHandler(this.FireFoxTeleportDIECombo_SelectedIndexChanged);
            // 
            // FireFoxSavedSpawnPoints
            // 
            this.FireFoxSavedSpawnPoints.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.FireFoxSavedSpawnPoints.Controls.Add(this.FireFoxCustomSpawnsChooseDIE);
            this.FireFoxSavedSpawnPoints.Controls.Add(this.FireFoxCustomDIESpawns);
            this.FireFoxSavedSpawnPoints.Controls.Add(this.FireFoxCustomFireBasepawns);
            this.FireFoxSavedSpawnPoints.Controls.Add(this.FireFoxCustomSpawnsChooseFireBase);
            this.FireFoxSavedSpawnPoints.Controls.Add(this.FireFoxCustomSpawnRefreshSpawn);
            this.FireFoxSavedSpawnPoints.Controls.Add(this.FireFoxCustomSpawnAddSpawn);
            this.FireFoxSavedSpawnPoints.Controls.Add(this.FireFoxCustomSpawnCustomNameLabel);
            this.FireFoxSavedSpawnPoints.Controls.Add(this.FireFoxCustomSpawnName);
            this.FireFoxSavedSpawnPoints.Controls.Add(this.FireFoxCustomSpawnDIE);
            this.FireFoxSavedSpawnPoints.Controls.Add(this.FireFoxCustomSpawnFireBase);
            this.FireFoxSavedSpawnPoints.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.FireFoxSavedSpawnPoints.Location = new System.Drawing.Point(9, 4);
            this.FireFoxSavedSpawnPoints.Name = "FireFoxSavedSpawnPoints";
            this.FireFoxSavedSpawnPoints.Size = new System.Drawing.Size(410, 350);
            this.FireFoxSavedSpawnPoints.TabIndex = 0;
            this.FireFoxSavedSpawnPoints.Text = "Custom Spawn Points";
            // 
            // FireFoxCustomSpawnsChooseDIE
            // 
            this.FireFoxCustomSpawnsChooseDIE.Location = new System.Drawing.Point(127, 277);
            this.FireFoxCustomSpawnsChooseDIE.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxCustomSpawnsChooseDIE.Name = "FireFoxCustomSpawnsChooseDIE";
            this.FireFoxCustomSpawnsChooseDIE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FireFoxCustomSpawnsChooseDIE.Size = new System.Drawing.Size(156, 20);
            this.FireFoxCustomSpawnsChooseDIE.TabIndex = 279;
            this.FireFoxCustomSpawnsChooseDIE.SelectedIndexChanged += new System.EventHandler(this.FireFoxCustomSpawnsChooseDIE_SelectedIndexChanged);
            // 
            // FireFoxCustomDIESpawns
            // 
            this.FireFoxCustomDIESpawns.AutoSize = true;
            this.FireFoxCustomDIESpawns.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxCustomDIESpawns.ForeColor = System.Drawing.Color.White;
            this.FireFoxCustomDIESpawns.Location = new System.Drawing.Point(138, 261);
            this.FireFoxCustomDIESpawns.Name = "FireFoxCustomDIESpawns";
            this.FireFoxCustomDIESpawns.Size = new System.Drawing.Size(126, 13);
            this.FireFoxCustomDIESpawns.TabIndex = 278;
            this.FireFoxCustomDIESpawns.Text = "Teleport (D.I.E) (SAVED)";
            // 
            // FireFoxCustomFireBasepawns
            // 
            this.FireFoxCustomFireBasepawns.AutoSize = true;
            this.FireFoxCustomFireBasepawns.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxCustomFireBasepawns.ForeColor = System.Drawing.Color.White;
            this.FireFoxCustomFireBasepawns.Location = new System.Drawing.Point(133, 197);
            this.FireFoxCustomFireBasepawns.Name = "FireFoxCustomFireBasepawns";
            this.FireFoxCustomFireBasepawns.Size = new System.Drawing.Size(142, 13);
            this.FireFoxCustomFireBasepawns.TabIndex = 277;
            this.FireFoxCustomFireBasepawns.Text = "Teleport (FireBase) (SAVED)";
            // 
            // FireFoxCustomSpawnsChooseFireBase
            // 
            this.FireFoxCustomSpawnsChooseFireBase.Location = new System.Drawing.Point(127, 213);
            this.FireFoxCustomSpawnsChooseFireBase.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxCustomSpawnsChooseFireBase.Name = "FireFoxCustomSpawnsChooseFireBase";
            this.FireFoxCustomSpawnsChooseFireBase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FireFoxCustomSpawnsChooseFireBase.Size = new System.Drawing.Size(156, 20);
            this.FireFoxCustomSpawnsChooseFireBase.TabIndex = 6;
            this.FireFoxCustomSpawnsChooseFireBase.SelectedIndexChanged += new System.EventHandler(this.FireFoxCustomSpawnsChooseFireBase_SelectedIndexChanged);
            // 
            // FireFoxCustomSpawnRefreshSpawn
            // 
            this.FireFoxCustomSpawnRefreshSpawn.Location = new System.Drawing.Point(127, 151);
            this.FireFoxCustomSpawnRefreshSpawn.Name = "FireFoxCustomSpawnRefreshSpawn";
            this.FireFoxCustomSpawnRefreshSpawn.Size = new System.Drawing.Size(156, 23);
            this.FireFoxCustomSpawnRefreshSpawn.TabIndex = 5;
            this.FireFoxCustomSpawnRefreshSpawn.Text = "Refresh Custom Spawn Points";
            this.FireFoxCustomSpawnRefreshSpawn.Click += new System.EventHandler(this.FireFoxCustomSpawnRefreshSpawn_Click);
            // 
            // FireFoxCustomSpawnAddSpawn
            // 
            this.FireFoxCustomSpawnAddSpawn.Location = new System.Drawing.Point(127, 112);
            this.FireFoxCustomSpawnAddSpawn.Name = "FireFoxCustomSpawnAddSpawn";
            this.FireFoxCustomSpawnAddSpawn.Size = new System.Drawing.Size(156, 23);
            this.FireFoxCustomSpawnAddSpawn.TabIndex = 4;
            this.FireFoxCustomSpawnAddSpawn.Text = "Add Custom Spawn Point";
            this.FireFoxCustomSpawnAddSpawn.Click += new System.EventHandler(this.FireFoxCustomSpawnAddSpawn_Click);
            // 
            // FireFoxCustomSpawnCustomNameLabel
            // 
            this.FireFoxCustomSpawnCustomNameLabel.Location = new System.Drawing.Point(172, 74);
            this.FireFoxCustomSpawnCustomNameLabel.Name = "FireFoxCustomSpawnCustomNameLabel";
            this.FireFoxCustomSpawnCustomNameLabel.Size = new System.Drawing.Size(66, 13);
            this.FireFoxCustomSpawnCustomNameLabel.TabIndex = 3;
            this.FireFoxCustomSpawnCustomNameLabel.Text = "Custom Name";
            // 
            // FireFoxCustomSpawnName
            // 
            this.FireFoxCustomSpawnName.Location = new System.Drawing.Point(101, 52);
            this.FireFoxCustomSpawnName.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxCustomSpawnName.Name = "FireFoxCustomSpawnName";
            this.FireFoxCustomSpawnName.Size = new System.Drawing.Size(208, 20);
            this.FireFoxCustomSpawnName.TabIndex = 2;
            // 
            // FireFoxCustomSpawnDIE
            // 
            this.FireFoxCustomSpawnDIE.Location = new System.Drawing.Point(223, 24);
            this.FireFoxCustomSpawnDIE.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxCustomSpawnDIE.Name = "FireFoxCustomSpawnDIE";
            this.FireFoxCustomSpawnDIE.Properties.Caption = "D.I.E";
            this.FireFoxCustomSpawnDIE.Size = new System.Drawing.Size(52, 19);
            this.FireFoxCustomSpawnDIE.TabIndex = 1;
            this.FireFoxCustomSpawnDIE.CheckedChanged += new System.EventHandler(this.FireFoxCustomSpawnDIE_CheckedChanged);
            // 
            // FireFoxCustomSpawnFireBase
            // 
            this.FireFoxCustomSpawnFireBase.Location = new System.Drawing.Point(136, 24);
            this.FireFoxCustomSpawnFireBase.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxCustomSpawnFireBase.Name = "FireFoxCustomSpawnFireBase";
            this.FireFoxCustomSpawnFireBase.Properties.Caption = "FireBase";
            this.FireFoxCustomSpawnFireBase.Size = new System.Drawing.Size(62, 19);
            this.FireFoxCustomSpawnFireBase.TabIndex = 0;
            this.FireFoxCustomSpawnFireBase.CheckedChanged += new System.EventHandler(this.FireFoxCustomSpawnFireBase_CheckedChanged);
            // 
            // FireFoxDockerLobby
            // 
            this.FireFoxDockerLobby.Controls.Add(this.controlContainer13);
            this.FireFoxDockerLobby.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxDockerLobby.FloatSize = new System.Drawing.Size(833, 482);
            this.FireFoxDockerLobby.FloatVertical = true;
            this.FireFoxDockerLobby.ID = new System.Guid("4939de30-c68b-4f40-9a6c-80e0f7671748");
            this.FireFoxDockerLobby.Location = new System.Drawing.Point(3, 25);
            this.FireFoxDockerLobby.Name = "FireFoxDockerLobby";
            this.FireFoxDockerLobby.Options.AllowDockAsTabbedDocument = false;
            this.FireFoxDockerLobby.Options.AllowDockBottom = false;
            this.FireFoxDockerLobby.Options.AllowDockLeft = false;
            this.FireFoxDockerLobby.Options.AllowDockRight = false;
            this.FireFoxDockerLobby.Options.AllowDockTop = false;
            this.FireFoxDockerLobby.Options.ShowAutoHideButton = false;
            this.FireFoxDockerLobby.Options.ShowCloseButton = false;
            this.FireFoxDockerLobby.Options.ShowMaximizeButton = false;
            this.FireFoxDockerLobby.OriginalSize = new System.Drawing.Size(803, 357);
            this.FireFoxDockerLobby.Size = new System.Drawing.Size(810, 357);
            this.FireFoxDockerLobby.Text = "Lobby/XP/Crystal Options";
            // 
            // controlContainer13
            // 
            this.controlContainer13.Controls.Add(this.FireFoxOtherOptionsMain);
            this.controlContainer13.Controls.Add(this.FireFoxLevelXPGB);
            this.controlContainer13.Controls.Add(this.FireFoxPlayerXPGB);
            this.controlContainer13.Controls.Add(this.FireFoxCrystalsGB);
            this.controlContainer13.Controls.Add(this.FireFoxLobbyOptionsSpeedSettingsGB);
            this.controlContainer13.Location = new System.Drawing.Point(0, 0);
            this.controlContainer13.Name = "controlContainer13";
            this.controlContainer13.Size = new System.Drawing.Size(810, 357);
            this.controlContainer13.TabIndex = 0;
            // 
            // FireFoxOtherOptionsMain
            // 
            this.FireFoxOtherOptionsMain.Controls.Add(this.FireFoxFastRoundsStart);
            this.FireFoxOtherOptionsMain.Controls.Add(this.FireFoxKillAllPlayers);
            this.FireFoxOtherOptionsMain.Controls.Add(this.FireFoxQuickXPOption);
            this.FireFoxOtherOptionsMain.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.FireFoxOtherOptionsMain.Location = new System.Drawing.Point(339, 301);
            this.FireFoxOtherOptionsMain.Name = "FireFoxOtherOptionsMain";
            this.FireFoxOtherOptionsMain.Size = new System.Drawing.Size(463, 53);
            this.FireFoxOtherOptionsMain.TabIndex = 8;
            this.FireFoxOtherOptionsMain.Text = "Other Options";
            // 
            // FireFoxFastRoundsStart
            // 
            this.FireFoxFastRoundsStart.Location = new System.Drawing.Point(304, 25);
            this.FireFoxFastRoundsStart.Name = "FireFoxFastRoundsStart";
            this.FireFoxFastRoundsStart.Size = new System.Drawing.Size(129, 23);
            this.FireFoxFastRoundsStart.TabIndex = 9;
            this.FireFoxFastRoundsStart.Text = "Enable Fast Rounds";
            this.FireFoxFastRoundsStart.Click += new System.EventHandler(this.FireFoxFastRoundsStart_Click);
            // 
            // FireFoxKillAllPlayers
            // 
            this.FireFoxKillAllPlayers.Location = new System.Drawing.Point(167, 25);
            this.FireFoxKillAllPlayers.Name = "FireFoxKillAllPlayers";
            this.FireFoxKillAllPlayers.Size = new System.Drawing.Size(129, 23);
            this.FireFoxKillAllPlayers.TabIndex = 8;
            this.FireFoxKillAllPlayers.Text = "Suicide All Players";
            this.FireFoxKillAllPlayers.Click += new System.EventHandler(this.FireFoxKillAllPlayers_Click);
            // 
            // FireFoxQuickXPOption
            // 
            this.FireFoxQuickXPOption.Location = new System.Drawing.Point(30, 25);
            this.FireFoxQuickXPOption.Name = "FireFoxQuickXPOption";
            this.FireFoxQuickXPOption.Size = new System.Drawing.Size(129, 23);
            this.FireFoxQuickXPOption.TabIndex = 7;
            this.FireFoxQuickXPOption.Text = "Instant Level 1,000";
            this.FireFoxQuickXPOption.Click += new System.EventHandler(this.FireFoxQuickXPOption_Click);
            // 
            // FireFoxLevelXPGB
            // 
            this.FireFoxLevelXPGB.Controls.Add(this.FireFoxLevelXPReset);
            this.FireFoxLevelXPGB.Controls.Add(this.FireFoxLevelXPSet);
            this.FireFoxLevelXPGB.Controls.Add(this.FireFoxLevelXPValue);
            this.FireFoxLevelXPGB.Controls.Add(this.FireFoxLevelXPSetTrackBar);
            this.FireFoxLevelXPGB.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.FireFoxLevelXPGB.Location = new System.Drawing.Point(339, 152);
            this.FireFoxLevelXPGB.Name = "FireFoxLevelXPGB";
            this.FireFoxLevelXPGB.Size = new System.Drawing.Size(463, 143);
            this.FireFoxLevelXPGB.TabIndex = 9;
            this.FireFoxLevelXPGB.Text = "Weapon XP Modifiers";
            // 
            // FireFoxLevelXPReset
            // 
            this.FireFoxLevelXPReset.Location = new System.Drawing.Point(159, 54);
            this.FireFoxLevelXPReset.Name = "FireFoxLevelXPReset";
            this.FireFoxLevelXPReset.Size = new System.Drawing.Size(139, 23);
            this.FireFoxLevelXPReset.TabIndex = 8;
            this.FireFoxLevelXPReset.Text = "Reset Weapon XP";
            this.FireFoxLevelXPReset.Click += new System.EventHandler(this.FireFoxLevelXPReset_Click);
            // 
            // FireFoxLevelXPSet
            // 
            this.FireFoxLevelXPSet.Location = new System.Drawing.Point(159, 28);
            this.FireFoxLevelXPSet.Name = "FireFoxLevelXPSet";
            this.FireFoxLevelXPSet.Size = new System.Drawing.Size(139, 23);
            this.FireFoxLevelXPSet.TabIndex = 7;
            this.FireFoxLevelXPSet.Text = "Set Weapon XP";
            this.FireFoxLevelXPSet.Click += new System.EventHandler(this.FireFoxLevelXPSet_Click);
            // 
            // FireFoxLevelXPValue
            // 
            this.FireFoxLevelXPValue.EditValue = "";
            this.FireFoxLevelXPValue.Location = new System.Drawing.Point(157, 80);
            this.FireFoxLevelXPValue.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxLevelXPValue.Name = "FireFoxLevelXPValue";
            this.FireFoxLevelXPValue.Size = new System.Drawing.Size(139, 20);
            this.FireFoxLevelXPValue.TabIndex = 7;
            // 
            // FireFoxLevelXPSetTrackBar
            // 
            this.FireFoxLevelXPSetTrackBar.EditValue = null;
            this.FireFoxLevelXPSetTrackBar.Location = new System.Drawing.Point(81, 96);
            this.FireFoxLevelXPSetTrackBar.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxLevelXPSetTrackBar.Name = "FireFoxLevelXPSetTrackBar";
            this.FireFoxLevelXPSetTrackBar.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.FireFoxLevelXPSetTrackBar.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FireFoxLevelXPSetTrackBar.Properties.Maximum = 10000;
            this.FireFoxLevelXPSetTrackBar.Size = new System.Drawing.Size(293, 45);
            this.FireFoxLevelXPSetTrackBar.TabIndex = 7;
            this.FireFoxLevelXPSetTrackBar.EditValueChanged += new System.EventHandler(this.FireFoxLevelXPSetTrackBar_EditValueChanged);
            // 
            // FireFoxPlayerXPGB
            // 
            this.FireFoxPlayerXPGB.Controls.Add(this.FireFoxPlayerXPReset);
            this.FireFoxPlayerXPGB.Controls.Add(this.FireFoxPlayerXPSet);
            this.FireFoxPlayerXPGB.Controls.Add(this.FireFoxPlayerXPValue);
            this.FireFoxPlayerXPGB.Controls.Add(this.FireFoxPlayerXPSetTrackBar);
            this.FireFoxPlayerXPGB.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.FireFoxPlayerXPGB.Location = new System.Drawing.Point(339, 0);
            this.FireFoxPlayerXPGB.Name = "FireFoxPlayerXPGB";
            this.FireFoxPlayerXPGB.Size = new System.Drawing.Size(463, 143);
            this.FireFoxPlayerXPGB.TabIndex = 2;
            this.FireFoxPlayerXPGB.Text = "Player XP Modifiers";
            // 
            // FireFoxPlayerXPReset
            // 
            this.FireFoxPlayerXPReset.Location = new System.Drawing.Point(159, 54);
            this.FireFoxPlayerXPReset.Name = "FireFoxPlayerXPReset";
            this.FireFoxPlayerXPReset.Size = new System.Drawing.Size(139, 23);
            this.FireFoxPlayerXPReset.TabIndex = 8;
            this.FireFoxPlayerXPReset.Text = "Reset Player XP";
            this.FireFoxPlayerXPReset.Click += new System.EventHandler(this.FireFoxPlayerXPReset_Click);
            // 
            // FireFoxPlayerXPSet
            // 
            this.FireFoxPlayerXPSet.Location = new System.Drawing.Point(159, 28);
            this.FireFoxPlayerXPSet.Name = "FireFoxPlayerXPSet";
            this.FireFoxPlayerXPSet.Size = new System.Drawing.Size(139, 23);
            this.FireFoxPlayerXPSet.TabIndex = 7;
            this.FireFoxPlayerXPSet.Text = "Set Player XP";
            this.FireFoxPlayerXPSet.Click += new System.EventHandler(this.FireFoxPlayerXPSet_Click);
            // 
            // FireFoxPlayerXPValue
            // 
            this.FireFoxPlayerXPValue.EditValue = "";
            this.FireFoxPlayerXPValue.Location = new System.Drawing.Point(157, 80);
            this.FireFoxPlayerXPValue.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxPlayerXPValue.Name = "FireFoxPlayerXPValue";
            this.FireFoxPlayerXPValue.Size = new System.Drawing.Size(139, 20);
            this.FireFoxPlayerXPValue.TabIndex = 7;
            // 
            // FireFoxPlayerXPSetTrackBar
            // 
            this.FireFoxPlayerXPSetTrackBar.EditValue = null;
            this.FireFoxPlayerXPSetTrackBar.Location = new System.Drawing.Point(81, 96);
            this.FireFoxPlayerXPSetTrackBar.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxPlayerXPSetTrackBar.Name = "FireFoxPlayerXPSetTrackBar";
            this.FireFoxPlayerXPSetTrackBar.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.FireFoxPlayerXPSetTrackBar.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FireFoxPlayerXPSetTrackBar.Properties.Maximum = 250000;
            this.FireFoxPlayerXPSetTrackBar.Size = new System.Drawing.Size(293, 45);
            this.FireFoxPlayerXPSetTrackBar.TabIndex = 7;
            this.FireFoxPlayerXPSetTrackBar.EditValueChanged += new System.EventHandler(this.FireFoxPlayerXPSetTrackBar_EditValueChanged);
            // 
            // FireFoxCrystalsGB
            // 
            this.FireFoxCrystalsGB.Controls.Add(this.FireFoxStartCrystalButton);
            this.FireFoxCrystalsGB.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.FireFoxCrystalsGB.Location = new System.Drawing.Point(8, 301);
            this.FireFoxCrystalsGB.Name = "FireFoxCrystalsGB";
            this.FireFoxCrystalsGB.Size = new System.Drawing.Size(321, 53);
            this.FireFoxCrystalsGB.TabIndex = 1;
            this.FireFoxCrystalsGB.Text = "Crystal Options";
            // 
            // FireFoxStartCrystalButton
            // 
            this.FireFoxStartCrystalButton.Enabled = false;
            this.FireFoxStartCrystalButton.Location = new System.Drawing.Point(96, 25);
            this.FireFoxStartCrystalButton.Name = "FireFoxStartCrystalButton";
            this.FireFoxStartCrystalButton.Size = new System.Drawing.Size(129, 23);
            this.FireFoxStartCrystalButton.TabIndex = 7;
            this.FireFoxStartCrystalButton.Text = "Start Crystals Unlock";
            this.FireFoxStartCrystalButton.Click += new System.EventHandler(this.FireFoxStartCrystalButton_Click);
            // 
            // FireFoxLobbyOptionsSpeedSettingsGB
            // 
            this.FireFoxLobbyOptionsSpeedSettingsGB.Controls.Add(this.FireFoxLobbyOptionsSpeedButton);
            this.FireFoxLobbyOptionsSpeedSettingsGB.Controls.Add(this.FireFoxLobbyOptionsSpeedValue);
            this.FireFoxLobbyOptionsSpeedSettingsGB.Controls.Add(this.FireFoxLobbyOptionsSpeedTrackController);
            this.FireFoxLobbyOptionsSpeedSettingsGB.Controls.Add(this.FireFoxLobbyOptionsJumpHeightValue);
            this.FireFoxLobbyOptionsSpeedSettingsGB.Controls.Add(this.FireFoxLobbyOptionsJumpHeightButton);
            this.FireFoxLobbyOptionsSpeedSettingsGB.Controls.Add(this.FireFoxLobbyOptionsJumpHeightTrackController);
            this.FireFoxLobbyOptionsSpeedSettingsGB.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.FireFoxLobbyOptionsSpeedSettingsGB.Location = new System.Drawing.Point(8, 0);
            this.FireFoxLobbyOptionsSpeedSettingsGB.Name = "FireFoxLobbyOptionsSpeedSettingsGB";
            this.FireFoxLobbyOptionsSpeedSettingsGB.Size = new System.Drawing.Size(321, 295);
            this.FireFoxLobbyOptionsSpeedSettingsGB.TabIndex = 0;
            this.FireFoxLobbyOptionsSpeedSettingsGB.Text = "Speed Settings";
            // 
            // FireFoxLobbyOptionsSpeedButton
            // 
            this.FireFoxLobbyOptionsSpeedButton.Location = new System.Drawing.Point(96, 170);
            this.FireFoxLobbyOptionsSpeedButton.Name = "FireFoxLobbyOptionsSpeedButton";
            this.FireFoxLobbyOptionsSpeedButton.Size = new System.Drawing.Size(129, 23);
            this.FireFoxLobbyOptionsSpeedButton.TabIndex = 6;
            this.FireFoxLobbyOptionsSpeedButton.Text = "Set Player Speed";
            this.FireFoxLobbyOptionsSpeedButton.Click += new System.EventHandler(this.FireFoxLobbyOptionsSpeedButton_Click);
            // 
            // FireFoxLobbyOptionsSpeedValue
            // 
            this.FireFoxLobbyOptionsSpeedValue.EditValue = "1";
            this.FireFoxLobbyOptionsSpeedValue.Location = new System.Drawing.Point(91, 223);
            this.FireFoxLobbyOptionsSpeedValue.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxLobbyOptionsSpeedValue.Name = "FireFoxLobbyOptionsSpeedValue";
            this.FireFoxLobbyOptionsSpeedValue.Size = new System.Drawing.Size(139, 20);
            this.FireFoxLobbyOptionsSpeedValue.TabIndex = 4;
            // 
            // FireFoxLobbyOptionsSpeedTrackController
            // 
            this.FireFoxLobbyOptionsSpeedTrackController.EditValue = 1;
            this.FireFoxLobbyOptionsSpeedTrackController.Location = new System.Drawing.Point(14, 198);
            this.FireFoxLobbyOptionsSpeedTrackController.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxLobbyOptionsSpeedTrackController.Name = "FireFoxLobbyOptionsSpeedTrackController";
            this.FireFoxLobbyOptionsSpeedTrackController.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.FireFoxLobbyOptionsSpeedTrackController.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FireFoxLobbyOptionsSpeedTrackController.Properties.Minimum = 1;
            this.FireFoxLobbyOptionsSpeedTrackController.Size = new System.Drawing.Size(293, 45);
            this.FireFoxLobbyOptionsSpeedTrackController.TabIndex = 5;
            this.FireFoxLobbyOptionsSpeedTrackController.Value = 1;
            this.FireFoxLobbyOptionsSpeedTrackController.EditValueChanged += new System.EventHandler(this.FireFoxLobbyOptionsSpeedTrackController_EditValueChanged);
            // 
            // FireFoxLobbyOptionsJumpHeightValue
            // 
            this.FireFoxLobbyOptionsJumpHeightValue.EditValue = "75";
            this.FireFoxLobbyOptionsJumpHeightValue.Location = new System.Drawing.Point(91, 121);
            this.FireFoxLobbyOptionsJumpHeightValue.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxLobbyOptionsJumpHeightValue.Name = "FireFoxLobbyOptionsJumpHeightValue";
            this.FireFoxLobbyOptionsJumpHeightValue.Size = new System.Drawing.Size(139, 20);
            this.FireFoxLobbyOptionsJumpHeightValue.TabIndex = 1;
            // 
            // FireFoxLobbyOptionsJumpHeightButton
            // 
            this.FireFoxLobbyOptionsJumpHeightButton.Location = new System.Drawing.Point(96, 70);
            this.FireFoxLobbyOptionsJumpHeightButton.Name = "FireFoxLobbyOptionsJumpHeightButton";
            this.FireFoxLobbyOptionsJumpHeightButton.Size = new System.Drawing.Size(129, 23);
            this.FireFoxLobbyOptionsJumpHeightButton.TabIndex = 0;
            this.FireFoxLobbyOptionsJumpHeightButton.Text = "Set Player Jump Height";
            this.FireFoxLobbyOptionsJumpHeightButton.Click += new System.EventHandler(this.FireFoxLobbyOptionsJumpHeightButton_Click);
            // 
            // FireFoxLobbyOptionsJumpHeightTrackController
            // 
            this.FireFoxLobbyOptionsJumpHeightTrackController.EditValue = 75;
            this.FireFoxLobbyOptionsJumpHeightTrackController.Location = new System.Drawing.Point(14, 96);
            this.FireFoxLobbyOptionsJumpHeightTrackController.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxLobbyOptionsJumpHeightTrackController.Name = "FireFoxLobbyOptionsJumpHeightTrackController";
            this.FireFoxLobbyOptionsJumpHeightTrackController.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.FireFoxLobbyOptionsJumpHeightTrackController.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FireFoxLobbyOptionsJumpHeightTrackController.Properties.Maximum = 10000;
            this.FireFoxLobbyOptionsJumpHeightTrackController.Properties.Minimum = 75;
            this.FireFoxLobbyOptionsJumpHeightTrackController.Size = new System.Drawing.Size(293, 45);
            this.FireFoxLobbyOptionsJumpHeightTrackController.TabIndex = 2;
            this.FireFoxLobbyOptionsJumpHeightTrackController.Value = 75;
            this.FireFoxLobbyOptionsJumpHeightTrackController.EditValueChanged += new System.EventHandler(this.FireFoxLobbyOptionsJumpHeightTrackController_EditValueChanged);
            // 
            // FireFoxDockerDA
            // 
            this.FireFoxDockerDA.Controls.Add(this.controlContainer15);
            this.FireFoxDockerDA.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxDockerDA.FloatSize = new System.Drawing.Size(833, 482);
            this.FireFoxDockerDA.ID = new System.Guid("66c337bb-a7e6-43e6-845c-9c4b7215e095");
            this.FireFoxDockerDA.Location = new System.Drawing.Point(3, 25);
            this.FireFoxDockerDA.Name = "FireFoxDockerDA";
            this.FireFoxDockerDA.Options.AllowDockAsTabbedDocument = false;
            this.FireFoxDockerDA.Options.AllowDockBottom = false;
            this.FireFoxDockerDA.Options.AllowDockLeft = false;
            this.FireFoxDockerDA.Options.AllowDockRight = false;
            this.FireFoxDockerDA.Options.AllowDockTop = false;
            this.FireFoxDockerDA.Options.ShowAutoHideButton = false;
            this.FireFoxDockerDA.Options.ShowCloseButton = false;
            this.FireFoxDockerDA.Options.ShowMaximizeButton = false;
            this.FireFoxDockerDA.OriginalSize = new System.Drawing.Size(803, 357);
            this.FireFoxDockerDA.Size = new System.Drawing.Size(810, 357);
            this.FireFoxDockerDA.Text = "Dark Aether";
            // 
            // controlContainer15
            // 
            this.controlContainer15.Controls.Add(this.FireFoxMainTabContainer);
            this.controlContainer15.Location = new System.Drawing.Point(0, 0);
            this.controlContainer15.Name = "controlContainer15";
            this.controlContainer15.Size = new System.Drawing.Size(810, 357);
            this.controlContainer15.TabIndex = 0;
            // 
            // FireFoxMainTabContainer
            // 
            this.FireFoxMainTabContainer.Location = new System.Drawing.Point(0, 0);
            this.FireFoxMainTabContainer.Name = "FireFoxMainTabContainer";
            this.FireFoxMainTabContainer.SelectedTabPage = this.FireFoxDATabP1;
            this.FireFoxMainTabContainer.Size = new System.Drawing.Size(822, 341);
            this.FireFoxMainTabContainer.TabIndex = 0;
            this.FireFoxMainTabContainer.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.FireFoxDATabP1,
            this.FireFoxDATabP2,
            this.FireFoxDATabP3,
            this.FireFoxDATabP4});
            // 
            // FireFoxDATabP1
            // 
            this.FireFoxDATabP1.Controls.Add(this.FireFoxInformationP1);
            this.FireFoxDATabP1.Controls.Add(this.FireFoxStartWeaponSpawningKeyPressP1);
            this.FireFoxDATabP1.Controls.Add(this.FireFoxStartSpawnWeaponsButtonP1);
            this.FireFoxDATabP1.Controls.Add(this.FireFoxResetKillCountP1);
            this.FireFoxDATabP1.Controls.Add(this.FirFoxP1DA);
            this.FireFoxDATabP1.Controls.Add(this.FireFoxTimedSpawnValueP1);
            this.FireFoxDATabP1.Controls.Add(this.FireFoxWeaponSwitchSpawnBoxPlayerOne);
            this.FireFoxDATabP1.Name = "FireFoxDATabP1";
            this.FireFoxDATabP1.Size = new System.Drawing.Size(820, 314);
            this.FireFoxDATabP1.Text = "Player One";
            // 
            // FireFoxInformationP1
            // 
            this.FireFoxInformationP1.Controls.Add(this.FireFoxP1LocationDA);
            this.FireFoxInformationP1.Controls.Add(this.FireFoxP1DarkAetherReady);
            this.FireFoxInformationP1.Controls.Add(this.FireFoxP1KillCount);
            this.FireFoxInformationP1.Controls.Add(this.FireFoxCurrentWeaponP1);
            this.FireFoxInformationP1.Controls.Add(this.FireFoxPlayerOneSpawnWeaponsDA);
            this.FireFoxInformationP1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.FireFoxInformationP1.Location = new System.Drawing.Point(5, 6);
            this.FireFoxInformationP1.Name = "FireFoxInformationP1";
            this.FireFoxInformationP1.Size = new System.Drawing.Size(280, 157);
            this.FireFoxInformationP1.TabIndex = 245;
            this.FireFoxInformationP1.Text = "Information";
            // 
            // FireFoxP1LocationDA
            // 
            this.FireFoxP1LocationDA.AutoSize = true;
            this.FireFoxP1LocationDA.ForeColor = System.Drawing.Color.White;
            this.FireFoxP1LocationDA.Location = new System.Drawing.Point(5, 107);
            this.FireFoxP1LocationDA.Name = "FireFoxP1LocationDA";
            this.FireFoxP1LocationDA.Size = new System.Drawing.Size(126, 13);
            this.FireFoxP1LocationDA.TabIndex = 299;
            this.FireFoxP1LocationDA.Text = "Location: Not Connected";
            this.FireFoxP1LocationDA.Visible = false;
            // 
            // FireFoxP1DarkAetherReady
            // 
            this.FireFoxP1DarkAetherReady.AutoSize = true;
            this.FireFoxP1DarkAetherReady.ForeColor = System.Drawing.Color.White;
            this.FireFoxP1DarkAetherReady.Location = new System.Drawing.Point(5, 87);
            this.FireFoxP1DarkAetherReady.Name = "FireFoxP1DarkAetherReady";
            this.FireFoxP1DarkAetherReady.Size = new System.Drawing.Size(162, 13);
            this.FireFoxP1DarkAetherReady.TabIndex = 298;
            this.FireFoxP1DarkAetherReady.Text = "Dark Aether Ready: Not Started";
            this.FireFoxP1DarkAetherReady.Visible = false;
            // 
            // FireFoxP1KillCount
            // 
            this.FireFoxP1KillCount.AutoSize = true;
            this.FireFoxP1KillCount.ForeColor = System.Drawing.Color.White;
            this.FireFoxP1KillCount.Location = new System.Drawing.Point(5, 67);
            this.FireFoxP1KillCount.Name = "FireFoxP1KillCount";
            this.FireFoxP1KillCount.Size = new System.Drawing.Size(127, 13);
            this.FireFoxP1KillCount.TabIndex = 297;
            this.FireFoxP1KillCount.Text = "Kill Count: Hasn\'t Started";
            // 
            // FireFoxCurrentWeaponP1
            // 
            this.FireFoxCurrentWeaponP1.AutoSize = true;
            this.FireFoxCurrentWeaponP1.ForeColor = System.Drawing.Color.White;
            this.FireFoxCurrentWeaponP1.Location = new System.Drawing.Point(5, 47);
            this.FireFoxCurrentWeaponP1.Name = "FireFoxCurrentWeaponP1";
            this.FireFoxCurrentWeaponP1.Size = new System.Drawing.Size(125, 13);
            this.FireFoxCurrentWeaponP1.TabIndex = 296;
            this.FireFoxCurrentWeaponP1.Text = "Progress: Hasn\'t Started";
            // 
            // FireFoxPlayerOneSpawnWeaponsDA
            // 
            this.FireFoxPlayerOneSpawnWeaponsDA.AutoSize = true;
            this.FireFoxPlayerOneSpawnWeaponsDA.ForeColor = System.Drawing.Color.White;
            this.FireFoxPlayerOneSpawnWeaponsDA.Location = new System.Drawing.Point(5, 27);
            this.FireFoxPlayerOneSpawnWeaponsDA.Name = "FireFoxPlayerOneSpawnWeaponsDA";
            this.FireFoxPlayerOneSpawnWeaponsDA.Size = new System.Drawing.Size(113, 13);
            this.FireFoxPlayerOneSpawnWeaponsDA.TabIndex = 295;
            this.FireFoxPlayerOneSpawnWeaponsDA.Text = "Name: Not Connected";
            // 
            // FireFoxStartWeaponSpawningKeyPressP1
            // 
            this.FireFoxStartWeaponSpawningKeyPressP1.Location = new System.Drawing.Point(383, 278);
            this.FireFoxStartWeaponSpawningKeyPressP1.Name = "FireFoxStartWeaponSpawningKeyPressP1";
            this.FireFoxStartWeaponSpawningKeyPressP1.Size = new System.Drawing.Size(156, 23);
            this.FireFoxStartWeaponSpawningKeyPressP1.TabIndex = 244;
            this.FireFoxStartWeaponSpawningKeyPressP1.Text = "Start Weapon Spawning (Key)";
            this.FireFoxStartWeaponSpawningKeyPressP1.Click += new System.EventHandler(this.FireFoxStartWeaponSpawningKeyPressP1_Click);
            // 
            // FireFoxStartSpawnWeaponsButtonP1
            // 
            this.FireFoxStartSpawnWeaponsButtonP1.Location = new System.Drawing.Point(383, 250);
            this.FireFoxStartSpawnWeaponsButtonP1.Name = "FireFoxStartSpawnWeaponsButtonP1";
            this.FireFoxStartSpawnWeaponsButtonP1.Size = new System.Drawing.Size(156, 23);
            this.FireFoxStartSpawnWeaponsButtonP1.TabIndex = 243;
            this.FireFoxStartSpawnWeaponsButtonP1.Text = "Start Weapon Spawning";
            this.FireFoxStartSpawnWeaponsButtonP1.Click += new System.EventHandler(this.FireFoxStartSpawnWeaponsButtonP1_Click);
            // 
            // FireFoxResetKillCountP1
            // 
            this.FireFoxResetKillCountP1.Location = new System.Drawing.Point(383, 222);
            this.FireFoxResetKillCountP1.Name = "FireFoxResetKillCountP1";
            this.FireFoxResetKillCountP1.Size = new System.Drawing.Size(156, 23);
            this.FireFoxResetKillCountP1.TabIndex = 242;
            this.FireFoxResetKillCountP1.Text = "Reset Kill Count";
            this.FireFoxResetKillCountP1.Click += new System.EventHandler(this.FireFoxResetKillCountP1_Click);
            // 
            // FirFoxP1DA
            // 
            this.FirFoxP1DA.Enabled = false;
            this.FirFoxP1DA.Location = new System.Drawing.Point(383, 194);
            this.FirFoxP1DA.Name = "FirFoxP1DA";
            this.FirFoxP1DA.Size = new System.Drawing.Size(156, 23);
            this.FirFoxP1DA.TabIndex = 241;
            this.FirFoxP1DA.Text = "Start Dark Aether Unlock";
            this.FirFoxP1DA.Click += new System.EventHandler(this.FirFoxP1DA_Click);
            // 
            // FireFoxTimedSpawnValueP1
            // 
            this.FireFoxTimedSpawnValueP1.EditValue = "Kill Swap Value";
            this.FireFoxTimedSpawnValueP1.Location = new System.Drawing.Point(383, 169);
            this.FireFoxTimedSpawnValueP1.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxTimedSpawnValueP1.Name = "FireFoxTimedSpawnValueP1";
            this.FireFoxTimedSpawnValueP1.Size = new System.Drawing.Size(156, 20);
            this.FireFoxTimedSpawnValueP1.TabIndex = 240;
            // 
            // FireFoxWeaponSwitchSpawnBoxPlayerOne
            // 
            this.FireFoxWeaponSwitchSpawnBoxPlayerOne.Location = new System.Drawing.Point(291, 6);
            this.FireFoxWeaponSwitchSpawnBoxPlayerOne.Name = "FireFoxWeaponSwitchSpawnBoxPlayerOne";
            this.FireFoxWeaponSwitchSpawnBoxPlayerOne.Size = new System.Drawing.Size(339, 157);
            this.FireFoxWeaponSwitchSpawnBoxPlayerOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxWeaponSwitchSpawnBoxPlayerOne.TabIndex = 239;
            this.FireFoxWeaponSwitchSpawnBoxPlayerOne.TabStop = false;
            // 
            // FireFoxDATabP2
            // 
            this.FireFoxDATabP2.Controls.Add(this.FireFoxInformationP2);
            this.FireFoxDATabP2.Controls.Add(this.FireFoxStartWeaponSpawningKeyPressP2);
            this.FireFoxDATabP2.Controls.Add(this.FireFoxStartSpawnWeaponsButtonP2);
            this.FireFoxDATabP2.Controls.Add(this.FireFoxResetKillCountP2);
            this.FireFoxDATabP2.Controls.Add(this.FirFoxP2DA);
            this.FireFoxDATabP2.Controls.Add(this.FireFoxTimedSpawnValueP2);
            this.FireFoxDATabP2.Controls.Add(this.FireFoxWeaponSwitchSpawnBoxPlayerTwo);
            this.FireFoxDATabP2.Name = "FireFoxDATabP2";
            this.FireFoxDATabP2.Size = new System.Drawing.Size(820, 314);
            this.FireFoxDATabP2.Text = "Player Two";
            // 
            // FireFoxInformationP2
            // 
            this.FireFoxInformationP2.Controls.Add(this.FireFoxP2LocationDA);
            this.FireFoxInformationP2.Controls.Add(this.FireFoxP2DarkAetherReady);
            this.FireFoxInformationP2.Controls.Add(this.FireFoxP2KillCount);
            this.FireFoxInformationP2.Controls.Add(this.FireFoxCurrentWeaponP2);
            this.FireFoxInformationP2.Controls.Add(this.FireFoxPlayerTwoSpawnWeaponsDA);
            this.FireFoxInformationP2.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.FireFoxInformationP2.Location = new System.Drawing.Point(5, 6);
            this.FireFoxInformationP2.Name = "FireFoxInformationP2";
            this.FireFoxInformationP2.Size = new System.Drawing.Size(280, 157);
            this.FireFoxInformationP2.TabIndex = 252;
            this.FireFoxInformationP2.Text = "Information";
            // 
            // FireFoxP2LocationDA
            // 
            this.FireFoxP2LocationDA.AutoSize = true;
            this.FireFoxP2LocationDA.ForeColor = System.Drawing.Color.White;
            this.FireFoxP2LocationDA.Location = new System.Drawing.Point(5, 107);
            this.FireFoxP2LocationDA.Name = "FireFoxP2LocationDA";
            this.FireFoxP2LocationDA.Size = new System.Drawing.Size(126, 13);
            this.FireFoxP2LocationDA.TabIndex = 299;
            this.FireFoxP2LocationDA.Text = "Location: Not Connected";
            this.FireFoxP2LocationDA.Visible = false;
            // 
            // FireFoxP2DarkAetherReady
            // 
            this.FireFoxP2DarkAetherReady.AutoSize = true;
            this.FireFoxP2DarkAetherReady.ForeColor = System.Drawing.Color.White;
            this.FireFoxP2DarkAetherReady.Location = new System.Drawing.Point(5, 87);
            this.FireFoxP2DarkAetherReady.Name = "FireFoxP2DarkAetherReady";
            this.FireFoxP2DarkAetherReady.Size = new System.Drawing.Size(162, 13);
            this.FireFoxP2DarkAetherReady.TabIndex = 298;
            this.FireFoxP2DarkAetherReady.Text = "Dark Aether Ready: Not Started";
            this.FireFoxP2DarkAetherReady.Visible = false;
            // 
            // FireFoxP2KillCount
            // 
            this.FireFoxP2KillCount.AutoSize = true;
            this.FireFoxP2KillCount.ForeColor = System.Drawing.Color.White;
            this.FireFoxP2KillCount.Location = new System.Drawing.Point(5, 67);
            this.FireFoxP2KillCount.Name = "FireFoxP2KillCount";
            this.FireFoxP2KillCount.Size = new System.Drawing.Size(127, 13);
            this.FireFoxP2KillCount.TabIndex = 297;
            this.FireFoxP2KillCount.Text = "Kill Count: Hasn\'t Started";
            // 
            // FireFoxCurrentWeaponP2
            // 
            this.FireFoxCurrentWeaponP2.AutoSize = true;
            this.FireFoxCurrentWeaponP2.ForeColor = System.Drawing.Color.White;
            this.FireFoxCurrentWeaponP2.Location = new System.Drawing.Point(5, 47);
            this.FireFoxCurrentWeaponP2.Name = "FireFoxCurrentWeaponP2";
            this.FireFoxCurrentWeaponP2.Size = new System.Drawing.Size(125, 13);
            this.FireFoxCurrentWeaponP2.TabIndex = 296;
            this.FireFoxCurrentWeaponP2.Text = "Progress: Hasn\'t Started";
            // 
            // FireFoxPlayerTwoSpawnWeaponsDA
            // 
            this.FireFoxPlayerTwoSpawnWeaponsDA.AutoSize = true;
            this.FireFoxPlayerTwoSpawnWeaponsDA.ForeColor = System.Drawing.Color.White;
            this.FireFoxPlayerTwoSpawnWeaponsDA.Location = new System.Drawing.Point(5, 27);
            this.FireFoxPlayerTwoSpawnWeaponsDA.Name = "FireFoxPlayerTwoSpawnWeaponsDA";
            this.FireFoxPlayerTwoSpawnWeaponsDA.Size = new System.Drawing.Size(113, 13);
            this.FireFoxPlayerTwoSpawnWeaponsDA.TabIndex = 295;
            this.FireFoxPlayerTwoSpawnWeaponsDA.Text = "Name: Not Connected";
            // 
            // FireFoxStartWeaponSpawningKeyPressP2
            // 
            this.FireFoxStartWeaponSpawningKeyPressP2.Location = new System.Drawing.Point(383, 278);
            this.FireFoxStartWeaponSpawningKeyPressP2.Name = "FireFoxStartWeaponSpawningKeyPressP2";
            this.FireFoxStartWeaponSpawningKeyPressP2.Size = new System.Drawing.Size(156, 23);
            this.FireFoxStartWeaponSpawningKeyPressP2.TabIndex = 251;
            this.FireFoxStartWeaponSpawningKeyPressP2.Text = "Start Weapon Spawning (Key)";
            this.FireFoxStartWeaponSpawningKeyPressP2.Click += new System.EventHandler(this.FireFoxStartWeaponSpawningKeyPressP2_Click);
            // 
            // FireFoxStartSpawnWeaponsButtonP2
            // 
            this.FireFoxStartSpawnWeaponsButtonP2.Location = new System.Drawing.Point(383, 250);
            this.FireFoxStartSpawnWeaponsButtonP2.Name = "FireFoxStartSpawnWeaponsButtonP2";
            this.FireFoxStartSpawnWeaponsButtonP2.Size = new System.Drawing.Size(156, 23);
            this.FireFoxStartSpawnWeaponsButtonP2.TabIndex = 250;
            this.FireFoxStartSpawnWeaponsButtonP2.Text = "Start Weapon Spawning";
            this.FireFoxStartSpawnWeaponsButtonP2.Click += new System.EventHandler(this.FireFoxStartSpawnWeaponsButtonP2_Click);
            // 
            // FireFoxResetKillCountP2
            // 
            this.FireFoxResetKillCountP2.Location = new System.Drawing.Point(383, 222);
            this.FireFoxResetKillCountP2.Name = "FireFoxResetKillCountP2";
            this.FireFoxResetKillCountP2.Size = new System.Drawing.Size(156, 23);
            this.FireFoxResetKillCountP2.TabIndex = 249;
            this.FireFoxResetKillCountP2.Text = "Reset Kill Count";
            this.FireFoxResetKillCountP2.Click += new System.EventHandler(this.FireFoxResetKillCountP2_Click);
            // 
            // FirFoxP2DA
            // 
            this.FirFoxP2DA.Enabled = false;
            this.FirFoxP2DA.Location = new System.Drawing.Point(383, 194);
            this.FirFoxP2DA.Name = "FirFoxP2DA";
            this.FirFoxP2DA.Size = new System.Drawing.Size(156, 23);
            this.FirFoxP2DA.TabIndex = 248;
            this.FirFoxP2DA.Text = "Start Dark Aether Unlock";
            this.FirFoxP2DA.Click += new System.EventHandler(this.FirFoxP2DA_Click);
            // 
            // FireFoxTimedSpawnValueP2
            // 
            this.FireFoxTimedSpawnValueP2.EditValue = "Kill Swap Value";
            this.FireFoxTimedSpawnValueP2.Location = new System.Drawing.Point(383, 169);
            this.FireFoxTimedSpawnValueP2.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxTimedSpawnValueP2.Name = "FireFoxTimedSpawnValueP2";
            this.FireFoxTimedSpawnValueP2.Size = new System.Drawing.Size(156, 20);
            this.FireFoxTimedSpawnValueP2.TabIndex = 247;
            // 
            // FireFoxWeaponSwitchSpawnBoxPlayerTwo
            // 
            this.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Location = new System.Drawing.Point(291, 6);
            this.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Name = "FireFoxWeaponSwitchSpawnBoxPlayerTwo";
            this.FireFoxWeaponSwitchSpawnBoxPlayerTwo.Size = new System.Drawing.Size(339, 157);
            this.FireFoxWeaponSwitchSpawnBoxPlayerTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxWeaponSwitchSpawnBoxPlayerTwo.TabIndex = 246;
            this.FireFoxWeaponSwitchSpawnBoxPlayerTwo.TabStop = false;
            // 
            // FireFoxDATabP3
            // 
            this.FireFoxDATabP3.Controls.Add(this.FireFoxInformationP3);
            this.FireFoxDATabP3.Controls.Add(this.FireFoxStartWeaponSpawningKeyPressP3);
            this.FireFoxDATabP3.Controls.Add(this.FireFoxStartSpawnWeaponsButtonP3);
            this.FireFoxDATabP3.Controls.Add(this.FireFoxResetKillCountP3);
            this.FireFoxDATabP3.Controls.Add(this.FirFoxP3DA);
            this.FireFoxDATabP3.Controls.Add(this.FireFoxTimedSpawnValueP3);
            this.FireFoxDATabP3.Controls.Add(this.FireFoxWeaponSwitchSpawnBoxPlayerThree);
            this.FireFoxDATabP3.Name = "FireFoxDATabP3";
            this.FireFoxDATabP3.Size = new System.Drawing.Size(820, 314);
            this.FireFoxDATabP3.Text = "Player Three";
            // 
            // FireFoxInformationP3
            // 
            this.FireFoxInformationP3.Controls.Add(this.FireFoxP3LocationDA);
            this.FireFoxInformationP3.Controls.Add(this.FireFoxP3DarkAetherReady);
            this.FireFoxInformationP3.Controls.Add(this.FireFoxP3KillCount);
            this.FireFoxInformationP3.Controls.Add(this.FireFoxCurrentWeaponP3);
            this.FireFoxInformationP3.Controls.Add(this.FireFoxPlayerThreeSpawnWeaponsDA);
            this.FireFoxInformationP3.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.FireFoxInformationP3.Location = new System.Drawing.Point(5, 6);
            this.FireFoxInformationP3.Name = "FireFoxInformationP3";
            this.FireFoxInformationP3.Size = new System.Drawing.Size(280, 157);
            this.FireFoxInformationP3.TabIndex = 259;
            this.FireFoxInformationP3.Text = "Information";
            // 
            // FireFoxP3LocationDA
            // 
            this.FireFoxP3LocationDA.AutoSize = true;
            this.FireFoxP3LocationDA.ForeColor = System.Drawing.Color.White;
            this.FireFoxP3LocationDA.Location = new System.Drawing.Point(5, 107);
            this.FireFoxP3LocationDA.Name = "FireFoxP3LocationDA";
            this.FireFoxP3LocationDA.Size = new System.Drawing.Size(126, 13);
            this.FireFoxP3LocationDA.TabIndex = 299;
            this.FireFoxP3LocationDA.Text = "Location: Not Connected";
            this.FireFoxP3LocationDA.Visible = false;
            // 
            // FireFoxP3DarkAetherReady
            // 
            this.FireFoxP3DarkAetherReady.AutoSize = true;
            this.FireFoxP3DarkAetherReady.ForeColor = System.Drawing.Color.White;
            this.FireFoxP3DarkAetherReady.Location = new System.Drawing.Point(5, 87);
            this.FireFoxP3DarkAetherReady.Name = "FireFoxP3DarkAetherReady";
            this.FireFoxP3DarkAetherReady.Size = new System.Drawing.Size(162, 13);
            this.FireFoxP3DarkAetherReady.TabIndex = 298;
            this.FireFoxP3DarkAetherReady.Text = "Dark Aether Ready: Not Started";
            this.FireFoxP3DarkAetherReady.Visible = false;
            // 
            // FireFoxP3KillCount
            // 
            this.FireFoxP3KillCount.AutoSize = true;
            this.FireFoxP3KillCount.ForeColor = System.Drawing.Color.White;
            this.FireFoxP3KillCount.Location = new System.Drawing.Point(5, 67);
            this.FireFoxP3KillCount.Name = "FireFoxP3KillCount";
            this.FireFoxP3KillCount.Size = new System.Drawing.Size(127, 13);
            this.FireFoxP3KillCount.TabIndex = 297;
            this.FireFoxP3KillCount.Text = "Kill Count: Hasn\'t Started";
            // 
            // FireFoxCurrentWeaponP3
            // 
            this.FireFoxCurrentWeaponP3.AutoSize = true;
            this.FireFoxCurrentWeaponP3.ForeColor = System.Drawing.Color.White;
            this.FireFoxCurrentWeaponP3.Location = new System.Drawing.Point(5, 47);
            this.FireFoxCurrentWeaponP3.Name = "FireFoxCurrentWeaponP3";
            this.FireFoxCurrentWeaponP3.Size = new System.Drawing.Size(125, 13);
            this.FireFoxCurrentWeaponP3.TabIndex = 296;
            this.FireFoxCurrentWeaponP3.Text = "Progress: Hasn\'t Started";
            // 
            // FireFoxPlayerThreeSpawnWeaponsDA
            // 
            this.FireFoxPlayerThreeSpawnWeaponsDA.AutoSize = true;
            this.FireFoxPlayerThreeSpawnWeaponsDA.ForeColor = System.Drawing.Color.White;
            this.FireFoxPlayerThreeSpawnWeaponsDA.Location = new System.Drawing.Point(5, 27);
            this.FireFoxPlayerThreeSpawnWeaponsDA.Name = "FireFoxPlayerThreeSpawnWeaponsDA";
            this.FireFoxPlayerThreeSpawnWeaponsDA.Size = new System.Drawing.Size(113, 13);
            this.FireFoxPlayerThreeSpawnWeaponsDA.TabIndex = 295;
            this.FireFoxPlayerThreeSpawnWeaponsDA.Text = "Name: Not Connected";
            // 
            // FireFoxStartWeaponSpawningKeyPressP3
            // 
            this.FireFoxStartWeaponSpawningKeyPressP3.Location = new System.Drawing.Point(383, 278);
            this.FireFoxStartWeaponSpawningKeyPressP3.Name = "FireFoxStartWeaponSpawningKeyPressP3";
            this.FireFoxStartWeaponSpawningKeyPressP3.Size = new System.Drawing.Size(156, 23);
            this.FireFoxStartWeaponSpawningKeyPressP3.TabIndex = 258;
            this.FireFoxStartWeaponSpawningKeyPressP3.Text = "Start Weapon Spawning (Key)";
            this.FireFoxStartWeaponSpawningKeyPressP3.Click += new System.EventHandler(this.FireFoxStartWeaponSpawningKeyPressP3_Click);
            // 
            // FireFoxStartSpawnWeaponsButtonP3
            // 
            this.FireFoxStartSpawnWeaponsButtonP3.Location = new System.Drawing.Point(383, 250);
            this.FireFoxStartSpawnWeaponsButtonP3.Name = "FireFoxStartSpawnWeaponsButtonP3";
            this.FireFoxStartSpawnWeaponsButtonP3.Size = new System.Drawing.Size(156, 23);
            this.FireFoxStartSpawnWeaponsButtonP3.TabIndex = 257;
            this.FireFoxStartSpawnWeaponsButtonP3.Text = "Start Weapon Spawning";
            this.FireFoxStartSpawnWeaponsButtonP3.Click += new System.EventHandler(this.FireFoxStartSpawnWeaponsButtonP3_Click);
            // 
            // FireFoxResetKillCountP3
            // 
            this.FireFoxResetKillCountP3.Location = new System.Drawing.Point(383, 222);
            this.FireFoxResetKillCountP3.Name = "FireFoxResetKillCountP3";
            this.FireFoxResetKillCountP3.Size = new System.Drawing.Size(156, 23);
            this.FireFoxResetKillCountP3.TabIndex = 256;
            this.FireFoxResetKillCountP3.Text = "Reset Kill Count";
            this.FireFoxResetKillCountP3.Click += new System.EventHandler(this.FireFoxResetKillCountP3_Click);
            // 
            // FirFoxP3DA
            // 
            this.FirFoxP3DA.Enabled = false;
            this.FirFoxP3DA.Location = new System.Drawing.Point(383, 194);
            this.FirFoxP3DA.Name = "FirFoxP3DA";
            this.FirFoxP3DA.Size = new System.Drawing.Size(156, 23);
            this.FirFoxP3DA.TabIndex = 255;
            this.FirFoxP3DA.Text = "Start Dark Aether Unlock";
            this.FirFoxP3DA.Click += new System.EventHandler(this.FirFoxP3DA_Click);
            // 
            // FireFoxTimedSpawnValueP3
            // 
            this.FireFoxTimedSpawnValueP3.EditValue = "Kill Swap Value";
            this.FireFoxTimedSpawnValueP3.Location = new System.Drawing.Point(383, 169);
            this.FireFoxTimedSpawnValueP3.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxTimedSpawnValueP3.Name = "FireFoxTimedSpawnValueP3";
            this.FireFoxTimedSpawnValueP3.Size = new System.Drawing.Size(156, 20);
            this.FireFoxTimedSpawnValueP3.TabIndex = 254;
            // 
            // FireFoxWeaponSwitchSpawnBoxPlayerThree
            // 
            this.FireFoxWeaponSwitchSpawnBoxPlayerThree.Location = new System.Drawing.Point(291, 6);
            this.FireFoxWeaponSwitchSpawnBoxPlayerThree.Name = "FireFoxWeaponSwitchSpawnBoxPlayerThree";
            this.FireFoxWeaponSwitchSpawnBoxPlayerThree.Size = new System.Drawing.Size(339, 157);
            this.FireFoxWeaponSwitchSpawnBoxPlayerThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxWeaponSwitchSpawnBoxPlayerThree.TabIndex = 253;
            this.FireFoxWeaponSwitchSpawnBoxPlayerThree.TabStop = false;
            // 
            // FireFoxDATabP4
            // 
            this.FireFoxDATabP4.Controls.Add(this.FireFoxStartWeaponSpawningKeyPressP4);
            this.FireFoxDATabP4.Controls.Add(this.FireFoxInformationP4);
            this.FireFoxDATabP4.Controls.Add(this.FireFoxStartSpawnWeaponsButtonP4);
            this.FireFoxDATabP4.Controls.Add(this.FireFoxResetKillCountP4);
            this.FireFoxDATabP4.Controls.Add(this.FirFoxP4DA);
            this.FireFoxDATabP4.Controls.Add(this.FireFoxTimedSpawnValueP4);
            this.FireFoxDATabP4.Controls.Add(this.FireFoxWeaponSwitchSpawnBoxPlayerFour);
            this.FireFoxDATabP4.Name = "FireFoxDATabP4";
            this.FireFoxDATabP4.Size = new System.Drawing.Size(820, 314);
            this.FireFoxDATabP4.Text = "Player Four";
            // 
            // FireFoxStartWeaponSpawningKeyPressP4
            // 
            this.FireFoxStartWeaponSpawningKeyPressP4.Location = new System.Drawing.Point(383, 278);
            this.FireFoxStartWeaponSpawningKeyPressP4.Name = "FireFoxStartWeaponSpawningKeyPressP4";
            this.FireFoxStartWeaponSpawningKeyPressP4.Size = new System.Drawing.Size(156, 23);
            this.FireFoxStartWeaponSpawningKeyPressP4.TabIndex = 267;
            this.FireFoxStartWeaponSpawningKeyPressP4.Text = "Start Weapon Spawning (Key)";
            this.FireFoxStartWeaponSpawningKeyPressP4.Click += new System.EventHandler(this.FireFoxStartWeaponSpawningKeyPressP4_Click);
            // 
            // FireFoxInformationP4
            // 
            this.FireFoxInformationP4.Controls.Add(this.FireFoxP4LocationDA);
            this.FireFoxInformationP4.Controls.Add(this.FireFoxP4DarkAetherReady);
            this.FireFoxInformationP4.Controls.Add(this.FireFoxP4KillCount);
            this.FireFoxInformationP4.Controls.Add(this.FireFoxCurrentWeaponP4);
            this.FireFoxInformationP4.Controls.Add(this.FireFoxPlayerFourSpawnWeaponsDA);
            this.FireFoxInformationP4.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.FireFoxInformationP4.Location = new System.Drawing.Point(5, 6);
            this.FireFoxInformationP4.Name = "FireFoxInformationP4";
            this.FireFoxInformationP4.Size = new System.Drawing.Size(280, 157);
            this.FireFoxInformationP4.TabIndex = 266;
            this.FireFoxInformationP4.Text = "Information";
            // 
            // FireFoxP4LocationDA
            // 
            this.FireFoxP4LocationDA.AutoSize = true;
            this.FireFoxP4LocationDA.ForeColor = System.Drawing.Color.White;
            this.FireFoxP4LocationDA.Location = new System.Drawing.Point(5, 107);
            this.FireFoxP4LocationDA.Name = "FireFoxP4LocationDA";
            this.FireFoxP4LocationDA.Size = new System.Drawing.Size(126, 13);
            this.FireFoxP4LocationDA.TabIndex = 299;
            this.FireFoxP4LocationDA.Text = "Location: Not Connected";
            this.FireFoxP4LocationDA.Visible = false;
            // 
            // FireFoxP4DarkAetherReady
            // 
            this.FireFoxP4DarkAetherReady.AutoSize = true;
            this.FireFoxP4DarkAetherReady.ForeColor = System.Drawing.Color.White;
            this.FireFoxP4DarkAetherReady.Location = new System.Drawing.Point(5, 87);
            this.FireFoxP4DarkAetherReady.Name = "FireFoxP4DarkAetherReady";
            this.FireFoxP4DarkAetherReady.Size = new System.Drawing.Size(162, 13);
            this.FireFoxP4DarkAetherReady.TabIndex = 298;
            this.FireFoxP4DarkAetherReady.Text = "Dark Aether Ready: Not Started";
            this.FireFoxP4DarkAetherReady.Visible = false;
            // 
            // FireFoxP4KillCount
            // 
            this.FireFoxP4KillCount.AutoSize = true;
            this.FireFoxP4KillCount.ForeColor = System.Drawing.Color.White;
            this.FireFoxP4KillCount.Location = new System.Drawing.Point(5, 67);
            this.FireFoxP4KillCount.Name = "FireFoxP4KillCount";
            this.FireFoxP4KillCount.Size = new System.Drawing.Size(127, 13);
            this.FireFoxP4KillCount.TabIndex = 297;
            this.FireFoxP4KillCount.Text = "Kill Count: Hasn\'t Started";
            // 
            // FireFoxCurrentWeaponP4
            // 
            this.FireFoxCurrentWeaponP4.AutoSize = true;
            this.FireFoxCurrentWeaponP4.ForeColor = System.Drawing.Color.White;
            this.FireFoxCurrentWeaponP4.Location = new System.Drawing.Point(5, 47);
            this.FireFoxCurrentWeaponP4.Name = "FireFoxCurrentWeaponP4";
            this.FireFoxCurrentWeaponP4.Size = new System.Drawing.Size(125, 13);
            this.FireFoxCurrentWeaponP4.TabIndex = 296;
            this.FireFoxCurrentWeaponP4.Text = "Progress: Hasn\'t Started";
            // 
            // FireFoxPlayerFourSpawnWeaponsDA
            // 
            this.FireFoxPlayerFourSpawnWeaponsDA.AutoSize = true;
            this.FireFoxPlayerFourSpawnWeaponsDA.ForeColor = System.Drawing.Color.White;
            this.FireFoxPlayerFourSpawnWeaponsDA.Location = new System.Drawing.Point(5, 27);
            this.FireFoxPlayerFourSpawnWeaponsDA.Name = "FireFoxPlayerFourSpawnWeaponsDA";
            this.FireFoxPlayerFourSpawnWeaponsDA.Size = new System.Drawing.Size(113, 13);
            this.FireFoxPlayerFourSpawnWeaponsDA.TabIndex = 295;
            this.FireFoxPlayerFourSpawnWeaponsDA.Text = "Name: Not Connected";
            // 
            // FireFoxStartSpawnWeaponsButtonP4
            // 
            this.FireFoxStartSpawnWeaponsButtonP4.Location = new System.Drawing.Point(383, 250);
            this.FireFoxStartSpawnWeaponsButtonP4.Name = "FireFoxStartSpawnWeaponsButtonP4";
            this.FireFoxStartSpawnWeaponsButtonP4.Size = new System.Drawing.Size(156, 23);
            this.FireFoxStartSpawnWeaponsButtonP4.TabIndex = 264;
            this.FireFoxStartSpawnWeaponsButtonP4.Text = "Start Weapon Spawning";
            this.FireFoxStartSpawnWeaponsButtonP4.Click += new System.EventHandler(this.FireFoxStartSpawnWeaponsButtonP4_Click);
            // 
            // FireFoxResetKillCountP4
            // 
            this.FireFoxResetKillCountP4.Location = new System.Drawing.Point(383, 222);
            this.FireFoxResetKillCountP4.Name = "FireFoxResetKillCountP4";
            this.FireFoxResetKillCountP4.Size = new System.Drawing.Size(156, 23);
            this.FireFoxResetKillCountP4.TabIndex = 263;
            this.FireFoxResetKillCountP4.Text = "Reset Kill Count";
            this.FireFoxResetKillCountP4.Click += new System.EventHandler(this.FireFoxResetKillCountP4_Click);
            // 
            // FirFoxP4DA
            // 
            this.FirFoxP4DA.Enabled = false;
            this.FirFoxP4DA.Location = new System.Drawing.Point(383, 194);
            this.FirFoxP4DA.Name = "FirFoxP4DA";
            this.FirFoxP4DA.Size = new System.Drawing.Size(156, 23);
            this.FirFoxP4DA.TabIndex = 262;
            this.FirFoxP4DA.Text = "Start Dark Aether Unlock";
            this.FirFoxP4DA.Click += new System.EventHandler(this.FirFoxP4DA_Click);
            // 
            // FireFoxTimedSpawnValueP4
            // 
            this.FireFoxTimedSpawnValueP4.EditValue = "Kill Swap Value";
            this.FireFoxTimedSpawnValueP4.Location = new System.Drawing.Point(383, 169);
            this.FireFoxTimedSpawnValueP4.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxTimedSpawnValueP4.Name = "FireFoxTimedSpawnValueP4";
            this.FireFoxTimedSpawnValueP4.Size = new System.Drawing.Size(156, 20);
            this.FireFoxTimedSpawnValueP4.TabIndex = 261;
            // 
            // FireFoxWeaponSwitchSpawnBoxPlayerFour
            // 
            this.FireFoxWeaponSwitchSpawnBoxPlayerFour.Location = new System.Drawing.Point(291, 6);
            this.FireFoxWeaponSwitchSpawnBoxPlayerFour.Name = "FireFoxWeaponSwitchSpawnBoxPlayerFour";
            this.FireFoxWeaponSwitchSpawnBoxPlayerFour.Size = new System.Drawing.Size(339, 157);
            this.FireFoxWeaponSwitchSpawnBoxPlayerFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxWeaponSwitchSpawnBoxPlayerFour.TabIndex = 260;
            this.FireFoxWeaponSwitchSpawnBoxPlayerFour.TabStop = false;
            // 
            // FireFoxDockerReticles
            // 
            this.FireFoxDockerReticles.Controls.Add(this.controlContainer16);
            this.FireFoxDockerReticles.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxDockerReticles.Enabled = false;
            this.FireFoxDockerReticles.FloatSize = new System.Drawing.Size(833, 482);
            this.FireFoxDockerReticles.ID = new System.Guid("22630fb3-0ca1-4c49-a537-1eaec40dfac8");
            this.FireFoxDockerReticles.Location = new System.Drawing.Point(3, 25);
            this.FireFoxDockerReticles.Name = "FireFoxDockerReticles";
            this.FireFoxDockerReticles.Options.AllowDockAsTabbedDocument = false;
            this.FireFoxDockerReticles.Options.AllowDockBottom = false;
            this.FireFoxDockerReticles.Options.AllowDockRight = false;
            this.FireFoxDockerReticles.Options.AllowDockTop = false;
            this.FireFoxDockerReticles.Options.ShowAutoHideButton = false;
            this.FireFoxDockerReticles.Options.ShowCloseButton = false;
            this.FireFoxDockerReticles.Options.ShowMaximizeButton = false;
            this.FireFoxDockerReticles.OriginalSize = new System.Drawing.Size(803, 357);
            this.FireFoxDockerReticles.Size = new System.Drawing.Size(810, 357);
            this.FireFoxDockerReticles.Text = "Reticles";
            // 
            // controlContainer16
            // 
            this.controlContainer16.Controls.Add(this.FireFoxReticlesMainTabController);
            this.controlContainer16.Location = new System.Drawing.Point(0, 0);
            this.controlContainer16.Name = "controlContainer16";
            this.controlContainer16.Size = new System.Drawing.Size(810, 357);
            this.controlContainer16.TabIndex = 0;
            // 
            // FireFoxReticlesMainTabController
            // 
            this.FireFoxReticlesMainTabController.Location = new System.Drawing.Point(0, 0);
            this.FireFoxReticlesMainTabController.Name = "FireFoxReticlesMainTabController";
            this.FireFoxReticlesMainTabController.SelectedTabPage = this.FireFoxReticlesTabP1;
            this.FireFoxReticlesMainTabController.Size = new System.Drawing.Size(822, 341);
            this.FireFoxReticlesMainTabController.TabIndex = 18;
            this.FireFoxReticlesMainTabController.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.FireFoxReticlesTabP1,
            this.FireFoxReticlesTabP2,
            this.FireFoxReticlesTabP3,
            this.FireFoxReticlesTabP4});
            // 
            // FireFoxReticlesTabP1
            // 
            this.FireFoxReticlesTabP1.Controls.Add(this.FireFoxInformationReticlesP1);
            this.FireFoxReticlesTabP1.Controls.Add(this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne);
            this.FireFoxReticlesTabP1.Controls.Add(this.FireFoxStartSpawnWeaponsButtonReticlesP1);
            this.FireFoxReticlesTabP1.Controls.Add(this.FireFoxResetKillCountReticlesP1);
            this.FireFoxReticlesTabP1.Controls.Add(this.FirFoxP1Reticles);
            this.FireFoxReticlesTabP1.Controls.Add(this.FireFoxTimedSpawnValueReticlesP1);
            this.FireFoxReticlesTabP1.Name = "FireFoxReticlesTabP1";
            this.FireFoxReticlesTabP1.Size = new System.Drawing.Size(820, 314);
            this.FireFoxReticlesTabP1.Text = "Player One";
            // 
            // FireFoxInformationReticlesP1
            // 
            this.FireFoxInformationReticlesP1.Controls.Add(this.FireFoxP1LocationReticles);
            this.FireFoxInformationReticlesP1.Controls.Add(this.FireFoxP1KillCountReticles);
            this.FireFoxInformationReticlesP1.Controls.Add(this.FireFoxCurrentWeaponReticlesP1);
            this.FireFoxInformationReticlesP1.Controls.Add(this.FireFoxPlayerOneSpawnWeaponsReticles);
            this.FireFoxInformationReticlesP1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.FireFoxInformationReticlesP1.Location = new System.Drawing.Point(5, 6);
            this.FireFoxInformationReticlesP1.Name = "FireFoxInformationReticlesP1";
            this.FireFoxInformationReticlesP1.Size = new System.Drawing.Size(280, 157);
            this.FireFoxInformationReticlesP1.TabIndex = 246;
            this.FireFoxInformationReticlesP1.Text = "Information";
            // 
            // FireFoxP1LocationReticles
            // 
            this.FireFoxP1LocationReticles.AutoSize = true;
            this.FireFoxP1LocationReticles.ForeColor = System.Drawing.Color.White;
            this.FireFoxP1LocationReticles.Location = new System.Drawing.Point(5, 88);
            this.FireFoxP1LocationReticles.Name = "FireFoxP1LocationReticles";
            this.FireFoxP1LocationReticles.Size = new System.Drawing.Size(126, 13);
            this.FireFoxP1LocationReticles.TabIndex = 299;
            this.FireFoxP1LocationReticles.Text = "Location: Not Connected";
            // 
            // FireFoxP1KillCountReticles
            // 
            this.FireFoxP1KillCountReticles.AutoSize = true;
            this.FireFoxP1KillCountReticles.ForeColor = System.Drawing.Color.White;
            this.FireFoxP1KillCountReticles.Location = new System.Drawing.Point(5, 67);
            this.FireFoxP1KillCountReticles.Name = "FireFoxP1KillCountReticles";
            this.FireFoxP1KillCountReticles.Size = new System.Drawing.Size(127, 13);
            this.FireFoxP1KillCountReticles.TabIndex = 297;
            this.FireFoxP1KillCountReticles.Text = "Kill Count: Hasn\'t Started";
            // 
            // FireFoxCurrentWeaponReticlesP1
            // 
            this.FireFoxCurrentWeaponReticlesP1.AutoSize = true;
            this.FireFoxCurrentWeaponReticlesP1.ForeColor = System.Drawing.Color.White;
            this.FireFoxCurrentWeaponReticlesP1.Location = new System.Drawing.Point(5, 47);
            this.FireFoxCurrentWeaponReticlesP1.Name = "FireFoxCurrentWeaponReticlesP1";
            this.FireFoxCurrentWeaponReticlesP1.Size = new System.Drawing.Size(125, 13);
            this.FireFoxCurrentWeaponReticlesP1.TabIndex = 296;
            this.FireFoxCurrentWeaponReticlesP1.Text = "Progress: Hasn\'t Started";
            // 
            // FireFoxPlayerOneSpawnWeaponsReticles
            // 
            this.FireFoxPlayerOneSpawnWeaponsReticles.AutoSize = true;
            this.FireFoxPlayerOneSpawnWeaponsReticles.ForeColor = System.Drawing.Color.White;
            this.FireFoxPlayerOneSpawnWeaponsReticles.Location = new System.Drawing.Point(5, 27);
            this.FireFoxPlayerOneSpawnWeaponsReticles.Name = "FireFoxPlayerOneSpawnWeaponsReticles";
            this.FireFoxPlayerOneSpawnWeaponsReticles.Size = new System.Drawing.Size(113, 13);
            this.FireFoxPlayerOneSpawnWeaponsReticles.TabIndex = 295;
            this.FireFoxPlayerOneSpawnWeaponsReticles.Text = "Name: Not Connected";
            // 
            // FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne
            // 
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.Location = new System.Drawing.Point(291, 6);
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.Name = "FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne";
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.Size = new System.Drawing.Size(339, 157);
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.TabIndex = 240;
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne.TabStop = false;
            // 
            // FireFoxStartSpawnWeaponsButtonReticlesP1
            // 
            this.FireFoxStartSpawnWeaponsButtonReticlesP1.Location = new System.Drawing.Point(383, 250);
            this.FireFoxStartSpawnWeaponsButtonReticlesP1.Name = "FireFoxStartSpawnWeaponsButtonReticlesP1";
            this.FireFoxStartSpawnWeaponsButtonReticlesP1.Size = new System.Drawing.Size(156, 23);
            this.FireFoxStartSpawnWeaponsButtonReticlesP1.TabIndex = 269;
            this.FireFoxStartSpawnWeaponsButtonReticlesP1.Text = "Start Weapon Spawning";
            this.FireFoxStartSpawnWeaponsButtonReticlesP1.Click += new System.EventHandler(this.FireFoxStartSpawnWeaponsButtonReticlesP1_Click);
            // 
            // FireFoxResetKillCountReticlesP1
            // 
            this.FireFoxResetKillCountReticlesP1.Location = new System.Drawing.Point(383, 222);
            this.FireFoxResetKillCountReticlesP1.Name = "FireFoxResetKillCountReticlesP1";
            this.FireFoxResetKillCountReticlesP1.Size = new System.Drawing.Size(156, 23);
            this.FireFoxResetKillCountReticlesP1.TabIndex = 268;
            this.FireFoxResetKillCountReticlesP1.Text = "Reset Kill Count";
            this.FireFoxResetKillCountReticlesP1.Click += new System.EventHandler(this.FireFoxResetKillCountReticlesP1_Click);
            // 
            // FirFoxP1Reticles
            // 
            this.FirFoxP1Reticles.Location = new System.Drawing.Point(383, 194);
            this.FirFoxP1Reticles.Name = "FirFoxP1Reticles";
            this.FirFoxP1Reticles.Size = new System.Drawing.Size(156, 23);
            this.FirFoxP1Reticles.TabIndex = 267;
            this.FirFoxP1Reticles.Text = "Start Reticles Unlock";
            this.FirFoxP1Reticles.Click += new System.EventHandler(this.FirFoxP1Reticles_Click);
            // 
            // FireFoxTimedSpawnValueReticlesP1
            // 
            this.FireFoxTimedSpawnValueReticlesP1.EditValue = "Kill Swap Value";
            this.FireFoxTimedSpawnValueReticlesP1.Location = new System.Drawing.Point(383, 169);
            this.FireFoxTimedSpawnValueReticlesP1.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxTimedSpawnValueReticlesP1.Name = "FireFoxTimedSpawnValueReticlesP1";
            this.FireFoxTimedSpawnValueReticlesP1.Size = new System.Drawing.Size(156, 20);
            this.FireFoxTimedSpawnValueReticlesP1.TabIndex = 266;
            // 
            // FireFoxReticlesTabP2
            // 
            this.FireFoxReticlesTabP2.Controls.Add(this.FireFoxStartSpawnWeaponsButtonReticlesP2);
            this.FireFoxReticlesTabP2.Controls.Add(this.FireFoxResetKillCountReticlesP2);
            this.FireFoxReticlesTabP2.Controls.Add(this.FirFoxP2Reticles);
            this.FireFoxReticlesTabP2.Controls.Add(this.FireFoxTimedSpawnValueReticlesP2);
            this.FireFoxReticlesTabP2.Controls.Add(this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo);
            this.FireFoxReticlesTabP2.Controls.Add(this.FireFoxInformationReticlesP2);
            this.FireFoxReticlesTabP2.Name = "FireFoxReticlesTabP2";
            this.FireFoxReticlesTabP2.Size = new System.Drawing.Size(820, 314);
            this.FireFoxReticlesTabP2.Text = "Player Two";
            // 
            // FireFoxStartSpawnWeaponsButtonReticlesP2
            // 
            this.FireFoxStartSpawnWeaponsButtonReticlesP2.Location = new System.Drawing.Point(383, 250);
            this.FireFoxStartSpawnWeaponsButtonReticlesP2.Name = "FireFoxStartSpawnWeaponsButtonReticlesP2";
            this.FireFoxStartSpawnWeaponsButtonReticlesP2.Size = new System.Drawing.Size(156, 23);
            this.FireFoxStartSpawnWeaponsButtonReticlesP2.TabIndex = 272;
            this.FireFoxStartSpawnWeaponsButtonReticlesP2.Text = "Start Weapon Spawning";
            this.FireFoxStartSpawnWeaponsButtonReticlesP2.Click += new System.EventHandler(this.FireFoxStartSpawnWeaponsButtonReticlesP2_Click);
            // 
            // FireFoxResetKillCountReticlesP2
            // 
            this.FireFoxResetKillCountReticlesP2.Location = new System.Drawing.Point(383, 222);
            this.FireFoxResetKillCountReticlesP2.Name = "FireFoxResetKillCountReticlesP2";
            this.FireFoxResetKillCountReticlesP2.Size = new System.Drawing.Size(156, 23);
            this.FireFoxResetKillCountReticlesP2.TabIndex = 271;
            this.FireFoxResetKillCountReticlesP2.Text = "Reset Kill Count";
            this.FireFoxResetKillCountReticlesP2.Click += new System.EventHandler(this.FireFoxResetKillCountReticlesP2_Click);
            // 
            // FirFoxP2Reticles
            // 
            this.FirFoxP2Reticles.Location = new System.Drawing.Point(383, 194);
            this.FirFoxP2Reticles.Name = "FirFoxP2Reticles";
            this.FirFoxP2Reticles.Size = new System.Drawing.Size(156, 23);
            this.FirFoxP2Reticles.TabIndex = 270;
            this.FirFoxP2Reticles.Text = "Start Reticles Unlock";
            this.FirFoxP2Reticles.Click += new System.EventHandler(this.FirFoxP2Reticles_Click);
            // 
            // FireFoxTimedSpawnValueReticlesP2
            // 
            this.FireFoxTimedSpawnValueReticlesP2.EditValue = "Kill Swap Value";
            this.FireFoxTimedSpawnValueReticlesP2.Location = new System.Drawing.Point(383, 169);
            this.FireFoxTimedSpawnValueReticlesP2.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxTimedSpawnValueReticlesP2.Name = "FireFoxTimedSpawnValueReticlesP2";
            this.FireFoxTimedSpawnValueReticlesP2.Size = new System.Drawing.Size(156, 20);
            this.FireFoxTimedSpawnValueReticlesP2.TabIndex = 267;
            // 
            // FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo
            // 
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.Location = new System.Drawing.Point(291, 6);
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.Name = "FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo";
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.Size = new System.Drawing.Size(339, 157);
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.TabIndex = 248;
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo.TabStop = false;
            // 
            // FireFoxInformationReticlesP2
            // 
            this.FireFoxInformationReticlesP2.Controls.Add(this.FireFoxP2LocationReticles);
            this.FireFoxInformationReticlesP2.Controls.Add(this.FireFoxP2KillCountReticles);
            this.FireFoxInformationReticlesP2.Controls.Add(this.FireFoxCurrentWeaponReticlesP2);
            this.FireFoxInformationReticlesP2.Controls.Add(this.FireFoxPlayerTwoSpawnWeaponsReticles);
            this.FireFoxInformationReticlesP2.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.FireFoxInformationReticlesP2.Location = new System.Drawing.Point(5, 6);
            this.FireFoxInformationReticlesP2.Name = "FireFoxInformationReticlesP2";
            this.FireFoxInformationReticlesP2.Size = new System.Drawing.Size(280, 157);
            this.FireFoxInformationReticlesP2.TabIndex = 247;
            this.FireFoxInformationReticlesP2.Text = "Information";
            // 
            // FireFoxP2LocationReticles
            // 
            this.FireFoxP2LocationReticles.AutoSize = true;
            this.FireFoxP2LocationReticles.ForeColor = System.Drawing.Color.White;
            this.FireFoxP2LocationReticles.Location = new System.Drawing.Point(5, 88);
            this.FireFoxP2LocationReticles.Name = "FireFoxP2LocationReticles";
            this.FireFoxP2LocationReticles.Size = new System.Drawing.Size(126, 13);
            this.FireFoxP2LocationReticles.TabIndex = 299;
            this.FireFoxP2LocationReticles.Text = "Location: Not Connected";
            // 
            // FireFoxP2KillCountReticles
            // 
            this.FireFoxP2KillCountReticles.AutoSize = true;
            this.FireFoxP2KillCountReticles.ForeColor = System.Drawing.Color.White;
            this.FireFoxP2KillCountReticles.Location = new System.Drawing.Point(5, 67);
            this.FireFoxP2KillCountReticles.Name = "FireFoxP2KillCountReticles";
            this.FireFoxP2KillCountReticles.Size = new System.Drawing.Size(127, 13);
            this.FireFoxP2KillCountReticles.TabIndex = 297;
            this.FireFoxP2KillCountReticles.Text = "Kill Count: Hasn\'t Started";
            // 
            // FireFoxCurrentWeaponReticlesP2
            // 
            this.FireFoxCurrentWeaponReticlesP2.AutoSize = true;
            this.FireFoxCurrentWeaponReticlesP2.ForeColor = System.Drawing.Color.White;
            this.FireFoxCurrentWeaponReticlesP2.Location = new System.Drawing.Point(5, 47);
            this.FireFoxCurrentWeaponReticlesP2.Name = "FireFoxCurrentWeaponReticlesP2";
            this.FireFoxCurrentWeaponReticlesP2.Size = new System.Drawing.Size(125, 13);
            this.FireFoxCurrentWeaponReticlesP2.TabIndex = 296;
            this.FireFoxCurrentWeaponReticlesP2.Text = "Progress: Hasn\'t Started";
            // 
            // FireFoxPlayerTwoSpawnWeaponsReticles
            // 
            this.FireFoxPlayerTwoSpawnWeaponsReticles.AutoSize = true;
            this.FireFoxPlayerTwoSpawnWeaponsReticles.ForeColor = System.Drawing.Color.White;
            this.FireFoxPlayerTwoSpawnWeaponsReticles.Location = new System.Drawing.Point(5, 27);
            this.FireFoxPlayerTwoSpawnWeaponsReticles.Name = "FireFoxPlayerTwoSpawnWeaponsReticles";
            this.FireFoxPlayerTwoSpawnWeaponsReticles.Size = new System.Drawing.Size(113, 13);
            this.FireFoxPlayerTwoSpawnWeaponsReticles.TabIndex = 295;
            this.FireFoxPlayerTwoSpawnWeaponsReticles.Text = "Name: Not Connected";
            // 
            // FireFoxReticlesTabP3
            // 
            this.FireFoxReticlesTabP3.Controls.Add(this.FireFoxStartSpawnWeaponsButtonReticlesP3);
            this.FireFoxReticlesTabP3.Controls.Add(this.FireFoxResetKillCountReticlesP3);
            this.FireFoxReticlesTabP3.Controls.Add(this.FirFoxP3Reticles);
            this.FireFoxReticlesTabP3.Controls.Add(this.FireFoxTimedSpawnValueReticlesP3);
            this.FireFoxReticlesTabP3.Controls.Add(this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree);
            this.FireFoxReticlesTabP3.Controls.Add(this.FireFoxInformationReticlesP3);
            this.FireFoxReticlesTabP3.Name = "FireFoxReticlesTabP3";
            this.FireFoxReticlesTabP3.Size = new System.Drawing.Size(820, 314);
            this.FireFoxReticlesTabP3.Text = "Player Three";
            // 
            // FireFoxStartSpawnWeaponsButtonReticlesP3
            // 
            this.FireFoxStartSpawnWeaponsButtonReticlesP3.Location = new System.Drawing.Point(383, 250);
            this.FireFoxStartSpawnWeaponsButtonReticlesP3.Name = "FireFoxStartSpawnWeaponsButtonReticlesP3";
            this.FireFoxStartSpawnWeaponsButtonReticlesP3.Size = new System.Drawing.Size(156, 23);
            this.FireFoxStartSpawnWeaponsButtonReticlesP3.TabIndex = 276;
            this.FireFoxStartSpawnWeaponsButtonReticlesP3.Text = "Start Weapon Spawning";
            this.FireFoxStartSpawnWeaponsButtonReticlesP3.Click += new System.EventHandler(this.FireFoxStartSpawnWeaponsButtonReticlesP3_Click);
            // 
            // FireFoxResetKillCountReticlesP3
            // 
            this.FireFoxResetKillCountReticlesP3.Location = new System.Drawing.Point(383, 222);
            this.FireFoxResetKillCountReticlesP3.Name = "FireFoxResetKillCountReticlesP3";
            this.FireFoxResetKillCountReticlesP3.Size = new System.Drawing.Size(156, 23);
            this.FireFoxResetKillCountReticlesP3.TabIndex = 275;
            this.FireFoxResetKillCountReticlesP3.Text = "Reset Kill Count";
            this.FireFoxResetKillCountReticlesP3.Click += new System.EventHandler(this.FireFoxResetKillCountReticlesP3_Click);
            // 
            // FirFoxP3Reticles
            // 
            this.FirFoxP3Reticles.Location = new System.Drawing.Point(383, 194);
            this.FirFoxP3Reticles.Name = "FirFoxP3Reticles";
            this.FirFoxP3Reticles.Size = new System.Drawing.Size(156, 23);
            this.FirFoxP3Reticles.TabIndex = 274;
            this.FirFoxP3Reticles.Text = "Start Reticles Unlock";
            this.FirFoxP3Reticles.Click += new System.EventHandler(this.FirFoxP3Reticles_Click);
            // 
            // FireFoxTimedSpawnValueReticlesP3
            // 
            this.FireFoxTimedSpawnValueReticlesP3.EditValue = "Kill Swap Value";
            this.FireFoxTimedSpawnValueReticlesP3.Location = new System.Drawing.Point(383, 169);
            this.FireFoxTimedSpawnValueReticlesP3.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxTimedSpawnValueReticlesP3.Name = "FireFoxTimedSpawnValueReticlesP3";
            this.FireFoxTimedSpawnValueReticlesP3.Size = new System.Drawing.Size(156, 20);
            this.FireFoxTimedSpawnValueReticlesP3.TabIndex = 273;
            // 
            // FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree
            // 
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.Location = new System.Drawing.Point(291, 6);
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.Name = "FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree";
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.Size = new System.Drawing.Size(339, 157);
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.TabIndex = 249;
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree.TabStop = false;
            // 
            // FireFoxInformationReticlesP3
            // 
            this.FireFoxInformationReticlesP3.Controls.Add(this.FireFoxP3LocationReticles);
            this.FireFoxInformationReticlesP3.Controls.Add(this.FireFoxP3KillCountReticles);
            this.FireFoxInformationReticlesP3.Controls.Add(this.FireFoxCurrentWeaponReticlesP3);
            this.FireFoxInformationReticlesP3.Controls.Add(this.FireFoxPlayerThreeSpawnWeaponsReticles);
            this.FireFoxInformationReticlesP3.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.FireFoxInformationReticlesP3.Location = new System.Drawing.Point(5, 6);
            this.FireFoxInformationReticlesP3.Name = "FireFoxInformationReticlesP3";
            this.FireFoxInformationReticlesP3.Size = new System.Drawing.Size(280, 157);
            this.FireFoxInformationReticlesP3.TabIndex = 248;
            this.FireFoxInformationReticlesP3.Text = "Information";
            // 
            // FireFoxP3LocationReticles
            // 
            this.FireFoxP3LocationReticles.AutoSize = true;
            this.FireFoxP3LocationReticles.ForeColor = System.Drawing.Color.White;
            this.FireFoxP3LocationReticles.Location = new System.Drawing.Point(5, 88);
            this.FireFoxP3LocationReticles.Name = "FireFoxP3LocationReticles";
            this.FireFoxP3LocationReticles.Size = new System.Drawing.Size(126, 13);
            this.FireFoxP3LocationReticles.TabIndex = 299;
            this.FireFoxP3LocationReticles.Text = "Location: Not Connected";
            // 
            // FireFoxP3KillCountReticles
            // 
            this.FireFoxP3KillCountReticles.AutoSize = true;
            this.FireFoxP3KillCountReticles.ForeColor = System.Drawing.Color.White;
            this.FireFoxP3KillCountReticles.Location = new System.Drawing.Point(5, 67);
            this.FireFoxP3KillCountReticles.Name = "FireFoxP3KillCountReticles";
            this.FireFoxP3KillCountReticles.Size = new System.Drawing.Size(127, 13);
            this.FireFoxP3KillCountReticles.TabIndex = 297;
            this.FireFoxP3KillCountReticles.Text = "Kill Count: Hasn\'t Started";
            // 
            // FireFoxCurrentWeaponReticlesP3
            // 
            this.FireFoxCurrentWeaponReticlesP3.AutoSize = true;
            this.FireFoxCurrentWeaponReticlesP3.ForeColor = System.Drawing.Color.White;
            this.FireFoxCurrentWeaponReticlesP3.Location = new System.Drawing.Point(5, 47);
            this.FireFoxCurrentWeaponReticlesP3.Name = "FireFoxCurrentWeaponReticlesP3";
            this.FireFoxCurrentWeaponReticlesP3.Size = new System.Drawing.Size(125, 13);
            this.FireFoxCurrentWeaponReticlesP3.TabIndex = 296;
            this.FireFoxCurrentWeaponReticlesP3.Text = "Progress: Hasn\'t Started";
            // 
            // FireFoxPlayerThreeSpawnWeaponsReticles
            // 
            this.FireFoxPlayerThreeSpawnWeaponsReticles.AutoSize = true;
            this.FireFoxPlayerThreeSpawnWeaponsReticles.ForeColor = System.Drawing.Color.White;
            this.FireFoxPlayerThreeSpawnWeaponsReticles.Location = new System.Drawing.Point(5, 27);
            this.FireFoxPlayerThreeSpawnWeaponsReticles.Name = "FireFoxPlayerThreeSpawnWeaponsReticles";
            this.FireFoxPlayerThreeSpawnWeaponsReticles.Size = new System.Drawing.Size(113, 13);
            this.FireFoxPlayerThreeSpawnWeaponsReticles.TabIndex = 295;
            this.FireFoxPlayerThreeSpawnWeaponsReticles.Text = "Name: Not Connected";
            // 
            // FireFoxReticlesTabP4
            // 
            this.FireFoxReticlesTabP4.Controls.Add(this.FireFoxStartSpawnWeaponsButtonReticlesP4);
            this.FireFoxReticlesTabP4.Controls.Add(this.FireFoxResetKillCountReticlesP4);
            this.FireFoxReticlesTabP4.Controls.Add(this.FirFoxP4Reticles);
            this.FireFoxReticlesTabP4.Controls.Add(this.FireFoxTimedSpawnValueReticlesP4);
            this.FireFoxReticlesTabP4.Controls.Add(this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour);
            this.FireFoxReticlesTabP4.Controls.Add(this.FireFoxInformationReticlesP4);
            this.FireFoxReticlesTabP4.Name = "FireFoxReticlesTabP4";
            this.FireFoxReticlesTabP4.Size = new System.Drawing.Size(820, 314);
            this.FireFoxReticlesTabP4.Text = "Player Four";
            // 
            // FireFoxStartSpawnWeaponsButtonReticlesP4
            // 
            this.FireFoxStartSpawnWeaponsButtonReticlesP4.Location = new System.Drawing.Point(383, 250);
            this.FireFoxStartSpawnWeaponsButtonReticlesP4.Name = "FireFoxStartSpawnWeaponsButtonReticlesP4";
            this.FireFoxStartSpawnWeaponsButtonReticlesP4.Size = new System.Drawing.Size(156, 23);
            this.FireFoxStartSpawnWeaponsButtonReticlesP4.TabIndex = 276;
            this.FireFoxStartSpawnWeaponsButtonReticlesP4.Text = "Start Weapon Spawning";
            this.FireFoxStartSpawnWeaponsButtonReticlesP4.Click += new System.EventHandler(this.FireFoxStartSpawnWeaponsButtonReticlesP4_Click);
            // 
            // FireFoxResetKillCountReticlesP4
            // 
            this.FireFoxResetKillCountReticlesP4.Location = new System.Drawing.Point(383, 222);
            this.FireFoxResetKillCountReticlesP4.Name = "FireFoxResetKillCountReticlesP4";
            this.FireFoxResetKillCountReticlesP4.Size = new System.Drawing.Size(156, 23);
            this.FireFoxResetKillCountReticlesP4.TabIndex = 275;
            this.FireFoxResetKillCountReticlesP4.Text = "Reset Kill Count";
            this.FireFoxResetKillCountReticlesP4.Click += new System.EventHandler(this.FireFoxResetKillCountReticlesP4_Click);
            // 
            // FirFoxP4Reticles
            // 
            this.FirFoxP4Reticles.Location = new System.Drawing.Point(383, 194);
            this.FirFoxP4Reticles.Name = "FirFoxP4Reticles";
            this.FirFoxP4Reticles.Size = new System.Drawing.Size(156, 23);
            this.FirFoxP4Reticles.TabIndex = 274;
            this.FirFoxP4Reticles.Text = "Start Reticles Unlock";
            this.FirFoxP4Reticles.Click += new System.EventHandler(this.FirFoxP4Reticles_Click);
            // 
            // FireFoxTimedSpawnValueReticlesP4
            // 
            this.FireFoxTimedSpawnValueReticlesP4.EditValue = "Kill Swap Value";
            this.FireFoxTimedSpawnValueReticlesP4.Location = new System.Drawing.Point(383, 169);
            this.FireFoxTimedSpawnValueReticlesP4.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxTimedSpawnValueReticlesP4.Name = "FireFoxTimedSpawnValueReticlesP4";
            this.FireFoxTimedSpawnValueReticlesP4.Size = new System.Drawing.Size(156, 20);
            this.FireFoxTimedSpawnValueReticlesP4.TabIndex = 273;
            // 
            // FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour
            // 
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.Location = new System.Drawing.Point(291, 6);
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.Name = "FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour";
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.Size = new System.Drawing.Size(339, 157);
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.TabIndex = 250;
            this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour.TabStop = false;
            // 
            // FireFoxInformationReticlesP4
            // 
            this.FireFoxInformationReticlesP4.Controls.Add(this.FireFoxP4LocationReticles);
            this.FireFoxInformationReticlesP4.Controls.Add(this.FireFoxP4KillCountReticles);
            this.FireFoxInformationReticlesP4.Controls.Add(this.FireFoxCurrentWeaponReticlesP4);
            this.FireFoxInformationReticlesP4.Controls.Add(this.FireFoxPlayerFourSpawnWeaponsReticles);
            this.FireFoxInformationReticlesP4.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.FireFoxInformationReticlesP4.Location = new System.Drawing.Point(5, 6);
            this.FireFoxInformationReticlesP4.Name = "FireFoxInformationReticlesP4";
            this.FireFoxInformationReticlesP4.Size = new System.Drawing.Size(280, 157);
            this.FireFoxInformationReticlesP4.TabIndex = 249;
            this.FireFoxInformationReticlesP4.Text = "Information";
            // 
            // FireFoxP4LocationReticles
            // 
            this.FireFoxP4LocationReticles.AutoSize = true;
            this.FireFoxP4LocationReticles.ForeColor = System.Drawing.Color.White;
            this.FireFoxP4LocationReticles.Location = new System.Drawing.Point(5, 88);
            this.FireFoxP4LocationReticles.Name = "FireFoxP4LocationReticles";
            this.FireFoxP4LocationReticles.Size = new System.Drawing.Size(126, 13);
            this.FireFoxP4LocationReticles.TabIndex = 299;
            this.FireFoxP4LocationReticles.Text = "Location: Not Connected";
            // 
            // FireFoxP4KillCountReticles
            // 
            this.FireFoxP4KillCountReticles.AutoSize = true;
            this.FireFoxP4KillCountReticles.ForeColor = System.Drawing.Color.White;
            this.FireFoxP4KillCountReticles.Location = new System.Drawing.Point(5, 67);
            this.FireFoxP4KillCountReticles.Name = "FireFoxP4KillCountReticles";
            this.FireFoxP4KillCountReticles.Size = new System.Drawing.Size(127, 13);
            this.FireFoxP4KillCountReticles.TabIndex = 297;
            this.FireFoxP4KillCountReticles.Text = "Kill Count: Hasn\'t Started";
            // 
            // FireFoxCurrentWeaponReticlesP4
            // 
            this.FireFoxCurrentWeaponReticlesP4.AutoSize = true;
            this.FireFoxCurrentWeaponReticlesP4.ForeColor = System.Drawing.Color.White;
            this.FireFoxCurrentWeaponReticlesP4.Location = new System.Drawing.Point(5, 47);
            this.FireFoxCurrentWeaponReticlesP4.Name = "FireFoxCurrentWeaponReticlesP4";
            this.FireFoxCurrentWeaponReticlesP4.Size = new System.Drawing.Size(125, 13);
            this.FireFoxCurrentWeaponReticlesP4.TabIndex = 296;
            this.FireFoxCurrentWeaponReticlesP4.Text = "Progress: Hasn\'t Started";
            // 
            // FireFoxPlayerFourSpawnWeaponsReticles
            // 
            this.FireFoxPlayerFourSpawnWeaponsReticles.AutoSize = true;
            this.FireFoxPlayerFourSpawnWeaponsReticles.ForeColor = System.Drawing.Color.White;
            this.FireFoxPlayerFourSpawnWeaponsReticles.Location = new System.Drawing.Point(5, 27);
            this.FireFoxPlayerFourSpawnWeaponsReticles.Name = "FireFoxPlayerFourSpawnWeaponsReticles";
            this.FireFoxPlayerFourSpawnWeaponsReticles.Size = new System.Drawing.Size(113, 13);
            this.FireFoxPlayerFourSpawnWeaponsReticles.TabIndex = 295;
            this.FireFoxPlayerFourSpawnWeaponsReticles.Text = "Name: Not Connected";
            // 
            // FireFoxDockerStats
            // 
            this.FireFoxDockerStats.Controls.Add(this.controlContainer17);
            this.FireFoxDockerStats.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxDockerStats.Enabled = false;
            this.FireFoxDockerStats.FloatSize = new System.Drawing.Size(833, 482);
            this.FireFoxDockerStats.ID = new System.Guid("e4cc0cbf-dba0-433e-92fe-88688d6e7fd3");
            this.FireFoxDockerStats.Location = new System.Drawing.Point(3, 25);
            this.FireFoxDockerStats.Name = "FireFoxDockerStats";
            this.FireFoxDockerStats.Options.AllowDockAsTabbedDocument = false;
            this.FireFoxDockerStats.Options.AllowDockBottom = false;
            this.FireFoxDockerStats.Options.AllowDockRight = false;
            this.FireFoxDockerStats.Options.AllowDockTop = false;
            this.FireFoxDockerStats.Options.ShowAutoHideButton = false;
            this.FireFoxDockerStats.Options.ShowCloseButton = false;
            this.FireFoxDockerStats.Options.ShowMaximizeButton = false;
            this.FireFoxDockerStats.OriginalSize = new System.Drawing.Size(817, 200);
            this.FireFoxDockerStats.Size = new System.Drawing.Size(810, 357);
            this.FireFoxDockerStats.Text = "Stats";
            // 
            // controlContainer17
            // 
            this.controlContainer17.Controls.Add(this.FireFoxStatsProgressGB);
            this.controlContainer17.Controls.Add(this.FirFoxStatsOptionGroupBox);
            this.controlContainer17.Controls.Add(this.FireFoxRandomizeStatsGB);
            this.controlContainer17.Controls.Add(this.FireFoxStatsPlayerListGB);
            this.controlContainer17.Location = new System.Drawing.Point(0, 0);
            this.controlContainer17.Name = "controlContainer17";
            this.controlContainer17.Size = new System.Drawing.Size(810, 357);
            this.controlContainer17.TabIndex = 0;
            // 
            // FireFoxStatsProgressGB
            // 
            this.FireFoxStatsProgressGB.Controls.Add(this.FireFoxStatsProgressLB);
            this.FireFoxStatsProgressGB.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.FireFoxStatsProgressGB.Location = new System.Drawing.Point(251, 218);
            this.FireFoxStatsProgressGB.Name = "FireFoxStatsProgressGB";
            this.FireFoxStatsProgressGB.Size = new System.Drawing.Size(551, 134);
            this.FireFoxStatsProgressGB.TabIndex = 21;
            this.FireFoxStatsProgressGB.Text = "Stats Status/Progress";
            // 
            // FireFoxStatsProgressLB
            // 
            this.FireFoxStatsProgressLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.FireFoxStatsProgressLB.ForeColor = System.Drawing.Color.White;
            this.FireFoxStatsProgressLB.FormattingEnabled = true;
            this.FireFoxStatsProgressLB.Location = new System.Drawing.Point(5, 22);
            this.FireFoxStatsProgressLB.Name = "FireFoxStatsProgressLB";
            this.FireFoxStatsProgressLB.Size = new System.Drawing.Size(541, 108);
            this.FireFoxStatsProgressLB.TabIndex = 277;
            // 
            // FirFoxStatsOptionGroupBox
            // 
            this.FirFoxStatsOptionGroupBox.Controls.Add(this.FireFoxSendStatsButton);
            this.FirFoxStatsOptionGroupBox.Controls.Add(this.FireFoxTotalTimePlayedMinsInput);
            this.FirFoxStatsOptionGroupBox.Controls.Add(this.FireFoxTotalTimePlayedHoursInput);
            this.FirFoxStatsOptionGroupBox.Controls.Add(this.FireFoxTotalTimePlayedDaysInput);
            this.FirFoxStatsOptionGroupBox.Controls.Add(this.FireFoxTotalGamesPlayedInput);
            this.FirFoxStatsOptionGroupBox.Controls.Add(this.FireFoxTotalElimsInput);
            this.FirFoxStatsOptionGroupBox.Controls.Add(this.FireFoxTotalCriticalKillsInput);
            this.FirFoxStatsOptionGroupBox.Controls.Add(this.FireFoxTotalEliteKillsInput);
            this.FirFoxStatsOptionGroupBox.Controls.Add(this.FireFoxTotalKillsInput);
            this.FirFoxStatsOptionGroupBox.Controls.Add(this.FireFoxTotalRoundsInput);
            this.FirFoxStatsOptionGroupBox.Controls.Add(this.FireFoxTotalTimePlayedMinsStatsLabel);
            this.FirFoxStatsOptionGroupBox.Controls.Add(this.FireFoxTotalTimePlayedHoursStatsLabel);
            this.FirFoxStatsOptionGroupBox.Controls.Add(this.FireFoxTotalTimePlayedDaysStatsLabel);
            this.FirFoxStatsOptionGroupBox.Controls.Add(this.FireFoxTotalGamesPlayedStatsLabel);
            this.FirFoxStatsOptionGroupBox.Controls.Add(this.FireFoxTotalElimsStatsLabel);
            this.FirFoxStatsOptionGroupBox.Controls.Add(this.FireFoxTotalCriticalKillsStatsLabel);
            this.FirFoxStatsOptionGroupBox.Controls.Add(this.FireFoxTotalEliteKillsStatsLabel);
            this.FirFoxStatsOptionGroupBox.Controls.Add(this.FireFoxTotalKillsStatsLabel);
            this.FirFoxStatsOptionGroupBox.Controls.Add(this.FireFoxTotalRoundsStatsLabel);
            this.FirFoxStatsOptionGroupBox.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.FirFoxStatsOptionGroupBox.Location = new System.Drawing.Point(248, 3);
            this.FirFoxStatsOptionGroupBox.Name = "FirFoxStatsOptionGroupBox";
            this.FirFoxStatsOptionGroupBox.Size = new System.Drawing.Size(554, 209);
            this.FirFoxStatsOptionGroupBox.TabIndex = 20;
            this.FirFoxStatsOptionGroupBox.Text = "Stats Options";
            // 
            // FireFoxSendStatsButton
            // 
            this.FireFoxSendStatsButton.Location = new System.Drawing.Point(213, 168);
            this.FireFoxSendStatsButton.Name = "FireFoxSendStatsButton";
            this.FireFoxSendStatsButton.Size = new System.Drawing.Size(129, 23);
            this.FireFoxSendStatsButton.TabIndex = 4;
            this.FireFoxSendStatsButton.Text = "Send Stats";
            this.FireFoxSendStatsButton.Click += new System.EventHandler(this.FireFoxSendStatsButton_Click);
            // 
            // FireFoxTotalTimePlayedMinsInput
            // 
            this.FireFoxTotalTimePlayedMinsInput.EditValue = "";
            this.FireFoxTotalTimePlayedMinsInput.Location = new System.Drawing.Point(356, 116);
            this.FireFoxTotalTimePlayedMinsInput.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxTotalTimePlayedMinsInput.Name = "FireFoxTotalTimePlayedMinsInput";
            this.FireFoxTotalTimePlayedMinsInput.Size = new System.Drawing.Size(96, 20);
            this.FireFoxTotalTimePlayedMinsInput.TabIndex = 291;
            // 
            // FireFoxTotalTimePlayedHoursInput
            // 
            this.FireFoxTotalTimePlayedHoursInput.EditValue = "";
            this.FireFoxTotalTimePlayedHoursInput.Location = new System.Drawing.Point(229, 116);
            this.FireFoxTotalTimePlayedHoursInput.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxTotalTimePlayedHoursInput.Name = "FireFoxTotalTimePlayedHoursInput";
            this.FireFoxTotalTimePlayedHoursInput.Size = new System.Drawing.Size(96, 20);
            this.FireFoxTotalTimePlayedHoursInput.TabIndex = 290;
            // 
            // FireFoxTotalTimePlayedDaysInput
            // 
            this.FireFoxTotalTimePlayedDaysInput.EditValue = "";
            this.FireFoxTotalTimePlayedDaysInput.Location = new System.Drawing.Point(106, 116);
            this.FireFoxTotalTimePlayedDaysInput.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxTotalTimePlayedDaysInput.Name = "FireFoxTotalTimePlayedDaysInput";
            this.FireFoxTotalTimePlayedDaysInput.Size = new System.Drawing.Size(96, 20);
            this.FireFoxTotalTimePlayedDaysInput.TabIndex = 289;
            // 
            // FireFoxTotalGamesPlayedInput
            // 
            this.FireFoxTotalGamesPlayedInput.EditValue = "";
            this.FireFoxTotalGamesPlayedInput.Location = new System.Drawing.Point(356, 73);
            this.FireFoxTotalGamesPlayedInput.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxTotalGamesPlayedInput.Name = "FireFoxTotalGamesPlayedInput";
            this.FireFoxTotalGamesPlayedInput.Size = new System.Drawing.Size(96, 20);
            this.FireFoxTotalGamesPlayedInput.TabIndex = 288;
            // 
            // FireFoxTotalElimsInput
            // 
            this.FireFoxTotalElimsInput.EditValue = "";
            this.FireFoxTotalElimsInput.Location = new System.Drawing.Point(230, 73);
            this.FireFoxTotalElimsInput.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxTotalElimsInput.Name = "FireFoxTotalElimsInput";
            this.FireFoxTotalElimsInput.Size = new System.Drawing.Size(96, 20);
            this.FireFoxTotalElimsInput.TabIndex = 287;
            // 
            // FireFoxTotalCriticalKillsInput
            // 
            this.FireFoxTotalCriticalKillsInput.EditValue = "";
            this.FireFoxTotalCriticalKillsInput.Location = new System.Drawing.Point(106, 73);
            this.FireFoxTotalCriticalKillsInput.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxTotalCriticalKillsInput.Name = "FireFoxTotalCriticalKillsInput";
            this.FireFoxTotalCriticalKillsInput.Size = new System.Drawing.Size(96, 20);
            this.FireFoxTotalCriticalKillsInput.TabIndex = 286;
            // 
            // FireFoxTotalEliteKillsInput
            // 
            this.FireFoxTotalEliteKillsInput.EditValue = "";
            this.FireFoxTotalEliteKillsInput.Location = new System.Drawing.Point(356, 32);
            this.FireFoxTotalEliteKillsInput.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxTotalEliteKillsInput.Name = "FireFoxTotalEliteKillsInput";
            this.FireFoxTotalEliteKillsInput.Size = new System.Drawing.Size(96, 20);
            this.FireFoxTotalEliteKillsInput.TabIndex = 285;
            // 
            // FireFoxTotalKillsInput
            // 
            this.FireFoxTotalKillsInput.EditValue = "";
            this.FireFoxTotalKillsInput.Location = new System.Drawing.Point(230, 32);
            this.FireFoxTotalKillsInput.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxTotalKillsInput.Name = "FireFoxTotalKillsInput";
            this.FireFoxTotalKillsInput.Size = new System.Drawing.Size(96, 20);
            this.FireFoxTotalKillsInput.TabIndex = 284;
            // 
            // FireFoxTotalRoundsInput
            // 
            this.FireFoxTotalRoundsInput.EditValue = "";
            this.FireFoxTotalRoundsInput.Location = new System.Drawing.Point(106, 32);
            this.FireFoxTotalRoundsInput.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxTotalRoundsInput.Name = "FireFoxTotalRoundsInput";
            this.FireFoxTotalRoundsInput.Size = new System.Drawing.Size(96, 20);
            this.FireFoxTotalRoundsInput.TabIndex = 283;
            // 
            // FireFoxTotalTimePlayedMinsStatsLabel
            // 
            this.FireFoxTotalTimePlayedMinsStatsLabel.AutoSize = true;
            this.FireFoxTotalTimePlayedMinsStatsLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxTotalTimePlayedMinsStatsLabel.Location = new System.Drawing.Point(356, 139);
            this.FireFoxTotalTimePlayedMinsStatsLabel.Name = "FireFoxTotalTimePlayedMinsStatsLabel";
            this.FireFoxTotalTimePlayedMinsStatsLabel.Size = new System.Drawing.Size(96, 13);
            this.FireFoxTotalTimePlayedMinsStatsLabel.TabIndex = 282;
            this.FireFoxTotalTimePlayedMinsStatsLabel.Text = "Time Played (Mins)";
            // 
            // FireFoxTotalTimePlayedHoursStatsLabel
            // 
            this.FireFoxTotalTimePlayedHoursStatsLabel.AutoSize = true;
            this.FireFoxTotalTimePlayedHoursStatsLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxTotalTimePlayedHoursStatsLabel.Location = new System.Drawing.Point(226, 139);
            this.FireFoxTotalTimePlayedHoursStatsLabel.Name = "FireFoxTotalTimePlayedHoursStatsLabel";
            this.FireFoxTotalTimePlayedHoursStatsLabel.Size = new System.Drawing.Size(103, 13);
            this.FireFoxTotalTimePlayedHoursStatsLabel.TabIndex = 281;
            this.FireFoxTotalTimePlayedHoursStatsLabel.Text = "Time Played (Hours)";
            // 
            // FireFoxTotalTimePlayedDaysStatsLabel
            // 
            this.FireFoxTotalTimePlayedDaysStatsLabel.AutoSize = true;
            this.FireFoxTotalTimePlayedDaysStatsLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxTotalTimePlayedDaysStatsLabel.Location = new System.Drawing.Point(103, 139);
            this.FireFoxTotalTimePlayedDaysStatsLabel.Name = "FireFoxTotalTimePlayedDaysStatsLabel";
            this.FireFoxTotalTimePlayedDaysStatsLabel.Size = new System.Drawing.Size(99, 13);
            this.FireFoxTotalTimePlayedDaysStatsLabel.TabIndex = 280;
            this.FireFoxTotalTimePlayedDaysStatsLabel.Text = "Time Played (Days)";
            // 
            // FireFoxTotalGamesPlayedStatsLabel
            // 
            this.FireFoxTotalGamesPlayedStatsLabel.AutoSize = true;
            this.FireFoxTotalGamesPlayedStatsLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxTotalGamesPlayedStatsLabel.Location = new System.Drawing.Point(355, 96);
            this.FireFoxTotalGamesPlayedStatsLabel.Name = "FireFoxTotalGamesPlayedStatsLabel";
            this.FireFoxTotalGamesPlayedStatsLabel.Size = new System.Drawing.Size(101, 13);
            this.FireFoxTotalGamesPlayedStatsLabel.TabIndex = 279;
            this.FireFoxTotalGamesPlayedStatsLabel.Text = "Total Games Played";
            // 
            // FireFoxTotalElimsStatsLabel
            // 
            this.FireFoxTotalElimsStatsLabel.AutoSize = true;
            this.FireFoxTotalElimsStatsLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxTotalElimsStatsLabel.Location = new System.Drawing.Point(238, 96);
            this.FireFoxTotalElimsStatsLabel.Name = "FireFoxTotalElimsStatsLabel";
            this.FireFoxTotalElimsStatsLabel.Size = new System.Drawing.Size(80, 13);
            this.FireFoxTotalElimsStatsLabel.TabIndex = 278;
            this.FireFoxTotalElimsStatsLabel.Text = "Total Max Elims";
            // 
            // FireFoxTotalCriticalKillsStatsLabel
            // 
            this.FireFoxTotalCriticalKillsStatsLabel.AutoSize = true;
            this.FireFoxTotalCriticalKillsStatsLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxTotalCriticalKillsStatsLabel.Location = new System.Drawing.Point(113, 96);
            this.FireFoxTotalCriticalKillsStatsLabel.Name = "FireFoxTotalCriticalKillsStatsLabel";
            this.FireFoxTotalCriticalKillsStatsLabel.Size = new System.Drawing.Size(86, 13);
            this.FireFoxTotalCriticalKillsStatsLabel.TabIndex = 277;
            this.FireFoxTotalCriticalKillsStatsLabel.Text = "Total Critical Kills";
            // 
            // FireFoxTotalEliteKillsStatsLabel
            // 
            this.FireFoxTotalEliteKillsStatsLabel.AutoSize = true;
            this.FireFoxTotalEliteKillsStatsLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxTotalEliteKillsStatsLabel.Location = new System.Drawing.Point(365, 53);
            this.FireFoxTotalEliteKillsStatsLabel.Name = "FireFoxTotalEliteKillsStatsLabel";
            this.FireFoxTotalEliteKillsStatsLabel.Size = new System.Drawing.Size(74, 13);
            this.FireFoxTotalEliteKillsStatsLabel.TabIndex = 276;
            this.FireFoxTotalEliteKillsStatsLabel.Text = "Total Elite Kills";
            // 
            // FireFoxTotalKillsStatsLabel
            // 
            this.FireFoxTotalKillsStatsLabel.AutoSize = true;
            this.FireFoxTotalKillsStatsLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxTotalKillsStatsLabel.Location = new System.Drawing.Point(252, 53);
            this.FireFoxTotalKillsStatsLabel.Name = "FireFoxTotalKillsStatsLabel";
            this.FireFoxTotalKillsStatsLabel.Size = new System.Drawing.Size(51, 13);
            this.FireFoxTotalKillsStatsLabel.TabIndex = 275;
            this.FireFoxTotalKillsStatsLabel.Text = "Total Kills";
            // 
            // FireFoxTotalRoundsStatsLabel
            // 
            this.FireFoxTotalRoundsStatsLabel.AutoSize = true;
            this.FireFoxTotalRoundsStatsLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxTotalRoundsStatsLabel.Location = new System.Drawing.Point(118, 53);
            this.FireFoxTotalRoundsStatsLabel.Name = "FireFoxTotalRoundsStatsLabel";
            this.FireFoxTotalRoundsStatsLabel.Size = new System.Drawing.Size(70, 13);
            this.FireFoxTotalRoundsStatsLabel.TabIndex = 274;
            this.FireFoxTotalRoundsStatsLabel.Text = "Total Rounds";
            // 
            // FireFoxRandomizeStatsGB
            // 
            this.FireFoxRandomizeStatsGB.Controls.Add(this.FireFoxRandomStatsLow);
            this.FireFoxRandomizeStatsGB.Controls.Add(this.FireFoxRandomStatsMedium);
            this.FireFoxRandomizeStatsGB.Controls.Add(this.FireFoxRandomStatsMax);
            this.FireFoxRandomizeStatsGB.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.FireFoxRandomizeStatsGB.Location = new System.Drawing.Point(9, 143);
            this.FireFoxRandomizeStatsGB.Name = "FireFoxRandomizeStatsGB";
            this.FireFoxRandomizeStatsGB.Size = new System.Drawing.Size(233, 209);
            this.FireFoxRandomizeStatsGB.TabIndex = 19;
            this.FireFoxRandomizeStatsGB.Text = "Randomize Stats Options";
            // 
            // FireFoxRandomStatsLow
            // 
            this.FireFoxRandomStatsLow.Location = new System.Drawing.Point(51, 114);
            this.FireFoxRandomStatsLow.Name = "FireFoxRandomStatsLow";
            this.FireFoxRandomStatsLow.Size = new System.Drawing.Size(129, 23);
            this.FireFoxRandomStatsLow.TabIndex = 3;
            this.FireFoxRandomStatsLow.Text = "Random Low Stats";
            this.FireFoxRandomStatsLow.Click += new System.EventHandler(this.FireFoxRandomStatsLow_Click);
            // 
            // FireFoxRandomStatsMedium
            // 
            this.FireFoxRandomStatsMedium.Location = new System.Drawing.Point(51, 83);
            this.FireFoxRandomStatsMedium.Name = "FireFoxRandomStatsMedium";
            this.FireFoxRandomStatsMedium.Size = new System.Drawing.Size(129, 23);
            this.FireFoxRandomStatsMedium.TabIndex = 2;
            this.FireFoxRandomStatsMedium.Text = "Random Medium Stats";
            this.FireFoxRandomStatsMedium.Click += new System.EventHandler(this.FireFoxRandomStatsMedium_Click);
            // 
            // FireFoxRandomStatsMax
            // 
            this.FireFoxRandomStatsMax.Location = new System.Drawing.Point(52, 52);
            this.FireFoxRandomStatsMax.Name = "FireFoxRandomStatsMax";
            this.FireFoxRandomStatsMax.Size = new System.Drawing.Size(129, 23);
            this.FireFoxRandomStatsMax.TabIndex = 1;
            this.FireFoxRandomStatsMax.Text = "Random Max Stats";
            this.FireFoxRandomStatsMax.Click += new System.EventHandler(this.FireFoxRandomStatsMax_Click);
            // 
            // FireFoxStatsPlayerListGB
            // 
            this.FireFoxStatsPlayerListGB.Controls.Add(this.FireFoxP4StatsRefresh);
            this.FireFoxStatsPlayerListGB.Controls.Add(this.FireFoxP3StatsRefresh);
            this.FireFoxStatsPlayerListGB.Controls.Add(this.FireFoxP2StatsRefresh);
            this.FireFoxStatsPlayerListGB.Controls.Add(this.FireFoxP1StatsRefresh);
            this.FireFoxStatsPlayerListGB.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.FireFoxStatsPlayerListGB.Location = new System.Drawing.Point(9, 3);
            this.FireFoxStatsPlayerListGB.Name = "FireFoxStatsPlayerListGB";
            this.FireFoxStatsPlayerListGB.Size = new System.Drawing.Size(233, 133);
            this.FireFoxStatsPlayerListGB.TabIndex = 18;
            this.FireFoxStatsPlayerListGB.Text = "Player List";
            // 
            // FireFoxP4StatsRefresh
            // 
            this.FireFoxP4StatsRefresh.Location = new System.Drawing.Point(11, 107);
            this.FireFoxP4StatsRefresh.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxP4StatsRefresh.Name = "FireFoxP4StatsRefresh";
            this.FireFoxP4StatsRefresh.Properties.Caption = "Player Four...";
            this.FireFoxP4StatsRefresh.Size = new System.Drawing.Size(95, 19);
            this.FireFoxP4StatsRefresh.TabIndex = 284;
            this.FireFoxP4StatsRefresh.CheckedChanged += new System.EventHandler(this.FireFoxP4StatsRefresh_CheckedChanged);
            // 
            // FireFoxP3StatsRefresh
            // 
            this.FireFoxP3StatsRefresh.Location = new System.Drawing.Point(11, 82);
            this.FireFoxP3StatsRefresh.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxP3StatsRefresh.Name = "FireFoxP3StatsRefresh";
            this.FireFoxP3StatsRefresh.Properties.Caption = "Player Three...";
            this.FireFoxP3StatsRefresh.Size = new System.Drawing.Size(95, 19);
            this.FireFoxP3StatsRefresh.TabIndex = 283;
            this.FireFoxP3StatsRefresh.CheckedChanged += new System.EventHandler(this.FireFoxP3StatsRefresh_CheckedChanged);
            // 
            // FireFoxP2StatsRefresh
            // 
            this.FireFoxP2StatsRefresh.Location = new System.Drawing.Point(11, 57);
            this.FireFoxP2StatsRefresh.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxP2StatsRefresh.Name = "FireFoxP2StatsRefresh";
            this.FireFoxP2StatsRefresh.Properties.Caption = "Player Two...";
            this.FireFoxP2StatsRefresh.Size = new System.Drawing.Size(84, 19);
            this.FireFoxP2StatsRefresh.TabIndex = 282;
            this.FireFoxP2StatsRefresh.CheckedChanged += new System.EventHandler(this.FireFoxP2StatsRefresh_CheckedChanged);
            // 
            // FireFoxP1StatsRefresh
            // 
            this.FireFoxP1StatsRefresh.Location = new System.Drawing.Point(11, 32);
            this.FireFoxP1StatsRefresh.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxP1StatsRefresh.Name = "FireFoxP1StatsRefresh";
            this.FireFoxP1StatsRefresh.Properties.Caption = "Player One...";
            this.FireFoxP1StatsRefresh.Size = new System.Drawing.Size(84, 19);
            this.FireFoxP1StatsRefresh.TabIndex = 281;
            this.FireFoxP1StatsRefresh.CheckedChanged += new System.EventHandler(this.FireFoxP1StatsRefresh_CheckedChanged);
            // 
            // FireFoxWeaponSpawningDocker
            // 
            this.FireFoxWeaponSpawningDocker.Form = this;
            this.FireFoxWeaponSpawningDocker.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.FireFoxWeaponDockerAR,
            this.FireFoxWeaponDockerSMG,
            this.FireFoxWeaponDockeTAC,
            this.FireFoxWeaponDockeLMG,
            this.FireFoxWeaponDockeSnipers,
            this.FireFoxWeaponDockeShotguns,
            this.FireFoxWeaponDockePistols,
            this.FireFoxWeaponDockeLaunchers,
            this.FireFoxWeaponDockeMelee,
            this.FireFoxWeaponDockeSpecial,
            this.FireFoxWeaponDockeDLC});
            this.FireFoxWeaponSpawningDocker.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // FireFoxWeaponDockerAR
            // 
            this.FireFoxWeaponDockerAR.Controls.Add(this.controlContainer2);
            this.FireFoxWeaponDockerAR.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxWeaponDockerAR.FloatSize = new System.Drawing.Size(833, 482);
            this.FireFoxWeaponDockerAR.ID = new System.Guid("3c744cad-1629-45ed-a9be-269694fa4949");
            this.FireFoxWeaponDockerAR.Location = new System.Drawing.Point(3, 25);
            this.FireFoxWeaponDockerAR.Name = "FireFoxWeaponDockerAR";
            this.FireFoxWeaponDockerAR.Options.AllowDockAsTabbedDocument = false;
            this.FireFoxWeaponDockerAR.Options.AllowDockBottom = false;
            this.FireFoxWeaponDockerAR.Options.AllowDockLeft = false;
            this.FireFoxWeaponDockerAR.Options.AllowDockRight = false;
            this.FireFoxWeaponDockerAR.Options.AllowDockTop = false;
            this.FireFoxWeaponDockerAR.Options.ShowAutoHideButton = false;
            this.FireFoxWeaponDockerAR.Options.ShowCloseButton = false;
            this.FireFoxWeaponDockerAR.Options.ShowMaximizeButton = false;
            this.FireFoxWeaponDockerAR.OriginalSize = new System.Drawing.Size(200, 200);
            this.FireFoxWeaponDockerAR.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxWeaponDockerAR.SavedIndex = 0;
            this.FireFoxWeaponDockerAR.SavedParent = this.FireFoxWeaponDockeDLC;
            this.FireFoxWeaponDockerAR.SavedTabbed = true;
            this.FireFoxWeaponDockerAR.Size = new System.Drawing.Size(811, 356);
            this.FireFoxWeaponDockerAR.Text = "Assult Rifles";
            this.FireFoxWeaponDockerAR.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // controlContainer2
            // 
            this.controlContainer2.Controls.Add(this.FireFoxGrozaLabel);
            this.controlContainer2.Controls.Add(this.FireFoxFFAR1Label);
            this.controlContainer2.Controls.Add(this.FireFoxQBZ83Label);
            this.controlContainer2.Controls.Add(this.FireFoxGrozaSpawn);
            this.controlContainer2.Controls.Add(this.FireFoxFFAR1Spawn);
            this.controlContainer2.Controls.Add(this.FireFoxQBZ83Spawn);
            this.controlContainer2.Controls.Add(this.FireFoxKrig6Label);
            this.controlContainer2.Controls.Add(this.FireFoxKraig6Spawn);
            this.controlContainer2.Controls.Add(this.FireFoxAK47Label);
            this.controlContainer2.Controls.Add(this.FireFoxXM4abel);
            this.controlContainer2.Controls.Add(this.FireFoxAK47Spawn);
            this.controlContainer2.Controls.Add(this.FireFoxXM4Spawn);
            this.controlContainer2.Location = new System.Drawing.Point(0, 0);
            this.controlContainer2.Name = "controlContainer2";
            this.controlContainer2.Size = new System.Drawing.Size(811, 356);
            this.controlContainer2.TabIndex = 0;
            // 
            // FireFoxGrozaLabel
            // 
            this.FireFoxGrozaLabel.AutoSize = true;
            this.FireFoxGrozaLabel.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxGrozaLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxGrozaLabel.Location = new System.Drawing.Point(763, 298);
            this.FireFoxGrozaLabel.Name = "FireFoxGrozaLabel";
            this.FireFoxGrozaLabel.Size = new System.Drawing.Size(35, 13);
            this.FireFoxGrozaLabel.TabIndex = 26;
            this.FireFoxGrozaLabel.Text = "Groza";
            // 
            // FireFoxFFAR1Label
            // 
            this.FireFoxFFAR1Label.AutoSize = true;
            this.FireFoxFFAR1Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxFFAR1Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxFFAR1Label.Location = new System.Drawing.Point(488, 298);
            this.FireFoxFFAR1Label.Name = "FireFoxFFAR1Label";
            this.FireFoxFFAR1Label.Size = new System.Drawing.Size(43, 13);
            this.FireFoxFFAR1Label.TabIndex = 25;
            this.FireFoxFFAR1Label.Text = "FFAR 1";
            // 
            // FireFoxQBZ83Label
            // 
            this.FireFoxQBZ83Label.AutoSize = true;
            this.FireFoxQBZ83Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxQBZ83Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxQBZ83Label.Location = new System.Drawing.Point(212, 298);
            this.FireFoxQBZ83Label.Name = "FireFoxQBZ83Label";
            this.FireFoxQBZ83Label.Size = new System.Drawing.Size(44, 13);
            this.FireFoxQBZ83Label.TabIndex = 24;
            this.FireFoxQBZ83Label.Text = "QBZ-83";
            // 
            // FireFoxGrozaSpawn
            // 
            this.FireFoxGrozaSpawn.Location = new System.Drawing.Point(553, 201);
            this.FireFoxGrozaSpawn.Name = "FireFoxGrozaSpawn";
            this.FireFoxGrozaSpawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxGrozaSpawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxGrozaSpawn.TabIndex = 23;
            this.FireFoxGrozaSpawn.TabStop = false;
            this.FireFoxGrozaSpawn.Click += new System.EventHandler(this.FireFoxGrozaSpawn_Click);
            // 
            // FireFoxFFAR1Spawn
            // 
            this.FireFoxFFAR1Spawn.Location = new System.Drawing.Point(284, 201);
            this.FireFoxFFAR1Spawn.Name = "FireFoxFFAR1Spawn";
            this.FireFoxFFAR1Spawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxFFAR1Spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxFFAR1Spawn.TabIndex = 21;
            this.FireFoxFFAR1Spawn.TabStop = false;
            this.FireFoxFFAR1Spawn.Click += new System.EventHandler(this.FireFoxFFAR1Spawn_Click);
            // 
            // FireFoxQBZ83Spawn
            // 
            this.FireFoxQBZ83Spawn.Location = new System.Drawing.Point(9, 201);
            this.FireFoxQBZ83Spawn.Name = "FireFoxQBZ83Spawn";
            this.FireFoxQBZ83Spawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxQBZ83Spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxQBZ83Spawn.TabIndex = 20;
            this.FireFoxQBZ83Spawn.TabStop = false;
            this.FireFoxQBZ83Spawn.Click += new System.EventHandler(this.FireFoxQBZ83Spawn_Click);
            // 
            // FireFoxKrig6Label
            // 
            this.FireFoxKrig6Label.AutoSize = true;
            this.FireFoxKrig6Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxKrig6Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxKrig6Label.Location = new System.Drawing.Point(764, 100);
            this.FireFoxKrig6Label.Name = "FireFoxKrig6Label";
            this.FireFoxKrig6Label.Size = new System.Drawing.Size(34, 13);
            this.FireFoxKrig6Label.TabIndex = 20;
            this.FireFoxKrig6Label.Text = "Krig 6";
            // 
            // FireFoxKraig6Spawn
            // 
            this.FireFoxKraig6Spawn.Location = new System.Drawing.Point(553, 3);
            this.FireFoxKraig6Spawn.Name = "FireFoxKraig6Spawn";
            this.FireFoxKraig6Spawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxKraig6Spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxKraig6Spawn.TabIndex = 20;
            this.FireFoxKraig6Spawn.TabStop = false;
            this.FireFoxKraig6Spawn.Click += new System.EventHandler(this.FireFoxKraig6Spawn_Click);
            // 
            // FireFoxAK47Label
            // 
            this.FireFoxAK47Label.AutoSize = true;
            this.FireFoxAK47Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxAK47Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxAK47Label.Location = new System.Drawing.Point(498, 100);
            this.FireFoxAK47Label.Name = "FireFoxAK47Label";
            this.FireFoxAK47Label.Size = new System.Drawing.Size(33, 13);
            this.FireFoxAK47Label.TabIndex = 21;
            this.FireFoxAK47Label.Text = "AK47";
            // 
            // FireFoxXM4abel
            // 
            this.FireFoxXM4abel.AutoSize = true;
            this.FireFoxXM4abel.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxXM4abel.ForeColor = System.Drawing.Color.White;
            this.FireFoxXM4abel.Location = new System.Drawing.Point(228, 100);
            this.FireFoxXM4abel.Name = "FireFoxXM4abel";
            this.FireFoxXM4abel.Size = new System.Drawing.Size(29, 13);
            this.FireFoxXM4abel.TabIndex = 21;
            this.FireFoxXM4abel.Text = "XM4";
            // 
            // FireFoxAK47Spawn
            // 
            this.FireFoxAK47Spawn.Location = new System.Drawing.Point(284, 3);
            this.FireFoxAK47Spawn.Name = "FireFoxAK47Spawn";
            this.FireFoxAK47Spawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxAK47Spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxAK47Spawn.TabIndex = 20;
            this.FireFoxAK47Spawn.TabStop = false;
            this.FireFoxAK47Spawn.Click += new System.EventHandler(this.FireFoxAK47Spawn_Click);
            // 
            // FireFoxXM4Spawn
            // 
            this.FireFoxXM4Spawn.Location = new System.Drawing.Point(9, 3);
            this.FireFoxXM4Spawn.Name = "FireFoxXM4Spawn";
            this.FireFoxXM4Spawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxXM4Spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxXM4Spawn.TabIndex = 20;
            this.FireFoxXM4Spawn.TabStop = false;
            this.FireFoxXM4Spawn.Click += new System.EventHandler(this.FireFoxXM4Spawn_Click);
            // 
            // FireFoxWeaponDockeDLC
            // 
            this.FireFoxWeaponDockeDLC.Controls.Add(this.controlContainer12);
            this.FireFoxWeaponDockeDLC.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.FireFoxWeaponDockeDLC.FloatSize = new System.Drawing.Size(833, 482);
            this.FireFoxWeaponDockeDLC.ID = new System.Guid("d36d333f-af84-4161-aa27-7cb3f979e9b5");
            this.FireFoxWeaponDockeDLC.Location = new System.Drawing.Point(0, 64);
            this.FireFoxWeaponDockeDLC.Name = "FireFoxWeaponDockeDLC";
            this.FireFoxWeaponDockeDLC.Options.AllowDockAsTabbedDocument = false;
            this.FireFoxWeaponDockeDLC.Options.AllowDockBottom = false;
            this.FireFoxWeaponDockeDLC.Options.AllowDockLeft = false;
            this.FireFoxWeaponDockeDLC.Options.AllowDockRight = false;
            this.FireFoxWeaponDockeDLC.Options.ShowAutoHideButton = false;
            this.FireFoxWeaponDockeDLC.Options.ShowCloseButton = false;
            this.FireFoxWeaponDockeDLC.Options.ShowMaximizeButton = false;
            this.FireFoxWeaponDockeDLC.OriginalSize = new System.Drawing.Size(200, 410);
            this.FireFoxWeaponDockeDLC.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.FireFoxWeaponDockeDLC.SavedIndex = 0;
            this.FireFoxWeaponDockeDLC.Size = new System.Drawing.Size(817, 410);
            this.FireFoxWeaponDockeDLC.Text = "DLC";
            this.FireFoxWeaponDockeDLC.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // controlContainer12
            // 
            this.controlContainer12.Controls.Add(this.FireFoxSwissK31Label);
            this.controlContainer12.Controls.Add(this.FireFoxZRG20MMLabel);
            this.controlContainer12.Controls.Add(this.FireFoxBallisticKnifeLabel);
            this.controlContainer12.Controls.Add(this.FireFoxEtoolLabel);
            this.controlContainer12.Controls.Add(this.FireFoxPPSH41Label);
            this.controlContainer12.Controls.Add(this.FireFoxSwissK31Spawn);
            this.controlContainer12.Controls.Add(this.FireFoxZRG20MMSpawn);
            this.controlContainer12.Controls.Add(this.FireFoxBallisticKnifeSpawn);
            this.controlContainer12.Controls.Add(this.FireFoxEtoolSpawn);
            this.controlContainer12.Controls.Add(this.FireFoxPPSH41Spawn);
            this.controlContainer12.Controls.Add(this.FireFoxMacheteLabel);
            this.controlContainer12.Controls.Add(this.FireFoxCrossbowLabel);
            this.controlContainer12.Controls.Add(this.FireFoxLC10Label);
            this.controlContainer12.Controls.Add(this.FireFoxFARA83Label);
            this.controlContainer12.Controls.Add(this.FireFoxMacheteSpawn);
            this.controlContainer12.Controls.Add(this.FireFoxCrossbowSpawn);
            this.controlContainer12.Controls.Add(this.FireFoxLC10Spawn);
            this.controlContainer12.Controls.Add(this.FireFoxFARA83Spawn);
            this.controlContainer12.Location = new System.Drawing.Point(3, 25);
            this.controlContainer12.Name = "controlContainer12";
            this.controlContainer12.Size = new System.Drawing.Size(811, 381);
            this.controlContainer12.TabIndex = 0;
            // 
            // FireFoxSwissK31Label
            // 
            this.FireFoxSwissK31Label.AutoSize = true;
            this.FireFoxSwissK31Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxSwissK31Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxSwissK31Label.Location = new System.Drawing.Point(733, 337);
            this.FireFoxSwissK31Label.Name = "FireFoxSwissK31Label";
            this.FireFoxSwissK31Label.Size = new System.Drawing.Size(56, 13);
            this.FireFoxSwissK31Label.TabIndex = 54;
            this.FireFoxSwissK31Label.Text = "Swiss K31";
            // 
            // FireFoxZRG20MMLabel
            // 
            this.FireFoxZRG20MMLabel.AutoSize = true;
            this.FireFoxZRG20MMLabel.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxZRG20MMLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxZRG20MMLabel.Location = new System.Drawing.Point(463, 337);
            this.FireFoxZRG20MMLabel.Name = "FireFoxZRG20MMLabel";
            this.FireFoxZRG20MMLabel.Size = new System.Drawing.Size(63, 13);
            this.FireFoxZRG20MMLabel.TabIndex = 53;
            this.FireFoxZRG20MMLabel.Text = "ZRG 20MM";
            // 
            // FireFoxBallisticKnifeLabel
            // 
            this.FireFoxBallisticKnifeLabel.AutoSize = true;
            this.FireFoxBallisticKnifeLabel.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxBallisticKnifeLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxBallisticKnifeLabel.Location = new System.Drawing.Point(187, 338);
            this.FireFoxBallisticKnifeLabel.Name = "FireFoxBallisticKnifeLabel";
            this.FireFoxBallisticKnifeLabel.Size = new System.Drawing.Size(69, 13);
            this.FireFoxBallisticKnifeLabel.TabIndex = 52;
            this.FireFoxBallisticKnifeLabel.Text = "Ballistic Knife";
            // 
            // FireFoxEtoolLabel
            // 
            this.FireFoxEtoolLabel.AutoSize = true;
            this.FireFoxEtoolLabel.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxEtoolLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxEtoolLabel.Location = new System.Drawing.Point(750, 219);
            this.FireFoxEtoolLabel.Name = "FireFoxEtoolLabel";
            this.FireFoxEtoolLabel.Size = new System.Drawing.Size(38, 13);
            this.FireFoxEtoolLabel.TabIndex = 51;
            this.FireFoxEtoolLabel.Text = "E-Tool";
            // 
            // FireFoxPPSH41Label
            // 
            this.FireFoxPPSH41Label.AutoSize = true;
            this.FireFoxPPSH41Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxPPSH41Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxPPSH41Label.Location = new System.Drawing.Point(474, 219);
            this.FireFoxPPSH41Label.Name = "FireFoxPPSH41Label";
            this.FireFoxPPSH41Label.Size = new System.Drawing.Size(51, 13);
            this.FireFoxPPSH41Label.TabIndex = 50;
            this.FireFoxPPSH41Label.Text = "PPSH 41";
            // 
            // FireFoxSwissK31Spawn
            // 
            this.FireFoxSwissK31Spawn.Location = new System.Drawing.Point(541, 240);
            this.FireFoxSwissK31Spawn.Name = "FireFoxSwissK31Spawn";
            this.FireFoxSwissK31Spawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxSwissK31Spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxSwissK31Spawn.TabIndex = 49;
            this.FireFoxSwissK31Spawn.TabStop = false;
            this.FireFoxSwissK31Spawn.Click += new System.EventHandler(this.FireFoxSwissK31Spawn_Click);
            // 
            // FireFoxZRG20MMSpawn
            // 
            this.FireFoxZRG20MMSpawn.Location = new System.Drawing.Point(275, 240);
            this.FireFoxZRG20MMSpawn.Name = "FireFoxZRG20MMSpawn";
            this.FireFoxZRG20MMSpawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxZRG20MMSpawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxZRG20MMSpawn.TabIndex = 48;
            this.FireFoxZRG20MMSpawn.TabStop = false;
            this.FireFoxZRG20MMSpawn.Click += new System.EventHandler(this.FireFoxZRG20MMSpawn_Click);
            // 
            // FireFoxBallisticKnifeSpawn
            // 
            this.FireFoxBallisticKnifeSpawn.Location = new System.Drawing.Point(9, 241);
            this.FireFoxBallisticKnifeSpawn.Name = "FireFoxBallisticKnifeSpawn";
            this.FireFoxBallisticKnifeSpawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxBallisticKnifeSpawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxBallisticKnifeSpawn.TabIndex = 47;
            this.FireFoxBallisticKnifeSpawn.TabStop = false;
            this.FireFoxBallisticKnifeSpawn.Click += new System.EventHandler(this.FireFoxBallisticKnifeSpawn_Click);
            // 
            // FireFoxEtoolSpawn
            // 
            this.FireFoxEtoolSpawn.Location = new System.Drawing.Point(541, 122);
            this.FireFoxEtoolSpawn.Name = "FireFoxEtoolSpawn";
            this.FireFoxEtoolSpawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxEtoolSpawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxEtoolSpawn.TabIndex = 46;
            this.FireFoxEtoolSpawn.TabStop = false;
            this.FireFoxEtoolSpawn.Click += new System.EventHandler(this.FireFoxEtoolSpawn_Click);
            // 
            // FireFoxPPSH41Spawn
            // 
            this.FireFoxPPSH41Spawn.Location = new System.Drawing.Point(275, 122);
            this.FireFoxPPSH41Spawn.Name = "FireFoxPPSH41Spawn";
            this.FireFoxPPSH41Spawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxPPSH41Spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxPPSH41Spawn.TabIndex = 45;
            this.FireFoxPPSH41Spawn.TabStop = false;
            this.FireFoxPPSH41Spawn.Click += new System.EventHandler(this.FireFoxPPSH41Spawn_Click);
            // 
            // FireFoxMacheteLabel
            // 
            this.FireFoxMacheteLabel.AutoSize = true;
            this.FireFoxMacheteLabel.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxMacheteLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxMacheteLabel.Location = new System.Drawing.Point(207, 219);
            this.FireFoxMacheteLabel.Name = "FireFoxMacheteLabel";
            this.FireFoxMacheteLabel.Size = new System.Drawing.Size(49, 13);
            this.FireFoxMacheteLabel.TabIndex = 44;
            this.FireFoxMacheteLabel.Text = "Machete";
            // 
            // FireFoxCrossbowLabel
            // 
            this.FireFoxCrossbowLabel.AutoSize = true;
            this.FireFoxCrossbowLabel.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxCrossbowLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxCrossbowLabel.Location = new System.Drawing.Point(733, 100);
            this.FireFoxCrossbowLabel.Name = "FireFoxCrossbowLabel";
            this.FireFoxCrossbowLabel.Size = new System.Drawing.Size(53, 13);
            this.FireFoxCrossbowLabel.TabIndex = 43;
            this.FireFoxCrossbowLabel.Text = "Crossbow";
            // 
            // FireFoxLC10Label
            // 
            this.FireFoxLC10Label.AutoSize = true;
            this.FireFoxLC10Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxLC10Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxLC10Label.Location = new System.Drawing.Point(487, 100);
            this.FireFoxLC10Label.Name = "FireFoxLC10Label";
            this.FireFoxLC10Label.Size = new System.Drawing.Size(35, 13);
            this.FireFoxLC10Label.TabIndex = 42;
            this.FireFoxLC10Label.Text = "LC 10";
            // 
            // FireFoxFARA83Label
            // 
            this.FireFoxFARA83Label.AutoSize = true;
            this.FireFoxFARA83Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxFARA83Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxFARA83Label.Location = new System.Drawing.Point(206, 100);
            this.FireFoxFARA83Label.Name = "FireFoxFARA83Label";
            this.FireFoxFARA83Label.Size = new System.Drawing.Size(50, 13);
            this.FireFoxFARA83Label.TabIndex = 36;
            this.FireFoxFARA83Label.Text = "FARA 83";
            // 
            // FireFoxMacheteSpawn
            // 
            this.FireFoxMacheteSpawn.Location = new System.Drawing.Point(9, 122);
            this.FireFoxMacheteSpawn.Name = "FireFoxMacheteSpawn";
            this.FireFoxMacheteSpawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxMacheteSpawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxMacheteSpawn.TabIndex = 41;
            this.FireFoxMacheteSpawn.TabStop = false;
            this.FireFoxMacheteSpawn.Click += new System.EventHandler(this.FireFoxMacheteSpawn_Click);
            // 
            // FireFoxCrossbowSpawn
            // 
            this.FireFoxCrossbowSpawn.Location = new System.Drawing.Point(541, 3);
            this.FireFoxCrossbowSpawn.Name = "FireFoxCrossbowSpawn";
            this.FireFoxCrossbowSpawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxCrossbowSpawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxCrossbowSpawn.TabIndex = 39;
            this.FireFoxCrossbowSpawn.TabStop = false;
            this.FireFoxCrossbowSpawn.Click += new System.EventHandler(this.FireFoxCrossbowSpawn_Click);
            // 
            // FireFoxLC10Spawn
            // 
            this.FireFoxLC10Spawn.Location = new System.Drawing.Point(275, 3);
            this.FireFoxLC10Spawn.Name = "FireFoxLC10Spawn";
            this.FireFoxLC10Spawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxLC10Spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxLC10Spawn.TabIndex = 37;
            this.FireFoxLC10Spawn.TabStop = false;
            this.FireFoxLC10Spawn.Click += new System.EventHandler(this.FireFoxLC10Spawn_Click);
            // 
            // FireFoxFARA83Spawn
            // 
            this.FireFoxFARA83Spawn.Location = new System.Drawing.Point(9, 3);
            this.FireFoxFARA83Spawn.Name = "FireFoxFARA83Spawn";
            this.FireFoxFARA83Spawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxFARA83Spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxFARA83Spawn.TabIndex = 36;
            this.FireFoxFARA83Spawn.TabStop = false;
            this.FireFoxFARA83Spawn.Click += new System.EventHandler(this.FireFoxFARA83Spawn_Click);
            // 
            // FireFoxWeaponDockerSMG
            // 
            this.FireFoxWeaponDockerSMG.Controls.Add(this.controlContainer3);
            this.FireFoxWeaponDockerSMG.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxWeaponDockerSMG.FloatSize = new System.Drawing.Size(833, 482);
            this.FireFoxWeaponDockerSMG.ID = new System.Guid("7a18bf62-178d-4e89-ae97-c24cfb2c826b");
            this.FireFoxWeaponDockerSMG.Location = new System.Drawing.Point(3, 25);
            this.FireFoxWeaponDockerSMG.Name = "FireFoxWeaponDockerSMG";
            this.FireFoxWeaponDockerSMG.Options.AllowDockAsTabbedDocument = false;
            this.FireFoxWeaponDockerSMG.Options.AllowDockBottom = false;
            this.FireFoxWeaponDockerSMG.Options.AllowDockLeft = false;
            this.FireFoxWeaponDockerSMG.Options.AllowDockRight = false;
            this.FireFoxWeaponDockerSMG.Options.AllowDockTop = false;
            this.FireFoxWeaponDockerSMG.Options.ShowAutoHideButton = false;
            this.FireFoxWeaponDockerSMG.Options.ShowCloseButton = false;
            this.FireFoxWeaponDockerSMG.Options.ShowMaximizeButton = false;
            this.FireFoxWeaponDockerSMG.OriginalSize = new System.Drawing.Size(200, 200);
            this.FireFoxWeaponDockerSMG.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxWeaponDockerSMG.SavedIndex = 0;
            this.FireFoxWeaponDockerSMG.SavedParent = this.FireFoxWeaponDockeDLC;
            this.FireFoxWeaponDockerSMG.SavedTabbed = true;
            this.FireFoxWeaponDockerSMG.Size = new System.Drawing.Size(811, 356);
            this.FireFoxWeaponDockerSMG.Text = "Sub Machine";
            this.FireFoxWeaponDockerSMG.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // controlContainer3
            // 
            this.controlContainer3.Controls.Add(this.FireFoxMAC10Label);
            this.controlContainer3.Controls.Add(this.FireFoxBullFrogLabel);
            this.controlContainer3.Controls.Add(this.FireFoxKSP45Label);
            this.controlContainer3.Controls.Add(this.FireFoxAK74uLabel);
            this.controlContainer3.Controls.Add(this.FireFoxMilano821Label);
            this.controlContainer3.Controls.Add(this.FireFoxMP5Label);
            this.controlContainer3.Controls.Add(this.FireFoxMAC10Spawn);
            this.controlContainer3.Controls.Add(this.FireFoxBullFrogSpawn);
            this.controlContainer3.Controls.Add(this.FireFoxKSP45Spawn);
            this.controlContainer3.Controls.Add(this.FireFoxAK74uSpawn);
            this.controlContainer3.Controls.Add(this.FireFoxMilano821Spawn);
            this.controlContainer3.Controls.Add(this.FireFoxMP5Spawn);
            this.controlContainer3.Location = new System.Drawing.Point(0, 0);
            this.controlContainer3.Name = "controlContainer3";
            this.controlContainer3.Size = new System.Drawing.Size(811, 356);
            this.controlContainer3.TabIndex = 0;
            // 
            // FireFoxMAC10Label
            // 
            this.FireFoxMAC10Label.AutoSize = true;
            this.FireFoxMAC10Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxMAC10Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxMAC10Label.Location = new System.Drawing.Point(754, 298);
            this.FireFoxMAC10Label.Name = "FireFoxMAC10Label";
            this.FireFoxMAC10Label.Size = new System.Drawing.Size(45, 13);
            this.FireFoxMAC10Label.TabIndex = 40;
            this.FireFoxMAC10Label.Text = "MAC-10";
            // 
            // FireFoxBullFrogLabel
            // 
            this.FireFoxBullFrogLabel.AutoSize = true;
            this.FireFoxBullFrogLabel.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxBullFrogLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxBullFrogLabel.Location = new System.Drawing.Point(487, 298);
            this.FireFoxBullFrogLabel.Name = "FireFoxBullFrogLabel";
            this.FireFoxBullFrogLabel.Size = new System.Drawing.Size(42, 13);
            this.FireFoxBullFrogLabel.TabIndex = 39;
            this.FireFoxBullFrogLabel.Text = "Bullfrog";
            // 
            // FireFoxKSP45Label
            // 
            this.FireFoxKSP45Label.AutoSize = true;
            this.FireFoxKSP45Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxKSP45Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxKSP45Label.Location = new System.Drawing.Point(214, 298);
            this.FireFoxKSP45Label.Name = "FireFoxKSP45Label";
            this.FireFoxKSP45Label.Size = new System.Drawing.Size(43, 13);
            this.FireFoxKSP45Label.TabIndex = 38;
            this.FireFoxKSP45Label.Text = "KSP 45";
            // 
            // FireFoxAK74uLabel
            // 
            this.FireFoxAK74uLabel.AutoSize = true;
            this.FireFoxAK74uLabel.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxAK74uLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxAK74uLabel.Location = new System.Drawing.Point(757, 100);
            this.FireFoxAK74uLabel.Name = "FireFoxAK74uLabel";
            this.FireFoxAK74uLabel.Size = new System.Drawing.Size(42, 13);
            this.FireFoxAK74uLabel.TabIndex = 37;
            this.FireFoxAK74uLabel.Text = "AK-74u";
            // 
            // FireFoxMilano821Label
            // 
            this.FireFoxMilano821Label.AutoSize = true;
            this.FireFoxMilano821Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxMilano821Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxMilano821Label.Location = new System.Drawing.Point(472, 100);
            this.FireFoxMilano821Label.Name = "FireFoxMilano821Label";
            this.FireFoxMilano821Label.Size = new System.Drawing.Size(59, 13);
            this.FireFoxMilano821Label.TabIndex = 28;
            this.FireFoxMilano821Label.Text = "Milano 821";
            // 
            // FireFoxMP5Label
            // 
            this.FireFoxMP5Label.AutoSize = true;
            this.FireFoxMP5Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxMP5Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxMP5Label.Location = new System.Drawing.Point(228, 100);
            this.FireFoxMP5Label.Name = "FireFoxMP5Label";
            this.FireFoxMP5Label.Size = new System.Drawing.Size(29, 13);
            this.FireFoxMP5Label.TabIndex = 36;
            this.FireFoxMP5Label.Text = "MP5";
            // 
            // FireFoxMAC10Spawn
            // 
            this.FireFoxMAC10Spawn.Location = new System.Drawing.Point(553, 201);
            this.FireFoxMAC10Spawn.Name = "FireFoxMAC10Spawn";
            this.FireFoxMAC10Spawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxMAC10Spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxMAC10Spawn.TabIndex = 35;
            this.FireFoxMAC10Spawn.TabStop = false;
            this.FireFoxMAC10Spawn.Click += new System.EventHandler(this.FireFoxMAC10Spawn_Click);
            // 
            // FireFoxBullFrogSpawn
            // 
            this.FireFoxBullFrogSpawn.Location = new System.Drawing.Point(284, 201);
            this.FireFoxBullFrogSpawn.Name = "FireFoxBullFrogSpawn";
            this.FireFoxBullFrogSpawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxBullFrogSpawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxBullFrogSpawn.TabIndex = 33;
            this.FireFoxBullFrogSpawn.TabStop = false;
            this.FireFoxBullFrogSpawn.Click += new System.EventHandler(this.FireFoxBullFrogSpawn_Click);
            // 
            // FireFoxKSP45Spawn
            // 
            this.FireFoxKSP45Spawn.Location = new System.Drawing.Point(9, 201);
            this.FireFoxKSP45Spawn.Name = "FireFoxKSP45Spawn";
            this.FireFoxKSP45Spawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxKSP45Spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxKSP45Spawn.TabIndex = 31;
            this.FireFoxKSP45Spawn.TabStop = false;
            this.FireFoxKSP45Spawn.Click += new System.EventHandler(this.FireFoxKSP45Spawn_Click);
            // 
            // FireFoxAK74uSpawn
            // 
            this.FireFoxAK74uSpawn.Location = new System.Drawing.Point(553, 3);
            this.FireFoxAK74uSpawn.Name = "FireFoxAK74uSpawn";
            this.FireFoxAK74uSpawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxAK74uSpawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxAK74uSpawn.TabIndex = 29;
            this.FireFoxAK74uSpawn.TabStop = false;
            this.FireFoxAK74uSpawn.Click += new System.EventHandler(this.FireFoxAK74uSpawn_Click);
            // 
            // FireFoxMilano821Spawn
            // 
            this.FireFoxMilano821Spawn.Location = new System.Drawing.Point(284, 3);
            this.FireFoxMilano821Spawn.Name = "FireFoxMilano821Spawn";
            this.FireFoxMilano821Spawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxMilano821Spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxMilano821Spawn.TabIndex = 27;
            this.FireFoxMilano821Spawn.TabStop = false;
            this.FireFoxMilano821Spawn.Click += new System.EventHandler(this.FireFoxMilano821Spawn_Click);
            // 
            // FireFoxMP5Spawn
            // 
            this.FireFoxMP5Spawn.Location = new System.Drawing.Point(9, 3);
            this.FireFoxMP5Spawn.Name = "FireFoxMP5Spawn";
            this.FireFoxMP5Spawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxMP5Spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxMP5Spawn.TabIndex = 28;
            this.FireFoxMP5Spawn.TabStop = false;
            this.FireFoxMP5Spawn.Click += new System.EventHandler(this.FireFoxMP5Spawn_Click);
            // 
            // FireFoxWeaponDockeTAC
            // 
            this.FireFoxWeaponDockeTAC.Controls.Add(this.controlContainer4);
            this.FireFoxWeaponDockeTAC.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxWeaponDockeTAC.FloatSize = new System.Drawing.Size(833, 482);
            this.FireFoxWeaponDockeTAC.ID = new System.Guid("de30e5c3-c740-43b6-8299-c5053c19368a");
            this.FireFoxWeaponDockeTAC.Location = new System.Drawing.Point(3, 25);
            this.FireFoxWeaponDockeTAC.Name = "FireFoxWeaponDockeTAC";
            this.FireFoxWeaponDockeTAC.Options.AllowDockAsTabbedDocument = false;
            this.FireFoxWeaponDockeTAC.Options.AllowDockBottom = false;
            this.FireFoxWeaponDockeTAC.Options.AllowDockLeft = false;
            this.FireFoxWeaponDockeTAC.Options.AllowDockRight = false;
            this.FireFoxWeaponDockeTAC.Options.AllowDockTop = false;
            this.FireFoxWeaponDockeTAC.Options.ShowAutoHideButton = false;
            this.FireFoxWeaponDockeTAC.Options.ShowCloseButton = false;
            this.FireFoxWeaponDockeTAC.Options.ShowMaximizeButton = false;
            this.FireFoxWeaponDockeTAC.OriginalSize = new System.Drawing.Size(200, 200);
            this.FireFoxWeaponDockeTAC.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxWeaponDockeTAC.SavedIndex = 0;
            this.FireFoxWeaponDockeTAC.SavedParent = this.FireFoxWeaponDockeDLC;
            this.FireFoxWeaponDockeTAC.SavedTabbed = true;
            this.FireFoxWeaponDockeTAC.Size = new System.Drawing.Size(811, 356);
            this.FireFoxWeaponDockeTAC.Text = "Tactical Rifles";
            this.FireFoxWeaponDockeTAC.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // controlContainer4
            // 
            this.controlContainer4.Controls.Add(this.FireFoxDMR14Label);
            this.controlContainer4.Controls.Add(this.FireFoxAUGLabel);
            this.controlContainer4.Controls.Add(this.FireFoxM16Label);
            this.controlContainer4.Controls.Add(this.FireFoxType63Label);
            this.controlContainer4.Controls.Add(this.FireFoxType63Spawn);
            this.controlContainer4.Controls.Add(this.FireFoxDMR14Spawn);
            this.controlContainer4.Controls.Add(this.FireFoxAUGSpawn);
            this.controlContainer4.Controls.Add(this.FireFoxM16Spawn);
            this.controlContainer4.Location = new System.Drawing.Point(0, 0);
            this.controlContainer4.Name = "controlContainer4";
            this.controlContainer4.Size = new System.Drawing.Size(811, 356);
            this.controlContainer4.TabIndex = 0;
            // 
            // FireFoxDMR14Label
            // 
            this.FireFoxDMR14Label.AutoSize = true;
            this.FireFoxDMR14Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxDMR14Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxDMR14Label.Location = new System.Drawing.Point(597, 279);
            this.FireFoxDMR14Label.Name = "FireFoxDMR14Label";
            this.FireFoxDMR14Label.Size = new System.Drawing.Size(47, 13);
            this.FireFoxDMR14Label.TabIndex = 39;
            this.FireFoxDMR14Label.Text = "DMR 14";
            // 
            // FireFoxAUGLabel
            // 
            this.FireFoxAUGLabel.AutoSize = true;
            this.FireFoxAUGLabel.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxAUGLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxAUGLabel.Location = new System.Drawing.Point(325, 279);
            this.FireFoxAUGLabel.Name = "FireFoxAUGLabel";
            this.FireFoxAUGLabel.Size = new System.Drawing.Size(30, 13);
            this.FireFoxAUGLabel.TabIndex = 38;
            this.FireFoxAUGLabel.Text = "AUG";
            // 
            // FireFoxM16Label
            // 
            this.FireFoxM16Label.AutoSize = true;
            this.FireFoxM16Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxM16Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxM16Label.Location = new System.Drawing.Point(614, 131);
            this.FireFoxM16Label.Name = "FireFoxM16Label";
            this.FireFoxM16Label.Size = new System.Drawing.Size(28, 13);
            this.FireFoxM16Label.TabIndex = 37;
            this.FireFoxM16Label.Text = "M16";
            // 
            // FireFoxType63Label
            // 
            this.FireFoxType63Label.AutoSize = true;
            this.FireFoxType63Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxType63Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxType63Label.Location = new System.Drawing.Point(307, 131);
            this.FireFoxType63Label.Name = "FireFoxType63Label";
            this.FireFoxType63Label.Size = new System.Drawing.Size(46, 13);
            this.FireFoxType63Label.TabIndex = 36;
            this.FireFoxType63Label.Text = "Type 63";
            // 
            // FireFoxType63Spawn
            // 
            this.FireFoxType63Spawn.Location = new System.Drawing.Point(107, 34);
            this.FireFoxType63Spawn.Name = "FireFoxType63Spawn";
            this.FireFoxType63Spawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxType63Spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxType63Spawn.TabIndex = 32;
            this.FireFoxType63Spawn.TabStop = false;
            this.FireFoxType63Spawn.Click += new System.EventHandler(this.FireFoxType63Spawn_Click);
            // 
            // FireFoxDMR14Spawn
            // 
            this.FireFoxDMR14Spawn.Location = new System.Drawing.Point(395, 182);
            this.FireFoxDMR14Spawn.Name = "FireFoxDMR14Spawn";
            this.FireFoxDMR14Spawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxDMR14Spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxDMR14Spawn.TabIndex = 35;
            this.FireFoxDMR14Spawn.TabStop = false;
            this.FireFoxDMR14Spawn.Click += new System.EventHandler(this.FireFoxDMR14Spawn_Click);
            // 
            // FireFoxAUGSpawn
            // 
            this.FireFoxAUGSpawn.Location = new System.Drawing.Point(107, 182);
            this.FireFoxAUGSpawn.Name = "FireFoxAUGSpawn";
            this.FireFoxAUGSpawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxAUGSpawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxAUGSpawn.TabIndex = 34;
            this.FireFoxAUGSpawn.TabStop = false;
            this.FireFoxAUGSpawn.Click += new System.EventHandler(this.FireFoxAUGSpawn_Click);
            // 
            // FireFoxM16Spawn
            // 
            this.FireFoxM16Spawn.Location = new System.Drawing.Point(395, 34);
            this.FireFoxM16Spawn.Name = "FireFoxM16Spawn";
            this.FireFoxM16Spawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxM16Spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxM16Spawn.TabIndex = 32;
            this.FireFoxM16Spawn.TabStop = false;
            this.FireFoxM16Spawn.Click += new System.EventHandler(this.FireFoxM16Spawn_Click);
            // 
            // FireFoxWeaponDockeLMG
            // 
            this.FireFoxWeaponDockeLMG.Controls.Add(this.controlContainer5);
            this.FireFoxWeaponDockeLMG.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxWeaponDockeLMG.FloatSize = new System.Drawing.Size(833, 482);
            this.FireFoxWeaponDockeLMG.ID = new System.Guid("066649d8-5860-4ef7-8cb8-4f5b5c3efaa6");
            this.FireFoxWeaponDockeLMG.Location = new System.Drawing.Point(3, 25);
            this.FireFoxWeaponDockeLMG.Name = "FireFoxWeaponDockeLMG";
            this.FireFoxWeaponDockeLMG.Options.AllowDockAsTabbedDocument = false;
            this.FireFoxWeaponDockeLMG.Options.AllowDockBottom = false;
            this.FireFoxWeaponDockeLMG.Options.AllowDockLeft = false;
            this.FireFoxWeaponDockeLMG.Options.AllowDockRight = false;
            this.FireFoxWeaponDockeLMG.Options.AllowDockTop = false;
            this.FireFoxWeaponDockeLMG.Options.ShowAutoHideButton = false;
            this.FireFoxWeaponDockeLMG.Options.ShowCloseButton = false;
            this.FireFoxWeaponDockeLMG.Options.ShowMaximizeButton = false;
            this.FireFoxWeaponDockeLMG.OriginalSize = new System.Drawing.Size(200, 200);
            this.FireFoxWeaponDockeLMG.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxWeaponDockeLMG.SavedIndex = 0;
            this.FireFoxWeaponDockeLMG.SavedParent = this.FireFoxWeaponDockeDLC;
            this.FireFoxWeaponDockeLMG.SavedTabbed = true;
            this.FireFoxWeaponDockeLMG.Size = new System.Drawing.Size(811, 356);
            this.FireFoxWeaponDockeLMG.Text = "Light Machine";
            this.FireFoxWeaponDockeLMG.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // controlContainer5
            // 
            this.controlContainer5.Controls.Add(this.FireFoxM60Label);
            this.controlContainer5.Controls.Add(this.FireFoxRPDLabel);
            this.controlContainer5.Controls.Add(this.FireFoxStoner63Label);
            this.controlContainer5.Controls.Add(this.FireFoxM60Spawn);
            this.controlContainer5.Controls.Add(this.FireFoxRDPSpawn);
            this.controlContainer5.Controls.Add(this.FireFoxStoner63Spawn);
            this.controlContainer5.Location = new System.Drawing.Point(0, 0);
            this.controlContainer5.Name = "controlContainer5";
            this.controlContainer5.Size = new System.Drawing.Size(811, 356);
            this.controlContainer5.TabIndex = 0;
            // 
            // FireFoxM60Label
            // 
            this.FireFoxM60Label.AutoSize = true;
            this.FireFoxM60Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxM60Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxM60Label.Location = new System.Drawing.Point(772, 201);
            this.FireFoxM60Label.Name = "FireFoxM60Label";
            this.FireFoxM60Label.Size = new System.Drawing.Size(28, 13);
            this.FireFoxM60Label.TabIndex = 45;
            this.FireFoxM60Label.Text = "M60";
            // 
            // FireFoxRPDLabel
            // 
            this.FireFoxRPDLabel.AutoSize = true;
            this.FireFoxRPDLabel.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxRPDLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxRPDLabel.Location = new System.Drawing.Point(500, 201);
            this.FireFoxRPDLabel.Name = "FireFoxRPDLabel";
            this.FireFoxRPDLabel.Size = new System.Drawing.Size(30, 13);
            this.FireFoxRPDLabel.TabIndex = 44;
            this.FireFoxRPDLabel.Text = "RPD";
            // 
            // FireFoxStoner63Label
            // 
            this.FireFoxStoner63Label.AutoSize = true;
            this.FireFoxStoner63Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxStoner63Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxStoner63Label.Location = new System.Drawing.Point(201, 201);
            this.FireFoxStoner63Label.Name = "FireFoxStoner63Label";
            this.FireFoxStoner63Label.Size = new System.Drawing.Size(53, 13);
            this.FireFoxStoner63Label.TabIndex = 43;
            this.FireFoxStoner63Label.Text = "Stoner 63";
            // 
            // FireFoxM60Spawn
            // 
            this.FireFoxM60Spawn.Location = new System.Drawing.Point(553, 104);
            this.FireFoxM60Spawn.Name = "FireFoxM60Spawn";
            this.FireFoxM60Spawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxM60Spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxM60Spawn.TabIndex = 42;
            this.FireFoxM60Spawn.TabStop = false;
            this.FireFoxM60Spawn.Click += new System.EventHandler(this.FireFoxM60Spawn_Click);
            // 
            // FireFoxRDPSpawn
            // 
            this.FireFoxRDPSpawn.Location = new System.Drawing.Point(281, 104);
            this.FireFoxRDPSpawn.Name = "FireFoxRDPSpawn";
            this.FireFoxRDPSpawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxRDPSpawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxRDPSpawn.TabIndex = 40;
            this.FireFoxRDPSpawn.TabStop = false;
            this.FireFoxRDPSpawn.Click += new System.EventHandler(this.FireFoxRDPSpawn_Click);
            // 
            // FireFoxStoner63Spawn
            // 
            this.FireFoxStoner63Spawn.Location = new System.Drawing.Point(9, 104);
            this.FireFoxStoner63Spawn.Name = "FireFoxStoner63Spawn";
            this.FireFoxStoner63Spawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxStoner63Spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxStoner63Spawn.TabIndex = 39;
            this.FireFoxStoner63Spawn.TabStop = false;
            this.FireFoxStoner63Spawn.Click += new System.EventHandler(this.FireFoxStoner63Spawn_Click);
            // 
            // FireFoxWeaponDockeSnipers
            // 
            this.FireFoxWeaponDockeSnipers.Controls.Add(this.controlContainer6);
            this.FireFoxWeaponDockeSnipers.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxWeaponDockeSnipers.FloatSize = new System.Drawing.Size(833, 482);
            this.FireFoxWeaponDockeSnipers.ID = new System.Guid("c3e6aea9-021c-4c54-9c97-1c976ce7bddf");
            this.FireFoxWeaponDockeSnipers.Location = new System.Drawing.Point(3, 25);
            this.FireFoxWeaponDockeSnipers.Name = "FireFoxWeaponDockeSnipers";
            this.FireFoxWeaponDockeSnipers.Options.AllowDockAsTabbedDocument = false;
            this.FireFoxWeaponDockeSnipers.Options.AllowDockBottom = false;
            this.FireFoxWeaponDockeSnipers.Options.AllowDockLeft = false;
            this.FireFoxWeaponDockeSnipers.Options.AllowDockRight = false;
            this.FireFoxWeaponDockeSnipers.Options.AllowDockTop = false;
            this.FireFoxWeaponDockeSnipers.Options.ShowAutoHideButton = false;
            this.FireFoxWeaponDockeSnipers.Options.ShowCloseButton = false;
            this.FireFoxWeaponDockeSnipers.Options.ShowMaximizeButton = false;
            this.FireFoxWeaponDockeSnipers.OriginalSize = new System.Drawing.Size(200, 200);
            this.FireFoxWeaponDockeSnipers.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxWeaponDockeSnipers.SavedIndex = 0;
            this.FireFoxWeaponDockeSnipers.SavedParent = this.FireFoxWeaponDockeDLC;
            this.FireFoxWeaponDockeSnipers.SavedTabbed = true;
            this.FireFoxWeaponDockeSnipers.Size = new System.Drawing.Size(811, 356);
            this.FireFoxWeaponDockeSnipers.Text = "Snipers";
            this.FireFoxWeaponDockeSnipers.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // controlContainer6
            // 
            this.controlContainer6.Controls.Add(this.FireFoxM82Label);
            this.controlContainer6.Controls.Add(this.FireFoxLW3TundraLabel);
            this.controlContainer6.Controls.Add(this.FireFoxPelington703Label);
            this.controlContainer6.Controls.Add(this.FireFoxM82Spawn);
            this.controlContainer6.Controls.Add(this.FireFoxLW3TundraSpawn);
            this.controlContainer6.Controls.Add(this.FireFoxPelington703Spawn);
            this.controlContainer6.Location = new System.Drawing.Point(0, 0);
            this.controlContainer6.Name = "controlContainer6";
            this.controlContainer6.Size = new System.Drawing.Size(811, 356);
            this.controlContainer6.TabIndex = 0;
            // 
            // FireFoxM82Label
            // 
            this.FireFoxM82Label.AutoSize = true;
            this.FireFoxM82Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxM82Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxM82Label.Location = new System.Drawing.Point(772, 201);
            this.FireFoxM82Label.Name = "FireFoxM82Label";
            this.FireFoxM82Label.Size = new System.Drawing.Size(28, 13);
            this.FireFoxM82Label.TabIndex = 51;
            this.FireFoxM82Label.Text = "M82";
            // 
            // FireFoxLW3TundraLabel
            // 
            this.FireFoxLW3TundraLabel.AutoSize = true;
            this.FireFoxLW3TundraLabel.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxLW3TundraLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxLW3TundraLabel.Location = new System.Drawing.Point(461, 201);
            this.FireFoxLW3TundraLabel.Name = "FireFoxLW3TundraLabel";
            this.FireFoxLW3TundraLabel.Size = new System.Drawing.Size(67, 13);
            this.FireFoxLW3TundraLabel.TabIndex = 50;
            this.FireFoxLW3TundraLabel.Text = "LW3-Tundra";
            // 
            // FireFoxPelington703Label
            // 
            this.FireFoxPelington703Label.AutoSize = true;
            this.FireFoxPelington703Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxPelington703Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxPelington703Label.Location = new System.Drawing.Point(183, 201);
            this.FireFoxPelington703Label.Name = "FireFoxPelington703Label";
            this.FireFoxPelington703Label.Size = new System.Drawing.Size(72, 13);
            this.FireFoxPelington703Label.TabIndex = 49;
            this.FireFoxPelington703Label.Text = "Pelington 703";
            // 
            // FireFoxM82Spawn
            // 
            this.FireFoxM82Spawn.Location = new System.Drawing.Point(553, 104);
            this.FireFoxM82Spawn.Name = "FireFoxM82Spawn";
            this.FireFoxM82Spawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxM82Spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxM82Spawn.TabIndex = 48;
            this.FireFoxM82Spawn.TabStop = false;
            this.FireFoxM82Spawn.Click += new System.EventHandler(this.FireFoxM82Spawn_Click);
            // 
            // FireFoxLW3TundraSpawn
            // 
            this.FireFoxLW3TundraSpawn.Location = new System.Drawing.Point(281, 104);
            this.FireFoxLW3TundraSpawn.Name = "FireFoxLW3TundraSpawn";
            this.FireFoxLW3TundraSpawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxLW3TundraSpawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxLW3TundraSpawn.TabIndex = 46;
            this.FireFoxLW3TundraSpawn.TabStop = false;
            this.FireFoxLW3TundraSpawn.Click += new System.EventHandler(this.FireFoxLW3TundraSpawn_Click);
            // 
            // FireFoxPelington703Spawn
            // 
            this.FireFoxPelington703Spawn.Location = new System.Drawing.Point(9, 104);
            this.FireFoxPelington703Spawn.Name = "FireFoxPelington703Spawn";
            this.FireFoxPelington703Spawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxPelington703Spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxPelington703Spawn.TabIndex = 45;
            this.FireFoxPelington703Spawn.TabStop = false;
            this.FireFoxPelington703Spawn.Click += new System.EventHandler(this.FireFoxPelington703Spawn_Click);
            // 
            // FireFoxWeaponDockeShotguns
            // 
            this.FireFoxWeaponDockeShotguns.Controls.Add(this.controlContainer7);
            this.FireFoxWeaponDockeShotguns.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxWeaponDockeShotguns.FloatSize = new System.Drawing.Size(833, 482);
            this.FireFoxWeaponDockeShotguns.ID = new System.Guid("d2943a93-118e-4add-b401-2a9e15159b08");
            this.FireFoxWeaponDockeShotguns.Location = new System.Drawing.Point(3, 25);
            this.FireFoxWeaponDockeShotguns.Name = "FireFoxWeaponDockeShotguns";
            this.FireFoxWeaponDockeShotguns.Options.AllowDockAsTabbedDocument = false;
            this.FireFoxWeaponDockeShotguns.Options.AllowDockBottom = false;
            this.FireFoxWeaponDockeShotguns.Options.AllowDockLeft = false;
            this.FireFoxWeaponDockeShotguns.Options.AllowDockRight = false;
            this.FireFoxWeaponDockeShotguns.Options.AllowDockTop = false;
            this.FireFoxWeaponDockeShotguns.Options.ShowAutoHideButton = false;
            this.FireFoxWeaponDockeShotguns.Options.ShowCloseButton = false;
            this.FireFoxWeaponDockeShotguns.Options.ShowMaximizeButton = false;
            this.FireFoxWeaponDockeShotguns.OriginalSize = new System.Drawing.Size(200, 200);
            this.FireFoxWeaponDockeShotguns.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxWeaponDockeShotguns.SavedIndex = 0;
            this.FireFoxWeaponDockeShotguns.SavedParent = this.FireFoxWeaponDockeDLC;
            this.FireFoxWeaponDockeShotguns.SavedTabbed = true;
            this.FireFoxWeaponDockeShotguns.Size = new System.Drawing.Size(811, 356);
            this.FireFoxWeaponDockeShotguns.Text = "ShotGuns";
            this.FireFoxWeaponDockeShotguns.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // controlContainer7
            // 
            this.controlContainer7.Controls.Add(this.FireFoxStreetsweeperLabel);
            this.controlContainer7.Controls.Add(this.FireFoxGalloSA12Label);
            this.controlContainer7.Controls.Add(this.FireFoxHauer77Label);
            this.controlContainer7.Controls.Add(this.FireFoxStreetsweeperSpawn);
            this.controlContainer7.Controls.Add(this.FireFoxGalloSA12Spawn);
            this.controlContainer7.Controls.Add(this.FireFoxHauer77Spawn);
            this.controlContainer7.Location = new System.Drawing.Point(0, 0);
            this.controlContainer7.Name = "controlContainer7";
            this.controlContainer7.Size = new System.Drawing.Size(811, 356);
            this.controlContainer7.TabIndex = 0;
            // 
            // FireFoxStreetsweeperLabel
            // 
            this.FireFoxStreetsweeperLabel.AutoSize = true;
            this.FireFoxStreetsweeperLabel.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxStreetsweeperLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxStreetsweeperLabel.Location = new System.Drawing.Point(721, 201);
            this.FireFoxStreetsweeperLabel.Name = "FireFoxStreetsweeperLabel";
            this.FireFoxStreetsweeperLabel.Size = new System.Drawing.Size(75, 13);
            this.FireFoxStreetsweeperLabel.TabIndex = 57;
            this.FireFoxStreetsweeperLabel.Text = "Streetsweeper";
            // 
            // FireFoxGalloSA12Label
            // 
            this.FireFoxGalloSA12Label.AutoSize = true;
            this.FireFoxGalloSA12Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxGalloSA12Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxGalloSA12Label.Location = new System.Drawing.Point(469, 201);
            this.FireFoxGalloSA12Label.Name = "FireFoxGalloSA12Label";
            this.FireFoxGalloSA12Label.Size = new System.Drawing.Size(60, 13);
            this.FireFoxGalloSA12Label.TabIndex = 56;
            this.FireFoxGalloSA12Label.Text = "Gallo SA12";
            // 
            // FireFoxHauer77Label
            // 
            this.FireFoxHauer77Label.AutoSize = true;
            this.FireFoxHauer77Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxHauer77Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxHauer77Label.Location = new System.Drawing.Point(204, 201);
            this.FireFoxHauer77Label.Name = "FireFoxHauer77Label";
            this.FireFoxHauer77Label.Size = new System.Drawing.Size(51, 13);
            this.FireFoxHauer77Label.TabIndex = 55;
            this.FireFoxHauer77Label.Text = "Hauer 77";
            // 
            // FireFoxStreetsweeperSpawn
            // 
            this.FireFoxStreetsweeperSpawn.Location = new System.Drawing.Point(553, 104);
            this.FireFoxStreetsweeperSpawn.Name = "FireFoxStreetsweeperSpawn";
            this.FireFoxStreetsweeperSpawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxStreetsweeperSpawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxStreetsweeperSpawn.TabIndex = 54;
            this.FireFoxStreetsweeperSpawn.TabStop = false;
            this.FireFoxStreetsweeperSpawn.Click += new System.EventHandler(this.FireFoxStreetsweeperSpawn_Click);
            // 
            // FireFoxGalloSA12Spawn
            // 
            this.FireFoxGalloSA12Spawn.Location = new System.Drawing.Point(281, 104);
            this.FireFoxGalloSA12Spawn.Name = "FireFoxGalloSA12Spawn";
            this.FireFoxGalloSA12Spawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxGalloSA12Spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxGalloSA12Spawn.TabIndex = 52;
            this.FireFoxGalloSA12Spawn.TabStop = false;
            this.FireFoxGalloSA12Spawn.Click += new System.EventHandler(this.FireFoxGalloSA12Spawn_Click);
            // 
            // FireFoxHauer77Spawn
            // 
            this.FireFoxHauer77Spawn.Location = new System.Drawing.Point(9, 104);
            this.FireFoxHauer77Spawn.Name = "FireFoxHauer77Spawn";
            this.FireFoxHauer77Spawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxHauer77Spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxHauer77Spawn.TabIndex = 51;
            this.FireFoxHauer77Spawn.TabStop = false;
            this.FireFoxHauer77Spawn.Click += new System.EventHandler(this.FireFoxHauer77Spawn_Click);
            // 
            // FireFoxWeaponDockePistols
            // 
            this.FireFoxWeaponDockePistols.Controls.Add(this.controlContainer8);
            this.FireFoxWeaponDockePistols.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxWeaponDockePistols.FloatSize = new System.Drawing.Size(833, 482);
            this.FireFoxWeaponDockePistols.ID = new System.Guid("3b5eb66c-9814-42f3-aa00-7b4c72213fca");
            this.FireFoxWeaponDockePistols.Location = new System.Drawing.Point(3, 25);
            this.FireFoxWeaponDockePistols.Name = "FireFoxWeaponDockePistols";
            this.FireFoxWeaponDockePistols.Options.AllowDockAsTabbedDocument = false;
            this.FireFoxWeaponDockePistols.Options.AllowDockBottom = false;
            this.FireFoxWeaponDockePistols.Options.AllowDockLeft = false;
            this.FireFoxWeaponDockePistols.Options.AllowDockRight = false;
            this.FireFoxWeaponDockePistols.Options.AllowDockTop = false;
            this.FireFoxWeaponDockePistols.Options.ShowAutoHideButton = false;
            this.FireFoxWeaponDockePistols.Options.ShowCloseButton = false;
            this.FireFoxWeaponDockePistols.Options.ShowMaximizeButton = false;
            this.FireFoxWeaponDockePistols.OriginalSize = new System.Drawing.Size(200, 200);
            this.FireFoxWeaponDockePistols.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxWeaponDockePistols.SavedIndex = 0;
            this.FireFoxWeaponDockePistols.SavedParent = this.FireFoxWeaponDockeDLC;
            this.FireFoxWeaponDockePistols.SavedTabbed = true;
            this.FireFoxWeaponDockePistols.Size = new System.Drawing.Size(811, 356);
            this.FireFoxWeaponDockePistols.Text = "Pistols";
            this.FireFoxWeaponDockePistols.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // controlContainer8
            // 
            this.controlContainer8.Controls.Add(this.FireFoxDiamattiLabel);
            this.controlContainer8.Controls.Add(this.FireFoxMagnumLabel);
            this.controlContainer8.Controls.Add(this.FireFoxLabel1911);
            this.controlContainer8.Controls.Add(this.FireFoxDiamattiSpawn);
            this.controlContainer8.Controls.Add(this.FireFoxMagnumSpawn);
            this.controlContainer8.Controls.Add(this.FireFoxSpawn1911);
            this.controlContainer8.Location = new System.Drawing.Point(0, 0);
            this.controlContainer8.Name = "controlContainer8";
            this.controlContainer8.Size = new System.Drawing.Size(811, 356);
            this.controlContainer8.TabIndex = 0;
            // 
            // FireFoxDiamattiLabel
            // 
            this.FireFoxDiamattiLabel.AutoSize = true;
            this.FireFoxDiamattiLabel.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxDiamattiLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxDiamattiLabel.Location = new System.Drawing.Point(753, 201);
            this.FireFoxDiamattiLabel.Name = "FireFoxDiamattiLabel";
            this.FireFoxDiamattiLabel.Size = new System.Drawing.Size(45, 13);
            this.FireFoxDiamattiLabel.TabIndex = 63;
            this.FireFoxDiamattiLabel.Text = "Diamatti";
            // 
            // FireFoxMagnumLabel
            // 
            this.FireFoxMagnumLabel.AutoSize = true;
            this.FireFoxMagnumLabel.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxMagnumLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxMagnumLabel.Location = new System.Drawing.Point(480, 201);
            this.FireFoxMagnumLabel.Name = "FireFoxMagnumLabel";
            this.FireFoxMagnumLabel.Size = new System.Drawing.Size(48, 13);
            this.FireFoxMagnumLabel.TabIndex = 62;
            this.FireFoxMagnumLabel.Text = "Magnum";
            // 
            // FireFoxLabel1911
            // 
            this.FireFoxLabel1911.AutoSize = true;
            this.FireFoxLabel1911.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxLabel1911.ForeColor = System.Drawing.Color.White;
            this.FireFoxLabel1911.Location = new System.Drawing.Point(224, 201);
            this.FireFoxLabel1911.Name = "FireFoxLabel1911";
            this.FireFoxLabel1911.Size = new System.Drawing.Size(31, 13);
            this.FireFoxLabel1911.TabIndex = 61;
            this.FireFoxLabel1911.Text = "1911";
            // 
            // FireFoxDiamattiSpawn
            // 
            this.FireFoxDiamattiSpawn.Location = new System.Drawing.Point(553, 104);
            this.FireFoxDiamattiSpawn.Name = "FireFoxDiamattiSpawn";
            this.FireFoxDiamattiSpawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxDiamattiSpawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxDiamattiSpawn.TabIndex = 60;
            this.FireFoxDiamattiSpawn.TabStop = false;
            this.FireFoxDiamattiSpawn.Click += new System.EventHandler(this.FireFoxDiamattiSpawn_Click);
            // 
            // FireFoxMagnumSpawn
            // 
            this.FireFoxMagnumSpawn.Location = new System.Drawing.Point(281, 104);
            this.FireFoxMagnumSpawn.Name = "FireFoxMagnumSpawn";
            this.FireFoxMagnumSpawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxMagnumSpawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxMagnumSpawn.TabIndex = 58;
            this.FireFoxMagnumSpawn.TabStop = false;
            this.FireFoxMagnumSpawn.Click += new System.EventHandler(this.FireFoxMagnumSpawn_Click);
            // 
            // FireFoxSpawn1911
            // 
            this.FireFoxSpawn1911.Location = new System.Drawing.Point(9, 104);
            this.FireFoxSpawn1911.Name = "FireFoxSpawn1911";
            this.FireFoxSpawn1911.Size = new System.Drawing.Size(249, 113);
            this.FireFoxSpawn1911.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxSpawn1911.TabIndex = 57;
            this.FireFoxSpawn1911.TabStop = false;
            this.FireFoxSpawn1911.Click += new System.EventHandler(this.FireFoxSpawn1911_Click);
            // 
            // FireFoxWeaponDockeLaunchers
            // 
            this.FireFoxWeaponDockeLaunchers.Controls.Add(this.controlContainer9);
            this.FireFoxWeaponDockeLaunchers.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxWeaponDockeLaunchers.FloatSize = new System.Drawing.Size(833, 482);
            this.FireFoxWeaponDockeLaunchers.ID = new System.Guid("144e67bb-13cc-434f-8d66-22374ddfb67b");
            this.FireFoxWeaponDockeLaunchers.Location = new System.Drawing.Point(3, 25);
            this.FireFoxWeaponDockeLaunchers.Name = "FireFoxWeaponDockeLaunchers";
            this.FireFoxWeaponDockeLaunchers.Options.AllowDockAsTabbedDocument = false;
            this.FireFoxWeaponDockeLaunchers.Options.AllowDockBottom = false;
            this.FireFoxWeaponDockeLaunchers.Options.AllowDockLeft = false;
            this.FireFoxWeaponDockeLaunchers.Options.AllowDockRight = false;
            this.FireFoxWeaponDockeLaunchers.Options.AllowDockTop = false;
            this.FireFoxWeaponDockeLaunchers.Options.ShowAutoHideButton = false;
            this.FireFoxWeaponDockeLaunchers.Options.ShowCloseButton = false;
            this.FireFoxWeaponDockeLaunchers.Options.ShowMaximizeButton = false;
            this.FireFoxWeaponDockeLaunchers.OriginalSize = new System.Drawing.Size(200, 200);
            this.FireFoxWeaponDockeLaunchers.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxWeaponDockeLaunchers.SavedIndex = 0;
            this.FireFoxWeaponDockeLaunchers.SavedParent = this.FireFoxWeaponDockeDLC;
            this.FireFoxWeaponDockeLaunchers.SavedTabbed = true;
            this.FireFoxWeaponDockeLaunchers.Size = new System.Drawing.Size(811, 356);
            this.FireFoxWeaponDockeLaunchers.Text = "Launchers";
            this.FireFoxWeaponDockeLaunchers.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // controlContainer9
            // 
            this.controlContainer9.Controls.Add(this.FireFoxRPG7Label);
            this.controlContainer9.Controls.Add(this.FireFoxCigma2Label);
            this.controlContainer9.Controls.Add(this.FireFoxRPG7);
            this.controlContainer9.Controls.Add(this.FireFoxCigma2);
            this.controlContainer9.Location = new System.Drawing.Point(0, 0);
            this.controlContainer9.Name = "controlContainer9";
            this.controlContainer9.Size = new System.Drawing.Size(811, 356);
            this.controlContainer9.TabIndex = 0;
            // 
            // FireFoxRPG7Label
            // 
            this.FireFoxRPG7Label.AutoSize = true;
            this.FireFoxRPG7Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxRPG7Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxRPG7Label.Location = new System.Drawing.Point(621, 201);
            this.FireFoxRPG7Label.Name = "FireFoxRPG7Label";
            this.FireFoxRPG7Label.Size = new System.Drawing.Size(39, 13);
            this.FireFoxRPG7Label.TabIndex = 63;
            this.FireFoxRPG7Label.Text = "RPG-7";
            // 
            // FireFoxCigma2Label
            // 
            this.FireFoxCigma2Label.AutoSize = true;
            this.FireFoxCigma2Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxCigma2Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxCigma2Label.Location = new System.Drawing.Point(319, 201);
            this.FireFoxCigma2Label.Name = "FireFoxCigma2Label";
            this.FireFoxCigma2Label.Size = new System.Drawing.Size(45, 13);
            this.FireFoxCigma2Label.TabIndex = 61;
            this.FireFoxCigma2Label.Text = "Cigma 2";
            // 
            // FireFoxRPG7
            // 
            this.FireFoxRPG7.Location = new System.Drawing.Point(412, 104);
            this.FireFoxRPG7.Name = "FireFoxRPG7";
            this.FireFoxRPG7.Size = new System.Drawing.Size(249, 113);
            this.FireFoxRPG7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxRPG7.TabIndex = 62;
            this.FireFoxRPG7.TabStop = false;
            this.FireFoxRPG7.Click += new System.EventHandler(this.FireFoxRPG7_Click);
            // 
            // FireFoxCigma2
            // 
            this.FireFoxCigma2.Location = new System.Drawing.Point(118, 104);
            this.FireFoxCigma2.Name = "FireFoxCigma2";
            this.FireFoxCigma2.Size = new System.Drawing.Size(249, 113);
            this.FireFoxCigma2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxCigma2.TabIndex = 61;
            this.FireFoxCigma2.TabStop = false;
            this.FireFoxCigma2.Click += new System.EventHandler(this.FireFoxCigma2_Click);
            // 
            // FireFoxWeaponDockeMelee
            // 
            this.FireFoxWeaponDockeMelee.Controls.Add(this.controlContainer10);
            this.FireFoxWeaponDockeMelee.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxWeaponDockeMelee.FloatSize = new System.Drawing.Size(833, 482);
            this.FireFoxWeaponDockeMelee.ID = new System.Guid("7ad61774-aa11-4aca-822c-0aa7b5decf55");
            this.FireFoxWeaponDockeMelee.Location = new System.Drawing.Point(3, 25);
            this.FireFoxWeaponDockeMelee.Name = "FireFoxWeaponDockeMelee";
            this.FireFoxWeaponDockeMelee.Options.AllowDockAsTabbedDocument = false;
            this.FireFoxWeaponDockeMelee.Options.AllowDockBottom = false;
            this.FireFoxWeaponDockeMelee.Options.AllowDockLeft = false;
            this.FireFoxWeaponDockeMelee.Options.AllowDockRight = false;
            this.FireFoxWeaponDockeMelee.Options.AllowDockTop = false;
            this.FireFoxWeaponDockeMelee.Options.ShowAutoHideButton = false;
            this.FireFoxWeaponDockeMelee.Options.ShowCloseButton = false;
            this.FireFoxWeaponDockeMelee.Options.ShowMaximizeButton = false;
            this.FireFoxWeaponDockeMelee.OriginalSize = new System.Drawing.Size(200, 200);
            this.FireFoxWeaponDockeMelee.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxWeaponDockeMelee.SavedIndex = 0;
            this.FireFoxWeaponDockeMelee.SavedParent = this.FireFoxWeaponDockeDLC;
            this.FireFoxWeaponDockeMelee.SavedTabbed = true;
            this.FireFoxWeaponDockeMelee.Size = new System.Drawing.Size(811, 356);
            this.FireFoxWeaponDockeMelee.Text = "Melee";
            this.FireFoxWeaponDockeMelee.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // controlContainer10
            // 
            this.controlContainer10.Controls.Add(this.FireFoxWakizashi);
            this.controlContainer10.Controls.Add(this.FireFoxSledgehammer);
            this.controlContainer10.Controls.Add(this.FireFoxKnifeLabel);
            this.controlContainer10.Controls.Add(this.FireFoxWakizashiSpawn);
            this.controlContainer10.Controls.Add(this.FireFoxSledgehammerSpawn);
            this.controlContainer10.Controls.Add(this.FireFoxKnifeSpawn);
            this.controlContainer10.Location = new System.Drawing.Point(0, 0);
            this.controlContainer10.Name = "controlContainer10";
            this.controlContainer10.Size = new System.Drawing.Size(811, 356);
            this.controlContainer10.TabIndex = 0;
            // 
            // FireFoxWakizashi
            // 
            this.FireFoxWakizashi.AutoSize = true;
            this.FireFoxWakizashi.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxWakizashi.ForeColor = System.Drawing.Color.White;
            this.FireFoxWakizashi.Location = new System.Drawing.Point(745, 201);
            this.FireFoxWakizashi.Name = "FireFoxWakizashi";
            this.FireFoxWakizashi.Size = new System.Drawing.Size(56, 13);
            this.FireFoxWakizashi.TabIndex = 69;
            this.FireFoxWakizashi.Text = "Wakizashi";
            // 
            // FireFoxSledgehammer
            // 
            this.FireFoxSledgehammer.AutoSize = true;
            this.FireFoxSledgehammer.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxSledgehammer.ForeColor = System.Drawing.Color.White;
            this.FireFoxSledgehammer.Location = new System.Drawing.Point(450, 201);
            this.FireFoxSledgehammer.Name = "FireFoxSledgehammer";
            this.FireFoxSledgehammer.Size = new System.Drawing.Size(77, 13);
            this.FireFoxSledgehammer.TabIndex = 68;
            this.FireFoxSledgehammer.Text = "Sledgehammer";
            // 
            // FireFoxKnifeLabel
            // 
            this.FireFoxKnifeLabel.AutoSize = true;
            this.FireFoxKnifeLabel.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxKnifeLabel.ForeColor = System.Drawing.Color.White;
            this.FireFoxKnifeLabel.Location = new System.Drawing.Point(224, 201);
            this.FireFoxKnifeLabel.Name = "FireFoxKnifeLabel";
            this.FireFoxKnifeLabel.Size = new System.Drawing.Size(31, 13);
            this.FireFoxKnifeLabel.TabIndex = 67;
            this.FireFoxKnifeLabel.Text = "Knife";
            // 
            // FireFoxWakizashiSpawn
            // 
            this.FireFoxWakizashiSpawn.Location = new System.Drawing.Point(553, 104);
            this.FireFoxWakizashiSpawn.Name = "FireFoxWakizashiSpawn";
            this.FireFoxWakizashiSpawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxWakizashiSpawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxWakizashiSpawn.TabIndex = 66;
            this.FireFoxWakizashiSpawn.TabStop = false;
            this.FireFoxWakizashiSpawn.Click += new System.EventHandler(this.FireFoxWakizashiSpawn_Click);
            // 
            // FireFoxSledgehammerSpawn
            // 
            this.FireFoxSledgehammerSpawn.Location = new System.Drawing.Point(281, 104);
            this.FireFoxSledgehammerSpawn.Name = "FireFoxSledgehammerSpawn";
            this.FireFoxSledgehammerSpawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxSledgehammerSpawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxSledgehammerSpawn.TabIndex = 64;
            this.FireFoxSledgehammerSpawn.TabStop = false;
            this.FireFoxSledgehammerSpawn.Click += new System.EventHandler(this.FireFoxSledgehammerSpawn_Click);
            // 
            // FireFoxKnifeSpawn
            // 
            this.FireFoxKnifeSpawn.Location = new System.Drawing.Point(9, 104);
            this.FireFoxKnifeSpawn.Name = "FireFoxKnifeSpawn";
            this.FireFoxKnifeSpawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxKnifeSpawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxKnifeSpawn.TabIndex = 63;
            this.FireFoxKnifeSpawn.TabStop = false;
            this.FireFoxKnifeSpawn.Click += new System.EventHandler(this.FireFoxKnifeSpawn_Click);
            // 
            // FireFoxWeaponDockeSpecial
            // 
            this.FireFoxWeaponDockeSpecial.Controls.Add(this.controlContainer11);
            this.FireFoxWeaponDockeSpecial.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxWeaponDockeSpecial.FloatSize = new System.Drawing.Size(833, 482);
            this.FireFoxWeaponDockeSpecial.ID = new System.Guid("7ff83060-52ae-463f-9efd-b2499b69edb7");
            this.FireFoxWeaponDockeSpecial.Location = new System.Drawing.Point(3, 25);
            this.FireFoxWeaponDockeSpecial.Name = "FireFoxWeaponDockeSpecial";
            this.FireFoxWeaponDockeSpecial.Options.AllowDockAsTabbedDocument = false;
            this.FireFoxWeaponDockeSpecial.Options.AllowDockBottom = false;
            this.FireFoxWeaponDockeSpecial.Options.AllowDockLeft = false;
            this.FireFoxWeaponDockeSpecial.Options.AllowDockRight = false;
            this.FireFoxWeaponDockeSpecial.Options.AllowDockTop = false;
            this.FireFoxWeaponDockeSpecial.Options.ShowAutoHideButton = false;
            this.FireFoxWeaponDockeSpecial.Options.ShowCloseButton = false;
            this.FireFoxWeaponDockeSpecial.Options.ShowMaximizeButton = false;
            this.FireFoxWeaponDockeSpecial.OriginalSize = new System.Drawing.Size(200, 200);
            this.FireFoxWeaponDockeSpecial.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.FireFoxWeaponDockeSpecial.SavedIndex = 0;
            this.FireFoxWeaponDockeSpecial.SavedParent = this.FireFoxWeaponDockeDLC;
            this.FireFoxWeaponDockeSpecial.SavedTabbed = true;
            this.FireFoxWeaponDockeSpecial.Size = new System.Drawing.Size(811, 356);
            this.FireFoxWeaponDockeSpecial.Text = "Special";
            this.FireFoxWeaponDockeSpecial.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // controlContainer11
            // 
            this.controlContainer11.Controls.Add(this.FireFoxM79Label);
            this.controlContainer11.Controls.Add(this.FireFoxM79Spawn);
            this.controlContainer11.Location = new System.Drawing.Point(0, 0);
            this.controlContainer11.Name = "controlContainer11";
            this.controlContainer11.Size = new System.Drawing.Size(811, 356);
            this.controlContainer11.TabIndex = 0;
            // 
            // FireFoxM79Label
            // 
            this.FireFoxM79Label.AutoSize = true;
            this.FireFoxM79Label.BackColor = System.Drawing.Color.Transparent;
            this.FireFoxM79Label.ForeColor = System.Drawing.Color.White;
            this.FireFoxM79Label.Location = new System.Drawing.Point(500, 192);
            this.FireFoxM79Label.Name = "FireFoxM79Label";
            this.FireFoxM79Label.Size = new System.Drawing.Size(28, 13);
            this.FireFoxM79Label.TabIndex = 65;
            this.FireFoxM79Label.Text = "M79";
            // 
            // FireFoxM79Spawn
            // 
            this.FireFoxM79Spawn.Location = new System.Drawing.Point(281, 95);
            this.FireFoxM79Spawn.Name = "FireFoxM79Spawn";
            this.FireFoxM79Spawn.Size = new System.Drawing.Size(249, 113);
            this.FireFoxM79Spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireFoxM79Spawn.TabIndex = 65;
            this.FireFoxM79Spawn.TabStop = false;
            this.FireFoxM79Spawn.Click += new System.EventHandler(this.FireFoxM79Spawn_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            // 
            // LoginAlerts
            // 
            this.LoginAlerts.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideHorizontal;
            this.LoginAlerts.ShowPinButton = false;
            // 
            // FireFoxDataDocker
            // 
            this.FireFoxDataDocker.Form = this;
            this.FireFoxDataDocker.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.FireFoxPanelContainerData});
            this.FireFoxDataDocker.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // FireFoxPanelContainerData
            // 
            this.FireFoxPanelContainerData.Controls.Add(this.controlContainer18);
            this.FireFoxPanelContainerData.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.FireFoxPanelContainerData.FloatSize = new System.Drawing.Size(833, 482);
            this.FireFoxPanelContainerData.ID = new System.Guid("89998632-7af1-487a-8754-388a97e8fdf2");
            this.FireFoxPanelContainerData.Location = new System.Drawing.Point(0, 64);
            this.FireFoxPanelContainerData.Name = "FireFoxPanelContainerData";
            this.FireFoxPanelContainerData.Options.AllowDockAsTabbedDocument = false;
            this.FireFoxPanelContainerData.Options.AllowDockBottom = false;
            this.FireFoxPanelContainerData.Options.AllowDockLeft = false;
            this.FireFoxPanelContainerData.Options.AllowDockRight = false;
            this.FireFoxPanelContainerData.Options.AllowDockTop = false;
            this.FireFoxPanelContainerData.Options.ShowAutoHideButton = false;
            this.FireFoxPanelContainerData.Options.ShowCloseButton = false;
            this.FireFoxPanelContainerData.OriginalSize = new System.Drawing.Size(817, 200);
            this.FireFoxPanelContainerData.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.FireFoxPanelContainerData.SavedIndex = 0;
            this.FireFoxPanelContainerData.Size = new System.Drawing.Size(817, 410);
            this.FireFoxPanelContainerData.Text = "Data";
            this.FireFoxPanelContainerData.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // controlContainer18
            // 
            this.controlContainer18.Controls.Add(this.FireFoxDataSpreadSheet);
            this.controlContainer18.Location = new System.Drawing.Point(3, 25);
            this.controlContainer18.Name = "controlContainer18";
            this.controlContainer18.Size = new System.Drawing.Size(810, 382);
            this.controlContainer18.TabIndex = 0;
            // 
            // FireFoxDataSpreadSheet
            // 
            this.FireFoxDataSpreadSheet.Location = new System.Drawing.Point(3, 0);
            this.FireFoxDataSpreadSheet.MenuManager = this.tabFormDefaultManager1;
            this.FireFoxDataSpreadSheet.Name = "FireFoxDataSpreadSheet";
            this.FireFoxDataSpreadSheet.Size = new System.Drawing.Size(804, 381);
            this.FireFoxDataSpreadSheet.TabIndex = 26;
            this.FireFoxDataSpreadSheet.Text = "spreadsheetControl1";
            // 
            // OtherAlerts
            // 
            this.OtherAlerts.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopRight;
            this.OtherAlerts.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideVertical;
            this.OtherAlerts.ShowPinButton = false;
            // 
            // stepProgressBarItem1
            // 
            this.stepProgressBarItem1.ContentBlock2.Caption = "Item1";
            this.stepProgressBarItem1.Name = "stepProgressBarItem1";
            // 
            // stepProgressBarItem2
            // 
            this.stepProgressBarItem2.ContentBlock2.Caption = "Item2";
            this.stepProgressBarItem2.Name = "stepProgressBarItem2";
            // 
            // stepProgressBarItem3
            // 
            this.stepProgressBarItem3.ContentBlock2.Caption = "Item3";
            this.stepProgressBarItem3.Name = "stepProgressBarItem3";
            // 
            // stepProgressBarItem4
            // 
            this.stepProgressBarItem4.ContentBlock2.Caption = "Item4";
            this.stepProgressBarItem4.Name = "stepProgressBarItem4";
            // 
            // stepProgressBarItem5
            // 
            this.stepProgressBarItem5.ContentBlock2.Caption = "Item5";
            this.stepProgressBarItem5.Name = "stepProgressBarItem5";
            // 
            // stepProgressBarItem6
            // 
            this.stepProgressBarItem6.ContentBlock2.Caption = "Item6";
            this.stepProgressBarItem6.Name = "stepProgressBarItem6";
            // 
            // stepProgressBarItem7
            // 
            this.stepProgressBarItem7.ContentBlock2.Caption = "Item7";
            this.stepProgressBarItem7.Name = "stepProgressBarItem7";
            // 
            // stepProgressBarItem8
            // 
            this.stepProgressBarItem8.ContentBlock2.Caption = "Item8";
            this.stepProgressBarItem8.Name = "stepProgressBarItem8";
            // 
            // stepProgressBarItem9
            // 
            this.stepProgressBarItem9.ContentBlock2.Caption = "Item9";
            this.stepProgressBarItem9.Name = "stepProgressBarItem9";
            // 
            // stepProgressBarItem10
            // 
            this.stepProgressBarItem10.ContentBlock2.Caption = "Item10";
            this.stepProgressBarItem10.Name = "stepProgressBarItem10";
            // 
            // stepProgressBarItem11
            // 
            this.stepProgressBarItem11.ContentBlock2.Caption = "Item11";
            this.stepProgressBarItem11.Name = "stepProgressBarItem11";
            // 
            // stepProgressBarItem12
            // 
            this.stepProgressBarItem12.ContentBlock2.Caption = "Item12";
            this.stepProgressBarItem12.Name = "stepProgressBarItem12";
            // 
            // stepProgressBarItem13
            // 
            this.stepProgressBarItem13.ContentBlock2.Caption = "Item13";
            this.stepProgressBarItem13.Name = "stepProgressBarItem13";
            // 
            // Firefox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 474);
            this.Controls.Add(this.FireFoxTabPageLoginMain);
            this.Controls.Add(this.panelContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.FireFoxTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Firefox.IconOptions.SvgImage")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Firefox";
            this.TabFormControl = this.FireFoxTabControl;
            this.Text = "FireFox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Firefox_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Firefox_FormClosed);
            this.Load += new System.EventHandler(this.Firefox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTabControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit4)).EndInit();
            this.FireFoxTabPageLogin.ResumeLayout(false);
            this.FireFoxTabPageLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxEnableQuickOptions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxAutoConnect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxDisableWhenOut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLoginPageSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPageKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPageUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxCleanProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPagePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxAllCGB)).EndInit();
            this.FireFoxAllCGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxUsePAPWeapons.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxPLGB)).EndInit();
            this.FireFoxPLGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxPLUpdate)).EndInit();
            this.FireFoxClientsCMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxMainDocker)).EndInit();
            this.panelContainer1.ResumeLayout(false);
            this.FireFoxDockerClients.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            this.FireFoxDockerTeleport.ResumeLayout(false);
            this.controlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxCustomXYZSpawn)).EndInit();
            this.FireFoxCustomXYZSpawn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTPValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxXYZSpawnMinus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxXYZSpawnPlus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxCustomSpawnPointsMapSpecific)).EndInit();
            this.FireFoxCustomSpawnPointsMapSpecific.ResumeLayout(false);
            this.FireFoxCustomSpawnPointsMapSpecific.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTeleportFireBaseCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTeleportDIECombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxSavedSpawnPoints)).EndInit();
            this.FireFoxSavedSpawnPoints.ResumeLayout(false);
            this.FireFoxSavedSpawnPoints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxCustomSpawnsChooseDIE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxCustomSpawnsChooseFireBase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxCustomSpawnName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxCustomSpawnDIE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxCustomSpawnFireBase.Properties)).EndInit();
            this.FireFoxDockerLobby.ResumeLayout(false);
            this.controlContainer13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxOtherOptionsMain)).EndInit();
            this.FireFoxOtherOptionsMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLevelXPGB)).EndInit();
            this.FireFoxLevelXPGB.ResumeLayout(false);
            this.FireFoxLevelXPGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLevelXPValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLevelXPSetTrackBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLevelXPSetTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxPlayerXPGB)).EndInit();
            this.FireFoxPlayerXPGB.ResumeLayout(false);
            this.FireFoxPlayerXPGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxPlayerXPValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxPlayerXPSetTrackBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxPlayerXPSetTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxCrystalsGB)).EndInit();
            this.FireFoxCrystalsGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLobbyOptionsSpeedSettingsGB)).EndInit();
            this.FireFoxLobbyOptionsSpeedSettingsGB.ResumeLayout(false);
            this.FireFoxLobbyOptionsSpeedSettingsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLobbyOptionsSpeedValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLobbyOptionsSpeedTrackController.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLobbyOptionsSpeedTrackController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLobbyOptionsJumpHeightValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLobbyOptionsJumpHeightTrackController.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLobbyOptionsJumpHeightTrackController)).EndInit();
            this.FireFoxDockerDA.ResumeLayout(false);
            this.controlContainer15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxMainTabContainer)).EndInit();
            this.FireFoxMainTabContainer.ResumeLayout(false);
            this.FireFoxDATabP1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxInformationP1)).EndInit();
            this.FireFoxInformationP1.ResumeLayout(false);
            this.FireFoxInformationP1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTimedSpawnValueP1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxWeaponSwitchSpawnBoxPlayerOne)).EndInit();
            this.FireFoxDATabP2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxInformationP2)).EndInit();
            this.FireFoxInformationP2.ResumeLayout(false);
            this.FireFoxInformationP2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTimedSpawnValueP2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxWeaponSwitchSpawnBoxPlayerTwo)).EndInit();
            this.FireFoxDATabP3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxInformationP3)).EndInit();
            this.FireFoxInformationP3.ResumeLayout(false);
            this.FireFoxInformationP3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTimedSpawnValueP3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxWeaponSwitchSpawnBoxPlayerThree)).EndInit();
            this.FireFoxDATabP4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxInformationP4)).EndInit();
            this.FireFoxInformationP4.ResumeLayout(false);
            this.FireFoxInformationP4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTimedSpawnValueP4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxWeaponSwitchSpawnBoxPlayerFour)).EndInit();
            this.FireFoxDockerReticles.ResumeLayout(false);
            this.controlContainer16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxReticlesMainTabController)).EndInit();
            this.FireFoxReticlesMainTabController.ResumeLayout(false);
            this.FireFoxReticlesTabP1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxInformationReticlesP1)).EndInit();
            this.FireFoxInformationReticlesP1.ResumeLayout(false);
            this.FireFoxInformationReticlesP1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTimedSpawnValueReticlesP1.Properties)).EndInit();
            this.FireFoxReticlesTabP2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTimedSpawnValueReticlesP2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxInformationReticlesP2)).EndInit();
            this.FireFoxInformationReticlesP2.ResumeLayout(false);
            this.FireFoxInformationReticlesP2.PerformLayout();
            this.FireFoxReticlesTabP3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTimedSpawnValueReticlesP3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxInformationReticlesP3)).EndInit();
            this.FireFoxInformationReticlesP3.ResumeLayout(false);
            this.FireFoxInformationReticlesP3.PerformLayout();
            this.FireFoxReticlesTabP4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTimedSpawnValueReticlesP4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxInformationReticlesP4)).EndInit();
            this.FireFoxInformationReticlesP4.ResumeLayout(false);
            this.FireFoxInformationReticlesP4.PerformLayout();
            this.FireFoxDockerStats.ResumeLayout(false);
            this.controlContainer17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxStatsProgressGB)).EndInit();
            this.FireFoxStatsProgressGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FirFoxStatsOptionGroupBox)).EndInit();
            this.FirFoxStatsOptionGroupBox.ResumeLayout(false);
            this.FirFoxStatsOptionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTotalTimePlayedMinsInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTotalTimePlayedHoursInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTotalTimePlayedDaysInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTotalGamesPlayedInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTotalElimsInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTotalCriticalKillsInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTotalEliteKillsInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTotalKillsInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxTotalRoundsInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxRandomizeStatsGB)).EndInit();
            this.FireFoxRandomizeStatsGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxStatsPlayerListGB)).EndInit();
            this.FireFoxStatsPlayerListGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxP4StatsRefresh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxP3StatsRefresh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxP2StatsRefresh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxP1StatsRefresh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxWeaponSpawningDocker)).EndInit();
            this.FireFoxWeaponDockerAR.ResumeLayout(false);
            this.controlContainer2.ResumeLayout(false);
            this.controlContainer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxGrozaSpawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxFFAR1Spawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxQBZ83Spawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxKraig6Spawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxAK47Spawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxXM4Spawn)).EndInit();
            this.FireFoxWeaponDockeDLC.ResumeLayout(false);
            this.controlContainer12.ResumeLayout(false);
            this.controlContainer12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxSwissK31Spawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxZRG20MMSpawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxBallisticKnifeSpawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxEtoolSpawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxPPSH41Spawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxMacheteSpawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxCrossbowSpawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLC10Spawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxFARA83Spawn)).EndInit();
            this.FireFoxWeaponDockerSMG.ResumeLayout(false);
            this.controlContainer3.ResumeLayout(false);
            this.controlContainer3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxMAC10Spawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxBullFrogSpawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxKSP45Spawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxAK74uSpawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxMilano821Spawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxMP5Spawn)).EndInit();
            this.FireFoxWeaponDockeTAC.ResumeLayout(false);
            this.controlContainer4.ResumeLayout(false);
            this.controlContainer4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxType63Spawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxDMR14Spawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxAUGSpawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxM16Spawn)).EndInit();
            this.FireFoxWeaponDockeLMG.ResumeLayout(false);
            this.controlContainer5.ResumeLayout(false);
            this.controlContainer5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxM60Spawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxRDPSpawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxStoner63Spawn)).EndInit();
            this.FireFoxWeaponDockeSnipers.ResumeLayout(false);
            this.controlContainer6.ResumeLayout(false);
            this.controlContainer6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxM82Spawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxLW3TundraSpawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxPelington703Spawn)).EndInit();
            this.FireFoxWeaponDockeShotguns.ResumeLayout(false);
            this.controlContainer7.ResumeLayout(false);
            this.controlContainer7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxStreetsweeperSpawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxGalloSA12Spawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxHauer77Spawn)).EndInit();
            this.FireFoxWeaponDockePistols.ResumeLayout(false);
            this.controlContainer8.ResumeLayout(false);
            this.controlContainer8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxDiamattiSpawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxMagnumSpawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxSpawn1911)).EndInit();
            this.FireFoxWeaponDockeLaunchers.ResumeLayout(false);
            this.controlContainer9.ResumeLayout(false);
            this.controlContainer9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxRPG7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxCigma2)).EndInit();
            this.FireFoxWeaponDockeMelee.ResumeLayout(false);
            this.controlContainer10.ResumeLayout(false);
            this.controlContainer10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxWakizashiSpawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxSledgehammerSpawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxKnifeSpawn)).EndInit();
            this.FireFoxWeaponDockeSpecial.ResumeLayout(false);
            this.controlContainer11.ResumeLayout(false);
            this.controlContainer11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxM79Spawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireFoxDataDocker)).EndInit();
            this.FireFoxPanelContainerData.ResumeLayout(false);
            this.controlContainer18.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.TabFormContentContainer FireFoxTabPageLogin;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.TabFormContentContainer FireFoxTabPageLoginMain;
        public DevExpress.XtraBars.TabFormControl FireFoxTabControl;
        public DevExpress.XtraBars.TabFormPage FireFoxLogin;
        public DevExpress.XtraBars.TabFormPage FireFoxMain;
        private DevExpress.XtraBars.TabFormDefaultManager tabFormDefaultManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        public DevExpress.XtraEditors.SimpleButton FireFoxCleanButton;
        public DevExpress.XtraEditors.ListBoxControl FireFoxCleanProgress;
        public DevExpress.XtraEditors.SimpleButton LoginButton;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private NSContextMenu FireFoxClientsCMS;
        private System.Windows.Forms.ToolStripMenuItem godModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infraredVisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem rapidFireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem disablePlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add1000PointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add10000PointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add100000PointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add1000000PointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add10000000PointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add100000000PointsToolStripMenuItem;
        private DevExpress.XtraEditors.GroupControl FireFoxPLGB;
        private DevExpress.XtraEditors.GroupControl FireFoxAllCGB;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        public DevExpress.XtraBars.Docking.DockPanel FireFoxDockerClients;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;
        public DevExpress.XtraBars.Docking.DockPanel FireFoxDockerTeleport;
        public DevExpress.XtraBars.TabFormPage FireFoxWeaponPage;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer2;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer3;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer4;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer5;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer6;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer7;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer8;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer9;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer10;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer11;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer12;
        public DevExpress.XtraBars.Docking.DockPanel FireFoxWeaponDockerAR;
        public DevExpress.XtraBars.Docking.DockPanel FireFoxWeaponDockerSMG;
        public DevExpress.XtraBars.Docking.DockPanel FireFoxWeaponDockeTAC;
        public DevExpress.XtraBars.Docking.DockPanel FireFoxWeaponDockeLMG;
        public DevExpress.XtraBars.Docking.DockPanel FireFoxWeaponDockeSnipers;
        public DevExpress.XtraBars.Docking.DockPanel FireFoxWeaponDockeShotguns;
        public DevExpress.XtraBars.Docking.DockPanel FireFoxWeaponDockePistols;
        public DevExpress.XtraBars.Docking.DockPanel FireFoxWeaponDockeLaunchers;
        public DevExpress.XtraBars.Docking.DockPanel FireFoxWeaponDockeMelee;
        public DevExpress.XtraBars.Docking.DockPanel FireFoxWeaponDockeSpecial;
        public DevExpress.XtraBars.Docking.DockPanel FireFoxWeaponDockeDLC;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer13;
        public DevExpress.XtraBars.Docking.DockPanel FireFoxDockerLobby;
        public DevExpress.XtraBars.Docking.DockPanel FireFoxDockerReticles;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer16;
        public DevExpress.XtraBars.Docking.DockPanel FireFoxDockerDA;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer15;
        private DevExpress.XtraTab.XtraTabControl FireFoxReticlesMainTabController;
        private DevExpress.XtraTab.XtraTabControl FireFoxMainTabContainer;
        public DevExpress.XtraEditors.SimpleButton FireFoxConnect;
        public DevExpress.XtraEditors.ListBoxControl FireFoxPLUpdate;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        public DevExpress.XtraBars.Docking.DockManager FireFoxMainDocker;
        public DevExpress.XtraBars.Docking.DockManager FireFoxWeaponSpawningDocker;
        private System.Windows.Forms.ToolStripMenuItem FireFoxCMSWeapons;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnAssult;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnXM4;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnAK47;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnKraig6;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnQBZ83;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnGroza;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnFARA1;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnSMGs;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnMP5;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnMilano821;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnAK74u;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnKSP45;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnBullfrog;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnMAC10;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnTACs;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnType63;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnM16;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnAUG;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnDMR14;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnLMGs;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnStoner63;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnM60;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnRPD;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnSnipers;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnPellington703;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnLW3Tundra;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnM82;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnShotguns;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnHauer;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnGalloSA12;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnStreetSweeper;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnPistols;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawn1911;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnMagnum;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnDiamatti;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem39;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnRPG7;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnCigma2;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnMelee;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnKnife;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnSledgehammer;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnWakizashi;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnSpecial;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnM79;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnDLC;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnFARA83;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnLC10;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnMachete;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnCrossbow;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnPPSH41;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnEtool;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnBallisticKnife;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnZRG20MM;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnSwissK31;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnCARV2;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnWonderWeapons;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnDiscordianDisruptor;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnDIEShockwave;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnDIENova;
        private System.Windows.Forms.ToolStripMenuItem DIEelectro;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnDIECryo;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnDIEThermo;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnGunShip;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnCruiseMissle;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnChopperGunner;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnTomahawk;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnMonkeyBomb;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnElSlasher;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnSerketsKiss;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnFieldUpgrades;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnFrenziedGuard;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnFrostBlast;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnEnerygyMine;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnAetherShroud;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnHealingAura;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnRingOfFire;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnMisc;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnEssenceTrap;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnClaymore;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnCoal;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnMolotov;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnShockCharge;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnTrophySystem;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnFlashbang;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnThermite;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnSnowBall;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnJammer;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnSmokeGrenade;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnDecoy;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnDroneSquad;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnStunGrenade;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem95;
        private System.Windows.Forms.ToolStripMenuItem FireFoxWeaponSpawnZombiesHead;
        public DevExpress.XtraTab.XtraTabPage FireFoxReticlesTabP1;
        public DevExpress.XtraTab.XtraTabPage FireFoxReticlesTabP2;
        public DevExpress.XtraTab.XtraTabPage FireFoxReticlesTabP3;
        public DevExpress.XtraTab.XtraTabPage FireFoxReticlesTabP4;
        public DevExpress.XtraTab.XtraTabPage FireFoxDATabP1;
        public DevExpress.XtraTab.XtraTabPage FireFoxDATabP2;
        public DevExpress.XtraTab.XtraTabPage FireFoxDATabP3;
        public DevExpress.XtraTab.XtraTabPage FireFoxDATabP4;
        public DevExpress.XtraEditors.TextEdit LoginPagePassword;
        public DevExpress.XtraEditors.TextEdit LoginPageUsername;
        private System.Windows.Forms.Label FireFoxGrozaLabel;
        private System.Windows.Forms.Label FireFoxFFAR1Label;
        private System.Windows.Forms.Label FireFoxQBZ83Label;
        private System.Windows.Forms.Label FireFoxKrig6Label;
        private System.Windows.Forms.Label FireFoxAK47Label;
        private System.Windows.Forms.Label FireFoxXM4abel;
        private System.Windows.Forms.Label FireFoxType63Label;
        private System.Windows.Forms.Label FireFoxMAC10Label;
        private System.Windows.Forms.Label FireFoxBullFrogLabel;
        private System.Windows.Forms.Label FireFoxKSP45Label;
        private System.Windows.Forms.Label FireFoxAK74uLabel;
        private System.Windows.Forms.Label FireFoxMilano821Label;
        private System.Windows.Forms.Label FireFoxMP5Label;
        private System.Windows.Forms.Label FireFoxDMR14Label;
        private System.Windows.Forms.Label FireFoxAUGLabel;
        private System.Windows.Forms.Label FireFoxM16Label;
        private System.Windows.Forms.Label FireFoxM60Label;
        private System.Windows.Forms.Label FireFoxRPDLabel;
        private System.Windows.Forms.Label FireFoxStoner63Label;
        private System.Windows.Forms.Label FireFoxM82Label;
        private System.Windows.Forms.Label FireFoxLW3TundraLabel;
        private System.Windows.Forms.Label FireFoxPelington703Label;
        private System.Windows.Forms.Label FireFoxStreetsweeperLabel;
        private System.Windows.Forms.Label FireFoxGalloSA12Label;
        private System.Windows.Forms.Label FireFoxHauer77Label;
        private System.Windows.Forms.Label FireFoxDiamattiLabel;
        private System.Windows.Forms.Label FireFoxMagnumLabel;
        private System.Windows.Forms.Label FireFoxLabel1911;
        private System.Windows.Forms.Label FireFoxWakizashi;
        private System.Windows.Forms.Label FireFoxSledgehammer;
        private System.Windows.Forms.Label FireFoxKnifeLabel;
        private System.Windows.Forms.Label FireFoxRPG7Label;
        private System.Windows.Forms.Label FireFoxCigma2Label;
        private System.Windows.Forms.Label FireFoxMacheteLabel;
        private System.Windows.Forms.Label FireFoxCrossbowLabel;
        private System.Windows.Forms.Label FireFoxLC10Label;
        private System.Windows.Forms.Label FireFoxFARA83Label;
        private System.Windows.Forms.Label FireFoxM79Label;
        private System.Windows.Forms.Label FireFoxSwissK31Label;
        private System.Windows.Forms.Label FireFoxZRG20MMLabel;
        private System.Windows.Forms.Label FireFoxBallisticKnifeLabel;
        private System.Windows.Forms.Label FireFoxEtoolLabel;
        private System.Windows.Forms.Label FireFoxPPSH41Label;
        public System.Windows.Forms.PictureBox FireFoxGrozaSpawn;
        public System.Windows.Forms.PictureBox FireFoxFFAR1Spawn;
        public System.Windows.Forms.PictureBox FireFoxQBZ83Spawn;
        public System.Windows.Forms.PictureBox FireFoxKraig6Spawn;
        public System.Windows.Forms.PictureBox FireFoxAK47Spawn;
        public System.Windows.Forms.PictureBox FireFoxXM4Spawn;
        public System.Windows.Forms.PictureBox FireFoxType63Spawn;
        public System.Windows.Forms.PictureBox FireFoxDMR14Spawn;
        public System.Windows.Forms.PictureBox FireFoxAUGSpawn;
        public System.Windows.Forms.PictureBox FireFoxM16Spawn;
        public System.Windows.Forms.PictureBox FireFoxMAC10Spawn;
        public System.Windows.Forms.PictureBox FireFoxBullFrogSpawn;
        public System.Windows.Forms.PictureBox FireFoxKSP45Spawn;
        public System.Windows.Forms.PictureBox FireFoxAK74uSpawn;
        public System.Windows.Forms.PictureBox FireFoxMilano821Spawn;
        public System.Windows.Forms.PictureBox FireFoxMP5Spawn;
        public System.Windows.Forms.PictureBox FireFoxM82Spawn;
        public System.Windows.Forms.PictureBox FireFoxLW3TundraSpawn;
        public System.Windows.Forms.PictureBox FireFoxPelington703Spawn;
        public System.Windows.Forms.PictureBox FireFoxM60Spawn;
        public System.Windows.Forms.PictureBox FireFoxRDPSpawn;
        public System.Windows.Forms.PictureBox FireFoxStoner63Spawn;
        public System.Windows.Forms.PictureBox FireFoxStreetsweeperSpawn;
        public System.Windows.Forms.PictureBox FireFoxGalloSA12Spawn;
        public System.Windows.Forms.PictureBox FireFoxHauer77Spawn;
        public System.Windows.Forms.PictureBox FireFoxDiamattiSpawn;
        public System.Windows.Forms.PictureBox FireFoxMagnumSpawn;
        public System.Windows.Forms.PictureBox FireFoxSpawn1911;
        public System.Windows.Forms.PictureBox FireFoxWakizashiSpawn;
        public System.Windows.Forms.PictureBox FireFoxSledgehammerSpawn;
        public System.Windows.Forms.PictureBox FireFoxKnifeSpawn;
        public System.Windows.Forms.PictureBox FireFoxRPG7;
        public System.Windows.Forms.PictureBox FireFoxCigma2;
        public System.Windows.Forms.PictureBox FireFoxMacheteSpawn;
        public System.Windows.Forms.PictureBox FireFoxCrossbowSpawn;
        public System.Windows.Forms.PictureBox FireFoxLC10Spawn;
        public System.Windows.Forms.PictureBox FireFoxFARA83Spawn;
        public System.Windows.Forms.PictureBox FireFoxM79Spawn;
        public System.Windows.Forms.PictureBox FireFoxSwissK31Spawn;
        public System.Windows.Forms.PictureBox FireFoxZRG20MMSpawn;
        public System.Windows.Forms.PictureBox FireFoxBallisticKnifeSpawn;
        public System.Windows.Forms.PictureBox FireFoxEtoolSpawn;
        public System.Windows.Forms.PictureBox FireFoxPPSH41Spawn;
        private DevExpress.XtraEditors.LabelControl FireFoxPasswordLabel;
        private DevExpress.XtraEditors.LabelControl FireFoxUsernameLabel;
        private DevExpress.XtraEditors.LabelControl FireFoxLicenseKeyLabel;
        public DevExpress.XtraEditors.TextEdit LoginPageKey;
        private DevExpress.XtraEditors.GroupControl FireFoxSavedSpawnPoints;
        private System.Windows.Forms.Label FireFoxCustomDIESpawns;
        private System.Windows.Forms.Label FireFoxCustomFireBasepawns;
        private DevExpress.XtraEditors.SimpleButton FireFoxCustomSpawnAddSpawn;
        private DevExpress.XtraEditors.LabelControl FireFoxCustomSpawnCustomNameLabel;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer17;
        public DevExpress.XtraEditors.CheckEdit FireFoxCustomSpawnFireBase;
        public DevExpress.XtraEditors.CheckEdit FireFoxCustomSpawnDIE;
        public DevExpress.XtraBars.Docking.DockPanel FireFoxDockerStats;
        public DevExpress.XtraEditors.TextEdit FireFoxCustomSpawnName;
        public DevExpress.XtraEditors.SimpleButton FireFoxCustomSpawnRefreshSpawn;
        public DevExpress.XtraEditors.ComboBoxEdit FireFoxCustomSpawnsChooseDIE;
        public DevExpress.XtraEditors.ComboBoxEdit FireFoxCustomSpawnsChooseFireBase;
        private DevExpress.XtraEditors.GroupControl FireFoxCustomSpawnPointsMapSpecific;
        private System.Windows.Forms.Label FireFoxTeleportFireBase;
        public DevExpress.XtraEditors.ComboBoxEdit FireFoxTeleportFireBaseCombo;
        private System.Windows.Forms.Label FireFoxTeleportDIE;
        public DevExpress.XtraEditors.ComboBoxEdit FireFoxTeleportDIECombo;
        private System.Windows.Forms.ToolStripMenuItem teleportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToMeToolStripMenuItem;
        private DevExpress.XtraEditors.GroupControl FireFoxCustomXYZSpawn;
        public DevExpress.XtraEditors.CheckEdit FireFoxXYZSpawnPlus;
        private DevExpress.XtraEditors.SimpleButton FireFoxXYZSpawnZ;
        private DevExpress.XtraEditors.SimpleButton FireFoxXYZSpawnY;
        private DevExpress.XtraEditors.SimpleButton FireFoxXYZSpawnX;
        public DevExpress.XtraEditors.CheckEdit FireFoxXYZSpawnMinus;
        public DevExpress.XtraEditors.TextEdit FireFoxTPValue;
        private DevExpress.XtraEditors.GroupControl FireFoxLobbyOptionsSpeedSettingsGB;
        private DevExpress.XtraEditors.SimpleButton FireFoxLobbyOptionsJumpHeightButton;
        private DevExpress.XtraEditors.TrackBarControl FireFoxLobbyOptionsJumpHeightTrackController;
        public DevExpress.XtraEditors.TextEdit FireFoxLobbyOptionsJumpHeightValue;
        public DevExpress.XtraEditors.TextEdit FireFoxLobbyOptionsSpeedValue;
        private DevExpress.XtraEditors.TrackBarControl FireFoxLobbyOptionsSpeedTrackController;
        private DevExpress.XtraEditors.SimpleButton FireFoxLobbyOptionsSpeedButton;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit repositoryItemColorPickEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit repositoryItemColorPickEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit repositoryItemColorPickEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit repositoryItemColorPickEdit4;
        public DevExpress.XtraEditors.Controls.ImageSlider FireFoxLoginPageSlider;
        public DevExpress.XtraBars.Alerter.AlertControl LoginAlerts;
        private DevExpress.XtraBars.TabFormContentContainer FireFoxTabPageData;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer18;
        private DevExpress.XtraBars.Docking.DockManager FireFoxDataDocker;
        public DevExpress.XtraBars.TabFormPage FireFoxDataPageTab;
        public DevExpress.XtraBars.Docking.DockPanel FireFoxPanelContainerData;
        public DevExpress.XtraBars.TabFormContentContainer FireFoxTabPageWeapons;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl FireFoxDataSpreadSheet;
        public DevExpress.XtraBars.Alerter.AlertControl OtherAlerts;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem1;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem2;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem3;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem4;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem5;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem6;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem7;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem8;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem9;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem10;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem11;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem12;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem13;
        private DevExpress.XtraEditors.GroupControl FireFoxCrystalsGB;
        private DevExpress.XtraEditors.SimpleButton FireFoxStartCrystalButton;
        private DevExpress.XtraEditors.GroupControl FireFoxOtherOptionsMain;
        private DevExpress.XtraEditors.SimpleButton FireFoxQuickXPOption;
        private DevExpress.XtraEditors.GroupControl FireFoxLevelXPGB;
        private DevExpress.XtraEditors.SimpleButton FireFoxLevelXPReset;
        private DevExpress.XtraEditors.SimpleButton FireFoxLevelXPSet;
        public DevExpress.XtraEditors.TextEdit FireFoxLevelXPValue;
        private DevExpress.XtraEditors.TrackBarControl FireFoxLevelXPSetTrackBar;
        private DevExpress.XtraEditors.GroupControl FireFoxPlayerXPGB;
        private DevExpress.XtraEditors.SimpleButton FireFoxPlayerXPReset;
        private DevExpress.XtraEditors.SimpleButton FireFoxPlayerXPSet;
        public DevExpress.XtraEditors.TextEdit FireFoxPlayerXPValue;
        private DevExpress.XtraEditors.TrackBarControl FireFoxPlayerXPSetTrackBar;
        private DevExpress.XtraEditors.GroupControl FireFoxInformationP1;
        private DevExpress.XtraEditors.SimpleButton FireFoxStartWeaponSpawningKeyPressP1;
        private DevExpress.XtraEditors.SimpleButton FireFoxStartSpawnWeaponsButtonP1;
        private DevExpress.XtraEditors.SimpleButton FireFoxResetKillCountP1;
        private DevExpress.XtraEditors.SimpleButton FirFoxP1DA;
        public DevExpress.XtraEditors.TextEdit FireFoxTimedSpawnValueP1;
        public System.Windows.Forms.Label FireFoxP1DarkAetherReady;
        public System.Windows.Forms.Label FireFoxP1KillCount;
        public System.Windows.Forms.PictureBox FireFoxWeaponSwitchSpawnBoxPlayerOne;
        public System.Windows.Forms.Label FireFoxCurrentWeaponP1;
        public System.Windows.Forms.Label FireFoxP1LocationDA;
        public System.Windows.Forms.Label FireFoxPlayerOneSpawnWeaponsDA;
        public DevExpress.XtraEditors.CheckEdit FireFoxUsePAPWeapons;
        private DevExpress.XtraEditors.GroupControl FireFoxInformationP2;
        public System.Windows.Forms.Label FireFoxP2LocationDA;
        public System.Windows.Forms.Label FireFoxP2DarkAetherReady;
        public System.Windows.Forms.Label FireFoxP2KillCount;
        public System.Windows.Forms.Label FireFoxCurrentWeaponP2;
        public System.Windows.Forms.Label FireFoxPlayerTwoSpawnWeaponsDA;
        private DevExpress.XtraEditors.SimpleButton FireFoxStartWeaponSpawningKeyPressP2;
        private DevExpress.XtraEditors.SimpleButton FireFoxStartSpawnWeaponsButtonP2;
        private DevExpress.XtraEditors.SimpleButton FireFoxResetKillCountP2;
        private DevExpress.XtraEditors.SimpleButton FirFoxP2DA;
        public DevExpress.XtraEditors.TextEdit FireFoxTimedSpawnValueP2;
        public System.Windows.Forms.PictureBox FireFoxWeaponSwitchSpawnBoxPlayerTwo;
        private DevExpress.XtraEditors.GroupControl FireFoxInformationP3;
        public System.Windows.Forms.Label FireFoxP3LocationDA;
        public System.Windows.Forms.Label FireFoxP3DarkAetherReady;
        public System.Windows.Forms.Label FireFoxP3KillCount;
        public System.Windows.Forms.Label FireFoxCurrentWeaponP3;
        public System.Windows.Forms.Label FireFoxPlayerThreeSpawnWeaponsDA;
        private DevExpress.XtraEditors.SimpleButton FireFoxStartWeaponSpawningKeyPressP3;
        private DevExpress.XtraEditors.SimpleButton FireFoxStartSpawnWeaponsButtonP3;
        private DevExpress.XtraEditors.SimpleButton FireFoxResetKillCountP3;
        private DevExpress.XtraEditors.SimpleButton FirFoxP3DA;
        public DevExpress.XtraEditors.TextEdit FireFoxTimedSpawnValueP3;
        public System.Windows.Forms.PictureBox FireFoxWeaponSwitchSpawnBoxPlayerThree;
        private DevExpress.XtraEditors.GroupControl FireFoxInformationP4;
        public System.Windows.Forms.Label FireFoxP4LocationDA;
        public System.Windows.Forms.Label FireFoxP4DarkAetherReady;
        public System.Windows.Forms.Label FireFoxP4KillCount;
        public System.Windows.Forms.Label FireFoxCurrentWeaponP4;
        public System.Windows.Forms.Label FireFoxPlayerFourSpawnWeaponsDA;
        private DevExpress.XtraEditors.SimpleButton FireFoxStartSpawnWeaponsButtonP4;
        private DevExpress.XtraEditors.SimpleButton FireFoxResetKillCountP4;
        private DevExpress.XtraEditors.SimpleButton FirFoxP4DA;
        public DevExpress.XtraEditors.TextEdit FireFoxTimedSpawnValueP4;
        public System.Windows.Forms.PictureBox FireFoxWeaponSwitchSpawnBoxPlayerFour;
        private DevExpress.XtraEditors.SimpleButton FireFoxStartWeaponSpawningKeyPressP4;
        private DevExpress.XtraEditors.GroupControl FireFoxStatsProgressGB;
        private DevExpress.XtraEditors.GroupControl FirFoxStatsOptionGroupBox;
        private DevExpress.XtraEditors.SimpleButton FireFoxSendStatsButton;
        public DevExpress.XtraEditors.TextEdit FireFoxTotalTimePlayedMinsInput;
        public DevExpress.XtraEditors.TextEdit FireFoxTotalTimePlayedHoursInput;
        public DevExpress.XtraEditors.TextEdit FireFoxTotalTimePlayedDaysInput;
        public DevExpress.XtraEditors.TextEdit FireFoxTotalGamesPlayedInput;
        public DevExpress.XtraEditors.TextEdit FireFoxTotalElimsInput;
        public DevExpress.XtraEditors.TextEdit FireFoxTotalCriticalKillsInput;
        public DevExpress.XtraEditors.TextEdit FireFoxTotalEliteKillsInput;
        public DevExpress.XtraEditors.TextEdit FireFoxTotalKillsInput;
        public DevExpress.XtraEditors.TextEdit FireFoxTotalRoundsInput;
        private System.Windows.Forms.Label FireFoxTotalTimePlayedMinsStatsLabel;
        private System.Windows.Forms.Label FireFoxTotalTimePlayedHoursStatsLabel;
        private System.Windows.Forms.Label FireFoxTotalTimePlayedDaysStatsLabel;
        private System.Windows.Forms.Label FireFoxTotalGamesPlayedStatsLabel;
        private System.Windows.Forms.Label FireFoxTotalElimsStatsLabel;
        private System.Windows.Forms.Label FireFoxTotalCriticalKillsStatsLabel;
        private System.Windows.Forms.Label FireFoxTotalEliteKillsStatsLabel;
        private System.Windows.Forms.Label FireFoxTotalKillsStatsLabel;
        private System.Windows.Forms.Label FireFoxTotalRoundsStatsLabel;
        private DevExpress.XtraEditors.GroupControl FireFoxRandomizeStatsGB;
        private DevExpress.XtraEditors.SimpleButton FireFoxRandomStatsLow;
        private DevExpress.XtraEditors.SimpleButton FireFoxRandomStatsMedium;
        private DevExpress.XtraEditors.SimpleButton FireFoxRandomStatsMax;
        private DevExpress.XtraEditors.GroupControl FireFoxStatsPlayerListGB;
        public DevExpress.XtraEditors.CheckEdit FireFoxP4StatsRefresh;
        public DevExpress.XtraEditors.CheckEdit FireFoxP3StatsRefresh;
        public DevExpress.XtraEditors.CheckEdit FireFoxP2StatsRefresh;
        public DevExpress.XtraEditors.CheckEdit FireFoxP1StatsRefresh;
        public System.Windows.Forms.ListBox FireFoxStatsProgressLB;
        public DevExpress.XtraEditors.CheckEdit FireFoxAutoConnect;
        public DevExpress.XtraEditors.CheckEdit FireFoxEnableQuickOptions;
        public DevExpress.XtraEditors.CheckEdit FireFoxDisableWhenOut;
        private DevExpress.XtraEditors.GroupControl FireFoxInformationReticlesP1;
        public System.Windows.Forms.Label FireFoxP1LocationReticles;
        public System.Windows.Forms.Label FireFoxP1KillCountReticles;
        public System.Windows.Forms.Label FireFoxCurrentWeaponReticlesP1;
        public System.Windows.Forms.Label FireFoxPlayerOneSpawnWeaponsReticles;
        public System.Windows.Forms.PictureBox FireFoxWeaponSwitchSpawnBoxReticlesPlayerOne;
        private DevExpress.XtraEditors.SimpleButton FireFoxStartSpawnWeaponsButtonReticlesP1;
        private DevExpress.XtraEditors.SimpleButton FireFoxResetKillCountReticlesP1;
        private DevExpress.XtraEditors.SimpleButton FirFoxP1Reticles;
        public DevExpress.XtraEditors.TextEdit FireFoxTimedSpawnValueReticlesP1;
        private DevExpress.XtraEditors.SimpleButton FireFoxKillAllPlayers;
        public DevExpress.XtraEditors.SimpleButton FireFoxFastRoundsStart;
        private DevExpress.XtraEditors.SimpleButton FireFoxStartSpawnWeaponsButtonReticlesP2;
        private DevExpress.XtraEditors.SimpleButton FireFoxResetKillCountReticlesP2;
        private DevExpress.XtraEditors.SimpleButton FirFoxP2Reticles;
        public DevExpress.XtraEditors.TextEdit FireFoxTimedSpawnValueReticlesP2;
        public System.Windows.Forms.PictureBox FireFoxWeaponSwitchSpawnBoxReticlesPlayerTwo;
        private DevExpress.XtraEditors.GroupControl FireFoxInformationReticlesP2;
        public System.Windows.Forms.Label FireFoxP2LocationReticles;
        public System.Windows.Forms.Label FireFoxP2KillCountReticles;
        public System.Windows.Forms.Label FireFoxCurrentWeaponReticlesP2;
        public System.Windows.Forms.Label FireFoxPlayerTwoSpawnWeaponsReticles;
        private DevExpress.XtraEditors.SimpleButton FireFoxStartSpawnWeaponsButtonReticlesP3;
        private DevExpress.XtraEditors.SimpleButton FireFoxResetKillCountReticlesP3;
        private DevExpress.XtraEditors.SimpleButton FirFoxP3Reticles;
        public DevExpress.XtraEditors.TextEdit FireFoxTimedSpawnValueReticlesP3;
        public System.Windows.Forms.PictureBox FireFoxWeaponSwitchSpawnBoxReticlesPlayerThree;
        private DevExpress.XtraEditors.GroupControl FireFoxInformationReticlesP3;
        public System.Windows.Forms.Label FireFoxP3LocationReticles;
        public System.Windows.Forms.Label FireFoxP3KillCountReticles;
        public System.Windows.Forms.Label FireFoxCurrentWeaponReticlesP3;
        public System.Windows.Forms.Label FireFoxPlayerThreeSpawnWeaponsReticles;
        private DevExpress.XtraEditors.SimpleButton FireFoxStartSpawnWeaponsButtonReticlesP4;
        private DevExpress.XtraEditors.SimpleButton FireFoxResetKillCountReticlesP4;
        private DevExpress.XtraEditors.SimpleButton FirFoxP4Reticles;
        public DevExpress.XtraEditors.TextEdit FireFoxTimedSpawnValueReticlesP4;
        public System.Windows.Forms.PictureBox FireFoxWeaponSwitchSpawnBoxReticlesPlayerFour;
        private DevExpress.XtraEditors.GroupControl FireFoxInformationReticlesP4;
        public System.Windows.Forms.Label FireFoxP4LocationReticles;
        public System.Windows.Forms.Label FireFoxP4KillCountReticles;
        public System.Windows.Forms.Label FireFoxCurrentWeaponReticlesP4;
        public System.Windows.Forms.Label FireFoxPlayerFourSpawnWeaponsReticles;
        public DevExpress.XtraEditors.SimpleButton FireFoxInfraredOff;
        public DevExpress.XtraEditors.SimpleButton FireFoxInfraredOn;
        public DevExpress.XtraEditors.SimpleButton FireFoxUnlimitedAmmoOff;
        public DevExpress.XtraEditors.SimpleButton FireFoxUnlimitedAmmoOn;
        public DevExpress.XtraEditors.SimpleButton FireFoxCritKillsOff;
        public DevExpress.XtraEditors.SimpleButton FireFoxCritKillsOn;
        public DevExpress.XtraEditors.SimpleButton FireFoxTPZombiesOff;
        public DevExpress.XtraEditors.SimpleButton FireFoxTPZombiesOn;
        public DevExpress.XtraEditors.SimpleButton FireFoxInstantKillOff;
        public DevExpress.XtraEditors.SimpleButton FireFoxInstantKillOn;
        public DevExpress.XtraEditors.SimpleButton FireFoxGodOff;
        public DevExpress.XtraEditors.SimpleButton FireFoxGodOn;
        public DevExpress.XtraEditors.SimpleButton FireFoxRapidFireOff;
        public DevExpress.XtraEditors.SimpleButton FireFoxRapidFireOn;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        public DevExpress.XtraEditors.SimpleButton StartGameTest;
    }
}

