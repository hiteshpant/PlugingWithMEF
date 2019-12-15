using ShapeContract;
using System.ComponentModel.Composition;

namespace Shape.Circle
{
    [Export(typeof(ShapeData))]
    public class CircleData : ShapeData
    {
        public double Radius
        {
            get;
            set;
        }


        public string Name
        {
            get;
            set;
        }

        [ImportingConstructor]
        public CircleData()
        {
            Radius = 10;
            DisplayName();
        }

        public void DisplayName()
        {
            Name = "Circle";
        }
    }
}