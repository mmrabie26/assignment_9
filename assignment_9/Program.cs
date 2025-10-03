

//1.Write a program that reads two numbers from the user and prints their sum, difference,
//product, and quotient (Arithmetic Operators).

//int num1, num2, sum, difference, product, quotient;

//Console.Write("Enter First Number: ");
//num1 = int.Parse(Console.ReadLine());


//Console.Write("Enter Second Number: ");
//num2 = int.Parse(Console.ReadLine());

//sum = num1 + num2;
//difference = num1 - num2;
//product = num1 * num2;
//quotient = num1 / num2;
//Console.WriteLine("Sum: " + sum);
//Console.WriteLine("difference: " + difference);
//Console.WriteLine("product: " + product);
//Console.WriteLine("quotient: " + quotient);



//2.Create a program that compares two numbers and prints whether they are equal or not
//(Relational Operators).

//int num1, num2;

//Console.Write("Enter First Number: ");
//num1 = int.Parse(Console.ReadLine());

//Console.Write("Enter Second Number: ");
//num2 = int.Parse(Console.ReadLine());

//Console.WriteLine(num1==num2);

//int age, salary;

//Console.Write("Enter your age: ");
//age = int.Parse(Console.ReadLine());

//Console.Write("Enter your salary: ");
//salary = int.Parse(Console.ReadLine());

//Console.WriteLine(age > 18 && salary > 5000);




//4.Demonstrate the difference between `x = y;` and `x += y;` with examples(Assignment
//Operators).

//the oprator equal "=" it assign right side(y) in left side (y)
//the oprator plussEqual"+=" it do two equation sumation right side (X) and left side (Y) and assign value in left side(X)



//5.Write a program that demonstrates the use of Unary Operators (++ and --) on a variable.

//int x = 5;

//Console.WriteLine(x++);
//Console.WriteLine(x--);




//6.Use the Ternary Operator to check if a number is even or odd.

//int x;

//Console.Write("Enter Number: ");
//x = int.Parse(Console.ReadLine());

//if (x % 2 == 0) Console.WriteLine("this number is even");
//else Console.WriteLine("this number is odd");




//7.Demonstrate the Null-Coalescing Operator (`??` and `??=`) on a nullable string variable.

//String name = null;
//String testName = name??"dummy name";
//Console.WriteLine(testName);

// ?? → returns left if not null, otherwise right.

//String user = null;
//user ??= "mmrabie";
//Console.WriteLine(user);

// ??= → assign right if left is null.



//8.Write a program that shows the difference between string concatenation using `+` and
//string interpolation

//String firstName, secondName;
//firstName = "Ali";
//secondName = "Ahmed";

//Console.WriteLine(firstName+secondName+" "+secondName);
//Console.WriteLine($"firstName: {firstName} | secondName: {secondName}");





//9.Write a program that prints the current date in the format `dd/MM/yyyy` using string formatting.

//Console.WriteLine($"Tody: {DateTime.Now:dd/mm/yyyy}");



//10.Show an example proving that strings are immutable (use `Replace` and check whether the reference changes or not).

//String testReplace = "test replace";
//testReplace.Replace("test", "hello");
//Console.WriteLine(testReplace);



//11.Write code using StringBuilder to add 3 different sentences and then remove one of them.

//StringBuilder sb = new StringBuilder();
//sb.Append("hello");
//sb.Append(" world");
//sb.Append(" C#");
//sb.Remove(0, 5);
//Console.WriteLine(sb);



//12.Write a program that reads a student’s grade and prints 'Pass' if >= 50, otherwise 'Fail'.

//int studentGrade;

//Console.Write("Enter your grade: ");
//studentGrade=int.Parse(Console.ReadLine());

//String grade = studentGrade >= 50 ? "pass" : "fail";
//Console.Write($"you are {grade}");




//13.Create a switch statement that checks a number from 1 to 3 and prints 'One', 'Two', or 'Three'.

//int num;

//Console.Write("Enter any number in (1->3: ");
//num = int.Parse(Console.ReadLine());

//if(num==1) Console.WriteLine("one");
//else if(num==2) Console.WriteLine("two");
//else if(num==3) Console.WriteLine("three");
//else Console.WriteLine("the assign number is gretter theen 3");



//14.Rewrite the previous example using a switch expression.


//int num;

//Console.Write("Enter any number in (1->3: ");
//num = int.Parse(Console.ReadLine());

//switch (num)
//{
//    case 1: 
//        Console.WriteLine("one");
//        break;
//    case 2: 
//        Console.WriteLine("two");
//        break;
//    case 3: 
//        Console.WriteLine("three");
//        break;
//    default: 
//        Console.WriteLine("the assign number is gretter theen 3");
//        break;
//}




//15.Write a for loop that prints numbers from 1 to 10.

//for(int x = 1; x <= 10; x++)
//{
//    Console.WriteLine(x);
//}



//16.Write a foreach loop that prints the names of 5 students stored in an array.

//String[] students = {"ali","glal","mohammed", "goda","ahmed"};

//foreach (var item in students)
//{
//    Console.WriteLine(item);
//}




//17.Write a while loop that keeps asking the user to enter numbers and sums them until the user enters 0.


//Console.WriteLine("Enter numbers when want exist ent 0");
//int sum=0;
//int num=0;
//do
//{
//    Console.Write("Enter number: ");
//    num= int.Parse(Console.ReadLine());
//    sum += num;

//} while (num != 0);

//Console.WriteLine($"number Sum:{sum}");



//18.Write a do-while loop that asks the user to enter a password and repeats until the user enters '1234'.

//int pass = 0;
//do
//{

//    Console.Write("Enter your password");
//    pass = int.Parse(Console.ReadLine());

//} while (pass!= 1234);

//Console.WriteLine($"your password is :{pass}");


//19.Create a 2D array (3x3), fill it with numbers 1–9, and print it.

//int[,] arry2D = new int[3, 3]
//{
//    { 1,2,3},
//    { 4,5,6},
//    { 7,8,9}
//};

//for(int arry1=0; arry1<arry2D.GetLength(0); arry1++)
//{
//    for(int arry2=0; arry2<arry2D.GetLength(1); arry2++)
//    {
//        Console.Write(arry2D[arry1,arry2] + ",");
//    }
//    Console.WriteLine();
//}


//20.Write a program that demonstrates the difference between shallow copy and deep copy on an integer array

//// shallow copy
//Student s1 = new Student(1, "ahmed");
//Student s2 = s1;

////deep copy
//Student s3 = new Student();
//s3.deepCopy(s1);

//class Student
//{
//    public Student() { }

//    public Student(int id, String name)
//    {
//        this.Id = id;
//        this.Name = name;
//    }
//    public int Id { get; set; }
//    public string Name { get; set; }

//    public void deepCopy(Student student)
//    {
//        this.Id = student.Id;
//        this.Name = student.Name;
//    }
//}




