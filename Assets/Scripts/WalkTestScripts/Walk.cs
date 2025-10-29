using UnityEngine;

public class Walk : MonoBehaviour
{

    public float movementSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        movement.x = Input.GetAxis
    }
}
