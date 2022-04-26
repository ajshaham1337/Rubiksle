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
    public Dictionary<string, string> cubeWordsDictionary;

    // Start is called before the first frame update
    void Start()
    {
        automate = FindObjectOfType<Automate>();
        // cubeMap = FindObjectOfType<CubeMap>();

        data = dataFile.text.Split('\n');
        sixWordsListForCube = new string[6] { "", "", "", "", "", "" };
        cubeWordsDictionary = new Dictionary<string, string>();
    }

    public void RandomizeCubeWords()
    {
        int dataLength = data.Length - 1;

        for (int i = 0; i < 6; i++)
        {
            sixWordsListForCube[i] = data[Random.Range(0, dataLength)];
        }

        cubeWordsDictionary.Add("F", sixWordsListForCube[0]);
        cubeWordsDictionary.Add("B", sixWordsListForCube[1]);
        cubeWordsDictionary.Add("U", sixWordsListForCube[2]);
        cubeWordsDictionary.Add("D", sixWordsListForCube[3]);
        cubeWordsDictionary.Add("L", sixWordsListForCube[4]);
        cubeWordsDictionary.Add("R", sixWordsListForCube[5]);

        LoadLettersOntoCube();
    }

    public void LoadLettersOntoCube()
    {
        
    }

    public void StartGame()
    {
        // RandomizeCubeWords();
        automate.Shuffle();
    }
}
