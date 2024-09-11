using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Test_Movement : MonoBehaviour
{
    // Player Parameters
    [SerializeField]
    private int velocity;


    private Vector2 _moves;
    private Rigidbody2D _rb;

    // Start is called before the first frame update

    public void OnMove(InputAction.CallbackContext context)
    {
        _moves = context.ReadValue<Vector2>();
    }
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( new Vector3(_moves.x, _moves.y, 0)* Time.deltaTime * velocity);
    }
}
