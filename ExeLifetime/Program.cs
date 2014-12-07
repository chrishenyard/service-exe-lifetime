using System;
using System.Reflection;
using log4net;

namespace ExeLifetime {
	class Program {
		private static ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		static void Main(string[] args) {
			log4net.Config.XmlConfigurator.Configure();
			_log.Info("Exe running in main");
			_log.Info("Press any key to exit");
			Console.ReadKey();
		}
	}
}