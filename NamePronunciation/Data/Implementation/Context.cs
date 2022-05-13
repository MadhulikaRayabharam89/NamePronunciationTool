using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NamePronunciation.Data.Implementation
{
    public class Context:DbContext,IContext
    {
    }
}
