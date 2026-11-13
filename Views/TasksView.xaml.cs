using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace DoAn.Views
{
    public class TaskDemo
    {
        public string Title { get; set; }
        public string Subject { get; set; }
        public DateTime Deadline { get; set; }
        public string Priority { get; set; }
        public Brush PriorityBrush { get; set; }
        public string Status { get; set; }
    }

    public partial class TasksView : UserControl
    {
        public TasksView()
        {
            InitializeComponent();

            dgTasks.ItemsSource = new[]
            {
                new TaskDemo { Title="Bài tập tuần 3", Subject="Nhập môn lập trình", Deadline=DateTime.Today.AddDays(2),
                               Priority="Cao", PriorityBrush=Brushes.IndianRed, Status="Đang làm" },
                new TaskDemo { Title="Ôn giữa kỳ", Subject="Đại số tuyến tính", Deadline=DateTime.Today.AddDays(7),
                               Priority="Trung bình", PriorityBrush=Brushes.Orange, Status="Chưa làm" },
                new TaskDemo { Title="Báo cáo nhóm", Subject="Cấu trúc dữ liệu", Deadline=DateTime.Today.AddDays(14),
                               Priority="Thấp", PriorityBrush=Brushes.SeaGreen, Status="Hoàn thành" },
            };
        }

        private void cbFilterSubject_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}