using Microsoft.Maui.Handlers;
#if ANDROID
using Android.Content.Res;
using Android.Graphics.Drawables;
using AndroidX.Core.Content;
#endif

namespace CustomEntry
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            EntryHandler.Mapper.AppendToMapping(nameof(CustomEntryControl.IsValid), (handler, view) =>
            {
                if (view is CustomEntryControl fieldEntry)
                {
#if ANDROID

                    Android.Content.Context context = Android.App.Application.Context;
                    
                    Drawable background = fieldEntry.IsValid ? ContextCompat.GetDrawable(context,  Resource.Drawable.control_rounded)
                     : ContextCompat.GetDrawable(context, Resource.Drawable.control_rounded_notvalid);

                    // Set the background of the AppCompatEditText to the StateListDrawable object.
                    handler.PlatformView.Background = background;
#elif IOS

#endif
                }

            });
            MainPage = new AppShell();
        }
    }
}