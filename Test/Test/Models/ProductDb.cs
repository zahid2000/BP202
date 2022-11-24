namespace Test.Models
{
    internal class ProductDb
    {

        public Product[] products = new Product[5];


        public void AddProduct(Product product)
        {
            if (products[products.Length - 1] == null)
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i] == null)
                    {
                        products[i] = product;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("yer yoxdur");
            }
        }

        public void SearchProduct(string name)
        {
            bool check = false;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == null)
                {
                    break;
                }
                if (name == products[i].name)
                {
                    check = true;
                    Console.WriteLine(products[i]);
                    break;
                }
            }
            if (check == false)
            {
                Console.WriteLine("netice tapilmadi");
            }
        }
    }


}
