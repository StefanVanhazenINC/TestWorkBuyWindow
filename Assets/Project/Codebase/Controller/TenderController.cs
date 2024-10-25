using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TenderController : MonoBehaviour
{
    [SerializeField] private Tender _tender;
    public UnityEvent OnTenderChange = new UnityEvent();

    //создает окно для предсталения 
    public Tender Tender
    {
        set
        {
            _tender = value;
            OnTenderChange?.Invoke();
        }
    }
    private void Awake()
    {
        OnTenderChange.AddListener(ShowViewTender);
    }

    public void SetTender(Tender tender)
    {
        if (tender != null)
        {
            Tender = tender;
        }
    }
    
    public void ShowViewTender()
    {
        TenderView t_tenderView = SpawnWindowTender(AssetPath.TenderView);
        t_tenderView.ShowTender(BuyTender,_tender.NameTender,_tender.DescriptionTender,_tender.Price,_tender.Discount,_tender.TotalPrice,_tender.ResourceDataContainer);
        
    }
    public void BuyTender() 
    {
        Debug.Log("Buy Tender");
    }

    private TenderView SpawnWindowTender(string path) 
    {
        TenderView t_tenderView = Resources.Load<TenderView>(path);
        t_tenderView = Instantiate(t_tenderView);
        return t_tenderView;
    }
}
