CREATE TABLE categories (
id INT PRIMARY KEY IDENTITY(1,1),
category VARCHAR(MAX) NULL,
type VARCHAR(MAX) NULL,
status VARCHAR(MAX) NULL,
date_insert DATE NULL
)

SELECT * FROM categories

CREATE TABLE income(
id int PRIMARY KEY IDENTITY(1,1),
category VARCHAR(MAX) NULL,
item VARCHAR (MAX) NULL,
income FLOAT NULL,
description TEXT NULL,
date_income DATE NULL,
date_insert DATE NULL
)
SELECT * FROM income

CREATE TABLE expenses(
id int PRIMARY KEY IDENTITY(1,1),
category VARCHAR(MAX) NULL,
item VARCHAR (MAX) NULL,
expense FLOAT NULL,
description VARCHAR (MAX) NULL,
date_expense DATE NULL,
date_insert DATE NULL
)
SELECT * FROM expenses

