using UnityEngine;
using System.Collections;

public class thr : MonoBehaviour {

    public Rigidbody rb;
    public GameObject he;
    public GameObject ball;
    public GameObject cap;
    public GameObject recap;
    static int capture = 0;
    public GameObject cam;
    public GameObject[] selectorArr;
    int resp;
    static int cha;
    int ra;
    
    static int mov;
    void Awake()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }
    // Use this for initialization
    void Start()
    {    
        rb = GetComponent<Rigidbody>();
        resp = 0;
        ra = 0;
        mov = 1;
    
    }

    bool _touchBegan = false;
    private void Update()
    {

        if (capture == 1)
        {
            if (resp == 1 && rb.velocity.magnitude < 1f)
            {
                resp = 0;
                rb.useGravity = false;
                inita();

                //  Destroy(gameObject);

            }
        }
            Touch currentTouch = Input.GetTouch(0);

            Vector2 currentTouchPosition = currentTouch.position;
            Vector3 touchPointInWorld = Camera.main.ScreenToWorldPoint(new Vector3(currentTouchPosition.x, currentTouchPosition.y));

     



            if (Input.touchCount <= 0)
            {
           

                return;
            }
            if (currentTouch.phase == TouchPhase.Began && rb.IsSleeping())
            {
       
                _touchBegan = true;
                return;
            }




            if (currentTouch.phase == TouchPhase.Moved && _touchBegan)
            {
           
                Vector2 sa = currentTouch.deltaPosition;
            //rb.velocity = transform.forward * 2;
            rb.velocity = transform.TransformDirection(new Vector3(sa.x * 0.2f, sa.magnitude * 0.3f, 7));
          
            // transform.Translate(0,0.1f, 0.1f);
            // transform.localPosition = Camera.main.ScreenToWorldPoint(new Vector3(currentTouchPosition.x, currentTouchPosition.y));
            return;
            }

            // if (currentTouch.phase == TouchPhase.Ended || currentTouch.phase == TouchPhase.Canceled && _touchBegan)
            if (currentTouch.phase == TouchPhase.Ended)
            {
                rb.useGravity = true;
                //AddForce
                resp = 1;
                _touchBegan = false;
                return;
            }

   

    }
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.LoadLevel(0);

    }

    void inita()
    {

        GameObject GPO = (GameObject)Instantiate(ball, cam.transform.position+ cam.transform.forward*2.5f,cam.transform.rotation);
        float yDir = GPO.transform.position.y;
        float xDir = GPO.transform.position.x;
        float zDir = GPO.transform.position.z;
        GPO.transform.position =new Vector3(xDir,yDir-1,zDir);


        Destroy(he);
    }
    IEnumerator Example()
    {
       
        yield return new WaitForSeconds(3);
        capture = 1;

    }

    void OnTriggerEnter(Collider other)
    {
        capture = 0;
        GameObject ani;
        rb.velocity = Vector3.zero;
        rb.transform.LookAt(cam.transform);
        StartCoroutine(Example());
        Destroy(other.gameObject);
       
       
        switch (cha)
        {
            case 0: if(!PlayerPrefs.HasKey("ele")==true)
                {
                    PlayerPrefs.SetInt("ele",1);
                }
            else
                {
                    int  a = PlayerPrefs.GetInt("ele");
                    PlayerPrefs.SetInt("ele", a+1);

                }
               
                break;
            case 1:
                if (!PlayerPrefs.HasKey("cat") == true)
                {
                    PlayerPrefs.SetInt("cat", 1);
                }
                else
                {
                    int a = PlayerPrefs.GetInt("cat");
                    PlayerPrefs.SetInt("cat", a + 1);

                }
                break;
            case 2:
                if (!PlayerPrefs.HasKey("spi") == true)
                {
                    PlayerPrefs.SetInt("spi", 1);
                }
                else
                {
                    int a = PlayerPrefs.GetInt("spi");
                    PlayerPrefs.SetInt("spi", a + 1);

                }
                break;

            case 3:
                if (!PlayerPrefs.HasKey("ele") == true)
                {
                    PlayerPrefs.SetInt("ele", 1);
                }
                else
                {
                    int a = PlayerPrefs.GetInt("ele");
                    PlayerPrefs.SetInt("ele", a + 1);

                }
                break;

            case 4:
                if (!PlayerPrefs.HasKey("rhi") == true)
                {
                    PlayerPrefs.SetInt("rhi", 1);
                }
                else
                {
                    int a = PlayerPrefs.GetInt("rhi");
                    PlayerPrefs.SetInt("rhi", a + 1);

                }
                break;

        }
    int va = Random.Range(0, 15);
        Vector3 pos = RandomCircle(cam.transform.position, 10);
    
           switch (va)
            {
                case 0:ani = (GameObject)Instantiate(selectorArr[0], pos, Quaternion.identity);
                cha = 1;
                ani.transform.LookAt(cam.transform);
                    break;
                case 1:
               case 2:
               case 3:
                ani = (GameObject)Instantiate(selectorArr[1], pos, Quaternion.identity);
                cha = 2; 
                ani.transform.LookAt(cam.transform);
                break;
            case 4:
                case 5:
                 
                case 6:
                case 7:
                case 8:
                ani = (GameObject)Instantiate(selectorArr[2], pos, Quaternion.identity);
                cha = 3;
                ani.transform.LookAt(cam.transform);
                break;
            case 9:
                  
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                    ani = (GameObject)Instantiate(selectorArr[3], pos, Quaternion.identity);
                cha = 4;
                ani.transform.LookAt(cam.transform);
                    break;


            }

    }
    Vector3 RandomCircle(Vector3 center, float radius)
    {
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.z = center.z + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.y = center.y;
        return pos;
    }
}
