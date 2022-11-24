
namespace AccessModifiers2
{

    public class Car
    {
        #region AccessModifiers
        //public int Id;
        //protected string message;
        //private string title;   
        //public   int Id { get; private set; }
        //public void SetId(int id)
        //{
        //    Id=id;
        //}
        //private int _id;
        //public int Id { get => _id; set {
        //        if (value>=0)
        //        {
        //            _id = value;
        //        }
        //    } }

        //public void SetId(int id)
        //{
        //    this._id = id;
        //}
        //public int GetId() => this._id;

        // internal class Bus : Car
        // {
        //     public string Name;
        //     public string Description;
        // }
        //class Bike : Bus
        // {

        // } 
        #endregion
        protected internal int id;
        private protected string Name;
       Test test = new Test();
        //Test1 test=new Test1();


    }

    class Bus : Car
    {
        public Bus()
        {
            Name = "BMW";
        }

    }
  
}
namespace AccessModifiers2.Models.DemoTest
{
    class Car
    {

    }
}