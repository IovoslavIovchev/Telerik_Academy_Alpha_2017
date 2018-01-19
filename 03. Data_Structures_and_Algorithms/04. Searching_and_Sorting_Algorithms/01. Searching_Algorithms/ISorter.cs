namespace SearchingHomework
{
    using System;
    using System.Collections.Generic;

    public interface ISorter<T> where T : IComparable<T>
    {
        IList<T> Sort(IList<T> collection);
    }
}
