using System;
using System.ComponentModel.Composition;
namespace ShapeContract
{   
    public interface IShape
    {       
        ShapeData Data { get; }
        void Draw(ShapeData shape);
    }
}
