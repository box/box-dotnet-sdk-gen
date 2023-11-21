using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IShieldInformationBarrierReportsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<ShieldInformationBarrierReports> GetShieldInformationBarrierReportsAsync(GetShieldInformationBarrierReportsQueryParamsArg queryParams, GetShieldInformationBarrierReportsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<ShieldInformationBarrierReport> CreateShieldInformationBarrierReportAsync(ShieldInformationBarrierReference requestBody, CreateShieldInformationBarrierReportHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<ShieldInformationBarrierReport> GetShieldInformationBarrierReportByIdAsync(string shieldInformationBarrierReportId, GetShieldInformationBarrierReportByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}