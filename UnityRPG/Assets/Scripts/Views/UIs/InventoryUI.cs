using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public InventoryController InventoryController;  
    public Text SizeText;
    public InventorySlotUI SlotPrefab;
    public GameObject ContentsObject;
    
    private InventorySlotUI[] _slots;
    private void Awake() {
        InventoryController.OnInitEvent += Init;
        InventoryController.OnChangeEvent += ChangeSlot;

        // TODO: 호출 시점이 이상해서 일단 여기에 만들어뒀는데..
        // 활성화된 다음 Awake가 발생하는데 활성화로 해놨다가 Awake에서 비활성화를 해줘야 하나? => 캔버스, Panel
        InventoryController.Init();
    }
    public void Init(InventoryData inventory) {
        if(_slots.Length > 0) return;
        
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

        if(slotData == null) {
            slotUI.ItemImage.sprite = null;
            slotUI.CountText.text = "";
        }
        else {
            slotUI.ItemImage.sprite = slotData.Item.Icon;
            if(slotData.Item.CanStack) {
                slotUI.CountText.text = slotData.Count.ToString();
            }
        }

        SizeText.text = $"{inventory.Slots.Count} / {inventory.MaxSize}";
    }
}
