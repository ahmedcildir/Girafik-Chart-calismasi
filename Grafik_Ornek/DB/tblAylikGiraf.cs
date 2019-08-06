namespace Grafik_Ornek.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAylikGiraf")]
    public partial class tblAylikGiraf
    {
        public int id { get; set; }

        [StringLength(12)]
        public string Tarih { get; set; }

        public int? ogr_Veri { get; set; }

        public int? pers_Veri { get; set; }

        public int? idari_Veri { get; set; }

        public int? akedemis_Veri { get; set; }

        public int? misafir_Veri { get; set; }

        public int? burslu_Veri { get; set; }
    }
}
