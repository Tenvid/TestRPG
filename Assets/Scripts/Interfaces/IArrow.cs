using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IArrow
{
    public void Move(float direction, ref int index);
}
