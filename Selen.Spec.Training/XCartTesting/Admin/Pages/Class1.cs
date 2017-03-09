
public class Rootobject
{
    public string schema { get; set; }
    public Control[] controls { get; set; }
    public string pageName { get; set; }
    public string title { get; set; }
    public string url { get; set; }
}

public class Control
{
    public string controlName { get; set; }
    public string controlType { get; set; }
    public string by { get; set; }
    public string value { get; set; }
}
