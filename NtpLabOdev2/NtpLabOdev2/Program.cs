using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtpLabOdev2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 2. ÖDEV  Uygulama1
            /*
             * Aşağıda verilen ifadeler için sonuçları hesaplayarak operatörlerin işlem önceliğini belirleyiniz.
                 36 / 6 / 3
                 8 / 4 * 2
                 4 2 + 6 - 1 + 3
                 (3 + 2) * 4 - 1 + 6 / 2
                 (5 - 2) * 2 - 1 + 8 2 / 2
            */
            double islem1 = 36 / 6 / 3; //(36/6)3=2
            double islem2 = 8 / 4 * 2; // (8/4)*2 = 4
            double islem3 = Math.Pow(4, 2) + (6 - 1 + 3); // (4^2)+6-1+3 =
            double islem4 = (3 + 2) * 2 - 1 + 6 / 2; //((3+2)*4)-1 + (6/2)
            double islem5 = (5 - 2) * 2 - 1 + Math.Pow(8, 2) / 2;//((5-2)*2)-1+(8^2)/2)




            #endregion

            #region 2.ödev Uygulama2
            /*x = 24, y = 11 ve z = 34 için aşağıdaki mantıksal ifadelerin doğru veya yanlış olduklarını ekrana yazınız.
             * 23 == 55 && 76 > 45 && 5 < 12
             * 23 >= 23 && 45 != 18
             * x > y && z == y && z < x
             * z > x &&  y < x
             */
            int x = 24;
            int y = 11;
            int z = 34;

            bool işlem1 = (23 == 55 && 76 > 45 && 5 < 12);
            bool işlem2 = (23 >= 23 && 45 != 18);
            bool işlem3 = (x > y && z == y && z < x);
            bool işlem4 = (z > x && y < x);


            #endregion


            #region 2.ödev Uygulama3
            //Girilen iki sayının biri birine tam bölünüp bölünemediğini bulan programı yazınız.
            Console.WriteLine("1.sayıyı girin");
            int birincisayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayıyı girin");
            int ikincisayi = Convert.ToInt32(Console.ReadLine());

            if (birincisayi % ikincisayi == 0)
            {
                Console.WriteLine("Girilen sayılar tam bölünüyor. Sonuç:" +  (birincisayi / ikincisayi));
            }
            else
            {
                Console.WriteLine("Girdiğiniz iki sayı birbirine tam bölünmüyor");
            }


            #endregion
            #region 2. ödev Uygulama4
            //gg.aa.yyyy formatında girilen tarih bilgisinden hangi ayda olduğumuzu gösteren programı yazınız.


            Console.Write("Doğum Tarihinizi Giriniz (gg.aa.yyyy) : ");
            string uygulama4_Girdi = Console.ReadLine();
            DateTime uygulama5_Tarih = DateTime.Parse(uygulama4_Girdi);

            if (uygulama5_Tarih.Month == 1)
                Console.WriteLine("Doğduğunuz Ay OCAK");
            else if (uygulama5_Tarih.Month == 2)
                Console.WriteLine("Doğduğunuz Ay ŞUBAT");
            else if (uygulama5_Tarih.Month == 3)
                Console.WriteLine("Doğduğunuz Ay MART");
            else if (uygulama5_Tarih.Month == 4)
                Console.WriteLine("Doğduğunuz Ay NİSAN");
            else if (uygulama5_Tarih.Month == 5)
                Console.WriteLine("Doğduğunuz Ay MAYIS");
            else if (uygulama5_Tarih.Month == 6)
                Console.WriteLine("Doğduğunuz Ay HAZİRAN");
            else if (uygulama5_Tarih.Month == 7)
                Console.WriteLine("Doğduğunuz Ay TEMMUZ");
            else if (uygulama5_Tarih.Month == 8)
                Console.WriteLine("Doğduğunuz Ay AĞUSTOS");
            else if (uygulama5_Tarih.Month == 9)
                Console.WriteLine("Doğduğunuz Ay EYLÜL");
            else if (uygulama5_Tarih.Month == 10)
                Console.WriteLine("Doğduğunuz Ay EKİM");
            else if (uygulama5_Tarih.Month == 11)
                Console.WriteLine("Doğduğunuz Ay KASIM");
            else if (uygulama5_Tarih.Month == 12)
                Console.WriteLine("Doğduğunuz Ay ARALIK");
            else
                Console.WriteLine("Yanlış formatta girdi yaptınız!");





            #endregion
            #region 2. ödev Uygulama5
            /*İkinci dereceden denklem köklerini bulan programı yazınız.*/
            int d, x1, x2 = 0;
            Console.WriteLine("a sayısı gir.");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b sayısı gir.");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c sayısı gir.");
            int c = Convert.ToInt32(Console.ReadLine());
            d = (b ^ 2) - (4 * a * c);//diskrimant
            if (d >= 0)
            {
                x1 = (-b + d ^ (1 / 2) / 2 * a);
                x2 = (-b - d ^ (1 / 2) / 2 * a);
                Console.WriteLine("Kök 1 {0} dır", x1);
                Console.WriteLine("Kök 2 {0} dır", x2);
            }
            else if (d == 0)
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine("Kök 1 {0} dır", x1);
                Console.WriteLine("Kök 2 {0} dır", -x2);

            }
            else
            {
                Console.WriteLine("Denklemin gerçek kökü yoktur");
            }





            #endregion


            #region 2.ödev Uygulama6
            /*Girilen bir derece değerini radyan ve gradyan değerine çeviren programı yazınız.*/

            int r, g;
            double pi = 3.14;

            Console.WriteLine("Açıyı giriniz = ");
            d = Convert.ToInt32(Console.ReadLine());

            r = Convert.ToInt32(d * pi / 180);
            g = d * 200 / 180;

            Console.WriteLine("Radyan = " + r);
            Console.WriteLine("Grad = " + g);
            Console.ReadKey();


            #endregion












        }
    }
    }

