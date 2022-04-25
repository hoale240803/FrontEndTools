namespace AngularGenTools.Handles
{
    /// <summary>
    /// base .html file to gen logic methods
    /// </summary>
    public interface IGenAngularComponent
    {
        void GenFileModules();

        void GenFileComponents();

        void GenServices();

        void GenValidate();

        void GenModels();

        void GenHandleForm();

        void GenHandleDropbox();

        void GenHandleInput();

        void GenHandleRadioButton();

        void GenHandleSelectBox();
        void GenWriteUnitTest();
    }
}