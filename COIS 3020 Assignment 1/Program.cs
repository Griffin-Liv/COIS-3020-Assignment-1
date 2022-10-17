using System;

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
            Console.WriteLine("printing an empty RouteMap\n");
            Console.WriteLine(airportMap.ToString() + "\n");

            Console.WriteLine("adding airport nodes\n");

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

            Console.WriteLine("printing Routemap\n");
            Console.WriteLine(airportMap.ToString() + "\n");

            Console.WriteLine("attempting to add duplicate airport node for Halifax\n");
            airportMap.AddAirport(new AirportNode("Halifax", "YHZ"));

            Console.WriteLine("printing Routemap\n");
            Console.WriteLine(airportMap.ToString() + "\n");

            Console.WriteLine("adding destinations Toronto >> Calgary, Toronto >> Winnipeg, Winnipeg >> Calgary, and Calgary >> Vancouver\n");
            airportMap.AddRoute(airportMap.FindAirportName("Toronto"), airportMap.FindAirportName("Calgary"));
            airportMap.AddRoute(airportMap.FindAirportName("Toronto"), airportMap.FindAirportName("Winnipeg"));

            airportMap.AddRoute(airportMap.FindAirportName("Winnipeg"), airportMap.FindAirportName("Calgary"));
            airportMap.AddRoute(airportMap.FindAirportName("Calgary"), airportMap.FindAirportName("Vancouver"));
            
            Console.WriteLine("printing Routemap\n");
            Console.WriteLine(airportMap.ToString() + "\n");

            Console.WriteLine("attempting to add a duplicate route Winnipeg >> Calgary\n");
            airportMap.AddRoute(airportMap.FindAirportName("Winnipeg"), airportMap.FindAirportName("Calgary"));

            // print out all the airports
            Console.WriteLine("Printing RouteMap after adding destinations\n");
            Console.WriteLine(airportMap.ToString() + "\n");

            // print out an airport found by its name
            Console.WriteLine("testing the FindAirportName() method and Node.ToString(), looking for Winnipeg\n");
            Console.WriteLine(airportMap.FindAirportName("Winnipeg").ToString());

            // print out an airport found by its code
            Console.WriteLine("testing the FindAirportCode() method, looking for YYT\n");
            Console.WriteLine(airportMap.FindAirportCode("YYT").ToString());

            //show shortest route from toronto to vancouver in this instance winnipeg should be skipped toronto -> calgary -> vancouver
            Console.WriteLine("show shortest route from toronto to vancouver in this instance winnipeg should be skipped toronto -> calgary -> vancouver\n");
            Console.WriteLine(airportMap.FastestRoute(airportMap.FindAirportName("Toronto"), airportMap.FindAirportName("Vancouver")));

            //remove the route from toronto to calgary
            Console.WriteLine("remove the route from toronto >> calgary\n");
            airportMap.RemoveRoute(airportMap.FindAirportName("Toronto"), airportMap.FindAirportName("Calgary"));

            //show the new list of airports and destinations with calgary removed from toronto as a destination
            Console.WriteLine("show the new list of airports and destinations with calgary removed from toronto as a destination\n");
            Console.WriteLine(airportMap.ToString() + "\n");

            //attempt to remove a nonexistent route from toronto to calgary
            Console.WriteLine("attempt to remove a nonexistent route from toronto to calgary\n");
            airportMap.RemoveRoute(airportMap.FindAirportName("Toronto"), airportMap.FindAirportName("Calgary"));

            Console.WriteLine("printing Routemap\n");
            Console.WriteLine(airportMap.ToString() + "\n");

            //show shortest route from toronto to vancouver in this instance winnipeg should not be skipped toronto -> winnipeg -> calgary -> vancouver
            Console.WriteLine("show shortest route from toronto to vancouver in this instance winnipeg should not be skipped toronto -> winnipeg -> calgary -> vancouver\n");
            Console.WriteLine(airportMap.FastestRoute(airportMap.FindAirportName("Toronto"), airportMap.FindAirportName("Vancouver")));

            //should report no route
            Console.WriteLine("attempting to find the fastest route when no route exists\n");
            Console.WriteLine(airportMap.FastestRoute(airportMap.FindAirportName("Calgary"), airportMap.FindAirportName("Fredericton")));


            // attempting to find and airport with a name that doesnt exists
            Console.WriteLine("testing the FindAirportName() method, looking for Winni\n");
            if(airportMap.FindAirportName("Winni") == null){
                Console.WriteLine("airportMap.FindAirportName('Winni') returns a null value\n");
            }

            // attempting to find and airport with a code that doesnt exists
            Console.WriteLine("testing the FindAirportCode() method, looking for ZZZ\n");
            if(airportMap.FindAirportCode("ZZZ") == null){
                Console.WriteLine("airportMap.FindAirportCode('ZZZ') returns a null value\n");
            }

        }
    }
}
