using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_camera_script : MonoBehaviour
{
    private float _rotationSpeed, _rotationCnt, _playerSpeed;
    public float _life, _lifeMax;
    //------------------------
    int tf;
    //------------------------
    void Start()
    {
        _rotationCnt = 0;
        _rotationSpeed = 2;
        _playerSpeed = 0.1f;
        //----------------------
        _life = 10;
        _lifeMax = _life;
        tf = 1;
        //----------------------
    }


    void Update()
    {
        PlayerMove();
      //  Debug.Log(_life);
    }
    void PlayerMove()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.x, _rotationCnt, transform.rotation.z);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, _playerSpeed, Space.Self);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -_playerSpeed, Space.Self);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rotationCnt -= _rotationSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rotationCnt += _rotationSpeed;
        }
        //---------------------------------------
        if (Input.GetKey(KeyCode.A))
        {
            if (tf == 1)
            {
                tf = 0;
                _life -= 1;
            }
        }
        else
        {
            tf = 1;

        }
        //-----------------------------------------
    }
}
    
