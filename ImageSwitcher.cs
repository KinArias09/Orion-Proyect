using UnityEngine;
using UnityEngine.UI;

public class ImageSwitcher : MonoBehaviour
{
    public Image displayImage; 
    public Sprite[] satelliteImages; 
    private int currentIndex = 0;

    void Start()
    {
        if (satelliteImages.Length > 0)
        {
            displayImage.sprite = satelliteImages[currentIndex]; 
        }
    }

    
    public void NextImage()
    {
        if (satelliteImages.Length == 0) return;

        currentIndex = (currentIndex + 1) % satelliteImages.Length;
        displayImage.sprite = satelliteImages[currentIndex];
    }

    
    public void PreviousImage()
    {
        if (satelliteImages.Length == 0) return;

        currentIndex--;
        if (currentIndex < 0)
        {
            currentIndex = satelliteImages.Length - 1;
        }
        displayImage.sprite = satelliteImages[currentIndex];
    }
}
