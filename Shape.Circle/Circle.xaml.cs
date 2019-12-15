using ShapeContract;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace Shape.Circle
{    

    [Export(typeof(IView))]
    public partial class CircleControl : UserControl, IView
    {
        public ShapeData Data => _VM?.Data;
        private readonly CircleViewModel _VM;

        [ImportingConstructor]
        public CircleControl(CircleViewModel VM)
        {
            _VM = VM;
            this.DataContext = VM;
            InitializeComponent();
        }
    }
}
