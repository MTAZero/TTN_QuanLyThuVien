namespace QuanLyThuVien.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MUONTRAS")]
    public partial class MUONTRA
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYMUON { get; set; }

        public int? DOCGIAID { get; set; }

        public int? DAUSACHID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYTRA { get; set; }

        public int? TRANGTHAI { get; set; }

        public virtual DAUSACH DAUSACH { get; set; }

        public virtual DOCGIA DOCGIA { get; set; }
    }
}
