//bài 1
// class Customer
// {
//     public string Ten;
//     public double Gia;
//     public virtual void DeoThe()
//     {
//         Console.Write("Deo the mau: ");
//     }
//     public virtual void nhap()  
//     {
//         Console.Write("Nhap ten: ");
//         Ten = Console.ReadLine();
//     }
// }
// class Aldult : Customer
// {
//     public string CMND;
//     public override void nhap()
//     {
//         base.nhap();
//         Console.Write("CMND: ");
//         CMND=Console.ReadLine();
//         Gia = 250000;
//         Console.WriteLine(Gia);
//     }
//     public override void DeoThe()
//     {
//         base.DeoThe();
//         Console.WriteLine("Do");
//     }
// }
// class Childrent : Customer
// {
//     public int chieucao;
//     public override void nhap()
//     {
//         base.nhap();
//         Console.Write("Chieu cao: ");
//         chieucao=int.Parse(Console.ReadLine());
//         if(chieucao >= 100)
//         {
//             Gia = 130000;
//         }
//         else
//         {
//             Gia = 0;
//         }
//         Console.WriteLine(Gia);
//     }
//     public override void DeoThe()
//     {
//         base.DeoThe();
//         Console.WriteLine("Xanh");
//     }
// }
// class program
// {
//     public static void Main(string[]args)
//     {
//         double Doanhthu = 0;
//         Aldult[] nl = new Aldult[100];
//         Childrent[] te = new Childrent[100];
//         int snl = 0, ste = 0;
//         int chon = 0;
//         while (chon != 3) 
//         {
//             Console.WriteLine(@"
//             ---MENU---
//             1. Nguoi lon
//             2. Tre em
//             3. Tong Doanh thu");
//             chon=int.Parse(Console.ReadLine());
//             if (chon == 1)
//             {
//                 nl[snl] = new Aldult();
//                 nl[snl].nhap();
//                 nl[snl].DeoThe();
//                 Doanhthu+=nl[snl].Gia;
//                 snl+=1;
//             }
//             else if (chon == 2)
//             {
//                 te[ste] = new Childrent();
//                 te[ste].nhap();
//                 te[ste].DeoThe();
//                 Doanhthu+=te[ste].Gia;
//                 ste+=1;
//             }
//             else if (chon == 3)
//             {    
//                 Console.WriteLine("Tong Doanh Thu: "+ Doanhthu);
//                 break;
//             }
//         }
//     }
// }

//bài 2
class Vinhome
{
    public string ID;
    public double Area, Price;
    public int Floor, n, GiaSCB=200000, GiaSCC=500000;
    public string[,] RoomCB = new string[100,10];
    public string[,] RoomCC = new string[100,10]; 
    public void Nhap()
    {
        Console.Write("So luong phong muon nhap: ");
        n = Convert.ToInt32(Console.ReadLine());
        for (int i=0;i<n;i++)
        {
            Console.Write("Nhap id phong thu {0}: ",i+1);
            ID = Console.ReadLine();
            Console.Write("Nhap dien tich phong {0}: ",i+1);
            Area = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tang cua phong {0}: ",i+1);
            Floor = Convert.ToInt32(Console.ReadLine());
            RoomCB[i,0]=ID;
            RoomCB[i,1]=Convert.ToString(Area);
            RoomCB[i,2]=Convert.ToString(Floor);
            RoomCC[i,0]=ID;
            RoomCC[i,1]=Convert.ToString(Area);
            RoomCC[i,2]=Convert.ToString(Floor);
        }
    }
}
class Basic: Vinhome
{
    public void GiaBasic()
    {
        base.Nhap();
        Console.WriteLine("-----Danh sach can ho co ban-----");
        for (int i=0;i<n;i++)
        {
            Price=GiaSCB*Convert.ToDouble(RoomCB[i,1]);
            RoomCB[i,3]=Convert.ToString(Price);
            Console.WriteLine("ID:{0}, Dien tich: {1}, Tang: {2}, Gia: {3}",RoomCB[i,0], RoomCB[i,1], RoomCB[i,2], RoomCB[i,3]);
        }
    }
    public void SapxepCB()
    {
        double max = Convert.ToDouble(RoomCB[0,3]);
        for (int i=1;i<n;i++)
        {
            if (Convert.ToDouble(RoomCB[i,3])>max)
            {
                max=Convert.ToDouble(RoomCB[i,3]);
            }
        }
        Console.WriteLine("-----Phong co gia cao nhat-----");
        for (int i=0;i<n;i++)
        {
            if (Convert.ToDouble(RoomCB[i,3])==max)
            {
                Console.WriteLine("ID:{0}, Dien tich: {1}, Tang: {2}, Gia: {3}",RoomCB[i,0], RoomCB[i,1], RoomCB[i,2], RoomCB[i,3]);
            }
        }
    }
}
class Condo: Vinhome
{
    public void GiaCondo()
    {
        base.Nhap();
        for (int i=0;i<n;i++)
        {
            Console.Write("Nhap huong cua can ho {0}: ",i+1);
            string view = Console.ReadLine();
            RoomCC[i,3]=view;
            if (view=="Ho boi")
            {
                Price=GiaSCC*Convert.ToDouble(RoomCC[i,1])*1.1;
                RoomCC[i,4]=Convert.ToString(Price);
            }
            else if (view=="Bien")
            {
                Price=GiaSCC*Convert.ToDouble(RoomCC[i,1])*1.4;
                RoomCC[i,4]=Convert.ToString(Price);
            }
            else if (view=="Thanh pho")
            {
                Price=GiaSCC*Convert.ToDouble(RoomCC[i,1])*1.2;
                RoomCC[i,4]=Convert.ToString(Price);
            }
            else
            {
                Price=GiaSCC*Convert.ToDouble(RoomCC[i,1]);
                RoomCC[i,4]=Convert.ToString(Price);
            }
        }
        Console.WriteLine("-----Danh sach can ho cao cap-----");
        for (int i=0;i<n;i++)
        {
            Console.WriteLine("ID:{0}, Dien tich: {1}, Tang: {2}, View: {3}, Gia: {4}",RoomCC[i,0], RoomCC[i,1], RoomCC[i,2], RoomCC[i,3], RoomCC[i,4]);
        }
    }
    public void SapxepCC()
    {
        double max = Convert.ToDouble(RoomCC[0,4]);
        for (int i=1;i<n;i++)
        {
            if (Convert.ToDouble(RoomCC[i,4])>max)
            {
                max=Convert.ToDouble(RoomCC[i,4]);
            }
        }
        Console.WriteLine("-----Phong co gia cao nhat-----");
        for (int i=0;i<n;i++)
        {
            if (Convert.ToDouble(RoomCC[i,4])==max)
            {
                Console.WriteLine("ID:{0}, Dien tich: {1}, Tang: {2}, View: {3}, Gia: {4}",RoomCC[i,0], RoomCC[i,1], RoomCC[i,2], RoomCC[i,3], RoomCC[i,4]);
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Basic B = new Basic();
        Condo C = new Condo();
        while (true)
        {
            Console.Write("Nhap MENU: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n==1)
            {
                B.GiaBasic();
            }
            if (n==2)
            {
                B.SapxepCB();
            }
            if (n==3)
            {
                C.GiaCondo();
            }
            if (n==4)
            {
                C.SapxepCC();
            }
            if (n==0)
            {
                break;
            }
        }
    }
}