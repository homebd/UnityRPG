using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 이걸 누가 들고 있어야 하는 거지 -> 일단 Player
public class ShopController : MonoBehaviour
{
    public event Action<ShopData> OnInitEvent;
    public event Action OnBuyEvent;
    private ShopData _shopData;

    // 기본 상점 데이터를 어디에서 초기화해야 하는지?
    public List<ItemData> ItemList;

    public void Init() {
        _shopData = new ShopData();

        foreach(ItemData data in ItemList) {
            _shopData.Items.Add(data.GetItemData());
        }

        CallInitEvent(_shopData);
    }

    public void CallInitEvent(ShopData shop) {
        OnInitEvent?.Invoke(shop);
    }

    public void CallBuyEvent() {
        OnBuyEvent?.Invoke();
    }
}
