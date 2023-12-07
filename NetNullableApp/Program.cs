using cPrinter = System.Console;

Person? person = null;

if(person != null)
    person.Name = "Bobby";

if(person is null)
    cPrinter.WriteLine("NULL");

if (person is not null)
    person.Name = "Bobby";

/*
if(person is not null)
{
    if(person.Company is not null)
    {
        if(person.Company.Country is not null)
            Console.WriteLine(person.Company.Country.OfficalName);
    }
}
*/

person = new Person
{
    Name = "Bobby",
    Company = new Company()
    {
        Title = "Yandex",
        
    }
};

Console.WriteLine(person?.Company?.Country?.OfficalName);




string name = null;

PrintName(name!);

int? n = null;
Nullable<int> m = 10;

Console.WriteLine(n.HasValue);
Console.WriteLine(m.HasValue);

int a = 10;

a = n ?? 100;

Console.WriteLine($"a = {a}");

void PrintName(string name)
{
    if(name == null)
        Console.WriteLine("NULL");

    Console.WriteLine($"Hello {name}");
}


class Person
{
    public string? Name { set; get; }
    public Company? Company { set; get; }
}

class Company
{
    public string? Title { set; get; }
    public Country? Country { set; get; }
}

class Country
{
    public string? OfficalName { set; get; }
}

