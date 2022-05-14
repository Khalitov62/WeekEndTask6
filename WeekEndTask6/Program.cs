
using System;

namespace WeekEndTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon();


            Console.Write("Capacity:");
            weapon.BulletSize = Convert.ToInt32(Console.ReadLine());
            Console.Write("BulletCount");
            weapon.BulletCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Finish:");

            bool check = true;
            do
            {
                Console.WriteLine("0 - İnformasiya almaq üçün");
                Console.WriteLine("1 - Shoot metodu üçün");
                Console.WriteLine("2 - Fire metodu üçün");
                Console.WriteLine("3 - GetRemainBulletCount metodu üçün");
                Console.WriteLine("4 - Reload metodu üçün");
                Console.WriteLine("5 - ChangeFireMode metodu üçün");
                Console.WriteLine("6 - Proqramdan dayandırmaq üçün qısayoldur.");


                int selector = Convert.ToInt32(Console.ReadLine());




                switch (selector)
                {
                    case 0:
                        {

                        }
                        break;
                    case 1:
                        {
                            Console.WriteLine("Shoot metod:");
                            weapon.Shoot();
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Fire  metod:");
                            weapon.Fire();
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("GetRemainBulletCount metod:");
                            weapon.GetRemainBulletCount();
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Reolad metod:");
                            weapon.Reload();
                        }
                        break;

                    case 5:
                        {
                            Console.WriteLine("ChangeFireMode");
                            weapon.ChangeFireMode();
                        }
                        break;

                    case 6:
                        {
                            check = false;
                        }
                        break;
                }

            } while (check);
        }
    }
}

