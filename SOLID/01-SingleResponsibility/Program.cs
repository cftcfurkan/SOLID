class Customer
{
    public string Name { get; set; }
    //public bool ValidateName(string name)
    //{
    //    return !string.IsNullOrWhiteSpace(name);
    //}
    //public void SayHello(string name)
    //{
    //    Console.WriteLine("Hello {0}",name);

    //
    //}


    // bu yapı singleResponsibility ye aykırıdır.
    // herbir metodumun veya classımın tekbir görevi olmalı 
    // dolayısıyla üstteki gibi bir kullanım yerine alttaki kullanım singleResponsibility kullanımına uygundur.


    
}

class CustomerValidator
{
    public bool ValidateName(string name)
    {
        return !string.IsNullOrWhiteSpace(name);
    }

}
class CustomerManager
{
    public void SayHello(string name)
    {
        Console.WriteLine("Hello {0}", name);

    }
}