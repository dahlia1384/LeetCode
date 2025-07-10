# Write your MySQL query statement below
select email as EMAIL
from PERSON
GROUP BY email
HAVING COUNT(email) >1;

