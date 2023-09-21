using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public event Action<InventoryData, int> OnChangeEvent;
    public event Action<InventoryData> OnInitEvent;
    private InventoryData _playerInventory;

    public void Init() {
        _playerInventory = new InventoryData();

        // TODO: SO화하여 몬스터 인벤토리 등에도 사용하도록 하기
        _playerInventory.MaxSize = 20;
        _playerInventory.Slots = new List<InventorySlot>();

        CallInitEvent(_playerInventory);
    }

    // TODO: 수량 선택해서 여러개 한 번에 Add, Sub 할 수 있게
    public bool AddItem(ItemData item) {
        int count = _playerInventory.Slots.Count;
        int index = -1;

        // 스택이 가능하다면 같은 ID의 아이템이 있는 슬롯 찾기
        if(item.CanStack) {
            for(index = 0; index < count; index++) {
                if(item.Id == _playerInventory.Slots[index].Item.Id) {
                    // TODO: 맥스 카운트 체크하기
                    _playerInventory.Slots[index].Count++;
                    CallChangeEvent(_playerInventory, index);
                    return true;
                }
            }
        }

        // 없거나 스택이 불가능하다면 추가하기
        if(count < _playerInventory.MaxSize) {
            InventorySlot newSlot = new InventorySlot();
            newSlot.Item = item;
            if(item.CanStack) {
                newSlot.Count = 1;
            }
            _playerInventory.Slots.Add(newSlot);
            CallChangeEvent(_playerInventory, count);

            return true;
        }
        
        // 여기까지 왔다면 인벤토리가 꽉 찬 것.
        // TODO: 팝업 메시지
        return false;
    }

    public bool SubItem(ItemData item) {
        int count = _playerInventory.Slots.Count;

        for(int i = 0; i < count; i++) {
            if(item.Id == _playerInventory.Slots[i].Item.Id) {
                // XXX: 이대로면 굳이 CanStack 안 보고 Count <= 0으로 해도 될 듯?
                // 스택이 없거나 마지막 개수라면
                if(!item.CanStack || --_playerInventory.Slots[i].Count == 0) {
                    _playerInventory.Slots.RemoveAt(i);
                }
                
                CallChangeEvent(_playerInventory, i);
                return true;
            }
        }
        
        // 여기까지 왔다면 인벤토리가 꽉 찬 것.
        // TODO: 팝업 메시지
        return false;
    }

    public void CallInitEvent(InventoryData inventory) {
        OnInitEvent?.Invoke(inventory);
    }

    public void CallChangeEvent(InventoryData inventory, int index) {
        OnChangeEvent?.Invoke(inventory, index);
    }
}
