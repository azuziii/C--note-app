internal class Item
{
    private readonly string _title;
    private readonly int _id;

    public Item(string newTitle, int newId)
    {
        _title = newTitle;
        _id = newId;
    }

    public string Title
    {
        get
        {
            return _title;
        }
    }

    public int Id
    {
        get
        {
            return _id;
        }
    }
}
