using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateUserQueryParamsArg {
        public string Fields { get; }

        public CreateUserQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}