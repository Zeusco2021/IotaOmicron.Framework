namespace IotaOmicron.Framework.Utilities.Common.Classes
{
    public class StandardResult<T>
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public T Data;
    }
}
