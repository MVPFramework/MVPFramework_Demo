using MVPFramework;
using MVPFramework_Demo.Views.Interfaces;

namespace MVPFramework_Demo.Views.UILogic
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
