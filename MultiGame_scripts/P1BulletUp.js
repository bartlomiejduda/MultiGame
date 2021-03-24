public var speed : int = 6;


function Start () 
{
    var r2d = GetComponent("Rigidbody2D");
    r2d.velocity.y = speed;
}


function OnBecameInvisible() 
{
    Destroy(gameObject);
} 