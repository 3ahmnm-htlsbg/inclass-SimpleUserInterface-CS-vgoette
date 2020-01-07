using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleUserInterface : MonoBehaviour
{
    public InputField varA;
    public Text counter;
    public Text result;
    public Button btn_push;
    public Button btn_count;

    int intCount = 1;

    public void CountNumbers()
    {
        intCount++;
        counter.text = intCount.ToString();
    }

   public void CopyText()
    {
        result.text = varA.text;
    }
}
