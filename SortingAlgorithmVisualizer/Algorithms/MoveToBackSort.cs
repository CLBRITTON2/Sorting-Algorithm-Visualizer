using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmVisualizer
{
    internal class MoveToBackSort : ISortingEngine
    {
        private int[] _arrayToBeSorted;
        private Graphics _sortingGraphics;
        private int _maxNumberValue;

        Brush numberBrush = new SolidBrush(Color.Red);
        Brush backgroundBrush = new SolidBrush(Color.White);
        Brush finishBrush = new SolidBrush(Color.Green);

        private int _currentListIndex = 0;

        public MoveToBackSort(int[] arrayToBeSorted, Graphics sortingGraphics, int maxNumberValue)
        {
            _arrayToBeSorted = arrayToBeSorted;
            _sortingGraphics = sortingGraphics;
            _maxNumberValue = maxNumberValue;
        }

        public void NextSortingStep()
        {
            if (_currentListIndex >= _arrayToBeSorted.Count() - 1) _currentListIndex = 0;
            if (_arrayToBeSorted[_currentListIndex] > _arrayToBeSorted[_currentListIndex + 1])
            {
                Rotate(_currentListIndex);
            }
            _currentListIndex++;
        }
        private void Rotate(int currentListIndex)
        {
            int temporaryIndex = _arrayToBeSorted[_currentListIndex];
            int endPoint = _arrayToBeSorted.Count() - 1;

            for(int i = _currentListIndex; i < endPoint; i++)
            {
                _arrayToBeSorted[i] = _arrayToBeSorted[i + 1];
                DrawNumber(i, _arrayToBeSorted[i]);
            }

            _arrayToBeSorted[endPoint] = temporaryIndex;
            DrawNumber(endPoint, _arrayToBeSorted[endPoint]);
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
        private void DrawNumber(int position, int height)
        {
            _sortingGraphics.FillRectangle(backgroundBrush, position, 0, 1, _maxNumberValue);
            _sortingGraphics.FillRectangle(numberBrush, position, _maxNumberValue - _arrayToBeSorted[position], 1, _maxNumberValue);
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
