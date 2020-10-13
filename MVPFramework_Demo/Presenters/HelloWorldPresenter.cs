using MVPFramework;
using MVPFramework_Demo.Views.Interfaces;
using MVPFramework_Demo.Views.UILogic;

namespace MVPFramework_Demo.Presenters
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