using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface IShieldInformationBarrierReportsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<ShieldInformationBarrierReports> GetShieldInformationBarrierReportsAsync(GetShieldInformationBarrierReportsQueryParams queryParams, GetShieldInformationBarrierReportsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<ShieldInformationBarrierReport> CreateShieldInformationBarrierReportAsync(ShieldInformationBarrierReference requestBody, CreateShieldInformationBarrierReportHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<ShieldInformationBarrierReport> GetShieldInformationBarrierReportByIdAsync(string shieldInformationBarrierReportId, GetShieldInformationBarrierReportByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}