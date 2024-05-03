using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityPlug_inPractice
{
    public class HookObject
    {
        // Static methods work on class namespace
        public static String ReturnString()
        {
            return "Returned String";
        }
        public static int ReturnInt()
        {
            return 5;
        }
        public static int AddInts(int a, int b)
        {
            return a + b;
        }
        public static float AddFloats(float a, float b) 
        {
            return a+ b;
        }

        //instance method
        public String ReturnInstanceString()
        {
            return "Instance String Returned";
        }

    }
}
