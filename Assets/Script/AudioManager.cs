using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioSource glass;
    public AudioSource sound;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }
    public void PlaySound(AudioSource Sound)
    {
        Sound.Stop();
        Sound.Play();
    }    

    public void PlayModifiedSound(AudioSource Sound)
    {
        Sound.pitch = Random.Range(0.7f, 1.3f);
        Sound.Stop();
        Sound.Play();
    }
}
