using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTeleporter : MonoBehaviour
{
    [SerializeField]
    private string sceneName;
    [SerializeField]
    private string sceneTeleporterDestinationName;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadSceneAsync(sceneName);
            StartCoroutine(setNewActiveScene());
            
        }
    }
    IEnumerator setNewActiveScene()
    {
        Scene nextScene = SceneManager.GetSceneByName(sceneName);
        Debug.Log(sceneName);
        FindObjectOfType<TeleportScenePlayer>().nextTeleportPosition = sceneTeleporterDestinationName;
        CanvasControl.StartSceneTransition();
        yield return new WaitForSeconds(0.3f);
        SceneManager.SetActiveScene(nextScene);
    }
    
}
