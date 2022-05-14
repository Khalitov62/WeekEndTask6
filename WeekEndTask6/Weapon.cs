using System;
using System.Collections.Generic;
using System.Text;

namespace WeekEndTask6
{
    class Weapon
    {
        private int _count=0;

        public int BulletSize { get; set; }
        public int BulletCount
        {
            get
            {
                return _count;
            }
            set
            {
                if (value>0 && value<=30)
                {
                    _count = value;
                }
            }

        }
        public bool isSingle { get; set; }

        //public Weapon(int bulletSize, int bulletCount)
        //{
        //    BulletSize = bulletSize;
        //    BulletCount = bulletCount;
        //}

        public void Shoot()
        {
            Console.WriteLine(BulletCount-=1);
        }
        public void Fire()
        {
            if (isSingle==false)
            {
                Console.WriteLine(BulletCount = 0);
            }
        }

        public void GetRemainBulletCount()
        {
            if (BulletCount<BulletSize)
            {
                Console.WriteLine(BulletSize-BulletCount);
            }
        }

        public void Reload()
        {
            if (BulletCount < 30)
            {
                Console.WriteLine(BulletCount=30);
            }
        }

        public void ChangeFireMode()
        {
            if (isSingle=true)
            {
                Console.WriteLine("Automatic");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"BulleSize : {BulletSize}, BulletCount : {BulletCount}, isSingle : {isSingle}");
        }
    }
}
