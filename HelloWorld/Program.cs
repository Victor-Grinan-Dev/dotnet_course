// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//C# is a staticaly typed language

Console.WriteLine(args[0]);

//// 1 byte is made up of 8 bits 00000000 - these bits can be used to store a number as follows
// //// Each bit can be worth 0 or 1 of the value it is placed in
// ////// From the right we start with a value of 1 and double for each digit to the left
// //// 00000000 = 0
// //// 00000001 = 1
// //// 00000010 = 2
// //// 00000011 = 3
// //// 00000100 = 4
// //// 00000101 = 5
// //// 00000110 = 6
// //// 00000111 = 7
// //// 00001000 = 8

// 1 byte (8 bit) unsigned, where signed means it can be negative
byte myByte = 255;
Console.Write(myByte);
byte mySecondByte = 0;
Console.Write(mySecondByte);

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


