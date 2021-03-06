using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 3.25f;
    public bool canPress = false;

    private Rigidbody2D _playerRigidbody;

    public Button_0 button;
    [SerializeField] TMP_InputField inputField;
    public TrapActivator trap;

    string InputString;

    private void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();
        if (_playerRigidbody == null)
        {
            Debug.LogError("Player is missing a Rigidbody2D component");
        }
    }
    void Update()
    {
        MovePlayer();
    }
    private void MovePlayer()
    {
        var horizontalInput = Input.GetAxisRaw("Horizontal");
        var verticalInput = Input.GetAxisRaw("Vertical");
        _playerRigidbody.velocity = new Vector2(horizontalInput * playerSpeed, verticalInput * playerSpeed);
    }

    public IEnumerator Slowed()
    {
        yield return new WaitForSeconds(1.5f);
        playerSpeed = 1.5f;
        yield return new WaitForSeconds(1f);
        playerSpeed = 3.25f;
    }

    //private bool IsGrounded()
    //{
    //    var groundCheck = Physics2D.Raycast(transform.position, Vector2.down, 0.7f);
    //    return groundCheck.collider != null && groundCheck.collider.CompareTag("Ground");
    //}

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Puzzle")
        {
            Debug.Log("menginjak spike");
            StartCoroutine(Slowed());
        }
    }
}
