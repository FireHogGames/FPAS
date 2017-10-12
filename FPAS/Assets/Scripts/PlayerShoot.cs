using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShoot : MonoBehaviour {

    public Camera playerCamera;
    public float fireRate;
    public LayerMask hitMask;
    private float nextTimeToFire;
    public Text scoreText;
    public Text hightText;
    private int score = 0;
    private int HighScore = 0;

    private void Start()
    {
        HighScore = PlayerPrefs.GetInt("HighScore");
        scoreText.text = "current score: " + score.ToString();
        hightText.text = "High score: " + HighScore.ToString();
    }

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        RaycastHit _hitPoint;

        if(Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out _hitPoint, 1000f, hitMask))
        {
            if(_hitPoint.collider.tag == "Target")
            {
                OnHit(_hitPoint.collider);
            }
        }
    }

    private void OnHit(Collider info)
    {
        Target target = info.GetComponent<Target>();
        if(target != null)
        {
            target.TakeDamage(20f, this);
        }
    }

    public void ConfirmKill(int points)
    {
        score += points;
        HighScore += points;
        PlayerPrefs.SetInt("HighScore", score);
        scoreText.text = "current score: " + score.ToString();
        hightText.text = "High score: " + HighScore.ToString();
    }
}
