using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IShieldInformationBarrierSegmentsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<ShieldInformationBarrierSegment> GetShieldInformationBarrierSegmentByIdAsync(string shieldInformationBarrierSegmentId, GetShieldInformationBarrierSegmentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<ShieldInformationBarrierSegment> UpdateShieldInformationBarrierSegmentByIdAsync(string shieldInformationBarrierSegmentId, UpdateShieldInformationBarrierSegmentByIdRequestBodyArg? requestBody = default, UpdateShieldInformationBarrierSegmentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteShieldInformationBarrierSegmentByIdAsync(string shieldInformationBarrierSegmentId, DeleteShieldInformationBarrierSegmentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<ShieldInformationBarrierSegments> GetShieldInformationBarrierSegmentsAsync(GetShieldInformationBarrierSegmentsQueryParamsArg queryParams, GetShieldInformationBarrierSegmentsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<ShieldInformationBarrierSegment> CreateShieldInformationBarrierSegmentAsync(CreateShieldInformationBarrierSegmentRequestBodyArg requestBody, CreateShieldInformationBarrierSegmentHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}