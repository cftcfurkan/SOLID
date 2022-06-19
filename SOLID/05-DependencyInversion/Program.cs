// entity framework kullanmak istedik fakat daha sonra fikir değiştirip dapper a geçiş yaptık diyelim fakat ozaman new anahtar sözcüğü ile işlem yaptığımız için entity frameworke tamamen bağlı kaldık dolayısıyla dapper a geçiş yapmak istediğimizde bütün kodu tekrarda yazmamız gerekti. 



HomeIndex();
CategoryIndex();
CategoryIndex2();
CategoryIndex3();

static void HomeIndex()
{
    //CategoryRepositoryEf ef = new CategoryRepositoryEf();
    //ef.GetCategories();

    Container container = new Container();
    container.GetInstance().GetCategories();
}
static void CategoryIndex()
{
    //CategoryRepositoryEf ef = new CategoryRepositoryEf();
    //ef.GetCategories();
    Container container = new Container();
    container.GetInstance().GetCategories();
}
static void CategoryIndex2()
{
    //CategoryRepositoryEf ef = new CategoryRepositoryEf();
    //ef.GetCategories();
    Container container = new Container();
    container.GetInstance().GetCategories();
}
static void CategoryIndex3()
{
    //CategoryRepositoryEf ef = new CategoryRepositoryEf();
    //ef.GetCategories();
    Container container = new Container();
    container.GetInstance().GetCategories();
}

class Container
{
    // container aracılığı ile örnekleme işlemini bu containerın içinde gerçekleştirdik.
    
    public ICategoryRepository GetInstance()
    {
        return new CategoryRepositoryEf();
    }
}
interface ICategoryRepository
{
    void GetCategories();
}
class CategoryRepositoryEf : ICategoryRepository
{
    public void GetCategories()
    {
        Console.WriteLine("Ef");
    }
}

class CategoryRepositoryDp : ICategoryRepository
{
    public void GetCategories()
    {
        Console.WriteLine("Dp");
    }
}