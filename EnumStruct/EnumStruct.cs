using System;


// Create an enum or days of the week.
// Create a program that prints out the day of the week 
// your birthday will fall on for which ever year you type in.				
public class Program
{
    public static void Main()
    {		
        DayOfWeek myBirthdayDay = DayOfWeek.Thursday;
        
        Console.WriteLine(myBirthdayDay);
        Console.WriteLine((int)myBirthdayDay+1);
        
        //Console.WriteLine((DayOfWeek)1);
        
        //Console.WriteLine((DayOfWeekWithNumbers)1);
    }
    enum DaysOfWeek
    {
Monday, Tuesday, Wednsday, Thursday, Friday, Saturday, Sunday }
        enum DayOfWeekWithNumbers
    {
        Monday = 1, Tuesday = 2, Wednsday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7
    }
}
