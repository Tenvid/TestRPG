using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Test_Battle : MonoBehaviour
{
    private int _index = 0;
    [SerializeField] GameObject _arrow;
    public void OnMoveUI(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if(context.ReadValue<float>() < 0)
            {
                if(_index >= 3)
                    return;

                _arrow.GetComponent<RectTransform>().localPosition = Constants.ArrowPositions[++_index];
            }
            else if (context.ReadValue<float>() > 0)
            {
                if (_index <= 0)
                    return;

                _arrow.GetComponent<RectTransform>().localPosition = Constants.ArrowPositions[--_index];
            }

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(_arrow.transform.position);
        Debug.Log(_arrow.GetComponent<RectTransform>().localPosition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
