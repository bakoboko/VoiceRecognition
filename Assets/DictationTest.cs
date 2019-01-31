using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

public class DictationTest : MonoBehaviour
{
    [SerializeField]
    private Text spokenWord;

    private DictationRecognizer dictationRecognizer;

    void Start()
    {
        dictationRecognizer = new DictationRecognizer();

        dictationRecognizer.DictationHypothesis += (text) =>
        {
           
            UIScript.hypothesis = text;
        };
    
        dictationRecognizer.Start();
    }
}