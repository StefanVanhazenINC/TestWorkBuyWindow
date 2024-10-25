using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TenderCreator : MonoBehaviour
{

    [SerializeField] private string[] _namaTender;
    [SerializeField] private string[] _descriptionTender;
    [SerializeField, Range(1, 10)] private int _rangePriceMax;
    [SerializeField, Range(1, 10)] private int _rangePriceMin;
    [SerializeField, Range(0, 100)] private int _rangeDiscountMax;
    [SerializeField, Range(0, 100)] private int _rangeDiscountMin;
    [SerializeField] private TenderController _tenderController;

    private int _valueItem = 0;
    private Tender _tender;
    public void SetValueItem(string valueItem) 
    {
        _valueItem = System.Int32.Parse(valueItem);
        if (_valueItem > 6) 
        {
            _valueItem = 6;
        }
        else if (_valueItem<0) 
        {
            _valueItem = 1;
        }
    }

    public void CreateTender()
    {
        if (_valueItem>0)
        {

            int t_indexNameAndDescription = Random.Range(0, _namaTender.Length);

            string t_nameTender = _namaTender[t_indexNameAndDescription];
            string t_descriptionTender = _descriptionTender[t_indexNameAndDescription];

            int t_price = Random.Range(_rangePriceMin, _rangePriceMax);
            int t_rangeDiscount = Random.Range(_rangeDiscountMin, _rangeDiscountMax);

            ResourceDataContainer[] t_container = new ResourceDataContainer[_valueItem];

            for (int i = 0; i < _valueItem; i++)
            {
                int indexResource = Random.Range(0, AssetPath.ListResource.Count);
                t_container[i] = new ResourceDataContainer(GetResourceData(AssetPath.ListResource[indexResource]), 20);
            }
            _tender = new Tender(t_nameTender, t_descriptionTender, t_price, t_rangeDiscount, t_container);
            _tenderController.SetTender(_tender);
        }
    }

    public ResourceData GetResourceData(string path) 
    {
        ResourceData t_resourceData = Resources.Load<ResourceData>(path)  ;
        return t_resourceData;
    }
}

