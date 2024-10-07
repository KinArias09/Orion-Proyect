using UnityEngine;
using TMPro;  

public class ItemInfoDisplay : MonoBehaviour
{
    public TMP_Text itemNameText;  
    public TMP_Text itemDescriptionText;  

    public void UpdateItemInfo(string itemName, string itemDescription)
    {
        itemNameText.text = itemName;
        itemDescriptionText.text = itemDescription;
    }
}
