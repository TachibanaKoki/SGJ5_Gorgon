using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class player_camera_script : MonoBehaviour
{
    private float _rotationSpeed, _rotationCnt, _playerSpeed;
    public float _life, _lifeMax;
    void Start()
    {
        _rotationCnt = 0;
        _rotationSpeed = 2;
        _playerSpeed = 0.1f;
        _life = 10;
        _lifeMax = _life;
    }


    void Update()
    {
        PlayerMove();
        if (_life<=0)
        {
            //Application.LoadLevel("Game_over");
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }

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
    }
    public void RightRot()
    {
        _rotationCnt += _rotationSpeed;
    }
    public void LeftRot()
    {
        _rotationCnt -= _rotationSpeed;
    }
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "bullet")
        {
            _life -= 1;
            transform.DOShakePosition(0.2f,0.1f,30);
            Destroy(c.gameObject);
        }
    }
}

    
