using UnityEngine;

[CreateAssetMenu(menuName ="Data/Resources/New Resource",fileName ="Resource")]
public class ResourceData : ScriptableObject
{
    [SerializeField] private Sprite _icon;

    public Sprite Icon { get => _icon; set => _icon = value; }
}
