--Aşağıdaki sorgu senaryolarını dvdrental örnek veri tabanı üzerinden gerçekleştiriniz.

--1 city tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz LEFT JOIN sorgusunu yazınız.
SELECT ci.city, co.country FROM city AS ci
LEFT JOIN country AS co
ON ci.country_id = co.country_id;

--2 customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz RIGHT JOIN sorgusunu yazınız.
SELECT p.payment_id, c.first_name, c.last_name FROM customer AS c
RIGHT JOIN payment AS p
ON c.customer_id = p.customer_id;

--3 customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz FULL JOIN sorgusunu yazınız.
SELECT r.rental_id, c.first_name, c.last_name FROM customer AS c
FULL JOIN rental AS r
ON c.customer_id = r.customer_id;