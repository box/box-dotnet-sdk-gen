using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface IShieldInformationBarrierSegmentsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<ShieldInformationBarrierSegment> GetShieldInformationBarrierSegmentByIdAsync(string shieldInformationBarrierSegmentId, GetShieldInformationBarrierSegmentByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<ShieldInformationBarrierSegment> UpdateShieldInformationBarrierSegmentByIdAsync(string shieldInformationBarrierSegmentId, UpdateShieldInformationBarrierSegmentByIdRequestBody? requestBody = default, UpdateShieldInformationBarrierSegmentByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task DeleteShieldInformationBarrierSegmentByIdAsync(string shieldInformationBarrierSegmentId, DeleteShieldInformationBarrierSegmentByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<ShieldInformationBarrierSegments> GetShieldInformationBarrierSegmentsAsync(GetShieldInformationBarrierSegmentsQueryParams queryParams, GetShieldInformationBarrierSegmentsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<ShieldInformationBarrierSegment> CreateShieldInformationBarrierSegmentAsync(CreateShieldInformationBarrierSegmentRequestBody requestBody, CreateShieldInformationBarrierSegmentHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

    }
}