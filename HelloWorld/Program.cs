// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//C# is a staticaly typed language

using System.IO.Pipes;
using System.Net;
using System.Text;

using HelloWorld.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using Dapper;



if(args.Length == 0){
    Console.WriteLine("Run the program with specified args");
    Console.WriteLine("test: respeat");
    Console.WriteLine("Run the program with specified args");
    Console.WriteLine("Run the program with specified args");
    Console.WriteLine("Run the program with specified args");
}
else if(args[0] == "bit-byte")
{
    Console.WriteLine(" 1 byte is made up of 8 bits 00000000 - these bits can be used to store a number as follows");
    Console.WriteLine(" Each bit can be worth 0 or 1 of the value it is placed in");
    Console.WriteLine(" From the right we start with a value of 1 and double for each digit to the left");
    Console.WriteLine(" 00000000 = 0");
    Console.WriteLine(" 00000001 = 1");
    Console.WriteLine(" 00000010 = 2");
    Console.WriteLine(" 00000011 = 3");
    Console.WriteLine(" 00000100 = 4");
    Console.WriteLine(" 00000101 = 5");
    Console.WriteLine(" 00000110 = 6");
    Console.WriteLine(" 00000111 = 7");
    Console.WriteLine(" 00001000 = 8");
    Console.WriteLine("");
    
}
else if(args[0] == "data-types")
{
        // 1 byte (8 bit) unsigned, where signed means it can be negative
    Console.WriteLine(" 1 byte (8 bit) unsigned, where signed means it can be negative");
    byte myByte = 255;
    Console.Write(myByte);
    byte mySecondByte = 0;
    Console.Write(mySecondByte);

    Console.WriteLine(" 1 byte (8 bit) signed, where signed means it can be negative");
    // 1 byte (8 bit) signed, where signed means it can be negative
    sbyte mySbyte = 127;
    Console.Write(mySbyte);
    sbyte mySecondSbyte = -128;
    Console.Write(mySecondSbyte);


// 2 byte (16 bit) unsigned, where signed means it can be negative
ushort myUshort = 65535;
Console.Write(myUshort);

// 2 byte (16 bit) signed, where signed means it can be negative
short myShort = -32768;
Console.Write(myShort);

// 4 byte (32 bit) signed, where signed means it can be negative
int myInt = 2147483647;
Console.Write(myInt);
int mySecondInt = -2147483648;
Console.Write(mySecondInt);

// 8 byte (64 bit) signed, where signed means it can be negative
long myLong = -9223372036854775808;
Console.Write(myLong);


// 4 byte (32 bit) floating point number
float myFloat = 0.751f;
float mySecondFloat = 0.75f;

// 8 byte (64 bit) floating point number
double myDouble = 0.751;
double mySecondDouble = 0.75d;

// 16 byte (128 bit) floating point number
decimal myDecimal = 0.751m;
decimal mySecondDecimal = 0.75m;

Console.WriteLine(myFloat - mySecondFloat);
Console.WriteLine(myDouble - mySecondDouble);
Console.WriteLine(myDecimal - mySecondDecimal);


char myCharacter = 'V';
Console.WriteLine(myCharacter);
string myString = "Hello World";
Console.WriteLine(myString);
string myStringWithSymbols = "!@#$@^$%%^&(&%^*__)+%^@##$!@%123589071340698ughedfaoig137";
Console.WriteLine(myStringWithSymbols);

bool myBool = true;
Console.WriteLine(myBool);

}
else if(args[0] == "collections")
{
    /**** ARRAYS ****/ // array are static and they cant be expanded
string[] myGrocery = new string[2]; //declared only ttwo items but assigned a 3rd item in index 2.

myGrocery[0] = "guacamole";
myGrocery[1] = "Ice Cream";
// myGrocery[2] = "bananas"; //only two items declared

string[] secondGrocery = {"Apples", "eggs"};

Console.WriteLine(secondGrocery[0]);
Console.WriteLine(secondGrocery[1]);

/**** LIST ****/ //list allow to dynamically add items to it
// List<string> groceryList = new List<string>(); //ORIGINAL SYNTAX
List<string> groceryList = new() {"Milk", "Cheese"}; //MODERN SYNTAX
Console.WriteLine(groceryList[0]);
Console.WriteLine(groceryList[1]);

groceryList.Add("Yogurt");
Console.WriteLine(groceryList[2]);

/***** IEnumerable ******/ //not a indexable collection
IEnumerable<string> groceryIEnumerable = groceryList;
Console.WriteLine(groceryIEnumerable.First()); 

/***** ARRAY OF ARRAY (multidimentional array) ****/
string[,] bidimentionalArry = new string[,] { 
    {"guacamole", "Ice Cream"},
    {"Milk", "Cheese"}
};

Console.WriteLine(bidimentionalArry[0,0]);
Console.WriteLine(bidimentionalArry[0,1]);
Console.WriteLine(bidimentionalArry[1,0]);
Console.WriteLine(bidimentionalArry[1,1]);

/***** DICCIONARY ****/
Dictionary<string, string> groceryDictionary = new Dictionary<string, string>{
    {"drink", "Milk"},
    // {'food', 'Toast'} how to add more elements to a dictionary
};
Console.WriteLine(groceryDictionary["drink"]);

Dictionary<string, double> itemPrices = new Dictionary<string, double>{
    {"cheese",  5.99 },
    {"carrots",  2.99 },
};

Console.WriteLine(itemPrices["cheese"]);

}
else if(args[0] == "operations")
{
/*Operations*/

// ++
// +=
// -=
// --

// +
// -
// *
// /

Console.WriteLine(Math.Pow(5,4));
Console.WriteLine(Math.Sqrt(25));

/***USING OPERATOR TO CHANGE STRINGS***/

string myString2 = "Hello";

myString2 += " World!";
Console.WriteLine(myString2);

/** scape operator /  ***/


/** Buildin functions **/
string[] myString2Array = myString2.Split(" ");

Console.WriteLine(myString2Array[0]);
Console.WriteLine(myString2Array[1]);

int number = 5;
int secondNum = 10;

Console.WriteLine(number);
Console.WriteLine(secondNum);

Console.WriteLine(number.Equals(secondNum));
Console.WriteLine(number.Equals(secondNum/2));

Console.WriteLine(number == secondNum);
Console.WriteLine(number != secondNum/2);

Console.WriteLine(number >= secondNum);
Console.WriteLine(number <= secondNum);

// && and || or
}
else if(args[0] == "iterations")
{

/*** LOOPS ***/

int[] thatArray = {0,1,2,3,4,5,6,7,8,9};

for(int i = 0; i < 10; i++){
 Console.Write(i);
}
Console.WriteLine("");

foreach(int itemOfAnArray in thatArray){
 Console.Write(itemOfAnArray);
}
Console.WriteLine("");

int num = 0;
while(num < 10)
{
   Console.Write(num);
   num++;
}
Console.WriteLine("");

do{
   Console.Write(num);
   num++;
}while(num < 10);
Console.WriteLine("");

int totalValue = thatArray.Sum();
Console.WriteLine(totalValue);

/*** methods ***/

static int GetSUm(int[] anArray)
{
    foreach (var item in anArray)
    {
        Console.Write(item);
    }
    Console.WriteLine("");

    return anArray.Sum();
}

int result = GetSUm(thatArray);
Console.WriteLine(result);

}
else if(args[0] == "models")
{
    /***** MODELS *****/
Console.WriteLine("*** COMPUTER MODEL: ***");
/*NOTE: some how the declaration of the class goes after the instant creation... i dont understand*/
Computer MyComputer = new()
{
    CPUCores = 8,
    HasWIfi = true,
    HasLTE = false,
    ReleaseDate = DateTime.Now,
    Price = 943.87m,
    VideoCard = "RTX-2060"
};

/*** SCOPE: Namespaces ****/
/* you cant write methods or declarations in side a namespace but you cant declare classes and structure etc */
/* the Following model "computer" was declared in its own name space */

    Console.Write("MyComputer.CPUCores: ");
    Console.WriteLine(MyComputer.CPUCores);
    Console.Write("MyComputer.ReleaseDate: ");
    Console.WriteLine(MyComputer.ReleaseDate);
    Console.Write("MyComputer.Price: ");
    Console.WriteLine(MyComputer.Price);
    Console.Write("MyComputer.VideoCard: ");
    Console.WriteLine(MyComputer.VideoCard);
    Console.Write("MyComputer.HasWIfi: ");
    Console.WriteLine(MyComputer.HasWIfi);

}
else if(args[0] == "db-connect")

{
    Console.WriteLine();
    string connectionString = "Server=localhost;Database=DotNetDB;TrustServerCertificate=true;Trusted_Connection=true;";

    IDbConnection dbConnection = new SqlConnection(connectionString); 

    /** TEST CONNECTION **/
    if(args.Length > 1 &&  args [1] == "test"){
        string sqlCommand = "SELECT GETDATE()";

        DateTime rightNow = dbConnection.QuerySingle<DateTime>(sqlCommand);

        Console.WriteLine();
        Console.WriteLine("If the date in the following line is correct then a succeful connection has been made.");
        Console.WriteLine(rightNow);
        Console.WriteLine();
    }else{
        Computer myComputer = new()
        {
            Motherboard = "Z600",
            CPUCores = 8,
            HasWIfi = true,
            HasLTE = false,
            ReleaseDate = DateTime.Now,
            Price = 943.87m,
            VideoCard = "RTX-2060"
        };

        // Console.WriteLine("CPUCores: " + myComputer.CPUCores);
        // Console.WriteLine("HasWIfi: " + myComputer.HasWIfi);
        // Console.WriteLine("HasLTE: " + myComputer.HasLTE);
        // Console.WriteLine("ReleaseDate: " + myComputer.ReleaseDate.ToString("yyyy-MM-dd"));
        // Console.WriteLine("Price: " + myComputer.Price.ToString().Replace(",", ".") );
        // Console.WriteLine("VideoCard: " + myComputer.VideoCard);

        string sql = @"INSERT INTO TutorialApp.Computer (
            Motherboard,
            CPUCores,
            HasWIfi,
            HasLTE,
            ReleaseDate,
            Price,
            VideoCard,
        ) VALUES ('" + myComputer.Motherboard 
                + "','" + myComputer.CPUCores
                + "','" + myComputer.HasWIfi
                + "','" + myComputer.HasLTE
                + "','" + myComputer.ReleaseDate.ToString("yyyy-MM-dd") //format date
                + "','" + myComputer.Price.ToString().Replace(",", ".") //replace coma for a dot
                + "','" + myComputer.VideoCard
        + "')";

         Console.WriteLine(sql);
         Console.WriteLine();
    }

   


}
else
{
    Console.WriteLine();
    Console.WriteLine("The specified arg '" + args[0] + "' was not found.");
    Console.WriteLine("Here is a list of args to try: ");
    Console.WriteLine(" - bit-byte");
    Console.WriteLine(" - data-types");
    Console.WriteLine(" - collections");
    Console.WriteLine(" - operations");
    Console.WriteLine(" - iterations");
    Console.WriteLine(" - models");
    Console.WriteLine(" - db-connect");
    Console.WriteLine(" - db-connect test");
    Console.WriteLine();
}




        

       

