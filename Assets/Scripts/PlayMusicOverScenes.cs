using UnityEngine;

public class PlayMusicOverScenes : MonoBehaviour
{

    static bool AudioBegin = false;

    void Awake()
    {
        if (!AudioBegin)
        {
            gameObject.GetComponent<AudioSource>().Play();
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
    }
}
