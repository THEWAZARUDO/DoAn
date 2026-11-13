using System.Windows;
using DoAn.Views;

namespace DoAn
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Nav_Checked(object sender, RoutedEventArgs e)
        {
            // Checked có thể chạy trước khi MainContent được tạo
            if (MainContent == null) return;

            if (sender == rbSubjects) MainContent.Content = new SubjectsView();
            else if (sender == rbTasks) MainContent.Content = new TasksView();
            else if (sender == rbSchedule) MainContent.Content = new ScheduleView();
        }

        protected override void OnContentRendered(System.EventArgs e)
        {
            base.OnContentRendered(e);
            MainContent.Content ??= new SubjectsView();
        }
    }
}