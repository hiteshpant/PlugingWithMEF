using System.ComponentModel.Composition;

namespace ShapeContract
{
    public interface ShapeData
    {
        string Name { get; }
        void DisplayName();     
    }
}