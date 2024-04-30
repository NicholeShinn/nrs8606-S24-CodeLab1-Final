using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[CreateAssetMenu(
    fileName = "New Backdrop",
    menuName = "ScriptableObjectBackdrop",
    order = 0 )
    ]
public class ScriptableBackdrops : ScriptableObject
{
    public Material backgroundMaterial;
    public string locationName;
    public string locationDesc;

    public ScriptableBackdrops south;
    public GameObject triggerForward;

    
    public void UpdateCurrentLocation(EndManager em)
    {
        em.descriptionUI.text = locationDesc;
        em.backDropMaterial = backgroundMaterial;
        Instantiate(triggerForward);
    }


}
