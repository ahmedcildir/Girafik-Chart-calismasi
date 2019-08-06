namespace Grafik_Ornek.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblHaftalikGraf")]
    public partial class tblHaftalikGraf
    {
        public int id { get; set; }

        [StringLength(50)]
        public string gun { get; set; }

        [MaxLength(10)]
        public byte[] ogr_Veri { get; set; }

        [MaxLength(10)]
        public byte[] perso_Veri { get; set; }

        [MaxLength(10)]
        public byte[] Akedemi_Veri { get; set; }

        [MaxLength(10)]
        public byte[] idari_Veri { get; set; }

        [MaxLength(10)]
        public byte[] burslu_veri { get; set; }

        [MaxLength(10)]
        public byte[] misafir_Veri { get; set; }
    }
}
