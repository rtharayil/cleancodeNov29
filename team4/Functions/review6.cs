public void CreateFile(string fileName, bool temp = false)
{
    if (temp)
    {
        Touch("./temp/" + fileName);
    }
    else
    {
        Touch(fileName);
    }
}
