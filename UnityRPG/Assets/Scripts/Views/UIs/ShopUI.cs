using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopUI : MonoBehaviour
{
    public ShopController ShopController;
    public Text GoldText;
    public ShopSlotUI SlotPrefab;
    public GameObject ContentsObject;
    
    //private List<ShopSlotUI> _slots;

    private void Awake() {
        ShopController.OnInitEvent += Init;

        // 인벤토리와 마찬가지로 임시..
        ShopController.Init();
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
            newSlot.BuyButton.onClick.AddListener(ClickBuyButton);

            //_slots.Add(newSlot);
        }
    }

    public void ClickBuyButton() {
        ShopController.CallBuyEvent();
    }

    public void ChangeGold(CharacterStatsData character) {
        GoldText.text = $"{character.Gold.ToString()} G";
    }
}
