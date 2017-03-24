using UnityEngine;
using System.Collections;

public class MercyScript : MonoBehaviour {

    public GameObject player;
    public Camera cam;
    public int speed = 10;
    public int speedRotation = 5;
    int c = 5;
    public int maxHeight = 20;
    public int minHeight = 0;

    // Use this for initialization
    void Start () {
        player = (GameObject)this.gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            cam.transform.position += player.transform.forward * speed * Time.deltaTime;
            player.transform.position += player.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space) && (player.transform.position.y <= maxHeight))
        {
            cam.transform.position += player.transform.up * speed * Time.deltaTime;
            player.transform.position += player.transform.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftControl) && (player.transform.position.y >= minHeight))
        {
            cam.transform.position -= player.transform.up * speed * Time.deltaTime;
            player.transform.position -= player.transform.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            cam.transform.position -= player.transform.forward * speed * Time.deltaTime;
            player.transform.position -= player.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            player.transform.Rotate(Vector3.down * speedRotation);
            cam.transform.RotateAround(player.transform.position, Vector3.down, speedRotation);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.Rotate(Vector3.up * speedRotation);
            cam.transform.RotateAround(player.transform.position, Vector3.up, speedRotation);
        }
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            Debug.Log(string.Format("{0} {1} {2} - {3}", this.gameObject.transform.position.x,
                this.gameObject.transform.position.y, this.gameObject.transform.position.z, this.gameObject.name));

        }
    }
}
