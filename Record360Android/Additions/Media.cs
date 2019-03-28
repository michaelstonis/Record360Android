using Java.Lang;

namespace Com.Record360.Sdk.Model
{
    public partial class Media: Object, IComparable
    {
        int IComparable.CompareTo(Object obj)
        {
            return CompareTo((Media)obj);
        }
    }
}
