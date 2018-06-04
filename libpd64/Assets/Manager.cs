using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; //Need this for calling UI scripts
using Magicolo;

public class Manager : MonoBehaviour {
    [SerializeField]
    Transform UIPanel; //Will assign our panel to this variable so we can enable/disable it

    [SerializeField]
    InputField durationField, attackField, desvolField, pitchField, chirpField, lfndepthField, lfnfreqField,
    amdepthField, amfreqField, richnessField;

    float pointer, duration, attack, desvol, pitch, chirp, lfndepth, lfnfreq,
    amdepth, amfreq, richness;

    void Start () {
        // Opening the patch will connect it up to the DSP
        PureData.OpenPatch("abstract");

        //initialize parameters
        pointer = 1.0f;
        duration = float.Parse(durationField.text);
        attack = float.Parse(attackField.text);
        desvol = float.Parse(desvolField.text);
        pitch = float.Parse(pitchField.text);
        chirp = float.Parse(chirpField.text);
        lfndepth = float.Parse(lfndepthField.text);
        lfnfreq = float.Parse(lfnfreqField.text);
        amdepth = float.Parse(amdepthField.text);
        amfreq = float.Parse(amfreqField.text);
        richness = float.Parse(richnessField.text);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void changeValue()
    {
        duration = float.Parse(durationField.text);
        attack = float.Parse(attackField.text);
        desvol = float.Parse(desvolField.text);
        pitch = float.Parse(pitchField.text);
        chirp = float.Parse(chirpField.text);
        lfndepth = float.Parse(lfndepthField.text);
        lfnfreq = float.Parse(lfnfreqField.text);
        amdepth = float.Parse(amdepthField.text);
        amfreq = float.Parse(amfreqField.text);
        richness = float.Parse(richnessField.text);

        Debug.Log(richness);
        Debug.Log(amfreq);
        Debug.Log(amdepth);
        Debug.Log(lfnfreq);
        Debug.Log(lfndepth);

        
        PureData.SendMessage("#touch", "abstract", pointer, duration, attack, desvol, pitch, chirp, lfndepth, lfnfreq, amdepth, amfreq, richness);
    }

    public void sendMessage()
    {
        PureData.SendMessage("#touch", "aTrigger", "bang");
    }
}
