using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Sdk.Gen {
    public class Pageable<T, U> {
        public T? Data { get; init; }

        public IReadOnlyList<U>? Entries { get; init; }

        public Pageable() {
            
        }
        public async System.Threading.Tasks.Task LoadNextPageAsync() {
        }

    }
}