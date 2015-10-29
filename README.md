# ImageButton
ImageButton for Xamarin.Forms which allows to set just the image for the button without text.

On Xamarin.Forms the default Button class doesn't allow to have a button with just image, without text. Even if there is no text the image is always aligned to the left and from the right side extra padding is added. XLabs has an awesome ImageButton class, which is perfect for button which have image and text, but again it's custom renderer is derived from default ButtonRenderer and thus it has the same problem. So I decided to create a minimal button with custom renderer which will allow to just have button with image. I've used some code portions from XLabs', so thanks XLabs' team for your efforts.
For now the ImageButton has 4 Bindable properties
  - Command - command to execute when button is clicked
  - Image - default image
  - SelectedImage - image for selected state
  - IsSelected - to toggle button to selected state.

I've included sample in the repo. Have a look, and be free to fork and add more functionality. I believe this will be a good starting point.