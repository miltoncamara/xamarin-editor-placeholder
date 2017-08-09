using EntryPlaceholder.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(EntryPlaceholder.Controls.EditorPlaceholder), typeof(EditorPlaceholderRenderer))]
namespace EntryPlaceholder.iOS
{
	public class EditorPlaceholderRenderer : EditorRenderer
	{
		string _placeholder { get; set; }

		protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
		{
			base.OnElementChanged(e);
			var element = this.Element as EntryPlaceholder.Controls.EditorPlaceholder;

			if (Control != null && element != null)
			{	
				_placeholder = element.Placeholder; ///Atribuo o texto definido na propriedade placeholder criado em nosso controle principal no Xamarin Forms.
				Control.TextColor = UIColor.FromRGB(140, 140, 140); ///Inicializa a cor do placeholder com um cinza claro.
				Control.Text = _placeholder;

				Control.ShouldBeginEditing += ShouldBeginEditing; ///Evento ao iniciar a intenção de editar as informações no editor de texto.
				Control.ShouldEndEditing += ShouldEndEditing; ///Evento ao finalizar a intenção de editar as informações no editor de texto.
			}
		}

		///Evento ao iniciar a intenção de editar as informações no editor de texto.
		bool ShouldBeginEditing(UITextView textField)
		{
			if (textField.Text == _placeholder)
			{
				textField.Text = string.Empty; ///Limpa o o valor do campo.
				textField.TextColor = UIColor.FromRGB(0, 0, 0); ///Seta a cor do texto do editor no formato normal.
			}

			return true;			
		}

		///Evento ao finalizar a intenção de editar as informações no editor de texto.
		bool ShouldEndEditing(UITextView textField)
		{
			if (textField.Text == "")
			{
				textField.Text = _placeholder; ///Seta o texto do placeholder caso o campo esteja vazio.
				textField.TextColor = UIColor.FromRGB(140, 140, 140); ///Volta a cor padrão do placeholder
			}

			return true;
		}
	}
}
