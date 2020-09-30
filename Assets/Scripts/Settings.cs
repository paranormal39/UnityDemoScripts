using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{

    public AudioSource ac;
    public Slider slider;
    Resolution[] resolutions;

    public Dropdown resloutionDropdown;
    int currentResolutionIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = ac.volume;
        
        resolutions = Screen.resolutions;
        resloutionDropdown.ClearOptions(); ;

        List<string> options = new List<string>();

        for (int i=0; i < resolutions.Length; i ++){
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);
            if(resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resloutionDropdown.AddOptions(options);
        resloutionDropdown.value = currentResolutionIndex;
        resloutionDropdown.RefreshShownValue();
    }

    // Update is called once per frame
    
    public void setVolume(float volume)
    {
        ac.volume = volume;
    }

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void SetFullScreen(bool isFullScreen)
    {
       Screen.fullScreen = isFullScreen;
    }
    public void SetResolution (int reslutionIndex)
    {
        Resolution resolution = resolutions[reslutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
