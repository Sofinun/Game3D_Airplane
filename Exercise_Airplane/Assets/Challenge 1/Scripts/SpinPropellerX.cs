using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float HorizontalInput;
    void Start()
    {
        
    }


    void Update()
    {
         // get the user's vertical input
        HorizontalInput = Input.GetAxis("Horizontal");


        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //direction of the plane
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.up * rotationSpeed * HorizontalInput * Time.deltaTime);
    }
}
