namespace SortingAlgorithms
{
    internal class SortingAlgorithms 
    {
        public static void InsertionSort<T>(IList<T> collection) where T : IComparable
        {
            for (int i = 0; i < collection.Count; i++)
            {   
                    T element = collection[i];
                    var index = i;

                while (index > 0 && collection[index - 1].CompareTo(element) > 0)
                {
                    collection[index] = collection[index - 1];
                    index--;
                }
                collection[index] = element;
            }
        }
        public static void PancakeSort<T>(IList<T> collection) where T : IComparable
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                int indexMaxElement = IndexOfMaxElement(collection, i);
                if (indexMaxElement != i)
                {
                    // flip collection till max element
                    // max element is now on position 0 
                    Flip(collection, indexMaxElement);
                    // flip collection till current index
                    Flip(collection, i);
                }
            }
        }
        private static int IndexOfMaxElement<T>(IList<T> collection, int range) where T : IComparable
        {
            int index = 0;
            for (int i = 1; i <= range; ++i)
            {
                if (collection[i].CompareTo(collection[index]) > 0)
                {
                    index = i;
                }
            }
            return index;
        }
        private static void Flip<T>(IList<T> collection, int currentIndex)
        {
            for (int i = 0; i < currentIndex; i++, currentIndex--)
            {
                T temp = collection[i];
                collection[i] = collection[currentIndex];
                collection[currentIndex] = temp;
            }
        }
        public static void SelectionSort<T>(IList<T> collection) where T : IComparable
        {
            int i, j, indexMin;
            for (i = 0; i < collection.Count - 1; ++i)
            {
                indexMin = i;
                for (j = i + 1; j < collection.Count; ++j)
                    if (collection[j].CompareTo(collection[indexMin]) < 0)
                        indexMin = j;
                T temp = collection[indexMin];
                collection[indexMin] = collection[i];
                collection[i] = temp;
            }
        }
        public static void CycleSort<T>(IList<T> collection) where T : IComparable
        {
            int writes = 0;
            for (int cycle_start = 0; cycle_start <= collection.Count - 2; cycle_start++)
            {
                T element = collection[cycle_start];
                int position = cycle_start;
                for (int i = cycle_start + 1; i < collection.Count; ++i)
                    if (collection[i].CompareTo(element) < 0) ++position;
                if (position == cycle_start) continue;
                while (element.CompareTo(collection[position]) == 0) position += 1;
                if (position != cycle_start)
                {
                    T temp = element;
                    element = collection[position];
                    collection[position] = temp;
                    writes++;
                }
                while (position != cycle_start)
                {
                    position = cycle_start;
                    for (int i = cycle_start + 1; i < collection.Count; i++)
                        if (collection[i].CompareTo(element) < 0) position += 1;
                    while (element.CompareTo(collection[position]) == 0) position += 1;
                    if (element.CompareTo(collection[position]) != 0)
                    {
                        T tmp = element;
                        element = collection[position];
                        collection[position] = tmp;
                        writes++;
                    }
                }
            }
        }
        public static void BubbleSort<T>(IList<T> collection) where T : IComparable
        {
            int n = collection.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (collection[j].CompareTo(collection[j + 1]) > 0)
                    {
                        T temp = collection[j];
                        collection[j] = collection[j + 1];
                        collection[j + 1] = temp;
                    }
                }
            }
        }
        public static void GnomeSort<T>(IList<T> collection) where T : IComparable
        {
            int n = collection.Count;
            int index = 0;
            while (index < n)
            {
                if (index == 0) index++;
                if (collection[index].CompareTo(collection[index - 1]) >= 0) index++;
                else
                {
                    T temp = collection[index];
                    collection[index] = collection[index - 1];
                    collection[index - 1] = temp;
                    index--;
                }
            }
        }
        public static void ShakerSort<T>(IList<T> collection) where T : IComparable
        {
            for (var i = 0; i < collection.Count / 2; i++)
            {
                bool flag = false;
                // left to right
                for (var j = i; j < collection.Count - i - 1; j++)
                {
                    if (collection[j].CompareTo(collection[j + 1]) > 0)
                    {
                        var temp = collection[j];
                        collection[j] = collection[j + 1];
                        collection[j + 1] = temp;
                        flag = true;
                    }
                }
                // right to left
                for (var j = collection.Count - 2 - i; j > i; j--)
                {
                    if (collection[j - 1].CompareTo(collection[j]) > 0)
                    {
                        var temp = collection[j - 1];
                        collection[j - 1] = collection[j];
                        collection[j] = temp;
                        flag = true;
                    }
                }
                // break if no changes
                if (!flag)
                {
                    break;
                }
            }
        }
    }
}
