using System;
namespace project
{
    class test
    {
        public static void Main()
        {
            Console.WriteLine("inter two numbers");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
           
          BMM(a,b);
            KMM(a, b);

        }
        private  static void BMM(int a, int b)
        {
            int n = 0;
            int m = 0;
            int e = 0;
            if (a < b)
            {
                m = b;
                n = a;
            }
            if(a>=b)
            {
                m = a;
                n = b;
            }
            e= (m % n);
           while(e>0)
            {
                
                    m = a;
                    a= e;
                    e = (m % a);

                
            }
          
            Console.WriteLine("BMM is:" + a);

        }
        private static void KMM(int x,int y)
        {
            int counter = 0;
            for(int i = 2; i <= x && i<=y;i++)
                
                {
                    if(x%i==0 && y%i==0)
                {
                    counter = 1;
                     
                }
                    if (counter==0)
                        
                            Console.WriteLine("KMM is:" + (x * y));
               
                    
                else  
                        { Console.WriteLine("KMM is:" + (x * y) / (x%y)); }
               
                    
                    
                }
        }
    }
}