public class BreathingActivity : Activity {

    public BreathingActivity(string activityName, string activityDescription) : base(activityName, activityDescription) {
    }

    public void Run(){
        DisplayStartingMessge();
        int rounds = _duration / 10;
        while (rounds > 0) {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine("Breathe out...");
            ShowCountdown(6);
            rounds--;
        }
        DisplayEndingMessage();
    }
}