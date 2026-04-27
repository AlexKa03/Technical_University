using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Incrementation : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textMesh;
    private int cnt = 0;
    public void Increment()
    {
        cnt++;
        textMesh.text = cnt.ToString();
    }
}