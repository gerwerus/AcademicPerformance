using ReactiveUI;
using System.Collections.Generic;
using System.Reactive;
using AcademicPerformance.Models;
using System.Reactive.Disposables;
using System.Runtime.InteropServices;

namespace AcademicPerformance.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private List<Student> students = new List<Student>();
        private int[] AverageMarks { get; set; }

        private string currentFio = "";
        private int[] currentMarks = { 0 };
        public string CurrentFio
        {
            get => currentFio;
            set
            {
                this.RaiseAndSetIfChanged(ref currentFio, value);
            }
        }
        public int[] CurrentMarks
        {
            get => currentMarks;
            set
            {
                this.RaiseAndSetIfChanged(ref currentMarks, value);
            }
        }
        public ReactiveCommand<Unit, Unit> AddStudent { get; }
        public ReactiveCommand<Unit, Unit> RemoveStudent { get; }
        public ReactiveCommand<Unit, Unit> LoadTable { get; }
        public ReactiveCommand<Unit, Unit> SaveTable { get; }

        public MainWindowViewModel()
        {
            AddStudent = ReactiveCommand.Create(() => Add());
            RemoveStudent = ReactiveCommand.Create(() => Remove());
            LoadTable = ReactiveCommand.Create(() => Load());
            SaveTable = ReactiveCommand.Create(() => Save());
        }
        private void Add()
        {
            Student student = new Student(currentMarks, currentFio);
            students.Add(student);
        }
        private void Remove()
        {
            /*students.Remove(student);*/
        }
        private void Load()
        {

        }
        private void Save()
        {

        }
    }
}
