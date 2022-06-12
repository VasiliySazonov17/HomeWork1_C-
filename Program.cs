//five branches
//first branch - max_min
//second branch - max_numb
//third branch - even_or_odd
//fourth branch - row_even

Console.Write("Input number first: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number second: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number third: ");
int num_3 = Convert.ToInt32(Console.ReadLine());
int max_num = num_1;

if (max_num < num_2)
{
    max_num = num_2;

}
else if (max_num < num_3)
{
    max_num = num_3;
}

if (max_num < num_3)
{
    max_num = num_3;
}
Console.Write("Max_number -> " + max_num);












