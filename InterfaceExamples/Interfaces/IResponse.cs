using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples.Interfaces
{
    public interface IResponse
    {
        int Id { get; set; }
        string Name { get; set; }
        string Username { get; set; }
        string Password { get; set; }
    }
}
