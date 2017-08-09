using System;
using Xamarin.Forms;

namespace EntryPlaceholder.Controls
{
	public class EditorPlaceholder : Editor
	{
		public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create<EditorPlaceholder, string>(view => view.Placeholder, String.Empty);

		public string Placeholder
		{
			get
			{
				return (string)GetValue(PlaceholderProperty);
			}
			set
			{
				SetValue(PlaceholderProperty, value);
			}
		}
	}
}
