using System;
using System.Text;

namespace DsaaApp1.Codes._1.Sort
{
    public class CArray : TestBedBase
    {
        private readonly int[] _arr;
        private readonly int _upper;
        private int _numElements;

        public CArray(IUiUpdater uiUpdater, int size, bool insertRandomNumbers) : base(uiUpdater)
        {
            _arr = new int[size];
            _upper = size - 1;
            _numElements = 0;

            if (!insertRandomNumbers) return;
            var rnd = new Random(100);
            for (var i = 0; i < 10; i++)
                Insert(rnd.Next(1, 100));
        }

        public void Insert(int item)
        {
            _arr[_numElements] = item;
            _numElements++;
        }

        public void DisplayElements()
        {
            var builder = new StringBuilder();
            for (var i = 0; i <= _upper; i++)
                builder.Append(_arr[i] + " ");
            UiUpdater.UpdateUi(builder.ToString(), true);
        }

        public void Clear()
        {
            for (var i = 0; i <= _upper; i++) _arr[i] = 0;
            _numElements = 0;
        }
    }
}