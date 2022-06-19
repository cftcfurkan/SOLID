// openClosed nesnelerde değişime kapalı ama genişlemeye açık olmalıdır.

//senaryo: personellerin parttime yada full time olma durumlarına göre maaş hesaplaması

SalaryCalculator calculator = new SalaryCalculator(new FullTimeEmployee());
calculator.CalculateSalary();


interface IEmployee
{
    void CalculateSalary();
}

class FullTimeEmployee : IEmployee
{
    public void CalculateSalary()
    {
        Console.WriteLine("Full");
    }
}
class SupportEmployee : IEmployee
{
    public void CalculateSalary()
    {
        Console.WriteLine("Support");
    }
}
class PartTimeEmployee : IEmployee
{
    public void CalculateSalary()
    {
        Console.WriteLine("Part");
    }
}
class SalaryCalculator
{
    //public  void CalculateSalary(string employeeType)
    //{
    //    if (employeeType == "Full")
    //    {
    //        new FullTimeEmployee().CalculateSalary();
    //    }
    //    else if (employeeType == "Support")
    //    {
    //        new SupportEmployee().CalculateSalary();

    //    }
    //    else
    //    {
    //        new PartTimeEmployee().CalculateSalary();
    //    }
    //}
    private readonly IEmployee employee;
    public SalaryCalculator(IEmployee employee)
    {
        this.employee = employee;
    }
    public void CalculateSalary()
    {
        this.employee.CalculateSalary();
    }
}



//diyelim ki senaryo değişti ve bir destek ekibi dahil ettik.(class SupportEmployee) 
// dahil edilen ekip metodta değişim yapmak zorunda bırakıyor (else if)
// bir interface tanımladık. ve classlarımızı interfaceten kalıttık.
// ctor'da bir employee tanımladık.
// ve bir salaryCalculator nesnesi tanımladık ve calculate ettik. programı ayağa kaldırdığımızda belirttiğimiz sınıfa ait veri, console ekranına geldi.