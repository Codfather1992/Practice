// See https://aka.ms/new-console-template for more information
using SuperHero_Generator.Interfaces;
using SuperHero_Generator.Models;

Console.WriteLine("Hello, World!");
IBeing being = new Human();
List <IBeing> list = new List<IBeing>();