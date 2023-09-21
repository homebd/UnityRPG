using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance {
        get {
            if(_instance == null)
            {
                GameObject go = GameObject.Find("GameManager");
                //없으면 생성
                if(go == null)
                {
                    go = new GameObject { name = "GameManager" };
                }

                if(go.GetComponent<GameManager>() == null)
                {
                    go.AddComponent<GameManager>();
                }
                
                //instance 할당
                _instance = go.GetComponent<GameManager>();
            }

            return _instance;
        }
    }

    public CharacterStatController PlayerStat;
    public InventoryController Inventory;
    public ShopController Shop;

    private void Start() {
        // 임시
        GameManager.Instance.PlayerStat.Init();
        GameManager.Instance.Inventory.Init();
        GameManager.Instance.Shop.Init();

        UIManager.Instance.LateStart();
    }
}
