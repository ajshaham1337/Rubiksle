using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefineWords : MonoBehaviour
{
    Automate automate;
    // CubeMap cubeMap;

    public TextAsset dataFile;
    public string[] data;
    public string[] sixWordsListForCube;
    Dictionary<string, string> CubeWordsDictionary = new Dictionary<string, string>();

    // Start is called before the first frame update
    void Start()
    {
        automate = FindObjectOfType<Automate>();
        // cubeMap = FindObjectOfType<CubeMap>();

        data = dataFile.text.Split('\n');
        sixWordsListForCube = new string[6] { "", "", "", "", "", "" };
    }

    public void RandomizeCubeWords()
    {
        int dataLength = data.Length - 1;

        for (int i = 0; i < 6; i++)
        {
            sixWordsListForCube[i] = data[Random.Range(0, dataLength)];
        }

        CubeWordsDictionary.Add("F", sixWordsListForCube[0]);
        CubeWordsDictionary.Add("B", sixWordsListForCube[1]);
        CubeWordsDictionary.Add("U", sixWordsListForCube[2]);
        CubeWordsDictionary.Add("D", sixWordsListForCube[3]);
        CubeWordsDictionary.Add("L", sixWordsListForCube[4]);
        CubeWordsDictionary.Add("R", sixWordsListForCube[5]);

        // Debug.Log(CubeWordsDictionary);
    }

    public void StartGame()
    {
        // RandomizeCubeWords();
        automate.Shuffle();
    }
}
