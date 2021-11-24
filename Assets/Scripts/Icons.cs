using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class Icons : MonoBehaviour
{
    Sprite yin, pep;

    void Start()
    {
        //Grabs yinYang and Peppermint still shots
        yin = Resources.Load<Sprite>("CharacterYin");
        pep = Resources.Load<Sprite>("CharacterPeppermint");

        loadImg();

    }

     void loadImg()
    {
        Image image;
        image = gameObject.GetComponent<Image>();

        //sets username icon to the image of the user selected pattern
        if (Singleton.instance.pattern == "Peppermint")
        {
            image.sprite = pep;

        }

        if (Singleton.instance.pattern == "Yin Yang")
        {
            image.sprite = yin;
        }
    }


}
