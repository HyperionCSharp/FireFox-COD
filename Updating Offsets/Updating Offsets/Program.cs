using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Updating_Offsets
{
    class Program
    {
        public static string PasswordHash2 = "eKGxhCwLzMuF3d3wC8xuD";
        public static string SaltKey2 = "GxZ3PHFN";
        public static readonly string VIKey2 = "@hdHSrz37Xrh6zpF";
        public static string GodMode;
        public static string PC_ArraySize_Offset;
        public static string PC_Name;
        public static string InfraredVision;
        public static string PP_Cords;
        public static string MainCamo;
        public static string XPBaseLevel;
        public static string XPBaseLevelFake;
        public static string XPBaseWeapon;
        public static string JumpHeight;
        public static string PlayerBase;
        public static string PlayerBase2;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To TCM's Offset Updater");


            //God Mode START //
            Console.WriteLine("Please Enter New God Mode Offset");
            GodMode = FireFoxDecryptEncryptVars.Encrypt(Console.ReadLine());
            if(GodMode == "")
            {
                Console.WriteLine("Skipping God Mode...");
            }
            else
            {
                using (var GodWrite = new StreamWriter("God.txt", false))
                {
                    GodWrite.WriteLine(GodMode);
                    Console.WriteLine("Successfully Wrote Offset GodMode To File!");
                }
            }
            //God Mode END //

            //PC_ArraySize_Offset START //
            Console.WriteLine("Please Enter New PC_ArraySize_Offset Offset");
            PC_ArraySize_Offset = FireFoxDecryptEncryptVars.Encrypt(Console.ReadLine());
            if (PC_ArraySize_Offset == "")
            {
                Console.WriteLine("Skipping PC_ArraySize_Offset...");
            }
            else
            {
                using (var PC_ArraySize_OffsetWrite = new StreamWriter("PC_ArraySize_Offset.txt", false))
                {
                    PC_ArraySize_OffsetWrite.WriteLine(PC_ArraySize_Offset);
                    Console.WriteLine("Successfully Wrote Offset PC_ArraySize_Offset To File!");
                }
            }
            //PC_ArraySize_Offset END //

            //PC_Name START //
            Console.WriteLine("Please Enter New PC_Name Offset");
            PC_Name = FireFoxDecryptEncryptVars.Encrypt(Console.ReadLine());
            if (PC_Name == "")
            {
                Console.WriteLine("Skipping PC_Name...");
            }
            else
            {
                using (var PC_NameWrite = new StreamWriter("PC_Name.txt", false))
                {
                    PC_NameWrite.WriteLine(PC_Name);
                    Console.WriteLine("Successfully Wrote Offset PC_Name To File!");
                }
            }
            //PC_Name END //

            //InfraredVision START //
            Console.WriteLine("Please Enter New InfraredVision Offset");
            InfraredVision = FireFoxDecryptEncryptVars.Encrypt(Console.ReadLine());
            if (InfraredVision == "")
            {
                Console.WriteLine("Skipping InfraredVision...");
            }
            else
            {
                using (var InfraredVisionWrite = new StreamWriter("InfraredVision.txt", false))
                {
                    InfraredVisionWrite.WriteLine(InfraredVision);
                    Console.WriteLine("Successfully Wrote Offset InfraredVision To File!");
                }
            }
            //InfraredVision END //

            //PP_Cords START //
            Console.WriteLine("Please Enter New PP_Cords Offset");
            PP_Cords = FireFoxDecryptEncryptVars.Encrypt(Console.ReadLine());
            if (PP_Cords == "")
            {
                Console.WriteLine("Skipping PP_Cords...");
            }
            else
            {
                using (var PP_CordsWrite = new StreamWriter("PP_Cords.txt", false))
                {
                    PP_CordsWrite.WriteLine(PP_Cords);
                    Console.WriteLine("Successfully Wrote Offset PP_Cords To File!");
                }
            }
            //PP_Cords END //

            //MainCamo START //
            Console.WriteLine("Please Enter New MainCamo Offset");
            MainCamo = FireFoxDecryptEncryptVars.Encrypt(Console.ReadLine());
            if (MainCamo == "")
            {
                Console.WriteLine("Skipping MainCamo...");
            }
            else
            {
                using (var MainCamoWrite = new StreamWriter("MainCamo.txt", false))
                {
                    MainCamoWrite.WriteLine(MainCamo);
                    Console.WriteLine("Successfully Wrote Offset MainCamo To File!");
                }
            }
            //MainCamo END //

            //XPBaseLevel START //
            Console.WriteLine("Please Enter New XPBaseLevel Offset");
            XPBaseLevel = FireFoxDecryptEncryptVars.Encrypt(Console.ReadLine());
            if (XPBaseLevel == "")
            {
                Console.WriteLine("Skipping XPBaseLevel...");
            }
            else
            {
                using (var XPBaseLevelWrite = new StreamWriter("XPBaseLevel.txt", false))
                {
                    XPBaseLevelWrite.WriteLine(XPBaseLevel);
                    Console.WriteLine("Successfully Wrote Offset XPBaseLevel To File!");
                }
            }
            //XPBaseLevel END //

            //XPBaseLevelFake START //
            Console.WriteLine("Please Enter New XPBaseLevelFake Offset");
            XPBaseLevelFake = FireFoxDecryptEncryptVars.Encrypt(Console.ReadLine());
            if (XPBaseLevelFake == "")
            {
                Console.WriteLine("Skipping XPBaseLevelFake...");
            }
            else
            {
                using (var XPBaseLevelFakeWrite = new StreamWriter("XPBaseLevelFake.txt", false))
                {
                    XPBaseLevelFakeWrite.WriteLine(XPBaseLevelFake);
                    Console.WriteLine("Successfully Wrote Offset XPBaseLevelFake To File!");
                }
            }
            //XPBaseLevelFake END //

            //XPBaseLevelFake START //
            Console.WriteLine("Please Enter New XPBaseWeapon Offset");
            XPBaseWeapon = FireFoxDecryptEncryptVars.Encrypt(Console.ReadLine());
            if (XPBaseWeapon == "")
            {
                Console.WriteLine("Skipping XPBaseWeapon...");
            }
            else
            {
                using (var XPBaseWeaponWrite = new StreamWriter("XPBaseWeapon.txt", false))
                {
                    XPBaseWeaponWrite.WriteLine(XPBaseWeapon);
                    Console.WriteLine("Successfully Wrote Offset XPBaseWeapon To File!");
                }
            }
            //XPBaseLevelFake END //

            //JumpHeight START //
            Console.WriteLine("Please Enter New JumpHeight Offset");
            JumpHeight = FireFoxDecryptEncryptVars.Encrypt(Console.ReadLine());
            if (JumpHeight == "")
            {
                Console.WriteLine("Skipping JumpHeight...");
            }
            else
            {
                using (var JumpHeightWrite = new StreamWriter("JumpHeight.txt", false))
                {
                    JumpHeightWrite.WriteLine(JumpHeight);
                    Console.WriteLine("Successfully Wrote Offset JumpHeight To File!");
                }
            }
            //JumpHeight END //

            //PlayerBase START //
            Console.WriteLine("Please Enter New PlayerBase Offset");
            PlayerBase = FireFoxDecryptEncryptVars.Encrypt(Console.ReadLine());
            if (PlayerBase == "")
            {
                Console.WriteLine("Skipping PlayerBase...");
            }
            else
            {
                using (var PlayerBaseWrite = new StreamWriter("PlayerBase.txt", false))
                {
                    PlayerBaseWrite.WriteLine(PlayerBase);
                    Console.WriteLine("Successfully Wrote Offset PlayerBase To File!");
                }
            }
            //PlayerBase END //

            //PlayerBase2 START //
            Console.WriteLine("Please Enter New PlayerBase2 Offset");
            PlayerBase2 = FireFoxDecryptEncryptVars.Encrypt(Console.ReadLine());
            if (PlayerBase2 == "")
            {
                Console.WriteLine("Skipping PlayerBase2...");
            }
            else
            {
                using (var PlayerBase2Write = new StreamWriter("PlayerBase2.txt", false))
                {
                    PlayerBase2Write.WriteLine(PlayerBase2);
                    Console.WriteLine("Successfully Wrote Offset PlayerBase2 To File!");
                }
            }
            //PlayerBase2 END //


            Console.ReadLine();
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
    }
}
