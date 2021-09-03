﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if(p.AD!=null && p.SOYAD!=null && p.NUMARA!=null && p.SIFRE!=null && p.FOTOGRAF!=null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        }
    }
}