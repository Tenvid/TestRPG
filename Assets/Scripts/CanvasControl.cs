using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasControl : MonoBehaviour
{
    static private Animator animator;
    private void Awake()
    {
        CanvasControl[] canvasControls = FindObjectsOfType<CanvasControl>();
        if (canvasControls.Length > 1)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public static void StartSceneTransition()
    {
        animator.Play("SceneTransitionStart");
    }
    public static void EndSceneTransition() 
    {
        animator.Play("SceneTransitionEnd");
    }
}
