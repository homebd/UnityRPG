using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] private List<ItemSO> ItemSO;
    
    public ItemSO GetItemSOWithID(int id) {
        if(0 <= id && id < ItemSO.Count) {
            return ItemSO[id];
        }
        
        return null;
    }
}
