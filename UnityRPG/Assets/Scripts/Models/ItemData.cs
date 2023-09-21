using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemData : MonoBehaviour
{
    public ItemSO ItemSO;

    public int Id;
    public Sprite Icon;
    public string Name;
    public string Description;
    public int Price;

    public bool CanStack;

    public ItemData GetItem() {
        ItemData newItemData = new ItemData();

        newItemData.ItemSO = ItemSO;
        newItemData.Id = ItemSO.Id;
        newItemData.Icon = ItemSO.Icon;
        newItemData.Name = ItemSO.Name;
        newItemData.Description = ItemSO.Discription;
        newItemData.CanStack = ItemSO.CanStack;
        newItemData.Price = ItemSO.Price;

        return newItemData;
    }
}
