using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlotUI : MonoBehaviour
{
    public int ItemId;
    public Image ItemImage;
    public Text CountText;
    public Text EquipText;
    public Button ImageButton;

    private void Awake() {
        ImageButton = GetComponent<Button>();

        //TODO: 플레이어 장비 정보에 등록 및 아이템 데이터에 Equip 저장 후 view로 받아오기
        ImageButton.onClick.AddListener(() => {
            if(ItemId != 0 && CountText.text == "") {
                if(EquipText.gameObject.activeSelf) {
                    EquipText.gameObject.SetActive(false);
                }
                else {
                    EquipText.gameObject.SetActive(true);
                }
            }
            
        });
    }
}
