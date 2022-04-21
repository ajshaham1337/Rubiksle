using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    // Start is called before the first frame update
    void Start()
    {
        defineWords = FindObjectOfType<DefineWords>();
        defineWords.RandomizeCubeWords();
    }

    // Update is called once per frame
    void Update()
    {
        
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
        int i = 0;
        foreach (Transform map in side)
        {
            if (face[i].name[0] == 'F')
            {
                // Debug.Log(map.gameObject.GetComponentsInChildren<Text>());
                map.GetComponent<Image>().color = new Color(1, 0.5f, 0, 1);
                Text[] newText = map.gameObject.GetComponentsInChildren<Text>();
                Debug.Log(newText.Length);
                int idx = int.Parse(map.name);
                char[] wordArray0 = defineWords.sixWordsListForCube[0].ToCharArray();
                newText[0].text = wordArray0[i].ToString();
            }
            if (face[i].name[0] == 'B')
            {
                map.GetComponent<Image>().color = Color.red;
                Text[] newText = map.gameObject.GetComponentsInChildren<Text>();
                Debug.Log(newText.Length);
                int idx = int.Parse(map.name);
                char[] wordArray1 = defineWords.sixWordsListForCube[1].ToCharArray();
                newText[0].text = wordArray1[i].ToString();
            }
            if (face[i].name[0] == 'U')
            {
                map.GetComponent<Image>().color = Color.yellow;
                Text[] newText = map.gameObject.GetComponentsInChildren<Text>();
                int idx = int.Parse(map.name);
                char[] wordArray2 = defineWords.sixWordsListForCube[2].ToCharArray();
                newText[0].text = wordArray2[i].ToString();
            }
            if (face[i].name[0] == 'D')
            {
                map.GetComponent<Image>().color = Color.white;
                Text[] newText = map.gameObject.GetComponentsInChildren<Text>();
                int idx = int.Parse(map.name);
                char[] wordArray3 = defineWords.sixWordsListForCube[3].ToCharArray();
                newText[0].text = wordArray3[i].ToString();
            }
            if (face[i].name[0] == 'L')
            {
                map.GetComponent<Image>().color = Color.green;
                Text[] newText = map.gameObject.GetComponentsInChildren<Text>();
                int idx = int.Parse(map.name);
                char[] wordArray4 = defineWords.sixWordsListForCube[4].ToCharArray();
                newText[0].text = wordArray4[i].ToString();
            }
            if (face[i].name[0] == 'R')
            {
                map.GetComponent<Image>().color = Color.blue;
                Text[] newText = map.gameObject.GetComponentsInChildren<Text>();
                int idx = int.Parse(map.name);
                char[] wordArray5 = defineWords.sixWordsListForCube[5].ToCharArray();
                newText[0].text = wordArray5[i].ToString();
            }
            i++;
        }
    }
}
