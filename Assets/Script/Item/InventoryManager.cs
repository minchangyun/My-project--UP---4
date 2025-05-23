using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    public Transform ItemSlotParent;
    public GameObject ItemSlotPrefab;
    public GameObject InventoryPannel;

    private bool inventoryOpen = false;
    private List<ItemSlot> slots = new List<ItemSlot>();



    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this.gameObject);
    }




    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Tab))
        {
            inventoryOpen = !inventoryOpen;
            InventoryPannel.SetActive(inventoryOpen);
        }
    }

    public void AddItem(ItemData newItem)
    {
        //동일한 아이템이 있는지 없는지 확인
        ItemSlot exitsSlot = null;

        for (int i = 0; i < slots.Count; i++)
        {
            if (slots[i] != null && slots[i].HasItem(newItem))
            {
                exitsSlot = slots[i];
                break;
            }
        }

        if(exitsSlot != null)
        {
            exitsSlot.AddCount(1);
        }
        else
        {
            GameObject newSlot = Instantiate(ItemSlotPrefab, ItemSlotParent);

            ItemSlot itemSlot = newSlot.GetComponent<ItemSlot>();
            itemSlot.SetUp(newItem);
            slots.Add(itemSlot);
        }





    }










}
