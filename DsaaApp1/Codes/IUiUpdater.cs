namespace DsaaApp1.Codes
{
    public interface IUiUpdater
    {
        void UpdateUi(string message, bool appendMessage = false, object someObject = null);
    }
}