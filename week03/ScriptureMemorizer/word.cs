public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            char[] display = _text.ToCharArray();

            for (int i = 0; i < display.Length; i++)
            {
                if (char.IsLetter(display[i]))
                {
                    display[i] = '_';
                }
            }

            return new string(display);
        }

        return _text;
    }
}