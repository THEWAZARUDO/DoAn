namespace DoAn.Models
{
    public class MonHoc
    {
        public int Id { get; set; }                 // tự thành khóa chính
        public string TenMon { get; set; } = "";
        public int SoTinChi { get; set; }

        public List<BaiTap> BaiTaps { get; set; } = new();   // 1 môn có nhiều bài tập
    }
}