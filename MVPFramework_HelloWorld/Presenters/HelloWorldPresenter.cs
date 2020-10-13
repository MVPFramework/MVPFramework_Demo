using MVPFramework;
using MVPFramework_HelloWorld.Views.Interfaces;
using MVPFramework_HelloWorld.Views.UILogic;

namespace MVPFramework_HelloWorld.Presenters
{
    [ViewLogicBinding(typeof(HelloWorldViewLogic))]
    public class HelloWorldPresenter : Presenter<IHelloWorldView>
    {
        public HelloWorldPresenter()
        {
            UpdateSayToWho("stranger");
        }

        public void Show(bool isShow)
        {
            if (isShow) { View.Show(); }
            else { View.Close(); }
        }

        public void UpdateSayToWho(string name)
        {
            View.LayoutSayTxt("Hello, " + name + ", welcome to use MVPFramework!");
        }
    }
}