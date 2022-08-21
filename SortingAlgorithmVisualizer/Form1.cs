using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SortingAlgorithmVisualizer
{
    public partial class Form1 : Form
    {
        int[] arrayToBeSorted;
        Graphics sortingGraphics;
        BackgroundWorker backgroundWorker = null;
        bool sortIsPaused = false;
        public Form1()
        {
            InitializeComponent();
            PopulateDropdownMenu();
        }
        private void PopulateDropdownMenu()
        {
            // If a class is using the sort engine interface, get the names of those classes
            // Cast the names to a list, put them in the SortingClassList, sort alphabetically
            // Populate drop down list with names on the list
            // Exclude the interface/abstract classes

            List<string> SortingClassList = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                .Where(x => typeof(ISortingEngine).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(x => x.Name).ToList();

            SortingClassList.Sort();
            foreach (var classUsingSortInterface in SortingClassList)
            {
                AlgorithmComboBox.Items.Add(classUsingSortInterface);
            }
            AlgorithmComboBox.SelectedIndex = 0;
        }
        private void SortButton_Click(object sender, EventArgs e)
        {
            if (arrayToBeSorted == null)
            {
                PopulateNumbersButton_Click(null, null);
            }
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += new DoWorkEventHandler(BackGroundWorkerDoWork);
            backgroundWorker.RunWorkerAsync(argument: AlgorithmComboBox.SelectedItem);
        }
        private void PauseResumeButton_Click(object sender, EventArgs e)
        {
            if (!sortIsPaused)
            {
                backgroundWorker.CancelAsync();
                sortIsPaused = true;
            }
            else
            {
                if (backgroundWorker.IsBusy)
                {
                    return;
                }
                int numberEntries = MainSortingPanel.Width;
                int maxNumberValue = MainSortingPanel.Height;
                sortIsPaused = false;
                for (int i = 0; i < numberEntries; i++)
                {
                    sortingGraphics.FillRectangle(new SolidBrush(Color.White), i, 0, 1, maxNumberValue);
                    sortingGraphics.FillRectangle(new SolidBrush(Color.Red), i, maxNumberValue - arrayToBeSorted[i], 1, maxNumberValue);
                }
                backgroundWorker.RunWorkerAsync(argument: AlgorithmComboBox.SelectedItem);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateNumbersButton_Click(object sender, EventArgs e)
        {
            sortingGraphics = MainSortingPanel.CreateGraphics();
            int numberEntries = MainSortingPanel.Width;
            int maxNumberValue = MainSortingPanel.Height;
            arrayToBeSorted = new int[numberEntries];
            sortingGraphics.FillRectangle(new SolidBrush(Color.White), 0, 0, numberEntries, maxNumberValue);

            for (int i = 0; i < numberEntries; i++)
            {
                arrayToBeSorted[i] = RandomNumberGenerator.NumberBetween(0, maxNumberValue);
            }

            for (int i = 0; i < numberEntries; i++)
            {
                sortingGraphics.FillRectangle(new SolidBrush(Color.Red), i, maxNumberValue - arrayToBeSorted[i], 1, maxNumberValue);
            }
        }
        public void BackGroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker secondBackgroundWorker = sender as BackgroundWorker;
            string SortEngineName = (string)e.Argument;
            Type type = Type.GetType("SortingAlgorithmVisualizer." + SortEngineName);
            var constructors = type.GetConstructors();
            try
            {
                // Create sort engine, call constructor, pass the list of parameters to the constructor 
                ISortingEngine sortEngine = (ISortingEngine)constructors[0].Invoke(new object[] { arrayToBeSorted, sortingGraphics, MainSortingPanel.Height });
                while (!sortEngine.SortIsComplete() && (!backgroundWorker.CancellationPending))
                {
                    sortEngine.NextSortingStep();
                }
                if(sortEngine.SortIsComplete())
                {
                    sortEngine.DrawSortedNumbers();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
