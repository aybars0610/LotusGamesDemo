using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tags;
using TMPro;
using System;


public class BallController : MonoBehaviour
{
    [SerializeField] public List<GameObject> _ball = new List<GameObject>();
    [SerializeField] private TMP_Text _ballCountText = null;
    //[SerializeField] private GameObject _ballPrefab;


    [Header("Movement")]
    [SerializeField] private float _horizontalLimit;
    [SerializeField] private float _horizontalSpeed;
    private float _horizontal;
    [SerializeField] private float _moveSpeed;

    private int _ballCount = 0;
    private int _target = 0;
   // private int gatenumber = 0;
    private string gatenumber = "";
    bool carpim = false;
    bool toplam = false;
    string harf = "";
    string harf2 = "";
    void Update()
    {
        BallMoveForward();
        BallHorizontalMovement();
        UpdateBallCountText();

        _ballCount = _ball.Count;
        
        Debug.Log(_target);
    }


    private void BallHorizontalMovement() {
        float _newX = 0;

        if(Input.GetMouseButton(0)) {
            _horizontal = Input.GetAxisRaw("Mouse X");
        }
        else {
            _horizontal = 0;
        }

        _newX = transform.position.x + _horizontal * _horizontalSpeed * Time.deltaTime;
        _newX = Mathf.Clamp(_newX, -_horizontalLimit, _horizontalLimit);

        transform.position = new Vector3(
            _newX,
            transform.position.y,
            transform.position.z
        );

        
    }



    private void BallMoveForward() {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
    }



    private void UpdateBallCountText() {
        //  _ballCountText.text = _ball.Count.ToString();
        _ballCountText.text = "" + collectableBox.shotCount + "/sec";
        _target = collectableBox.shotCount;
    }




}
