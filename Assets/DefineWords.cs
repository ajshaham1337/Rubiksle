using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefineWords : MonoBehaviour
{
    Automate automate;
    // CubeMap cubeMap;

    public TextAsset dataFile;
    public string[] data;
    public string[] sixWordsListForCube;
    public Dictionary<string, string> cubeWordsDictionary;

    // public Transform cube;
    public Transform F;
    public Transform B;
    public Transform L;
    public Transform FR;
    public Transform LB;
    public Transform R;
    public Transform FL;
    public Transform RB;
    public Transform D;
    public Transform FD;
    public Transform BD;
    public Transform BLD;
    public Transform FRD;
    public Transform LD;
    public Transform BRD;
    public Transform FLD;
    public Transform RD;
    public Transform FU;
    public Transform BU;
    public Transform BRU;
    public Transform FRU;
    public Transform LU;
    public Transform BLU;
    public Transform FLU;
    public Transform RU;
    public Transform U;

    public Transform[] frontTransforms;
    public Transform[] backTransforms;
    public Transform[] upTransforms;
    public Transform[] downTransforms;
    public Transform[] leftTransforms;
    public Transform[] rightTransforms;


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
        Text fluFront = FLU.transform.Find("Front").GetChild(0).GetChild(0).GetComponent<Text>();
        fluFront.text = sixWordsListForCube[0][0].ToString();
        Text fuFront = FU.transform.Find("Front").GetChild(0).GetChild(0).GetComponent<Text>();
        fuFront.text = sixWordsListForCube[0][1].ToString();
        Text fruFront = FRU.transform.Find("Front").GetChild(0).GetChild(0).GetComponent<Text>();
        fruFront.text = sixWordsListForCube[0][2].ToString();
        Text flFront = FL.transform.Find("Front").GetChild(0).GetChild(0).GetComponent<Text>();
        flFront.text = sixWordsListForCube[0][3].ToString();
        Text fFront = F.transform.Find("Front").GetChild(0).GetChild(0).GetComponent<Text>();
        fFront.text = sixWordsListForCube[0][4].ToString();
        Text frFront = FR.transform.Find("Front").GetChild(0).GetChild(0).GetComponent<Text>();
        frFront.text = sixWordsListForCube[0][5].ToString();
        Text fldFront = FLD.transform.Find("Front").GetChild(0).GetChild(0).GetComponent<Text>();
        fldFront.text = sixWordsListForCube[0][6].ToString();
        Text fdFront = FD.transform.Find("Front").GetChild(0).GetChild(0).GetComponent<Text>();
        fdFront.text = sixWordsListForCube[0][7].ToString();
        Text frdFront = FRD.transform.Find("Front").GetChild(0).GetChild(0).GetComponent<Text>();
        frdFront.text = sixWordsListForCube[0][8].ToString();
        frontTransforms = new Transform[9] {FLU, FU, FRU, FL, F, FR, FLD, FD, FRD};
        
        Text bruBack = BRU.transform.Find("Back").GetChild(0).GetChild(0).GetComponent<Text>();
        bruBack.text = sixWordsListForCube[1][0].ToString();
        Text buBack = BU.transform.Find("Back").GetChild(0).GetChild(0).GetComponent<Text>();
        buBack.text = sixWordsListForCube[1][1].ToString();
        Text bluBack = BLU.transform.Find("Back").GetChild(0).GetChild(0).GetComponent<Text>();
        bluBack.text = sixWordsListForCube[1][2].ToString();
        Text lbBack = LB.transform.Find("Back").GetChild(0).GetChild(0).GetComponent<Text>();
        lbBack.text = sixWordsListForCube[1][3].ToString();
        Text bBack = B.transform.Find("Back").GetChild(0).GetChild(0).GetComponent<Text>();
        bBack.text = sixWordsListForCube[1][4].ToString();
        Text rbBack = RB.transform.Find("Back").GetChild(0).GetChild(0).GetComponent<Text>();
        rbBack.text = sixWordsListForCube[1][5].ToString();
        Text bldBack = BLD.transform.Find("Back").GetChild(0).GetChild(0).GetComponent<Text>();
        bldBack.text = sixWordsListForCube[1][6].ToString();
        Text bdBack = BD.transform.Find("Back").GetChild(0).GetChild(0).GetComponent<Text>();
        bdBack.text = sixWordsListForCube[1][7].ToString();
        Text brdBack = BRD.transform.Find("Back").GetChild(0).GetChild(0).GetComponent<Text>();
        brdBack.text = sixWordsListForCube[1][8].ToString();
        backTransforms = new Transform[9] {BRU, BU, BLU, LB, B, RB, BLD, BD, BRD};
        
        Text bruUp = BRU.transform.Find("Up").GetChild(0).GetChild(0).GetComponent<Text>();
        bruUp.text = sixWordsListForCube[2][0].ToString();
        Text luUp = LU.transform.Find("Up").GetChild(0).GetChild(0).GetComponent<Text>();
        luUp.text = sixWordsListForCube[2][1].ToString();
        Text fruUp = FRU.transform.Find("Up").GetChild(0).GetChild(0).GetComponent<Text>();
        fruUp.text = sixWordsListForCube[2][2].ToString();
        Text buUp = BU.transform.Find("Up").GetChild(0).GetChild(0).GetComponent<Text>();
        buUp.text = sixWordsListForCube[2][3].ToString();
        Text uUp = U.transform.Find("Up").GetChild(0).GetChild(0).GetComponent<Text>();
        uUp.text = sixWordsListForCube[2][4].ToString();
        Text fuUp = FU.transform.Find("Up").GetChild(0).GetChild(0).GetComponent<Text>();
        fuUp.text = sixWordsListForCube[2][5].ToString();
        Text bluUp = BLU.transform.Find("Up").GetChild(0).GetChild(0).GetComponent<Text>();
        bluUp.text = sixWordsListForCube[2][6].ToString();
        Text ruUp = RU.transform.Find("Up").GetChild(0).GetChild(0).GetComponent<Text>();
        ruUp.text = sixWordsListForCube[2][7].ToString();
        Text fluUp = FLU.transform.Find("Up").GetChild(0).GetChild(0).GetComponent<Text>();
        fluUp.text = sixWordsListForCube[2][8].ToString();
        upTransforms = new Transform[9] {BRU, LU, FRU, BU, U, FU, BLU, RU, FLU};

        Text brdDown = BRD.transform.Find("Down").GetChild(0).GetChild(0).GetComponent<Text>();
        brdDown.text = sixWordsListForCube[3][0].ToString();
        Text rdDown = RD.transform.Find("Down").GetChild(0).GetChild(0).GetComponent<Text>();
        rdDown.text = sixWordsListForCube[3][1].ToString();
        Text fldDown = FLD.transform.Find("Down").GetChild(0).GetChild(0).GetComponent<Text>();
        fldDown.text = sixWordsListForCube[3][2].ToString();
        Text bdDown = BD.transform.Find("Down").GetChild(0).GetChild(0).GetComponent<Text>();
        bdDown.text = sixWordsListForCube[3][3].ToString();
        Text dDown = D.transform.Find("Down").GetChild(0).GetChild(0).GetComponent<Text>();
        dDown.text = sixWordsListForCube[3][4].ToString();
        Text fdDown = FD.transform.Find("Down").GetChild(0).GetChild(0).GetComponent<Text>();
        fdDown.text = sixWordsListForCube[3][5].ToString();
        Text bldDown = BLD.transform.Find("Down").GetChild(0).GetChild(0).GetComponent<Text>();
        bldDown.text = sixWordsListForCube[3][6].ToString();
        Text ldDown = LD.transform.Find("Down").GetChild(0).GetChild(0).GetComponent<Text>();
        ldDown.text = sixWordsListForCube[3][7].ToString();
        Text frdDown = FRD.transform.Find("Down").GetChild(0).GetChild(0).GetComponent<Text>();
        frdDown.text = sixWordsListForCube[3][8].ToString();
        downTransforms = new Transform[9] {BRD, RD, FLD, BD, D, FD, BLD, LD, FRD};

        Text fruLeft = FRU.transform.Find("Left").GetChild(0).GetChild(0).GetComponent<Text>();
        fruLeft.text = sixWordsListForCube[4][0].ToString();
        Text luLeft = LU.transform.Find("Left").GetChild(0).GetChild(0).GetComponent<Text>();
        luLeft.text = sixWordsListForCube[4][1].ToString();
        Text bruLeft = BRU.transform.Find("Left").GetChild(0).GetChild(0).GetComponent<Text>(); 
        bruLeft.text = sixWordsListForCube[4][2].ToString();
        Text frLeft = FR.transform.Find("Left").GetChild(0).GetChild(0).GetComponent<Text>();
        frLeft.text = sixWordsListForCube[4][3].ToString();
        Text lLeft = L.transform.Find("Left").GetChild(0).GetChild(0).GetComponent<Text>();
        lLeft.text = sixWordsListForCube[4][4].ToString();
        Text lbLeft = LB.transform.Find("Left").GetChild(0).GetChild(0).GetComponent<Text>();
        lbLeft.text = sixWordsListForCube[4][5].ToString();
        Text frdLeft = FRD.transform.Find("Left").GetChild(0).GetChild(0).GetComponent<Text>();
        frdLeft.text = sixWordsListForCube[4][6].ToString();
        Text ldLeft = LD.transform.Find("Left").GetChild(0).GetChild(0).GetComponent<Text>();
        ldLeft.text = sixWordsListForCube[4][7].ToString();
        Text bldLeft = BLD.transform.Find("Left").GetChild(0).GetChild(0).GetComponent<Text>();
        bldLeft.text = sixWordsListForCube[4][8].ToString();
        leftTransforms = new Transform[9] {FRU, LU, BRU, FR, L, LB, FRD, LD, BLD};

        Text bluRight = BLU.transform.Find("Right").GetChild(0).GetChild(0).GetComponent<Text>();
        bluRight.text = sixWordsListForCube[5][0].ToString();
        Text ruRight = RU.transform.Find("Right").GetChild(0).GetChild(0).GetComponent<Text>();
        ruRight.text = sixWordsListForCube[5][1].ToString();
        Text fluRight = FLU.transform.Find("Right").GetChild(0).GetChild(0).GetComponent<Text>();
        fluRight.text = sixWordsListForCube[5][2].ToString();
        Text rbRight = RB.transform.Find("Right").GetChild(0).GetChild(0).GetComponent<Text>();
        rbRight.text = sixWordsListForCube[5][3].ToString();
        Text rRight = R.transform.Find("Right").GetChild(0).GetChild(0).GetComponent<Text>();
        rRight.text = sixWordsListForCube[5][4].ToString();
        Text flRight = FL.transform.Find("Right").GetChild(0).GetChild(0).GetComponent<Text>();
        flRight.text = sixWordsListForCube[5][5].ToString();
        Text brdRight = BRD.transform.Find("Right").GetChild(0).GetChild(0).GetComponent<Text>();
        brdRight.text = sixWordsListForCube[5][6].ToString();
        Text rdRight = RD.transform.Find("Right").GetChild(0).GetChild(0).GetComponent<Text>();
        rdRight.text = sixWordsListForCube[5][7].ToString();
        Text fldRight = FLD.transform.Find("Right").GetChild(0).GetChild(0).GetComponent<Text>();
        fldRight.text = sixWordsListForCube[5][8].ToString();
        rightTransforms = new Transform[9] {BLU, RU, FLU, RB, R, FL, BRD, RD, FLD};
    }

    public void StartGame()
    {
        // RandomizeCubeWords();
        automate.Shuffle();
    }
}
