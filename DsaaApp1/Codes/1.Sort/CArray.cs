using System;
using System.Text;

namespace DsaaApp1.Codes._1.Sort
{
    public class CArray : TestBedBase
    {
        private int[] _arr;

        public CArray(IUiUpdater uiUpdater, int size, bool insertRandomNumbers) : base(uiUpdater)
        {
            Reset(size);

            if (!insertRandomNumbers)
                return;

            AddRrandomNumbers();
        }

        public void Reset(int size)
        {
            _arr = new int[size];
        }

        private void AddRrandomNumbers()
        {
            var rnd = new Random(100);
            for (var i = 0; i < 10; i++)
                Insert(rnd.Next(1, 100));
        }

        public void SelectionSort()
        {
            var upper = _arr.GetUpperBound(0);
            for (var outer = 0; outer <= upper; outer++)
            {
                var min = outer;
                for (var inner = outer + 1; inner <= upper; inner++)
                    if (_arr[inner] < _arr[min])
                        min = inner;

                var temp = _arr[outer];
                _arr[outer] = _arr[min];
                _arr[min] = temp;
                DisplayElements();
            }
        }

        public void Insert(int item)
        {
            var numElements = _arr.Length;
            Array.Resize(ref _arr, numElements + 1);
            _arr[numElements] = item;
        }

        public void DisplayElements()
        {
            var builder = new StringBuilder();
            var upper = _arr.GetUpperBound(0);
            for (var i = 0; i <= upper; i++)
                builder.Append(_arr[i] + " ");
            builder.AppendLine();
            UiUpdater.UpdateUi(builder.ToString(), true);
        }

        public void Clear()
        {
            var upper = _arr.GetUpperBound(0);
            for (var i = 0; i <= upper; i++)
                _arr[i] = 0;
        }
    }
}