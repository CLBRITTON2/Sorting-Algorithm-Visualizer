using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SortingAlgorithmVisualizer
{
    internal class MergeSort : ISortingEngine
    {
        private int[] _arrayToBeSorted;
        private Graphics _sortingGraphics;
        private int _maxNumberValue;

        Brush numberBrush = new SolidBrush(Color.Red);
        Brush backgroundBrush = new SolidBrush(Color.White);
        Brush finishBrush = new SolidBrush(Color.Green);

        public MergeSort(int[] arrayToBeSorted, Graphics sortingGraphics, int maxNumberValue)
        {
            _arrayToBeSorted = arrayToBeSorted;
            _sortingGraphics = sortingGraphics;
            _maxNumberValue = maxNumberValue;
        }

        public void NextSortingStep()
        {
            StartMergeSort(_arrayToBeSorted, 0, _arrayToBeSorted.Count() - 1);
        }
        private void StartMergeSort(int[] arrayToBeSorted, int leftSide, int rightSide)
        {
            if (leftSide < rightSide)
            {
                int midPoint = (leftSide + rightSide) / 2;

                // Recursion
                StartMergeSort(arrayToBeSorted, leftSide, midPoint);
                StartMergeSort(arrayToBeSorted, midPoint + 1, rightSide);

                Merge(arrayToBeSorted, leftSide, midPoint, rightSide);
            }
        }
        private void Merge(int[] arrayToBeSorted, int leftSide, int midPoint, int rightSide)
        {
            int[] leftArray = new int[midPoint - leftSide + 1];
            int[] rightArray = new int[rightSide - midPoint];

            Array.Copy(arrayToBeSorted, leftSide, leftArray, 0, midPoint - leftSide + 1);
            Array.Copy(arrayToBeSorted, midPoint + 1, rightArray, 0, rightSide - midPoint);

            int i = 0; // Left array index
            int j = 0; // Right array index
            // K = arrayToBeSorted index
            for(int k = leftSide; k < rightSide + 1; k++) 
            {
                if (i == leftArray.Length)
                {
                    arrayToBeSorted[k] = rightArray[j];
                    DrawNumber(k, arrayToBeSorted[k]);
                    Thread.Sleep(1);
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    arrayToBeSorted[k] = leftArray[i];
                    DrawNumber(k, arrayToBeSorted[k]);
                    Thread.Sleep(1);
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    arrayToBeSorted[k] = leftArray[i];
                    DrawNumber(k, arrayToBeSorted[k]);
                    Thread.Sleep(1);
                    i++;
                }
                else
                {
                    arrayToBeSorted[k] = rightArray[j];
                    DrawNumber(k, arrayToBeSorted[k]);
                    Thread.Sleep(1);
                    j++;
                }
            }
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
