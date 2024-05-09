using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AdioManager : MonoBehaviour
{
    [SerializeField] 
    private AudioMixer _audioMixer;

    [SerializeField] 
    private Slider _slider;

    private const float MULTIPLE = 20f;

    private void Start()
    {
        UpdateMusicVolume();
    }

    public void UpdateMusicVolume()
    {
        _audioMixer.SetFloat("music", Mathf.Log10(_slider.value) * MULTIPLE);
    }

}
