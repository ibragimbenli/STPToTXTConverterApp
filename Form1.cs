using System;
using System.IO;
using System.Windows.Forms;

namespace STPToTXTConverterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "STP Files|*.stp";
            openFileDialog.Title = "Step Dosyası Seçiniz!";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string stpFilePath = openFileDialog.FileName;
                string txtFilePath = Path.ChangeExtension(openFileDialog.FileName, ".txt");
                try
                {
                    string stpContents = File.ReadAllText(stpFilePath);

                    File.WriteAllText(txtFilePath, stpContents);

                    MessageBox.Show(".stp dosyası başarıyla .txt'ye dönüştürüldü.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (File.Exists(txtFilePath))
                    {
                        try
                        {
                            using (StreamReader sr = File.OpenText(txtFilePath))
                            {
                                string value;
                                value = sr.ReadLine().Replace(" ", "");
                                while ((value = sr.ReadLine()) != null)
                                {
                                    listBoxContent.Items.Add(value);
                                }
                                sr.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message, "Error");
                        }
                        finally
                        {
                            //Close the StreamReader and delete the text file
                            File.Delete(txtFilePath);
                        }
                    }
                    else
                    {
                        MessageBox.Show("File not found: " + txtFilePath, "Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dönüştürme işlemi başarısız!: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}