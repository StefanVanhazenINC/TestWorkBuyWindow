public class ResourceDataContainer
{
    public readonly ResourceData _resourceData;
    public readonly int _value = 0;

    public ResourceDataContainer(ResourceData resourceData, int value)
    {
        _resourceData = resourceData;
        _value = value;
    }
}