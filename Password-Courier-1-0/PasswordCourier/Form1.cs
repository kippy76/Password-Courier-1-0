/*
 Copyright (C) 2012  Christopher Walker

 This program is free software: you can redistribute it and/or modify
 it under the terms of the GNU General Public License version 3 as
 published by the Free Software Foundation.

 This program is distributed in the hope that it will be useful,
 but WITHOUT ANY WARRANTY; without even the implied warranty of
 MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 GNU General Public License for more details.

 You should have received a copy of the GNU General Public License
 along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PasswordCourier
{
    /*
     * This program provides the means to distribute a password via an encrypted
     * key. Carry out procedure below:
     * 
     * 1. Change 'DEPLOY' to false and run program.
     * 2. Enter password to be secured.
     * 3. You can generate a new salt, or enter a known salt code.
     * 4. Click on generate key button.
     * 3. Copy details for 'Salt' and 'Key'.
     * 4. Change 'DEPLOY' to true.
     * 5. Change 'DISTRIBUTIONKEY' to key value created by generator.
     * 
     * Now compile and distribute the .exe with the 'Salt' from the generator.
     * Run the program, enter the salt, and the password will be displayed.
     * 
     * When in 'nodeploy' mode, you can click the banner image to toggle between
     * the generator and presenter for testing.
     * 
     * You could generate a salt for a specific recipient, and re-use the same
     * salt. Each time the recipient needs a new encrypted password, simply issue
     * a new copy of the program with the new embedded 'DISTRIBUTIONKEY' using the
     * recipients' known salt. Provided you can deliver the salt code securely to the
     * recipient, this provides a nice, secure method of password delivery.
     */

    public partial class Form1 : Form
    {
        // *****************************************************
        private static Boolean DEPLOY = true;
        private static string DISTRIBUTIONKEY = "hRsWhQiWBtmviYC56A4zI5eb2uyJmtkTr3Rbqj3Xx+c=";
        // *****************************************************
        private Random random;
        private Timer timer;
        private static string distKeyTest = "";

        public Form1()
        {
            random = new Random();
            timer = new Timer();
            timer.Interval = 200;
            timer.Tick += new EventHandler(timerElapsed);
            timer.Enabled = true;
            timer.Start();
            InitializeComponent();
            initForm();
        }

        private void initForm()
        {
            grpGenerator.Visible = !DEPLOY;
            grpPresenter.Visible = DEPLOY;
        }

        public string generateRandomSalt()
        {
            string allowed = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string salt = "";
            for (int pos = 0; pos < 16; pos++)
            {
                salt += allowed[random.Next() % (allowed.Length)];
            }
            return salt;
        }

        public static string EncryptString(string Message, string pass)
        {
            string Passphrase = pass;
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;
            byte[] DataToEncrypt = UTF8.GetBytes(Message);
            try
            {
                ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
            }
            finally
            {
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }
            return Convert.ToBase64String(Results);
        }

        public static string DecryptString(string Message, string pass)
        {
            try
            {
                string Passphrase = pass;
                byte[] Results;
                System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
                MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
                byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));
                TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
                TDESAlgorithm.Key = TDESKey;
                TDESAlgorithm.Mode = CipherMode.ECB;
                TDESAlgorithm.Padding = PaddingMode.PKCS7;
                byte[] DataToDecrypt = Convert.FromBase64String(Message);
                try
                {
                    ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();
                    Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);
                }
                finally
                {
                    TDESAlgorithm.Clear();
                    HashProvider.Clear();
                }
                return UTF8.GetString(Results);
            }
            catch (Exception)
            {
            }
            return null;
        }

        private void btnGenSalt_Click(object sender, EventArgs e)
        {
            string salt = generateRandomSalt();
            txtGenSalt.Text = "";
            for (int saltPos = 0; saltPos < salt.Length; saltPos++)
            {
                txtGenSalt.Text += salt[saltPos];
                if (((saltPos + 1) % 4 == 0) && (saltPos != salt.Length - 1))
                {
                    txtGenSalt.Text += " - ";
                }
            }
        }

        private void btnGenerateKeyClick(object sender, EventArgs e)
        {
            if (txtGenPass.Text.Length == 0)
            {
                return;
            }
            string salt;
            if (txtGenSalt.Text.Length == 0)
            {
                salt = generateRandomSalt();
                txtGenSalt.Text = "";
                for (int saltPos = 0; saltPos < salt.Length; saltPos++)
                {
                    txtGenSalt.Text += salt[saltPos];
                    if (((saltPos + 1) % 4 == 0) && (saltPos != salt.Length - 1))
                    {
                        txtGenSalt.Text += " - ";
                    }
                }
            }
            else
            {
                salt = formatKey(txtGenSalt.Text);
            }            
            string encoded = EncryptString(txtGenPass.Text, salt);
            txtGenEncoded.Text = encoded;
            distKeyTest = encoded;
        }

        private void timerElapsed(object sender, EventArgs e)
        {
            string key = "";
            key = formatKey(txtViewKey.Text);
            txtViewPassword.Text = DecryptString(DEPLOY ? DISTRIBUTIONKEY : distKeyTest, key);
        }

        private string formatKey(string text)
        {
            text = text.Replace(" ", string.Empty);
            text = text.Replace("-", string.Empty);
            return text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!DEPLOY)
            {
                bool gen = grpGenerator.Visible;
                grpGenerator.Visible = !gen;
                grpPresenter.Visible = gen;
            }
        }

       
    }
}
