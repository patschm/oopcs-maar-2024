﻿using DoomsdayPreppers;
using Heras;
using Logitech;
using Philips;
using Siemens;

namespace Oprijlaan;

class Program
{
    static void Main(string[] args)
    {
        var lamp = new Lamp();
        var came = new Camera();
        var hek  = new Hek();
        var kuil = new Valkuil();

        var lus = new DetectieLus();

        

        lus.Detecting();
        

    }
}
