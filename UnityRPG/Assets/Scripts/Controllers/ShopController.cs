using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 이걸 누가 들고 있어야 하는 거지 -> 일단 Player
public class ShopController : MonoBehaviour
{
    public event Action<ShopData> OnInitEvent;
    private ShopData _shopData;

    // 기본 상점 데이터를 어디에서 초기화해야 하는지?
    public List<ItemData> ItemList;

    public void Init() {
        _shopData = new ShopData();

        foreach(ItemData data in ItemList) {
            _shopData.Items.Add(data.GetItem());
        }

        CallInitEvent(_shopData);
    }

    public void CallInitEvent(ShopData shop) {
        OnInitEvent?.Invoke(shop);
    }

    public void Buy(ItemData itemData) {
        if(!GameManager.Instance.PlayerStat.CheckGold(itemData.Price)) return;
        // 골드가 부족합니다.

        if(!GameManager.Instance.Inventory.AddItem(itemData)) return;
        // 인벤토리가 꽉 찼습니다.

        GameManager.Instance.PlayerStat.ChangeGold(-itemData.Price);
    }
}
