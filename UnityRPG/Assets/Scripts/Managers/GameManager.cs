using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance {
        get {
            if(_instance == null) {
                GameObject obj = new GameObject("GameManager");

                _instance = obj.AddComponent<GameManager>();
            }

            return _instance;
        }
    }

    public CharacterStatController PlayerStat;
    public InventoryController Inventory;
    public ShopController Shop;
}
