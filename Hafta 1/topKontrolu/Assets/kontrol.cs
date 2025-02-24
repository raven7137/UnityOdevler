using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float speed = 5f; 
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); 
        float moveVertical = Input.GetAxis("Vertical"); 

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical) * speed;

        rb.AddForce(movement, ForceMode.Acceleration); 
    }
}