namespace ExpiCore
{
    public interface IWriteItemPassedData
    {
        string ObjectName { get; }
        string Property { get; }
        object Value { get; }
    }
}
