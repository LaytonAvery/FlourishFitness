using System.Collections.Generic;

namespace FlourishFitness.Pages
{
    public interface IBmi
    {
        IEnumerable<Bmi> GetBmiHistory();
        Bmi GetCurrentBmi();
        void AddBmi();
        void UpdateBmi();
    }
}