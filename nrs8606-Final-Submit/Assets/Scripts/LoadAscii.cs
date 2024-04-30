using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LoadAscii : MonoBehaviour
{
    GameObject asciiLevel;
    string ascii_FILE_PATH;
    public static LoadAscii instance;

    public GameObject prefabFlowers;
    public GameObject prefabSlides;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        ascii_FILE_PATH = Application.dataPath + "/TextFiles/flowers.txt";
        LoadLevel();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadLevel()
    {
        asciiLevel = new GameObject("LevelObjects");

        //Get the lines from the file
        string[] lines = File.ReadAllLines(ascii_FILE_PATH);

        for(int y = 0; y<lines.Length; y++)
        {
            string line = lines[y].ToUpper();

            char[] characters = line.ToCharArray();

            for(int x = 0; x < characters.Length; x++)
            {
                char c = characters[x];

                GameObject newObject = null;

                switch (c)
                {
                    case 'X': //if the character is an x
                        newObject =
                            Instantiate(prefabFlowers);
                        break;
                    case 'O': //if the character is an x
                        newObject =
                            Instantiate(prefabSlides);
                        break;
                    default:
                        break;
                }

                if (newObject != null)
                {
                    newObject.transform.parent = asciiLevel.transform;
                    newObject.transform.position = new Vector2(x-2, -y);
                }
            }
        }
    }
}
