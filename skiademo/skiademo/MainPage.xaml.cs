using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace skiademo
{
    [XamlCompilation(XamlCompilationOptions.Skip)]
    public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			InitializeComponent();
        }

        private void SKGLView_PaintSurface(object sender, SkiaSharp.Views.Forms.SKPaintGLSurfaceEventArgs e)
        {
            e.Surface.Canvas.Clear(SkiaSharp.SKColors.White);
        }
    }
}
