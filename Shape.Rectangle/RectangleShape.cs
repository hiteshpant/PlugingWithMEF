using ShapeContract;
using System.ComponentModel.Composition;

namespace Shape.Rectangle
{
    [Export(typeof(IShape))]
    public class RectangleShape : IShape
    {        
        public ShapeData Data
        {
            get;
            set;
        }

        [ImportingConstructor]
        public RectangleShape()
        {
            Data =  new RectangleShapeData();
        }

        public void Draw(ShapeData shape)
        {
           
        }
    }
}
