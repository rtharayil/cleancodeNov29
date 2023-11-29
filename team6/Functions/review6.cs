public void CreateFile(string name, bool temp)                                                                                                                                                                                                                             public void CreateFile(string name, bool temp)
{
    temp = false;
    if (temp)
    {
        Touch("./temp/" + name);
    }
    else
    {
        Touch(name);
    }
}
