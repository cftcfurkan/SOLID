// liskov subs. =>  X eğer Y'nin bir alt türü ise X'in Y'nin yerine geçebilmesi gerekir.

// employee parttime ise maaşı günlük ful time ise  saatlik hesaplansın.

Employee employee = new PartTimeEmployee();

class Employee
{

    public int ID { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }

}
class PartTimeEmployee : Employee
{
    public decimal DailyWage { get; set; }

}
class FullTimeEmployee : Employee
{
    public decimal HourlyWage { get; set; }
}