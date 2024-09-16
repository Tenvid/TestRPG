using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TeleportScenePlayer : MonoBehaviour
{
    public string nextTeleportPosition;
    private void OnLevelWasLoaded(int level)
    {
        if (nextTeleportPosition != "")
        {
            Vector3 teleportPosition = GameObject.Find(nextTeleportPosition).transform.position;
            gameObject.transform.position = teleportPosition;
            CanvasControl.EndSceneTransition();
        }
    }
    private void Awake()
    {
        TeleportScenePlayer[] teleportScenePlayers = FindObjectsOfType<TeleportScenePlayer>();
        if (teleportScenePlayers.Length > 1)
            Destroy(gameObject);


        DontDestroyOnLoad(gameObject);
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
