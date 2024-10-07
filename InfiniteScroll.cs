using UnityEngine;
using UnityEngine.UI;

public class InfiniteScroll : MonoBehaviour
{
    public RectTransform content;  
    public float itemWidth;        
    public int itemCount;          

    private Vector2 originalPosition;
    private float totalWidth;

    void Start()
    {
        originalPosition = content.anchoredPosition;
        totalWidth = itemWidth * itemCount;
    }

    void Update()
    {
        Vector2 currentPosition = content.anchoredPosition;

        
        if (currentPosition.x > originalPosition.x + totalWidth)
        {
            currentPosition.x = originalPosition.x;
        }
        
        else if (currentPosition.x < originalPosition.x - totalWidth)
        {
            currentPosition.x = originalPosition.x;
        }

        content.anchoredPosition = currentPosition;
    }
}
