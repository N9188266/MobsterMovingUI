using Android.OS;
using Android.Views;
using Xamarin.Forms;
using MobMove;
using MobMove.Droid;
using System.ComponentModel;
using Android.Support.V4.View;
using Android.Support.Design.Widget;
using Android.Content.Res;

[assembly: ExportRenderer(typeof(MyTabbedPage), typeof(MyTabbedPageRenderer))]

namespace MobMove.Droid
{
    public class MyTabbedPageRenderer
    {
        public MyTabbedPageRenderer()
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
                    colors = Resources.GetColorStateList(Resource.Color.icon_tab);
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
    }
}
