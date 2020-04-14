using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody2D pl;
    private Vector2 moveVelocity;
    // Start is called before the first frame update
    void Start()
    {
        pl = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
    }
 void FixedUpdate(){
    pl.MovePosition(pl.position + moveVelocity * Time.fixedDeltaTime);
}

}
