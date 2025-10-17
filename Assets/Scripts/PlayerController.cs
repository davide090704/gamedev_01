using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float horizontalInput;
    public float verticalInput;
    public float turnSpeed = 45.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        // Move the vehicle forward
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
      

    }
}
;