using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Item", menuName = " Inventory/Item")] // this is used to create asset file, its name and function
public class Items : ScriptableObject {

    new  public string name = "New Item";
    public Sprite icon = null;
    public bool isDefaultItem = false;


}
