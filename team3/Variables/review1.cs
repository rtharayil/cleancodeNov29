public bool IsShopOpen(string day)
{
    if (!string.IsNullOrEmpty(day))
    {
        day = day.ToLower();

        
        if (day == "friday" || day == "saturday" || day == "sunday")
        {
            return true;
        }

    }
    else
    {
        print("Day is Null")
    }

        return false;
}