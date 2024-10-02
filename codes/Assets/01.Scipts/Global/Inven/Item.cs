using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  <#아이템클래스>
/// </summary>
public enum ItemType
{
    Equip,
    Use,
    Consumeable,
    ETC
}

[System.Serializable]
public class Item
{
    public int ItemID;
    public ItemType m_ItType;
    public string ItemName;
    public Sprite ItemImg;
    public int Price;
    public float DamageModifier;

    public bool Use()
    {
        if (ItemID == 4)
        {
            return true;
        }
        return false;
    }

    public bool Equip()
    {
        if (ItemID == 5)
        {
            Debug.Log("아이템 ID가 5인 경우 장착할 수 없습니다.");
            return false;
        }
        else if (ItemID == 6)
        {
            // 아이템 ID가 6인 경우 HP를 서서히 회복합니다.
            Game_Mgr.Inst.StartRecoverHP(); // HP 회복 시작
        }
        return true;
    }
}
