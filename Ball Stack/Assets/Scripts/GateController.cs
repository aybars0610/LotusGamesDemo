using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GateController : MonoBehaviour
{

    [SerializeField] private enum GateType {
        PositiveGate,
        NegativeGate
    }

    [SerializeField] private TMP_Text _gateText = null;
    [SerializeField] private GateType gateType;

    
    [SerializeField] private string _gateNumber = "";
    [SerializeField] private string gate = "";
    [SerializeField] private string Contact2 = "";

    public string GetGateNumber() {
        return _gateNumber;
    }

    private void Start()
    {
        GenerateRandomGateNumber();
    }

    private void GenerateRandomGateNumber()
    {
        switch (gateType)
        {
            case GateType.PositiveGate:
                Contact2 = Random.Range(1, 15).ToString();
                gate = "+";
                _gateNumber = gate + Contact2;

                SetGateText();
                break;
            case GateType.NegativeGate:
                Contact2 = Random.Range(1, 15).ToString();
                gate = "X";
                _gateNumber = gate + Contact2;
                SetGateText();
                break;
        }
    }

    private void SetGateText()
    {
        _gateText.text = _gateNumber.ToString();
    }
}
