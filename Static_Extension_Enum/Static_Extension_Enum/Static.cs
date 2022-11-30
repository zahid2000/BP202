namespace Static_Extension_Enum
{
 
    internal   class Calc
    {
        public int Id1 { get; set; }
        static Calc()
        {
            Console.WriteLine("Static constructor isledi");
        }
        public static void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static int count;
        public static int Id { get; set; }
        static void Add()
        {
            Console.WriteLine(Message.Saved);
        }
    }

   static class Message
    {
        public static string Saved = "Əlavə edildi";
        public static string Deleted = "Saved";
    }
}
