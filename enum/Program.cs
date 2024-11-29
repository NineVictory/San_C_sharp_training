using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    public enum Size
    {
        Small,
        Medium,
        Large
    }

    internal class Program

    {


        static void Main(string[] args)
        {
            // typeof(Size)를 사용하여 열거형의 Type 정보를 가져온다
            Type sizeType = typeof(Size);
            Console.WriteLine($"The underlying type of Size enum is: {sizeType}"); //The underlying type of Size enum is: enum.Program+Size

            // Size 열거형의 값을 출력
            foreach (var name in Enum.GetNames(typeof(Size)))
            {
                Console.WriteLine(name);
                //Small
                //Medium
                //Large
            }


            // Size 열거형의 모든 값을 가져옵니다.
            Array sizes = Enum.GetValues(typeof(Size));

            Console.WriteLine("Available sizes:");

            // 각 값을 출력합니다.
            foreach (var size in sizes)
            {
                Console.WriteLine(size);
                
            }
        }
    }
}
