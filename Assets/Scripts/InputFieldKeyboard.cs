using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputFieldKeyboard : MonoBehaviour
{
    public ObjectSelector objectSelector;
    public TextMeshProUGUI inputText;

    public void OnValueChange()
    {
        if (inputText.text.Contains("1"))
        {
            objectSelector.Chair();
        }
        if (inputText.text.Contains("2"))
        {
            objectSelector.Stove();
        }
        if (inputText.text.Contains("3"))
        {
            objectSelector.Fridge();
        }
    }

}
