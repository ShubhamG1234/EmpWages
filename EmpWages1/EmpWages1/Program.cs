Console.WriteLine("Welcome to Employee Wage");
int IS_ABSENT = 0;
int IS_FULL_TIME = 1;
int IS_PART_TIME = 2;
int EMP_RATE_PER_HOUR = 20;
int NUM_OF_WORKING_DAY = 20;

int empHrs = 0;
int empWage = 0;
int totalEmpWage = 0;
for (int day =0; day < NUM_OF_WORKING_DAY; day++)
{ 
Random random = new Random();
int empCheck = random.Next(3);
switch (empCheck)
{
    case 1:
        Console.WriteLine("Employee is Present full Time");
        empHrs = 8;
        break;
    case 2:
        Console.WriteLine("Employee is Present part Time");
        empHrs = 4;
        break;
    default:
        Console.WriteLine("Employee is Absent");
        empHrs = 0;
        break;
}
empWage = empHrs * EMP_RATE_PER_HOUR;
    totalEmpWage += empWage;
Console.WriteLine("Emp Wage : " + empWage);
}
Console.WriteLine("Total Emp Wage : " + totalEmpWage);
