// class program
// {
//     static void Main(string[]args)
//     {
//         int i_max =0; int i_min = 0;
//         double Tong=0, Tich=1;
        
//         Console.Write("n=");
//         int n=int.Parse(Console.ReadLine());
//         double[]A=new double[n];
//         for (int i=0;i<n;i++)
//         {
//           A[i]=Convert.ToDouble(Console.ReadLine());
//         }
//         Console.Write("A= [");
//         for (int i=0;i<n;i++)
//         {
//             Console.Write(A[i]);
//             if (i != (n-1))
//                 Console.Write(",");
//         }
//         Console.WriteLine("]");
//         // int n = 10;
//         // double[] A= {2,-5,7.6,-12,6.5,-4.5,-9.1,-3.4,15,1};
//         for (int i=0;i<n;i++)
//         {
//             if (A[i]<0)
//                 Tong-=A[i]; //Tong=Tong-A[i]
//         }
//         Console.WriteLine("Tong = {0}",Tong);
        
//         for (int i=0;i<n;i++)
//         {
//             if (A[i]==A.Max())
//                 i_max=i;
//             else if (A[i]==A.Min())
//                 i_min=i;
//         }
//         for (int i=0;i<n;i++)
//         {
//             if (((i_max<i) & (i_min>i)) | ((i_max>i) & (i_min<i)))
//                 Tich*=A[i];
//         }
//         Console.WriteLine("Tich = {0}",Tich);

//         for (int i=0;i<n;i++) 
//         {
//             for (int j=i+1;j<n;j++) 
//             {
//                 if (A[i] > A[j]) 
//                 {
//                     double m=A[i];
//                     A[i]=A[j];
//                     A[j]=m;
//                 }
//             }
//         }
//         Console.Write("A_tang = [");
//         for (int i=0;i<n;i++)
//         {
//             Console.Write(A[i]);
//             if (i != (n-1))
//                 Console.Write(",");
//         }
//         Console.WriteLine("]");
//     }
// }

//Ta có 3 lớp Animal, Cat, Dog. Trong đó Cat và Dog kề thừa từ lớp Animal. Trong các lớp đều có phương thức Speak()
// class Animal
// {
//     public virtual void Speak()
//     {
//         Console.WriteLine("Animal is speaking. . .");
//     } 
// }
// class Cat : Animal
// {
//     public override void Speak()
//     {
//         Console.WriteLine(" Cat is speaking Meo Meo");
//     } 
// }
// class Dog : Animal
// {
//     public override void Speak()
//     {
//         Console.WriteLine(" Dog is speaking Gau Gau");
//     } 
// }
// class Program
// {
//     static void Main(string[] args) 
//     {
//     Animal cat = new Cat();
//     Animal dog = new Dog();
//     cat.Speak();
//     dog.Speak();
//     } 
// }


