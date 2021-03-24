using UnityEngine;
using System.Collections;

public class Settings
{
    private AudioSource m_MusicSource;
    private AudioSource m_SoundSource;

    public float SoundVolumeSet
    {
        get { return m_SoundSource.volume; }
        set { m_SoundSource.volume = value; }
    }

    public float MusicVolumeSet
    {
        get { return m_MusicSource.volume; }
        set { m_MusicSource.volume = value; }
    }

    public int HighScoreSet { get; set; }

    public void Load(AudioSource muzyka, AudioSource dzwiek)
    {
        m_MusicSource = muzyka;
        m_SoundSource = dzwiek;

        SoundVolumeSet = PlayerPrefs.GetFloat("SoundVolumeSet", 1.0f);
        MusicVolumeSet = PlayerPrefs.GetFloat("MusicVolumeSet", 0.5f);
        HighScoreSet = PlayerPrefs.GetInt("HighScoreSet", 0);
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("SoundVolumeSet", SoundVolumeSet);
        PlayerPrefs.SetFloat("MusicVolumeSet", MusicVolumeSet);
        PlayerPrefs.SetInt("HighScoreSet", HighScoreSet);
    }
}
