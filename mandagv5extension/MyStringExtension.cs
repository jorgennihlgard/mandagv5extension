﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mandagv5extension
{
   public static class MyStringExtension
    {
        public static string Dotify(this string text)
        {
            string result = text.Trim();
            if (result[result.Length - 1] != '.')
                return result + '.';
            else
                return result;
        }
        public static string Plusplussa(this string tal)
        {
            return tal + tal;ggg
        }
    }
}
