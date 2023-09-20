using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] private GameObject _content;
    [SerializeField] private Text _size;
    [SerializeField] private GameObject _newItem;
    private InventoryData _data;

    private void LateUpdate() {
        _size.text = $"{_data.Items.Count} / {_data.MaxSize}";
    }
}
