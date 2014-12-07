using System.ServiceProcess;

namespace ServiceLifetime {
	partial class ProjectInstaller {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			serviceProcessInstaller1 = new ServiceProcessInstaller();
			serviceInstaller1 = new ServiceInstaller();
			// 
			// serviceProcessInstaller1
			// 
			serviceProcessInstaller1.Account = ServiceAccount.LocalSystem;

			// 
			// serviceInstaller1
			// 
			serviceInstaller1.ServiceName = "ServiceLifetime";
			// 
			// ProjectInstaller
			// 
			Installers.AddRange(new System.Configuration.Install.Installer[] {
            serviceProcessInstaller1,
            serviceInstaller1});

		}

		#endregion

		private ServiceProcessInstaller serviceProcessInstaller1;
		private ServiceInstaller serviceInstaller1;
	}
}