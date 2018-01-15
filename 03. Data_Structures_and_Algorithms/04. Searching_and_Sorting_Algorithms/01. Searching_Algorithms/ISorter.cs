namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public interface ISorter<T>
    {
        IList<T> Sort(IList<T> collection);
    }
}
