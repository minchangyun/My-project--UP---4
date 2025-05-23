using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Item", menuName = "Inventory/Item")]




public class ItemData : ScriptableObject
{
    

    public string ItemName;
    public string ItemDescription;
    public Sprite Icon;

}
