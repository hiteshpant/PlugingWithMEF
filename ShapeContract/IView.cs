using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeContract
{
    public interface IView
    {
        ShapeData Data { get; }
    }
}
