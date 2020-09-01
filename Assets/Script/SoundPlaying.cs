using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class SoundPlaying : MonoBehaviour
{
    public AudioSource _audioSource;
    public AudioClip _audioClip;
    public bool _isFirst = true;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_isFirst == true)
        {
            _audioSource.PlayOneShot(_audioClip);
            _isFirst = false;
        }
    }
}
