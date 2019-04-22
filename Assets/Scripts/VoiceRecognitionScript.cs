using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Windows.Speech;
using UnityEngine.UI;
using System.IO;

public class VoiceRecognitionScript : MonoBehaviour
{
    private DictationRecognizer dictationRecognizer;
    public string[] keywords = new string[] { "fire", "ice", "confuse", "shield" };
    private string heldString;
    public TextAsset asset;
    public Button button;

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
        if (UIScript.hypothesis != null)
        {
            foreach (string i in keywords)
            {
                if (i == UIScript.hypothesis)
                {
                    UIScript.spell = i;
                }
            }

            if (Input.GetKeyDown(KeyCode.Space))
                WriteString();

            if(UIScript.hypothesis != heldString)
                button.GetComponent<Image>().color = Color.red;
        }

        
    }

 
    void WriteString()
    {
        heldString = UIScript.hypothesis;

        button.GetComponent<Image>().color = Color.green;
        string path = "Assets/ListOfWords.txt";

        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(heldString);
        writer.Close();

    }
}
