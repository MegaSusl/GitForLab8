using LibForPracticeMine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace winformsForPractice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            PickPaint.Items.AddRange(new string[] { "Акриловая (0.25)", "Масляная (0.20)", "Силиконовая (0.30)" });
            PickPaint.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            if ( Regex.IsMatch(heightBox.Text, @"^\d+$") && Regex.IsMatch(widthBox.Text, @"^\d+$") && Regex.IsMatch(LayersBox.Text, @"^\d+$")) 
            {
                double height = Convert.ToDouble(heightBox.Text);
                double width = Convert.ToDouble(widthBox.Text);
                int layers = Convert.ToInt16(LayersBox.Text);
                double paintRequried = CalcPaint.calculatePaint( height, width, PickPaint.SelectedIndex, layers );

                PaintFinal.Text = paintRequried.ToString() + " (л)";
                paintFinalM.Text = CalcPaint.calculatePaintM(width, height, paintRequried).ToString() + " (л/м2)";
            }
            else
            {
                MessageBox.Show("Вы ввели неверные значения!", "Ошибка!!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
