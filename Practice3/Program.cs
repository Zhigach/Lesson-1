/*Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница */

Console.WriteLine("Enter number of a week day");
int weekDay = Convert.ToInt32(Console.ReadLine());

if (weekDay == 1){
    Console.WriteLine("Monday");
} else
if (weekDay == 2){
    Console.WriteLine("Tuesday");
} else
if (weekDay == 3){
    Console.WriteLine("Wednesday");
} else
if (weekDay == 4){
    Console.WriteLine("Thursday");
} else
if (weekDay == 5){
    Console.WriteLine("Friday");
} else 
if (weekDay == 6){
    Console.WriteLine("Saturday");
} else
if (weekDay == 7){
    Console.WriteLine("Sunday");
} else {
    Console.WriteLine("Not a weekDay");
}


