// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");



// testing

Console.WriteLine($"Hello {System.Environment.GetEnvironmentVariable("USER")}");

if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
 {
  Console.WriteLine("We're on Linux!");
 }

if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
 {
  Console.WriteLine("We're on Windows!");
 }

Console.WriteLine("Version {0}", Environment.OSVersion.Version);
Console.WriteLine("Platform {0}", Environment.OSVersion.Platform);










// try to change desktop wallpaper on linux

// find path

// get settins from dconf



// set background image
// try using gsettings


// set background using the dconf file
// 1 create the new file (/etc/dconf/db/ibus.d/01-wallpaperize-settings)

// add text



// run dconf update

//