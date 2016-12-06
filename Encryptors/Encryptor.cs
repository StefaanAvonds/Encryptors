using Encryptors.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryptors
{
    public partial class Encryptor : Form
    {
        public Encryptor()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Encryptor_Load(object sender, EventArgs e)
        {
            cmbEncryption.DataSource = Enum.GetValues(typeof(EncryptingMethods));
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            EncryptingMethods selectedEnum;
            Enum.TryParse(cmbEncryption.SelectedValue.ToString(), out selectedEnum);

            txtResult.Text = App.EncryptionManager.EncryptText(txtText.Text, selectedEnum);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            EncryptingMethods selectedEnum;
            Enum.TryParse(cmbEncryption.SelectedValue.ToString(), out selectedEnum);

            txtResult.Text = App.EncryptionManager.DecryptText(txtText.Text, selectedEnum);
        }
    }
}
