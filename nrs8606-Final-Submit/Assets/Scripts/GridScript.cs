using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class GridScript : MonoBehaviour
{
    public int gridWidth = 3;
    public int gridHeight = 4; //how big...grid?

    public GameObject[,] grid; //grid is exist with 2 variables seperated by comma

    public GameObject prefabForGrid; //the grid is made of this object
    //-----------------------------------------------------------------
    string TITLE_FILE_PATH;
    TMP_Text prefabTextVariable;

    // Start is called before the first frame update
    void Start()
    {
        prefabTextVariable = prefabForGrid.GetComponent<TMP_Text>();

        //accessing, and parsing the data from txt file for the title objects, split at a comma to create an array of letters
        TITLE_FILE_PATH = Application.dataPath + "/TextFiles/title.txt";
        //getting the lines from the file
        string fileContents = File.ReadAllText(TITLE_FILE_PATH);
        string[] letters = fileContents.Split(',');

        //-----------------------------------------------------------------
        grid = new GameObject[gridWidth, gridHeight]; //create new grid on start 

        //fillin grid with the prefabs, they will correspond to position on grid using for loop
        foreach (string eachLetter in letters)
        {
            Debug.Log(eachLetter);

        }
        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                grid[x, y] = Instantiate<GameObject>(prefabForGrid); //instantiating prefabs on x and y
                grid[x, y].transform.position = new Vector2(x * 3 - 1, y * 2 - 2); //placing their transform on a 2D vector, there's no established Z axis. multiply to scale distance between, and subtract to center on camera/center point of world

            }
        }
        ///below we are assigning the letters from the text file to the text component variable in the instantiated objects according to their placement on the grid
        grid[0, 0].GetComponentInChildren<TMP_Text>().text = letters[9];
        grid[0, 1].GetComponentInChildren<TMP_Text>().text = letters[6];
        grid[0, 2].GetComponentInChildren<TMP_Text>().text = letters[3];
        grid[0, 3].GetComponentInChildren<TMP_Text>().text = letters[0];
        //-----
        grid[1, 0].GetComponentInChildren<TMP_Text>().text = letters[10];
        grid[1, 1].GetComponentInChildren<TMP_Text>().text = letters[7];
        grid[1, 2].GetComponentInChildren<TMP_Text>().text = letters[4];
        grid[1, 3].GetComponentInChildren<TMP_Text>().text = letters[1];
        //-----
        grid[2, 0].GetComponentInChildren<TMP_Text>().text = letters[11];
        grid[2, 1].GetComponentInChildren<TMP_Text>().text = letters[8];
        grid[2, 2].GetComponentInChildren<TMP_Text>().text = letters[5];
        grid[2, 3].GetComponentInChildren<TMP_Text>().text = letters[2];
        //-----
    }
    

    // Update is called once per frame
    void Update()
    {

    }


}
