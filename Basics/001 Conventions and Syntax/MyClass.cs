//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

//Based on the HelloWorld File, turn this into a class.

//Write a console program with a program class, and Main Function
//Add another class with any name, add variables 
//Using the new keyword create several objects
//Console writeline the Objects variables

using System;

public class School
{
    public Backpack jamesPack;
    public Backpack hillaryPack;
    public Backpack deweyPack;
    public Coat jamesCoat;
    public Coat hillaryCoat;

    public void Main()
    {
        jamesPack = new Backpack();
        hillaryPack = new Backpack();
        deweyPack = new Backpack();
        jamesCoat = new Coat();
        hillaryCoat = new Coat();

        jamesPack.books = 3;
        jamesPack.folders = 3;
        jamesPack.pens = 8;
        jamesPack.dirty = true;

        hillaryPack.books = 2;
        hillaryPack.folders = 4;
        hillaryPack.pens = 3;
        hillaryPack.dirty = false;

        deweyPack.books = 1;
        deweyPack.folders = 8;
        deweyPack.pens = 3;
        deweyPack.dirty = false;

        jamesCoat.floof = 10.7f;
        jamesCoat.hood = false;

        hillaryCoat.floof = 39.2f;
        hillaryCoat.pockets = 4;

        Console.WriteLine("James has " + jamesPack.books + " books in his backpack.");
        Console.WriteLine("James has " + jamesPack.folders + " folders in his backpack.");
        Console.WriteLine("Hillary has " + hillaryPack.folders + " folders in her backpack.");
        Console.WriteLine("Hillary has " + hillaryPack.pens + " pens in her backpack.");
        Console.WriteLine("Dewey is weird." + " Let's not talk about him.");

        Console.WriteLine("");
        Console.WriteLine("James has about " + jamesCoat.floof + " amount of floof in his coat.");
        Console.WriteLine("Hillary has about " + hillaryCoat.floof + " amount of floof in her coat.");
    }    
}

public class Backpack
{
    public int books;
    public int folders;
    public int pens;
    public bool dirty;
}

public class Coat
{
    public float floof;
    public int pockets = 2;
    public bool hood = true;
}