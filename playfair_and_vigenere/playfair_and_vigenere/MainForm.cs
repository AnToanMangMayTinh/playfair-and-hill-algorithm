using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace playfair_and_vigenere
{
    public partial class MainForm : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            rbtn5x5.Checked = true;
        }

        string strPlainText;
        List<string> lsPlainString, lsCipherString;
        string strKey = "";


        #region Playfair

        char[,] cMatrix; // ma trận mã
             
        int iChoseMatrix = 0; // == 5 là matrix 5x5; == 6 là matrix 6x6
        
        //hàm xử lý chuỗi ban đầu (tách chuỗi ban đầu thành từng cặp ký tự );
        private void XuLyChuoiPlayfair(string strPlainText, ref List<string> lsString)
        {
            string[] strPlainText1 = strPlainText.Split(' ');
            string strNewPlainText = "";
            lsString = new List<string>();
            int i = 0, j = 0;

            foreach (string str in strPlainText1)
            {
                strNewPlainText += str;
            }

            int iLength = strNewPlainText.Length; // chiều dài plaintext khi không có space

            while (iLength != 0)
            {
                string str = strNewPlainText.Substring(i, 2);
                if (str.Substring(0, 1) == str.Substring(1, 1))
                {
                    strNewPlainText = strNewPlainText.Substring(0, i + 1) + "X" + strNewPlainText.Substring(i + 1);
                    str = strNewPlainText.Substring(i, 2);
                }

                lsString.Add(str);

                i += 2;
                iLength = strNewPlainText.Substring(i).Length;
                if (iLength == 1)
                    strNewPlainText += "X";
                Console.WriteLine(lsString[j]);
                j++;
            }
            txtPlainTextAfter.Text = ShowText(lsString);
        }

        // Hàm kiểm tra các ký tự trong ma trận
        private int CheckMatrix(char iChar, char[,] cKey)
        {
            for (int iHang = 0; iHang < iChoseMatrix; iHang++)
            {
                for (int iCot = 0; iCot < iChoseMatrix; iCot++)
                {
                    if (iChoseMatrix == 5)
                    {
                        if ((cKey[iHang, iCot] == 'I' && iChar == 'J') || (cKey[iHang, iCot] == 'J' && iChar == 'I'))
                            return 0;
                    }

                    if (cKey[iHang, iCot] == iChar)
                        return 0; // bị trùng ký tự

                    if (cKey[iHang, iCot] == '\0')
                        return 1; // không bị trùng ký tự hoặc chưa có ký tự nào trong ma trận
                }
            }
            return 1;
        }
        
        // Hàm tạo ma trận mã, với key nhập vào ban đầu
        private void CreateMatrix()
        {
            cMatrix = new char[6, 6]; // ma trận mã
            int iNumchar = 0;// số thứ của tự ký tự trong chuỗi
            int iChar = 65; //A
            flptxt.Controls.Clear();
            Console.WriteLine(strKey);

            for (int iHang = 0; iHang < iChoseMatrix; iHang++)
            {
                for (int iCot = 0; iCot < iChoseMatrix; iCot++)
                {
                    end:
                    if (iNumchar < strKey.Length)
                    {
                        while (CheckMatrix(strKey[iNumchar], cMatrix) == 0)// nếu ký tự đã có trong ma trận
                        {
                            //thì bỏ qua ký tự đó
                            iNumchar++;
                            if (iNumchar >= strKey.Length)
                                goto end;
                        }
                        cMatrix[iHang, iCot] = strKey[iNumchar];
                        iNumchar++;
                    }
                    else
                    {
                        while (CheckMatrix((char)iChar, cMatrix) == 0)
                        {
                            iChar++;
                        }
                        if (iChoseMatrix == 6 && iChar > 90) //90: Z
                        {
                            iChar = 48; //48: 0
                        }
                        cMatrix[iHang, iCot] = (char)iChar;
                        iChar++;
                    }

                    flptxt.Controls.Add(CreateTextBox(cMatrix[iHang, iCot]));
                    Console.WriteLine(cMatrix[iHang, iCot]);
                }
            }
        }

        // Hàm tạo các textbox để hiển thị ma trận
        private TextBox CreateTextBox(char cASCII)
        {
            TextBox txtMatrix = new TextBox();
            txtMatrix.Name = "txtMatrix" + cASCII;

            if (iChoseMatrix == 5)
            {
                txtMatrix.Size = new Size(40, 40);
            }
            else
            {
                txtMatrix.Size = new Size(35, 35);
            }
            txtMatrix.Font = new Font("Microsoft Sans Serif", 14);
            txtMatrix.TextAlign = HorizontalAlignment.Center;
            txtMatrix.Enabled = false;
            txtMatrix.Text = cASCII.ToString();
            //grbMatrixKey.Controls.Add(txtMatrix);
            return txtMatrix;
        }

        //hàm hiện thực mã hóa
        private void EncryptPlayfair(char[,] cMatrix)
        {
            lsPlainString = new List<string>(); // list plaintext đã tách
            lsCipherString = new List<string>(); // list ciphertext
            XuLyChuoiPlayfair(strPlainText, ref lsPlainString); //tách chuỗi Plaintext
            int[] iLoc1 = new int[2]; //lưu tọa độ của ký tự trong ma trận iLoc[0]: vị trí hàng, iLoc[1]: vị trí cột
            int[] iLoc2 = new int[2];
            foreach (string str in lsPlainString)
            {
                string str1 = str.Substring(0, 1);
                ViTri(Convert.ToChar(str1), cMatrix, ref iLoc1);
                string str2 = str.Substring(1, 1);
                ViTri(Convert.ToChar(str2), cMatrix, ref iLoc2);
                if (iLoc1[0] == iLoc2[0]) // Nếu plainchar cùng 1 hàng
                {
                    iLoc1[1] = (iLoc1[1] + 1) % iChoseMatrix;
                    iLoc2[1] = (iLoc2[1] + 1) % iChoseMatrix;
                }
                else
                {
                    if (iLoc1[1] == iLoc2[1]) //Nếu PlainChar cùng 1 cột
                    {
                        iLoc1[0] = (iLoc1[0] + 1) % iChoseMatrix;
                        iLoc2[0] = (iLoc2[0] + 1) % iChoseMatrix;
                    }
                    else
                    {
                        int iTemp = iLoc1[1];
                        iLoc1[1] = iLoc2[1];
                        iLoc2[1] = iTemp;
                    }
                }


                str1 = cMatrix[iLoc1[0], iLoc1[1]].ToString();
                str2 = cMatrix[iLoc2[0], iLoc2[1]].ToString();
                lsCipherString.Add(str1 + str2);
                Console.WriteLine(str1 + str2);
            }
            txtCipherText.Text = ShowText(lsCipherString);
        }

        // hàm tìm vị trí của ký tự trong ma trận
        private int ViTri(char cPlainChar, char[,] cMatrix, ref int[] iLoc)
        {

            for (int iHang = 0; iHang < iChoseMatrix; iHang++)
            {
                for (int iCot = 0; iCot < iChoseMatrix; iCot++)
                {
                    if (cPlainChar == cMatrix[iHang, iCot])
                    {
                        iLoc[0] = iHang;
                        iLoc[1] = iCot;
                        return 0;
                    }
                }
            }
            return 1;
        }

        //hàm hiện thực giải mã
        private void DecryptPlayfair(char[,] cMatrix)
        {
            lsPlainString = new List<string>(); // list plaintext đã tách
            lsCipherString = new List<string>(); // list ciphertext 
            XuLyChuoiPlayfair(strPlainText, ref lsPlainString); //tách chuỗi Plaintext
            int[] iLoc1 = new int[2]; //lưu tọa độ của ký tự trong ma trận iLoc[0]: vị trí hàng, iLoc[1]: vị trí cột
            int[] iLoc2 = new int[2];
            foreach (string str in lsPlainString)
            {
                string str1 = str.Substring(0, 1);
                ViTri(Convert.ToChar(str1), cMatrix, ref iLoc1);
                string str2 = str.Substring(1, 1);
                ViTri(Convert.ToChar(str2), cMatrix, ref iLoc2);
                if (iLoc1[0] == iLoc2[0]) // Nếu plainchar cùng 1 hàng
                {
                    iLoc1[1] = (iLoc1[1] + 4) % iChoseMatrix;
                    iLoc2[1] = (iLoc2[1] + 4) % iChoseMatrix;
                }
                else
                {
                    if (iLoc1[1] == iLoc2[1]) //Nếu PlainChar cùng 1 cột
                    {
                        iLoc1[0] = (iLoc1[0] + 4) % iChoseMatrix;
                        iLoc2[0] = (iLoc2[0] + 4) % iChoseMatrix;
                    }
                    else
                    {
                        int iTemp = iLoc1[1];
                        iLoc1[1] = iLoc2[1];
                        iLoc2[1] = iTemp;
                    }
                }

                str1 = cMatrix[iLoc1[0], iLoc1[1]].ToString();
                str2 = cMatrix[iLoc2[0], iLoc2[1]].ToString();
                lsCipherString.Add(str1 + str2);
                Console.WriteLine(str1 + str2);
            }

            txtCipherText.Text = ShowText(lsCipherString);
        }

        private void txtKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kiểm tra ký tự nhập vào có phải là số hay không
            //do ma trận mã 5x5 không mã hóa được ký tự số
            if ((Char.IsDigit(e.KeyChar) && rbtn5x5.Checked ) || Char.IsWhiteSpace(e.KeyChar) )
                e.Handled = true;
            
        }

        private void rbtn6x6_CheckedChanged(object sender, EventArgs e)
        {
            iChoseMatrix = 6;
            CreateMatrix();
        }

        private void rbtn5x5_CheckedChanged(object sender, EventArgs e)
        {
            iChoseMatrix = 5;
            CreateMatrix();
        }

        private void txtKey_TextChanged_1(object sender, EventArgs e)
        {
            strKey = txtKey.Text.ToUpper();
            CreateMatrix();
            if(strKey.Length > 1)
            {
                btnDecrypt.Enabled = true;
                btnEncrypt.Enabled = true;
            }
            else
            {
                btnDecrypt.Enabled = false;
                btnEncrypt.Enabled = false;
            }
        }

        private void txtPlainText_TextChanged(object sender, EventArgs e)
        {
            strPlainText = txtPlainText.Text.ToUpper();
        }

        private void btnEncrypt_Click_1(object sender, EventArgs e)
        {
            EncryptPlayfair(cMatrix);

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            DecryptPlayfair(cMatrix);
        }
        #endregion

        #region Vigenere

        List<string> lsAlphabet = new List<string>(); 
        private void createAlphabet ()
        {
            for (int ichar = 65; ichar < 91; ichar++)
            {
                lsAlphabet.Add(Convert.ToChar(ichar).ToString());
            }
        }

        private void xuLyChuoiVige(ref List<string> lsString)
        {
            strPlainText = this.txtPlainVige.Text.ToUpper();
            string[] strPlainText1 = strPlainText.Split(' ');
            string strNewPlainText = "";
            lsString = new List<string>();
            int i = 0;
            
            int iLengthKey = txtKeyVige.Text.Length;

            foreach (string str in strPlainText1)
            {
                strNewPlainText += str;
            }

            int iLength = strNewPlainText.Length;

            while (iLength != 0)
            {
                string str;
                if (iLength >= iLengthKey)
                {
                    str = strNewPlainText.Substring(i, iLengthKey);
                    i += iLengthKey;                    
                }
                else
                {
                    str = strNewPlainText.Substring(i);
                    i += str.Length;
                }

                iLength -= str.Length ;
                lsString.Add(str);

               
            }
            txtAfterVige.Text = ShowText(lsString);
        }

        private void encryptVige()
        {
            strKey = txtKeyVige.Text.ToUpper();
            lsCipherString = new List<string>();
            lsPlainString = new List<string>();

            xuLyChuoiVige(ref lsPlainString);

            foreach (string strPlain in lsPlainString)
            {
                string strCipher = "";
                for( int i = 0; i < strPlain.Length; i++)
                {
                    int index = (lsAlphabet.IndexOf(strKey[i].ToString()) + lsAlphabet.IndexOf(strPlain[i].ToString())) % 26;
                    strCipher += lsAlphabet[index];
                }
                lsCipherString.Add(strCipher);
            }

            txtResultVige.Text = ShowText(lsCipherString);
        }

        private void btnEncryptVige_Click(object sender, EventArgs e)
        {
            encryptVige();
        }

        private void txtKeyVige_TextChanged(object sender, EventArgs e)
        {
            createAlphabet();
            strKey = txtKeyVige.Text.ToUpper();
            if (strKey.Length > 0)
            {
                btnDecryptVige.Enabled = true;
                btnEncryptVige.Enabled = true;
            }
            else
            {
                btnDecryptVige.Enabled = false;
                btnEncryptVige.Enabled = false ;
            }
        }

        private void txtPlainVige_TextChanged(object sender, EventArgs e)
        {
            strPlainText = txtPlainVige.Text.ToUpper();
        }

        private void decryptVige()
        {
            strKey = txtKeyVige.Text.ToUpper();
            lsCipherString = new List<string>();
            lsPlainString = new List<string>();

            xuLyChuoiVige(ref lsPlainString);

            foreach (string strPlain in lsPlainString)
            {
                string strCipher = "";
                for (int i = 0; i < strPlain.Length; i++)
                {
                    int index = (lsAlphabet.IndexOf(strPlain[i].ToString()) + 26) - lsAlphabet.IndexOf(strKey[i].ToString());
                    strCipher += lsAlphabet[index];
                }
                lsCipherString.Add(strCipher);
            }

            txtResultVige.Text = ShowText(lsCipherString);
        }

        private void btnDecryptVige_Click(object sender, EventArgs e)
        {
            decryptVige();
        }

        private void txtKeyVige_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }


        #endregion

        //hàm hiển thị ciphertext và plaintext đã tách
        private string ShowText(List<string> lsText)
        {
            string text = "";
            foreach (string str in lsText)
                text += str + " ";
            return text;
        }

    }
}