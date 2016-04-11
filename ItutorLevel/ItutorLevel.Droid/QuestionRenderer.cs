using Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using ItutorLevel;

[assembly: ExportRenderer(typeof(ItutorLevel.Droid.QuestionRenderer), typeof(QuestionsControl))]
namespace ItutorLevel.Droid
{
    public class QuestionRenderer : ViewRenderer<QuestionsControl, QuestionRenderer>
    {

        protected override void OnAttachedToWindow()
        {
            base.OnAttachedToWindow();
            
            //SetBackgroundResource(VetUtilX2.Droid.Resource.Drawable.side_nav_bar);
        }
        //protected override void OnElementChanged(ElementChangedEventArgs<ItutorLevel.Droid.QuestionRenderer> e)
        //{
        //    base.OnElementChanged(e);

        //    if (Control == null)
        //    {
        //        cameraPreview = new RadioButton(Context);
        //        SetNativeControl(cameraPreview);
        //    }

        //    if (e.OldElement != null)
        //    {
        //        // Unsubscribe
        //        cameraPreview.Click -= OnCameraPreviewClicked;
        //    }
        //    if (e.NewElement != null)
        //    {
        //        Control.Preview = Camera.Open((int)e.NewElement.Camera);

        //        // Subscribe
        //        cameraPreview.Click += OnCameraPreviewClicked;
        //    }
        //}
    }
}

