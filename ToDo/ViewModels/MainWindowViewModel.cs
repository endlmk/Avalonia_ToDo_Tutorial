using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Services;

namespace ToDo.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(Database db)
        {
            List = new ToDoListViewModel(db.GetItems());
        }
        
        public ToDoListViewModel List { get; }
    }
}