using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CubeMap : MonoBehaviour
{
    CubeState cubeState;
    DefineWords defineWords;

    public Transform up;
    public Transform down;
    public Transform left;
    public Transform right;
    public Transform front;
    public Transform back;

    char[] wordArray0;
    char[] wordArray1;
    char[] wordArray2;
    char[] wordArray3;
    char[] wordArray4;
    char[] wordArray5;

    // Start is called before the first frame update
    void Start()
    {
        defineWords = FindObjectOfType<DefineWords>();
        defineWords.RandomizeCubeWords();

        wordArray0 = defineWords.sixWordsListForCube[0].ToCharArray();
        wordArray1 = defineWords.sixWordsListForCube[1].ToCharArray();
        wordArray2 = defineWords.sixWordsListForCube[2].ToCharArray();
        wordArray3 = defineWords.sixWordsListForCube[3].ToCharArray();
        wordArray4 = defineWords.sixWordsListForCube[4].ToCharArray();
        wordArray5 = defineWords.sixWordsListForCube[5].ToCharArray();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int NumberOfOccurencesInArr(char[] charArr, char c)
    {
        int n = 0;

        for (int i = 0; i < charArr.Length; i++)
        {
            if (charArr[i] == c)
            {
                n++;
            }
        }

        return n;
    }

    public void Set()
    {
        cubeState = FindObjectOfType<CubeState>();

        UpdateMap(cubeState.front, front);
        UpdateMap(cubeState.back, back);
        UpdateMap(cubeState.left, left);
        UpdateMap(cubeState.right, right);
        UpdateMap(cubeState.up, up);
        UpdateMap(cubeState.down, down);
    }

    void UpdateMap(List<GameObject> face, Transform side)
    {
        char[] modifiedWordArray0 = new char[9];
        char[] modifiedWordArray1 = new char[9];
        char[] modifiedWordArray2 = new char[9];
        char[] modifiedWordArray3 = new char[9];
        char[] modifiedWordArray4 = new char[9];
        char[] modifiedWordArray5 = new char[9];

        int i = 0;
        char c;

        foreach (Transform map in side)
        {
            Text[] newText = map.gameObject.GetComponentsInChildren<Text>();
            c = face[i].name[0];

            if (c == 'F')
            {
                newText[0].text = wordArray0[i].ToString();
                modifiedWordArray0[i] = wordArray0[i];
            }
            else if (c == 'B')
            {
                newText[0].text = wordArray1[i].ToString();
                modifiedWordArray1[i] = wordArray1[i];
            }
            else if (c == 'U')
            {
                newText[0].text = wordArray2[i].ToString();
                modifiedWordArray2[i] = wordArray2[i];
            }
            else if (c == 'D')
            {
                newText[0].text = wordArray3[i].ToString();
                modifiedWordArray3[i] = wordArray3[i];
            }
            else if (c == 'L')
            {
                newText[0].text = wordArray4[i].ToString();
                modifiedWordArray4[i] = wordArray4[i];
            }
            else if (c == 'R')
            {
                newText[0].text = wordArray5[i].ToString();
                modifiedWordArray5[i] = wordArray5[i];
            }

            i++;

            // Debug.Log($"Face: {face[i].name[0]}\tSide: {side}\tMap: {map}\ttext: {newText[0].text}");
        }

        i = 0;

        foreach (Transform map in side)
        {
            Text[] newText = map.gameObject.GetComponentsInChildren<Text>();
            c = face[i].name[0];
            char[] arrCopy = new char[9];

            if (c == 'F')
            {
                Array.Copy(modifiedWordArray0, arrCopy, 9);
            }
            else if (c == 'B')
            {
                Array.Copy(modifiedWordArray1, arrCopy, 9);
            }
            else if (c == 'U')
            {
                Array.Copy(modifiedWordArray2, arrCopy, 9);
            }
            else if (c == 'D')
            {
                Array.Copy(modifiedWordArray3, arrCopy, 9);
            }
            else if (c == 'L')
            {
                Array.Copy(modifiedWordArray4, arrCopy, 9);
            }
            else if (c == 'R')
            {
                Array.Copy(modifiedWordArray5, arrCopy, 9);
            }

            if (defineWords.cubeWordsDictionary[side.name[0].ToString()][i].ToString() == newText[0].text)
            {
                map.GetComponent<Image>().color = Color.green;
            }
            else if (defineWords.cubeWordsDictionary[side.name[0].ToString()].Contains(newText[0].text) &&
                (NumberOfOccurencesInArr(arrCopy, newText[0].text[0]) <
                    NumberOfOccurencesInArr(defineWords.cubeWordsDictionary[side.name[0].ToString()].ToCharArray(), newText[0].text[0])))
            {
                map.GetComponent<Image>().color = Color.yellow;
            }
            else
            {
                map.GetComponent<Image>().color = Color.grey;
            }

            i++;
        }

        for (i = 0; i < 9; i++)
        {
            // not fully working as intended yet...
            Renderer frontColor = defineWords.frontTransforms[i].transform.Find("Front").GetComponent<Renderer>();
            if (defineWords.cubeWordsDictionary[side.name[0].ToString()][i] == modifiedWordArray0[i])
            {
                frontColor.material.color = Color.green;
            } else if (defineWords.cubeWordsDictionary[side.name[0].ToString()].Contains(modifiedWordArray0[i].ToString()) &&
                (NumberOfOccurencesInArr(modifiedWordArray0, modifiedWordArray0[i]) <
                    NumberOfOccurencesInArr(defineWords.cubeWordsDictionary[side.name[0].ToString()].ToCharArray(), modifiedWordArray0[i])))
            {
                frontColor.material.color = Color.yellow;
            }
            else
            {
                frontColor.material.color = Color.grey;
            }
            Renderer backColor = defineWords.backTransforms[i].transform.Find("Back").GetComponent<Renderer>();
            if (defineWords.cubeWordsDictionary[side.name[0].ToString()][i] == modifiedWordArray1[i])
            {
                backColor.material.color = Color.green;
            } else if (defineWords.cubeWordsDictionary[side.name[0].ToString()].Contains(modifiedWordArray1[i].ToString()) &&
                (NumberOfOccurencesInArr(modifiedWordArray1, modifiedWordArray1[i]) <
                    NumberOfOccurencesInArr(defineWords.cubeWordsDictionary[side.name[0].ToString()].ToCharArray(), modifiedWordArray1[i])))
            {
                backColor.material.color = Color.yellow;
            }
            else
            {
                backColor.material.color = Color.grey;
            }
            Renderer upColor = defineWords.upTransforms[i].transform.Find("Up").GetComponent<Renderer>();
            if (defineWords.cubeWordsDictionary[side.name[0].ToString()][i] == modifiedWordArray2[i])
            {
                upColor.material.color = Color.green;
            } else if (defineWords.cubeWordsDictionary[side.name[0].ToString()].Contains(modifiedWordArray2[i].ToString()) &&
                (NumberOfOccurencesInArr(modifiedWordArray2, modifiedWordArray2[i]) <
                    NumberOfOccurencesInArr(defineWords.cubeWordsDictionary[side.name[0].ToString()].ToCharArray(), modifiedWordArray2[i])))
            {
                upColor.material.color = Color.yellow;
            }
            else
            {
                upColor.material.color = Color.grey;
            }
            Renderer downColor = defineWords.downTransforms[i].transform.Find("Down").GetComponent<Renderer>();
            if (defineWords.cubeWordsDictionary[side.name[0].ToString()][i] == modifiedWordArray3[i])
            {
                downColor.material.color = Color.green;
            } else if (defineWords.cubeWordsDictionary[side.name[0].ToString()].Contains(modifiedWordArray3[i].ToString()) &&
                (NumberOfOccurencesInArr(modifiedWordArray3, modifiedWordArray3[i]) <
                    NumberOfOccurencesInArr(defineWords.cubeWordsDictionary[side.name[0].ToString()].ToCharArray(), modifiedWordArray3[i])))
            {
                downColor.material.color = Color.yellow;
            }
            else
            {
                downColor.material.color = Color.grey;
            }
            Renderer leftColor = defineWords.leftTransforms[i].transform.Find("Left").GetComponent<Renderer>();
            if (defineWords.cubeWordsDictionary[side.name[0].ToString()][i] == modifiedWordArray4[i])
            {
                leftColor.material.color = Color.green;
            } else if (defineWords.cubeWordsDictionary[side.name[0].ToString()].Contains(modifiedWordArray4[i].ToString()) &&
                (NumberOfOccurencesInArr(modifiedWordArray4, modifiedWordArray4[i]) <
                    NumberOfOccurencesInArr(defineWords.cubeWordsDictionary[side.name[0].ToString()].ToCharArray(), modifiedWordArray4[i])))
            {
                leftColor.material.color = Color.yellow;
            }
            else
            {
                leftColor.material.color = Color.grey;
            }
            Renderer rightColor = defineWords.rightTransforms[i].transform.Find("Right").GetComponent<Renderer>();
            if (defineWords.cubeWordsDictionary[side.name[0].ToString()][i] == modifiedWordArray5[i])
            {
                rightColor.material.color = Color.green;
            } else if (defineWords.cubeWordsDictionary[side.name[0].ToString()].Contains(modifiedWordArray5[i].ToString()) &&
                (NumberOfOccurencesInArr(modifiedWordArray5, modifiedWordArray5[i]) <
                    NumberOfOccurencesInArr(defineWords.cubeWordsDictionary[side.name[0].ToString()].ToCharArray(), modifiedWordArray5[i])))
            {
                rightColor.material.color = Color.yellow;
            }
            else
            {
                rightColor.material.color = Color.grey;
            }
        }
    }
}
