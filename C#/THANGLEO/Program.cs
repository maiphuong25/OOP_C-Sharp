class Thangleo
{
    public string MaThang;
    public string LoaiThang;
    public string Chieucao;
    public int Soluong;
    public double GiaBan;
    public void NhapThang()
    {
        Console.Write("Ma thang: "); MaThang = Console.ReadLine();
        Console.Write("Loai thang: "); LoaiThang = Console.ReadLine();
        Console.Write("Chieu cao: "); Chieucao = Console.ReadLine();
        Console.Write("So luong: "); Soluong = Convert.ToInt32(Console.ReadLine());
        Console.Write("Gia ban (trieu VND): "); GiaBan = Convert.ToDouble(Console.ReadLine());
    }
    public void XuatThang()
    {
        Console.WriteLine("Ma: {0}, Loai: {1}, Chieu cao: {2}, So luong: {3}, Gia: {4}",MaThang, LoaiThang, Chieucao, Soluong, GiaBan);
    }
}
class DanhsachThang
{
    public Thangleo [] DS = new Thangleo[100];
    public int dem = 0;
    public DanhsachThang()
    {
        Nhap();
    }
    public void Nhap()
    {
        string[,] lines = new string [100,100];
        string input = File.ReadAllText("thangleo.txt");
        int i = 0, j = 0;
        foreach (var hang in input.Split("\n"))
        {
            j = 0;
            foreach (var cot in hang.Split("  "))
            {
                lines[i,j] = cot;
                j++;
            }
            i++;
        }
        dem = i;
        for (i=0; i<dem; i++)
        {
            Thangleo a = new Thangleo();
            a.MaThang = lines[i,0];
            a.LoaiThang = lines [i,1];
            a.Chieucao = lines [i,2];
            a.Soluong = Int32.Parse(lines[i,3]);
            a.GiaBan = Double.Parse(lines[i,4]);
            DS[i] = a;
        }
    }
    public void Themmoi()
    {
        Console.WriteLine("THEM MOI");
        Thangleo m = new Thangleo();
        m.NhapThang();
        DS[dem] = m;
        dem++;
        Console.WriteLine("Da them moi thanh cong");
    }
    public void Xuat()
    {
        Console.WriteLine("XUAT");
        Console.WriteLine("MaThang  LoaiThang  Chieucao  Soluong  Giaban (trieu vnd)");
        for (int i=0; i<dem; i++)
        {
            DS[i].XuatThang();
        }
    }
    public void TimSanPham()
    {
        Console.WriteLine("TIM SAN PHAM");
        Console.Write("Nhap chieu cao toi thieu: "); string min = Console.ReadLine();
        Console.Write("Nhap chieu cao toi da: "); string max = Console.ReadLine();
        int ktra=0;
        for (int i=0; i<dem; i++)
        {
            string p = DS[i].Chieucao;
            if ((string.Compare(p, min, true)>0) & (string.Compare(p, max, true)<0))
            {
                DS[i].XuatThang();
                ktra++;
            } 
        }
        if (ktra==0) Console.WriteLine("Khong tim thay thang phu hop");
    }
    public void Sapxep()
    {
        Console.WriteLine("SAP XEP");
        for (int i=0; i<dem; i++)
        {
            for (int j=i+1; j<dem; j++)
            {
                if (DS[i].GiaBan > DS[j].GiaBan)
                {
                    Thangleo m = DS[i];
                    DS[i]=DS[j];
                    DS[j]=m;
                }
            }
        }
        Console.WriteLine("Da sap xep xong");
    }
    public void Ktra()
    {
        Console.WriteLine("KIEM TRA");
        Console.Write("Nhap Ma thang: "); string Ma = Console.ReadLine();
        Console.Write("Nhap So luong: "); int soluong = Convert.ToInt32(Console.ReadLine());
        for (int i=0; i<dem; i++)
        {
            if (DS[i].MaThang == Ma)
            {
                if (DS[i].Soluong == soluong)
                {
                    Console.WriteLine("OK");
                }
                else Console.WriteLine("Chi con {0} thang. Khong du hang", DS[i].Soluong);
            }
        }
    }
    public void SoSanh()
    {
        Console.WriteLine("SO SANH");
        string[] ds = new string[100]; int phu=0;
        for (int i=0; i<dem; i++)
        {
            double min, max; Thangleo tmin_=null, tmax_=null;
            min = max = DS[i].GiaBan;
            for (int j=i+1; j<dem; j++)
            {
                if (DS[i].LoaiThang==DS[j].LoaiThang & DS[i].Chieucao == DS[j].Chieucao)
                {
                    if (DS[j].GiaBan < min) { min=DS[j].GiaBan; tmin_ = DS[j]; }
                    else { max=DS[j].GiaBan; tmax_ = DS[j]; }
                }
            }
            if (ds.Contains(DS[i].LoaiThang + DS[i].Chieucao+"")) continue;
            else if (tmin_!=null & tmax_!=null)
            {
                tmin_.XuatThang(); tmax_.XuatThang();
                ds[phu] = DS[i].LoaiThang + DS[i].Chieucao;
                phu++;
            }
        }
    }
}

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"
        ________MENU_________
        Bam 1: Them moi danh sách
        Bam 2: Xuat danh sach
        Bam 3: Tim san pham
        Bam 4: Sap xep
        Bam 5: Kiem tra
        Bam 6: So sanh
        Bam 0: Exit");
        DanhsachThang ds = new DanhsachThang();
        while (true)
        {
            Console.Write("Chon buoc: "); int n = Convert.ToInt32(Console.ReadLine());
            if      (n==0) break;
            else if (n==1) ds.Themmoi();
            else if (n==2) ds.Xuat();
            else if (n==3) ds.TimSanPham();
            else if (n==4) ds.Sapxep();
            else if (n==5) ds.Ktra();
            else if (n==6) ds.SoSanh();
        }
    }
}