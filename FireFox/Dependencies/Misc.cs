using DevExpress.XtraEditors;
using FireFox.Properties;
using Leaf.xNet;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireFox.Dependencies;
using System.Security.Cryptography;
using System.ServiceProcess;
using System.ComponentModel;
using System.Threading;
using System.Drawing;

namespace FireFox
{
    class Misc
    {
        //Current Tool Version
        public static string FireFoxCurrentVersion = "51.0";

        //Cleaner Files
        //Grabbing Cleaned Amount
        public static int CleanedFilesNum = 0;
        //Check Protection BG Worker
        public static BackgroundWorker FireFoxCheckProtectionBGWorker = new BackgroundWorker();
        //Logo Creation
        public static BackgroundWorker FireFoxLogoChangerBGWorker = new BackgroundWorker();
        //Oath Token
        public static string FireFoxSavedOathToken;
        //Saved Profile ID
        public static string FireFoxSavedProfileID;
        //Password For Decryption Keys
        static string PasswordHash = "wGJ8BjGpGhfByq9Fa5YFz";
        static string SaltKey = "";
        static readonly string VIKey = "@2Qeg4wNhWyWhrTy";
        //Get Expire Date
        public static string FireFoxExpireDate;
        //Cleaning Files?
        public static bool FireFoxIsCleaningFiles = false;
        public static class Globals
        {
            public static Firefox firefox;
        }

        /*public static void FireFoxCheckForUpdate()
        {
            try
            {
                using (HttpRequest httpRequest = new HttpRequest())
                {
                    httpRequest.ClearAllHeaders();
                    httpRequest.KeepAlive = true;
                    httpRequest.IgnoreProtocolErrors = true;
                    httpRequest.ConnectTimeout = 25000;
                    httpRequest.AllowAutoRedirect = false;
                    string GetVersionNumber = httpRequest.Get("https://epictools.org/api/downloads/files/1?key=4c254c1369dca495439788e8601bbed4").ToString();
                    JToken GrabVersionNumber = JObject.Parse(GetVersionNumber)["version"];
                    string FinalVersionNumber = GrabVersionNumber.ToString();
                    if (FireFoxCurrentVersion != FinalVersionNumber)
                    {
                        XtraMessageBox.Show("A New Version Of The Tool Has Been Found!\nPlease Click Ok To Be Redirected To The Download Page\nEnjoy The Update!");
                        Process.Start("https://epictools.org/files/file/1-epictools-trainer/");
                        Application.Exit();
                        Process.GetCurrentProcess().Kill();
                    }
                }
            }
            catch (Exception EX)
            {
                XtraMessageBox.Show("Error Checking Tool Version\nPlease Try To Download The Tool Again In Case Of A New Version!");
                XtraMessageBox.Show(EX.Message);
                System.Diagnostics.Process.Start("https://epictools.org/files/file/1-epictools-trainer/");
                Application.Exit();
                Process.GetCurrentProcess().Kill();
            }
        }*/

        public static class FireFoxLogoChanger
        {
            public static void FireFoxLogoChangerStart()
            {
                Globals.firefox.FireFoxLoginPageSlider.AnimationTime = 3000;
                if (Directory.Exists("Logos"))
                {
                    DirectoryInfo d = new DirectoryInfo("Logos");
                    foreach (var file in d.GetFiles("*.jpg"))
                    {
                        Globals.firefox.FireFoxLoginPageSlider.Images.Add(Image.FromFile(file.FullName));
                    }
                    foreach (var file in d.GetFiles("*.png"))
                    {
                        Globals.firefox.FireFoxLoginPageSlider.Images.Add(Image.FromFile(file.FullName));
                    }
                    foreach (var file in d.GetFiles("*.gif"))
                    {
                        Globals.firefox.FireFoxLoginPageSlider.Images.Add(Image.FromFile(file.FullName));
                    }
                    foreach (var file in d.GetFiles("*.jfif"))
                    {
                        Globals.firefox.FireFoxLoginPageSlider.Images.Add(Image.FromFile(file.FullName));
                    }
                    foreach (var file in d.GetFiles("*.mp4"))
                    {
                        Globals.firefox.FireFoxLoginPageSlider.Images.Add(Image.FromFile(file.FullName));
                    }
                }
                else
                {
                    Globals.firefox.FireFoxLoginPageSlider.Images.Add(Properties.Resources.FireFoxLogo1);
                    Globals.firefox.FireFoxLoginPageSlider.Images.Add(Properties.Resources.FireFoxLogo2);
                    Globals.firefox.FireFoxLoginPageSlider.Images.Add(Properties.Resources.FireFoxLogo3);
                    Globals.firefox.FireFoxLoginPageSlider.Images.Add(Properties.Resources.FireFoxLogo4);
                    Globals.firefox.FireFoxLoginPageSlider.Images.Add(Properties.Resources.FireFoxLogo5);
                }
            }
        }

        public static class FireFoxCheckAssetFiles
        {

            public static void FireFoxStartProtectCheck()
            {
                FireFoxCheckProtectionBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(FireFoxCheckProtect_DoWork);
                FireFoxCheckProtectionBGWorker.RunWorkerAsync();
            }

            public static void FireFoxCheckProtect_DoWork(object sender, DoWorkEventArgs e)
            {
                while (true)
                {
                    Process[] pname = Process.GetProcessesByName("Assets2");
                    if (pname.Length == 0)
                    {
                        try
                        {
                            Application.Exit();
                        }
                        catch
                        {
                            Process.GetCurrentProcess().Kill();
                        }
                    }
                    ServiceController sc = new ServiceController("EQProtect");
                    if (sc.Status != ServiceControllerStatus.Running)
                    {
                        try
                        {
                            Application.Exit();
                        }
                        catch
                        {
                            Process.GetCurrentProcess().Kill();
                        }
                    }
                    Thread.Sleep(2500);
                }
            }

            public static void FireFoxCloseAssetsWhenFormClose()
            {
                string Assets1 = Path.Combine(Path.GetTempPath(), "Assets1.exe");
                string Assets2 = Path.Combine(Path.GetTempPath(), "Assets2.exe");
                try { EndTask("Assets2"); } catch { }
                try { if (File.Exists(Assets1)) { File.Delete(Assets1); } if (File.Exists(Assets2)) { File.Delete(Assets2); } } catch { }
            }
            public static void EndTask(string taskname)
            {
                string processName = taskname.Replace(".exe", "");

                foreach (Process process in Process.GetProcessesByName(processName))
                {
                    process.Kill();
                }
            }

        }
        public static DateTime Epoch2UTCNow(int epoch)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(epoch);
        }

        public static void Login(string Username, string Password, string Key)
        {
            FireFoxAddPages();
        }


        public static bool LoginKey(string Username, string Password, string Key)
        {
            using (HttpRequest httpRequest = new HttpRequest())
            {
                string PCName = Environment.UserName +"1";
                SaltKey = PCName + "GhCJe";
                string HWIDEncrypted = Encrypt(PCName).Replace("+", " ");
                httpRequest.ClearAllHeaders();
                httpRequest.KeepAlive = true;
                httpRequest.IgnoreProtocolErrors = true;
                httpRequest.ConnectTimeout = 25000;
                httpRequest.AllowAutoRedirect = false;

                string SendHWID = "{\"HWID\":\"" + HWIDEncrypted + "\"}";
                string RegisterKeyHWIDData = "key=" + Key + "&identifier=" + Username + "&extra=" + SendHWID;
                string RegisterKey = httpRequest.Get("https://epictools.org/applications/nexus/interface/licenses/?activate&key=" + Key + "&identifier=" + Username + "&extra=" + SendHWID).ToString();
                string CheckKey = httpRequest.Get("https://epictools.org/applications/nexus/interface/licenses/?check&key=" + Key + "&identifier=" + Username + "&usage_id=1").ToString();
                if (CheckKey.Contains("ACTIVE") && CheckKey.Contains("status") && CheckKey.Contains("uses") && CheckKey.Contains("max_uses"))
                {

                    string GetKeyInfo = httpRequest.Get("https://epictools.org/applications/nexus/interface/licenses/?info&key=" + Key + "&identifier=" + Username + "&usage_id=1").ToString();
                    JToken HWIDGrab = JObject.Parse(GetKeyInfo)["usage_data"]["1"]["extra"]["HWID"];
                    try
                    {
                        JToken ExpireDate = JObject.Parse(GetKeyInfo)["expires"];
                        int ExpireDateNum = ExpireDate.ToObject<int>();
                        FireFoxExpireDate = Epoch2UTCNow(ExpireDateNum).ToString();
                    }
                    catch (Exception EX)
                    {
                        if (EX.Message.Contains("Can not convert Null to Int32"))
                        {
                            FireFoxExpireDate = "Lifetime/Never Expires";
                        }
                        else
                        {
                            FireFoxExpireDate = "Error Grabbing Expire Date ---> " + EX.Message;
                        }
                    }
                    string HWIDFinal = HWIDGrab.ToString();
                    if (String.Compare(HWIDFinal, HWIDEncrypted) != 0)
                    {
                        if (XtraMessageBox.Show("You're HWID Does Not Match Our Records\nWould You Like To Update You're HWID NOW\nKeep Note We Track How Many HWID Resets You Do\nMass Amounts Could Result In Ban.", "HWID Does Not Match!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        {
                            XtraMessageBox.Show("HWID Not Updated, Closing Application!");
                            Process.GetCurrentProcess().Kill();
                            return false;
                        }
                        else
                        {
                            string SendUpdatedHWID = "{\"HWID\":\"" + HWIDEncrypted + "\"}";
                            string UpdateKey = httpRequest.Get("https://epictools.org/applications/nexus/interface/licenses/?updateExtra&key=" + Key + "&identifier=" + Username + "&extra=" + SendUpdatedHWID + "&usage_id=1").ToString();
                            Globals.firefox.LoginAlerts.Show(null, "HWID Updated Successfully!", "HWID Successfully Updated In records, Please Login Again!");
                            return false;
                        }
                    }
                    else
                    {
                        if (!FireFoxIsCleaningFiles)
                        {
                            Globals.firefox.LoginAlerts.Show(null, "Expire Info...", "Your Package Will Expire: " + FireFoxExpireDate);
                            Settings.Default["Username"] = Username;
                            Settings.Default["Password"] = Password;
                            Settings.Default["Key"] = Key;
                            Settings.Default.Save();
                            MainTab.FireFoxOffsets.FireFoxUpdateOffsets();
                            FireFoxAddPages();
                            Globals.firefox.FireFoxTabControl.Pages.Remove(Globals.firefox.FireFoxLogin);
                            if (Globals.firefox.FireFoxAutoConnect.Checked)
                            {
                                MainTab.FireFoxConnectionOptions.FireFoxConnect();
                            }
                            return true;
                        }
                        return true;
                    }
                }
                else if (CheckKey.Contains("BAD_KEY_OR_ID"))
                {
                    Globals.firefox.LoginAlerts.Show(null, "Invalid/Expired License Key!", "The License Key You Provided Is Invalid, Perhaps It Is Expired?");
                    Globals.firefox.LoginAlerts.Show(null, "Error Message!", CheckKey);
                    Globals.firefox.LoginAlerts.Show(null, "PLEASE READ", "Use USERNAME only for login, It IS CASE SENSITIVE, Make sure caps etc are correct!");
                    return false;
                }
                else
                {
                    Globals.firefox.LoginAlerts.Show(null, "Invalid/Expired License Key!", "The License Key You Provided Is Invalid, Perhaps It Is Expired?");
                    XtraMessageBox.Show("Error Code: " + CheckKey);
                    return false;
                }
            }
        }

        public static string Encrypt(string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));

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
            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

            var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
            var memoryStream = new MemoryStream(cipherTextBytes);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        }

        public static void FireFoxRemovePages()
        {
            Globals.firefox.FireFoxTabControl.Pages.Remove(Globals.firefox.FireFoxMain);
            Globals.firefox.FireFoxTabControl.Pages.Remove(Globals.firefox.FireFoxWeaponPage);
            Globals.firefox.FireFoxTabControl.Pages.Remove(Globals.firefox.FireFoxDataPageTab);
        }

        public static void FireFoxAddPages()
        {
            Globals.firefox.FireFoxTabControl.Pages.Add(Globals.firefox.FireFoxMain);
            Globals.firefox.FireFoxTabControl.Pages.Add(Globals.firefox.FireFoxWeaponPage);
            Globals.firefox.FireFoxTabControl.Pages.Add(Globals.firefox.FireFoxDataPageTab);
            Globals.firefox.FireFoxTabControl.SelectedPage = Globals.firefox.FireFoxMain;
        }

        public static void FireFoxHideDockers()
        {
            //Start Update
            Globals.firefox.FireFoxMainDocker.BeginUpdate();
            Globals.firefox.FireFoxWeaponSpawningDocker.BeginUpdate();
            //Main Tab
            Globals.firefox.FireFoxDockerClients.Hide();
            Globals.firefox.FireFoxDockerTeleport.Hide();
            Globals.firefox.FireFoxDockerLobby.Hide();
            Globals.firefox.FireFoxDockerDA.Hide();
            Globals.firefox.FireFoxDockerReticles.Hide();
            Globals.firefox.FireFoxDockerStats.Hide();
            //Weapon Tab
            Globals.firefox.FireFoxWeaponDockerAR.Hide();
            Globals.firefox.FireFoxWeaponDockerSMG.Hide();
            Globals.firefox.FireFoxWeaponDockeTAC.Hide();
            Globals.firefox.FireFoxWeaponDockeLMG.Hide();
            Globals.firefox.FireFoxWeaponDockeSnipers.Hide();
            Globals.firefox.FireFoxWeaponDockeSnipers.Hide();
            Globals.firefox.FireFoxWeaponDockeShotguns.Hide();
            Globals.firefox.FireFoxWeaponDockePistols.Hide();
            Globals.firefox.FireFoxWeaponDockeLaunchers.Hide();
            Globals.firefox.FireFoxWeaponDockeMelee.Hide();
            Globals.firefox.FireFoxWeaponDockeSpecial.Hide();
            Globals.firefox.FireFoxWeaponDockeDLC.Hide();
            //Data Tab
            Globals.firefox.FireFoxPanelContainerData.Hide();
            //End Update
            Globals.firefox.FireFoxMainDocker.EndUpdate();
            Globals.firefox.FireFoxWeaponSpawningDocker.EndUpdate();
        }

        public static void FireFoxUpdateDockerPanels()
        {
            FireFoxHideDockers();
            Globals.firefox.FireFoxMainDocker.BeginUpdate();
            Globals.firefox.FireFoxWeaponSpawningDocker.BeginUpdate();
            if (Globals.firefox.FireFoxTabControl.SelectedPage == Globals.firefox.FireFoxMain)
            {
                Globals.firefox.FireFoxDockerStats.Show();
                Globals.firefox.FireFoxDockerReticles.Show();
                Globals.firefox.FireFoxDockerDA.Show();
                Globals.firefox.FireFoxDockerLobby.Show();
                Globals.firefox.FireFoxDockerTeleport.Show();
                Globals.firefox.FireFoxDockerClients.Show();
            }
            if (Globals.firefox.FireFoxTabControl.SelectedPage == Globals.firefox.FireFoxWeaponPage)
            {
                Globals.firefox.FireFoxWeaponDockeDLC.Show();
                Globals.firefox.FireFoxWeaponDockeSpecial.Show();
                Globals.firefox.FireFoxWeaponDockeMelee.Show();
                Globals.firefox.FireFoxWeaponDockeLaunchers.Show();
                Globals.firefox.FireFoxWeaponDockePistols.Show();
                Globals.firefox.FireFoxWeaponDockeShotguns.Show();
                Globals.firefox.FireFoxWeaponDockeSnipers.Show();
                Globals.firefox.FireFoxWeaponDockeSnipers.Show();
                Globals.firefox.FireFoxWeaponDockeLMG.Show();
                Globals.firefox.FireFoxWeaponDockeTAC.Show();
                Globals.firefox.FireFoxWeaponDockerSMG.Show();
                Globals.firefox.FireFoxWeaponDockerAR.Show();
            }
            if (Globals.firefox.FireFoxTabControl.SelectedPage == Globals.firefox.FireFoxDataPageTab)
            {
                Globals.firefox.FireFoxPanelContainerData.Show();
                Globals.firefox.OtherAlerts.Show(null, "Reminder!", "Remember Use These Keys To Save/Load Files!\nCTRL+S = Save\nCTRL+O = Load");
            }
            Globals.firefox.FireFoxMainDocker.EndUpdate();
            Globals.firefox.FireFoxWeaponSpawningDocker.EndUpdate();
        }

        public static void FireFoxCleanUp(string Username)
        {
            CleanedFilesNum = 0;
            Globals.firefox.FireFoxCleanProgress.Items.Clear();
            Globals.firefox.FireFoxCleanProgress.Visible = true;
            FireFoxIsCleaningFiles = true;
            bool LoginCheck = Process.GetProcesses(Username).Length > 0;
            if (LoginCheck == false)
            {
                Globals.firefox.FireFoxCleanProgress.Items.Add("Failed To Authenticate Login Data... Will Not Conintue...");
            }
            else
            {
                string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string LocalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string ProgramData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                string DocumentFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string HKCU = $@"SOFTWARE\Blizzard Entertainment\Battle.net";
                string HKCU2 = $@"SOFTWARE\Blizzard Entertainment\Blizzard Error";
                string HKCU3 = $@"SOFTWARE\WOW6432Node\Blizzard Entertainment";
                EndTask("BlackOpsColdWar");
                EndTask("Battle.net");
                EndTask("Agent");
                try
                {
                    clearFolder(AppData + "/Battle.net");
                }
                catch { }
                try
                {
                    clearFolder(LocalAppData + "/Blizzard Entertainment");
                }
                catch { }
                try
                {
                    clearFolder(LocalAppData + "/Battle.net");
                }
                catch { }
                try
                {
                    clearFolder(ProgramData + "/Battle.net");
                }
                catch { }
                try
                {
                    clearFolder(ProgramData + "/Blizzard Entertainment");
                }
                catch { }
                try
                {
                    clearFolder(ProgramData + "/Activision");
                }
                catch { }
                try
                {
                    clearFolder(DocumentFolder + "/Call Of Duty Black Ops Cold War");
                }
                catch { }
                try
                {
                    clearFolder(DocumentFolder + "/Call of Duty Modern Warfare");
                }
                catch { }
                try
                {
                    DeleteRegistryFolder(RegistryHive.CurrentUser, HKCU);
                }
                catch { }
                try
                {
                    DeleteRegistryFolder(RegistryHive.CurrentUser, HKCU2);
                }
                catch { }
                try
                {
                    DeleteRegistryFolder(RegistryHive.LocalMachine, HKCU3);
                }
                catch { }
                if (CleanedFilesNum != 0)
                {
                    Globals.firefox.FireFoxCleanProgress.Items.Add("Successfully Cleaned " + CleanedFilesNum + " Files!");
                    Globals.firefox.FireFoxCleanButton.Text = "Cleaned " + CleanedFilesNum + " Files!";
                    Globals.firefox.FireFoxCleanButton.Refresh();
                }
                else
                {
                    Globals.firefox.FireFoxCleanProgress.Items.Add("No Files To Clean!");
                    Globals.firefox.FireFoxCleanButton.Text = "No Files To Clean!";
                    Globals.firefox.FireFoxCleanButton.Refresh();
                }
            }
        }

        public static void DeleteRegistryFolder(RegistryHive registryHive, string fullPathKeyToDelete)
        {
            using (var baseKey = RegistryKey.OpenBaseKey(registryHive, RegistryView.Registry64))
            {
                try
                {
                    baseKey.DeleteSubKeyTree(fullPathKeyToDelete);
                    Globals.firefox.FireFoxCleanProgress.Items.Add("Deleted Registry Keys " + fullPathKeyToDelete);
                    CleanedFilesNum = CleanedFilesNum + 1;
                }
                catch (Exception EX)
                {
                    if (!EX.Message.Contains("does not exist"))
                    {
                        Globals.firefox.FireFoxCleanProgress.Items.Add("Error Deleting Registry Key " + fullPathKeyToDelete);
                    }
                }
                Globals.firefox.FireFoxCleanProgress.SelectedIndex = Globals.firefox.FireFoxCleanProgress.Items.Count - 1;
                Globals.firefox.FireFoxCleanProgress.SelectedIndex = -1;
            }
        }

        public static void clearFolder(string FolderName)
        {
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                try
                {
                    fi.Delete();
                    Globals.firefox.FireFoxCleanProgress.Items.Add("File " + fi + " Deleted!");
                    CleanedFilesNum = CleanedFilesNum + 1;
                }
                catch
                {

                }
            }
            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                try
                {
                    clearFolder(di.FullName);
                    di.Delete();
                }
                catch
                {

                }
            }
        }

        public static void EndTask(string taskname)
        {
            string processName = taskname.Replace(".exe", "");
            foreach (Process process in Process.GetProcessesByName(processName))
            {
                string Name = process.ToString();
                try
                {
                    process.Kill();
                    Globals.firefox.FireFoxCleanProgress.Items.Add(Name.Replace("System.Diagnostics.Process ", "") + " Killed!");
                }
                catch
                {
                    Globals.firefox.FireFoxCleanProgress.Items.Add("Failed To Kill " + Name.Replace("System.Diagnostics.Process ", ""));
                }
                Globals.firefox.FireFoxCleanProgress.SelectedIndex = Globals.firefox.FireFoxCleanProgress.Items.Count - 1;
                Globals.firefox.FireFoxCleanProgress.SelectedIndex = -1;
            }
        }
    }
}
