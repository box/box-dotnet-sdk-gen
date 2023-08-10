using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ConflictError : ClientError {
        public ConflictError(ClientErrorTypeField type, int? status, ClientErrorCodeField code, string message, ClientErrorContextInfoField contextInfo, string helpUrl, string requestId) : base(type, status, code, message, contextInfo, helpUrl, requestId) {
            
        }
    }
}