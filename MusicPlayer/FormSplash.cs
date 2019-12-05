using System;
using System.Windows.Forms;

namespace MusicPlayer
{
	public partial class FormSplash : Form
	{
		int SplashCounter = 10;

		public FormSplash()
		{
			InitializeComponent();
		}

		private void SplashTimer_Tick(object sender, EventArgs e)
		{
			--SplashCounter;
			if (SplashCounter <= 0)
				Close();
		}
	}
}
