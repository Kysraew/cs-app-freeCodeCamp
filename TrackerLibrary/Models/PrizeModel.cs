using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        public int Id{  get; set; }
        public int PrizeNumber {  get; set; }
        public string PrizeName {  get; set; }
        public decimal PrizeAmount {  get; set; }
        public double PrizePercentage { get; set; }

        public PrizeModel() 
        {
        
        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PrizeName = placeName;
            
            int prizeNumberValue = 0;
            int.TryParse(placeNumber, out prizeNumberValue);
            PrizeNumber = prizeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
