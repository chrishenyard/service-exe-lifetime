using System.Reflection;
using System.ServiceProcess;
using log4net;

namespace ServiceLifetime {
	public partial class ServiceLifetime : ServiceBase {
		private static ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public ServiceLifetime() {
			log4net.Config.XmlConfigurator.Configure();
			InitializeComponent();
			CanPauseAndContinue = true;
		}

		protected override void OnStart(string[] args) {
			_log.Info("Starting service");
		}

		protected override void OnStop() {
			_log.Info("Stopping service");
		}

		protected override void OnPause() {
			_log.Info("Pausing service");
		}

		protected override void OnContinue() {
			_log.Info("Continuing service");
		}
	}
}
