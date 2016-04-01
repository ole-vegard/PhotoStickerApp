using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics;
using Android.Graphics.Drawables;

namespace PhotoStickerApp.Droid
{
	[Activity (Label = "PhotoStickerApp", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to its
			Button button = FindViewById<Button> (Resource.Id.button1);
			var drawable = BaseContext.GetDrawable (Resource.Drawable.mario);
			ImageView c = FindViewById<ImageView> (Resource.Id.signature_canvas);
			Bitmap b;
			if (drawable is BitmapDrawable) {
				BitmapDrawable bitmapDrawable = (BitmapDrawable) drawable;
				if(bitmapDrawable.Bitmap != null) {
					b = bitmapDrawable.Bitmap;
					c.SetImageBitmap (b);
				}
			}



		




			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};


		}
	}
}


