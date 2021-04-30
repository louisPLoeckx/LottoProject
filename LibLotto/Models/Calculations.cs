using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibLotto.Models
{
    public class Calculations
    {
        public static int numberOfPicks { get; set; }
        public static List<CalculationLottoNumbers> GetPicks()
        {
            List<CalculationLottoNumbers> MultiplePicks = new List<CalculationLottoNumbers>();
            int count = 0;
            while (numberOfPicks < count)
            {
                //CalculationLottoNumbers CalculationLottoNumbers = new CalculationLottoNumbers();
                MultiplePicks.Add(new CalculationLottoNumbers());
                count++;
            }

            return MultiplePicks;
        }

        
    }
}
