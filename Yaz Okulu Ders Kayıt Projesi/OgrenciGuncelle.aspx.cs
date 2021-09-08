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
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OGRID"].ToString());
            Txtid.Text = x.ToString();
            Txtid.Enabled = false;
            EntityOgrenci ent = new EntityOgrenci();
            List<EntityOgrenci> OgrList = BLLOgrenci.BllDetay(x);
            TxtAd.Text = OgrList[0].AD.ToString();
            TxtSoyad.Text = OgrList[0].SOYAD.ToString();
            TxtNumara.Text = OgrList[0].NUMARA.ToString();
            TxtFoto.Text = OgrList[0].FOTOGRAF.ToString();
            TxtSifre.Text = OgrList[0].SIFRE.ToString();
            TxtAd.Text = OgrList[0].AD.ToString();
        }
    }
}