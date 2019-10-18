using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera camera = GetComponentInChildren<Camera>();
        float speed = 5.0f;
        float mouseX = Input.GetAxis("Mouse X") * speed;
        float mouseY = Input.GetAxis("Mouse Y") * speed;
        transform.localRotation = Quaternion.Euler(0, mouseX, 0) * transform.localRotation;
        camera.transform.localRotation = Quaternion.Euler(mouseY, 0, 0) * camera.transform.localRotation;
    }
}
