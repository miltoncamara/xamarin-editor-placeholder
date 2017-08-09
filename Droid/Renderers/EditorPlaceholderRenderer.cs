using EntryPlaceholder.Controls;
using EntryPlaceholder.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EntryPlaceholder.Controls.EditorPlaceholder), typeof(EditorPlaceholderRenderer))]
namespace EntryPlaceholder.Droid
{
	public class EditorPlaceholderRenderer : EditorRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
		{
			base.OnElementChanged(e);
			if (e.NewElement != null)
			{
				var element = e.NewElement as EditorPlaceholder;

				Control.Hint = element.Placeholder;
			}
		}
	}
}
