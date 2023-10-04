using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum VillagerType
{
    Normal = 0,
    Pescador = 1,
    Herrero = 2
}

public class VillagerBaase : MonoBehaviour
{
    public string Name = "Villager";
    public int health = 100;
    public VillagerType type = VillagerType.Normal;
    public Sprite skin;
    public Item selectedItem;
    public List<Item> inventory;
    public List<Item> tradeItems;

    //private void Start()
    //{
    //    Item RawMeat = new Item("Raw Meat");
    //    AddItemToInventory(RawMeat);
    //    Debug.Log("Item name: " + inventory[0].Name);
    //}
    public VillagerBaase()
    {
    }

    public VillagerBaase(string _name, int _health, VillagerType _type, Sprite _skin)
    {
        Name = _name;
        health = _health;
        type = _type;
        skin = _skin;

        CreateInventory();
        createItemsToTrade();
    }
    public virtual void setName(string _name)
    {
        Name = _name;
    }

    public virtual void setHealth(int _health)
    {
        health = _health;
    }

    public virtual void setType(VillagerType _type)
    {
        type = _type;
    }

    public virtual void setSkin(Sprite _skin)
    {
        skin = _skin;
    }

    public virtual void setSelectedItem(Item _item)
    {
        selectedItem = _item;
    }
   
    public virtual void CreateInventory()
    {
        inventory = new List<Item>();
    }
    public virtual void AddItemToInventory(Item _item)
    {
        inventory.Add(_item);
    }
    public virtual string getName()
    {
        return name;
    }
    public virtual VillagerType getType()
    {
        return type;
    }
    public virtual Item getSelectedItem()
    {
        return selectedItem;
    }
    public virtual Item getInventoryItem(int _index)
    {
        return inventory[_index];
    }
    public virtual void createItemsToTrade()
    {
        tradeItems = new List<Item>();
    }
    public virtual List<Item> getTradeItems()
    {
        return tradeItems;
    }
    public virtual Item Trade(Item trade)
    {
        return new Item();
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
