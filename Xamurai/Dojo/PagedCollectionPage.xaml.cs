
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamurai
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PagedCollectionPage : ContentPage
	{
		public PagedCollectionPage ()
		{
			BindingContext = new SampleViewModel();
			InitializeComponent ();

        }


        //THIS WAS MY ATTEMPT TO GET THE PAGE TO SCROLL A SPECIFIC DISTANCE. QUITE A FAIL.
        async void OnScrollViewScrolled(object sender, ScrolledEventArgs e)
        {

            await scrollView.ScrollToAsync(e.ScrollX + 360, 0, false);
            Console.WriteLine($"ScrollX {e.ScrollX}, ScrollY: {e.ScrollY}");
        }


        //THIS WAS MY START TO THE GESTURE RECOGNIZER, BUT RAN INTO SAME PROBLEM AS ABOVE 
        void SwipeGestureRecognizer_Swiped(System.Object sender, Xamarin.Forms.SwipedEventArgs e)
        {
            
        }

    }
}