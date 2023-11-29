public void CreateFile(string fileName, bool createInTemp = false)
{
    if (createInTemp)
    {
        Touch("./temp/" + fileName);
    }
    else
    {
        Touch(fileName);
    }
}