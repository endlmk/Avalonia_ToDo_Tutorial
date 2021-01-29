using System.Reactive;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ReactiveUI;
using ToDo.Models;

namespace ToDo.ViewModels
{
    public class AddItemViewModel : ViewModelBase
    {
        string description;

        public AddItemViewModel()
        {
            var okEnabled = this.WhenAnyValue(
                x => x.Description,
                x => !string.IsNullOrWhiteSpace((x)));

            Ok = ReactiveCommand.Create(
                () => new ToDoItem {Description = Description},
                okEnabled);
            Cancel = ReactiveCommand.Create((() => { }));
        }

        public string Description
        {
            get => description; 
            set => this.RaiseAndSetIfChanged(ref description, value);
        }
        
        public ReactiveCommand<Unit, ToDoItem> Ok { get; }
        public ReactiveCommand<Unit, Unit> Cancel { get; }
    }
}