using System;
using System.Collections.Generic;
using System.Text;

namespace HttpClientExample
{
   

    public class Data
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }

        public override string ToString()
        {
            return $"{userId},{id},{title},{completed}";
        }

    }

}
