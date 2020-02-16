using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector2 velocity;
    public GameObject player;

    public float smoothTimeX;
    public float smoothTimeY;

    private List<Transform> playerViews =  new List<Transform>();
    private Transform originalView;
    private Transform currentView;
    private const float transitionSpeed = 6;


    // Start is called before the first frame update
    void Start()
    {
            originalView = transform;
    }

    // Update is call once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            // Press O to go back to overhead view
            currentView = originalView;
        }

        if(Input.GetKeyDown(KeyCode.N))
        {
            SwitchView(+1);
        }
    }

    private void FixedUpdate()
    {
        if (player != null)
        {
            float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
            float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY);

            transform.position = new Vector3(posX, posY, transform.position.z);
        }
    }

    // LateUpdate is called once per frame after initial Update function
    private void LateUpdate()
    {
        if(player != null)
        {
            // Move Camera Using Linear Interpolation
            transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);
        }
    }

    public void SwitchView(int player)
    {
        // When Number of Players Are Selected, Camera moves to player 1 view

        // Needs reference to current active players on the board

        this.player = GameManager.Instance.players[0].gameObject;
        currentView = GameManager.Instance.players[player].transform;
    }
}
