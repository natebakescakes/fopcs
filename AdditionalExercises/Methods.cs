using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    class Methods
    {
        public enum TriangleType
        {
            LeftAligned,
            Center,
            RightAligned,
            InvertedLeftAligned,
            InvertedCenter,
            InvertedRightAligned
        }

        public static void PrintTriangle(TriangleType triangleType, int height)
        {
            switch (triangleType)
            {
                case TriangleType.LeftAligned:
                    LeftAligned(height);
                    break;
                case TriangleType.Center:
                    Center(height);
                    break;
                case TriangleType.RightAligned:
                    RightAligned(height);
                    break;
                case TriangleType.InvertedLeftAligned:
                    InvertedLeftAligned(height);
                    break;
                case TriangleType.InvertedCenter:
                    InvertedCenter(height);
                    break;
                case TriangleType.InvertedRightAligned:
                    InvertedRightAligned(height);
                    break;
            }

        }

        private static void LeftAligned(int height)
        {
            string s = "";

            for (int i = 0; i < height; i++)
            {
                s += "*";
                Console.WriteLine(s);
            }
        }

        private static void RightAligned(int height)
        {
            string s = "";

            for (int i = 0; i < height; i++)
            {
                s += "*";
                string format = "{0," + height + "}";
                Console.WriteLine(format, s);
            }
        }

        private static void Center(int height)
        {
            string stars = "";

            for (int i = 0, j = height; i < height; i++, j -= (i % 2 == 0 ? 1 : 0))
            {
                stars += "*";
                String spaces = new String(' ', j);
                Console.WriteLine($"{spaces}{stars}");
            }
        }

        private static void InvertedLeftAligned(int height)
        {
            string s = new String('*', height);

            for (int i = 0; i < height; i++)
            {
                s = s.Substring(0, height - i);
                Console.WriteLine(s);
            }
        }

        private static void InvertedCenter(int height)
        {
            for (int i = height, j = height; i >= 0; i--, j += (i % 2 == 0 ? 1 : 0))
            {
                String stars = new string('*', i);
                String spaces = new string(' ', j);
                Console.WriteLine($"{spaces}{stars}");
            }
        }

        private static void InvertedRightAligned(int height)
        {
            string s = new String('*', height);

            for (int i = 0; i < height; i++)
            {
                s = s.Substring(0, height - i);
                string format = "{0," + height + "}"; // {0, 10}
                Console.WriteLine(format, s);
            }
        }
    }
}
