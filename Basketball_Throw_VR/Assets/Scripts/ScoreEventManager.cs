using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreEventManager : MonoBehaviour
{
    public List<Material> colorMaterials;

    // Start is called before the first frame update
    void Start()
    {
        HoopColliderScript.scoreActionEvent += ChangeColorOfObjects;
    }

    // Update is called once per frame
    void ChangeColorOfObjects()
    {
        for(int i = 0; i < colorMaterials.Count; i++)
        {
            colorMaterials[i].color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
    }
}
