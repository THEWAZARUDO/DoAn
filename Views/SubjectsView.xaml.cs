using System.Windows.Controls;
using System.Windows.Media;

namespace QuanLyHocTap.Views
{
    public class SubjectDemo
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public string Lecturer { get; set; }
        public Brush Color { get; set; }
    }

    public class ColorOption
    {
        public string Name { get; set; }
        public Brush Brush { get; set; }
    }

    public partial class SubjectsView : UserControl
    {
        public SubjectsView()
        {
            InitializeComponent();

            dgSubjects.ItemsSource = new[]
            {
                new SubjectDemo { Code="IT001", Name="Nhập môn lập trình", Credits=4, Lecturer="Nguyễn Văn A", Color=Brushes.RoyalBlue },
                new SubjectDemo { Code="MA003", Name="Đại số tuyến tính",   Credits=3, Lecturer="Trần Thị B",  Color=Brushes.Orange },
                new SubjectDemo { Code="IT002", Name="Cấu trúc dữ liệu",    Credits=4, Lecturer="Lê Văn C",    Color=Brushes.SeaGreen },
            };

            cbColor.ItemsSource = new[]
            {
                new ColorOption { Name="Xanh dương", Brush=Brushes.RoyalBlue },
                new ColorOption { Name="Cam",        Brush=Brushes.Orange },
                new ColorOption { Name="Xanh lá",    Brush=Brushes.SeaGreen },
                new ColorOption { Name="Đỏ",         Brush=Brushes.IndianRed },
                new ColorOption { Name="Tím",        Brush=Brushes.MediumPurple },
            };
            cbColor.SelectedIndex = 0;
        }
    }
}