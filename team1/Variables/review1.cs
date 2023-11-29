public bool IsShopOpen(string day)
{
    bool partyDay = false;
    if (!string.IsNullOrEmpty(day))
    {
        day = day.ToLower();
        if (day == "friday" || day == "saturday" || day == "sunday")
        {
            partyDay = true;
        }
    }
 
    return partyDay;
}