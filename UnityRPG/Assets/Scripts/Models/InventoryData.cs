using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot
{
    public ItemData Item;
    public int Count;
}
public class InventoryData
{
    public int Id;
    // 인벤토리 최대 크기: 인벤토리 오른쪽 위에 0 / 60 이런식으로 표기
    public int MaxSize;
    public List<InventorySlot> Slots = new List<InventorySlot>();
}
