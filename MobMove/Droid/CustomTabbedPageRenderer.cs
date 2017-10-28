using System;
using Android.OS;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;
using MobMove;
using MobMove.Droid;
using Xamarin.Forms.Platform.Android;
using System.ComponentModel;
using Android.Support.V4.View;
using Android.Support.Design.Widget;
using Android.Content.Res;

[assembly: ExportRenderer(typeof(MyTabbedPage), typeof(CustomTabbedPageRenderer))]
namespace MobMove.Droid
{
    public class CustomTabbedPageRenderer : TabbedPageRenderer
    {
		bool setup;
		ViewPager pager;
		TabLayout layout;

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (setup)
				return;

			if (e.PropertyName == "Renderer")
			{
				pager = (ViewPager)ViewGroup.GetChildAt(0);
				layout = (TabLayout)ViewGroup.GetChildAt(1);
				setup = true;

				ColorStateList colors = null;
				if ((int)Build.VERSION.SdkInt >= 23)
				{
					colors = Resources.GetColorStateList(Resource.Color.icon_tab, Forms.Context.Theme);
				}
				else
				{
					colors = Resources.GetColorStateList(Resource.Color.icon_tab, null);
				}

				for (int i = 0; i < layout.TabCount; i++)
				{
					var tab = layout.GetTabAt(i);
					var icon = tab.Icon;
					if (icon != null)
					{
						icon = Android.Support.V4.Graphics.Drawable.DrawableCompat.Wrap(icon);
						Android.Support.V4.Graphics.Drawable.DrawableCompat.SetTintList(icon, colors);
					}
				}

			}
		}

		protected override void SetTabIcon(TabLayout.Tab tab, FileImageSource icon)
		{
			base.SetTabIcon(tab, icon);

			tab.SetCustomView(Resource.Layout.MyTabLayout);
			var imageview = tab.CustomView.FindViewById<ImageView>(Resource.Id.icon);
            var textview = tab.CustomView.FindViewById<TextView>(Resource.Id.title);
			imageview.Background=tab.Icon;
            textview.Text = tab.Text;
		}

    }
}
