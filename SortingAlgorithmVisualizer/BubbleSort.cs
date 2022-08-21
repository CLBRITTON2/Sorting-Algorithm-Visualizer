using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;

namespace SortingAlgorithmVisualizer
{
    internal class BubbleSort : ISortingEngine
    {
        private int[] _arrayToBeSorted;
        private Graphics _sortingGraphics;
        private int _maxNumberValue;

        Brush redBrush = new SolidBrush(Color.Red);
        Brush whiteBrush = new SolidBrush(Color.White);

        public BubbleSort(int[] arrayToBeSorted, Graphics sortingGraphics, int maxNumberValue)
        {
            _arrayToBeSorted = arrayToBeSorted;
            _sortingGraphics = sortingGraphics;
            _maxNumberValue = maxNumberValue;
        }

        public void NextSortingStep()
        {
            for (int i = 0; i < _arrayToBeSorted.Count() - 1; i++)
            {
                if (_arrayToBeSorted[i] > _arrayToBeSorted[i + 1])
                {
                    Switch(i, i + 1);
                }               
            }
        }
        private void Switch(int i, int j)
        {
            int temporaryContainer = _arrayToBeSorted[i];
            _arrayToBeSorted[i] = _arrayToBeSorted[i + 1];
            _arrayToBeSorted[i + 1] = temporaryContainer;

            // Painting values before and after the switch
            DrawNumberRepresentations(i, _arrayToBeSorted[i]);
            DrawNumberRepresentations(j, _arrayToBeSorted[j]);
        }
        private void DrawNumberRepresentations(int position, int height)
        {
            _sortingGraphics.FillRectangle(whiteBrush, position, 0, 1, _maxNumberValue);
            _sortingGraphics.FillRectangle(redBrush, position, _maxNumberValue - _arrayToBeSorted[position], 1, _maxNumberValue);
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
                _sortingGraphics.FillRectangle(new SolidBrush(Color.Green), i, _maxNumberValue - _arrayToBeSorted[i], 1, _maxNumberValue);
            }
        }
    }
}
