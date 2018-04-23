using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDisplayCheck : MixinBase {

	[SerializeField] TestCheckMixin target;
    [SerializeField] Image image;
    [SerializeField] Text text;

    Color originalColour;

    void Start()
    {
        originalColour = image.color;
    }

    void Update()
    {
        if (target.Test)
        {
            image.color = Color.red;
        } else {
            image.color = originalColour;
        }
        text.text = target.ReturnMixin().GetType().ToString();
    }
}
