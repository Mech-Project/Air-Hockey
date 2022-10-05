using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector3(50, 0, 0);
        rb.useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
