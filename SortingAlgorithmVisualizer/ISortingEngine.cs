using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmVisualizer
{
    internal interface ISortingEngine
    {
        void SortData(int[] arrayToBeSorted, Graphics sortingGraphics, int maxNumberValue);
    }
}
