using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; 
    public float rotationSpeed = 50f;
    public float minDistance = 5f; 
    public float maxDistance = 20f; 
    public float zoomSpeed = 10f; 
    private float currentDistance;

    void Start()
    {
        currentDistance = Vector3.Distance(transform.position, target.position); 
    }

    void Update()
    {
        
        if (Input.GetMouseButton(1))
        {
            float horizontalRotation = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            transform.RotateAround(target.position, Vector3.up, horizontalRotation);

            float verticalRotation = -Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
            transform.RotateAround(target.position, transform.right, verticalRotation);
        }

       
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");
        if (scrollInput != 0)
        {
            
            currentDistance -= scrollInput * zoomSpeed;
            currentDistance = Mathf.Clamp(currentDistance, minDistance, maxDistance); 

            
            Vector3 direction = (transform.position - target.position).normalized;
            transform.position = target.position + direction * currentDistance;
        }

        
        transform.LookAt(target);
    }
}
