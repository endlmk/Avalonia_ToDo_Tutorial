using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ToDo.Views
{
    public class ToDoListView : UserControl
    {
        public ToDoListView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}