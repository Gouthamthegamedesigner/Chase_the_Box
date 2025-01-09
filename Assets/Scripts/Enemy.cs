using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
   [SerializeField] private float _speed = 9;

   private Transform _target;

   void Awake()
   {
        _target = FindObjectOfType<Player>().transform;
   }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            if (collision.gameObject.name == "Player")
            {
                SceneManager.LoadSceneAsync("GamOverScreen");
            }
    }

}
