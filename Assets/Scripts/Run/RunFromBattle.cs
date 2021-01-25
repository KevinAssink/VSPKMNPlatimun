using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunFromBattle : MonoBehaviour
{

    [SerializeField] private Text _RunText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetText(string text)
    {
        _RunText.text = text;
    }
}
