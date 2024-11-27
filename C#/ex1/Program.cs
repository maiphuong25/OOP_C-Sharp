// 1.Kiểm tra số có phải âm hay không
class program
{
    static void Main(string[] args)
    {
        Console.Write("n=");
        int num=Convert.ToInt32(Console.ReadLine());
        if (num<0)
        {
            Console.WriteLine("The number is negative");
        }
    }

}

// 2. Ví dụ while
// class program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("nhap n=");
//         int i=1;
//         int n=Convert.ToInt32(Console.ReadLine());
//         while (i<=n)
//         {
//             Console.WriteLine(i);
//             i++;
//         }
//     }

// }

// 3.Ví dụ for
// class program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Nhap n=");
//         int i=1;
//         int n=Convert.ToInt32(Console.ReadLine());
//         for (i=1;i<=n;i++);
//             Console.WriteLine(i);
//     }
// }



// // ///---------benhnhan-----------//
// class Hospital
// {
//      private int MaBN;
//      private string TenBN;
//      private string Benh;
//      private string BHYT;
//      private int SoNgayNhapVien;
//      public int Mabn
//      {get {return MaBN;}
//      set {MaBN=value;}}
//      public string Ten
//      {get {return TenBN;}
//      set {TenBN=value;}}
//      public string benh
//      {get {return Benh;}
//      set {Benh=value;}}
//      public string bhyt
//      {get {return BHYT;}
//      set {BHYT=value;}}
//      public int songaynhapvien
//      {get {return SoNgayNhapVien;}
//      set {SoNgayNhapVien=value;}}
//      public void xuat()
//      {
//           Console.WriteLine("{0} | {1} | {2} | {3} | {4}",MaBN,TenBN,Benh,BHYT,SoNgayNhapVien);
//      }
// }
// class QuanLyBenhNhan
// {
//      public static Hospital[] Benhnhan = new Hospital[0];
//      public static void ThemDS()
//      {
//           string[,] text = new string[100,100];
//           string input = @"191525;       Tran Huy Hoang;             Xuong Khop;         Co;               14
// 124123;       Le Thi Ha;                       Mat;                       Co;               5
// 121513;       Nguyen Thanh Nga;        Tieu hoa;               Co;               5
// 198512;       Nguyen Ngoc Huy;          Lao ;                      Khong;        21
// 192621;       Tran Thi Hang;                Covid;                    Co;               21
// 980125;       Nguyen Gia Huy;            Da day;                  Co;               5
// 123631;       Vo Ha Tram;                    Xuong Khop;         Co;               3
// 192126;       Vu Thu Phuong ;             Covid;                    Co;               21
// 824122;       Truong Van Thang ;         Tieu hoa;               Khong;        1
// 612863;       Tran Van Trung;              Mat;                       Khong;        2
// 192621;       Pham Cong Hoai;            Covid;                    Co;               14
// 211752;       Pham Thi Ngoc;              Xuong Khop;         Co;               7
// 199178;       Le Van Huy;                    Lao;                       Khong;        14
// 129862;       Pham Hoang My;             Tieu hoa;               Co;               5
// 180876;       Le Trung Hieu;                Covid;                    Khong;        14
// 133126;       Nguyen Hoai Nam;          Mat;                       Co;               3";
//           int i=0,j=0;
//           foreach (var row in input.Split("\n"))
//           {
//                j=0;
//                foreach (var col in row.Trim().Split(";"))
//                {
//                     text[i,j] = col.Trim();
//                     j++;
//                }
//                i++;
//           }
//           Benhnhan = new Hospital[i];
//           for (int a = 0; a<i; a++)
//           {
//                QuanLyBenhNhan.Benhnhan[a] = new Hospital();
//                Benhnhan[a].Mabn=Convert.ToInt32(text[a,0]);
//                Benhnhan[a].Ten=text[a,1];
//                Benhnhan[a].benh=text[a,2];
//                Benhnhan[a].bhyt=text[a,3];
//                Benhnhan[a].songaynhapvien=Convert.ToInt32(text[a,4]);
//           }
//      }
//      static public void Them()
//      {
//           Hospital[] tam = new Hospital[Benhnhan.Length];
//           Array.Copy(Benhnhan,tam,Benhnhan.Length);
//           Benhnhan = new Hospital[tam.Length+1];
//           Array.Copy(tam,Benhnhan,tam.Length);
//           Benhnhan[Benhnhan.Length-1] = new Hospital();
//           Console.Write("Nhap MaBN: ");
//           Benhnhan[Benhnhan.Length-1].Mabn=Convert.ToInt32(Console.ReadLine());
//           Console.Write("Nhap TenBN: ");
//           Benhnhan[Benhnhan.Length-1].Ten=Console.ReadLine();
//           Console.Write("Nhap Benh: ");
//           Benhnhan[Benhnhan.Length-1].benh=Console.ReadLine();
//           Console.Write("Nhap BHYT: ");
//           Benhnhan[Benhnhan.Length-1].bhyt=Console.ReadLine();
//           Console.Write("Nhap So ngay nhap vien: ");
//           Benhnhan[Benhnhan.Length-1].songaynhapvien=Convert.ToInt32(Console.ReadLine());
//           Console.WriteLine("Da them thanh cong !");
//      }
//      static public void CapNhat()
//      {
//           Console.Write("Nhap MaBN can cap nhat: ");
//           int cantim = Convert.ToInt32(Console.ReadLine());
//           int t = 0;
//           foreach (Hospital i in Benhnhan)
//           {
//                if (i.Mabn==cantim)
//                {
//                     t=1;
//                     i.xuat();
//                     Console.Write("Nhap TenBN: ");
//                     i.Ten=Console.ReadLine();
//                     Console.Write("Nhap Benh: ");
//                     i.benh=Console.ReadLine();
//                     Console.Write("Nhap BHYT: ");
//                     i.bhyt=Console.ReadLine();
//                     Console.Write("Nhap So ngay nhap vien: ");
//                     i.songaynhapvien=Convert.ToInt32(Console.ReadLine());
                    
//                     Console.WriteLine("Da cap nhat thanh cong !");
//                }
//           }
//           if (t==0)
//                Console.WriteLine("Khong tim thay benh nhan !");
//      }
//      static public void ThanhToan()
//      {
//           Console.Write("Nhap MaBN can thanh toan: ");
//           int Mabncant hanhtoan=Convert.ToInt32(Console.ReadLine());
//           Console.Write("Nhap TenBN can thanh toan: ");
//           string Tenbncanthanhtoan=Console.ReadLine();
//           int tien=0; int t = 0;
//           foreach( Hospital i in Benhnhan)
//           {
//                if (i.Mabn==Mabncanthanhtoan & i.Ten==Tenbncanthanhtoan)
//                {
//                     t=1;
//                     tien=i.songaynhapvien*150000;
//                     if (i.bhyt=="Co")
//                     {
//                          tien=tien*85/100;
//                     }
//                     Console.WriteLine("Tien can thanh toan la: {0}",tien);
//                     break;
//                }
//           }
//           if (t==0)
//                Console.WriteLine("Khong tim thay benh nhan !");
//      }
//      static public void xuat()
//      {
//           foreach( Hospital i in Benhnhan)
//           {
//                i.xuat();
//           }
//      }
// }
// class Program
// {
//      static void Main(string[] args)
//      {
//           QuanLyBenhNhan.ThemDS();
//           while (true)
//           {
//                Console.WriteLine(@"
//                1. Them benh nhan
//                2. Cap nhat benh nhan
//                3. Thanh toan vien phi
//                0. Exit");
//                Console.Write("Nhap so: ");
//                string so = Console.ReadLine();
//                if (so=="1")
//                     QuanLyBenhNhan.Them();
//                else if (so=="2")
//                     QuanLyBenhNhan.CapNhat();
//                else if (so=="3")
//                     QuanLyBenhNhan.ThanhToan();
//                else if (so=="0")
//                     break;

//           }
//      }
// }


//--------------candidate------------//

// class candidate
// {
//     static void Main(string[]args)
//     {
//         dsthisinh a = new dsthisinh();
//         a.Nhapds();
//         while(true)
//         {
//             Console.WriteLine("\nĐối tượng Thi sinh");
//             Console.WriteLine("Tao Menu");
//             Console.WriteLine("1.Thêm");
//             Console.WriteLine("2.Cập nhật (Chỉnh sửa thí sinh theo mã thí sinh (MaTS)");
//             Console.WriteLine("3.Tra cứu (Tìm, Xuất danh sách thí sinh đã đậu vào ngành HTTTQL)Biết rằng, điểm chuẩn (Đã bao gồm Điểm học bạ + Điểm ưu tiên) của ngành HTTTQL là 26 điểm");
//             Console.WriteLine("0.exit");
//             Console.Write("nhap tuy chon");
//             int key =Convert.ToInt32(Console.ReadLine());
//             if (key==1)
//             {
//                 Console.WriteLine("Thêm mới danh sách");
//                 a.Them();
//             }
//             else if (key==2)
//             {
//                 Console.WriteLine("Chỉnh sửa thí sinh theo mã thí sinh (MaTS)");
//                 a.CapnhatvaXuat();
//             }
//             else if ((key!=1)&(key!=2)&(key!=3)&(key!=0))
//             {
//                 Console.WriteLine("cau lenh bi sai.Moi nhap lai");
//             }
//             else if (key==0)
//             {
//                 Console.WriteLine("thoat");
//                 break;
//             }
//         }
//     }
//     class dsthisinh
//     {
//         public string[,] A = new string[20, 5];
//         public void Nhapds()
//         {
//             int i=0,j=0;
//             string[] lines = File.ReadAllLines(@"candidate.txt");
//             foreach(string s in lines)
//             {
//                 j=0;
//                 string[] authorsList = s.Split(" ;");
//                 foreach (string author in authorsList)
//                 {
//                     if(j==5)
//                     {
//                         break;
//                     }
//                    A[i, j] = Convert.ToString(author);
//                     j++;
//                 }
//                 i++;
//             }
//         }
//         public void CapnhatvaXuat()
//         {
//             int i,j;
//             for (i=0;i<20;i++)
//             {
//                 for (j=0;j<5;j++)
//                 {
//                     Console.Write(A[i,j]+"");
//                 }
//                 Console.WriteLine();
//                 if (A[i+1,0]==null)
//                 {
//                    break;
//              }
//           }
//         }
//         public void Them()
//         {
//             int i,j;
//             string a;
//             for (i=0; i<20;i++)
//             {
//                 if (A[i,0]==null)
//                 {
//                     Console.WriteLine("them 1 hs moi");
//                     A[i,0]=Console.ReadLine();
//                     Console.Write("MaTS");
//                     A[i,1]=Console.ReadLine();
//                     Console.Write("Ten");
//                     A[i,2]=Console.ReadLine();
//                     Console.Write("GioiTinh");
//                     A[i,3]=Console.ReadLine();
//                     Console.Write("diemHB");
//                     A[i,4]=Console.ReadLine();
//                     Console.Write("diemUT");
//                     break;

//                 }
//             }    
//         }
//     }  
// }


            
//-----------------fashion----------------//

// class Fashion
// {
//     private int SoLuong;
//     private int MaSP;
//     private string TenSP;
//     private string PhanLoai;
//     private int GiaBan;
//     public void xuat()
//     {
//         Console.WriteLine("{0} ; {1} ; {2} ; {3} ; {4}", MaSP, TenSP, SoLuong, PhanLoai, GiaBan);
//     }
//     public int Masp{get { return MaSP; }
//     set { MaSP = value; }}
//     public int Soluong{get { return SoLuong; }
//     set { SoLuong = value; }}
//     public string Tensp{get { return TenSP; }
//     set { TenSP = value; }}
//     public string Phanloai{get { return PhanLoai; }
//     set { PhanLoai = value; }}
//     public int Giaban{get { return GiaBan; }
//     set { GiaBan = value; }}

// }
// class QLFashion
// {
//     public static Fashion[] ThoiTrang = new Fashion[0];
//     public static void Them()
//     {
//         string[,] sheet = new string [100,100];
//         string input = @"145 ; Ao so mi ; 10; Ao; 20000
//         724; Quan tay ; 15; Quan; 355000";// khuc ni m cop het cai dssanpham(text) bo vao giua hai dau ""//
//         int i=0,j=0;
//         foreach (var row in input.Split('\n'))
//         {
//             j=0;
//             foreach (var col in row.Trim().Split(';'))
//             {
//                 sheet[i,j]=col.Trim();
//                 j++;
//             }
//             i++;
//         }
//         ThoiTrang = new Fashion[i];
//         for(int a = 0; a<i; a++)
//         {
//             QLFashion.ThoiTrang[a]=new Fashion();
//             ThoiTrang[a].Masp=Convert.ToInt32(sheet[a,0]);
//             ThoiTrang[a].Tensp=sheet[a,1];
//             ThoiTrang[a].Soluong=Convert.ToInt32(sheet[a,2]);
//             ThoiTrang[a].Phanloai=sheet[a,3];
//             ThoiTrang[a].Giaban=Convert.ToInt32(sheet[a,4]);
//         }
//     }
//     public static void TimKiem()
//     {
//         if (ThoiTrang!=null)
//         {
//             Console.Write("nhap phan loai can tim: ");
//             string cantim = Console.ReadLine();
//             foreach (Fashion i in ThoiTrang)
//             {
//                 if (i.Phanloai==cantim)
//                 {
//                     i.xuat();
//                 }
//             }
//         }
//     }
//     public static void KiemTra()
//     {
//         if (ThoiTrang!=null)
//         {
//             Console.Write("Nhap ma sp can mua: ");
//             int maspcantim = Convert.ToInt32(Console.ReadLine());
//             Console.Write("Nhap soluong sp can mua: ");
//             int soluongcanmua = Convert.ToInt32(Console.ReadLine());
//             foreach (Fashion i in ThoiTrang)
//             {
//                 if (i.Masp==maspcantim)
//                 {
//                     if (soluongcanmua==i.Soluong)
//                     {
//                         Console.WriteLine("Du so luong");
//                     }
//                     else
//                     {
//                         Console.WriteLine("Khong du so luong");
//                     }
//                 }
//             }
//         }
        
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         while (true)
//         {
//             Console.WriteLine(@"
//             1. Them
//             2. Tim Kiem
//             3. Kiem tra
//             0. Exit");
//             Console.Write("Nhap so ");
//             string so = Console.ReadLine();
//             if (so == "1")
//             {
//                 QLFashion.Them();
//             } 
//             else if (so == "2")
//             {
//                 QLFashion.TimKiem();
//             } 
//             if (so == "3")
//             {
//                 QLFashion.KiemTra();
//             } 
//             if (so == "0")
//             {
//                 break;
//             } 
//         }
//     }
// }