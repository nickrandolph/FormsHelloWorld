﻿using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace HelloUno.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new HelloUno.App(), args);
            host.Run();
        }
    }
}
