using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class VoiceRecognitionScript : MonoBehaviour
{
    private DictationRecognizer dictationRecognizer;
    public string[] keywords = new string[] { "fire", "ice", "confuse", "shield" };

    void Start()
    {
        dictationRecognizer = new DictationRecognizer();
        dictationRecognizer.DictationHypothesis += (text) =>
        {
            UIScript.hypothesis = text;
        };
        dictationRecognizer.Start();
    }


    void Update ()
    {
        if(UIScript.hypothesis != null)
        {
            foreach (string i in keywords)
            {
                if (i == UIScript.hypothesis)
                {
                    UIScript.spell = i;
                }
            }
        }
  
    }
}
