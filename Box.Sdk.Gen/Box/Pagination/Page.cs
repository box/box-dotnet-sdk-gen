using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Sdk.Gen {
    public class Page<T, U> {
        public T? Data { get; init; }

        public IReadOnlyList<U>? Entries { get; init; }

        public PaginationOptions? PaginationOptions { get; init; }

        public Page() {
            
        }
    }
}