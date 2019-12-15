using ShapeContract;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Shape.Rectangle
{
    [Export]
    public class RectangleViewModel:ViewModelBase
    {
        private readonly Rectangle.RectangleShapeData _RectangleData;

        public ICommand CalculateAreaCommand { get; }

        public ShapeData Data
        {
            get
            {
                return _RectangleData;
            }
        }

        public double Area
        {
            get
            {
                return _RectangleData.Width * _RectangleData.Height;
            }
        }

        public double Width
        {
            get
            {
                return _RectangleData.Width;
            }
            set
            {
                _RectangleData.Width= value;
            }
        }

        public double Height
        {
            get
            {
                return _RectangleData.Height;
            }
            set
            {
                _RectangleData.Height = value;
            }
        }

        [ImportingConstructor]
        public RectangleViewModel()
        {
            CalculateAreaCommand = new RelayCommand(OnCalcullateArea);
            _RectangleData = new Rectangle.RectangleShapeData();
        }

        private void OnCalcullateArea()
        {
            OnPropertyChanged("Area");
        }
       
    }
}
