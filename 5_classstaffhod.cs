using System;

class Staff
{
    public string Name { get; set; }
    public string Post { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Staff[] staffs = new Staff[5];

        for (int i = 0; i < 5; i++)
        {
            staffs[i] = new Staff();
            Console.Write("Enter name of staff " + (i + 1) + ": ");
            staffs[i].Name = Console.ReadLine();
            Console.Write("Enter post of staff " + (i + 1) + ": ");
            staffs[i].Post = Console.ReadLine();
        }

        Console.WriteLine("\nHODs:");
        foreach (Staff staff in staffs)
        {
            if (staff.Post.Equals("HOD", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(staff.Name);
            }
        }
    }
}




















Enter name of staff 1: ankan
Enter post of staff 1: hod
Enter name of staff 2: raj
Enter post of staff 2: ss
Enter name of staff 3: arun
Enter post of staff 3: hod
Enter name of staff 4: wish
Enter post of staff 4: jk
Enter name of staff 5: emon
Enter post of staff 5: kh

HODs:
ankan
arun
