// See https://aka.ms/new-console-template for more information
string stranger = "Darie"; //has to have semicolon at the end
//can use var in C#, but use types as well.
//methods such as WriteLine are capitalized

Console.WriteLine("Hello, World!");//same as JS this is a string
Console.WriteLine("Hello, "+ stranger);
Console.WriteLine($"Hello, + {stranger}");//this is how to use string interpolation, $ at the beginning

string stranger2 = "Another";
int one = 1;

Console.WriteLine($"Hello, + {stranger2} {one}");

Console.WriteLine(stranger2.IndexOf("n").ToString());

int a = 10, b = 20, c = 40;

double d = 5.0, e = 2.0;

double div = d / e; //double precision point, divide

int sum = a + b + c; 

Console.WriteLine($"The sum is {sum}"); //70
Console.WriteLine($"what is {sum/3}"); //23
Console.WriteLine($"what is 70/3 { div }");// 2.5
Console.WriteLine($"What is the max of int {int.MaxValue}"); //2147483647
Console.WriteLine("--------------------------------ARRAY-----------------");

var firstArr = new int [5] {-69, 46, 10, 1, 100};
//int[] arr2 =new int[10];
firstArr[1] = 20;

//var firstArr = new int[10];

for(var i = 0; i < firstArr.Length; i++){
    Console.WriteLine($"The value at {i} is {firstArr[i]}" );
}

foreach( var el in firstArr){
    Console.WriteLine($"The value is {el}");
}

Console.WriteLine("------------------------------LIST--------------------");
//arrays and lists can only have one data type

//List<int> list = new List<int>(); <-- proper way to write
var list = new List<int>();

list.AddRange(firstArr); //
list.Add(1000);
list.Add(10001);
list.Add(10002);

foreach( var el in list){
    Console.WriteLine($"The value is {el}");
}

Console.WriteLine($"The first element is {list[0]}");
