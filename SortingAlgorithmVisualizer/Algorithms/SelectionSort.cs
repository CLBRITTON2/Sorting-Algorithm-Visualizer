using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SortingAlgorithmVisualizer
{
    internal class SelectionSort : ISortingEngine
    {
        private int[] _arrayToBeSorted;
        private Graphics _sortingGraphics;
        private int _maxNumberValue;

        Brush numberBrush = new SolidBrush(Color.Red);
        Brush backgroundBrush = new SolidBrush(Color.White);
        Brush finishBrush = new SolidBrush(Color.Green);

        public SelectionSort(int[] arrayToBeSorted, Graphics sortingGraphics, int maxNumberValue)
        {
            _arrayToBeSorted = arrayToBeSorted;
            _sortingGraphics = sortingGraphics;
            _maxNumberValue = maxNumberValue;
        }

        public void NextSortingStep()
        {
            for (int i = 0; i < _arrayToBeSorted.Count() - 1; i++)
            {
                int smallestNumber = FindSmallestNumber(_arrayToBeSorted, i);
                int temporaryContainer = _arrayToBeSorted[i];

                _arrayToBeSorted[i] = _arrayToBeSorted[smallestNumber];
                DrawNumber(i, _arrayToBeSorted[smallestNumber]);
                Thread.Sleep(1);

                _arrayToBeSorted[smallestNumber] = temporaryContainer;
                DrawNumber(smallestNumber, temporaryContainer);
                Thread.Sleep(1);
            }
        }
        private int FindSmallestNumber(int[] arrayToBeSorted, int k)
        {
            int smallestNumber = k;
            int smallestNumberIndex = arrayToBeSorted[k];
            for (int i = k + 1; i < arrayToBeSorted.Count(); i++)
            {
                if (arrayToBeSorted[i] < smallestNumberIndex)
                {
                    smallestNumber = i;
                    smallestNumberIndex = arrayToBeSorted[i];
                }
            }
            return smallestNumber;
        }
        private void DrawNumber(int position, int height)
        {
            _sortingGraphics.FillRectangle(backgroundBrush, position, 0, 1, _maxNumberValue);
            _sortingGraphics.FillRectangle(numberBrush, position, _maxNumberValue - _arrayToBeSorted[position], 1, _maxNumberValue);
        }
        public bool SortIsComplete()
        {
            for (int i = 0; i < _arrayToBeSorted.Count() - 1; i++)
            {
                if (_arrayToBeSorted[i] > _arrayToBeSorted[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        public void DrawSortedNumbers()
        {
            for (int i = 0; i < (_arrayToBeSorted.Count() - 1); i++)
            {
                _sortingGraphics.FillRectangle(finishBrush, i, _maxNumberValue - _arrayToBeSorted[i], 1, _maxNumberValue);
            }
        }
    }
}
