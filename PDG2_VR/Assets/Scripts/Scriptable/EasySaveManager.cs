using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasySaveManager : MonoBehaviour {

    [Header("Prefabs")]
    [SerializeField] private GameObject pinkCube;
    [SerializeField] private GameObject yellowCube;
    [SerializeField] private GameObject greenCube;
    [SerializeField] private GameObject blueCube;

    [Header("DB Settings")]
    [SerializeField] private string postitTag;
    [SerializeField] private int postitAmount;

    [Header("DB Collections")]
    [SerializeField] private List<Vector3> positions;
    [SerializeField] private List<string> colors;

    [SerializeField] private List<string> titlesF;

    //[SerializeField] private List<string> titleR;
    //[SerializeField] private List<string> titleB;
    //[SerializeField] private List<string> titleL;

    [SerializeField] private List<int> valuesR;
    [SerializeField] private List<int> valuesB;
    [SerializeField] private List<int> valuesL;

    [Header("Additional Info")]
    public bool loaded;

    void Start() {
        positions = new List<Vector3>();
        colors = new List<string>();

        titlesF = new List<string>();

        //titleR = new List<string>();
        //titleB = new List<string>();
        //titleL = new List<string>();

        valuesR = new List<int>();
        valuesB = new List<int>();
        valuesL = new List<int>();

        LoadPostit();
    }

    private void OnApplicationQuit() {
        SavePostit();
    }

    public void SavePostit() {
        GameObject[] postits = GameObject.FindGameObjectsWithTag(postitTag);

        postitAmount = postits.Length;

        positions.Clear();
        colors.Clear();
        titlesF.Clear();
        valuesR.Clear();
        valuesB.Clear();
        valuesL.Clear();

        foreach (GameObject p in postits) {
            Attributes a = p.GetComponent<Attributes>();

            positions.Add(p.transform.position);
            colors.Add(a.color);
            titlesF.Add(a.nameF.text);

            //titleR.Add(a.nameR.text);
            //titleB.Add(a.nameB.text);
            //titleL.Add(a.nameL.text);

            valuesR.Add(a.valueR);
            valuesB.Add(a.valueB);
            valuesL.Add(a.valueL);
        }

        ES2.Save(postitAmount, "amount");
        ES2.Save(positions, "positions");
        ES2.Save(colors, "colors");

        ES2.Save(titlesF, "titlesF");

        //ES2.Save(titlesR, "titleR");
        //ES2.Save(titlesB, "titleB");
        //ES2.Save(titlesL, "titleL");

        ES2.Save(valuesR, "valuesR");
        ES2.Save(valuesB, "valuesB");
        ES2.Save(valuesL, "valuesL");
    }

    public void LoadPostit() {
        if (loaded) return;
        loaded = true;

        postitAmount = ES2.Load<int>("amount");

        positions = ES2.LoadList<Vector3>("positions");
        colors = ES2.LoadList<string>("colors");

        titlesF = ES2.LoadList<string>("titlesF");

        //titlesR = ES2.LoadList<string>("titlesR");
        //titlesB = ES2.LoadList<string>("titlesB");
        //titlesL = ES2.LoadList<string>("titlesL");

        valuesR = ES2.LoadList<int>("valuesR");
        valuesB = ES2.LoadList<int>("valuesB");
        valuesL = ES2.LoadList<int>("valuesL");

        for (int i = 0; i < postitAmount; i++) {
            switch (colors[i]) {
                case "Yellow":
                    GameObject py = Instantiate(yellowCube, positions[i], Quaternion.identity);
                    Attributes ay = py.GetComponent<Attributes>();

                    ay.newNameF = titlesF[i];

                    ay.valueR = valuesR[i];
                    ay.valueB = valuesB[i];
                    ay.valueL = valuesL[i];
                    break;
                case "Pink":
                    GameObject pp = Instantiate(pinkCube, positions[i], Quaternion.identity);
                    Attributes ap = pp.GetComponent<Attributes>();

                    ap.newNameF = titlesF[i];

                    ap.valueR = valuesR[i];
                    ap.valueB = valuesB[i];
                    ap.valueL = valuesL[i];
                    break;
                case "Blue":
                    GameObject pb = Instantiate(blueCube, positions[i], Quaternion.identity);
                    Attributes ab = pb.GetComponent<Attributes>();

                    ab.newNameF = titlesF[i];

                    ab.valueR = valuesR[i];
                    ab.valueB = valuesB[i];
                    ab.valueL = valuesL[i];
                    break;
                case "Green":
                    GameObject pg = Instantiate(greenCube, positions[i], Quaternion.identity);
                    Attributes ag = pg.GetComponent<Attributes>();

                    ag.newNameF = titlesF[i];

                    ag.valueR = valuesR[i];
                    ag.valueB = valuesB[i];
                    ag.valueL = valuesL[i];
                    break;
            }
        }
    }

}
