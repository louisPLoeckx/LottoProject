using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibLotto.Models
{
    public class CalculationLottoNumbers: LottoNumbers
    {
        //public  lottoNumbers = new LottoNumbers();

        public void CalculateBaseNumbers()
        {
            
            Random random = new Random();
            int amountOfBaseNumbers = 5;
            int count = 0;

            while (count < amountOfBaseNumbers)
            {
                int number = random.Next(1, 50);
                if (!BaseNumbers.Contains(number))
                {
                    BaseNumbers.Add(number);
                    count++;
                }
            }
        }

        public void CalculateStarNumbers()
        {
            Random random = new Random();
            int amountOfBaseNumbers = 2;
            int count = 0;

            while (count < amountOfBaseNumbers)
            {
                int number = random.Next(1, 12);
                if (!StarNumbers.Contains(number))
                {
                    StarNumbers.Add(number);
                    count++;
                }
            }
        }

        public CalculationLottoNumbers()
        {
            CalculateBaseNumbers();
            CalculateStarNumbers();
        }
    }
}
