﻿using System;
using System.Collections.Generic;
using System.IO;

namespace csharp_text_analyser_monikarychter
{
    class Aplication
    {
        
        static void Main(string[] args)

        {
            foreach(var fpath in args){
            
            FileContent file = new FileContent("test.txt"); 
            var chars = new StatisticAnaliysis(file.CharIterator());
            var words = new StatisticAnaliysis(file.WordIterator());
            Console.WriteLine("---"+fpath+"----");
            Console.WriteLine("Char count: " + chars.Size());
            Console.WriteLine("word count: " + words.Size());

            Console.WriteLine("'love' count:" + words.CountOf("love"));
            Console.WriteLine();
            
        

          
            
              } 
         
        }

    }
}

