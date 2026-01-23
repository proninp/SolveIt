SELECT SUM(price * items) income_from_female
FROM purchases
WHERE user_gender = 'female' OR user_gender = 'f'