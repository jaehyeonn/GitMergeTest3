using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitMergeTest3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ruler ruler = new Ruler(10);
            ruler.Run();
        }
    }

    public class Ruler
    {
        private const float ONE_INCH = 2.54F;
        public int Centimeter { get; set; } = 0;

        public float Inch
        {
            get { return Centimeter * ONE_INCH; }

            // {2023 07 03 Add private _SetInch function / Gamma
            private set { this._SetInch(value); }
        }
        public Ruler(int cmValue) { Centimeter = cmValue; }

        public void Run()
        {
            Console.WriteLine($"{this.Centimeter}cm는 {this.Inch}inch 입니다.");
        }

        private void _SetInch(float inchvalue) { Centimeter = (int)(inchvalue / ONE_INCH); }
            // }2023 07 03 Add private _SetInch function / Gamma
    }
}

