using ShapeContract;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Shape.Rectangle
{
    /// <summary>
    /// Interaction logic for RectangleControl.xaml
    /// </summary>
    /// 
    [Export(typeof(IView))]
    public partial class RectangleControl : UserControl, IView
    {
        private readonly RectangleViewModel _ViewModel;

        public ShapeData Data => _ViewModel?.Data;

        [ImportingConstructor]
        public RectangleControl(RectangleViewModel vm)
        {
            _ViewModel = vm;
            this.DataContext = _ViewModel;
            InitializeComponent();
        }
    }
}
