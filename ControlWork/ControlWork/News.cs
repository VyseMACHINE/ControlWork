using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    [Serializable]
    public class News : List<News>
    {
        public string Title { get; set; }
        public string Context { get; set; }       
        public DateTime Date { get; set; }
    }
}
