using System.ServiceProcess;

namespace ServiceLifetime {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main() {
			ServiceBase[] ServicesToRun;
			ServicesToRun = new ServiceBase[]
			{
				new ServiceLifetime()
			};
			ServiceBase.Run(ServicesToRun);
		}
	}
}
