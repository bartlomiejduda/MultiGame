public var speed : int = 6;


function Start () 
{
	var r2d = GetComponent("Rigidbody2D");

	if (gameObject.tag == "right_tag")
	{
    	r2d.velocity.x = speed;
    }

    else if (gameObject.tag == "left_tag")
    {
    	
    	r2d.velocity.x = speed;
    }

    else if (gameObject.tag == "down_tag")
    {
    	
    	r2d.velocity.y = speed;
    }
}


function OnBecameInvisible() 
{
    Destroy(gameObject);
} 