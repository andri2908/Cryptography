using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Management;


namespace Cryptography
{
    public partial class Form1 : Form
    {
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        public Form1()
        {
            InitializeComponent();
        }

        public static void GenKey_SaveInContainer(string ContainerName)
        {
            // Create the CspParameters object and set the key container 
            // name used to store the RSA key pair.
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = ContainerName;

            // Create a new instance of RSACryptoServiceProvider that accesses
            // the key container MyKeyContainerName.
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            // Display the key information to the console.
            Console.WriteLine("Key added to container: \n  {0}", rsa.ToXmlString(true));
        }

        public RSAParameters GetKeyFromContainer(string ContainerName, bool param)
        {
            // Create the CspParameters object and set the key container 
            // name used to store the RSA key pair.
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = ContainerName;

            RSAParameters rsaKeyInfo;

            // Create a new instance of RSACryptoServiceProvider that accesses
            // the key container MyKeyContainerName.
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            // Display the key information to the console.
            Console.WriteLine("Key retrieved from container : \n {0}", rsa.ToXmlString(true));

            rsaKeyInfo = rsa.ExportParameters(param);

            return rsaKeyInfo;
        }

        public static void DeleteKeyFromContainer(string ContainerName)
        {
            // Create the CspParameters object and set the key container 
            // name used to store the RSA key pair.
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = ContainerName;

            // Create a new instance of RSACryptoServiceProvider that accesses
            // the key container.
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            // Delete the key entry in the container.
            rsa.PersistKeyInCsp = false;

            // Call Clear to release resources and delete the key from the container.
            rsa.Clear();

            Console.WriteLine("Key deleted.");
        }

        public byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                //RSA = GetKeyFromContainer("POS_CONTAINER");
                //Create a new instance of RSACryptoServiceProvider.
                //using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    //Import the RSA Key information. This only needs
                    //toinclude the public key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Encrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
                }
                return encryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }

        }

        public byte[] RSAEncrypt(byte[] DataToEncrypt, bool DoOAEPPadding, RSACryptoServiceProvider rsaProvider)
        {
            try
            {
                byte[] encryptedData;
                //RSA = GetKeyFromContainer("POS_CONTAINER");
                //Create a new instance of RSACryptoServiceProvider.
                //using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    //Encrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    encryptedData = rsaProvider.Encrypt(DataToEncrypt, DoOAEPPadding);
                }
                return encryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
        }

        public byte[] RSADecrypt(byte[] DataToDecrypt, bool DoOAEPPadding, RSACryptoServiceProvider rsaProvider)
        {
            try
                {
                    byte[] decryptedData;
                    //RSA = GetKeyFromContainer("POS_CONTAINER");
                    //Create a new instance of RSACryptoServiceProvider.
                    //using ()
                    {
                        //Import the RSA Key information. This needs
                        //to include the private key information.

                        //Decrypt the passed byte array and specify OAEP padding.  
                        //OAEP padding is only available on Microsoft Windows XP or
                        //later.  
                        decryptedData = rsaProvider.Decrypt(DataToDecrypt, DoOAEPPadding);
                    }
                    return decryptedData;
                }
                //Catch and display a CryptographicException  
                //to the console.
                catch (CryptographicException e)
                {
                    Console.WriteLine(e.ToString());

                    return null;
                }
        }

        public byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                //RSA = GetKeyFromContainer("POS_CONTAINER");
                //Create a new instance of RSACryptoServiceProvider.
                //using ()
                {
                    //Import the RSA Key information. This needs
                    //to include the private key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Decrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
                }
                return decryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }

        }

        public void readProcessorID()
        {
            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_processor");
            mbsList = mbs.Get();
            string id = "";
            foreach (ManagementObject mo in mbsList)
            {
                id = mo["ProcessorID"].ToString();
            }

            processorID.Text = id;

        }

        public void readHDD_ID()
        {
            string drive = Path.GetPathRoot(Environment.SystemDirectory);//"C";
            drive = drive.Substring(0, 1);

            ManagementObject dsk = new ManagementObject(
                @"win32_logicaldisk.deviceid=""" + drive + @":""");
            dsk.Get();
            string volumeSerial = dsk["VolumeSerialNumber"].ToString();

            HDD_ID.Text = volumeSerial;
        }

        private void saveLicenseFile(string textToEncrypt, string filePath)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            try
            {
                byte[] dataToEncrypt = ByteConverter.GetBytes(textToEncrypt);
                byte[] encryptedData;
                RSAParameters rsaKeyInfo = GetKeyFromContainer(containerName.Text, false);

                encryptedData = RSAEncrypt(dataToEncrypt, rsaKeyInfo, false);
                File.WriteAllBytes(filePath, encryptedData);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void loadLicenseFile(string filePath)
        {
            byte[] encryptedData;
            byte[] decryptedData;
            RSAParameters rsaKeyInfo = GetKeyFromContainer(containerName.Text, true);

            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            try
            {
                    encryptedData = File.ReadAllBytes(filePath);
                    decryptedData = RSADecrypt(encryptedData, rsaKeyInfo, false);

                    decryptedString.Text = ByteConverter.GetString(decryptedData);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //saveLicenseFile(originalString.Text, saveFileDialog1.FileName);
                saveLicenseFile(originalString.Text,  filePath + "\\license.lic");
                MessageBox.Show("DONE");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readHDD_ID();
            readProcessorID();

            originalString.Text = processorID.Text + HDD_ID.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loadLicenseFile(openFileDialog1.FileName);
                MessageBox.Show("DONE");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            GenKey_SaveInContainer(containerName.Text);
            MessageBox.Show("KEYS ARE SAVED TO CONTAINER ["+ containerName.Text + "]");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteKeyFromContainer(containerName.Text);
        }

        private void generateNewKeyPair()
        {
            CspParameters cspParams = null;
            RSACryptoServiceProvider rsaProvider = null;
            StreamWriter publicKeyFile = null;
            StreamWriter privateKeyFile = null;
            string publicKey = "";
            string privateKey = "";

            try
            {
                // Create a new key pair on target CSP
                cspParams = new CspParameters();
                cspParams.ProviderType = 1; // PROV_RSA_FULL
                //cspParams.ProviderName; // CSP name
                cspParams.Flags = CspProviderFlags.UseArchivableKey;
                cspParams.KeyNumber = (int)KeyNumber.Exchange;
                rsaProvider = new RSACryptoServiceProvider(cspParams);

                // Export public key
                publicKey = rsaProvider.ToXmlString(false);

                // Write public key to file
                publicKeyFile = File.CreateText("publicKey.xml");
                publicKeyFile.Write(publicKey);

                // Export private/public key pair
                privateKey = rsaProvider.ToXmlString(true);

                // Write private/public key pair to file
                privateKeyFile = File.CreateText("privateKey.xml");
                privateKeyFile.Write(privateKey);
            }
            catch (Exception ex)
            {
                // Any errors? Show them
                //Console.WriteLine("Exception generating a new key pair!More info:");
                //Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Do some clean up if needed
                if (publicKeyFile != null)
                {
                    publicKeyFile.Close();
                }
                if (privateKeyFile != null)
                {
                    privateKeyFile.Close();
                }
            }
        }

        private void createVolumeLicenseFile(string filePath)
        {
            string textToEncrypt = "";
            byte[] dataToEncrypt;
            byte[] encryptedData;
            RSACryptoServiceProvider rsaProvider = null;
            StreamReader publicKeyFile = null;
            string publicKeyText = "";
            CspParameters cspParams = null;

            if (generateKeyPair.Checked)
            {
                generateNewKeyPair();
            }

            // Import public key
            // Select target CSP
            cspParams = new CspParameters();
            cspParams.ProviderType = 1; // PROV_RSA_FULL

            rsaProvider = new RSACryptoServiceProvider(cspParams);

            // Read public key from file
            publicKeyFile = File.OpenText("publicKey.xml");
            publicKeyText = publicKeyFile.ReadToEnd();

            // Import public key
            rsaProvider.FromXmlString(publicKeyText);
            
            // GET ORIGINAL STRING, USE '#' FOR DELIMITER
            textToEncrypt = keywordTextBox.Text + "#" + registeredNameTextBox.Text + "#" + registeredAddressTextBox.Text;
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            try
            {
                dataToEncrypt = ByteConverter.GetBytes(textToEncrypt);
                encryptedData = RSAEncrypt(dataToEncrypt, false, rsaProvider);
                File.WriteAllBytes(filePath + "license.lic", encryptedData);
                File.Copy("privateKey.xml", filePath + "privateKey.xml");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void loadVolumeLicenseFile(string filePath)
        {
            byte[] encryptedData;
            byte[] decryptedData;
            CspParameters cspParams = null;
            RSACryptoServiceProvider rsaProvider = null;
            StreamReader privateKeyFile = null;
            string privateKeyText = "";
            // Select target CSP
            cspParams = new CspParameters();
            cspParams.ProviderType = 1; // PROV_RSA_FULL

            //cspParams.ProviderName; // CSP name
            rsaProvider = new RSACryptoServiceProvider(cspParams);

            // Read private/public key pair from file
            privateKeyFile = File.OpenText("privateKey.xml");
            privateKeyText = privateKeyFile.ReadToEnd();

            // Import private/public key pair
            rsaProvider.FromXmlString(privateKeyText);

            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            try
            {
                encryptedData = File.ReadAllBytes(filePath);
                decryptedData = RSADecrypt(encryptedData, false, rsaProvider);

                string[] decryptedText = ByteConverter.GetString(decryptedData).Split('#') ;

                decryptedNameTextBox.Text = decryptedText[1];
                decryptedAddressTextBox.Text = decryptedText[2];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            string filePath =  Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AlphaSoft\\";

            if (!Directory.Exists(filePath))
            { 
                Directory.CreateDirectory(filePath);
            }

            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
               // filePath = saveFileDialog1.FileName;
                //saveLicenseFile(originalString.Text, saveFileDialog1.FileName);
                createVolumeLicenseFile(filePath);
                MessageBox.Show("DONE");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loadVolumeLicenseFile(openFileDialog1.FileName);
                MessageBox.Show("DONE");
            }
        }
    }
}
