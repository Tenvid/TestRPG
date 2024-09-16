using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayer : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;
    [SerializeField]
    private Vector3 _playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.Game_Was_Loaded == false)
        {
            Instantiate(_player, _playerPosition, Quaternion.identity);
            GameManager.Game_Was_Loaded = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
