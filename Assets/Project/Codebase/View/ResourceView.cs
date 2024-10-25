using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResourceView : MonoBehaviour
{
    [SerializeField] private TMP_Text _value;
    [SerializeField] private Image _icon;

    public void SetResourceView(string value,Sprite icon)
    {
        _value.text =  value;
        _icon.sprite = icon;

    }
}
