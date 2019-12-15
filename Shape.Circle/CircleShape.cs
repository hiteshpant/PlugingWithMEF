using ShapeContract;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Circle
{
    [Export(typeof(IShape))]
    public class CircleShape : IShape
    {       
        public ShapeData Data
        {
            get;
            set;
        }

        public CircleShape()
        {

            Data = new CircleData();
        }

        public void Draw()
        {           
        }

        public void Draw(ShapeData shape)
        {           
        }
    }
}
