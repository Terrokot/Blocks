using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // Start is called before the first frame update
    public Rigidbody rb;
    void Start() {
        Debug.Log("Hello World");

       // rb.AddForce(0, 200, 500);
    }

    // Update is called once per frame
    void FixedUpdate() {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
