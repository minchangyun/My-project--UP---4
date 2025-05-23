using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



//아이템을 슬롯에 반영해준다?


public class ItemSlot : MonoBehaviour
{
    public Image Icon;
    public Text CountText;
    public Text ItemName;

    private ItemData itemData;
    private int itemCount = 1;

    private void UPdateUI()
    {
        if(itemData != null)
        {
            Icon.sprite = itemData.Icon;
            ItemName.text = itemData.ItemName;
            

            if(itemCount > 1)
            {
                CountText.text = itemCount.ToString();
            }
            else
            {
                CountText.text = "";
            }
        }
        else
        {
            Icon.sprite = null;
            CountText.text = "";
        }

    }

    public void SetUp(ItemData setItemData)
    {
        itemData = setItemData;
        UPdateUI();
    }

    public void AddCount(int amount)
    {
        itemCount -= amount;
        UPdateUI();
    }

    public bool HasItem(ItemData checkItem)
    {
        return itemData == checkItem;
    }

    public void OnClickItem()
    {
        if (itemData == null || itemCount <= 0)
        {
            return;
        }

        itemCount--;
        UPdateUI();

        if(itemCount <= 0)
        { 
            Destroy(this.gameObject);
        }
    }



}
