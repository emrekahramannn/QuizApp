using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IQuestion
    {
        int Id { get; set; }
        string QuestionText { get; set; }
        string[] Choices { get; set; }
        string Answer { get; set; }
    }
}
