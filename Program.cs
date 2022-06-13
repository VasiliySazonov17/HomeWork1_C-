//five branches
//first branch - max_min
//second branch - max_numb
//third branch - even_or_odd
//fourth branch - row_even

Console.Write("Input number: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= num_1)
{
    if(count % 2 == 0)
    {
        Console.Write(count);
        
        if (1 < num_1 - count)
        {
            Console.Write(", ");
        }
    }
    count ++;
}

