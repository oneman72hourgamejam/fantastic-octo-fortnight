using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnityManager : MonoBehaviour
{
    public Button btn;
    public Text _t;

    private void OnEnable()
    {
        btn.onClick.AddListener(Calc);
    }

    private void Calc()
    {
        Manager m = new Manager(2);
        _t.text = m.A.ToString() + "/" + m.Add(2).ToString();
    }

    private void OnDisable()
    {
        btn.onClick.RemoveListener(Calc);
    }
}
