abstract class NHANVIEN
{
     public string? MaNV;
     public string? HoTen;
     public double HSLuong;
     public double LuongCB;
     public double Luong;
     virtual public void TinhLuong()
     {}
}
class CTV: NHANVIEN
{
     public double PhuCap;
     override public void TinhLuong()
     {
          base.TinhLuong();
          Luong=HSLuong*LuongCB*0.75 + PhuCap;
     }
}
class NHANVIENCT: NHANVIEN
{
     public double KPI;
     override public void TinhLuong()
     {
          base.TinhLuong();
          Luong=HSLuong*LuongCB*(1+KPI);
     }
}
class QUANLY: NHANVIEN
{
     public double PhuCapQL;
     override public void TinhLuong()
     {
          base.TinhLuong();
          Luong=HSLuong*LuongCB*2+PhuCapQL;
     }
}
class QUANLYNV
{
     public static CTV[] dsctv = new CTV[2];
     public static NHANVIENCT[] dsnvct = new NHANVIENCT[2];
     public static QUANLY[] dsquanly = new QUANLY[2];
     public static void NhapNhanVien(string input)
     {
          int i=0,j=0;
          string[,] sheet = new string[100,100];
          foreach (var row in input.Split("\n"))
          {
               j=0;
               foreach (var col in row.Split(";"))
               {
                    sheet[i,j]=col.Trim();
                    j++;
               }
               i++;
          }

          int ictv=0,invct=0,iql=0;
          for (j=0;j<i;j++)
          {
               if (sheet[j,0]=="CTV")
               {
                    dsctv[ictv] = new CTV();
                    dsctv[ictv].MaNV= sheet[j,1];
                    dsctv[ictv].HoTen= sheet[j,2];
                    dsctv[ictv].HSLuong= Convert.ToDouble(sheet[j,3]);
                    dsctv[ictv].LuongCB= Convert.ToDouble(sheet[j,4]);
                    dsctv[ictv].PhuCap= Convert.ToDouble(sheet[j,5]);
                    ictv++;
               }
               else if (sheet[j,0]=="NVCT")
               {
                    dsnvct[invct] = new NHANVIENCT();
                    dsnvct[invct].MaNV= sheet[j,1];
                    dsnvct[invct].HoTen= sheet[j,2];
                    dsnvct[invct].HSLuong= Convert.ToDouble(sheet[j,3]);
                    dsnvct[invct].LuongCB= Convert.ToDouble(sheet[j,4]);
                    dsnvct[invct].KPI= Convert.ToDouble(sheet[j,5]);
                    invct++;
               }
               else
               {
                    dsquanly[iql] = new QUANLY();
                    dsquanly[iql].MaNV= sheet[j,1];
                    dsquanly[iql].HoTen= sheet[j,2];
                    dsquanly[iql].HSLuong= Convert.ToDouble(sheet[j,3]);
                    dsquanly[iql].LuongCB= Convert.ToDouble(sheet[j,4]);
                    dsquanly[iql].PhuCapQL= Convert.ToDouble(sheet[j,5]);
                    iql++;
               }
          }
     }
     public static void XuatNV()
     {
          Console.WriteLine(@"Luong cua nhan vien:");
          foreach(CTV i in dsctv)
          {
               i.TinhLuong();
               Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5}",i.MaNV, i.HoTen, i.HSLuong, i.LuongCB, i.PhuCap, i.Luong);
          }
          foreach(NHANVIENCT i in dsnvct)
          {
               i.TinhLuong();
               Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5}",i.MaNV, i.HoTen, i.HSLuong, i.LuongCB, i.KPI, i.Luong);
          }
          foreach(QUANLY i in dsquanly)
          {
               i.TinhLuong();
               Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5}",i.MaNV, i.HoTen, i.HSLuong, i.LuongCB, i.PhuCapQL, i.Luong);
          }
     }
     public static void MaxLuong()
     {
          double max=0;
          int nvmax=0;
          int loainvmax=0;
          for (int i=0;i<dsctv.Length;i++)
          {
               if (dsctv[i].Luong>max)
               {
                    loainvmax=0;
                    nvmax=i;
                    max=dsctv[i].Luong;
               }
          }
          for (int i=0;i<dsnvct.Length;i++)
          {
               if (dsnvct[i].Luong>max)
               {
                    loainvmax=1;
                    nvmax=i;
                    max=dsnvct[i].Luong;
               }
          }
          for (int i=0;i<dsquanly.Length;i++)
          {
               if (dsquanly[i].Luong>max)
               {
                    loainvmax=2;
                    nvmax=i;
                    max=dsquanly[i].Luong;
               }
          }
          Console.Write(@"Nhan vien co luong cao nhat: ");
          if (loainvmax==0)
               Console.WriteLine(dsctv[nvmax].HoTen);
          else if (loainvmax==1)
               Console.WriteLine(dsnvct[nvmax].HoTen);
          else
               Console.WriteLine(dsquanly[nvmax].HoTen);  
     }
     public static void MinLuong()
     {
          double min=0;
          int nvmin=0;
          int loainvmin=0;
          for (int i=0;i<dsctv.Length;i++)
          {
               if (dsctv[i].Luong<min)
               {
                    loainvmin=0;
                    nvmin=i;
                    min=dsctv[i].Luong;
               }
          }
          for (int i=0;i<dsnvct.Length;i++)
          {
               if (dsnvct[i].Luong<min)
               {
                    loainvmin=1;
                    nvmin=i;
                    min=dsnvct[i].Luong;
               }
          }
          for (int i=0;i<dsquanly.Length;i++)
          {
               if (dsquanly[i].Luong<min)
               {
                    loainvmin=2;
                    nvmin=i;
                    min=dsquanly[i].Luong;
               }
          }
          Console.Write(@"Nhan vien co luong thap nhat: ");
          if (loainvmin==0)
               Console.WriteLine(dsctv[nvmin].HoTen);
          else if (loainvmin==1)
               Console.WriteLine(dsnvct[nvmin].HoTen);
          else
               Console.WriteLine(dsquanly[nvmin].HoTen);
     }
}
class Program
{
     static void Main(string[] args)
     {
          string input=@"CTV;abc213;Pham Hoang Trieu;5;3000000;1000000
NVCT;abc23;Pham Vo Minh Nhat;6;1000000;1
QL;abc243;Pham Hoang Nhat;3;1000000;1000000
NVCT;abc253;Pham Thanh Minh;4;1000000;1.5
QL;abc263;Pham Thanh Huong;2;1000000;2000000
CTV;abc273;Pham Thi Thuong;1;1000000;1";
          QUANLYNV.NhapNhanVien(input);
          QUANLYNV.XuatNV();
          QUANLYNV.MaxLuong();
          QUANLYNV.MinLuong();
     }
}