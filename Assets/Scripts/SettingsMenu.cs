using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Collections;
using System.Collections.Generic;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider volumeSlider;
    public Slider brightnessSlider;
    public Slider mouseSensitivitySlider;

    private void Start()
    {
        // Load the saved settings
        LoadSettings();
    }
    public void SetVolume(float volume)
    {
        // Set the volume level of the AudioMixer
        audioMixer.SetFloat("Volume", Mathf.Log10(volume) * 20);
    }

    public void SaveSettings()
    {
        // Save the current settings to PlayerPrefs
        PlayerPrefs.SetFloat("VolumeLevel", volumeSlider.value);
        PlayerPrefs.SetFloat("BrightnessLevel", brightnessSlider.value);
        PlayerPrefs.SetFloat("MouseSensitivity", mouseSensitivitySlider.value);
    }

    public void LoadSettings()
    {
        // Load the saved settings from PlayerPrefs
        volumeSlider.value = PlayerPrefs.GetFloat("VolumeLevel", 0.5f);
        brightnessSlider.value = PlayerPrefs.GetFloat("BrightnessLevel", 0.5f);
        mouseSensitivitySlider.value = PlayerPrefs.GetFloat("MouseSensitivity", 10f);
    }

    public void ResetSettings()
    {
        // Reset the settings to default values
        volumeSlider.value = 0.5f;
        brightnessSlider.value = 0.5f;
        mouseSensitivitySlider.value = 10f;

        // Save the reset settings
        SaveSettings();
    }
}

