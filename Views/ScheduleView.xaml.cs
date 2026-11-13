using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;

namespace QuanLyHocTap.Views
{
    public class EventDemo
    {
        public string Subject { get; set; }
        public string TimeRange { get; set; }
        public string Kind { get; set; }
        public Brush Background { get; set; }
        public Brush Accent { get; set; }
        public Brush Foreground { get; set; }
    }

    public class DayColumn
    {
        public string DayName { get; set; }
        public List<EventDemo> Events { get; set; } = new();
    }

    public partial class ScheduleView : UserControl
    {
        public ScheduleView()
        {
            InitializeComponent();
            dpDate.SelectedDate = DateTime.Today;

            // Lịch trên trường: nền đặc. Lịch tự học: nền nhạt.
            EventDemo OnCampus(string s, string t, Color c) => new()
            {
                Subject = s,
                TimeRange = t,
                Kind = "Trên trường",
                Background = new SolidColorBrush(c),
                Accent = new SolidColorBrush(c),
                Foreground = Brushes.White
            };
            EventDemo SelfStudy(string s, string t, Color c) => new()
            {
                Subject = s,
                TimeRange = t,
                Kind = "Tự học",
                Background = new SolidColorBrush(Color.FromArgb(40, c.R, c.G, c.B)),
                Accent = new SolidColorBrush(c),
                Foreground = new SolidColorBrush(c)
            };

            var blue = Colors.RoyalBlue; var orange = Colors.Orange; var green = Colors.SeaGreen;

            icWeek.ItemsSource = new List<DayColumn>
            {
                new() { DayName = "Thứ 2", Events = { OnCampus("Nhập môn lập trình", "07:30 - 09:30", blue) } },
                new() { DayName = "Thứ 3", Events = { OnCampus("Đại số tuyến tính", "09:45 - 11:45", orange),
                                                      SelfStudy("Ôn Đại số", "19:00 - 21:00", orange) } },
                new() { DayName = "Thứ 4", Events = { OnCampus("Cấu trúc dữ liệu", "13:00 - 16:00", green) } },
                new() { DayName = "Thứ 5", Events = { SelfStudy("Làm bài lập trình", "19:00 - 21:00", blue) } },
                new() { DayName = "Thứ 6" },
                new() { DayName = "Thứ 7", Events = { SelfStudy("Ôn CTDL", "08:00 - 10:00", green) } },
                new() { DayName = "CN" },
            };

            // Thử hiện cảnh báo trùng lịch khi cần:
            // bdConflict.Visibility = System.Windows.Visibility.Visible;
        }
    }
}