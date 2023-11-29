public void CreateFile(string name, bool temp = false)
{
    string path = temp?"./temp/" + name: name;
    Touch(path);
}