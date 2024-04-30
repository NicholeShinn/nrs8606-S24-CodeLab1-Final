using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class EndManager : MonoBehaviour
{

    public TextMeshProUGUI descriptionUI;
    public GameObject backDrop;
    public Material backDropMaterial;

    public ScriptableBackdrops currentLocation;
    //public static EndManager instance;

    // Start is called before the first frame update
    void Start()
    {
        currentLocation.UpdateCurrentLocation(this);
        backDropMaterial = backDrop.GetComponent<MeshRenderer>().material;
    }

public void Movedir()
    {
        currentLocation = currentLocation.south;
        backDrop.GetComponent<MeshRenderer>().material = backDropMaterial;
        currentLocation.UpdateCurrentLocation(this);
    }
}
