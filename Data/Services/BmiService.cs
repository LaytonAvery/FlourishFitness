using System.Collections.Generic;

namespace FlourishFitness.Pages
{
    public class BmiService : IBmi
    {
        public void AddBmi()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Bmi> GetBmiHistory()
        {
            var bmiList = new List<Bmi>()
            {
                new Bmi{ UserId=1, Age=26, Height=67, Weight=165 },
                new Bmi{ UserId=1, Age=26, Height=67, Weight=160 },
                new Bmi{ UserId=1, Age=26, Height=67, Weight=155 },
                new Bmi{ UserId=1, Age=26, Height=67, Weight=150 },
            };

            return bmiList;
        }

        public Bmi GetCurrentBmi()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateBmi()
        {
            throw new System.NotImplementedException();
        }
    }
}