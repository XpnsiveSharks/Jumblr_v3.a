using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jumblr_v3.a.Commons
{
    public interface IAttributes
    {
        string WORDS { get; set; }
        string HINT { get; set; }
        string DIFFICULTY { get; set; }
        int SCORE {  get; set; }
    }
}
