using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Shape : MonoBehaviour
{
    public Transform Cube;
    public Transform Player;
    public float Distance;
    public Renderer r;

    void Update()
    {
        Distance = Vector3.Distance(Player.position, Cube.position);

        transform.GetComponent<Renderer>().material.color = Color.Lerp(Color.green, Color.white, Distance/15);

        if (Distance < 5 && Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene("HW3");
        }
    }
}
