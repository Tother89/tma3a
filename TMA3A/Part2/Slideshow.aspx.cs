using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Part2_Slideshow : System.Web.UI.Page
{
    private IList<Photo> photos;
    private bool IsPlaying => PlayButton.ImageUrl == "../Images/pause.png";
    private bool IsShuffleOn() => ShuffleOn.Value == "true";
    HttpCookie slideCookie = new HttpCookie("SlideCookie")
    {
        Expires = DateTime.Now.AddDays(1)
    };

    private Photo CurrentPhoto => photos.FirstOrDefault(pic => pic.Url.Equals(Image.ImageUrl, StringComparison.InvariantCultureIgnoreCase));

    protected void Page_Load(object sender, EventArgs e)
    {
        if(photos == null)
        {
            LoadPhotos();
        }
    }

    protected void Timer_Tick(object sender, EventArgs e)
    {
        if (IsPlaying)
        {
            ShowNextPhoto();
        }
    }

    private void SetShuffle(bool isShuffleOn)
    {
        ShuffleOn.Value = isShuffleOn ? "true" : "false";
    }

    private void LoadPhotos()
    {
        this.photos = SqlHandler.GetPhotosFromDb();
    }

    public void DisplayRandomPhoto()
    {
        Random random = new Random();
        int i = random.Next(photos.Count);
        Image.ImageUrl = photos[i].Url;
        CaptionLabel.Text = photos[i].Id + ". " + photos[i].Description;
    }

    private void DisplayPhoto(Photo photo)
    {
        if (photo == null)
            return;

        Image.ImageUrl = photo.Url;
        CaptionLabel.Text = (photo.Id) + ". " + photo.Description;
    }

    private void ShowNextPhoto()
    {
        if (!IsShuffleOn())
        {
            DisplayPhoto(NextPhoto());
        }
        else
        {
            DisplayRandomPhoto();
        }
    }

    private void ShowLastPhoto()
    {
        if (!IsShuffleOn())
        {
            DisplayPhoto(PreviousPhoto());
        }
        else
        {
            DisplayRandomPhoto();
        }
    }

    private Photo PreviousPhoto()
    {
        int lastIndex = CurrentPhoto.Id == 1 ? 20 : CurrentPhoto.Id - 1;
        return photos[lastIndex-1];
    }

    private Photo NextPhoto()
    {
        int nextIndex = CurrentPhoto.Id == 20 ? 1 : CurrentPhoto.Id + 1;
        return photos[nextIndex-1];
    }

    protected void PlayButton_Click(object sender, ImageClickEventArgs e)
    {
        PlayButton.ImageUrl = IsPlaying ? "../Images/play.png" : "../Images/pause.png";
    }

    protected void ShuffleButton_Click(object sender, ImageClickEventArgs e)
    {
        SetShuffle(!IsShuffleOn());

        ShuffleButton.ImageUrl = IsShuffleOn() ? "../Images/shuffleoff.png" : "../Images/shuffle.png";
    }

    protected void ForwardButton_Click(object sender, ImageClickEventArgs e)
    {
        if(!IsShuffleOn())
            ShowNextPhoto();
    }

    protected void BackButton_Click(object sender, ImageClickEventArgs e)
    {
        if (!IsShuffleOn())
            ShowLastPhoto();
    }

}