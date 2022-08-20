using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmVisualizer
{
    internal class BubbleSortEngine : ISortingEngine
    {
        private bool _arrayIsSorted = false;
        private int[] _arrayToBeSorted;
        private Graphics _sortingGraphics;
        private int _maxNumberValue;

        Brush whiteBrush = new SolidBrush(Color.White);
        Brush blackBrush = new SolidBrush(Color.Black);

        public void SortData(int[] arrayToBeSorted, Graphics sortingGraphics, int maxNumberValue)
        {
            _arrayToBeSorted = arrayToBeSorted;
            _sortingGraphics = sortingGraphics;
            _maxNumberValue = maxNumberValue;

            while (!_arrayIsSorted)
            {
                for(int i = 0; i < arrayToBeSorted.Count() - 1; i++)
                {
                    if (arrayToBeSorted[i] > arrayToBeSorted[i + 1])
                    {
                        Switch(i, i + 1);
                    }
                }
                _arrayIsSorted = SortComplete();
            }
        }
        private bool SortComplete()
        {
            for (int i = 0; i < _arrayToBeSorted.Count() - 1; i++)
            {
                if (_arrayToBeSorted[i] > _arrayToBeSorted[i + 1]) return false;
            }
            return true;
        }
        private void Switch(int i, int j)
        {
            int temporaryContainer = _arrayToBeSorted[i];
            _arrayToBeSorted[i] = _arrayToBeSorted[i + 1];
            _arrayToBeSorted[i + 1] = temporaryContainer;

            // Paint values before switch
            _sortingGraphics.FillRectangle(blackBrush, i, 0, 1, _maxNumberValue);
            _sortingGraphics.FillRectangle(blackBrush, j, 0, 1, _maxNumberValue);

            // Paint values after switch
            _sortingGraphics.FillRectangle(whiteBrush, i, _maxNumberValue - _arrayToBeSorted[i], 1, _maxNumberValue);
            _sortingGraphics.FillRectangle(whiteBrush, j, _maxNumberValue - _arrayToBeSorted[j], 1, _maxNumberValue);
        }
    }
}
