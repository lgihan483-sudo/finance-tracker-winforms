create table users(
id int primary key identity(1,1),
username varchar(MAX) null,
password varchar(MAX) null,
date_create date null
)

SELECT * FROM users

