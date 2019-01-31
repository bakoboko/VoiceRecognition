using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class VoiceRecognitionScript : MonoBehaviour
{
    public string[] keywords = new string[] { "fire", "ice", "confuse", "shield" };
    public ConfidenceLevel confidence;

    protected PhraseRecognizer recognizer;

	private void Start ()
    {
		if(keywords != null)
        {
            recognizer = new KeywordRecognizer(keywords, confidence);
            recognizer.OnPhraseRecognized += Recognizer_OnPhraseRecognized;
            recognizer.Start();
        }
	}

    private void Recognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        UIScript.spell = args.text;
        
    }
	

	void Update ()
    {
		
	}
}
