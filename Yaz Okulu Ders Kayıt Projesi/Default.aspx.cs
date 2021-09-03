using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace Yaz_Okulu_Ders_Kayıt_Projesi
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci
            {
                AD = TxtAd.Text,
                SOYAD = TxtSoyad.Text,
                NUMARA = TxtNumara.Text,
                SIFRE = TxtSifre.Text,
                FOTOGRAF = TxtFoto.Text
            };
            BLLOgrenci.OgrenciEkleBLL(ent);
        }
    }
}