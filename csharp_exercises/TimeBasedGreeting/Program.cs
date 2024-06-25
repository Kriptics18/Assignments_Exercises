/*Write a program that greets the user using the appropriate greeting for the time of day.
Use only if , not else or switch , statements to do so. Be sure to include the following
greetings:
"Good Morning"
"Good Afternoon"
"Good Evening"
"Good Night"
It's up to you which times should serve as the starting and ending ranges for each of the
greetings. If you need a refresher on how to get the current time, see DateTime
Formatting. When testing your program, you'll probably want to use a DateTime variable
you define, rather than the current time. Once you're confident the program works
correctly, you can substitute DateTime.Now for your variable (or keep your variable and just
assign DateTime.Now as its value, which is often a better approach)
*/

using System;


DateTime currentTime = DateTime.Now;
int currentHour = currentTime.Hour;

if (currentHour >= 6 && currentHour < 12) {
    Console.WriteLine("Good Morning");
}
if (currentHour >= 12 && currentHour < 16) {
    Console.WriteLine("Good Afternoon");
}
if (currentHour >= 16 && currentHour < 21) {
    Console.WriteLine("Good Evening");
}
if (currentHour >= 21 || currentHour < 5) {
    Console.WriteLine("Good Night");
}
