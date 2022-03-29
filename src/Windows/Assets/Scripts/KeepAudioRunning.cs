using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepAudioRunning : MonoBehaviour
{
    static bool running = false;
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        if (transform.gameObject == true && running == true)
        {
            Destroy(transform.gameObject);
            running = false;
        }
        running = true;
    }
}
