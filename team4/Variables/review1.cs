public bool IsShopOpen(string day)
{
  day = day.ToLower();
  if(!string.IsNullorEmpty(day))
  {
    if(day=="friday" || day=="saturday" || day=="sunday")
    {
      return true;
    }
    else
    {
      return false;
    }
  }
  else
  {
    return false;
  }
}
