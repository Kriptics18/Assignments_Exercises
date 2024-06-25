/*Write a simple program that defines a variable representing a birth date and calculates
how many days old the person with that birth date is currently.
For extra credit, output the date of their next 10,000 day (about 27 years) anniversary.
Note: once you figure out their age in days, you can calculate the days until the next
anniversary using int daysToNextAnniversary = 10000 - (days % 10000);*/

using System;

DateTime birthDate, now, nextAnniversary;
TimeSpan age;
int lastAnniversary, daysToNextAnniversary;

birthDate = new DateTime(1990, 1, 1);
now = DateTime.Now;
age = now - birthDate;
int days = age.Days;
Console.WriteLine($"You are {days} days old.");

lastAnniversary = days % 10000;
daysToNextAnniversary = 10000 - lastAnniversary;
nextAnniversary = now + new TimeSpan(daysToNextAnniversary, 0, 0, 0);
Console.WriteLine("Your next 10,000 day anniversary is " + nextAnniversary.ToString());
