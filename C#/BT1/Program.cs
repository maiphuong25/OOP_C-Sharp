//Bài 1: Nhập họ tên, tuổi, điểm....
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         string ten;
    //         string mon;
    //         int tuoi;
    //         float diem;
    //         Console.Write("Ho va ten: ");
    //         ten=Console.ReadLine();
    //         Console.Write("Tuoi: ");
    //         tuoi=int.Parse(Console.ReadLine());
    //         Console.Write("Mon hoc: ");
    //         mon=Console.ReadLine();
    //         Console.Write("Diem: ");
    //         diem=float.Parse(Console.ReadLine());
    //         Console.Write("Ban "+ten+" "+tuoi+" tuoi, hoc mon "+mon+" duoc "+diem+" diem");
    //     }
    // }


//Bài 2: Nhập từ bàn phím 1 số nguyên n và n số nguyên, việc nhập dừng lại khi đủ n hoặc nhập số 0. In màn hình tổng số lẻ
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int s=0;
//             Console.Write("n=");
//             int n=int.Parse(Console.ReadLine());
//             for (int i=0; i<n;i++)
//             {
//                 int so=int.Parse(Console.ReadLine());
//                 if (so==0) break;
//                 if (so%2==1) s+=so;
//             }
//             Console.WriteLine("Tong cac so le la: "+s);
//         }
//     }
// }

// -----------------------------------------------------------------------

// using System;
// namespace Vidu3
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Nhap vao so luong gio hang: ");
//             int n=int.Parse(Console.ReadLine());
//             int[] a=new int[n];
//             for (int i=0;i<n;i++)
//             {
//                 Random gio=new Random();
//                 a[i]=gio.Next(1,9);
//                 Console.WriteLine("Gio "+(i+1)+" co "+ a[i]+" do vat.");
//             }
//         }
//     }
// }



//Bài 2: Nhập từ bàn phím 1 số nguyên n và n số nguyên, việc nhập dừng lại khi đủ n hoặc nhập số 0. In màn hình tổng số lẻ
// class Program
// {
//     static void Main(string[] args)
//     {
//         int s=0;
//         Console.Write("Nhap n=");
//         int n=Convert.ToInt32(Console.ReadLine());
//         int[]A=new int[n];
//         for (int i=0;i<n;i++)
//         {   
//             Console.Write("Phan tu thu {0} la: ",i);
//             int m=Convert.ToInt32(Console.ReadLine());
//             A[i]=m;
//             if (A[i]%2!=0)
//             {
//                 s=s+A[i];
//             }
//         }
//     Console.WriteLine("Tong le={0}",s);
//     }
// }

//CHUONG 4

//Xây dựng một lớp Hình chữ nhật gồm Thuộc tính: Chiều dài và chiều rộng. Phương thức: 
// • Hàm khởi tạo
// • Hàm nhập, xuất
// • Hàm tính diện tích (Tinhdientich)
// Tính diện tích hình chữ nhật rồi in kết quả lên màn hình
// class HinhChuNhat
// {
//     public double Dai { get; set; }
//     public double Rong { get; set; }
//     public double Tinhdientich()
//     {
//         return Dai * Rong; }
//         public void Xuat()
//         {
//         Console.WriteLine("Chieu dai: {0}", Dai);
//         Console.WriteLine("Chieu rong: {0}", Rong);
//         Console.WriteLine("Dien tich HCN: {0}", Tinhdientich());
//         }
//         class Program
//         {
//         static void Main(string[] args) {
//         HinhChuNhat hcn = new HinhChuNhat();
//         hcn.Dai = 4.5;
//         hcn.Rong = 3.5;
//         hcn.Xuat();
//         Console.ReadLine();
//         }
//     } 
// }

