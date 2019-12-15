using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using ShapeContract;
using System.Linq;
using System.ComponentModel;

namespace ShapeParser
{
    [Export]
    public class ShapeParserViewModel:ViewModelBase
    {
        private IShape _SelectedShape;
        private List<IShape> _Shapes { get; set; }
        private readonly IList<IView> _AvailableViews;

        public ObservableCollection<IShape> Shapes { get; set; }

        public IView SelectedData
        {
            get;
            set;
        }

        public IShape SelectedShapeData
        {
            get
            {
                return _SelectedShape;
            }
            set
            {
                _SelectedShape = value;
                SelectedData = _AvailableViews.Where(x =>x.Data.GetType().Name==_SelectedShape.Data.GetType().Name).FirstOrDefault();
                OnPropertyChanged("SelectedData");
            }
        }

        [ImportingConstructor]
        public ShapeParserViewModel([ImportMany]IEnumerable<IShape> shapes,
            [ImportMany]IEnumerable<IView> vmBase)
        {
            _Shapes = shapes.ToList();
            _AvailableViews = vmBase.ToList();
            Shapes = new ObservableCollection<IShape>();
            PopulateShapes();
            SelectedShapeData = Shapes[0];
        }


        private void PopulateShapes()
        {
            _Shapes.ToList()
                  .ForEach((shape) =>
                  {
                      Shapes.Add(shape);
                  });         
        }
    }
}
