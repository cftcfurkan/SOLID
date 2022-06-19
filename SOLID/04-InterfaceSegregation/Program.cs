// alakalı interface'leri parçalamak gerekir.Yani bir interface'te alakasız birşey olmamalı.

//class a interface'in gerekli gereksiz bütün metodları implemente ediliyor bunun önüne geçmek için 
//interfaceten kalıtılan başka bir interface aracılığıyla metodları bölüyoruz.

public interface IRepository
{
    void Add();
}
public interface ICategoryRepository : IRepository
{
    void GetCategories();

}
public interface IProductRepository :IRepository
{
    void GetProducts();

}
public class CategoryRepository : ICategoryRepository
{
    public void Add()
    {
        Console.WriteLine("Added");
    }

    public void GetCategories()
    {
        Console.WriteLine("List Category");
    }

}
public class ProductRepository : IProductRepository
{
    public void Add()
    {
        Console.WriteLine("Added");
    }

    public void GetProducts()
    {
        Console.WriteLine("List Product");
    }
}