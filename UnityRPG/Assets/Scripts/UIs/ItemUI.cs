using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    private ItemSO _itemSO;
    public ItemSO ItemSO {
        get {
            return _itemSO;
        }
        set {
           _itemSO = value;

           Icon.sprite = _itemSO.Icon; 
        }
    }
    public Image Icon;
    public Text Count;
}
