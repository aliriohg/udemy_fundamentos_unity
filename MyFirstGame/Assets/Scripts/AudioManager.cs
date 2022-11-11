using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager Instance
    {
        get;private set;
    }

    public AudioSource musicPlayer, soundPlayer;

    public AudioClip[] availableSoudClips;
    private Dictionary<string, AudioClip> loadedAudioClips;
    void Awake()
    {
    Instance = this;
    }

    // Update is called once per frame
    void Start()
    {
        loadedAudioClips = new Dictionary<string, AudioClip>();
        foreach (AudioClip audio in availableSoudClips)
        {
            loadedAudioClips.Add(audio.name, audio);
        }
        musicPlayer.Play();
    }

    public void PlaySound(string name)
    {
        soundPlayer.clip = loadedAudioClips[name];
        soundPlayer.Play();
    }

    public void StopMusic()
    {
        musicPlayer.Stop();
    }
}
