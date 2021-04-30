using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibLotto.Models
{
    public class OccuranceOfNumbers:Calculations
    {
        List<CalculationLottoNumbers> numbers;

        List<int> baseNumbers = new List<int>();
        List<int> starNumbers = new List<int>();

        public void OccuranceOfNumbersInLists()
        {
            int count = 0;
            List<CalculationLottoNumbers> numbers = GetPicks();

            baseNumbers = new List<int>();
            Dictionary<int,int> baseNumbersInList = new Dictionary<int, int>();
            starNumbers = new List<int>();
            Dictionary<int, int> starNumbersInList = new Dictionary<int, int>();

            while (count <= numberOfPicks)
            {
                foreach (var lottoNumbers in numbers)
                {
                    foreach (var number in lottoNumbers.BaseNumbers)
                    {
                        baseNumbers.Add(number);
                        if (!baseNumbersInList.Contains(number))
                        {
                            baseNumbersInList.Add(number);
                        }
                    }
                    foreach (var number in lottoNumbers.StarNumbers)
                    {
                        starNumbers.Add(number);
                        if (!starNumbersInList.Contains(number))
                        {
                            starNumbersInList.Add(number);
                        }
                    }
                }
            }

            foreach (int baseNumber in baseNumbers)
            {
                for (int i = 1; i <= 60; i++)
                {
                    if (i == baseNumber)
                    {
                        baseNumbersInList[i ]++;
                    }
                }
            }
            foreach (int starNumber in starNumbers)
            {
                for (int i = 1; i <= 12; i++)
                {
                    if (i == starNumber)
                    {
                        starNumbersInList[i]++;
                    }
                }
            }
        }

        public OccuranceOfNumbers()
        {
            OccuranceOfNumbersInLists();
        }
    }
}
