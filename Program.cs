using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpet_Fitter_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string clientName = "";
            string roomName = "";
            decimal roomLength = 0m;
            decimal roomWidth = 0m;
            decimal roomDimensions = (decimal)(roomLength + roomWidth);
            string[] carpetQuality = new string[2] { "Basic", "Standard", "Luxury" }; //This creates a 3 element array numbered 0-2
            string[] carpetQualityCost = new string[2] { "£1.50", "£3.00, £5.00" };

            bool carpetQualityBasic = false;
            bool carpetQualityStandard = false;
            bool carpetQualityLuxury = false;

            float basic =(float)(1.50 * roomLength * (roomWidth));
            decimal standard = (float)(3.00 * roomLength) * roomWidth;
            decimal luxury = (float)(5.00 *roomLength * (roomWidth));

            char symbol = '£';
            decimal basicQuality = (decimal)(basic + symbol);
            decimal standardQuality = (decimal)(standard + symbol);
            decimal luxuryQuality = (decimal)(luxury + symbol);

            string underlayRequired = "";
            bool underlayRequiredInput = false;
            decimal underlayCost = 0m;

            decimal fittingCost = 49.99m;
            decimal fittingCostWsymbol = symbol + fittingCost;

            decimal totalCost = 0m;
            decimal vat = (decimal)(totalCost) * (100 / 20);

            Console.WriteLine("Hello and Welcome ot the Carpet Fitter Program!");
            Console.WriteLine("This is where you enter the measurements of your room(s) and calculate the total cost based on your room dimensions and carpet quality");

            Console.WriteLine("Please enter your name");
            clientName = (Console.ReadLine());

            Console.WriteLine("Please first enter your room name, for e.g. 'living room' ");
            roomName = (Console.ReadLine());

            Console.WriteLine("Please enter the dimensions of" + roomName + " - the room length first, and then width second");
            roomLength = decimal.Parse(Console.ReadLine());
            roomWidth = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Now you'll see on your scree, the different quality types of carpets, please select one of them");
            Console.WriteLine(carpetQuality);
            Console.WriteLine("These are the costs of these qualities, in the same sequence as above");
            Console.WriteLine(carpetQualityCost);





        }
    }
}
