using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBattleOption : MonoBehaviour, IArrow
{
    public void Move(float direction, ref int index)
    {
        if (direction < 0)
        {
            if (index < Constants.CombatOptions - 1)
            {
                GetComponent<RectTransform>().localPosition = Constants.ArrowPositions[++index];
            }
        }
        else if (direction > 0)
        {
            if (index <= 0)
                return;

            GetComponent<RectTransform>().localPosition = Constants.ArrowPositions[--index];
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
