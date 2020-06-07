using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GraphTranz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createClosure_Click(object sender, EventArgs e)
        {
            OpenFileDialog openGraph = new OpenFileDialog();

            openGraph.InitialDirectory = "D:\\учёба\\Konstr\\GraphTranz";
            openGraph.Filter = "txt files (*.txt)|*.txt";
            openGraph.FilterIndex = 2;
            openGraph.RestoreDirectory = true;

            if (String.IsNullOrEmpty(matrixGraph.Text))
            {
                if (openGraph.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openGraph.FileName;
                    string text = File.ReadAllText(filePath);
                    matrixGraph.AppendText(text);
                }
            }
            string temp = matrixGraph.Text;
            double t = Math.Sqrt((temp.Length + 1) / 2);
            int n = (int)t;


            string[] matrInfo = temp.Split(' ', '\n');
            int[,] matrData = new int[n, n];
            int q = 0;
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    matrData[j, k] = Int32.Parse(matrInfo[q]);
                    q++;
                }
            }

            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (matrData[i, k] != 0 && matrData[k, j] != 0)
                        {
                            matrData[i, j] = 1;
                        }
                    }
                }
            }

            temp = String.Empty;
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    temp += Convert.ToString(matrData[j, k]) + ' ';
                }
                temp += '\n';
            }
            transitClosure.AppendText(temp);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files |*.txt";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {

                using (FileStream fstream = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate))
                {

                    fstream.SetLength(0);
                    byte[] array = System.Text.Encoding.Default.GetBytes(temp);
                    fstream.Write(array, 0, array.Length);
                }

                MessageBox.Show("Сохранено", "Завершение работы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ошибка. Повторите попытку", "Завершение работы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            saveFileDialog1.FileName = "";
        }
    }
}
