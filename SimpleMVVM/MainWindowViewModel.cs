using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SimpleMVVM
{
    public class MainWindowViewModel : ViewModelBase
    {
        private Task _selectedTask;

        private string _name { get; set; }
        private string _isdone { get; set; }
        private ObservableCollection<Task> _tasks { get; set; }

        public MainWindowViewModel(){
            _tasks = createList();
            }

        public ObservableCollection<Task> Tasks
        {
            get
            {
                return _tasks;
            }
            set
            {
                if (_tasks != value)
                {
                    _tasks = value;
                    OnPropertyChanged("Tasks");
                }
            }
        }

        public Task SelectedTask
        {
            get => _selectedTask;
            set
            {
                _selectedTask = value;
                OnPropertyChanged("SelectedTask");
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string IsDone
        {
            get
            {
                return _isdone;
            }
            set
            {
                if (_isdone != value)
                {
                    _isdone = value;
                    OnPropertyChanged("IsDone");
                }
            }
        }

        private ObservableCollection<Task> createList() {
            ObservableCollection<Task> tasks = new ObservableCollection<Task>();
            tasks.Add(new Task(){ Id = 1, Name = "Task 1", IsDone=false});
            tasks.Add(new Task(){ Id = 2, Name = "Task 2", IsDone = false });
            tasks.Add(new Task(){ Id = 3, Name = "Task 3", IsDone = true });
            return tasks;
        }
    }
}
