using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public float speed = 1f;

    private Rigidbody2D _rigidbody;
    private Animator _animator;

    public AudioClip clickSound;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        audioSource.clip = clickSound;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) {

            _rigidbody.velocity = Vector2.up * speed;
            _animator.SetTrigger("Jump");
            audioSource.Play();
        }
    }
}
