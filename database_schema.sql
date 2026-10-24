-- =============================================
-- Database Schema for Personal Expense Tracker
-- Database: MSSQL / LocalDB
-- =============================================

-- 1. Users Table
CREATE TABLE users (
    id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(100) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    data_create DATETIME DEFAULT GETDATE()
);

-- 2. Categories Table
CREATE TABLE categories (
    id INT IDENTITY(1,1) PRIMARY KEY,
    category VARCHAR(100) NOT NULL,
    type VARCHAR(50) NOT NULL, -- 'Income' or 'Expense'
    status VARCHAR(50) NOT NULL, -- 'Active' or 'Inactive'
    date_insert DATETIME DEFAULT GETDATE()
);

-- 3. Income Table
CREATE TABLE income (
    id INT IDENTITY(1,1) PRIMARY KEY,
    category VARCHAR(100) NOT NULL,
    item VARCHAR(150) NOT NULL,
    income DECIMAL(18, 2) NOT NULL,
    description VARCHAR(500) NULL,
    date_income DATE NOT NULL,
    date_insert DATETIME DEFAULT GETDATE()
);

-- 4. Expenses Table
CREATE TABLE expenses (
    id INT IDENTITY(1,1) PRIMARY KEY,
    category VARCHAR(100) NOT NULL,
    item VARCHAR(150) NOT NULL,
    expense DECIMAL(18, 2) NOT NULL,
    description VARCHAR(500) NULL,
    date_expense DATE NOT NULL,
    date_insert DATETIME DEFAULT GETDATE()
);
