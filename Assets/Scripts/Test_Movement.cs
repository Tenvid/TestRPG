using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Test_Movement : MonoBehaviour
{
    // Player Parameters
    public int velocity;
    
    private Vector2 _moves;


    // Start is called before the first frame update

    public void OnMove(InputAction.CallbackContext context)
    {
        _moves = context.ReadValue<Vector2>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( new Vector3(_moves.x, _moves.y, 0)* Time.deltaTime * velocity);
    }
}
