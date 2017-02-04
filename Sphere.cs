using UnityEngine;
using UnityEngine.UI;

public class Sphere : MonoBehaviour
{

    public Text myscore;
    int score = 20;
    public string CreateScore = "http://192.168.100.110:8080/hellounity/insertscore.php";

    public void Start()
    {
        myscore = myscore.GetComponent<Text>();
    }

    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
        // If the sphere has no Rigidbody component, add one to enable physics.
        if (!this.GetComponent<Rigidbody>())
        {
            var rigidbody = this.gameObject.AddComponent<Rigidbody>();
            rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
            myscore.text = "Youre score has changed to 20pts!";
            MyScore(score);
        }
    }

    public void MyScore(int score)
    {
        WWWForm form = new WWWForm();
        form.AddField("scorePost", score);

        WWW www = new WWW(CreateScore, form);
    }
}