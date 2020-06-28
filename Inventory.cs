using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class Inventory : MonoBehaviour {

    #region Singleton
    public static Inventory instance;
    private void Awake()
    {
        instance = this;
        if ( instance != null)
        {
            Debug.LogWarning("  This is a warning ");
            return; 
        }
    }
    #endregion
    public delegate void  onItemChanged();
    public onItemChanged onItemChangedCallBack;

    public List<Items> Item = new List<Items>();
    public int space = 2;
     
    public bool Add (Items item)
    {
        if (!item.isDefaultItem)
        {
            if (Item.Count >= space)
            {
                Debug.Log("Space is full");
                return false;
            }

            if (onItemChangedCallBack != null )
            {
                onItemChangedCallBack.Invoke(); 
            }
          Item.Add(item);
        }
        return true;
    }

    public void Remove(Items item)
    {
      
            Item.Remove(item);
        
    }






}
