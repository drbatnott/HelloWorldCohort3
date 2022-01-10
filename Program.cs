// See https://aka.ms/new-console-template for more information
/*A text writer is a type of stream used to save text data
 * It saves data in a similar way to the console
 * This means we can Write to it and WriteLine to it
 * */
TextWriter textWriter = new StreamWriter("OurData.csv",true);
string yesNo;
do
{
    Console.Write("Hello. What is your name? ");
    /*
     * A /* comment
     * is a multi line comment
     * */
    string name;
    // == is the comparison comparison operator it will return true if the things are equal
    // != is the not equals comparison operator it will return true if the things are not equal
    if ((name = Console.ReadLine()) == null)
    {
        Console.WriteLine("You should enter your name :-(");
    }
    else
    {
        Console.Write("Hello " + name + " what is your age? ");
    }

    //I am going to assume the age will be an integer
    int age;
    string ageString;
    ageString = Console.ReadLine();
    if (ageString == null)
    {
        Console.WriteLine("You need to enter a number");
        age = -1;
    }
    else
    {
        age = int.Parse(ageString);
    }

    Console.Write(age + " are you sure? What is your weight? ");
    float weight;
    weight = float.Parse(Console.ReadLine());
    Console.WriteLine("Are you sure you are only " + weight + "kg?");
    Console.Write("What is your height in cm? ");
    float heightCm = float.Parse(Console.ReadLine());
    // the / is the division operator
    float heightInMetres = heightCm / 100;
    // the * is the multiplication operator
    // the = is the assignment operator
    float bmi = weight / (heightInMetres * heightInMetres);
    // > is the greater than comparison operator and < is the less than comparison operator
    // || is the logical OR operator
    if (bmi > 25 || bmi < 18)
    {
        Console.WriteLine("Your BMI is not OK");
    }
    else
    {
        Console.WriteLine("You are an OK BMI");
    }

    /* the Logical AND is && <= means less than or equals 
     * >= means greater than or equal to
    */
    if (bmi <= 25 && bmi >= 18)
    {
        Console.WriteLine("Your BMI is OK");
    }
    else
        Console.WriteLine("Your BMI is not OK");
    //when + is placed between two strings or a string and a number
    //the two things are concatenated
    textWriter.WriteLine("name," + name);
    textWriter.WriteLine("age," + age);
    textWriter.WriteLine("height in cm," + heightCm);
    textWriter.WriteLine("mas in kg," + weight);
    textWriter.WriteLine("bmi," + bmi);
    Console.Write("More Data? ");
    yesNo = Console.ReadLine();
}
while (yesNo.Contains("y") || yesNo.Contains("Y"));
    /*
     * The next line closes the TextWriter.
     * If we don't close the file before the program stops 
     * we will lose at least some of the data we think
     * we have written to it!
     * */

    textWriter.Close();