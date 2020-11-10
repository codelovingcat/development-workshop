using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace qr_code_barcode
{
    public partial class QRBarcode : Form
    {
        public QRBarcode()
        {
            InitializeComponent();
        }


        private void btnQR_Click(object sender, EventArgs e)
        {
            QRCodeEncoder qRCode = new QRCodeEncoder();
            pictureBox1.Image = qRCode.Encode(textBoxQR.Text);
        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcodeDraw = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox2.Image = barcodeDraw.Draw(textBoxBarcode.Text,100);
        }

        private void btnQrback_Click(object sender, EventArgs e)
        {
            QRCodeDecoder qRCode = new QRCodeDecoder();
            textBoxQR.Text = qRCode.Decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap));
        }
    }
}
