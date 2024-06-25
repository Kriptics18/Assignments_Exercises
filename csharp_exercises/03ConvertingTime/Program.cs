//Write program to enter an integer number of centuries and convert it to years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data type for every data conversion. Beware of overflows!

using System;

try {
    int centuries = int.Parse(Console.ReadLine());
    int years = centuries * 100;
    int days = (int)(years * 365.2422);
    int hours = days * 24;
    long minutes = hours * 60;
    long seconds = minutes * 60;
    long milliseconds = seconds * 1000;
    long microseconds = milliseconds * 1000;
    long nanoseconds = microseconds * 1000;

    Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");

} catch (Exception) {
    Console.WriteLine("Invalid input.");
}