using MVPFramework;

namespace MVPFramework_HelloWorld.Views.Interfaces
{
    public interface IHelloWorldView:IViewLogic
    {
        void LayoutSayTxt(string sayTxt);
    }
}
