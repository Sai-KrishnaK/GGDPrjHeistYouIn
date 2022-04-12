using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{

    public static MusicControl instance;

    public bool playing;
    public AudioSource musicSource;
    public AudioClip[] musicClips;


        private void Awake ()
    {
        DontDestroyOnLoad(this.gameObject);

        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        playing = true;
        StartCoroutine(PlayMusicLoop());
    }

    IEnumerator PlayMusicLoop()
    {
        yield return null;

        while(playing)
        {
            for(int i=0; i<musicClips.Length; i++)
            {
                musicSource.clip = musicClips[i];

                musicSource.Play();
                while(musicSource.isPlaying)
                {
                    yield return null;
                }
            }
        }
    }
    
}
