
/*  Shortcuts:

1.  cw -> Console.WriteLine();

*/

// Numbers:

/*

int a = 1;
long b = 10000000L;     // pul 'L' To define that the value should be treated as a type of 'long'
long c = 1000000000000;

double d = 2.36735;
float f = 2.0003F;      // pul 'F' To define that the value should be treated as a type of 'float'
decimal g = 23.00000004M;   // pul 'M' To define that the value should be treated as a type of 'decimal'

    // declaring by combining varaibls with the same type.
int i = 10,
    j = 11,
    k = 12;

Console.WriteLine("formatted: " + string.Format("{0:0.00}",d)); // formating - taking 3 decimal places
Console.WriteLine(d.ToString("C")); // Currency
Console.WriteLine(d.ToString("C0"));
Console.WriteLine(d.ToString("C1"));
Console.WriteLine(d.ToString("C2"));




// Texts:

string name = "Ali"; // strings values must be between two qutations.
char letter = 'A';  // chars values must be between single qutations.

bool active = false;


// string.Contact((x,y,v);  

// string.Contain("");

//striung.Replace("","");

// string.trim();  trimStart(); trimEnd()


// string conct = $" welcome {name}";



// Casting:

string number = "-23";
int num = Convert.ToInt32(number);
Console.WriteLine(num);

// Operators:

int age = 12;
age++; //   - * /    
age += 1;
Console.WriteLine(age);


string msg = "Hello";
msg += " Ammar";
Console.WriteLine(msg);

int fnum = 10;
int snum = 3;

int reminder = fnum % snum; // modular - get the reminder
Console.WriteLine(reminder);


//  IF Statement  AND Conditional Operator:


    //   ==    <    <=    >    >=   !=   &&  ||

if (reminder == 0)
{
    Console.WriteLine("0");
}
else if (reminder == 1)
{
    Console.WriteLine("1");
}
else
{
    Console.WriteLine("-1");
}

    // Conditional Operator - altelnary statement
string res = (reminder == 0) ? "0" : "1";


// Switch:

string day = "Sat";

switch (day)
{
    case "Sat":
        Console.WriteLine("Yes");
        break;
    case "Mon":
        Console.WriteLine("No");
        break;
    default:
        Console.WriteLine("hmm!");
        break;
}


// For Loop:

for(int m = 0; m < 3; m++)
{
    Console.WriteLine(m);
}



// While loop:

int count = 1;

while (count<10)
{
    Console.WriteLine(count);
    count++;
}


*/



/*printing numbers as:

1 
2 2
3 3 3

 */
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Markup;

Console.Write("Enter number of items: ");

//int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 1; i++) 
{
    for(int j = 1; j <= i; j++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}


// --i  -> 

int z = 1;
int s = --z;
int k = z--;
Console.WriteLine(k);
Console.WriteLine(s);



// Data Structure:

//  Array




// exmple

int[][] arrays = new int[][]
        {
            new int[] { 30, 60, 40 },
            new int[] { 40, 40, 100 }
        };

// Iterate over the arrays using nested foreach loops
foreach (int[] innerArray in arrays)
{
    foreach (int value in innerArray)
    {
        Console.Write(value + " ");
    }
    Console.WriteLine(); // Print a new line after each inner array
} 

// nethods/ functions:



static double discount(double price, double discPrs)
{
    return price * discPrs;
}

double result = discount(10, 0.5);
Console.WriteLine("Discount: " + result);





// LIST:
Console.WriteLine("\nLISTS: \n");


List<int> myList = new List<int>();
for(int i = 1; i <= 5; i++)
{
    myList.Add(i);
}

foreach(var item in myList) {  
    Console.WriteLine(item); 
}


// STACK :  LIFO
Console.WriteLine("\nSTACK: \n");

Stack<int> stack = new Stack<int>();

stack.Push(1);
stack.Push(2);
stack.Push(3); 

Console.WriteLine("Stack after push operation");
//PrintStack(stack);

foreach (var item in stack)
{
    Console.WriteLine(item);
}

int poppedItem1 = stack.Pop();
int poppedItem2 = stack.Pop();

Console.WriteLine("\nPopped Item 1 : " + poppedItem1);
Console.WriteLine("\nPopped Item 2 : " + poppedItem2);

Console.WriteLine("\nStack after pop operation: ");
//PrintStack(stack);

foreach(var item in stack)
{
    Console.WriteLine(item);
}


// oop

Animal animal = new Cat();
animal.eatFood();



































