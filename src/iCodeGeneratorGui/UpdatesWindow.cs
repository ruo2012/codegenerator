using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using iCodeGenerator.Updater;

namespace iCodeGenerator.iCodeGeneratorGui
{
	/// <summary>
	/// Summary description for UpdatesWindow.
	/// </summary>
	public class UpdatesWindow : Form
    {
        private WebBrowser webBrowser1;
	
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public UpdatesWindow()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		    webBrowser1.Url = new Uri(string.Format("http://icodegenerator.net/?v={0}#.download", UpdateChecker.Version));

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatesWindow));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(794, 572);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // UpdatesWindow
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdatesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Notice";
            this.ResumeLayout(false);

		}
		#endregion

	}
}
