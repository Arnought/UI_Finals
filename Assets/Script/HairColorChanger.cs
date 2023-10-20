using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairColorChanger : MonoBehaviour
{
    public List<Texture> hairTextureList;
    public Material hairMaterial;

    private void Update()
    {
        ChangeHairColor();
    }

    public void ChangeHairColor()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int currentHairTextureIndex = hairTextureList.IndexOf(hairMaterial.mainTexture);

            currentHairTextureIndex++;

            if (currentHairTextureIndex >= hairTextureList.Count)
            {
                currentHairTextureIndex = 0;
            }
            hairMaterial.mainTexture = hairTextureList[currentHairTextureIndex];
        }
    }
}
