using MVPFramework_Demo.Views.UILogic;
using System;
using System.Windows.Forms;

namespace MVPFramework_Demo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run((PresenterStub.HelloWorldPresenter.View as HelloWorldViewLogic).target);
        }
    }
}
