Input validation is not done when getting email.

Code checks if the institution's credit balance (institution.credit) is greater than 0 before creating the badge. 
However, it immediately decrements the credit balance after creating the badge, regardless of whether badge creation succeeds. 
This could lead to inconsistencies in credit management.

Hardcoded App Context Access : current_app._get_current_object() makes it less reusable
