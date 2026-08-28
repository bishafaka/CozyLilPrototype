using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed=5f;
    [SerializeField] LayerMask groundLayer;
    Rigidbody2D rb;
    Collider2D col;
    Vector2 moveInput;

    void Awake()
    {
        rb=GetComponent<Rigidbody2D>();
        col=GetComponent<Collider2D>();
    }
    void OnEnable()
    {
        if(InputManager.Instance!=null)
            InputManager.Instance.Move+=OnMove;
    }
    void OnDisable()
    {
        if(InputManager.Instance!=null)
            InputManager.Instance.Move-=OnMove;
    }
    void FixedUpdate()
    {
        if(moveInput==Vector2.zero)
            return;
        Vector2 movement=moveInput*speed*Time.fixedDeltaTime;
        if(CanMoveTo(rb.position+movement))
        {
            rb.MovePosition(rb.position+movement);
            return;
        }
        MoveAxis(Vector2.right*movement.x);
        MoveAxis(Vector2.up*movement.y);
    }
    void MoveAxis(Vector2 movement)
    {
        if(Mathf.Abs(movement.x+movement.y)<0.001f)
            return;
        Vector2 target=rb.position+movement;
        if(CanMoveTo(target))
            rb.MovePosition(target);
    }
    bool CanMoveTo(Vector2 position)
    {
        Bounds bounds=col.bounds;
        Vector2 center=position+(Vector2)(bounds.center-transform.position);
        Vector2 extents=bounds.extents;
        return IsGround(center+new Vector2(-extents.x, -extents.y)) && IsGround(center+new Vector2(-extents.x, extents.y)) && IsGround(center+new Vector2(extents.x, -extents.y)) && IsGround(center+new Vector2(extents.x, extents.y));
    }
    void OnMove(Vector2 input) => moveInput=input;
    bool IsGround(Vector2 point) => Physics2D.OverlapPoint(point, groundLayer)!=null;
}
