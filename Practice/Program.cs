using System;

// initialize variables - graded assignments 
int currentAssignments = 5;


int[] sophia = [90, 86, 87, 98, 100];
int[] andrew = [92, 89, 81, 96, 90];
int[] emma = [90, 85, 87, 98, 68];
int[] logan = [90, 95, 87, 88, 96];

string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan"];

foreach (string name in studentNames)
{
    if (name == "Sophia")
    {
        int sophiaSum = 0;
        decimal sophiaScore;

        foreach (int i in sophia)
        {
            sophiaSum += i;
        }

        sophiaScore = (decimal)sophiaSum / currentAssignments;

        Console.WriteLine("Student\t\tGrade\t\tExtra Credit\n");
        Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-" + "\tA-");
    }
    else if (name == "Andrew")
    {
        int andrewSum = 0;
        decimal andrewScore;

        foreach (int i in andrew)
        {
            andrewSum += i;
        }

        andrewScore = (decimal)andrewSum / currentAssignments;

        Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
    }
    else if (name == "Emma")
    {
        int emmaSum = 0;
        decimal emmaScore;

        foreach (int i in emma)
        {
            emmaSum += i;
        }

        emmaScore = (decimal)emmaSum / currentAssignments;

        Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
    }
    else if (name == "Logan")
    {
        int loganSum = 0;
        decimal loganScore;

        foreach (int i in logan)
        {
            loganSum += i;
        }

        loganScore = (decimal)loganSum / currentAssignments;

        Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");
    }
}





