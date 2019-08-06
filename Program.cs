using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_ogrenci_ornek
{
    interface IKisi
    {
         int No { get; set; }
        
        string Ad { get; set; }

        string Soyad { get; set; }

        int Hesapla(int y,int b);
    }

    interface IOgrenci
    {

        int KursNo { get; set; }

        int DesrNotuHesabi(int n,int n2);

    }

    interface IEgirmen
    {
        int PortalNo { get; set; }

        int DersSuresi(int saat);

    }





    class Program:IKisi,IOgrenci,IEgirmen
    {
        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int KursNo { get; set; }
        public int PortalNo { get; set; }

 

        public int DersSuresi(int saat)
        {
            throw new NotImplementedException();
        }

        public int DesrNotuHesabi(int n, int n2)
        {
            throw new NotImplementedException();
        }

        public int Hesapla(int y, int b)
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {

        }
    }
}
