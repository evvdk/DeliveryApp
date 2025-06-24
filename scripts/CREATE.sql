USE master
CREATE DATABASE kr
ON
(NAME = 'Delivery',FILENAME = 'C:\Databases\kr.mdf',SIZE = 1,MAXSIZE = 10,FILEGROWTH = 1)
LOG ON
(NAME = 'Delivery_log',FILENAME = 'C:\Databases\kr_log.ldf',SIZE = 1,MAXSIZE = 5,FILEGROWTH = 1)
GO

USE kr
GO
CREATE TYPE PhoneNumber FROM CHAR(12);
GO

-- Правило для телефона
CREATE RULE Rule_Телефон_Format AS @phone LIKE '+7[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]';
GO

-- Правило для Email
CREATE RULE Rule_Email_Format AS @email IS NULL OR @email LIKE '%@%\.%';
GO

-- Правило для Паспорта (10 цифр)
CREATE RULE Rule_Паспорт_Format AS @passport LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' AND LEN(@passport) = 10;
GO

CREATE TABLE Клиент (
    ID_клиента INT PRIMARY KEY,
    Логин NVARCHAR(30) UNIQUE NOT NULL,
    Пароль BINARY(32) NOT NULL,
    Имя NVARCHAR(20) NOT NULL,
    Телефон dbo.PhoneNumber NOT NULL,
    Эл_почта VARCHAR(50),

    -- Дополнительные проверки на уровне CHECK
    CONSTRAINT CHK_Клиент_Логин_Length CHECK (LEN(Логин) BETWEEN 5 AND 30),
    CONSTRAINT CHK_Клиент_Имя_Length CHECK (LEN(Имя) BETWEEN 3 AND 20)
);

CREATE TABLE Персонал (
    ID_работника INT PRIMARY KEY,
    Фамилия NVARCHAR(50) NOT NULL,
    Имя NVARCHAR(50) NOT NULL,
    Отчество NVARCHAR(50),
    Телефон dbo.PhoneNumber NOT NULL,
    Паспорт CHAR(10) UNIQUE NOT NULL,
    Трудовая_книжка CHAR(7) UNIQUE NOT NULL,
    Дата_рождения DATE NOT NULL,

    CONSTRAINT CHK_Персонал_Возраст CHECK (DATEDIFF(YEAR, Дата_рождения, GETDATE()) >= 18)
);

CREATE TABLE Статус (
    ID_статуса SMALLINT PRIMARY KEY,
    Значение NVARCHAR(50) NOT NULL
);

CREATE TABLE Столик (
    ID_столика INT PRIMARY KEY,
    Значение INT NOT NULL,
    Расположение NVARCHAR(50)
);

CREATE TABLE Заказ (
    ID_заказа INT PRIMARY KEY,
    Логин NVARCHAR(30) NOT NULL,
    Официант INT NOT NULL,
    Столик INT NOT NULL,
    Статус SMALLINT NOT NULL,
    Время_заказа DATETIME DEFAULT GETDATE(),
    Время_завершения_заказа DATETIME,

    FOREIGN KEY (Логин) REFERENCES Клиент(Логин),
    FOREIGN KEY (Официант) REFERENCES Персонал(ID_работника),
    FOREIGN KEY (Столик) REFERENCES Столик(ID_столика),
    FOREIGN KEY (Статус) REFERENCES Статус(ID_статуса)
);

CREATE TABLE Поставщик (
    ID_поставщика INT PRIMARY KEY,
    Название NVARCHAR(50) NOT NULL,
    Телефон dbo.PhoneNumber NOT NULL,
    Фамилия_директора NVARCHAR(30),
    Имя_директора NVARCHAR(30),
    Отчество_директора NVARCHAR(30),
    Эл_почта VARCHAR(50)
);

CREATE TABLE Меню (
    Название NVARCHAR(30) PRIMARY KEY,
    Цена MONEY NOT NULL,
    Описание NVARCHAR(100),
    Калорийность INT,
    Масса INT
);

CREATE TABLE Ингредиенты (
    ID_ингредиента INT PRIMARY KEY,
    Название NVARCHAR(30) NOT NULL,
    Количество INT DEFAULT 0,
    Единица_измерения NVARCHAR(10),
    Поставщик INT,
    Цена_закупки MONEY,

    FOREIGN KEY (Поставщик) REFERENCES Поставщик(ID_поставщика)
);

CREATE TABLE Меню_Ингредиенты (
    ID_ингредиента INT NOT NULL,
    Название_блюда NVARCHAR(30) NOT NULL,
    Количество INT NOT NULL,

    PRIMARY KEY (ID_ингредиента, Название_блюда),
    FOREIGN KEY (ID_ингредиента) REFERENCES Ингредиенты(ID_ингредиента),
    FOREIGN KEY (Название_блюда) REFERENCES Меню(Название)
);

CREATE TABLE Складские_операции (
    ID_ингредиента INT NOT NULL,
    ID_работника INT NOT NULL,
    Дата_и_время DATETIME DEFAULT GETDATE(),
    Изменение INT NOT NULL,

    PRIMARY KEY (ID_ингредиента, ID_работника, Дата_и_время),
    FOREIGN KEY (ID_ингредиента) REFERENCES Ингредиенты(ID_ингредиента),
    FOREIGN KEY (ID_работника) REFERENCES Персонал(ID_работника)
);

CREATE TABLE Смена (
    Номер_смены INT PRIMARY KEY,
    Время_начала TIME NOT NULL,
    Время_окончания TIME NOT NULL,
    Оплата_в_час MONEY NOT NULL
);

CREATE TABLE График_работы (
    ID_работника INT NOT NULL,
    Номер_смены INT NOT NULL,

    PRIMARY KEY (ID_работника, Номер_смены),
    FOREIGN KEY (ID_работника) REFERENCES Персонал(ID_работника),
    FOREIGN KEY (Номер_смены) REFERENCES Смена(Номер_смены)
);

CREATE TABLE Состав_заказа (
    ID_заказа INT NOT NULL,
    Название_блюда NVARCHAR(30) NOT NULL,
    Количество INT NOT NULL,

    PRIMARY KEY (ID_заказа, Название_блюда),
    FOREIGN KEY (ID_заказа) REFERENCES Заказ(ID_заказа),
    FOREIGN KEY (Название_блюда) REFERENCES Меню(Название)
);

-- Привязка к таблице Клиент
EXEC sp_bindrule 'Rule_Телефон_Format', 'Клиент.Телефон';
EXEC sp_bindrule 'Rule_Email_Format', 'Клиент.Эл_почта';

-- Привязка к таблице Персонал
EXEC sp_bindrule 'Rule_Телефон_Format', 'Персонал.Телефон';
EXEC sp_bindrule 'Rule_Паспорт_Format', 'Персонал.Паспорт';

-- Привязка к таблице Поставщик
EXEC sp_bindrule 'Rule_Телефон_Format', 'Поставщик.Телефон';
EXEC sp_bindrule 'Rule_Email_Format', 'Поставщик.Эл_почта';
