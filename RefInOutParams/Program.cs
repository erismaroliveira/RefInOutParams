/* Ref */
void Increment(ref int number)
{
    number++;
}

int number = 1;
Increment(ref number);
Console.WriteLine(number);
/* Ref */

/* In */
void Decrement(in int number1)
{
    // error compilation
    //number1--;
    var result = number1 - 2;
    Console.WriteLine("Valor Modificador de parâmetro In: " + result);
}

int number1 = 10;
Decrement(in number1);
Console.WriteLine("Valor sem executar a função Decrement: " + number1);
/* In */

/* Out */
int valor;

DoSomething(out valor);
Console.WriteLine(valor);

void DoSomething(out int number)
{
    number = 123;
}
/* Out */

/* Params */
UseParams(new Student("Erismar Oliveira"), 
    new Student("Bruce Wayne"), 
    new Student("Peter Parker"));

static void UseParams(params Student[] items)
{
    foreach (var t in items)
        Console.WriteLine(t + " ");
}

public record Student(string name);
/* Params */