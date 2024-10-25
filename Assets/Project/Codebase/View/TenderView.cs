using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TenderView : MonoBehaviour
{
    //кнопка 
    [SerializeField] private ResourceView[] _resourceView;
    [SerializeField] private TMP_Text _title;
    [SerializeField] private TMP_Text _description;

    [SerializeField] private GameObject _discountObject;
    [SerializeField] private TMP_Text _discount;
    [SerializeField] private TMP_Text _price;
    [SerializeField] private TMP_Text _totalPrice;

    [SerializeField] private Button _buy;
    [SerializeField] private Button _close;
    //поля 
    public void ShowTender(UnityAction buyAction,string nameTander,string descriptionTender,float price,int discount,float totalPrice, ResourceDataContainer[] resources)
    {
        _close.onClick.AddListener(CloseTenderView);
        _buy.onClick.AddListener(buyAction);
        _buy.onClick.AddListener(CloseTenderView);
        _title.text = nameTander;
        _description.text = descriptionTender;
        SetViewPrice(price, discount, totalPrice);
        for (int i = 0; i < resources.Length; i++)
        {
            string t_value = resources[i]._value.ToString();
            Sprite t_icon = resources[i]._resourceData.Icon;
            _resourceView[i].SetResourceView(t_value, t_icon);
            _resourceView[i].gameObject.SetActive(true);
        }
    }

    public void SetViewPrice(float price, int discount, float totalPrice)
    {
        _price.text = price.ToString();
        if (discount > 0) 
        {
            _price.fontStyle = FontStyles.Strikethrough;
            _price.fontSize = 10;

            _totalPrice.gameObject.SetActive(true);
            _totalPrice.text = totalPrice.ToString();

            _discountObject.gameObject.SetActive(true);
            _discount.text = discount.ToString();
        }
    }
    private void CloseTenderView() 
    {
        Destroy(gameObject);
    }
}
