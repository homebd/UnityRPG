using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopUI : MonoBehaviour
{
    public Text GoldText;
    public ShopSlotUI SlotPrefab;
    public GameObject ContentsObject;
    
    //private List<ShopSlotUI> _slots;

    private void Awake() {
        GameManager.Instance.Shop.OnInitEvent += Init;
        GameManager.Instance.PlayerStat.OnInitEvent += ShowGold;
        GameManager.Instance.PlayerStat.OnChangeGoldEvent += ShowGold;
    }
    public void Init(ShopData shop) {
        int ItemSize = shop.Items.Count;

        for(int i = 0; i < ItemSize; i++) {
            ShopSlotUI newSlot = Instantiate(SlotPrefab, ContentsObject.transform);
            ItemData itemData = shop.Items[i];

            newSlot.ItemId = itemData.Id;
            newSlot.ItemImage.sprite = itemData.Icon;
            newSlot.NameText.text = itemData.Name;
            newSlot.DescriptionText.text = itemData.Description;
            newSlot.PriceText.text = $"{itemData.Price.ToString()} G";
            newSlot.BuyButton.onClick.AddListener(() => ClickBuyButton(itemData));

            //_slots.Add(newSlot);
        }
    }

    public void ClickBuyButton(ItemData itemData) {
        // view -> controller로 시그널 보내는 법..?
        // view에선 controller의 존재(구조)를 모르게 하라던데
        GameManager.Instance.Shop.Buy(itemData);
    }

    public void ShowGold(CharacterStatsHandler character) {
        GoldText.text = $"{character.CurStats.Gold.ToString()} G";
    }
}
