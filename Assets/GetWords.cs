using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

public class GetWords : MonoBehaviour
{
    public Transform contentWindow;
    public GameObject recallTextObject;

    // Start is called before the first frame update
    void Start()
    {
        string readFromFilePath = "./Assets/" + "NineLetterWordsList" + ".txt";

        List<string> fileLines = File.ReadAllLines (readFromFilePath).ToList();

        foreach(string line in fileLines)
        {
            Instantiate(recallTextObject, contentWindow);
            recallTextObject.GetComponent<Text>().text += '\n' + line;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
