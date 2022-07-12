using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureClassDesignUML
{
    class ClassA {
        public int? x { get; set; }
        public int? y { get; set; } 
        public string? z { get; set; }
        public void MethodA(ClassA W) {
            Console.Write($"Hello,{W.z}!");
        }
    }
}
