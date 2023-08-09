using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class DeleteUserByIdQueryParamsArg {
        public bool? Notify { get; }

        public bool? Force { get; }

        public DeleteUserByIdQueryParamsArg(bool? notify, bool? force) {
            Notify = notify;
            Force = force;
        }
    }
}