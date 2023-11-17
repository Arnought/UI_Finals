using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairColorChanger : MonoBehaviour
{
    public List<Texture> hairTextureList;
    public List<Texture> bodyTextureList;
    public Material hairMaterial;
    public Material bodyMaterial;

    public void ChangeHairColor()
    {
        
           int currentHairTextureIndex = hairTextureList.IndexOf(hairMaterial.mainTexture);

            currentHairTextureIndex++;

            if (currentHairTextureIndex >= hairTextureList.Count)
            {
                currentHairTextureIndex = 0;
            }
            hairMaterial.mainTexture = hairTextureList[currentHairTextureIndex];

            
            int changeBodyTextureIndex = bodyTextureList.IndexOf(bodyMaterial.mainTexture);
            changeBodyTextureIndex++;

        if (changeBodyTextureIndex >= bodyTextureList.Count)
        {
            changeBodyTextureIndex = 0;
        }
        bodyMaterial.mainTexture = bodyTextureList[changeBodyTextureIndex];
    }
}
