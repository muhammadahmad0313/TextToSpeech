using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _Text : MonoBehaviour
{
    [SerializeField] private Text _text = null;
   
   public void play() {
    // TextToSpeech.instance.SpeakText(_text);
    TextToSpeech.instance.SpeakText(_text.text);
}
}
