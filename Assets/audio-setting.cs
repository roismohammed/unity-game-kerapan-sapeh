using UnityEngine;
using UnityEngine.UI;

public class AudioSetting : MonoBehaviour
{
    public Slider musicSlider;
    public AudioSource musicAudio;

    void Start()
    {
        musicSlider.value = musicAudio.volume;

        musicSlider.onValueChanged.AddListener(ChangeVolume);
    }

    void ChangeVolume(float value)
    {
        musicAudio.volume = value;
    }
}