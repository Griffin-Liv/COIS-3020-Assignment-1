﻿using System;

namespace COIS_3020_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            RouteMap<AirportNode> airportMap = new RouteMap<AirportNode>();
            /*
            airportMap.AddAirport(new AirportNode("Calgary International Airport", "YYC"));
            airportMap.AddAirport(new AirportNode("Edmonton International Airport", "YEG"));
            airportMap.AddAirport(new AirportNode("Fredericton International Airport", "YFC"));
            airportMap.AddAirport(new AirportNode("Gander International Airport", "YQX"));
            airportMap.AddAirport(new AirportNode("Halifax Stanfield International Airport", "YHZ"));
            airportMap.AddAirport(new AirportNode("Greater Moncton Roméo LeBlanc International Airport", "YQM"));
            airportMap.AddAirport(new AirportNode("Montréal–Trudeau International Airport", "YUL"));
            airportMap.AddAirport(new AirportNode("Ottawa Macdonald–Cartier International Airport", "YOW"));
            airportMap.AddAirport(new AirportNode("Québec/Jean Lesage International Airport", "YQB"));
            airportMap.AddAirport(new AirportNode("St. John's International Airport", "YYT"));
            airportMap.AddAirport(new AirportNode("Toronto Pearson International Airport", "YYZ"));
            airportMap.AddAirport(new AirportNode("Vancouver International Airport", "YVR"));
            airportMap.AddAirport(new AirportNode("Winnipeg International Airport", "YWG"));
            */

            airportMap.AddAirport(new AirportNode("Calgary", "YYC"));
            airportMap.AddAirport(new AirportNode("Edmonton", "YEG"));
            airportMap.AddAirport(new AirportNode("Fredericton", "YFC"));
            airportMap.AddAirport(new AirportNode("Gander", "YQX"));
            airportMap.AddAirport(new AirportNode("Halifax", "YHZ"));
            airportMap.AddAirport(new AirportNode("Moncton", "YQM"));
            airportMap.AddAirport(new AirportNode("Montréal", "YUL"));
            airportMap.AddAirport(new AirportNode("Ottawa", "YOW"));
            airportMap.AddAirport(new AirportNode("Québec", "YQB"));
            airportMap.AddAirport(new AirportNode("St. John's", "YYT"));
            airportMap.AddAirport(new AirportNode("Toronto", "YYZ"));
            airportMap.AddAirport(new AirportNode("Vancouver", "YVR"));
            airportMap.AddAirport(new AirportNode("Winnipeg", "YWG"));




            airportMap.AddRoute(airportMap.FindAirportName("Toronto"), airportMap.FindAirportName("Calgary"));
            airportMap.AddRoute(airportMap.FindAirportName("Toronto"), airportMap.FindAirportName("Winnipeg"));

            airportMap.AddRoute(airportMap.FindAirportName("Winnipeg"), airportMap.FindAirportName("Calgary"));
            airportMap.AddRoute(airportMap.FindAirportName("Calgary"), airportMap.FindAirportName("Vancouver"));
            
            airportMap.AddRoute(airportMap.FindAirportName("Vancouver"), airportMap.FindAirportName("Montreal"));
            airportMap.AddRoute(airportMap.FindAirportName("Calgary"), airportMap.FindAirportName("Montreal"));
            airportMap.AddRoute(airportMap.FindAirportName("Montreal"), airportMap.FindAirportName("Ottawa"));
            
            // print out all the airports
            Console.WriteLine(airportMap.ToString());

            //show shortest route from toronto to vancouver in this instance winnipeg should be skipped toronto -> calgary -> vancouver
            Console.WriteLine(airportMap.FastestRoute(airportMap.FindAirportName("Toronto"), airportMap.FindAirportName("Vancouver")));

            //remove the route from toronto to calgary
            airportMap.RemoveRoute(airportMap.FindAirportName("Toronto"), airportMap.FindAirportName("Calgary"));

            //show shortest route from toronto to vancouver in this instance winnipeg should not be skipped toronto -> winnipeg -> calgary -> vancouver
            Console.WriteLine(airportMap.FastestRoute(airportMap.FindAirportName("Toronto"), airportMap.FindAirportName("Vancouver")));

            //should report no route
            Console.WriteLine(airportMap.FastestRoute(airportMap.FindAirportName("Calgary"), airportMap.FindAirportName("Fredericton")));

            //show the new list of airports and destinations with calgary removed from toronto as a destination
            Console.WriteLine(airportMap.ToString());




        }
    }
}


