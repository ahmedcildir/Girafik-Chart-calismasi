using Grafik_Ornek.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Grafik_Ornek
{
    public partial class Grafik : System.Web.UI.Page
    {
        GrafikDBContext ctx = new GrafikDBContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            //verilerin veri tabanından çekilerel işlenmesi
            var getVeri = from v in ctx.tblAylikGirafs.OrderByDescending(x => x.id).Take(5) select v;
            foreach (var i in getVeri)
            {
                Chart1.Series["veri1"].Points.AddXY(i.Tarih, i.ogr_Veri);
                Chart1.Series["veri2"].Points.Add(Convert.ToInt32(i.pers_Veri));
                Chart1.Series["veri3"].Points.Add(Convert.ToInt32(i.akedemis_Veri));
                Chart1.Series["veri4"].Points.Add(Convert.ToInt32(i.misafir_Veri));
                Chart1.Series["veri5"].Points.Add(Convert.ToInt32(i.burslu_Veri));
            }
            var getVeriAylik = from v in ctx.tblAylikGirafs.OrderByDescending(x => x.id).Take(30) select v;
            foreach (var i in getVeriAylik)
            {
                Chart2.Series["veri1"].Points.AddXY(i.Tarih, i.ogr_Veri);
                Chart2.Series["veri2"].Points.Add(Convert.ToInt32(i.pers_Veri));
                Chart2.Series["veri3"].Points.Add(Convert.ToInt32(i.akedemis_Veri));
                Chart2.Series["veri4"].Points.Add(Convert.ToInt32(i.misafir_Veri));
                Chart2.Series["veri5"].Points.Add(Convert.ToInt32(i.burslu_Veri));
            }

            //verilerin elle girişi
            Chart1.Series["veri1"].Points.AddXY("Pazartesi",25);
            Chart1.Series["veri1"].Points.AddXY("salı", 35);
            Chart1.Series["veri1"].Points.AddXY("çarşamba", 45);
            Chart1.Series["veri1"].Points.AddXY("prşembe", 55);
            Chart1.Series["veri1"].Points.AddXY("cuma", 65);

            Chart1.Series["veri2"].Points.Add(15);
            Chart1.Series["veri2"].Points.Add(25);
            Chart1.Series["veri2"].Points.Add(35);
            Chart1.Series["veri2"].Points.Add(36);
            Chart1.Series["veri2"].Points.Add(46);

            Chart1.Series["veri3"].Points.Add(10);
            Chart1.Series["veri3"].Points.Add(20);
            Chart1.Series["veri3"].Points.Add(30);
            Chart1.Series["veri3"].Points.Add(40);
            Chart1.Series["veri3"].Points.Add(50);

            Chart1.Series["veri4"].Points.Add(12);
            Chart1.Series["veri4"].Points.Add(21);
            Chart1.Series["veri4"].Points.Add(32);
            Chart1.Series["veri4"].Points.Add(23);
            Chart1.Series["veri4"].Points.Add(25);


        }
    }
}