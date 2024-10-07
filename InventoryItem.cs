using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryItem : MonoBehaviour, IPointerDownHandler
{
    public GameObject object3D;  
    public string itemName;  
    public string itemDescription;  

    public ItemInfoDisplay itemInfoDisplay;  

    public void OnPointerDown(PointerEventData eventData)
    {
        
        if (object3D.activeSelf)
        {
            object3D.SetActive(false);  
            itemInfoDisplay.UpdateItemInfo("", "");  
        }
        else
        {
            
            object3D.SetActive(true);  
            itemInfoDisplay.UpdateItemInfo(itemName, itemDescription);  
        }
    }
}
