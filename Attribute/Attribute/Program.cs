using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomAttr;
namespace Attribute
{
    [AddtionalInfoAttribute("aa","bbb",Download ="http://ojc.asia")]
    class Program
    {
        [Conditional("SOUNDCARD")]
        static void print()
        {
            Console.WriteLine("도레미...");
        }
        [Conditional("SOUNDCARD")]
        static void isSound()
        {
            isSpeaker();
        }
        [Conditional("SPEAKER")]
        static void isSpeaker()
        {
            Console.WriteLine("음악을 들을 수 있습니다.");
        }


        static void Main(string[] args)
        {
            isSound(); 
        }
    }
}
