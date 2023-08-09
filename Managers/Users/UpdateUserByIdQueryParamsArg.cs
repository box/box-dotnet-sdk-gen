using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateUserByIdQueryParamsArg {
        public string Fields { get; }

        public UpdateUserByIdQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}