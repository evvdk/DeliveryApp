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

-- ������� ��� ��������
CREATE RULE Rule_�������_Format AS @phone LIKE '+7[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]';
GO

-- ������� ��� Email
CREATE RULE Rule_Email_Format AS @email IS NULL OR @email LIKE '%@%\.%';
GO

-- ������� ��� �������� (10 ����)
CREATE RULE Rule_�������_Format AS @passport LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' AND LEN(@passport) = 10;
GO

CREATE TABLE ������ (
    ID_������� INT PRIMARY KEY,
    ����� NVARCHAR(30) UNIQUE NOT NULL,
    ������ BINARY(32) NOT NULL,
    ��� NVARCHAR(20) NOT NULL,
    ������� dbo.PhoneNumber NOT NULL,
    ��_����� VARCHAR(50),

    -- �������������� �������� �� ������ CHECK
    CONSTRAINT CHK_������_�����_Length CHECK (LEN(�����) BETWEEN 5 AND 30),
    CONSTRAINT CHK_������_���_Length CHECK (LEN(���) BETWEEN 3 AND 20)
);

CREATE TABLE �������� (
    ID_��������� INT PRIMARY KEY,
    ������� NVARCHAR(50) NOT NULL,
    ��� NVARCHAR(50) NOT NULL,
    �������� NVARCHAR(50),
    ������� dbo.PhoneNumber NOT NULL,
    ������� CHAR(10) UNIQUE NOT NULL,
    ��������_������ CHAR(7) UNIQUE NOT NULL,
    ����_�������� DATE NOT NULL,

    CONSTRAINT CHK_��������_������� CHECK (DATEDIFF(YEAR, ����_��������, GETDATE()) >= 18)
);

CREATE TABLE ������ (
    ID_������� SMALLINT PRIMARY KEY,
    �������� NVARCHAR(50) NOT NULL
);

CREATE TABLE ������ (
    ID_������� INT PRIMARY KEY,
    �������� INT NOT NULL,
    ������������ NVARCHAR(50)
);

CREATE TABLE ����� (
    ID_������ INT PRIMARY KEY,
    ����� NVARCHAR(30) NOT NULL,
    �������� INT NOT NULL,
    ������ INT NOT NULL,
    ������ SMALLINT NOT NULL,
    �����_������ DATETIME DEFAULT GETDATE(),
    �����_����������_������ DATETIME,

    FOREIGN KEY (�����) REFERENCES ������(�����),
    FOREIGN KEY (��������) REFERENCES ��������(ID_���������),
    FOREIGN KEY (������) REFERENCES ������(ID_�������),
    FOREIGN KEY (������) REFERENCES ������(ID_�������)
);

CREATE TABLE ��������� (
    ID_���������� INT PRIMARY KEY,
    �������� NVARCHAR(50) NOT NULL,
    ������� dbo.PhoneNumber NOT NULL,
    �������_��������� NVARCHAR(30),
    ���_��������� NVARCHAR(30),
    ��������_��������� NVARCHAR(30),
    ��_����� VARCHAR(50)
);

CREATE TABLE ���� (
    �������� NVARCHAR(30) PRIMARY KEY,
    ���� MONEY NOT NULL,
    �������� NVARCHAR(100),
    ������������ INT,
    ����� INT
);

CREATE TABLE ����������� (
    ID_����������� INT PRIMARY KEY,
    �������� NVARCHAR(30) NOT NULL,
    ���������� INT DEFAULT 0,
    �������_��������� NVARCHAR(10),
    ��������� INT,
    ����_������� MONEY,

    FOREIGN KEY (���������) REFERENCES ���������(ID_����������)
);

CREATE TABLE ����_����������� (
    ID_����������� INT NOT NULL,
    ��������_����� NVARCHAR(30) NOT NULL,
    ���������� INT NOT NULL,

    PRIMARY KEY (ID_�����������, ��������_�����),
    FOREIGN KEY (ID_�����������) REFERENCES �����������(ID_�����������),
    FOREIGN KEY (��������_�����) REFERENCES ����(��������)
);

CREATE TABLE ���������_�������� (
    ID_����������� INT NOT NULL,
    ID_��������� INT NOT NULL,
    ����_�_����� DATETIME DEFAULT GETDATE(),
    ��������� INT NOT NULL,

    PRIMARY KEY (ID_�����������, ID_���������, ����_�_�����),
    FOREIGN KEY (ID_�����������) REFERENCES �����������(ID_�����������),
    FOREIGN KEY (ID_���������) REFERENCES ��������(ID_���������)
);

CREATE TABLE ����� (
    �����_����� INT PRIMARY KEY,
    �����_������ TIME NOT NULL,
    �����_��������� TIME NOT NULL,
    ������_�_��� MONEY NOT NULL
);

CREATE TABLE ������_������ (
    ID_��������� INT NOT NULL,
    �����_����� INT NOT NULL,

    PRIMARY KEY (ID_���������, �����_�����),
    FOREIGN KEY (ID_���������) REFERENCES ��������(ID_���������),
    FOREIGN KEY (�����_�����) REFERENCES �����(�����_�����)
);

CREATE TABLE ������_������ (
    ID_������ INT NOT NULL,
    ��������_����� NVARCHAR(30) NOT NULL,
    ���������� INT NOT NULL,

    PRIMARY KEY (ID_������, ��������_�����),
    FOREIGN KEY (ID_������) REFERENCES �����(ID_������),
    FOREIGN KEY (��������_�����) REFERENCES ����(��������)
);

-- �������� � ������� ������
EXEC sp_bindrule 'Rule_�������_Format', '������.�������';
EXEC sp_bindrule 'Rule_Email_Format', '������.��_�����';

-- �������� � ������� ��������
EXEC sp_bindrule 'Rule_�������_Format', '��������.�������';
EXEC sp_bindrule 'Rule_�������_Format', '��������.�������';

-- �������� � ������� ���������
EXEC sp_bindrule 'Rule_�������_Format', '���������.�������';
EXEC sp_bindrule 'Rule_Email_Format', '���������.��_�����';
