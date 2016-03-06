using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReflectionConsoleApplication1
{
    class Program
    {
        const int loopCount = 10000;

        static void Main(string[] args)
        {
            Thread.Sleep(2000);

            NormalEquals();

            ReflectionEquals();

            Thread.Sleep(10000);
        }

        private static void NormalEquals()
        {
            for (int i = 0; i < 5; i++)
            {
                var e1 = new NormalEquals();
                var e2 = new NormalEquals();

                var stopWatch = new Stopwatch();
                stopWatch.Start();

                for (int j = 0; j < loopCount; j++)
                {
                    var isEquals = e1.Equals(e2);
                    if (!isEquals) return;
                }

                stopWatch.Stop();

                System.Console.WriteLine("Normal   calc time {0}s", stopWatch.Elapsed);

                System.Console.WriteLine("-----------------------------------------");
            }
        }

        private static void ReflectionEquals()
        {
            for (int i = 0; i < 5; i++)
            {
                var e1 = new ReflectionEquals();
                var e2 = new ReflectionEquals();

                var stopWatch = new Stopwatch();
                stopWatch.Start();

                for (int j = 0; j < loopCount; j++)
                {
                    var isEquals = e1.Equals(e2);
                    if (!isEquals) return;
                }

                stopWatch.Stop();

                System.Console.WriteLine("Reflec   calc time {0}s", stopWatch.Elapsed);

                System.Console.WriteLine("-----------------------------------------");
            }
        }

    }

    class NormalEquals
    {
        #region メンバ
        private int member0 = 0;
        private int member1 = 1;
        private int member2 = 2;
        private int member3 = 3;
        private int member4 = 4;
        private int member5 = 5;
        private int member6 = 6;
        private int member7 = 7;
        private int member8 = 8;
        private int member9 = 9;
        private String memberS0 = "0000000000";
        private String memberS1 = "1111111111";
        private String memberS2 = "2222222222";
        private String memberS3 = "3333333333";
        private String memberS4 = "4444444444";
        private String memberS5 = "5555555555";
        private String memberS6 = "6666666666";
        private String memberS7 = "7777777777";
        private String memberS8 = "8888888888";
        private String memberS9 = "9999999999";
        #endregion

        public override bool Equals(object obj)
        {
            var o = obj as NormalEquals;
            if(o == null) return false;
            if (member0 != o.member0) return false;
            if (member1 != o.member1) return false;
            if (member2 != o.member2) return false;
            if (member3 != o.member3) return false;
            if (member4 != o.member4) return false;
            if (member5 != o.member5) return false;
            if (member6 != o.member6) return false;
            if (member7 != o.member7) return false;
            if (member8 != o.member8) return false;
            if (member9 != o.member9) return false;
            if (!memberS0.Equals(o.memberS0)) return false;
            if (!memberS1.Equals(o.memberS1)) return false;
            if (!memberS2.Equals(o.memberS2)) return false;
            if (!memberS3.Equals(o.memberS3)) return false;
            if (!memberS4.Equals(o.memberS4)) return false;
            if (!memberS5.Equals(o.memberS5)) return false;
            if (!memberS6.Equals(o.memberS6)) return false;
            if (!memberS7.Equals(o.memberS7)) return false;
            if (!memberS8.Equals(o.memberS8)) return false;
            if (!memberS9.Equals(o.memberS9)) return false;
            return true;
        }

    }

    class ReflectionEquals
    {

        #region メンバ
        private int member0 = 0;
        private int member1 = 1;
        private int member2 = 2;
        private int member3 = 3;
        private int member4 = 4;
        private int member5 = 5;
        private int member6 = 6;
        private int member7 = 7;
        private int member8 = 8;
        private int member9 = 9;
        private String memberS0 = "0000000000";
        private String memberS1 = "1111111111";
        private String memberS2 = "2222222222";
        private String memberS3 = "3333333333";
        private String memberS4 = "4444444444";
        private String memberS5 = "5555555555";
        private String memberS6 = "6666666666";
        private String memberS7 = "7777777777";
        private String memberS8 = "8888888888";
        private String memberS9 = "9999999999";
        #endregion

        static FieldInfo[] fields = typeof(ReflectionEquals).GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

        public override bool Equals(object obj)
        {
            var o = obj as ReflectionEquals;
            if (o == null) return false;            

            for (int i = 0; i < fields.Length; i++)
            {
                var field = fields[i];

                if (!field.GetValue(this).Equals(field.GetValue(o))) return false;
            }
            return true;
        }

    }
}
