namespace DoAn.Models
{
    public class BaiTap
    {
        public int Id { get; set; }
        public string TieuDe { get; set; } = "";
        public DateTime HanNop { get; set; }
        public bool DaHoanThanh { get; set; }

        public int MonHocId { get; set; }           // khóa ngoại
        public MonHoc? MonHoc { get; set; }
    }
}