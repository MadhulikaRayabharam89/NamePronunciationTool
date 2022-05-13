using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NamePronunciation.Services
{
    public interface IPronunciationService
    {
        public string GetStandardPronunciation(string Name);
        public string GetPhoneticsforName(string Name);
        

    }
}
