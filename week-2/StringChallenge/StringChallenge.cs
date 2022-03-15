string Info;
int Number; 

Console.WriteLine("Please enter your message and press enter");

Info = Console.ReadLine();

Console.WriteLine("Please enter a number LESS THAN the length of your string and press enter");

Number = int.Parse(Console.ReadLine());

char Alphabet;

Console.WriteLine("For which character should I search in your original message?");

Alphabet = char.Parse(Console.ReadLine());

Console.WriteLine("What's your First Name?");

string Name = Console.ReadLine();

Console.WriteLine("What's Your Last Name?");

string LastName = Console.ReadLine();

Console.WriteLine("Your Full Name is: " + Name + " " + LastName);

Console.WriteLine("The Initials: " + Name.Substring(0,1) +"/"+ LastName.Substring(0,1));

Console.WriteLine("First Name: " + Name +" LastName: "+ LastName.Substring(0,2));

Console.WriteLine("User's Last Name Length: " + LastName.Length);