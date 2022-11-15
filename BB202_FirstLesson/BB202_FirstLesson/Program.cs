

int num =15;


do
{
    Console.WriteLine("Hello");
} while (num > 15);



//string result = num switch
//{
//    > 10 => "bigger than 10",
//    < 10 => "less than 10",
//    _=>"equals 10"
//};

//Console.WriteLine(result);

string[] arr = { "Eli", "Seyhun", "Samir", "Nezrin", "Sima", null };

foreach (var item in arr)
{
    var result = item ?? "Hello";

    Console.WriteLine(result);
}
