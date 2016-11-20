using UnityEngine;
using Vuforia;
using System.Collections;


 
 public class txtmesh : MonoBehaviour
{
    public TextAsset dataFile;
    private TextMesh testMesh;

    // Use this for initialization
    void Start()
    {
        string[] dataLines = dataFile.text.Split('\n');
        string[][] dataPairs = new string[dataLines.Length][];
        int lineNum = 0;
        foreach (string line in dataLines)
        {
            dataPairs[lineNum++] = line.Split('|');
        }
        display(dataPairs[0][1]);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void display(string s)
    {
        string displayText = s;//get display text
        testMesh = GetComponent<TextMesh>();//
        testMesh.text = displayText;
    }
}