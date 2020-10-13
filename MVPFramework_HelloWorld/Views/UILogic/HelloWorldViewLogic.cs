using MVPFramework;
using MVPFramework_HelloWorld.Views.Interfaces;

namespace MVPFramework_HelloWorld.Views.UILogic
{
    public class HelloWorldViewLogic : ViewLogic<HelloWorldView, IHelloWorldView>, IHelloWorldView
    {
        public void Activate()
        {
            target?.Activate();
        }

        public void Close()
        {
            target?.Close();
        }

        public void LayoutSayTxt(string sayTxt)
        {
            target.lbsay.Text = sayTxt;
        }

        public void Show()
        {
            target?.Show();
        }
    }
}
