using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHandler : MonoBehaviour, IPointerClickHandler
{
    public GameObject prefabPieza;
public Transform
CubeSatTransform;

public void
OnPointerClick(PointerEventData
eventData)
{

Vector3 spawnPosition=
CubeSatTransform.position;
Instantiate(prefabPieza, spawnPosition, Quaternion.identity);
   }
}
