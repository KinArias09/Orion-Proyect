using UnityEngine;

public class CubeSatController : MonoBehaviour
{
    public Transform cubeSat;  
    public float rotationSpeed = 100f;  
    public float zoomSpeed = 10f;  
    public float minZoomDistance = 2f;  
    public float maxZoomDistance = 20f;  

    private Vector3 initialCubeSatPosition;  
    private Quaternion initialCubeSatRotation;  
    private Vector3 initialCameraPosition;  

    private float lastClickTime = 0f;  
    private float doubleClickDelay = 0.3f;  
    private bool rotating = false;  

    void Start()
    {
        
        initialCubeSatPosition = cubeSat.position;
        initialCubeSatRotation = cubeSat.rotation;
        initialCameraPosition = Camera.main.transform.position;
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(1)) 
        {
            if (Time.time - lastClickTime < doubleClickDelay) 
            {
                ResetCubeSat();  
                rotating = false; 
            }
            else
            {
                rotating = true; 
            }

            lastClickTime = Time.time;  
        }

        
        if (rotating && Input.GetMouseButton(1))
        {
            float rotationX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            float rotationY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

            
            cubeSat.Rotate(Vector3.up, -rotationX, Space.World);
            cubeSat.Rotate(Vector3.right, rotationY, Space.World);
        }

        
        if (Input.GetMouseButtonUp(1))
        {
            rotating = false;  
        }

        
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");
        if (scrollInput != 0f)
        {
            Vector3 direction = Camera.main.transform.forward;
            float distance = Vector3.Distance(Camera.main.transform.position, cubeSat.position);

            if (distance > minZoomDistance && distance < maxZoomDistance)
            {
                Camera.main.transform.position += direction * scrollInput * zoomSpeed;
            }
            else if (distance <= minZoomDistance && scrollInput < 0f)
            {
                Camera.main.transform.position += direction * scrollInput * zoomSpeed;
            }
            else if (distance >= maxZoomDistance && scrollInput > 0f)
            {
                Camera.main.transform.position += direction * scrollInput * zoomSpeed;
            }
        }
    }

    
    void ResetCubeSat()
    {
        cubeSat.position = initialCubeSatPosition;
        cubeSat.rotation = initialCubeSatRotation;
        Camera.main.transform.position = initialCameraPosition;
    }
}
