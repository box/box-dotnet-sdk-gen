using Box.Sdk.Gen.Schemas;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Box.Sdk.Gen
{
    public class RecentItemsPaginator : GenericPaginator<RecentItem>
    {
        public RecentItemsPaginator(Func<string, Task<(IReadOnlyList<RecentItem> items, string nextMarker)>> fetchNextPage) : base(fetchNextPage)
        {
        }
    }

    public class GenericPaginator<T> : IAsyncEnumerable<T>
    {
        //buffered entries
        public IReadOnlyList<T> Entries;

        public string NextMarker;

        public int Limit;

        private Func<string, Task<(IReadOnlyList<T> items, string nextMarker)>> _fetchNextPage;

        public GenericPaginator(Func<string, Task<(IReadOnlyList<T> items, string nextMarker)>> fetchNextPage)
        {
            _fetchNextPage = fetchNextPage;
        }

        public IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default)
        {
            return new PaginatorEnumerator<T>(_fetchNextPage, Limit);
        }
    }

    public class PaginatorEnumerator<T> : IAsyncEnumerator<T>
    {
        private int _currentIndex;
        private Func<string, Task<(IReadOnlyList<T> items, string nextMarker)>> _fetchNextPage;
        private IReadOnlyList<T> _currentPage;
        private int _pageSize;
        private string _nextMarker;

        public PaginatorEnumerator(Func<string, Task<(IReadOnlyList<T> items, string nextMarker)>> fetchNextPage, int pageSize)
        {
            _fetchNextPage = fetchNextPage;
            _pageSize = pageSize;
            Reset();
        }


        public T Current => _currentPage[_currentIndex];

        public void Dispose()
        {
            //TODO
        }

        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            _currentPage = new List<T>();
            _currentIndex = -1;
        }

        async ValueTask<bool> IAsyncEnumerator<T>.MoveNextAsync()
        {
            _currentIndex++;
            if (_currentIndex >= _currentPage.Count)
            {
                (_currentPage, _nextMarker) = await _fetchNextPage(_nextMarker);
                _currentIndex = 0;
            }
            return _nextMarker != null;
        }
    }
}
