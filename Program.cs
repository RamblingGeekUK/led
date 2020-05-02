using System;
using System.Device.Gpio;
using System.Threading;
using ws281x;

namespace led {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");

            // Initialize a new instance of the wrapper
            var neopixel = new ws281x.Net.Neopixel(ledCount: 32, pin: 18);

            // You can also choose a custom color order
            neopixel = new ws281x.Net.Neopixel(ledCount: 32, pin: 18, stripType: rpi_ws281x.WS2811_STRIP_RBG);

            // Always initialize the wrapper first
            neopixel.Begin ();

            // Set color of all LEDs to red
            for (var i = 0; i < neopixel.GetNumberOfPixels (); i++) {
                neopixel.SetPixelColor (i, System.Drawing.Color.Red);
            }

            // Apply changes to the led
            neopixel.Show ();

            // Dispose after use
            neopixel.Dispose ();

        }
    }
}