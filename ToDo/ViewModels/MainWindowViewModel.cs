using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;
using ToDo.Services;

namespace ToDo.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase content;
        
        public MainWindowViewModel(Database db)
        {
            Content = List = new ToDoListViewModel(db.GetItems());
        }

        public ViewModelBase Content
        {
            get => content;
            private set => this.RaiseAndSetIfChanged(ref content, value);
        }
        public ToDoListViewModel List { get; }

        public void AddItem()
        {
            Content = new AddItemViewModel();
        }
    }
}