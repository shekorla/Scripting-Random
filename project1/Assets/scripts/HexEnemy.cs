using UnityEngine;

public class HexEnemy : MonoBehaviour
{
    
    public float timerL, timerR,resetVal,moveSpeed;
    public Vector3 post;

    private void Start()
    {
        timerL = resetVal;
        timerR = resetVal;
        post = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerL > 0)
        {
            post.x += -moveSpeed;
            timerL += -1; //* Time.deltaTime;
        }
        else
        {
            post.x += moveSpeed;
            timerR += -1;// * Time.deltaTime;
        }

        if (timerL==0&&timerR==0)
        {
            timerL = resetVal;
            timerR = resetVal;
        }

        gameObject.transform.position = post;
    }
}
