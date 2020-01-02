using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    #region SINGLETON
    private static SoundManager instance = null;
    public static SoundManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = (SoundManager)FindObjectOfType(typeof(SoundManager));
            }
            return instance;
        }
    }
    #endregion

    private AudioSource audioSource = null;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        MainPanelController.Instance.ChangeSoundButtonText(audioSource.isPlaying);

        if (audioSource.isPlaying)
            audioSource.Stop();
        else
            audioSource.Play();
    }
}
