namespace DsaaApp1.Codes
{
    public abstract class TestBedBase
    {
        protected readonly IUiUpdater UiUpdater;

        protected TestBedBase(IUiUpdater uiUpdater)
        {
            UiUpdater = uiUpdater;
        }
    }
}