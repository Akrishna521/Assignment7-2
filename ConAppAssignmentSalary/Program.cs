using System;

public class EmployeeSalaryCalculator
{
    public enum EmployeeType
    {
        HR,
        Admin,
        SoftwareDeveloper
    }

    public static double CalculateMonthlySalary(EmployeeType employeeType, int workingHours, int numberOfWorkingDays, int projectHandles = 0, int extras = 0)
    {
        double salary = workingHours * numberOfWorkingDays * 100;

        switch (employeeType)
        {
            case EmployeeType.HR:
                salary += projectHandles * 3000;
                break;
            case EmployeeType.SoftwareDeveloper:
                salary += extras;
                break;
            default:
                break;
        }

        return salary;
    }

    public static void Main()
    {
        Console.WriteLine("Choose Employee Type:");
        Console.WriteLine("1. HR");
        Console.WriteLine("2. Admin");
        Console.WriteLine("3. Software Developer");

        int employeeTypeChoice = Convert.ToInt32(Console.ReadLine());

        EmployeeType employeeType = (EmployeeType)employeeTypeChoice;

        Console.WriteLine("Enter working hours:");
        int workingHours = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number of working days:");
        int numberOfWorkingDays = Convert.ToInt32(Console.ReadLine());

        double monthlySalary = CalculateMonthlySalary(employeeType, workingHours, numberOfWorkingDays);

        Console.WriteLine($"Monthly salary: {monthlySalary}");
    }
}