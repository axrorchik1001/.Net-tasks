// See https://aka.ms/new-console-template for more information

// Add
// Get
// GetAll
// Delete

Console.Write("how many cars do you add: ");
int inputArraySize = int.Parse(Console.ReadLine());
string[] cars = new string[inputArraySize];
 


int index = 0;
bool again = true;

while (again)
{

    Console.WriteLine("1. Add car " +
        "\n2. Get car " +
        "\n3. Get all car " +
        "\n4. Remove car " +
        "\n5. Exit");
    Console.Write(">>> Enter number: ");
    int choice = int.Parse(Console.ReadLine());


    if(choice == 1)
    {
        Console.Write("Enter cars: ");
        string input = Console.ReadLine();
        index = Add(cars, index, input);
        Console.Clear();

    }

    else if(choice == 2)
    {
        Console.Clear();
        Console.Write("Enter cars: ");
        string car = Console.ReadLine();
        Get(cars, car);
       
    }

    else if(choice == 3)
    {
        Console.Clear();
        GetAll(cars);
        Console.WriteLine();

    }

    else if(choice == 4)
    {
        Console.Clear();
        Console.Write("Enter cars: ");
        string car = Console.ReadLine();
        Delete(cars, car);
    }
    else if(choice == 5)
    {
        break;
    }
    else
    {
        Console.WriteLine("siz xato kiritdingiz");
    }
}

static int Add(string[] cars, int index, string car)
{
    cars[index] = car;
    return index + 1;
}

static void Get(string[] cars, string car)
{
    foreach (string item in cars)
    {
        int count = 0;
        if(item == car)
        {
            Console.WriteLine(car);
        }
        else
        {
            count++;
        }
        
        if(count == cars.Length + 1)
        {
            Console.WriteLine("not found");
            break;
        }
       
        
    }
}

static void GetAll(string[] cars)
{
    foreach(string item in cars)
    {
        if(item != null)
        {
        Console.WriteLine($"<< {item} >>");
        }
    }
}

static void Delete(string[] cars, string car)
{
    for(int index = 0; index < cars.Length; index++)
    {
        if (cars[index] == car)
        {
            cars[index] = null;
        }
    }
}