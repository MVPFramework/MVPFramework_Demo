using MVPFramework_Demo.Presenters;
namespace MVPFramework_Demo
{
    public class PresenterStub
    {
        // HelloWorld 界面
        private static HelloWorldPresenter _helloWorldPresenter = null;
        public static HelloWorldPresenter HelloWorldPresenter
        {
            set => _helloWorldPresenter = value;
            get
            {
                if (_helloWorldPresenter == null)
                {
                    _helloWorldPresenter = new HelloWorldPresenter();
                }
                return _helloWorldPresenter;
            }
        }
    }
}
