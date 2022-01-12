using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt2_Podorozhnyi50402
{
    class Sortowanie
    {
        public int SelectSort(ref double[] T)
        {
            int mPK;
            double mPKopiaElementDoWymiany;
            int mPLicznikOD = 0;
            for (int i = 0; i < T.Length - 1; i++)
            {
                mPK = i;

                for (int j = i + 1; j < T.Length; j++)
                {
                    mPLicznikOD++;

                    if (T[mPK] > T[j])
                    {
                        mPK = j;
                    }
                }

                mPKopiaElementDoWymiany = T[i];
                T[i] = T[mPK];
                T[mPK] = mPKopiaElementDoWymiany;
            }

            return mPLicznikOD;
        }

        public int InsertSort(ref double[] T)
        {
            double mPKopiaElementuDoWymiany;
            int mPK;
            int mPLicznikOD = 0;

            for (int i = 0; i < T.Length; i++)
            {
                mPKopiaElementuDoWymiany = T[i];

                mPK = i;
                while ((mPK > 0) && (mPKopiaElementuDoWymiany < T[mPK - 1]))
                {
                    mPLicznikOD++;

                    T[mPK] = T[mPK - 1];
                    mPK--;
                }

                if (mPK != 0)
                {
                    mPLicznikOD++;
                }

                T[mPK] = mPKopiaElementuDoWymiany;
            }

            return mPLicznikOD;
        }

        public int mPMerge(ref int[] mPLeft, ref int[] mPRight)
        {
            int mPLicznikOD = 0;
            int mPresultLength = mPRight.Length + mPLeft.Length;
            int[] mPresult = new int[mPresultLength];

            int indexLeft = 0, indexRight = 0, indexResult = 0;

            while (indexLeft < mPLeft.Length || indexRight < mPRight.Length)
            {
                mPLicznikOD++;

                if (indexLeft < mPLeft.Length && indexRight < mPRight.Length)
                {

                    if (mPLeft[indexLeft] <= mPRight[indexRight])
                    {
                        mPresult[indexResult] = mPLeft[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }

                    else
                    {
                        mPresult[indexResult] = mPRight[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }

                else if (indexLeft < mPLeft.Length)
                {
                    mPresult[indexResult] = mPLeft[indexLeft];
                    indexLeft++;
                    indexResult++;
                }

                else if (indexRight < mPRight.Length)
                {
                    mPresult[indexResult] = mPRight[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return mPLicznikOD;
        }

        internal int ShellSort(ref double[] mPTablInt)
        {
            int i, j, pos, arrLenght, countOfIterations;
            double temp;
            countOfIterations = 0;
            arrLenght = mPTablInt.Length;
            pos = 3;
            while (pos > 0)
            {
                for (i = 0; i < arrLenght; i++)
                {
                    j = i;
                    temp = mPTablInt[i];
                    while ((j >= pos) && (mPTablInt[j - pos] > temp))
                    {
                        countOfIterations++;
                        mPTablInt[j] = mPTablInt[j - pos];
                        j = j - pos;
                    }
                    mPTablInt[j] = temp;
                }
                if (pos / 2 != 0)
                    pos = pos / 2;
                else if (pos == 1)
                    pos = 0;
                else
                    pos = 1;
            }
            return countOfIterations;
        }

        private int Partition(double[] arr, int start, int end)
        {
            double temp;
            double p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }

        internal int HeapSort(ref double[] mPTabl)
        {
            var countOfIterations = 0;
            var lenght = mPTabl.Length;
            for (int i = lenght / 2 - 1; i >= 0; i--)
            {
                countOfIterations++;
                Heapify(mPTabl, lenght, i);
            }
            for (int i = lenght - 1; i >= 0; i--)
            {
                countOfIterations++;
                double temp = mPTabl[0];
                mPTabl[0] = mPTabl[i];
                mPTabl[i] = temp;
                Heapify(mPTabl, i, 0);
            }
            return countOfIterations;
        }

        private void Heapify(double[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;
            if (largest != i)
            {
                double swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                Heapify(arr, n, largest);
            }
        }

        public List<Book> mPQuickSortStr(List<Book> books)
        {
            var titles = books.Select(x => x.mPTitle).ToArray();
            mPQuickSortStr(titles, 0, titles.Length - 1);

            var sortedBooks = new List<Book>();
            titles.ToList().ForEach(x =>
            {
                var book = books.Where(y => y.mPTitle == x).First();
                sortedBooks.Add(book);
                books.Remove(book);
            });
            return sortedBooks;
        }

        private int mPPartitionStr(string[] arr, int start, int end)
        {
            int pivot = end;
            int i = start, j = end;
            string temp;
            while (i < j)
            {
                while (i < end && string.Compare(arr[i], arr[pivot]) < 0)
                    i++;
                while (j > start && string.Compare(arr[j], arr[pivot]) > 0)
                    j--;

                if (i < j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            temp = arr[pivot];
            arr[pivot] = arr[j];
            arr[j] = temp;
            return j;
        }

        private void mPQuickSortStr(string[] arr, int start, int end)
        {
            if (start < end)
            {
                int pivotIndex = mPPartitionStr(arr, start, end);
                mPQuickSortStr(arr, start, pivotIndex - 1);
                mPQuickSortStr(arr, pivotIndex + 1, end);
            }
        }
    }
}
