using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

sealed class TextToSpeech : MonoBehaviour
{

    public static TextToSpeech instance { get; private set; }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

   public void SpeakText(string text) => ttsrust_say(text);
   public void SpeakText(Text text) => ttsrust_say(text.text);


    #if !UNITY_EDITOR && (UNITY_IOS || UNITY_WEBGL)
    const string _dll = "__Internal";
    #else
    const string _dll = "ttsrust";
    #endif

    [DllImport(_dll)] static extern void ttsrust_say(string text);
}
