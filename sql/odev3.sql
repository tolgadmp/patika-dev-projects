SELECT * FROM country wHERE country LIKE 'A%a';

SELECT * FROM country wHERE country LIKE '%____n';

SELECT * FROM film wHERE title ILIKE '%T%T%T%T';

SELECT * FROM film wHERE title LIKE 'C%' AND length > 90 AND rental_rate = 2.99;