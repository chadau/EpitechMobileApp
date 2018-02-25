using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EpitechMobileApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuBar : MasterDetailPage
	{
		public MenuBar ()
		{
			InitializeComponent ();
		}

        void Profil_on_Click(object sender, System.EventArgs e)
        {
            IsPresented = false;
        }

        void Modules_on_Click(object sender, System.EventArgs e)
        {
            IsPresented = false;
        }

        void Planning_on_Click(object sender, System.EventArgs e)
        {
            IsPresented = false;
        }
    }
}