namespace Library.Extensions
{
    public static class ListExtensions
    {
        /// <summary>
        /// Adds item to the list if item is not null
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="item"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void AddIfNotNull<T>(this List<T> list, T item)
        {
            if(list == null) { throw new ArgumentNullException(nameof(list)); }
            if(item == null) { return; }

            list.Add(item);
        }
    }
}
