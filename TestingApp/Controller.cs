using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayGameOfLife
{
    abstract class Controller
    {
        #region getControllerStatic
        public static Controller GetDefaultController()
        {
            Controller controller = new Adapter();
            return controller;
        }

        #endregion   
        public abstract void ClickOnGrid(int x=0, int y=0);
        private IView view = null;
        public abstract IView GetView();
        public abstract void SetView(IView newView);

    }


    internal class Adapter:Controller
    {
        private IView view = new GUI();
        public override void ClickOnGrid(int x=0, int y=0)
        {
            Console.Write("Ai apasat pe grid");
            view.UpdateView();
        }

        public override IView GetView()
        {
            return this.view;
        }

        public override void SetView(IView newView)
        {
            this.view = newView;
        }
    }
}
