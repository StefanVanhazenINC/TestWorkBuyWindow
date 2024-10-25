
using UnityEngine;

public class Tender 
{
    public readonly string NameTender;
    public readonly string DescriptionTender;
    public readonly float Price;
    public readonly int Discount;
    public readonly float TotalPrice;
    public readonly ResourceDataContainer[] ResourceDataContainer;

    public Tender(string nameTender, string descriptionTender, int price, int discount, ResourceDataContainer[] resourceDataContainer)
    {
        Debug.Log("Create");
        NameTender = nameTender;
        DescriptionTender = descriptionTender;
        Price = price;
        Discount = discount;
        ResourceDataContainer = resourceDataContainer;

        TotalPrice = price * ((100 - (float)Discount) / 100);
    }
  
}
