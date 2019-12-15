using ShapeContract;
using System.ComponentModel.Composition;

namespace Shape.Rectangle
{
    [Export(typeof(ShapeData))]
    public class RectangleShapeData : ShapeData
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public string Name
        {
            get;
            private set;
        }

        [ImportingConstructor]
        public RectangleShapeData()
        {
            Height = 10;
            Width = 20;
            DisplayName();
        }

        public void DisplayName()
        {
            Name = "Rectangle";
        }
    }
}