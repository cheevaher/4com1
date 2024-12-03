CREATE TABLE clients (
    id INT NOT NULL PRIMARY KEY IDENTITY,
    firstname NVARCHAR(100) NOT NULL,
    lastname NVARCHAR(100) NOT NULL,
    email NVARCHAR(150) NOT NULL UNIQUE,
    phone NVARCHAR(20) NOT NULL,
    address NVARCHAR(255) NOT NULL,
    created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
);

INSERT INTO clients (firstname, lastname, email, phone, address)
VALUES
('Bill', 'Grant', 'bill@gmail.com', '+123456789', 'New York, USA'),
('John', 'Smith', 'john@gmail.com', '+122233344', 'Florida, USA'),
('Andrew', 'Belli', 'andrew@gmail.com', '+147845678', 'California, USA');
