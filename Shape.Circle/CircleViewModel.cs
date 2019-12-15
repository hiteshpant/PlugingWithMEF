using ShapeContract;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Shape.Circle
{
    [Export]
    public class CircleViewModel : ViewModelBase
    {
        private readonly CircleData _CircleData;

        public ICommand CalculateAreaCommand { get; }

        public ShapeData Data
        {
            get
            {
                return _CircleData;
            }
        }

        public double Area
        {
            get
            {
                return 3.14 * Math.Pow(Radius, 2);
            }
            
        }

        public double Radius
        {
            get
            {
                return _CircleData.Radius;
            }
            set
            {
                _CircleData.Radius = value;
            }
        }

        [ImportingConstructor]
        public CircleViewModel()
        {
            _CircleData = new CircleData();
            CalculateAreaCommand = new RelayCommand(OnCalcullateArea);
            OnCalcullateArea();
        }

        private void OnCalcullateArea()
        {            
            OnPropertyChanged("Area");
        }
    }
}
