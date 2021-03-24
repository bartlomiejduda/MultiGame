
public var w_gore : GameObject;
public var w_prawo : GameObject;
public var w_lewo : GameObject;
public var w_dol : GameObject;

function Update() { 
 

    if (Input.GetKeyDown("i")) 
    {
        Instantiate(w_gore, transform.position, Quaternion.identity);
    }

    if (Input.GetKeyDown("l")) 
    {
        Instantiate(w_prawo, transform.position, Quaternion.identity);
    }

    if (Input.GetKeyDown("j")) 
    {
        Instantiate(w_lewo, transform.position, Quaternion.identity);
    }

     if (Input.GetKeyDown("k")) 
    {
        Instantiate(w_dol, transform.position, Quaternion.identity);
    }
} 