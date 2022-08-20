using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithmVisualizer
{
    public partial class Form1 : Form
    {
        int[] arrayToBeSorted;
        Graphics sortingGraphics;
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TheResetButton_Click(object sender, EventArgs e)
        {
            sortingGraphics = MainSortingPanel.CreateGraphics();
            int numberEntries = MainSortingPanel.Width;
            int maxNumberValue = MainSortingPanel.Height;
            arrayToBeSorted = new int[numberEntries];
            sortingGraphics.FillRectangle(new SolidBrush(Color.Black), 0, 0, numberEntries, maxNumberValue);

            for(int i = 0; i < numberEntries; i++)
            {
                arrayToBeSorted[i] = RandomNumberGenerator.NumberBetween(0, maxNumberValue);
            }

            for(int i = 0; i < numberEntries; i++)
            {
                sortingGraphics.FillRectangle(new SolidBrush(Color.White), i, maxNumberValue - arrayToBeSorted[i], 1, maxNumberValue);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ISortingEngine sortingEngine = new BubbleSortEngine();
            sortingEngine.SortData(arrayToBeSorted, sortingGraphics, MainSortingPanel.Height);
        }
    }
}
