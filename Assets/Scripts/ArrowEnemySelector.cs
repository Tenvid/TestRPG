using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowEnemySelector : MonoBehaviour, IArrow
{
    //public void Move(GameObject enemy)
    //{
    //    transform.position = enemy.transform.position;
    //    transform.position -= new Vector3(1.5f, 0, 0);
    //}

    public void Move(float direction, ref int index)
    {
        if(direction > 0)
        {
            if (index < Test_Battle.Enemies.Length - 1)
            {
                transform.position = Test_Battle.Enemies[++index].gameObject.transform.position;
                transform.position -= new Vector3(1.5f, 0, 0); // TODO: Move Vector to constants
            }
        }
        else if (direction < 0)
        {
            if (index > 0)
            {
                transform.position = Test_Battle.Enemies[--index].gameObject.transform.position;
                transform.position -= new Vector3(1.5f, 0, 0); // TODO: Move Vector to constants
            }
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
