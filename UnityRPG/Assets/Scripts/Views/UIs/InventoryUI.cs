using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{ 
    public Text SizeText;
    public InventorySlotUI SlotPrefab;
    public GameObject ContentsObject;
    
    private InventorySlotUI[] _slots;
    private void Awake() {
        GameManager.Instance.Inventory.OnInitEvent += Init;
        GameManager.Instance.Inventory.OnChangeEvent += ChangeSlot;
    }
    public void Init(InventoryData inventory) {
        //if(_slots != null && _slots.Length > 0) return;
        
        int slotSize = inventory.MaxSize;
        int slotDataSize = inventory.Slots.Count;

        _slots = new InventorySlotUI[slotSize];

        for(int i = 0; i < slotSize; i++) {
            InventorySlotUI newSlot = Instantiate(SlotPrefab, ContentsObject.transform);

            if(i < slotDataSize) {
                InventorySlot slotData = inventory.Slots[i];

                newSlot.ItemId = slotData.Item.Id;
                newSlot.ItemImage.sprite = slotData.Item.Icon;
                if(slotData.Item.CanStack) {
                    newSlot.CountText.text = inventory.Slots[i].Count.ToString();
                }
            }

            _slots[i] = newSlot;
        }

        SizeText.text = $"{inventory.Slots.Count} / {inventory.MaxSize}";
    }

    public void ChangeSlot(InventoryData inventory, int index) {
        InventorySlotUI slotUI = _slots[index];
        InventorySlot slotData = (inventory.Slots.Count > index) ? inventory.Slots[index] : null;

        if(slotData == null || (slotUI.ItemId != 0 && slotData.Item.Id != slotUI.ItemId)) {
            slotUI.ItemId = 0;
            slotUI.ItemImage.sprite = null;
            slotUI.CountText.text = "";
        }
        else {
            slotUI.ItemId = slotData.Item.Id;
            slotUI.ItemImage.sprite = slotData.Item.Icon;
            if(slotData.Item.CanStack) {
                slotUI.CountText.text = slotData.Count.ToString();
            }
        }

        SizeText.text = $"{inventory.Slots.Count} / {inventory.MaxSize}";
    }
}
