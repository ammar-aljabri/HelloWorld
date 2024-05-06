
/*  Shortcuts:

1.  cw -> Console.WriteLine();

*/

// Numbers:

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

    // Conditional Operator
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























