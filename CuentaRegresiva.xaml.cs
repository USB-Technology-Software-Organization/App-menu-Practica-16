using System.Diagnostics;

namespace App_menu;

public partial class CuentaRegresiva : ContentPage
{

    private readonly ProgressArc _progressArc;

    private DateTime _startTime;

    private readonly int _duration = 11;

    private double _progress;

    private CancellationTokenSource _cancellationTokenSource = new();


    /// <summary>
    /// <Createdate>10/7/2023</Createdate>
    /// <Company>USB Technology</Company>
    /// <Lastmodificationdate>10/7/2023</Lastmodificationdate>
    /// <Lastmodificationdescription>Se agrego una directiva using</Lastmodificationdescription>
    /// <Lastmodificationautor>Gael Baires</Lastmodificationautor>
    /// </summary>

    public CuentaRegresiva()

	{

		InitializeComponent();

        _progressArc = new ProgressArc();

    }
    protected override void OnAppearing()

    {

        base.OnAppearing();

        //Play icon - workaround because setting it in xaml broke the build for some reason//

        ProgressButton.Text = "\uf144";

        ProgressView.Drawable = _progressArc;

    }

    //Handle button click events//

    private void StartButton_OnClicked(object sender, EventArgs e)

    {

        _startTime = DateTime.Now;

        _cancellationTokenSource = new CancellationTokenSource();

        UpdateArc();

    }


    //Cancel the update loop//

    private void ResetButton_OnClicked(object sender, EventArgs e)

    {

        _cancellationTokenSource.Cancel();

        UpdateArc();

    }

    private async void UpdateArc()

    {

        while (!_cancellationTokenSource.Token.IsCancellationRequested)

        {

            TimeSpan elapsedTime = DateTime.Now - _startTime;

            int secondsRemaining = (int)(_duration - elapsedTime.TotalSeconds);

            ProgressButton.Text = $"{secondsRemaining}";

            _progress = Math.Ceiling(elapsedTime.TotalSeconds);

            _progress %= _duration;

            _progressArc.Progress = _progress / _duration;

            ProgressView.Invalidate();

            if (secondsRemaining == 0)

            {

                _cancellationTokenSource.Cancel();

                return;

            }

            await Task.Delay(500);

        }

        ResetView();

    }

    private void ResetView()

    {

        _progress = 0;

        _progressArc.Progress = 100;

        ProgressView.Invalidate();

        ProgressButton.Text = "\uf144";

    }

}

public class ProgressArc : IDrawable

{

    public double Progress { get; set; } = 100;

    public void Draw(ICanvas canvas, RectF dirtyRect)

    {

        //Angle of the arc in degrees//

        var endAngle = 90 - (int)Math.Round(Progress * 360, MidpointRounding.AwayFromZero);

        //Drawing code goes here//

        // canvas.StrokeColor = Color.FromRgba("6599ff");

        canvas.StrokeColor = Color.FromRgba("6599ff");

        canvas.StrokeSize = 4;

        Debug.WriteLine($"The rect width is {dirtyRect.Width} and height is {dirtyRect.Height}");

        canvas.DrawArc(5, 5, (dirtyRect.Width - 10), (dirtyRect.Height - 10), 90, endAngle, false, false);

    }

}

