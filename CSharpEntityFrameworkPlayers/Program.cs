// See https://aka.ms/new-console-template for more information
using CSharpEntityFrameworkPlayers;

Console.WriteLine("Hello, World!");
Random rd = new Random();
/*
using(SchoolContext db = new SchoolContext())
{
    Student studente = new Student() { Name = "Francesco", Surname = "Pippo", Email = "francesco.pippo98@gmail.com" };

    db.Add(studente);
    db.SaveChanges();

    Console.WriteLine("Studente inserito nel database!");
}*/


using (SportContext db = new SportContext())
{
    int[] DueNumeri = GeneraDueNumeri();
    Player uno = new Player() { Name = "Uno", Surname = "Primo", Punteggio = rd.Next(1, 10), Vinte = DueNumeri[0], Giocate = DueNumeri[1]};

    db.Add(uno);
    db.SaveChanges();

    Console.WriteLine(uno.ToString);
}


 int[] GeneraDueNumeri()
{
    int[] Arr = {0, 0 };

    int x = rd.Next(1, 100);
    int y = rd.Next(1, 100);
    if(x > y)
    {
        Arr[0] = y;
        Arr[1] = x;
    }
    else
    {
        Arr[0] = x;
        Arr[1] = y;
    }

    return Arr;
}