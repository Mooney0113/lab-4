/*
Name: Nicholas Mooney
Course: CSCI 1250, Section 001
Assignment: Lab 04, Group Trip
Date: October 15, 2026
Description: Rebuilds the trip calculator with methods and arrays so it
 reports on a whole group instead of one person
 */



 //Trip Calculator 

const double pizza = 8 ;
const double taxRate = .18 ;

Console.Write("How many miles for your trip?");
double TripMiles = Convert.ToDouble(Console.ReadLine());

Console.Write("How many miles per gallon does your car go?");
double MilesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("How much did you pay for gas?");
double PricePerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("How many pizzas?");
double pizzaSlices = Convert.ToDouble(Console.ReadLine()) ;

Console.Write("Price per Pizza?");
double pricePerPizza = Convert.ToDouble(Console.ReadLine()) ;



double totalSlices = pizzaSlices * pizza ;

// Part 1



double fuelCost = FuelCost(TripMiles, MilesPerGallon, PricePerGallon) ;
double pizzaCost = pizzaSlices * pricePerPizza ;
double tripTotal = fuelCost + pizzaCost ;


Console.WriteLine("=== Part 1: The Trip ===") ;
Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));
Console.WriteLine("Pizza Cost: " + pizzaCost.ToString("C"));
Console.WriteLine("Trip Total: " + tripTotal.ToString("C"));

//Part 2

string[] names = { "Ada", "Grace", "Alan", "Katherine" };
double[] hoursWorked = { 22, 15, 30, 18 };
double[] hourlyRates = { 13.50, 16.00, 11.20, 14.80 };

int peopleGoing = names.Length ;
double slicesEach = totalSlices / names.Length ;
double costPerPerson = tripTotal / names.Length ;

Console.WriteLine("=== Part 2: The Group ===") ;
Console.WriteLine("People going: " + peopleGoing) ;
Console.WriteLine("Slices Each: " + slicesEach.ToString("F1"));
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C")) ;






static double FuelCost(double miles, double MilesPerGallon, double PricePerGallon)
{
  double gallons = miles / MilesPerGallon;
  return gallons * PricePerGallon;  
}
static double TakeHomePay(double hours, double hourlyRate, double taxRate)
{
    
}

static double HoursToCover(double amountOwed, double takeHomePerHour)
{
}    