//five branches
//first branch - max_min
//second branch - max_numb
//third branch - even_or_odd
//fourth branch - row_even

Console.Write("Input number first: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number second: ");
int num_2 = Convert.ToInt32(Console.ReadLine());



if (num_1 < num_2)
{
    Console.WriteLine("Max_num = " + num_2);
    Console.WriteLine("Min_num = " + num_1);
     }

else if (num_2 < num_1)

{
    Console.WriteLine("Max_num = " + num_1);
    Console.WriteLine("Min_num = " + num_2);
    }
else if (num_2 == num_1)
{
    Console.WriteLine("Input different numbers");
    }