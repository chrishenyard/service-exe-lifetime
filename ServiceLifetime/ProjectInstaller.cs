using System.ComponentModel;

namespace ServiceLifetime {
	[RunInstaller(true)]
	public partial class ProjectInstaller : System.Configuration.Install.Installer {
		public ProjectInstaller() {
			InitializeComponent();
		}
	}
}
