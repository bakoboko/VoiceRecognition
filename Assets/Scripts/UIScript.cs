using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {
    public static string spell;
    public static string hypothesis;

    private Text spellTextBox;
    private Text hypothesisTextBox;

	void Start ()
    {
        spellTextBox = GameObject.FindGameObjectWithTag("Spell").GetComponent<Text>();
        hypothesisTextBox = GameObject.FindGameObjectWithTag("Hypothesis").GetComponent<Text>();
	}
	
	void Update ()
    {
        spellTextBox.GetComponent<Text>().text = spell;
        hypothesisTextBox.GetComponent<Text>().text = hypothesis;
    }
}
